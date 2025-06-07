using iTasks.Migrations;
using iTasks.models;
using iTasks.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        // Funcoes para confirmar se ja ixiste um ultizador
        private bool ExistemUtilizadores()
        {

            try
            {
                using (var db = new iTasksContext())
                {
                    return db.Users.Any();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceder à base de dados: " + ex.Message);
                return false;
            }

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            if (ExistemUtilizadores())
            {
                Pl_Login.Visible = true;
                Pl_Register.Visible = false;
            }
            else
            {
                Pl_Login.Visible = false;
                Pl_Register.Visible = true;
            }
                
        }


        // funcao para fechar o form
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }


        // Register
        private void tb_CreateName_Enter(object sender, EventArgs e)
        {
            tb_CreateName.Text = "Nome";

            if (tb_CreateName.Text == "Nome")
            {
                tb_CreateName.Text = "";

                tb_CreateName.ForeColor = Color.Black;
            }
        }
        private void tb_CreateName_Leave(object sender, EventArgs e)
        {
            if (tb_CreateName.Text == "")
            {
                tb_CreateName.Text = "Nome";

                tb_CreateName.ForeColor = Color.Silver;
            }
        }

        private void tb_CreateUsername_Enter(object sender, EventArgs e)
        {
            tb_CreateUsername.Text = "Utilizador";

            if (tb_CreateUsername.Text == "Utilizador")
            {
                tb_CreateUsername.Text = "";

                tb_CreateUsername.ForeColor = Color.Black;
            }
        }
        private void tb_CreateUsername_Leave(object sender, EventArgs e)
        {
            if (tb_CreateUsername.Text == "")
            {
                tb_CreateUsername.Text = "Utilizador";

                tb_CreateUsername.ForeColor = Color.Silver;
            }
        }

        private void tb_CreatePassword_Enter(object sender, EventArgs e)
        {
            tb_CreatePassword.Text = "Senha";

            if (tb_CreatePassword.Text == "Senha")
            {
                tb_CreatePassword.Text = "";

                tb_CreatePassword.UseSystemPasswordChar = true;

                tb_CreatePassword.ForeColor = Color.Black;
            }
        }
        private void tb_CreatePassword_Leave(object sender, EventArgs e)
        {
            if (tb_CreatePassword.Text == "")
            {
                tb_CreatePassword.Text = "Senha";

                tb_CreatePassword.UseSystemPasswordChar = false;

                tb_CreatePassword.ForeColor = Color.Silver;
            }
        }

        private void tb_CreateConfirmPassword_Enter(object sender, EventArgs e)
        {
            tb_CreateConfirmPassword.Text = "Confirmar Senha";

            if (tb_CreateConfirmPassword.Text == "Confirmar Senha")
            {
                tb_CreateConfirmPassword.Text = "";

                tb_CreateConfirmPassword.UseSystemPasswordChar = true;

                tb_CreateConfirmPassword.ForeColor = Color.Black;
            }
        }
        private void tb_CreateConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (tb_CreateConfirmPassword.Text == "")
            {
                tb_CreateConfirmPassword.Text = "Confirmar Senha";

                tb_CreateConfirmPassword.UseSystemPasswordChar = false;

                tb_CreateConfirmPassword.ForeColor = Color.Silver;
            }
        }


        private void bt_Register_Click(object sender, EventArgs e)
        {
            string Name = tb_CreateName.Text;
            string Username = tb_CreateUsername.Text;
            string Password = tb_CreatePassword.Text;
            string ConfirmPassword = tb_CreateConfirmPassword.Text;

            if(Password != ConfirmPassword)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    var newUser = new Maneger()
                    {
                        Name = Name,
                        Username = Username,
                        Password = Password,
                        Department = Department.Administração,
                        GenerateUser = "True"
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    Pl_Register.Visible = false;
                    Pl_Login.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Não Foi Possivel Aceder a Base de Dados");
                    return;
                }
            }
        }

        // Login
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


        private void bt_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            if(username == "Utilizadores" || password == "Senha")
            {
                MessageBox.Show("Todos os Campos são de prencimento Obrigadorio.");
                return;
            }

            using(var db = new iTasksContext())
            {
                var utilizador = db.Users.FirstOrDefault(x => x.Username == username);

                if (utilizador != null && utilizador.Password == password)
                {
                    HomePageForm homePage = new HomePageForm();

                    Hide();
                    homePage.FormClosed += Closed_FormClosed;
                    homePage.ShowDialog();
                }
            } 
        }

        
    }
}
