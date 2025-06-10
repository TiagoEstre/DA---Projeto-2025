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

        }

    }
}
