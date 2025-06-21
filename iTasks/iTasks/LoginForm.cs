using iTasks.controller;
using iTasks.Migrations;
using iTasks.models;
using iTasks.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Load += LoginForm_Load;
        }

        /* ---------- Carregamento de Dados  ---------- */

        // Carrega o nome de utilizador e a palavra-passe desencriptada, se existirem os ficheiros
        private (string username, string password)? LoadCredentials()
        {
            try
            {
                // Verifica se os ficheiros existem
                if (File.Exists("username.dat") && File.Exists("password.dat"))
                {
                    // Lê o username
                    string username = File.ReadAllText("username.dat");

                    // Lê e desencripta a palavra-passe
                    byte[] encryptedPassword = File.ReadAllBytes("password.dat");
                    byte[] decryptedPassword = ProtectedData.Unprotect(encryptedPassword, null, DataProtectionScope.CurrentUser);
                    string password = Encoding.UTF8.GetString(decryptedPassword);

                    return (username, password);
                }
            }
            catch
            {
                // Silenciosamente ignora erros
            }

            return null;
        }
        
        // Apaga os ficheiros que armazenam o nome de utilizador e a palavra-passe guardados
        private void ClearSavedCredentials()
        {
            try
            {
                // Verifica se o ficheiro onde esta guardado o nome do utilizador e a palavra-passe
                if (File.Exists("username.dat")) File.Delete("username.dat");   // Se existir, apaga-o
                if (File.Exists("password.dat")) File.Delete("password.dat");   // Se existir, apaga-o
            }
            catch
            {
                // Em caso de erro, a exceção é ignorada silenciosamente
            }
        }


        // Funcoes para confirmar se ja existe um ultizador
        private bool UsersExist()
        {
            try
            {
                // Abre uma ligação a base de dados
                using (var db = new iTasksContext())
                {
                   // Verifica se existe algum registo na tabela Users
                    return db.Users.Any();
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, mostra uma mensagem ao utilizador
                MessageBox.Show("Erro ao aceder à base de dados: " + ex.Message);
                return false; // Retorna false se ocorrer uma exceção
            }
        }

        // Evento que executado quando o formulario de login é carregado
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Verifica se já existem utilizadores registados na base de dados
            if (UsersExist())
            {
                // Se existirem  utilizadores, mostra o painel de login
                Pl_Login.Visible = true;
                // Esconde o painel de registo
                Pl_Register.Visible = false;

                // Tenta carregar credenciais guadadas anteriormente (se esistirem)
                var credenciais = LoadCredentials();
                if (credenciais.HasValue)
                {
                    tb_Username.Text = credenciais.Value.username;  // Preenche automaticamente o campo do nome utilizador com o valor guardado
                    tb_Username.ForeColor = Color.Black;            // Define a cor do texto como preto (em vez do cinzento do placeholder)

                    tb_Password.Text = credenciais.Value.password;  // Preenche o campo da palavra-passe com a palavra-passe recuperada
                    tb_Password.UseSystemPasswordChar = true;       // Mostra os caracteres como "•" (modo de palavra-passe)
                    tb_Password.ForeColor = Color.Black;

                    ts_RememberMe.Checked = true;                   // Marca a ToggleSwitch "Lembra-me como ativa"
                }
            }
            else
            {
                // Se não existirem utilizadores, esconde o painel de login
                Pl_Login.Visible = false;
                // Mostra o painel de registo, Permitindo a criação do primeiro utilizador
                Pl_Register.Visible = true;
            }
        }


        /* ---------- Painel Register  ---------- */

        // Evento quando o campo "Nome" recebe foco (o utilizador clica ou navega até ele)
        private void tb_CreateName_Enter(object sender, EventArgs e)
        {
            // Se o texto for o texto padrão (placeholder)
            if (tb_CreateName.Text == "Nome")
            {
                tb_CreateName.Text = "";                    // Limpa o campo
                tb_CreateName.ForeColor = Color.Black;      // Altera a cor do texto para preto (modo de edição)
            }
        }
        // Evento quando o campo "Nome" perde o foco (o utilizador sai do campo)
        private void tb_CreateName_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio
            if (tb_CreateName.Text == "")
            {
                tb_CreateName.Text = "Nome";                // Restaura o texto padrão
                tb_CreateName.ForeColor = Color.Silver;     // Define cor cinzenta para indicar placeholder
            }
        }

        // Entrada no campo "Utilizador"
        private void tb_CreateUsername_Enter(object sender, EventArgs e)
        {
            // Se o texto for o texto padrão (placeholder)
            if (tb_CreateUsername.Text == "Utilizador")
            {
                tb_CreateUsername.Text = "";                // Limpa o campo
                tb_CreateUsername.ForeColor = Color.Black;  // Altera a cor do texto para preto (modo de edição)
            }
        }
        // Saida do campo "Utilizador"
        private void tb_CreateUsername_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio
            if (tb_CreateUsername.Text == "")
            {
                tb_CreateUsername.Text = "Utilizador";      // Restaura o texto padrão
                tb_CreateUsername.ForeColor = Color.Silver; // Define cor cinzenta para indicar placeholder
            }
        }

        // Entrada no campo "Senha"
        private void tb_CreatePassword_Enter(object sender, EventArgs e)
        {
            // Se o texto for o texto padrão (placeholder)
            if (tb_CreatePassword.Text == "Senha")
            {
                tb_CreatePassword.Text = "";                        // Limpa o texto
                tb_CreatePassword.UseSystemPasswordChar = true;     // Ativa o modo oculto (•••)
                tb_CreatePassword.ForeColor = Color.Black;          // Cor de texto real
            }
        }
        // Saida do campo "Senha"
        private void tb_CreatePassword_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio
            if (tb_CreatePassword.Text == "")
            {
                tb_CreatePassword.Text = "Senha";                   // Restaura texto padrão
                tb_CreatePassword.UseSystemPasswordChar = false;    // Mostra texto normalmente (sem •)
                tb_CreatePassword.ForeColor = Color.Silver;         // Cor cinzenta para placeholder
            }
        }

        // Entrada no campo "Confirmar Senha"
        private void tb_CreateConfirmPassword_Enter(object sender, EventArgs e)
        {
            // Se o texto for o texto padrão (placeholder)
            if (tb_CreateConfirmPassword.Text == "Confirmar Senha")
            {
                tb_CreateConfirmPassword.Text = "";                         // Limpa texto
                tb_CreateConfirmPassword.UseSystemPasswordChar = true;      // Oculta os caracteres
                tb_CreateConfirmPassword.ForeColor = Color.Black;           // Texto real
            }
        }
        // Saida do campo "Confirmar Senha"
        private void tb_CreateConfirmPassword_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio
            if (tb_CreateConfirmPassword.Text == "")
            {
                tb_CreateConfirmPassword.Text = "Confirmar Senha";          // Texto padrão
                tb_CreateConfirmPassword.UseSystemPasswordChar = false;     // Mostra texto normal
                tb_CreateConfirmPassword.ForeColor = Color.Silver;          // Texto cinzento (placeholder)
            }
        }


        // Metodo que faz hash da palavra-passe com SHA-256
        private string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);    // Converte a palavra-passe para bytes
                byte[] hash = sha256.ComputeHash(bytes);            // Calcula o hash
                StringBuilder result = new StringBuilder();         // Prepara para converter os bytes em string

                foreach (byte b in hash)
                    result.Append(b.ToString("x2"));                // Converrte cada byte em hexadecimal

                return result.ToString();                           // Retorna a palavra-passe com hash
            }
        }

        // Botão Register
        private void bt_Register_Click(object sender, EventArgs e)
        {
            // Captura os valores dos campos de texto do formulario
            string Name = tb_CreateName.Text;
            string Username = tb_CreateUsername.Text;
            string Password = tb_CreatePassword.Text;
            string ConfirmPassword = tb_CreateConfirmPassword.Text;

            // Validação: verifica se as senhas coincidem
            if(Password != ConfirmPassword)
            {
                MessageBox.Show("As senhas não coincidem.");        // Mostra mensagem de aviso
                return;                                             // Interrompe a execução do metedo
            }

            // Cria uma instancia do contexto da base de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Cria um novo objeto de utilizador do tipo (Maneger)
                    var newUser = new Maneger()
                    {
                        Name = Name,                                // Nome do utilizador
                        Username = Username,                        // Nome de utilizador (login)
                        Password = HashPasswordSHA256(Password),    // Palavra-passe encriptada com SHA-256
                        Department = Department.Administração,      // Atribui o departamento "Administração"
                        GenerateUser = "True"                       // Marca como utilizador gerado automaticamente
                    };

                    // Adiciona o novo utilizador a base de dados
                    db.Users.Add(newUser);
                    db.SaveChanges();

                    // Esconde o painel de registo e mostra o painel de login
                    Pl_Register.Visible = false;
                    Pl_Login.Visible = true;
                }
                catch
                {
                    // Caso ocorra um erro ao aceder a base de dados, mostra uma mensagem de erro
                    MessageBox.Show("Não Foi Possivel Aceder a Base de Dados");
                    return;
                }
            }
        }
        

        /* ---------- Painel Login  ---------- */

        // Entrada no campo "Utilizador"
        private void tb_Username_Enter(object sender, EventArgs e)
        {
            // Se o texto for o texto padrão (placeholder)
            if (tb_Username.Text == "Utilizador")
            {
                tb_Username.Text = "";                      // Limpa o campo
                tb_Username.ForeColor = Color.Black;        // Muda a cor do texto para preto (modo de escrita)
            }
        }
        // Saida do campo "Utilizador"
        private void tb_Username_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Utilizador";            // Texto padrão
                tb_Username.ForeColor = Color.Silver;       // Mudar a cor para cinzento (modo de placeholder)
            }
        }

        // Entrada no campo "Senha"
        private void tb_Password_Enter(object sender, EventArgs e)
        {
            // Se o texto for o texto padrão (placeholder)
            if (tb_Password.Text == "Senha")
            {
                tb_Password.Text = "";                      // Limpa o campo
                tb_Password.UseSystemPasswordChar = true;   // Oculta os caracteres
                tb_Password.ForeColor = Color.Black;        // Muda a cor do texto para preto (modo de escrita)
            }
        }
        // Saida do campo "Senha"
        private void tb_Password_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Senha";                 // Texto padrão
                tb_Password.UseSystemPasswordChar = false;  // Mostra texto normal
                tb_Password.ForeColor = Color.Silver;       // Mudar a cor para cinzento (modo de placeholder)
            }
        }


        // Guarda o nome de utilizador e a palavra-passe encriptada em ficheiros locais.
        private void SaveCredentials(string username, string password)
        {
            try
            {
                // Guarda o username em texto simples
                File.WriteAllText("username.dat", username);

                // encripta a palavra e guarda-a em ficheiro
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] encryptedPassword = ProtectedData.Protect(passwordBytes, null, DataProtectionScope.CurrentUser);
                File.WriteAllBytes("password.dat", encryptedPassword);
            }
            catch
            {
                // Mostra erro caso não seja possivel guardar as credenciais
                MessageBox.Show("Erro ao guardar as credenciais.");
            }
        }


        // Fecho o formulário principal (LoginForm) 
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        // Botão Login
        private void bt_Login_Click(object sender, EventArgs e)
        {
            // Obtém os valores introduzidos nos campos de texto
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            // Validação: confirma se no campo ainda contem os placeholders
            if(username == "Utilizadores" || password == "Senha")
            {
                // Mostra uma mensagem de erro e interrompe o processo de login
                MessageBox.Show("Todos os campos são de prencimento obrigadorio.");
                return;
            }

            // Aplica a função de hash SHA-256 a palavra-passe introduzida
            string hashedPassword = HashPasswordSHA256(password);
            
            // Abre uma ligação ao contexto da base de dados
            using(var db = new iTasksContext())
            {   
                // Procura o utilizador com o nome de utilizador inntroduzido
                var utilizador = db.Users.FirstOrDefault(x => x.Username == username);

                // Verifica se o utilizador existe e se a palavra-passe (já com hash) corresponde
                if (utilizador != null && utilizador.Password == hashedPassword)
                {
                    // Se a opção "Relembrar" estiver ativa, guarda as credenciais
                    if (ts_RememberMe.Checked)
                        SaveCredentials(username, password); // Guarda username e password (encriptada)
                    else
                        ClearSavedCredentials();           // Remove credenciais guadadas anteriormente

                    // Inicia a sessão do utilizador atraves do sessionManager
                    sessionManager.Login(utilizador);

                    // Cria e abre o formulario da pagina inicial (HomePage)
                    HomePageForm homePage = new HomePageForm();

                    Hide();                                     // esconde o formulario de login atual
                    homePage.FormClosed += Closed_FormClosed;   // Garante que, ao fechar o formulario da (HomePage), a aplicação encerra ou volta atras correntamente
                    homePage.ShowDialog();                      // Mostra o formulario da (HomePage) como janela principal
                }
                else
                {
                    // Mostra mensagem de erro caso as credenciais estejam incorretas
                    MessageBox.Show("Username ou Password incorretos.");
                }
            } 
        }   
    }
}
