using iTasks.controller;
using iTasks.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace iTasks.views
{
    public partial class CompletedTasksForm : Form
    {
        public CompletedTasksForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            VerifyUsers();
        }

        private void dgv_Done_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Done.Columns[e.ColumnIndex].Name == "DurationInDays")
            {
                var row = dgv_Done.Rows[e.RowIndex];
                var durationObj = row.Cells["DurationInDays"].Value;
                var expectedObj = row.Cells["ExpectedDurationInDays"].Value;

                if (durationObj != null && expectedObj != null &&
                    int.TryParse(durationObj.ToString(), out int duration) &&
                    int.TryParse(expectedObj.ToString(), out int expected))
                {
                    Color backColor;
                    Color foreColor;

                    if (duration > expected)
                    {
                        backColor = Color.Red;
                        foreColor = Color.White;
                    }
                    else
                    {
                        backColor = Color.Green;
                        foreColor = Color.Black;
                    }

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = backColor;
                        cell.Style.ForeColor = foreColor;
                    }
                }

            }
        }

        private void LoadCurrentUser()
        {
            if (!sessionManager.IsLoggedIn())
            {
                MessageBox.Show("Utilizador não autenticado.");
                this.Close();
            }
        }

        // ViewModel comum a ambos os tipos de utilizador
        public class TaskViewModel
        {
            public string ProgrammerName { get; set; } // Opcional
            public string Description { get; set; }
            public DateTime? ActualStartDate { get; set; }
            public DateTime? ActualEndDate { get; set; }
            public int? DurationInDays { get; set; }
            public int? ExpectedDurationInDays { get; set; }
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
                    List<Tasks> tasksDone;

                    if (currentUser is Programmer programmer)
                    {
                        tasksDone = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Where(t => t.IdProgrammer.Id == programmer.Id && t.CurrentStatus == CurrentStatus.Done)
                            .ToList();

                        var taskViewModels = tasksDone.Select(t => new TaskViewModel
                        {
                            Description = t.Description,
                            ActualStartDate = t.ActualStartDate,
                            ActualEndDate = t.ActualEndDate,
                            DurationInDays = t.ActualStartDate.HasValue && t.ActualEndDate.HasValue
                                ? (int?)(t.ActualEndDate.Value - t.ActualStartDate.Value).TotalDays
                                : null
                        }).ToList();

                        dgv_Done.DataSource = taskViewModels;
                        dgv_Done.ClearSelection();
                        dgv_Done.CurrentCell = null;
                    }
                    else if (currentUser is Maneger manager)
                    {
                        tasksDone = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.IdManeger)
                            .Where(t => t.IdManeger.Id == manager.Id && t.CurrentStatus == CurrentStatus.Done)
                            .ToList();

                        var taskViewModels = tasksDone.Select(t => new TaskViewModel
                        {
                            ProgrammerName = t.IdProgrammer?.Name,
                            Description = t.Description,
                            ActualStartDate = t.ActualStartDate,
                            ActualEndDate = t.ActualEndDate,
                            DurationInDays = t.ActualStartDate.HasValue && t.ActualEndDate.HasValue
                                ? (int?)(t.ActualEndDate.Value - t.ActualStartDate.Value).TotalDays
                                : null,
                            ExpectedDurationInDays = (int?)(t.ExpectedEndDate - t.EstimatedStartDate).TotalDays
                        }).ToList();

                        dgv_Done.DataSource = taskViewModels;
                        dgv_Done.ClearSelection();
                        dgv_Done.CurrentCell = null;
                    }
                    else
                    {
                        MessageBox.Show("Tipo de utilizador não reconhecido.");
                        dgv_Done.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar tarefas: " + ex.Message);
                }
            }
        }
    }
}
