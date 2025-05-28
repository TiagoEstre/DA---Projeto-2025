using iTasks.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            if (username == "admin" || password == "admin")
            {
                HomePageForm homePage = new HomePageForm();

                Hide();
                homePage.FormClosed += Closed_FormClosed;
                homePage.ShowDialog();
            }
        }

        
    }
}
