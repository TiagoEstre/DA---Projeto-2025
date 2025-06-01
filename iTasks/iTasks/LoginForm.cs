using iTasks.Migrations;
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
            MessageBox.Show("LoginForm_Load executado");
            if (ExistemUtilizadores())
            {
                InitializeComponent();
                Pl_Login.Visible = true;
                Pl_Register.Visible = false;
                
            }
            else
            {
                InitializeComponent();
                Pl_Register.Visible = true;
                Pl_Login.Visible = false;
                
            }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        
        
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void bt_ViewRegister_Click(object sender, EventArgs e)
        {
            Pl_Register.Visible = true;
            Pl_Login.Visible = false;
        }
        private void ButtonViewLogin_Click(object sender, EventArgs e)
        {
            Pl_Login.Visible = true;
            Pl_Register.Visible = false;
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            string Name = tb_Name.Text;
            string Surname = tb_Surname.Text;
            string Password = tb_CreartePassword.Text;
            string ConfirmPassword = tb_CreateConfirmPassword.Text;


        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            HomePageForm homePage = new HomePageForm();

            Hide();
            homePage.FormClosed += Closed_FormClosed;
            homePage.ShowDialog();
        }

        
    }
}
