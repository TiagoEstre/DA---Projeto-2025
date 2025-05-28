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
        private void trocarForm(Form novoForm)
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
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Menu";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_home_96__1_;    
        }
        private void b_Users_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Utilizadores";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;
            trocarForm(new UserManagementForm());
        }

        private void b_Tasks_Click(object sender, EventArgs e)
        {
            p_Tasks.Visible = true;
        }

        private void b_TaskDetails_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Detalhes Tarefas";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;
        }

        private void b_OngoingTasks_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Tarefas Em Curso";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;
        }

        private void b_CompletedTasks_Click(object sender, EventArgs e)
        {
            l_NameForm.Text = "Tarefas Concluidas";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;
        }

        
    }
}
