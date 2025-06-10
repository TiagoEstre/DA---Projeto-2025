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
    public partial class TaskTypeForm : Form
    {
        private TaskType SelectedTaskType;
        private readonly Action<Form> _trocarForm;
        public TaskTypeForm(Action<Form> trocarForm)
        {
            InitializeComponent();
            _trocarForm = trocarForm;
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
            var currentUser = sessionManager.CurrentUser;

            string name = currentUser.Name;


            using (var db = new iTasksContext())
            {
                try
                {
                    var Managers = db.Users
                        .OfType<Maneger>()
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)))
                        .ToList();

                    if (Managers.Count == 0)
                    {
                        b_Create.Visible = false;
                        b_read.Visible = false;
                        b_Update.Visible = false;
                        b_Delete.Visible = false;
                    }

                }
                catch
                {
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }
        }




        // Codigo Botões
        // Botão Criar
        private void b_Create_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;

            using (var db = new iTasksContext())
            {
                var newTypeTasks = new TaskType()
                {
                    Name = name,
                };

                db.TaskTypes.Add(newTypeTasks);
                db.SaveChanges();
            }
        }

        // Botão Procurar
        private void b_read_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;

            if (name == "Nome") name = "";

            using (var db = new iTasksContext())
            {
                try
                {
                    var tasksType = db.TaskTypes
                        .OfType<TaskType>()
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)))
                        .ToList();

                    if (tasksType.Count == 0)
                    {
                        lb_TaskTipe.DataSource = null;
                        return;
                    }


                    lb_TaskTipe.SelectedIndexChanged -= lb_TaskTipe_SelectedIndexChanged;

                    lb_TaskTipe.DataSource = tasksType;
                    lb_TaskTipe.DisplayMember = "Name";
                    lb_TaskTipe.ValueMember = "Id";
                    lb_TaskTipe.ClearSelected();

                    lb_TaskTipe.SelectedIndexChanged += lb_TaskTipe_SelectedIndexChanged;
                }
                catch
                {
                    MessageBox.Show("Erro ao consultar Tipo de Tarefa");
                }
            }
        }


        // Botão Iditar
        private void lb_TaskTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_TaskTipe.SelectedItem == null)
                return;

            var selectedTaskType = lb_TaskTipe.SelectedItem as TaskType;

            if (selectedTaskType == null) return;

            SelectedTaskType = selectedTaskType;
            tb_Id.Text = selectedTaskType.Id.ToString();
            tb_Name.Text = selectedTaskType.Name;
        }

        private void b_Update_Click(object sender, EventArgs e)
        {
            if (SelectedTaskType != null)
            {
                string name = tb_Name.Text;

                SelectedTaskType.Name = name;

                //Atualizar na base de dados
                using (var db = new iTasksContext())
                {
                    db.Entry(SelectedTaskType).State = EntityState.Modified;
                    db.SaveChanges();

                    b_read_Click(null, null);
                }
            }
        }


        // Botão Eliminar

        private void b_Delete_Click(object sender, EventArgs e)
        {
            if (SelectedTaskType != null)
            {
                try
                {
                    using (var db = new iTasksContext())
                    {
                        var taskToDelete = db.TaskTypes.Find(SelectedTaskType.Id);

                        if (taskToDelete == null)
                        {
                            MessageBox.Show("A Tarefa selecionada não foi encontrada na base de dados.");
                            return;
                        }

                        db.TaskTypes.Remove(taskToDelete);
                        db.SaveChanges();

                        tb_Id.Clear();
                        tb_Name.Clear();
                        SelectedTaskType = null;

                        tb_Id.Text = "";
                        tb_Name.Text = "";

                        b_read_Click(null, null);

                        MessageBox.Show("Tarefa removida com sucesso.");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao remover tarefa");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa da lista para remover.");
            }
        }
    }
}
