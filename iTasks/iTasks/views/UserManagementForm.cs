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

namespace iTasks.views
{
    public partial class UserManagementForm : Form
    {
        private Maneger SelectedManeger;
        private Programmer SelectedProgrammer;
        public UserManagementForm()
        {
            InitializeComponent();
            EnumValues();
        }


        // funcao para inserir os dados nas comboBox
        private void EnumValues()
        {
            // Inserir dados na ComboBox do Livel de Experiencia
            Enum.GetValues(typeof(ExperienceLevel));
            cb_ExperienceLevel.DataSource = Enum.GetValues(typeof(ExperienceLevel)).Cast<ExperienceLevel>().ToList();
            cb_ExperienceLevel.SelectedIndex = -1;

            // Inserir dados na ComboBox do Gestores
            ListGestor();

            // Inserir dados na ComboBox do Departamento
            Enum.GetValues(typeof(Department));
            cb_Department.DataSource = Enum.GetValues(typeof(Department)).Cast<Department>().ToList();
            cb_Department.SelectedIndex = -1;
        }

        // Funcao para procurar os gestor na bd e colocalos na ComboBox
        private void ListGestor()
        { 
            try
            {
                // vai chamar a dase de bados e mete-a na variavel db
                using (var db = new iTasksContext())
                {
                    // vai a base de dados e procura só os utilizador que forem Gestores
                    var gestor = db.Users.OfType<Maneger>().ToList();

                    // Colocar os Nomes do Gestores na ComboList e guardar o id do Gestor
                    cb_Maneger.DataSource = gestor;
                    cb_Maneger.DisplayMember = "Name";
                    cb_Maneger.ValueMember = "Id";
                    cb_Maneger.SelectedIndex = -1;
                }
            }
            catch
            {
                // se ouver algum erro com o codigo em cima ele aparece na listBox com esta mensagem
                cb_Maneger.Text = "Erro ao carregar Gestor!";
            }

        }


        // Funcoes para as CheckBox
        private void cb_Programmer_CheckedChanged(object sender, EventArgs e)
        {
            // if confirma que checkBox dos programadores está selecionada ou não
            if (cb_SelecProgrammer.Checked)
            {
                // se tiver
                // ele tira a seleção da checkBox dos Getores
                cb_SelecManeger.Checked = false;
                // tira a visibilidade do painel dos gestores
                p_Manager.Visible = false;

                // mete visibilidade do painel dos programdadores
                p_Programmer.Visible = true;

                // mete visibilidade na listBox dos programadores
                lb_Programmer.Visible = true;
            }
            // se for diverente do if
            else
            {
                // tira a visibilidade do painel dos programadores
                p_Programmer.Visible = false;

                // tira a visibilidade da listBox dos programadores
                lb_Programmer.Visible = false;
            }
        }
        private void cb_Manager_CheckedChanged(object sender, EventArgs e)
        {
            // if confirma que checkBox dos gestores está selecionada ou não
            if (cb_SelecManeger.Checked)
            {
                // se tiver
                // ele tira a seleção da checkBox dos programadores
                cb_SelecProgrammer.Checked = false;
                // tira a visibilidade do painel dos programadores
                p_Programmer.Visible = false;

                // mete visibilidade do painel dos gestores
                p_Manager.Visible = true;

                // mete visibilidade na listBox dos gestores
                lb_Manager.Visible = true;
            }
            // se for diverente do if
            else
            {
                // tira a visibilidade do painel dos gestores
                p_Manager.Visible = false;

                // tira a visibilidade da listBox dos gestores
                lb_Manager.Visible = false;
            }
        }


        // Funcoes para apanhar o texto e rescrever nas TextBox
        // Função ativa quando entrar na textBox para inserir texto
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            // Vai defenir que o texto da textBox é "Nome" 
            tb_Name.Text = "Nome";

            // Verifica se o texto da textBox for "Nome"
            if (tb_Name.Text == "Nome")
            {
                // Se tiver "Nome" ele mete no Texto ""
                tb_Name.Text = "";

                // E converte cor do texto para Preto
                tb_Name.ForeColor = Color.Black;
            }
        }
        // Função ativa quando sair da textBox
        private void tb_Name_Leave(object sender, EventArgs e)
        {
            // Verifica se o texto da textBox for ""
            if (tb_Name.Text == "")
            {
                // Se tiver "" ele mete no Texto "Nome"
                tb_Name.Text = "Nome";

                // E converte a cor do texto para "Cinzento"
                tb_Name.ForeColor = Color.Silver;
            }
        }


        // Função ativa quando entrar na textBox para inserir texto
        private void tb_Username_Enter(object sender, EventArgs e)
        {
            // Vai defenir que o texto da textBox é "Utilizador" 
            tb_Username.Text = "Utilizador";

            // Verifica se o texto da textBox for "Utilizador"
            if (tb_Username.Text == "Utilizador")
            {
                // Se tiver "Utilizador" ele mete no Texto ""
                tb_Username.Text = "";

                // E converte cor do texto para Preto
                tb_Username.ForeColor = Color.Black;
            }
        }
        // Função ativa quando sair da textBox
        private void tb_Username_Leave(object sender, EventArgs e)
        {
            // Verifica se o texto da textBox for ""
            if (tb_Username.Text == "")
            {
                // Se tiver "" ele mete no Texto "Utilizador"
                tb_Username.Text = "Utilizador";

                // E converte a cor do texto para "Cinzento"
                tb_Username.ForeColor = Color.Silver;
            }
        }


        // Função ativa quando entrar na textBox para inserir texto
        private void tb_Password_Enter(object sender, EventArgs e)
        {
            // Vai defenir que o texto da textBox é "Senha" 
            tb_Password.Text = "Senha";

            // Verifica se o texto da textBox for "Senha"
            if (tb_Password.Text == "Senha")
            {
                // Se tiver "Senha" ele mete no Texto ""
                tb_Password.Text = "";

                // E converte o UserSystemPassword de false para true
                tb_Password.UseSystemPasswordChar = true;

                // E converte cor do texto para Preto
                tb_Password.ForeColor = Color.Black;
            }
        }
        // Função ativa quando sair da textBox
        private void tb_Password_Leave(object sender, EventArgs e)
        {
            // Verifica se o texto da textBox for ""
            if (tb_Password.Text == "")
            {
                // Se tiver "" ele mete no Texto "Senha"
                tb_Password.Text = "Senha";

                // E converte o UserSystemPassword de true para false
                tb_Password.UseSystemPasswordChar = false;

                // E converte a cor do texto para "Cinzento"
                tb_Password.ForeColor = Color.Silver;
            }
        }


        /* ------------ Funções do CRUD ------------*/

        // Função para Salvar novo Usuário
        // Função para inserir o programador na base de dados
        private void SaveProgrammer()
        {
            // Vai buscar o texto das textBox e mete-lo em variaveis
            string name = tb_Name.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            // Vai confirmar se nas textBox estiverem com a escrita pradão em mete "" 
            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";
            if (password == "Senha") password = "";

            // Vai confirmar se todas as os dados estão a prenchidos
            if (string.IsNullOrEmpty(name) ||
               string.IsNullOrEmpty(username) ||
               string.IsNullOrEmpty(password) ||
               cb_ExperienceLevel.SelectedIndex == -1 ||
               cb_Maneger.SelectedIndex == -1)
            {
                // Se não tiverem
                // Mostra uma Messagem a disser "Por favor, preencha todos os campos obrigatorios"
                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.");
                return;
            }

            // Mete o dado da comboBox dentro de uma variaval
            ExperienceLevel experienceLevelSelec = (ExperienceLevel)cb_ExperienceLevel.SelectedItem;
            Maneger manegerSelec = cb_Maneger.SelectedItem as Maneger;

            // Confirma que é selecionado um gestor na comboBox
            if (manegerSelec == null)
            {
                // Se não tiver nenhum gestor selecionado
                // Mostra uma Messagem a disser "Por favor, selecione um gestor responsável."
                MessageBox.Show("Por favor, selecione um gestor responsável.");
                return;
            }

            // mete a base de dados na variavel db
            using (var db = new iTasksContext())
            {
                try
                {
                    // Verifica que manegerSelec já existe na base de dados e não queria outro utilizador igual
                    db.Users.Attach(manegerSelec);

                    // Vai buscar o Utilizador com o mesmo "Username" da textBox
                    var nameUsers = db.Users.Any(n => n.Username == username);
                    // Verifica se a varivel nameUsers tem um utilizador valido ou null
                    // se for null salta este if
                    if (nameUsers)
                    {
                        // Se for valido
                        // Mostra uma Messagem a dizer "Já existe um usuário na base de dados."
                        MessageBox.Show("Já existe um usuário na base de dados.");
                        return;
                    }

                    // Preenche um novo utilizador perante a class Programmer e mete na variavel
                    var newProgrammer = new Programmer()
                    {
                        Name = name,
                        Username = username,
                        Password = password,
                        ExperienceLevel = experienceLevelSelec,
                        idManeger = manegerSelec
                    };

                    // Adiciona o novo utilizador a db Users
                    db.Users.Add(newProgrammer);
                    // Salva a base de dados
                    db.SaveChanges();

                    // Se conseguir criar o novo utlizador
                    // Mostra uma messagem a dizer "Programador criado com sucesso!"
                    MessageBox.Show("Programador criado com sucesso!");
                }
                catch
                {
                    // se der algo erro no codigo aterior 
                    // Mostra uma messagem a dizer "Erro ao criar Programador!"
                    MessageBox.Show("Erro ao criar Programador!");
                }
            }
        }

        // Função para inserir o gestor na base de dados
        private void SaveManager()
        {
            // Vai buscar o texto das textBox e mete-lo em variaveis
            string name = tb_Name.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            // Vai confirmar se nas textBox estiverem com a escrita pradão em mete "" 
            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";
            if (password == "Senha") password = "";

            // Vai confirmar se todas as os dados estão a prenchidos
            if (string.IsNullOrEmpty(name) ||
               string.IsNullOrEmpty(username) ||
               string.IsNullOrEmpty(password) ||
               cb_Department.SelectedIndex == -1)
            {
                // Se não tiverem
                // Mostra uma Messagem a disser "Por favor, preencha todos os campos obrigatorios"
                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.");
                return;
            }

            // Mete o dado da comboBox dentro de uma variaval
            Department departmentSelec = (Department)cb_Department.SelectedItem;
            string ManegerUsers = ts_ManegerUsername.Checked ? "True" : "False";

            // mete a base de dados na variavel db
            using (var db = new iTasksContext())
            {
                try
                {
                    // Verifica que manegerSelec já existe na base de dados e não queria outro utilizador igual
                    var nameUsers = db.Users.Any(n => n.Username == username);
                    // Verifica se a varivel nameUsers tem um utilizador valido ou null
                    // se for null salta este if
                    if (nameUsers)
                    {
                        // Se for valido
                        // Mostra uma Messagem a dizer "Já existe um usuário na base de dados."
                        MessageBox.Show("Já existe um usuário na base de dados.");
                        return;
                    }

                    var newManeger = new Maneger()
                    {
                        Name = name,
                        Username = username,
                        Password = password,
                        Department = departmentSelec,
                        GenerateUser = ManegerUsers
                    };

                    db.Users.Add(newManeger);
                    db.SaveChanges();

                    MessageBox.Show("Gestor criado com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Erro ao criar gestor!");
                }
            }
        }

        // botao para criar os usuários
        private void b_Create_Click(object sender, EventArgs e)
        {
            if (cb_SelecProgrammer.Checked)
            {
                SaveProgrammer();
            }
            else if (cb_SelecManeger.Checked)
            {
                SaveManager();
            }
        }


        // Função para Procurar Usuário
        // Função para procurar o programador na base de dados
        private void SearchProgrammer()
        {
            string name = tb_Name.Text;
            string username = tb_Username.Text;

            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";

            using (var db = new iTasksContext())
            {
                try
                {
                    var Programmers = db.Users
                        .OfType<Programmer>()
                        .Include(p => p.idManeger)
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)) &&
                                (string.IsNullOrEmpty(username) || m.Username.Contains(username)))
                        .ToList();

                    if (Programmers.Count == 0)
                    {
                        MessageBox.Show("Nenhum programador encontrado.");
                        lb_Programmer.DataSource = null;
                        return;
                    }

                    lb_Programmer.SelectedIndexChanged -= lb_Programmer_SelectedIndexChanged;

                    lb_Programmer.DataSource = Programmers;
                    lb_Programmer.DisplayMember = "Name";
                    lb_Programmer.ValueMember = "Id";
                    lb_Programmer.ClearSelected();

                    lb_Programmer.SelectedIndexChanged += lb_Programmer_SelectedIndexChanged;
                }
                catch
                {
                    MessageBox.Show("Erro ao consultar programadores");
                }
            }
        }
        // Função para procurar o gestor na base de dados
        private void SearchManager()
        {
            string name = tb_Name.Text;
            string username = tb_Username.Text;

            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";

            using (var db = new iTasksContext())
            {
                try
                {
                    var Managers = db.Users
                        .OfType<Maneger>()
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)) &&
                                (string.IsNullOrEmpty(username) || m.Username.Contains(username)))
                        .ToList();

                    if (Managers.Count == 0)
                    {
                        MessageBox.Show("Nenhum gestor encontrado.");
                        lb_Manager.DataSource = null;
                        return;
                    }

                    lb_Manager.SelectedIndexChanged -= lb_Manager_SelectedIndexChanged;

                    lb_Manager.DataSource = Managers;
                    lb_Manager.DisplayMember = "Name";
                    lb_Manager.ValueMember = "Id";
                    lb_Manager.ClearSelected();

                    lb_Manager.SelectedIndexChanged += lb_Manager_SelectedIndexChanged;
                }
                catch
                {
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }

        }

        // botao para procurar os usuários
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


        // Eventos para ao selecioar o nome na listBox ele prenche os campos todos
        private void lb_Programmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Programmer.SelectedItem == null)
                return;

            var selectedProgrammer = lb_Programmer.SelectedItem as Programmer;
            if (selectedProgrammer == null)
                return;

            SelectedProgrammer = selectedProgrammer;
            tb_Id.Text = selectedProgrammer.Id.ToString();
            tb_Name.Text = selectedProgrammer.Name;
            tb_Username.Text = selectedProgrammer.Username;
            tb_Password.Text = selectedProgrammer.Password;

            cb_ExperienceLevel.SelectedIndex = cb_ExperienceLevel.FindStringExact(selectedProgrammer.ExperienceLevel.ToString());

            // Só tenta selecionar gestor se a ComboBox já estiver populada
            if (cb_Maneger.DataSource != null && selectedProgrammer.idManeger != null)
            {
                // Confirmar o tipo do Id, e garantir que não há problemas de conversão
                cb_Maneger.SelectedValue = selectedProgrammer.idManeger.Id;
            }
            else
            {
                cb_Maneger.SelectedIndex = -1;
            }
        }
        private void lb_Manager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Manager.SelectedItem == null)
                return;

            var selectedManager = lb_Manager.SelectedItem as Maneger;

            if (selectedManager == null)
            {
                MessageBox.Show("Erro ao converter o item selecionado.");
                return;
            }

            SelectedManeger = selectedManager;
            tb_Id.Text = selectedManager.Id.ToString();
            tb_Name.Text = selectedManager.Name;
            tb_Username.Text = selectedManager.Username;
            tb_Password.Text = selectedManager.Password;
            tb_Password.UseSystemPasswordChar = true;

            cb_Department.SelectedItem = selectedManager.Department;
            ts_ManegerUsername.Checked = selectedManager.GenerateUser == "True" || selectedManager.GenerateUser == "true";
        }


        // Botão Editar
        private void b_Edit_Click(object sender, EventArgs e)
        {

            //Se um Gestor estiver selecionado
            if (SelectedManeger != null)
            {
                Department departmentSelec = (Department)cb_Department.SelectedItem;
                string ManegerUsers = ts_ManegerUsername.Checked ? "True" : "False";

                SelectedManeger.Name = tb_Name.Text;
                SelectedManeger.Username = tb_Username.Text;
                SelectedManeger.Password = tb_Password.Text;
                SelectedManeger.Department = departmentSelec;
                SelectedManeger.GenerateUser = ManegerUsers;

                //Atualizar na base de dados
                using (var db = new iTasksContext())
                {
                    db.Entry(SelectedManeger).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }

            // Se o programador estiver selecionado
            else if (SelectedProgrammer != null)
            {
                ExperienceLevel experienceLevelSelec = (ExperienceLevel)cb_ExperienceLevel.SelectedItem;
                Maneger manegerSelec = cb_Maneger.SelectedItem as Maneger;

                SelectedProgrammer.Name = tb_Name.Text;
                SelectedProgrammer.Username = tb_Username.Text;
                SelectedProgrammer.Password = tb_Password.Text;
                SelectedProgrammer.ExperienceLevel = experienceLevelSelec;
                SelectedProgrammer.idManeger = manegerSelec;

                //Atualizar base de dados
                using (var db = new iTasksContext())
                {
                    db.Entry(SelectedProgrammer).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente da lista para editar.");
                return;
            }

            MessageBox.Show("Dados do cliente atualizados com sucesso.");
        }

        // Botão Eliminar
        private void ClearFormFields()
        {
            tb_Id.Text = "";
            tb_Name.Text = "Nome";
            tb_Username.Text = "Utilizador";
            tb_Password.Text = "Senha";
            tb_Password.UseSystemPasswordChar = false;
            tb_Name.ForeColor = Color.Silver;
            tb_Username.ForeColor = Color.Silver;
            tb_Password.ForeColor = Color.Silver;
            cb_ExperienceLevel.SelectedIndex = -1;
            cb_Maneger.SelectedIndex = -1;
            cb_Department.SelectedIndex = -1;
            ts_ManegerUsername.Checked = false;
            SelectedManeger = null;
            SelectedProgrammer = null;
        }
        private void b_Delete_Click(object sender, EventArgs e)
        {
            if (SelectedProgrammer != null)
            {
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
                            // Desassociar tarefas ligadas ao programador
                            var tarefas = db.Tasks
                                .Where(t => t.IdProgrammer.Id == SelectedProgrammer.Id)
                                .ToList();

                            foreach (var tarefa in tarefas)
                            {
                                tarefa.IdProgrammer = null;
                            }

                            db.Users.Attach(SelectedProgrammer);
                            db.Users.Remove(SelectedProgrammer);

                            db.SaveChanges();

                            MessageBox.Show("Programador eliminado com sucesso!");
                            ClearFormFields();
                            SearchProgrammer();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao eliminar programador.\n{ex.Message}");
                        }
                    }
                }
            }
            else if (SelectedManeger != null)
            {
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
                            db.Users.Attach(SelectedManeger);
                            db.Users.Remove(SelectedManeger);
                            db.SaveChanges();

                            MessageBox.Show("Gestor eliminado com sucesso!");
                            ClearFormFields();
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
                MessageBox.Show("Por favor, selecione um utilizador (Programador ou Gestor) na lista para apagar.");
            }

        } 
    }
}
