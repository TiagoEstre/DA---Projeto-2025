using iTasks.controller;
using iTasks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iTasks.views
{
    public partial class TaskTypeForm : Form
    {
        private readonly Action<Form> _trocarForm;
        public TaskTypeForm(Action<Form> trocarForm)
        {
            InitializeComponent();
            _trocarForm = trocarForm;
            LoadCurrentUser();
            VerifyUsers();
        }

        private void LoadCurrentUser()
        {
            if (sessionManager.IsLoggedIn())
            {
                var currentUser = sessionManager.CurrentUser;
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
                        b_Create.Visible = false;
                        b_read.Visible = false;
                        b_Update.Visible = false;
                        b_Delete.Visible = false;
                    }

                }
                catch
                {
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }
        }

        private void b_read_Click(object sender, EventArgs e)
        {
            _trocarForm(new TaskDetailForm());
        }

        private void tb_Description_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_Description.Text?.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                lb_TaskTipe.DataSource = null;
                return;
            }

            try
            {
                using (var db = new iTasksContext())
                {
                    var filteredList = db.Tasks
                        .Where(t => t.Description.ToLower().Contains(searchText))
                        .Select(t => t.Description)
                        .Distinct()
                        .Take(10)
                        .ToList();
                    lb_TaskTipe.DataSource = filteredList;
                }
            }
            catch (Exception ex)
            {
                lb_TaskTipe.DataSource = new List<string> { $"Erro: {ex.Message}" };
            }
        }
    }
}
