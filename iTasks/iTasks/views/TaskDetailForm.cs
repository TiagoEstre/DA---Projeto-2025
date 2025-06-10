using iTasks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace iTasks.views
{
    public partial class TaskDetailForm : Form
    {
        private Tasks selectedTasks;
        public TaskDetailForm()
        {
            InitializeComponent();
            Value();
        }

        private void Value()
        {
            // Valores do Statos
            Enum.GetValues(typeof(CurrentStatus));
            cb_CurrentStatus.DataSource = Enum.GetValues(typeof(CurrentStatus)).Cast<CurrentStatus>().ToList();
            cb_CurrentStatus.SelectedIndex = -1;

            // Lista do Tipo de Tarefas
            ListTaskType();

            // Lista de Programadores
            ListProgrammer();

        }
        private void ListProgrammer()
        {
            try
            {
                using (var db = new iTasksContext())
                {
                    var programadors = db.Users.OfType<Programmer>().ToList();

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


        // Codigo Botões
        // Botão Criar
        private void b_create_Click(object sender, EventArgs e)
        {
            string descricao = tb_Description.Text;
            int order = int.Parse(tb_Order.Text.Trim());
            string storyPoint = tb_StoryPoints.Text;

            DateTime startDate = dtp_StartDate.Value.Date;
            DateTime endDate = dtp_EndDate.Value.Date;

            TaskType taskType = cb_TaskType.SelectedItem as TaskType;
            Programmer programmer = cb_Programmer.SelectedItem as Programmer;

            using (var db = new iTasksContext())
            {
                try
                {
                    db.Users.Attach(programmer);
                    var newTasks = new Tasks()
                    {
                        IdManeger = programmer.idManeger,
                        IdProgrammer = programmer,
                        ExecutionOrder = order,
                        Description = descricao,
                        EstimatedStartDate = startDate,
                        ExpectedEndDate = endDate,
                        idTaskType = taskType,
                        StoryPoints = storyPoint,
                        CurrentStatus = CurrentStatus.ToDo
                    };

                    db.Tasks.Add(newTasks);
                    db.SaveChanges();

                    selectedTasks = newTasks;

                    MessageBox.Show("Nova tarefa criada com sucesso!");

                }
                catch
                {
                    MessageBox.Show("Erro ao entra da base de dados");
                }

            }
        }

        // Botão Procurar
        private void b_Read_Click(object sender, EventArgs e)
        {
            string descricao = tb_Description.Text;

            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Preenchimento obrigatorio no campo da descrição");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    var tasks = db.Tasks
                        .Include(t => t.idTaskType)
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Description.Contains(descricao));


                    if (tasks == null)
                    {
                        MessageBox.Show("Tarefa não encontrada.");
                        return;
                    }

                    selectedTasks = tasks;

                    tb_Id.Text = tasks.Id.ToString();
                    dtp_StartRealDate.Value = tasks.ActualStartDate ?? DateTime.Today;
                    dtp_EndRealDate.Value = tasks.ActualEndDate ?? DateTime.Today;

                    cb_CurrentStatus.SelectedItem = tasks.CurrentStatus;
                    dtp_CreationDate.Value = tasks.CreationDate;

                    tb_Description.Text = tasks.Description;

                    if (tasks.idTaskType != null)
                    { cb_TaskType.SelectedValue = tasks.idTaskType.Id; }

                    if (tasks.IdProgrammer != null)
                    { cb_Programmer.SelectedValue = tasks.IdProgrammer.Id; }

                    tb_Order.Text = tasks.ExecutionOrder.ToString();
                    tb_StoryPoints.Text = tasks.StoryPoints;
                    dtp_StartDate.Value = tasks.EstimatedStartDate;
                    dtp_EndDate.Value = tasks.ExpectedEndDate;

                }
                catch
                {
                    MessageBox.Show("Erro ao consultar programadores");
                }
            }
        }

        // Botão Editar
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
                    db.Users.Attach(programmer);

                    var taskToUpdate = db.Tasks
                                         .Include(t => t.idTaskType)
                                         .Include(t => t.IdProgrammer)
                                         .FirstOrDefault(t => t.Id == selectedTasks.Id);

                    if (taskToUpdate == null)
                    {
                        MessageBox.Show("A tarefa não foi encontrada no banco de dados para atualização.");
                        return;
                    }

                    
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
                    MessageBox.Show($"Erro ao atualizar tarefa.");
                }
            }
        }

        // Delete
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
            cb_CurrentStatus.Text = string.Empty;

            cb_TaskType.DataSource = null;
            cb_TaskType.Items.Clear();
            cb_TaskType.Text = string.Empty;
            ListTaskType();
            cb_TaskType.SelectedIndex = -1;
            cb_TaskType.Text = string.Empty;

            cb_Programmer.DataSource = null;
            cb_Programmer.Items.Clear();
            cb_Programmer.Text = string.Empty;
            ListProgrammer();
            cb_Programmer.SelectedIndex = -1;
            cb_Programmer.Text = string.Empty;
        }
        private void b_Delete_Click(object sender, EventArgs e)
        {
            if (selectedTasks == null)
            {
                MessageBox.Show("Nenhuma tarefa selecionada para apagar. Por favor, procure uma tarefa primeiro.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    db.Tasks.Attach(selectedTasks);
                    db.Tasks.Remove(selectedTasks);

                    db.SaveChanges();

                    MessageBox.Show("Tarefa apagada com sucesso!");

                    ClearFormFields();
                    selectedTasks = null;
                }
                catch
                {
                    MessageBox.Show($"Erro ao apagar tarefa.");
                }
            }
        }
    }
}
