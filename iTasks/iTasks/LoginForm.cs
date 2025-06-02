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

        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            string Name = tb_CrearteName.Text;
            string Username = tb_CrearteUsername.Text;
            string Password = tb_CreartePassword.Text;
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
            tb_Username.Text = "Utilizadores";

            if (tb_Username.Text == "Utilizadores")
            {
                tb_Username.Text = "";

                tb_Username.ForeColor = Color.Black;
            }
        }
        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Utilizadores";

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
