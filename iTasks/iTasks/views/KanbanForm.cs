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
    public partial class KanbanForm : Form
    {
        private readonly Action<Form> _trocarForm;
        public KanbanForm(Action<Form> trocarForm)
        {
            InitializeComponent();
            LoadCurrentUser();
            VerifyUsers();
            _trocarForm = trocarForm;
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
                        b_NewTask.Visible = false;
                    }

                }
                catch
                {
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }
        }


        private void b_NewTask_Click(object sender, EventArgs e)
        {
            _trocarForm(new TaskDetailForm());
        }
    }
}
