using iTasks.Migrations;
using iTasks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using iTasks.controller;

namespace iTasks.views
{
    public partial class UserManagementForm : Form
    {
        private Maneger SelectedManeger;        // Gestor atualmente selecionada
        private Programmer SelectedProgrammer;  // Programador atualmente selecionada
        public UserManagementForm()
        {
            InitializeComponent();
            VerifyUsers();
            SearchProgrammerAndManagers();
            EnumValues();
        }

        /* ---------- Funções de Inicialização  ---------- */
        // Método privado para verificar permissões do utilizador atual
        private void VerifyUsers()
        {
            // Verifica se o utilizador atual está definido no SessionManager
            if (sessionManager.CurrentUser == null)
            {
                // Mostra uma mensagem de erro se não houver utilizador na sessão
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return; // Encerra a execução do método
            }

            // Obtém o utilizador atual da sessão
            var currentUser = sessionManager.CurrentUser;

            // Verifica se o utilizador é um objeto do tipo 'Maneger'
            if (currentUser is Maneger maneger)
            {
                // Verifica se a propriedade 'GenerateUser' está definida como "false" (ignorando maiúsculas/minúsculas)
                if (string.Equals(maneger.GenerateUser, "false", StringComparison.OrdinalIgnoreCase))
                {
                    // Oculta os botões de criação, pesquisa, edição e eliminação
                    b_Create.Visible = false;
                    b_Search.Visible = false;
                    b_Edit.Visible = false;
                    b_Delete.Visible = false;

                    // Desativa os campos de entrada de texto
                    tb_Name.Enabled = false;
                    tb_Username.Enabled = false;
                    tb_Password.Enabled = false;

                    // Desativa os campos de seleção de nível de experiência e departamento
                    cb_ExperienceLevel.Enabled = false;
                    cb_Department.Enabled = false;

                    // Desativa o campo com o nome de utilizador do gestor
                    ts_ManegerUsername.Enabled = false;
                }
            }
        }
        // Método responsável por preencher as ComboBoxes com os valores dos enums e dados auxiliares
        private void EnumValues()
        {
            // Preenche a ComboBox do Nível de Experiência com os valores do enum ExperienceLevel
            cb_ExperienceLevel.DataSource = Enum.GetValues(typeof(ExperienceLevel)).Cast<ExperienceLevel>().ToList();
            // Nenhum item será selecionado inicialmente
            cb_ExperienceLevel.SelectedIndex = -1;

            // Preenche a ComboBox dos gestores chamando um método auxiliar
            ListGestor();

            // Preenche a ComboBox do Departamento com os valores do enum Department
            cb_Department.DataSource = Enum.GetValues(typeof(Department)).Cast<Department>().ToList();
            // Nenhum item será selecionado inicialmente
            cb_Department.SelectedIndex = -1;
        }
        // Método que carrega os gestores da base de dados e os insere na ComboBox cb_Maneger
        private void ListGestor()
        {
            try
            {
                // Cria uma nova instância do contexto da base de dados (iTasksContext)
                using (var db = new iTasksContext())
                {
                    // Obtém todos os utilizadores do tipo "Maneger" (Gestores) da base de dados
                    var gestor = db.Users.OfType<Maneger>().ToList();

                    
                    cb_Maneger.DataSource = gestor;     // Define a lista de gestores como fonte de dados da ComboBox cb_Maneger
                    cb_Maneger.DisplayMember = "Name";  // Exibe o nome do gestor na ComboBox
                    cb_Maneger.ValueMember = "Id";      // Usa o Id do gestor como valor interno da ComboBox
                    cb_Maneger.SelectedIndex = -1;      // Garante que nenhum item esteja selecionado inicialmente
                }
            }
            catch
            {
                // Em caso de erro ao carregar os gestores, exibe uma mensagem na ComboBox
                cb_Maneger.Text = "Erro ao carregar Gestor!";
            }
        }


        /* --------- Funções do Layout ---------- */
        // Função que limpa e redefine os campos do formulário de utilizador
        private void clearText()
        {
            // Redefine o campo ID para o texto "ID" (provavelmente desativado ou apenas informativo)
            tb_Id.Text = "ID";

            // Redefine o campo Nome com texto padrão e cor prateada (indica texto de exemplo)
            tb_Name.Text = "Nome";
            tb_Name.ForeColor = Color.Silver;

            // Redefine o campo Utilizador com texto padrão e cor prateada
            tb_Username.Text = "Utilizador";
            tb_Username.ForeColor = Color.Silver;

            // Redefine o campo Senha com texto padrão, cor prateada e desativa a ocultação da senha
            tb_Password.Text = "Senha";
            tb_Password.ForeColor = Color.Silver;
            tb_Password.UseSystemPasswordChar = false;

            // Remove a seleção nas ComboBoxes
            cb_ExperienceLevel.SelectedIndex = -1;
            cb_Maneger.SelectedIndex = -1;
            cb_Department.SelectedIndex = -1;

            // Desmarca o switch (ou CheckBox) que indica se o utilizador é gestor
            ts_ManegerUsername.Checked = false;
        }
        // Evento chamado quando o estado da CheckBox "Programmer" (cb_SelecProgrammer) é alterado
        private void cb_Programmer_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se a CheckBox dos programadores foi marcada
            if (cb_SelecProgrammer.Checked)
            {
                // Limpa todos os campos do formulário
                clearText();

                
                lb_Users.DataSource = null;         // Limpa a listBox de utilizadores
                cb_SelecManeger.Checked = false;    // Desmarca a CheckBox dos gestores (se estiver marcada)
                p_Manager.Visible = false;          // Esconde o painel dos gestores
                p_Programmer.Visible = true;        // Mostra o painel dos programadores
                SearchProgrammerAndManagers();      // Executa a função que atualiza a lista de programadores e gestores
            }
            // Se a CheckBox dos programadores for desmarcada:
            else
            {
                clearText();                        // Limpa os campos do formulário
                SearchProgrammerAndManagers();      // Atualiza a lista (pode mostrar todos os utilizadores, ou resetar filtros)
                p_Programmer.Visible = false;       // Esconde o painel dos programadores
            }
        }
        // Evento acionado quando o estado da CheckBox dos gestores (cb_SelecManeger) é alterado
        private void cb_Manager_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se a CheckBox dos gestores foi marcada
            if (cb_SelecManeger.Checked)
            {
                
                clearText();                        // Limpa os campos do formulário
                lb_Users.DataSource = null;         // Limpa a listBox de utilizadores
                cb_SelecProgrammer.Checked = false; // Desmarca a CheckBox dos programadores, caso esteja selecionada
                p_Programmer.Visible = false;       // Esconde o painel dos programadores
                p_Manager.Visible = true;           // Mostra o painel dos gestores
                SearchProgrammerAndManagers();      // Atualiza a lista de utilizadores (filtrando ou recarregando conforme necessário)
            }
            // Se a CheckBox dos gestores for desmarcada:
            else
            {
                clearText();                        // Limpa os campos do formulário
                SearchProgrammerAndManagers();      // Atualiza a lista de utilizadores (removendo filtro de gestores)
                p_Manager.Visible = false;          // Esconde o painel dos gestores
            }
        }

        /* ======== TextBox: Nome ======== */
        // Evento ativado ao entrar no campo "Nome"
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            // Se o texto atual for o placeholder "Nome", limpa o campo
            if (tb_Name.Text == "Nome")
            {
                tb_Name.Text = "";                   // Limpa o texto
                tb_Name.ForeColor = Color.Black;     // Define a cor do texto como preta
            }
        }
        // Evento ativado ao sair do campo "Nome"
        private void tb_Name_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio, redefine o placeholder
            if (tb_Name.Text == "")
            {
                tb_Name.Text = "Nome";               // Repõe o texto padrão
                tb_Name.ForeColor = Color.Silver;    // Define a cor como cinzento (placeholder)
            }
        }

        /* ======== TextBox: Utilizador ======== */
        // Evento ativado ao entrar no campo "Utilizador"
        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Utilizador")
            {
                tb_Username.Text = "";
                tb_Username.ForeColor = Color.Black;
            }
        }
        // Evento ativado ao sair do campo "Utilizador"
        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Utilizador";
                tb_Username.ForeColor = Color.Silver;
            }
        }

        /* ======== TextBox: Senha ======== */
        // Evento ativado ao entrar no campo "Senha"
        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text == "Senha")
            {
                tb_Password.Text = "";
                tb_Password.UseSystemPasswordChar = true;  // Ativa a ocultação dos caracteres
                tb_Password.ForeColor = Color.Black;
            }
        }
        // Evento ativado ao sair do campo "Senha"
        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Senha";
                tb_Password.UseSystemPasswordChar = false; // Desativa a ocultação dos caracteres
                tb_Password.ForeColor = Color.Silver;
            }
        }


        /* --------- Funções do CRUD ---------- */
        /* --------- Salvar ---------- */
        // Gera um hash SHA-256 a partir de uma string de senha
        private string HashPasswordSHA256(string password)
        {
            // Cria uma instância do algoritmo SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Converte a senha em um array de bytes (UTF-8)
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Calcula o hash a partir dos bytes
                byte[] hash = sha256.ComputeHash(bytes);

                // Constrói a string do hash em formato hexadecimal
                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                    result.Append(b.ToString("x2")); // "x2" = dois dígitos hexadecimais

                // Retorna o hash como string final
                return result.ToString();
            }
        }
        // Função para inserir um programador na base de dados
        private void SaveProgrammer()
        {
            // Pega o texto das TextBoxes e armazena nas variáveis
            string name = tb_Name.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            // Se o texto estiver com os valores padrão, considera vazio
            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";
            if (password == "Senha") password = "";

            // Verifica se algum campo obrigatório está vazio ou não selecionado
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                cb_ExperienceLevel.SelectedIndex == -1 ||  // Nível de experiência
                cb_Maneger.SelectedIndex == -1)            // Gestor responsável
            {
                // Exibe mensagem para o usuário preencher todos os campos
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return; // Sai do método para evitar continuar com dados incompletos
            }

            // Obtém os valores selecionados nas ComboBoxes
            ExperienceLevel experienceLevelSelec = (ExperienceLevel)cb_ExperienceLevel.SelectedItem;
            Maneger manegerSelec = cb_Maneger.SelectedItem as Maneger;

            // Confirma que um gestor válido foi selecionado
            if (manegerSelec == null)
            {
                // Exibe mensagem para selecionar um gestor responsável
                MessageBox.Show("Por favor, selecione um gestor responsável.");
                return; // Sai do método
            }

            // Usa o contexto da base de dados para inserir o programador
            using (var db = new iTasksContext())
            {
                try
                {
                    // Anexa o gestor selecionado ao contexto para evitar duplicação na inserção
                    db.Users.Attach(manegerSelec);

                    // Verifica se já existe um usuário com o mesmo nome de usuário (username)
                    bool userExists = db.Users.Any(u => u.Username == username);
                    if (userExists)
                    {
                        // Exibe mensagem que o usuário já existe
                        MessageBox.Show("Já existe um usuário com esse nome de utilizador.");
                        return; // Sai do método
                    }

                    // Cria um novo objeto Programmer com os dados fornecidos
                    var newProgrammer = new Programmer()
                    {
                        Name = name,
                        Username = username,
                        Password = HashPasswordSHA256(password), // Senha criptografada com SHA256
                        ExperienceLevel = experienceLevelSelec,
                        idManeger = manegerSelec
                    };

                    // Adiciona o novo programador à lista de usuários do banco
                    db.Users.Add(newProgrammer);

                    // Salva as alterações no banco de dados
                    db.SaveChanges();

                    // Mensagem de sucesso após salvar
                    MessageBox.Show("Programador criado com sucesso!");
                }
                catch
                {
                    // Em caso de erro na inserção, exibe mensagem de erro
                    MessageBox.Show("Erro ao criar o programador.");
                }
            }
        }
        // Função para inserir o gestor na base de dados
        // Função para inserir um gestor na base de dados
        private void SaveManager()
        {
            // Pega o texto das TextBoxes e armazena nas variáveis
            string name = tb_Name.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            // Se o texto estiver com os valores padrão, considera vazio
            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";
            if (password == "Senha") password = "";

            // Verifica se algum campo obrigatório está vazio ou não selecionado
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                cb_Department.SelectedIndex == -1)  // Departamento selecionado?
            {
                // Exibe mensagem para o usuário preencher todos os campos
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return; // Sai do método para evitar continuar com dados incompletos
            }

            // Obtém o departamento selecionado na ComboBox
            Department departmentSelec = (Department)cb_Department.SelectedItem;
            // Converte o estado do toggle switch em string para armazenar no banco
            string ManegerUsers = ts_ManegerUsername.Checked ? "True" : "False";

            // Usa o contexto da base de dados para inserir o gestor
            using (var db = new iTasksContext())
            {
                try
                {
                    // Verifica se já existe um usuário com o mesmo nome de usuário (username)
                    bool userExists = db.Users.Any(u => u.Username == username);
                    if (userExists)
                    {
                        // Exibe mensagem que o usuário já existe
                        MessageBox.Show("Já existe um usuário com esse nome de utilizador.");
                        return; // Sai do método
                    }

                    // Cria um novo objeto Maneger com os dados fornecidos
                    var newManeger = new Maneger()
                    {
                        Name = name,
                        Username = username,
                        Password = HashPasswordSHA256(password), // Senha criptografada com SHA256
                        Department = departmentSelec,
                        GenerateUser = ManegerUsers
                    };

                    // Adiciona o novo gestor à lista de usuários do banco
                    db.Users.Add(newManeger);

                    // Salva as alterações no banco de dados
                    db.SaveChanges();

                    // Mensagem de sucesso após salvar
                    MessageBox.Show("Gestor criado com sucesso!");
                }
                catch
                {
                    // Em caso de erro na inserção, exibe mensagem de erro
                    MessageBox.Show("Erro ao criar gestor!");
                }
            }
        }
        // Evento do botão para criar os usuários (programador ou gestor)
        private void b_Create_Click(object sender, EventArgs e)
        {
            // Verifica se a checkbox do programador está selecionada
            if (cb_SelecProgrammer.Checked)
            {
                // Chama a função para salvar o programador na base de dados
                SaveProgrammer();

                // Limpa os campos do formulário para uma nova entrada
                clearText();
            }
            // Se não for programador, verifica se a checkbox do gestor está selecionada
            else if (cb_SelecManeger.Checked)
            {
                // Chama a função para salvar o gestor na base de dados
                SaveManager();

                // Limpa os campos do formulário para uma nova entrada
                clearText();
            }
        }


        /* --------- Procurar ---------- */
        // Método para pesquisar programadores e gestores baseando-se nos textos digitados nas TextBoxes
        private void SearchProgrammerAndManagers()
        {
            // Obtém os valores atuais das textBoxes
            string name = tb_Name.Text;
            string username = tb_Username.Text;

            // Se os textos forem os valores padrão, considera como vazio para a busca
            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";

            using (var db = new iTasksContext())
            {
                try
                {
                    // Lista para armazenar os resultados da pesquisa
                    var results = new List<Users>();

                    // Verifica quais checkboxes estão marcadas para determinar o tipo de usuários a buscar
                    bool buscarProgramador = cb_SelecProgrammer.Checked;
                    bool buscarGestor = cb_SelecManeger.Checked;

                    // Se nenhuma checkbox estiver marcada, buscar ambos tipos de usuário
                    if (!buscarProgramador && !buscarGestor)
                    {
                        buscarProgramador = true;
                        buscarGestor = true;
                    }

                    // Busca programadores caso esteja selecionado ou nenhuma seleção
                    if (buscarProgramador)
                    {
                        var programmers = db.Users
                            .OfType<Programmer>()
                            .Include(p => p.idManeger) // Inclui dados do gestor relacionado
                            .Where(p =>
                                (string.IsNullOrEmpty(name) || p.Name.Contains(name)) &&
                                (string.IsNullOrEmpty(username) || p.Username.Contains(username)))
                            .ToList();

                        results.AddRange(programmers);
                    }

                    // Busca gestores caso esteja selecionado ou nenhuma seleção
                    if (buscarGestor)
                    {
                        var managers = db.Users
                            .OfType<Maneger>()
                            .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)) &&
                                (string.IsNullOrEmpty(username) || m.Username.Contains(username)))
                            .ToList();

                        // Garante que o campo GenerateUser não seja null para exibição correta
                        foreach (var manager in managers)
                        {
                            if (manager.GenerateUser == null)
                                manager.GenerateUser = "False";
                        }

                        results.AddRange(managers);
                    }

                    // Remove temporariamente o evento para evitar chamadas recursivas ao alterar o DataSource
                    lb_Users.SelectedIndexChanged -= lb_Users_SelectedIndexChanged;

                    // Atualiza a ListBox com os resultados da busca ou uma mensagem caso não encontre
                    if (results.Count == 0)
                    {
                        lb_Users.DataSource = null;
                        lb_Users.Text = "Nenhum utilizador encontrado.";
                    }
                    else
                    {
                        lb_Users.DataSource = results;
                        lb_Users.DisplayMember = "Name";
                        lb_Users.ValueMember = "Id";
                        lb_Users.ClearSelected();
                    }

                    // Reativa o evento
                    lb_Users.SelectedIndexChanged += lb_Users_SelectedIndexChanged;
                }
                catch
                {
                    // Caso ocorra um erro, exibe mensagem na ListBox
                    lb_Users.Text = "Nenhum utilizador encontrado.";
                }
            }
        }
        // Eventos para atualizar a lista sempre que o texto mudar
        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            SearchProgrammerAndManagers();
        }
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            SearchProgrammerAndManagers();
        }
        // Função para procurar programadores na base de dados
        private void SearchProgrammer()
        {
            // Obtém os valores das textBoxes para nome e username
            string name = tb_Name.Text;
            string username = tb_Username.Text;

            // Se os valores forem os padrões, considera vazio para a pesquisa
            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";

            using (var db = new iTasksContext())
            {
                try
                {
                    // Pesquisa programadores que contenham o nome e username digitados (se não vazios)
                    var Programmers = db.Users
                        .OfType<Programmer>()                // Filtra só os programadores
                        .Include(p => p.idManeger)           // Inclui o gestor associado
                        .Where(m =>
                            (string.IsNullOrEmpty(name) || m.Name.Contains(name)) &&
                            (string.IsNullOrEmpty(username) || m.Username.Contains(username)))
                        .ToList();

                    // Se não encontrar nenhum, mostra mensagem e limpa lista
                    if (Programmers.Count == 0)
                    {
                        MessageBox.Show("Nenhum programador encontrado.");
                        lb_Users.DataSource = null;
                        return;
                    }

                    // Remove temporariamente o evento para evitar chamadas recursivas
                    lb_Users.SelectedIndexChanged -= lb_Users_SelectedIndexChanged;

                    // Atualiza a ListBox com os programadores encontrados
                    lb_Users.DataSource = Programmers;
                    lb_Users.DisplayMember = "Name"; // Mostra o nome na lista
                    lb_Users.ValueMember = "Id";     // Valor interno é o ID
                    lb_Users.ClearSelected();

                    // Reativa o evento
                    lb_Users.SelectedIndexChanged += lb_Users_SelectedIndexChanged;
                }
                catch
                {
                    // Em caso de erro, mostra mensagem
                    MessageBox.Show("Erro ao consultar programadores");
                }
            }
        }
        // Função para procurar gestores na base de dados
        private void SearchManager()
        {
            // Obtém os valores das textBoxes para nome e username
            string name = tb_Name.Text;
            string username = tb_Username.Text;

            // Se os valores forem os padrões, considera vazio para a pesquisa
            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";

            using (var db = new iTasksContext())
            {
                try
                {
                    // Pesquisa gestores que contenham o nome e username digitados (se não vazios)
                    var Managers = db.Users
                        .OfType<Maneger>()                  // Filtra só os gestores
                        .Where(m =>
                            (string.IsNullOrEmpty(name) || m.Name.Contains(name)) &&
                            (string.IsNullOrEmpty(username) || m.Username.Contains(username)))
                        .ToList();

                    // Se não encontrar nenhum, mostra mensagem e limpa lista
                    if (Managers.Count == 0)
                    {
                        MessageBox.Show("Nenhum gestor encontrado.");
                        lb_Users.DataSource = null;
                        return;
                    }

                    // Remove temporariamente o evento para evitar chamadas recursivas
                    lb_Users.SelectedIndexChanged -= lb_Users_SelectedIndexChanged;

                    // Atualiza a ListBox com os gestores encontrados
                    lb_Users.DataSource = Managers;
                    lb_Users.DisplayMember = "Name"; // Mostra o nome na lista
                    lb_Users.ValueMember = "Id";     // Valor interno é o ID
                    lb_Users.ClearSelected();

                    // Reativa o evento
                    lb_Users.SelectedIndexChanged += lb_Users_SelectedIndexChanged;
                }
                catch
                {
                    // Em caso de erro, mostra mensagem
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }
        }
        // Evento do botão para procurar usuários, decide qual função chamar com base na seleção
        private void b_Search_Click(object sender, EventArgs e)
        {
            if (cb_SelecProgrammer.Checked)
            {
                SearchProgrammer();
            }
            else if (cb_SelecManeger.Checked)
            {
                SearchManager();
            }
        }


        /* --------- Editar ---------- */
        // Evento chamado quando o usuário seleciona um item na ListBox lb_Users
        private void lb_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se nada estiver selecionado, não faz nada
            if (lb_Users.SelectedItem == null)
                return;

            // Verifica se o item selecionado é um Programador
            if (lb_Users.SelectedItem is Programmer selectedProgrammer)
            {
                // Se o checkbox de programador não estiver marcado, ativa ele
                if (!cb_SelecProgrammer.Checked)
                    cb_SelecProgrammer.Checked = true;

                // Guarda o programador selecionado para edição futura
                SelectedProgrammer = selectedProgrammer;

                // Preenche os campos do formulário com os dados do programador selecionado
                tb_Id.Text = selectedProgrammer.Id.ToString();
                tb_Name.Text = selectedProgrammer.Name;
                tb_Username.Text = selectedProgrammer.Username;

                // Marca que a senha não foi alterada ainda e esconde a senha com caracteres •
                passwordAlterada = false;
                tb_Password.Text = "•••••••••";
                tb_Password.UseSystemPasswordChar = true;

                // Define o nível de experiência selecionado na ComboBox correspondente
                cb_ExperienceLevel.SelectedIndex = cb_ExperienceLevel.FindStringExact(selectedProgrammer.ExperienceLevel.ToString());

                // Se o gestor estiver atribuído e a ComboBox de gestores estiver carregada, seleciona o gestor
                if (cb_Maneger.DataSource != null && selectedProgrammer.idManeger != null)
                {
                    cb_Maneger.SelectedValue = selectedProgrammer.idManeger.Id;
                }
                else
                {
                    cb_Maneger.SelectedIndex = -1;
                }
            }
            // Se o item selecionado for um Gestor
            else if (lb_Users.SelectedItem is Maneger)
            {
                var selectedManager = lb_Users.SelectedItem as Maneger;

                // Caso algo dê errado e o gestor seja nulo, mostra erro
                if (selectedManager == null)
                {
                    MessageBox.Show("Erro: O gestor selecionado está nulo.");
                    return;
                }

                // Ativa o checkbox de gestor, caso não esteja ativo
                if (!cb_SelecManeger.Checked)
                    cb_SelecManeger.Checked = true;

                // Guarda o gestor selecionado para edição futura
                SelectedManeger = selectedManager;

                // Preenche os campos do formulário com os dados do gestor selecionado
                tb_Id.Text = selectedManager.Id.ToString();
                tb_Name.Text = selectedManager.Name;
                tb_Username.Text = selectedManager.Username;

                // Marca que a senha não foi alterada ainda e esconde a senha com caracteres •
                passwordAlterada = false;
                tb_Password.Text = "•••••••••";
                tb_Password.UseSystemPasswordChar = true;

                // Seleciona o departamento do gestor na ComboBox
                cb_Department.SelectedItem = selectedManager.Department;

                // Define o checkbox "ts_ManegerUsername" com base no valor do GenerateUser do gestor
                ts_ManegerUsername.Checked =
                    !string.IsNullOrWhiteSpace(selectedManager.GenerateUser) &&
                    selectedManager.GenerateUser.Equals("true", StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                // Se o tipo de usuário não for reconhecido, mostra mensagem de erro
                MessageBox.Show("Tipo de utilizador não reconhecido.");
            }
        }
        // Flag para saber se a senha foi alterada pelo usuário
        private bool passwordAlterada = false;
        // Evento disparado quando o texto da senha é alterado
        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            // Só marca a senha como alterada se o campo estiver focado e o texto não for a senha padrão mascarada
            if (tb_Password.Focused && tb_Password.Text != "********")
            {
                passwordAlterada = true;
            }
        }
        // Evento do botão "Editar" para salvar alterações feitas em usuário selecionado
        private void b_Edit_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            // Se a senha for a padrão mascarada ou o texto padrão, considera que senha não foi alterada
            if (password == "•••••••••" || password == "Senha") password = "";

            // Caso o gestor esteja selecionado para edição
            if (SelectedManeger != null)
            {
                // Valida se os campos obrigatórios estão preenchidos
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(username) ||
                    cb_Department.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatorios.");
                    return;
                }

                // Pega o departamento selecionado e o estado do checkbox do username
                Department departmentSelec = (Department)cb_Department.SelectedItem;
                string ManegerUsers = ts_ManegerUsername.Checked ? "True" : "False";

                // Atualiza os dados do gestor selecionado com os dados do formulário
                SelectedManeger.Name = name;
                SelectedManeger.Username = username;

                // Se a senha foi alterada e não está vazia, atualiza a senha criptografada
                if (passwordAlterada && !string.IsNullOrWhiteSpace(password))
                    SelectedManeger.Password = HashPasswordSHA256(password);

                SelectedManeger.Department = departmentSelec;
                SelectedManeger.GenerateUser = ManegerUsers;

                // Salva as alterações no banco de dados
                using (var db = new iTasksContext())
                {
                    db.Entry(SelectedManeger).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            // Caso o programador esteja selecionado para edição
            else if (SelectedProgrammer != null)
            {
                // Valida os campos obrigatórios do programador
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(username) ||
                    cb_ExperienceLevel.SelectedIndex == -1 ||
                    cb_Maneger.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatorios.");
                    return;
                }

                // Pega o nível de experiência e o gestor selecionado
                ExperienceLevel experienceLevelSelec = (ExperienceLevel)cb_ExperienceLevel.SelectedItem;
                Maneger manegerSelec = cb_Maneger.SelectedItem as Maneger;

                // Atualiza os dados do programador selecionado com os dados do formulário
                SelectedProgrammer.Name = name;
                SelectedProgrammer.Username = username;

                // Atualiza senha se foi alterada e não está vazia
                if (passwordAlterada && !string.IsNullOrWhiteSpace(password))
                    SelectedProgrammer.Password = HashPasswordSHA256(password);

                SelectedProgrammer.ExperienceLevel = experienceLevelSelec;
                SelectedProgrammer.idManeger = manegerSelec;

                // Salva as alterações no banco de dados
                using (var db = new iTasksContext())
                {
                    db.Entry(SelectedProgrammer).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            else
            {
                // Caso nenhum usuário esteja selecionado para edição, mostra mensagem de erro
                MessageBox.Show("Selecione um cliente da lista para editar.");
                return;
            }

            // Confirma que os dados foram atualizados com sucesso
            MessageBox.Show("Dados do cliente atualizados com sucesso.");
        }


        /* --------- Eliminar ---------- */
        private void ClearFormFields()
        {
            // Limpa o campo do Id
            tb_Id.Text = "";

            // Reseta o campo Nome para o texto padrão
            tb_Name.Text = "Nome";

            // Reseta o campo Username para o texto padrão
            tb_Username.Text = "Utilizador";

            // Reseta o campo Password para o texto padrão
            tb_Password.Text = "Senha";

            // Desativa a máscara de senha (mostrar texto legível)
            tb_Password.UseSystemPasswordChar = false;

            // Altera a cor do texto dos campos para cinza (indicando texto padrão)
            tb_Name.ForeColor = Color.Silver;
            tb_Username.ForeColor = Color.Silver;
            tb_Password.ForeColor = Color.Silver;

            // Limpa a seleção do combobox de nível de experiência
            cb_ExperienceLevel.SelectedIndex = -1;

            // Limpa a seleção do combobox de gerente
            cb_Maneger.SelectedIndex = -1;

            // Limpa a seleção do combobox de departamento
            cb_Department.SelectedIndex = -1;

            // Desmarca o checkbox do gerente
            ts_ManegerUsername.Checked = false;

            // Reseta as variáveis que armazenam o usuário selecionado
            SelectedManeger = null;
            SelectedProgrammer = null;
        }
        // Botão Eliminar
        private void b_Delete_Click(object sender, EventArgs e)
        {
            // Verifica se um programador está selecionado para exclusão
            if (SelectedProgrammer != null)
            {
                // Confirmação para apagar o programador
                DialogResult dialogResult = MessageBox.Show(
                    $"Tem a certeza que quer apagar o programador '{SelectedProgrammer.Name}'?",
                    "Confirmar Eliminação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new iTasksContext())
                    {
                        try
                        {
                            // Busca todas as tarefas associadas ao programador para desassociá-las
                            var tarefas = db.Tasks
                                .Where(t => t.IdProgrammer.Id == SelectedProgrammer.Id)
                                .ToList();

                            foreach (var tarefa in tarefas)
                            {
                                // Remove a associação do programador da tarefa
                                tarefa.IdProgrammer = null;
                            }

                            // Anexa o programador selecionado ao contexto para poder removê-lo
                            db.Users.Attach(SelectedProgrammer);
                            // Remove o programador da base de dados
                            db.Users.Remove(SelectedProgrammer);

                            // Salva as alterações no banco
                            db.SaveChanges();

                            MessageBox.Show("Programador eliminado com sucesso!");

                            // Limpa os campos do formulário após exclusão
                            ClearFormFields();

                            // Atualiza a lista de programadores na interface
                            SearchProgrammer();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao eliminar programador.\n{ex.Message}");
                        }
                    }
                }
            }
            // Se não houver programador selecionado, verifica se um gestor está selecionado
            else if (SelectedManeger != null)
            {
                // Confirmação para apagar o gestor
                DialogResult dialogResult = MessageBox.Show(
                    $"Tem a certeza que quer apagar o gestor '{SelectedManeger.Name}'?",
                    "Confirmar Eliminação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new iTasksContext())
                    {
                        try
                        {
                            // Anexa o gestor selecionado ao contexto para poder removê-lo
                            db.Users.Attach(SelectedManeger);
                            // Remove o gestor da base de dados
                            db.Users.Remove(SelectedManeger);

                            // Salva as alterações no banco
                            db.SaveChanges();

                            MessageBox.Show("Gestor eliminado com sucesso!");

                            // Limpa os campos do formulário após exclusão
                            ClearFormFields();

                            // Atualiza a lista de gestores na interface
                            ListGestor();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao eliminar gestor.\n" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                // Caso nenhum usuário esteja selecionado para exclusão
                MessageBox.Show("Por favor, selecione um utilizador (Programador ou Gestor) na lista para apagar.");
            }
        }


    }
}
