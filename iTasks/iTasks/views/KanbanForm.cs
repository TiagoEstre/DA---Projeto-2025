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
                                           .Where(t => t.IdProgrammer.Id == programmer.Id)
                                           .ToList();

                        b_NewTask.Visible = false;

                        var tasksToDo = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.ToDo).ToList();
                        var tasksDoing = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Doing).ToList();
                        var tasksDone = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Done).ToList();

                        lb_ToDo.DataSource = null;
                        lb_ToDo.Items.Clear();
                        lb_ToDo.DataSource = tasksToDo;
                        lb_ToDo.DisplayMember = "Description";

                        lb_Doing.DataSource = null;
                        lb_Doing.Items.Clear();
                        lb_Doing.DataSource = tasksDoing;
                        lb_Doing.DisplayMember = "Description";

                        lb_Done.DataSource = null;
                        lb_Done.Items.Clear();
                        lb_Done.DataSource = tasksDone;
                        lb_Done.DisplayMember = "Description";
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

                        b_NewTask.Visible = true;

                        var tasksToDo = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.ToDo).ToList();
                        var tasksDoing = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Doing).ToList();
                        var tasksDone = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Done).ToList();

                        lb_ToDo.DataSource = null;
                        lb_ToDo.Items.Clear();
                        lb_ToDo.DataSource = tasksToDo;
                        lb_ToDo.DisplayMember = "Description";
                        lb_ToDo.ClearSelected();

                        lb_Doing.DataSource = null;
                        lb_Doing.Items.Clear();
                        lb_Doing.DataSource = tasksDoing;
                        lb_Doing.DisplayMember = "Description";
                        lb_Doing.ClearSelected();

                        lb_Done.DataSource = null;
                        lb_Done.Items.Clear();
                        lb_Done.DataSource = tasksDone;
                        lb_Done.DisplayMember = "Description";
                        lb_Done.ClearSelected();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de utilizador não reconhecido ou sem permissões para visualizar tarefas.");
                        b_NewTask.Visible = false;
                        lb_ToDo.DataSource = null;
                        lb_ToDo.Items.Clear();
                        lb_Doing.DataSource = null; // Limpa também outras listas
                        lb_Doing.Items.Clear();
                        lb_Done.DataSource = null;  // Limpa também outras listas
                        lb_Done.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar tarefas: {ex.Message}");
                }
            }
        }


        private void b_NewTask_Click(object sender, EventArgs e)
        {
            _trocarForm(new TaskDetailForm());
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
                    var taskInDb = db.Tasks.Find(taskToUpdateStatus.Id);

                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
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
                MessageBox.Show("Por favor, selecione uma tarefa na coluna 'To Do' para iniciar.");
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
                    var taskInDb = db.Tasks.Find(taskToUpdateStatus.Id);

                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
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
                    var taskInDb = db.Tasks.Find(taskToRetrocede.Id);

                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
                    }

                    switch (taskInDb.CurrentStatus)
                    {
                        case CurrentStatus.Done:
                            taskInDb.CurrentStatus = CurrentStatus.Doing;
                            taskInDb.ActualEndDate = null;
                            break;
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
    }
}
