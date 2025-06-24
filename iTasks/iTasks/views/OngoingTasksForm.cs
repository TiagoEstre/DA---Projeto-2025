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
            Value();
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

            using (var db = new iTasksContext())
            {
                try
                {
                    if (currentUser is Programmer programmer)
                    {
                        
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

                        allTasks = taskViewModels;
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
        private void Value()
        {
            try
            {
                // Cria um contexto de base de dados
                using (var db = new iTasksContext())
                {
                    // Obtem a lista de tipos de tarefas da base de dados
                    var TakssType = db.TaskTypes.ToList();

                    // Adiciona uma opção adicional no início da lista para exibir todos as Tarefas
                    TakssType.Insert(0, new TaskType { Id = -1, Name = "Todos as Tarefas" });

                    cb_FilterTypeTasks.DataSource = TakssType;    // Define as propriadades do ComboBox com os dados carregados
                    cb_FilterTypeTasks.DisplayMember = "Name";    // Propriedade a ser exibida no ComboBox
                    cb_FilterTypeTasks.ValueMember = "Id";        // Valor associado a cada item do ComboBox
                    cb_FilterTypeTasks.SelectedIndex = 0;         // Seleciona o primeiro item por padrão
                }
            }
            catch
            {
                // Caso ocorra um erro ao carregar os dados, exibe uma mensagem no ComboBox
                cb_FilterTypeTasks.Text = "Erro ao carregar as Tarefas!";
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
        
        
        private void tb_filterProgrammer_TextChanged(object sender, EventArgs e)
        {
            var currentUser = sessionManager.CurrentUser;

            string filterText = tb_filterProgrammer.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filterText))
            {
                dgv_Tasks.DataSource = allTasks;
                dgv_Tasks.ClearSelection();
                return;
            }

            if (currentUser is Maneger maneger)
            {
                var filtered = allTasks
                    .Where(t => t.ProgrammerName.ToLower().Contains(filterText))
                    .ToList();

                dgv_Tasks.DataSource = filtered;
                dgv_Tasks.ClearSelection();
            }
            else if (currentUser is Programmer programmer)
            {
                var filtered = allTasks
                    .Where(t => t.Description != null && t.Description.ToLower().Contains(filterText))
                    .ToList();

                dgv_Tasks.DataSource = filtered;
                dgv_Tasks.ClearSelection();
            }
            
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

        private void cb_FilterTypeTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se o item selecionado é do tipo TaskType
            if (cb_FilterTypeTasks.SelectedItem is TaskType selectedTask)
            {
                // Chama o método para filtrar as tarefas
                FiltrarTarefas(selectedTask.Id);
            }
        }
        private void FiltrarTarefas(int tasksId)
        {
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return;
            }

            try
            {
                using (var db = new iTasksContext())
                {
                    List<Tasks> filteredTasks;

                    if (sessionManager.CurrentUser is Maneger maneger)
                    {
                        var programmerIds = db.Users
                            .OfType<Programmer>()
                            .Where(p => p.idManeger.Id == maneger.Id)
                            .Select(p => p.Id)
                            .ToList();

                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.idTaskType)
                            .Where(t => programmerIds.Contains(t.IdProgrammer.Id));

                        if (tasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == tasksId);
                        }

                        filteredTasks = query.ToList();
                    }
                    else if (sessionManager.CurrentUser is Programmer programmer)
                    {
                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.idTaskType)
                            .Where(t => t.IdProgrammer.Id == programmer.Id);

                        if (tasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == tasksId);
                        }

                        filteredTasks = query.ToList();
                    }
                    else
                    {
                        filteredTasks = new List<Tasks>();
                    }

                    var viewModels = filteredTasks.Select(t =>
                    {
                        int daysRemaining = (t.ExpectedEndDate - DateTime.Today).Days;
                        return new TaskViewModel
                        {
                            Description = t.Description,
                            ProgrammerName = t.IdProgrammer?.Name ?? "",
                            ExpectedEndDate = t.ExpectedEndDate,
                            DaysRemaining = daysRemaining >= 0 ? daysRemaining : 0,
                            DaysLate = daysRemaining < 0 ? -daysRemaining : 0,
                        };
                    }).ToList();

                    allTasks = viewModels;
                    dgv_Tasks.DataSource = viewModels;
                    dgv_Tasks.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar tarefas.\n" + ex.Message);
            }
        }
    }
}
