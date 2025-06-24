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
        private bool isReadOnlyMode;

        public TaskDetailForm(string Tasks)
        {
            InitializeComponent();
            ConfirmUser();
            Value();
            DateToUpdate();

        }
        private void DateToUpdate()
        {
            dtp_CreationDate.Value = DateTime.Now;
            dtp_StartDate.Value = DateTime.Now;
            dtp_EndDate.Value = DateTime.Now;
            dtp_StartRealDate.Value = DateTime.Now;
            dtp_EndRealDate.Value = DateTime.Now;
        }
        
        public TaskDetailForm(Tasks task, bool readOnly = false)
        {
            InitializeComponent();
            this.selectedTasks = task;
            this.isReadOnlyMode = readOnly;

            if (sessionManager.CurrentUser is Maneger manager)
            {
                currentManeger = manager;
                Value();
                
                if (selectedTasks != null)
                {
                    LoadTaskDetails(selectedTasks);
                    SetReadOnlyMode(isReadOnlyMode);
                }
                else
                {
                    SetupFormForCreation();
                }
            }
            else if (sessionManager.CurrentUser is Programmer programmer)
            {
                if (selectedTasks != null)
                {
                    Value();
                    LoadTaskDetails(selectedTasks);
                    SetReadOnlyMode(true);
                }
                else
                {
                    MessageBox.Show("Programadores não podem criar tarefas.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tipo de utilizador não autorizado a aceder a este formulário.");
                this.Close();
            }
        }

        private void SetupFormForCreation()
        {
            Value();
            tb_Id.Visible = false;
            dtp_StartRealDate.Visible = false;
            dtp_EndRealDate.Visible = false;
            dtp_CreationDate.Visible = false;

            
            b_create.Visible = true;
            b_Read.Visible = false;
            b_Update.Visible = false;
            b_Delete.Visible = false;
            
            ClearFormFields();
        }


        
        private void LoadTaskDetails(Tasks task)
        {
            tb_Id.Text = task.Id.ToString();
            tb_Description.Text = task.Description;
            tb_Order.Text = task.ExecutionOrder.ToString();
            tb_StoryPoints.Text = task.StoryPoints.ToString();

            dtp_StartDate.Value = task.EstimatedStartDate;
            dtp_EndDate.Value = task.ExpectedEndDate;
            dtp_CreationDate.Value = task.CreationDate;

            dtp_StartRealDate.Value = task.ActualStartDate ?? DateTime.Today;
            dtp_EndRealDate.Value = task.ActualEndDate ?? DateTime.Today;

            cb_CurrentStatus.SelectedItem = task.CurrentStatus;

            if (task.idTaskType != null)
                cb_TaskType.SelectedValue = task.idTaskType.Id;
            else
                cb_TaskType.SelectedIndex = -1;

            if (task.IdProgrammer != null)
                cb_Programmer.SelectedValue = task.IdProgrammer.Id;
            else
                cb_Programmer.SelectedIndex = -1;
        }

        private void SetReadOnlyMode(bool readOnly)
        {
            isReadOnlyMode = readOnly;

            tb_Description.ReadOnly = readOnly;
            tb_Order.ReadOnly = readOnly;
            tb_StoryPoints.ReadOnly = readOnly;

            dtp_StartDate.Enabled = !readOnly;
            dtp_EndDate.Enabled = !readOnly;
            dtp_CreationDate.Enabled = !readOnly;

            dtp_StartRealDate.Enabled = !readOnly;
            dtp_EndRealDate.Enabled = !readOnly;

            cb_CurrentStatus.Enabled = !readOnly;
            cb_TaskType.Enabled = !readOnly;
            cb_Programmer.Enabled = !readOnly;

            b_create.Visible = !readOnly && (sessionManager.CurrentUser is Maneger);
            b_Read.Visible = true;
            b_Update.Visible = !readOnly && (sessionManager.CurrentUser is Maneger);
            b_Delete.Visible = !readOnly && (sessionManager.CurrentUser is Maneger);

            if (readOnly)
            {
                b_create.Visible = false;
                b_Read.Visible = false;
                b_Update.Visible = false;
                b_Delete.Visible = false;
            }

            tb_Id.ReadOnly = true;
        }

        private void ConfirmUser()
        {
            if (sessionManager.CurrentUser is Maneger maneger)
            {
                currentManeger = maneger;
            }
            else if (sessionManager.CurrentUser is Programmer)
            {
            }
            else
            {
                MessageBox.Show("Apenas gestores e programadores podem aceder a este formulário.");
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
                    List<Programmer> programadors;
                    if (sessionManager.CurrentUser is Maneger manager)
                    {
                        programadors = db.Users
                            .OfType<Programmer>()
                            .Where(p => p.idManeger != null && p.idManeger.Id == manager.Id)
                            .ToList();
                    }
                    else
                    {
                        programadors = db.Users.OfType<Programmer>().ToList();
                    }

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
            int storyPoint = int.Parse(tb_StoryPoints.Text);

            DateTime startDate = dtp_StartDate.Value.Date;
            DateTime endDate = dtp_EndDate.Value.Date;

            TaskType taskType = cb_TaskType.SelectedItem as TaskType;
            Programmer programmer = cb_Programmer.SelectedItem as Programmer;

            Maneger maneger = currentManeger;

            if (isReadOnlyMode)
            {
                MessageBox.Show("Não pode criar tarefas no modo de visualização.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    bool orderExists = db.Tasks.Any(t => t.IdProgrammer.Id == programmer.Id
                                    && t.ExecutionOrder == order
                                    && t.IdManeger.Id == currentManeger.Id);

                    if (orderExists)
                    {
                        MessageBox.Show("Já existe uma tarefa com essa ordem para este programador sob sua gestão.");
                        return;
                    }

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
                    tb_StoryPoints.Text = tasks.StoryPoints.ToString();
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
            if (isReadOnlyMode)
            {
                MessageBox.Show("Não pode atualizar tarefas no modo de visualização.");
                return;
            }

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
                    taskToUpdate.StoryPoints = int.Parse(tb_StoryPoints.Text);
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
            if (isReadOnlyMode)
            {
                MessageBox.Show("Não pode apagar tarefas no modo de visualização.");
                return;
            }

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
