using iTasks.controller;
using iTasks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks.views
{
    public partial class OngoingTasksForm : Form
    {
        public OngoingTasksForm()
        {
            InitializeComponent();
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
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return;
            }

            var currentUser = sessionManager.CurrentUser;
            List<Tasks> tasksToDisplay = new List<Tasks>();

            using (var db = new iTasksContext())
            {
                try
                {
                    if (currentUser is Programmer programmer)
                    {
                        tasksToDisplay = db.Tasks
                                           .Include(t => t.IdProgrammer)
                                           .Include(t => t.idTaskType)
                                           .Where(t => t.IdProgrammer.Id == programmer.Id)
                                           .ToList();

                        var tasksDone = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Doing).ToList();

                        lb_Doing.DataSource = null;
                        lb_Doing.Items.Clear();
                        lb_Doing.DataSource = tasksDone;
                        lb_Doing.DisplayMember = "Description";
                    }
                    else if (currentUser is Maneger manager)
                    {
                        var associatedProgrammers = db.Users
                                                      .OfType<Programmer>()
                                                      .Include(p => p.idManeger)
                                                      .Where(p => p.idManeger != null && p.idManeger.Id == manager.Id)
                                                      .ToList();

                        var programmerIds = associatedProgrammers.Select(p => p.Id).ToList();

                        tasksToDisplay = db.Tasks
                                           .Include(t => t.IdProgrammer)
                                           .Include(t => t.idTaskType)
                                           .Where(t => programmerIds.Contains(t.IdProgrammer.Id))
                                           .ToList();



                        var tasksDone = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Doing).ToList();

                        lb_Doing.DataSource = null;
                        lb_Doing.Items.Clear();
                        lb_Doing.DataSource = tasksDone;
                        lb_Doing.DisplayMember = "Description";
                        lb_Doing.ClearSelected();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de utilizador não reconhecido ou sem permissões para visualizar tarefas.");

                        lb_Doing.DataSource = null;
                        lb_Doing.Items.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao carregar tarefas.");
                }
            }
        }
    }
}
