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
    public partial class KanbanForm : Form
    {
        private readonly Action<Form> _trocarForm;
        private Task selectedTask;

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
                                           .ToList();

                        b_NewTask.Visible = false;

                        var tasksToDo = tasksToDisplay
                            .Where(t => t.CurrentStatus == CurrentStatus.ToDo)
                            .OrderByDescending(t => t.IdProgrammer != null && t.IdProgrammer.Id == programmer.Id)
                            .ToList();

                        var tasksDoing = tasksToDisplay
                            .Where(t => t.CurrentStatus == CurrentStatus.Doing)
                            .OrderByDescending(t => t.IdProgrammer != null && t.IdProgrammer.Id == programmer.Id)
                            .ToList();

                        var tasksDone = tasksToDisplay
                            .Where(t => t.CurrentStatus == CurrentStatus.Done)
                            .OrderByDescending(t => t.IdProgrammer != null && t.IdProgrammer.Id == programmer.Id)
                            .ToList();

                        UpdateListBoxWithColor(lb_ToDo, tasksToDo, programmer.Id);
                        UpdateListBoxWithColor(lb_Doing, tasksDoing, programmer.Id);
                        UpdateListBoxWithColor(lb_Done, tasksDone, programmer.Id);
                    }
                    else if (currentUser is Maneger manager)
                    {
                        var assocaciatedProgrammers = db.Users
                            .OfType<Programmer>()
                            .Include(p => p.idManeger)
                            .Where(p => p.idManeger != null && p.idManeger.Id == manager.Id)
                            .ToList();

                        var programmerIds = assocaciatedProgrammers.Select(p => p.Id).ToList();

                        tasksToDisplay = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.idTaskType)
                            .Where(t => t.IdProgrammer != null && programmerIds.Contains(t.IdProgrammer.Id))
                            .ToList();

                        b_NewTask.Visible = true;

                        var tasksToDo = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.ToDo).ToList();
                        var tasksDoing = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Doing).ToList();
                        var tasksDone = tasksToDisplay
                            .Where(t => t.CurrentStatus == CurrentStatus.Done &&
                                        t.ActualStartDate != null &&
                                        t.ActualEndDate != null)
                            .ToList();

                        // Calcular médias por StroryPoints
                        var avgDurationsBySP = tasksDone
                            .GroupBy(t => t.StoryPoints)
                            .ToDictionary(
                                g => g.Key,
                                g => g.Average(t => (t.ActualEndDate.Value - t.ActualStartDate.Value).TotalHours)
                            );

                        // Atribuir estimativa individual e total
                        double totalEstimatedHours = 0;

                        foreach (var task in tasksToDo)
                        {
                            double estimated = 0;

                            if (avgDurationsBySP.ContainsKey(task.StoryPoints))
                            {
                                estimated = avgDurationsBySP[task.StoryPoints];
                            }
                            else if (avgDurationsBySP.Any())
                            {
                                var closestSP = avgDurationsBySP.Keys
                                    .OrderBy(sp => Math.Abs(sp - task.StoryPoints))
                                    .First();

                                estimated = avgDurationsBySP[closestSP];   
                            }

                            task.Description += $" ( {estimated:F1} h estimado)";
                            totalEstimatedHours += estimated;
                        }

                        // Atualiza as listBoxes com a descrições já alteradas
                        UpdateListBox(lb_ToDo, tasksToDo);
                        UpdateListBox(lb_Doing, tasksDoing);
                        UpdateListBox(lb_Done, tasksDone);

                    }
                    else
                    {
                        MessageBox.Show("Tipo de utilizador não reconhecido ou sem permissões para visualizar tarefas.");
                        b_NewTask.Visible = false;

                        lb_ToDo.DataSource = null;
                        lb_ToDo.Items.Clear();
                        lb_Doing.DataSource = null;
                        lb_Doing.Items.Clear();
                        lb_Done.DataSource = null;
                        lb_Done.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar tarefas: {ex.Message}");
                }
            }
        }

        private void UpdateListBoxWithColor(ListBox listBox, List<Tasks> tasks, int currentUserId)
        {
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.Items.Clear();

            foreach (var task in tasks.OrderBy(t => t.ExecutionOrder))
            {
                listBox.Items.Add(task);
            }

            listBox.DrawItem -= ListBox_DrawItem;
            listBox.DrawItem += ListBox_DrawItem;
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var listBox = sender as ListBox;
            var item = listBox.Items[e.Index] as Tasks;
            var currentUser = sessionManager.CurrentUser as Programmer;
            bool isMine = item?.IdProgrammer != null && currentUser != null && item.IdProgrammer.Id == currentUser.Id;

            e.DrawBackground();
            using (Brush brush = new SolidBrush(isMine ? Color.Green : Color.Red))
            {
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void b_NewTask_Click(object sender, EventArgs e)
        {
            _trocarForm(new TaskDetailForm(null));
        }

        private void b_ExecuteTask_Click(object sender, EventArgs e)
        {
            if (lb_ToDo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa na coluna 'To Do' para iniciar.");
                return;
            }

            Tasks taskToUpdateStatus = lb_ToDo.SelectedItem as Tasks;

            if (taskToUpdateStatus == null || taskToUpdateStatus.CurrentStatus != CurrentStatus.ToDo)
            {
                MessageBox.Show("A tarefa selecionada não é válida ou não está no estado 'To Do'.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    var taskInDb = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Id == taskToUpdateStatus.Id);

                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
                    }

                    if (sessionManager.CurrentUser is Programmer prog)
                    {
                        if (taskInDb.IdProgrammer == null || taskInDb.IdProgrammer.Id != prog.Id)
                        {
                            MessageBox.Show("Não pode mover tarefas que não lhe estão atribuídas.");
                            lb_ToDo.SelectedItem = null;
                            return;
                        }

                        int doingCount = db.Tasks.Count(t => t.IdProgrammer.Id == prog.Id && t.CurrentStatus == CurrentStatus.Doing);

                        if (doingCount >= 2)
                        {
                            MessageBox.Show("Já possui duas tarefas em execução (Doing). Termine uma antes de iniciar outra.");
                            return;
                        }

                        var nextTask = db.Tasks
                                .Where(t => t.IdProgrammer.Id == prog.Id && t.CurrentStatus == CurrentStatus.ToDo)
                                .OrderBy(t => t.ExecutionOrder)
                                .FirstOrDefault();

                        if (nextTask != null && nextTask.Id != taskInDb.Id)
                        {
                            MessageBox.Show("Deve executar as tarefas pela ordem definida (ex: 1, 2, 3...).");
                            return;
                        }
                    }

                    taskInDb.CurrentStatus = CurrentStatus.Doing;
                    taskInDb.ActualStartDate = DateTime.Now;

                    db.SaveChanges();

                    VerifyUsers();
                }
                catch
                {
                    MessageBox.Show("Erro ao mover tarefa");
                }
            }
        }

        private void b_FinishTask_Click(object sender, EventArgs e)
        {
            if (lb_Doing.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa na coluna 'Doing' para finalizar.");
                return;
            }

            Tasks taskToUpdateStatus = lb_Doing.SelectedItem as Tasks;

            if (taskToUpdateStatus == null || taskToUpdateStatus.CurrentStatus != CurrentStatus.Doing)
            {
                MessageBox.Show("A tarefa selecionada não é válida ou não está no estado 'Doing'.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    var taskInDb = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Id == taskToUpdateStatus.Id);

                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
                    }

                    if (sessionManager.CurrentUser is Programmer prog)
                    {
                        if (taskInDb.IdProgrammer == null || taskInDb.IdProgrammer.Id != prog.Id)
                        {
                            MessageBox.Show("Não pode mover tarefas que não lhe estão atribuídas.");
                            lb_Doing.SelectedItem = null;
                            return;
                        }
                    }

                    taskInDb.CurrentStatus = CurrentStatus.Done;
                    taskInDb.ActualEndDate = DateTime.Now;

                    db.SaveChanges();

                    VerifyUsers();
                }
                catch
                {
                    MessageBox.Show("Erro ao mover tarefa");
                }
            }
        }

        private void b_RestartTask_Click(object sender, EventArgs e)
        {
            Tasks taskToRetrocede = null;
            ListBox sourceListBox = null;

            if (lb_Done.SelectedItem != null)
            {
                taskToRetrocede = lb_Done.SelectedItem as Tasks;
                sourceListBox = lb_Done;
            }
            else if (lb_Doing.SelectedItem != null)
            {
                taskToRetrocede = lb_Doing.SelectedItem as Tasks;
                sourceListBox = lb_Doing;
            }
            else if (lb_ToDo.SelectedItem != null)
            {
                taskToRetrocede = lb_ToDo.SelectedItem as Tasks;
                sourceListBox = lb_ToDo;
            }

            if (taskToRetrocede == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa para retroceder.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    var taskInDb = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Id == taskToRetrocede.Id);

                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
                    }

                    if (sessionManager.CurrentUser is Programmer prog)
                    {
                        if (taskInDb.IdProgrammer == null || taskInDb.IdProgrammer.Id != prog.Id)
                        {
                            MessageBox.Show("Não pode mover tarefas que não lhe estão atribuídas.");
                            lb_Done.SelectedItem = null;
                            return;
                        }
                    }

                    switch (taskInDb.CurrentStatus)
                    {
                        case CurrentStatus.Doing:
                            taskInDb.CurrentStatus = CurrentStatus.ToDo;
                            taskInDb.ActualStartDate = null;
                            break;
                        case CurrentStatus.ToDo:
                            MessageBox.Show("A tarefa já está no estado 'To Do' e não pode ser retrocedida mais.");
                            return;
                        default:
                            MessageBox.Show("Estado da tarefa não reconhecido para retrocesso.");
                            return;
                    }

                    db.SaveChanges();
                    VerifyUsers();
                }
                catch
                {
                    MessageBox.Show("Erro ao retroceder tarefa");
                }
            }
        }

        private void UpdateListBox(ListBox listBox, List<Tasks> tasks)
        {
            listBox.Items.Clear();
            foreach (var task in tasks.OrderBy(t => t.ExecutionOrder))
            {
                listBox.Items.Add(task);
            }
        }

        private void lb_ToDo_DoubleClick(object sender, EventArgs e)
        {
            ListBox clickedListBox = sender as ListBox;

            if (clickedListBox != null && clickedListBox.SelectedItem != null)
            {
                Tasks selectedTask = clickedListBox.SelectedItem as Tasks;

                if (selectedTask != null)
                {
                    bool isReadOnly = (sessionManager.CurrentUser is Programmer);

                    _trocarForm(new TaskDetailForm(selectedTask, isReadOnly));
                }
            }
        }

        private void lb_Doing_DoubleClick(object sender, EventArgs e)
        {
            ListBox clickedListBox = sender as ListBox;

            if (clickedListBox != null && clickedListBox.SelectedItem != null)
            {
                Tasks selectedTask = clickedListBox.SelectedItem as Tasks;

                if (selectedTask != null)
                {
                    bool isReadOnly = (sessionManager.CurrentUser is Programmer);

                    _trocarForm(new TaskDetailForm(selectedTask, isReadOnly));
                }
            }
        }

        private void lb_Done_DoubleClick(object sender, EventArgs e)
        {
            ListBox clickedListBox = sender as ListBox;

            if (clickedListBox != null && clickedListBox.SelectedItem != null)
            {
                Tasks selectedTask = clickedListBox.SelectedItem as Tasks;

                if (selectedTask != null)
                {
                    bool isReadOnly = (sessionManager.CurrentUser is Programmer);

                    _trocarForm(new TaskDetailForm(selectedTask, isReadOnly));
                }
            }
        }
        
        private void b_ExportCSV_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sessionManager.CurrentUser is Maneger maneger))
            {
                MessageBox.Show("Apenas gestores podem exportar tarefas.");
                return;
            }

            using(var db = new iTasksContext())
            {
                try
                {
                    var associatedProgrammer = db.Users
                        .OfType<Programmer>()
                        .Include(p => p.idManeger)
                        .Where(p => p.idManeger != null && p.idManeger.Id == maneger.Id)
                        .ToList();

                    var programmerIds = associatedProgrammer.Select(p => p.Id).ToList();

                    var doneTasks = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .Include(t => t.idTaskType)
                        .Where(t => t.CurrentStatus == CurrentStatus.Done &&
                                    t.IdProgrammer != null &&
                                    programmerIds.Contains(t.IdProgrammer.Id))
                        .ToList();

                    if (!doneTasks.Any())
                    {
                        MessageBox.Show("Não há tarefas concluidas para exportar.");
                        return;
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "CVS files (*.csv)|*.csv",
                        FileName = "TarefasConcluídas.csv"
                    };


                    var sb = new StringBuilder();
                    sb.AppendLine("Programador;Descricao;DataPrevistaInicio;DataPrevista;TipoTarefa;DataRealInicio;DataRealFim");

                    foreach (var task in doneTasks)
                    {
                        string line = string.Join(";",
                                task.IdProgrammer?.Username ?? "N/A",
                                task.Description,
                                task.EstimatedStartDate.ToString("yyyy-MM-dd") ?? "",
                                task.ExpectedEndDate.ToString("yyyy-MM-dd") ?? "",
                                task.idTaskType?.Name ?? "",
                                task.ActualStartDate?.ToString("yyyy-MM-dd HH:mm") ?? "",
                                task.ActualEndDate?.ToString("yyyy-MM-dd HH:mm") ?? ""
                            );

                        sb.AppendLine(line);
                    }

                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Tarefas exportadas com sucesso.");
                    }
                    
                    
                }
                catch
                {
                    MessageBox.Show("Erro ao exportar tarefas");
                }
            }
        }
    }
}
