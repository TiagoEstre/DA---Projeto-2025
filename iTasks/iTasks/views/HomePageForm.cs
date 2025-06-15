using iTasks.controller;
using iTasks.models;
using iTasks.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks.views
{
    public partial class HomePageForm : Form
    {
        private Form formAtivo;
        public HomePageForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            trocarForm(new KanbanForm(trocarForm));
            VerifyUsers();

        }

        private void LoadCurrentUser()
        {
            if (sessionManager.IsLoggedIn())
            {
                var currentUser = sessionManager.CurrentUser;

                b_User.Text = currentUser.Name;
            }
        }
        private void VerifyUsers()
        {
            var currentUser = sessionManager.CurrentUser;

            string name = currentUser.Name;


            using (var db = new iTasksContext())
            {
                try
                {
                    var Managers = db.Users
                        .OfType<Maneger>()
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)))
                        .ToList();

                    if (Managers.Count == 0)
                    {
                        b_Users.Visible = false;
                        p_ManagerApp.Size = new System.Drawing.Size(220, 60);
                    }


                }
                catch
                {
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }
        }
        

        // Codigo Para Mover Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void p_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Codigo para Mudar de Form
        public void trocarForm(Form novoForm)
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
                panelMessage.Controls.Remove(formAtivo);
            }

            formAtivo = novoForm;
            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;

            panelMessage.Controls.Add(novoForm);
            novoForm.Show();
        }

        // Codigo dos Botoes do Menu
        private void pb_Logo_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Menu";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_home_96__1_;
            trocarForm(new KanbanForm(trocarForm));
        }

        // Gestao
        private void b_ManagerApp_Click(object sender, EventArgs e)
        {
            bool isVisible = p_ManagerApp.Visible;

            p_Tasks.Visible = false;
            p_ManagerApp.Visible = !isVisible;
        }
        private void b_Users_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Utilizadores";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;
            trocarForm(new UserManagementForm());
        }
        private void b_TaskType_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Tipo de Tarefas";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;
            trocarForm(new TaskTypeForm(trocarForm));
        }

        // Tasks
        private void b_Tasks_Click(object sender, EventArgs e)
        {
            bool isVisible = p_Tasks.Visible;

            p_ManagerApp.Visible = false;
            p_Tasks.Visible = !isVisible;
        }
        private void b_OngoingTasks_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Tarefas Em Curso";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_tasks_96__1_;
            trocarForm(new OngoingTasksForm());
         
        }
        private void b_CompletedTasks_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Tarefas Concluidas";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_to_do_96;
            trocarForm(new CompletedTasksForm());
        }

        private void itb_logout_CheckedChanged(object sender, EventArgs e)
        {
            sessionManager.Logout();

            LoginForm loginForm = new LoginForm();

            Hide();
            loginForm.FormClosed += Closed_FormClosed;
            loginForm.ShowDialog();


        }

        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
