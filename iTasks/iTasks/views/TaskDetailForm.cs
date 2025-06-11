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
    public partial class TaskDetailForm : Form
    {
        private Tasks selectedTasks;
        private Maneger currentManeger;

        public TaskDetailForm()
        {
            InitializeComponent();
            ConfirmUser();

        }

        private void ConfirmUser()
        {
            // Verifica se o utilizador logado é um gestor
            if (sessionManager.CurrentUser is Maneger maneger)
            {
                currentManeger = maneger;
                Value();
            }
            else
            {
                MessageBox.Show("Apenas gestores podem aceder a este formulário.");
                this.Close();
            }
        }
        private void Value()
        {
            cb_CurrentStatus.DataSource = Enum.GetValues(typeof(CurrentStatus)).Cast<CurrentStatus>().ToList();
            cb_CurrentStatus.SelectedIndex = -1;

            ListTaskType();
            ListProgrammer();
        }

        private void ListProgrammer()
        {
            try
            {
                using (var db = new iTasksContext())
                {
                    // Apenas programadores do gestor atual
                    var programadors = db.Users
                        .OfType<Programmer>()
                        .Where(p => p.idManeger.Id == currentManeger.Id)
                        .ToList();

                    cb_Programmer.DataSource = programadors;
                    cb_Programmer.DisplayMember = "Name";
                    cb_Programmer.ValueMember = "Id";
                    cb_Programmer.SelectedIndex = -1;
                }
            }
            catch
            {
                cb_Programmer.Text = "Erro ao carregar Programadores!";
            }
        }

        private void ListTaskType()
        {
            try
            {
                using (var db = new iTasksContext())
                {
                    var taskTypes = db.TaskTypes.ToList();
                    cb_TaskType.DataSource = taskTypes;
                    cb_TaskType.DisplayMember = "Name";
                    cb_TaskType.ValueMember = "Id";
                    cb_TaskType.SelectedIndex = -1;
                }
            }
            catch
            {
                cb_TaskType.Text = "Erro ao carregar Tipo de Tarefas!";
            }
        }

        private void b_create_Click(object sender, EventArgs e)
        {
            string descricao = tb_Description.Text;
            int order = int.Parse(tb_Order.Text.Trim());
            string storyPoint = tb_StoryPoints.Text;

            DateTime startDate = dtp_StartDate.Value.Date;
            DateTime endDate = dtp_EndDate.Value.Date;

            TaskType taskType = cb_TaskType.SelectedItem as TaskType;
            Programmer programmer = cb_Programmer.SelectedItem as Programmer;

            Maneger maneger = currentManeger;

            using (var db = new iTasksContext())
            {
                try
                {
                    db.Users.Attach(programmer);
                    db.Users.Attach(maneger);
                    db.TaskTypes.Attach(taskType);

                    var newTasks = new Tasks()
                    {
                        IdManeger = maneger,
                        IdProgrammer = programmer,
                        ExecutionOrder = order,
                        Description = descricao,
                        EstimatedStartDate = startDate,
                        ExpectedEndDate = endDate,
                        idTaskType = taskType,
                        StoryPoints = storyPoint,
                        CurrentStatus = CurrentStatus.ToDo,
                        CreationDate = DateTime.Now
                    };

                    db.Tasks.Add(newTasks);
                    db.SaveChanges();

                    selectedTasks = newTasks;

                    MessageBox.Show("Nova tarefa criada com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Erro ao criar tarefa na base de dados");
                }
            }
        }

        private void b_Read_Click(object sender, EventArgs e)
        {
            string descricao = tb_Description.Text;

            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Preenchimento obrigatório no campo da descrição");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    var tasks = db.Tasks
                        .Include(t => t.idTaskType)
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Description.Contains(descricao) && t.IdManeger.Id == currentManeger.Id);

                    if (tasks == null)
                    {
                        MessageBox.Show("Tarefa não encontrada ou não pertence a este gestor.");
                        return;
                    }

                    selectedTasks = tasks;

                    tb_Id.Text = tasks.Id.ToString();
                    dtp_StartRealDate.Value = tasks.ActualStartDate ?? DateTime.Today;
                    dtp_EndRealDate.Value = tasks.ActualEndDate ?? DateTime.Today;
                    dtp_CreationDate.Value = tasks.CreationDate;

                    cb_CurrentStatus.SelectedItem = tasks.CurrentStatus;
                    tb_Description.Text = tasks.Description;

                    if (tasks.idTaskType != null)
                        cb_TaskType.SelectedValue = tasks.idTaskType.Id;

                    if (tasks.IdProgrammer != null)
                        cb_Programmer.SelectedValue = tasks.IdProgrammer.Id;

                    tb_Order.Text = tasks.ExecutionOrder.ToString();
                    tb_StoryPoints.Text = tasks.StoryPoints;
                    dtp_StartDate.Value = tasks.EstimatedStartDate;
                    dtp_EndDate.Value = tasks.ExpectedEndDate;
                }
                catch
                {
                    MessageBox.Show("Erro ao consultar tarefa.");
                }
            }
        }

        private void b_Update_Click(object sender, EventArgs e)
        {
            if (selectedTasks == null)
            {
                MessageBox.Show("Nenhuma tarefa selecionada para edição. Por favor, procure uma tarefa primeiro.");
                return;
            }

            TaskType taskType = cb_TaskType.SelectedItem as TaskType;
            Programmer programmer = cb_Programmer.SelectedItem as Programmer;

            using (var db = new iTasksContext())
            {
                try
                {
                    var taskToUpdate = db.Tasks
                        .Include(t => t.idTaskType)
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Id == selectedTasks.Id && t.IdManeger.Id == currentManeger.Id);

                    if (taskToUpdate == null)
                    {
                        MessageBox.Show("A tarefa não foi encontrada ou não pertence a este gestor.");
                        return;
                    }

                    db.Users.Attach(programmer);
                    db.TaskTypes.Attach(taskType);

                    taskToUpdate.Description = tb_Description.Text;
                    taskToUpdate.ExecutionOrder = int.Parse(tb_Order.Text.Trim());
                    taskToUpdate.StoryPoints = tb_StoryPoints.Text;
                    taskToUpdate.EstimatedStartDate = dtp_StartDate.Value.Date;
                    taskToUpdate.ExpectedEndDate = dtp_EndDate.Value.Date;
                    taskToUpdate.ActualStartDate = dtp_StartRealDate.Value.Date;
                    taskToUpdate.ActualEndDate = dtp_EndRealDate.Value.Date;
                    taskToUpdate.CreationDate = dtp_CreationDate.Value;
                    taskToUpdate.CurrentStatus = (CurrentStatus)cb_CurrentStatus.SelectedItem;
                    taskToUpdate.idTaskType = taskType;
                    taskToUpdate.IdProgrammer = programmer;

                    db.SaveChanges();

                    selectedTasks = taskToUpdate;

                    MessageBox.Show("Tarefa atualizada com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Erro ao atualizar tarefa.");
                }
            }
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            if (selectedTasks == null)
            {
                MessageBox.Show("Nenhuma tarefa selecionada para apagar.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    var taskToDelete = db.Tasks
                        .FirstOrDefault(t => t.Id == selectedTasks.Id && t.IdManeger.Id == currentManeger.Id);

                    if (taskToDelete == null)
                    {
                        MessageBox.Show("A tarefa não foi encontrada ou não pertence a este gestor.");
                        return;
                    }

                    db.Tasks.Remove(taskToDelete);
                    db.SaveChanges();

                    MessageBox.Show("Tarefa apagada com sucesso!");
                    ClearFormFields();
                    selectedTasks = null;
                }
                catch
                {
                    MessageBox.Show("Erro ao apagar tarefa.");
                }
            }
        }

        private void ClearFormFields()
        {
            tb_Id.Text = "ID";
            tb_Description.Clear();
            tb_Order.Clear();
            tb_StoryPoints.Clear();
            dtp_StartDate.Value = DateTime.Today;
            dtp_EndDate.Value = DateTime.Today;
            dtp_StartRealDate.Value = DateTime.Today;
            dtp_EndRealDate.Value = DateTime.Today;
            dtp_CreationDate.Value = DateTime.Today;

            cb_CurrentStatus.SelectedIndex = -1;
            cb_CurrentStatus.Text = "";

            cb_TaskType.DataSource = null;
            cb_TaskType.Items.Clear();
            ListTaskType();

            cb_Programmer.DataSource = null;
            cb_Programmer.Items.Clear();
            ListProgrammer();
        }
    }
}
