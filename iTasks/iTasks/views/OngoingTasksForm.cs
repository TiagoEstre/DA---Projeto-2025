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
        private List<TaskViewModel> allTasks = new List<TaskViewModel>();
        public OngoingTasksForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            VerifyUsers();
        }
        private void tb_filterProgrammer_TextChanged(object sender, EventArgs e)
        {
            string filterText = tb_filterProgrammer.Text.Trim().ToLower();


            var filtered = allTasks
                .Where(t => t.ProgrammerName.ToLower().Contains(filterText))
                .ToList();

            dgv_Tasks.DataSource = filtered;
            dgv_Tasks.ClearSelection();
        }
        private void dgv_Tasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Tasks.Rows[e.RowIndex].DataBoundItem is TaskViewModel task)
            {
                Color backColor;
                Color foreColor;

                if (task.DaysRemaining <= 7)
                {
                    backColor = Color.Red;
                    foreColor = Color.White;
                }
                else
                {
                    backColor = Color.LightGreen;
                    foreColor = Color.Black;
                }

                // Aplicar cores na linha toda
                foreach (DataGridViewCell cell in dgv_Tasks.Rows[e.RowIndex].Cells)
                {
                    cell.Style.BackColor = backColor;
                    cell.Style.ForeColor = foreColor;
                }
            }
        }
        private void LoadCurrentUser()
        {
            if (sessionManager.IsLoggedIn())
            {
                var currentUser = sessionManager.CurrentUser;
            }
        }

        public class TaskViewModel
        {
            public string Description { get; set; }
            public string ProgrammerName { get; set; }
            public DateTime? ExpectedEndDate { get; set; }
            public int DaysRemaining { get; set; }
            public int DaysLate { get; set; }
        }
        private void VerifyUsers()
        {
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return;
            }

            var currentUser = sessionManager.CurrentUser;

            using (var db = new iTasksContext())
            {
                try
                {
                    if (currentUser is Programmer programmer)
                    {
                        tb_filterProgrammer.Visible = false;
                        cb_FilterProjeto.Visible = false;
                        dgv_Tasks.Location = new Point(15, 23);
                        dgv_Tasks.Size = new Size(1266, 680);
                        dgv_Tasks.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

                        var tasks = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Where(t => t.IdProgrammer.Id == programmer.Id &&
                                          (t.CurrentStatus == CurrentStatus.ToDo || t.CurrentStatus == CurrentStatus.Doing))
                            .OrderBy(t => t.CurrentStatus)
                            .ToList();

                        var taskViewModels = tasks.Select(t =>
                        {
                            int estimatedDurationDays = (t.ExpectedEndDate - t.EstimatedStartDate).Days;
                            int daysElapsed = (DateTime.Today - (t.ActualStartDate ?? t.EstimatedStartDate)).Days;
                            int daysRemaining = estimatedDurationDays - daysElapsed;
                            if (daysRemaining < 0) daysRemaining = 0;

                            return new TaskViewModel
                            {
                                Description = t.Description,
                                ProgrammerName = t.IdProgrammer.Name,
                                ExpectedEndDate = t.ExpectedEndDate,
                                DaysRemaining = daysRemaining,
                                DaysLate = daysRemaining < 0 ? -daysRemaining : 0,
                            };
                        }).ToList();

                        dgv_Tasks.DataSource = taskViewModels;
                        dgv_Tasks.ClearSelection();

                    }
                    else if (currentUser is Maneger manager)
                    {
                        var programmerIds = db.Users
                            .OfType<Programmer>()
                            .Where(p => p.idManeger != null && p.idManeger.Id == manager.Id)
                            .Select(p => p.Id)
                            .ToList();

                        var tasks = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Where(t => programmerIds.Contains(t.IdProgrammer.Id) &&
                                          t.CurrentStatus != CurrentStatus.Done)
                            .ToList();

                        var taskViewModels = tasks.Select(t =>
                        {
                            int daysRemaining = (t.ExpectedEndDate - DateTime.Today).Days;

                            return new TaskViewModel
                            {
                                Description = t.Description,
                                ProgrammerName = t.IdProgrammer.Name,
                                ExpectedEndDate = t.ExpectedEndDate,
                                DaysRemaining = daysRemaining >= 0 ? daysRemaining : 0,
                                DaysLate = daysRemaining < 0 ? -daysRemaining : 0,
                            };
                        }).ToList();

                        allTasks = taskViewModels;
                        dgv_Tasks.DataSource = taskViewModels;
                        dgv_Tasks.ClearSelection();

                    }
                    else
                    {
                        MessageBox.Show("Tipo de utilizador não reconhecido ou sem permissões para visualizar tarefas.");

                        dgv_Tasks.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar tarefas." + ex.Message);
                }
            }
        }
    }
}
