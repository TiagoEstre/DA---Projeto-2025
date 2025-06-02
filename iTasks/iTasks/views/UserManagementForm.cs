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

namespace iTasks.views
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();

            Enum.GetValues(typeof(ExperienceLevel));
            Enum.GetValues(typeof(Department));
            cb_ExperienceLevel.DataSource = Enum.GetValues(typeof(ExperienceLevel));
            cb_Department.DataSource = Enum.GetValues(typeof(Department));
        }

        private void cb_Programmer_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Programmer.Checked)
            {
                cb_Manager.Checked = false;
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
            if (cb_Manager.Checked)
            {
                cb_Programmer.Checked = false;
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
        public class ListManager
        {
            public Maneger Maneger { get; set; }
        }

        public class ListProgrmmer
        {
            public Programmer Programmer { get; set; }
        }

        // Funções
        // Função para Salvar novo Usuário
        private void SaveManager(Maneger Maneger)
        {
            using (var db = new iTasksContext())
            {
                db.Users.Add(Maneger);
                db.SaveChanges();
            }
        }
        private void SaveProgrammer(Programmer Programmer)
        {
            using (var db = new iTasksContext())
            {
                db.Users.Add(Programmer);
                db.SaveChanges();
            }
        }

        private void b_Create_Click(object sender, EventArgs e)
        {
            string Name = tb_Name.Text;
            string Users = tb_Username.Text;
            string Password = tb_Password.Text;
        }
    }
}
