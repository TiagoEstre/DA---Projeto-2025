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
                using (var db = new iTasksContext())
                {
                    var gestor = db.Users.OfType<Maneger>().ToList();

                    cb_Maneger.DataSource = gestor;
                    cb_Maneger.DisplayMember = "Name";
                    cb_Maneger.ValueMember = "Id";
                    cb_Maneger.SelectedIndex = -1;
                }
            }
            catch
            {
                cb_Maneger.Text = "Erro ao carregar Gestor!";
            }

        }


        // Funcoes para as CheckBox
        private void cb_Programmer_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_SelecProgrammer.Checked)
            {
                cb_SelecManeger.Checked = false;
                p_Manager.Visible = false;

                p_Programmer.Visible = true;

                lb_Programmer.Visible = true;
            }
            else
            {
                p_Programmer.Visible = false;

                lb_Programmer.Visible = false;
            }
        }
        private void cb_Manager_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_SelecManeger.Checked)
            {
                cb_SelecProgrammer.Checked = false;
                p_Programmer.Visible = false;

                p_Manager.Visible = true;

                lb_Manager.Visible = true;
            }
            else
            {
                p_Manager.Visible = false;

                lb_Manager.Visible = false;
            }
        }


        // Funcoes para apanhar o texto e rescrever nas TextBox
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            tb_Name.Text = "Nome";

            if (tb_Name.Text == "Nome")
            {
                tb_Name.Text = "";

                tb_Name.ForeColor = Color.Black;
            }
        }
        private void tb_Name_Leave(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            {
                tb_Name.Text = "Nome";

                tb_Name.ForeColor = Color.Silver;
            }
        }

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            tb_Username.Text = "Utilizador";

            if (tb_Username.Text == "Utilizador")
            {
                tb_Username.Text = "";

                tb_Username.ForeColor = Color.Black;
            }
        }
        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Utilizador";

                tb_Username.ForeColor = Color.Silver;
            }
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            tb_Password.Text = "Senha";

            if (tb_Password.Text == "Senha")
            {
                tb_Password.Text = "";

                tb_Password.UseSystemPasswordChar = true;

                tb_Password.ForeColor = Color.Black;
            }
        }
        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Senha";

                tb_Password.UseSystemPasswordChar = false;

                tb_Password.ForeColor = Color.Silver;
            }
        }


        // Funções

        // Função para Salvar novo Usuário
        // Função para inserir o programador na base de dados
        private void SaveProgrammer()
        {
            string name = tb_Name.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";
            if (password == "Senha") password = "";

            if (string.IsNullOrEmpty(name) ||
               string.IsNullOrEmpty(username) ||
               string.IsNullOrEmpty(password) ||
               cb_ExperienceLevel.SelectedIndex == -1 ||
               cb_Maneger.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.");
                return;
            }

            ExperienceLevel experienceLevelSelec = (ExperienceLevel)cb_ExperienceLevel.SelectedItem;
            Maneger manegerSelec = cb_Maneger.SelectedItem as Maneger;

            if (manegerSelec == null)
            {
                MessageBox.Show("Por favor, selecione um gestor responsável.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    db.Users.Attach(manegerSelec);

                    var nameUsers = db.Users.Any(n => n.Username == username);

                    if (nameUsers)
                    {
                        MessageBox.Show("Já existe um usuário na base de dados.");
                        return;
                    }

                    var newProgrammer = new Programmer()
                    {
                        Name = name,
                        Username = username,
                        Password = password,
                        ExperienceLevel = experienceLevelSelec,
                        idManeger = manegerSelec
                    };

                    db.Users.Add(newProgrammer);
                    db.SaveChanges();

                    MessageBox.Show("Programador criado com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Erro ao criar Programador!");
                }
            }
        }
        // Função para inserir o gestor na base de dados
        private void SaveManager()
        {
            string name = tb_Name.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            if (name == "Nome") name = "";
            if (username == "Utilizador") username = "";
            if (password == "Senha") password = "";

            if (string.IsNullOrEmpty(name) ||
               string.IsNullOrEmpty(username) ||
               string.IsNullOrEmpty(password) ||
               cb_Department.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.");
                return;
            }

            Department departmentSelec = (Department)cb_Department.SelectedItem;
            string ManegerUsers = ts_ManegerUsername.Checked ? "True" : "False";

            using (var db = new iTasksContext())
            {
                try
                {
                    var nameUsers = db.Users.Any(n => n.Username == username);
                    if (nameUsers)
                    {
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
                            db.Users.Attach(SelectedProgrammer);
                            db.Users.Remove(SelectedProgrammer);
                            db.SaveChanges();
                            MessageBox.Show("Programador eliminado com sucesso!");
                            ClearFormFields();
                            SearchProgrammer();
                        }
                        catch
                        {
                            MessageBox.Show($"Erro ao eliminar programador.");
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
                        catch
                        {
                            MessageBox.Show("Erro ao eliminar gestor.");
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
