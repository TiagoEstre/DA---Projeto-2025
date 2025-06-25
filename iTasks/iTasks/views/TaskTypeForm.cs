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
        private TaskType SelectedTaskType;  // Armazena o tipo de tarefa atualmente selecionado


        public TaskTypeForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            VerifyUsers();
            resetList();
        }

        /* ---------- Funções de Inicialização  ---------- */
        // Método privado que carrega o usuário atual da sessão
        private void LoadCurrentUser()
        {
            // Verifica se há um usuário logado na sessão
            if (sessionManager.IsLoggedIn())
            {
                // Obtém o usuário atual da sessão e armazena na variável 'currentUser'
                var currentUser = sessionManager.CurrentUser;
            }
        }
        // Método privado que verifica se o usuário atual é um gestor (Manager)
        private void VerifyUsers()
        {
            // Obtém o usuário atual da sessão
            var currentUser = sessionManager.CurrentUser;

            // Armazena o nome do usuário atual em uma variável
            string name = currentUser.Name;

            // Cria uma nova instância do contexto do banco de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Consulta os usuários do tipo 'Maneger' cujo nome contenha o nome do usuário atual.
                    var Managers = db.Users
                        .OfType<Maneger>() // Atenção: a classe correta seria 'Manager' (com 'a') se for 'gerente' em inglês
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)))
                        .ToList();

                    // Se nenhum gestor for encontrado, ajusta a visibilidade dos botões na interface
                    if (Managers.Count == 0)
                    {
                        b_Create.Visible = false;
                        b_read.Visible = true;
                        b_Update.Visible = false;
                        b_Delete.Visible = false;
                    }
                }
                catch
                {
                    // Caso ocorra algum erro na consulta, exibe uma mensagem para o usuário
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }
        }




        /* ---------- Botões  ---------- */
        // Método que recarrega a lista de tipos de tarefa com base no filtro de nome
        private void resetList()
        {
            // Obtém o texto digitado na TextBox de nome
            string name = tb_Name.Text;

            // Se o valor ainda for o placeholder "Nome", considera como vazio
            if (name == "Nome") name = "";

            // Cria uma nova instância do contexto de banco de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Consulta todos os TaskTypes cujo nome contenha o texto informado,
                    // ou todos se o nome estiver vazio
                    var tasksType = db.TaskTypes
                        .OfType<TaskType>() // Filtra apenas entidades do tipo TaskType, caso a tabela tenha herança
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)))
                        .ToList();

                    // Se não houver resultados, limpa a listbox e encerra o método
                    if (tasksType.Count == 0)
                    {
                        lb_TaskTipe.DataSource = null;
                        return;
                    }

                    // Remove temporariamente o evento de seleção da ListBox para evitar execução durante a atualização
                    lb_TaskTipe.SelectedIndexChanged -= lb_TaskTipe_SelectedIndexChanged;

                    // Define os dados da listbox com os resultados encontrados
                    lb_TaskTipe.DataSource = tasksType;
                    lb_TaskTipe.DisplayMember = "Name"; // Define que o campo 'Name' será exibido na listbox
                    lb_TaskTipe.ValueMember = "Id";     // Define que o campo 'Id' será o valor associado ao item

                    // Limpa a seleção atual da listbox
                    lb_TaskTipe.ClearSelected();

                    // Reassocia o evento após carregar os dados
                    lb_TaskTipe.SelectedIndexChanged += lb_TaskTipe_SelectedIndexChanged;
                }
                catch
                {
                    // Exibe mensagem genérica em caso de erro
                    MessageBox.Show("Erro ao consultar Tipo de Tarefa");
                }
            }
        }
        // Método que limpa os campos do formulário
        private void ClearFormFields()
        {
            // Limpa o campo de texto do ID (provavelmente usado para exibição ou edição de um registro existente)
            tb_Id.Text = "";

            // Limpa o campo de nome (removendo qualquer texto digitado pelo usuário)
            tb_Name.Text = "";
        }
        // Evento disparado ao clicar no botão "Create" (Criar)
        private void b_Create_Click(object sender, EventArgs e)
        {
            // Obtém o texto digitado no campo de nome
            string name = tb_Name.Text;

            // Cria uma nova instância do contexto do banco de dados
            using (var db = new iTasksContext())
            {
                // Cria um novo objeto TaskType com o nome informado
                var newTypeTasks = new TaskType()
                {
                    Name = name,
                };

                // Adiciona o novo tipo de tarefa ao DbSet
                db.TaskTypes.Add(newTypeTasks);

                // Salva as alterações no banco de dados
                db.SaveChanges();

                // Limpa os campos do formulário após salvar
                ClearFormFields();
            }
        }
        // Evento disparado ao clicar no botão "Procurar" (Read)
        private void b_read_Click(object sender, EventArgs e)
        {
            // Obtém o texto digitado no campo de nome
            string name = tb_Name.Text;

            // Se o texto for o placeholder "Nome", considera como vazio para pesquisa
            if (name == "Nome") name = "";

            // Cria uma nova instância do contexto de banco de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Consulta os tipos de tarefa cujo nome contenha o texto digitado,
                    // ou retorna todos se o nome estiver vazio
                    var tasksType = db.TaskTypes
                        .OfType<TaskType>()
                        .Where(m =>
                            string.IsNullOrEmpty(name) || m.Name.Contains(name))
                        .ToList();

                    // Se não encontrar nenhum tipo de tarefa, atualiza a listbox e retorna
                    if (tasksType.Count == 0)
                    {
                        lb_TaskTipe.Text = "Não Existe tarefa escolhida.";
                        lb_TaskTipe.DataSource = null;
                        return;
                    }

                    // Remove temporariamente o evento para evitar disparos indesejados ao atualizar a lista
                    lb_TaskTipe.SelectedIndexChanged -= lb_TaskTipe_SelectedIndexChanged;

                    // Atualiza os dados da listbox com os tipos de tarefa encontrados
                    lb_TaskTipe.DataSource = tasksType;
                    lb_TaskTipe.DisplayMember = "Name";  // Mostra o nome do tipo de tarefa
                    lb_TaskTipe.ValueMember = "Id";      // Valor associado é o Id do tipo de tarefa
                    lb_TaskTipe.ClearSelected();         // Limpa qualquer seleção ativa

                    // Reassocia o evento após a atualização
                    lb_TaskTipe.SelectedIndexChanged += lb_TaskTipe_SelectedIndexChanged;
                }
                catch
                {
                    // Exibe mensagem de erro genérica caso a consulta falhe
                    MessageBox.Show("Erro ao consultar Tipo de Tarefa");
                }
            }
        }
        // Evento disparado quando a seleção da ListBox lb_TaskTipe é alterada
        private void lb_TaskTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se nenhum item estiver selecionado, sai do método
            if (lb_TaskTipe.SelectedItem == null)
                return;

            // Converte o item selecionado para o tipo TaskType
            var selectedTaskType = lb_TaskTipe.SelectedItem as TaskType;

            // Se a conversão falhar (item não é TaskType), sai do método
            if (selectedTaskType == null) return;

            // Atualiza a variável SelectedTaskType com o item selecionado
            SelectedTaskType = selectedTaskType;

            // Preenche o campo de texto do Id com o Id da tarefa selecionada
            tb_Id.Text = selectedTaskType.Id.ToString();

            // Preenche o campo de texto do Nome com o nome da tarefa selecionada
            tb_Name.Text = selectedTaskType.Name;
        }
        // Evento disparado ao clicar no botão "Update" (Atualizar)
        private void b_Update_Click(object sender, EventArgs e)
        {
            // Verifica se há um tipo de tarefa selecionado para atualizar
            if (SelectedTaskType != null)
            {
                // Obtém o nome atualizado digitado pelo usuário
                string name = tb_Name.Text;

                // Cria uma nova instância do contexto do banco de dados
                using (var db = new iTasksContext())
                {
                    // Busca no banco de dados o tipo de tarefa pelo Id selecionado
                    var taskTypeToUpdate = db.TaskTypes.Find(SelectedTaskType.Id);

                    // Se encontrou o registro no banco
                    if (taskTypeToUpdate != null)
                    {
                        // Atualiza o nome com o valor informado
                        taskTypeToUpdate.Name = name;

                        // Salva as alterações no banco
                        db.SaveChanges();
                    }
                }

                // Atualiza a lista exibida para refletir as mudanças
                resetList();
            }
            else
            {
                // Caso nenhum tipo de tarefa esteja selecionado, mostra uma mensagem para o usuário
                MessageBox.Show("Selecione um tipo de tarefa para editar.");
            }
        }
        // Evento disparado ao clicar no botão "Delete" (Excluir)
        private void b_Delete_Click(object sender, EventArgs e)
        {
            // Verifica se há uma tarefa selecionada para exclusão
            if (SelectedTaskType != null)
            {
                try
                {
                    // Cria uma nova instância do contexto do banco de dados
                    using (var db = new iTasksContext())
                    {
                        // Busca no banco de dados o tipo de tarefa pelo Id selecionado
                        var taskToDelete = db.TaskTypes.Find(SelectedTaskType.Id);

                        // Se o tipo de tarefa não foi encontrado, exibe mensagem e retorna
                        if (taskToDelete == null)
                        {
                            MessageBox.Show("A Tarefa selecionada não foi encontrada na base de dados.");
                            return;
                        }

                        // Busca todas as tarefas que possuem associação com esse tipo de tarefa
                        var tarefas = db.Tasks
                            .Where(t => t.idTaskType != null && t.idTaskType.Id == taskToDelete.Id)
                            .ToList();

                        // Para cada tarefa associada, remove a referência ao tipo de tarefa (desassociação)
                        foreach (var tarefa in tarefas)
                        {
                            tarefa.idTaskType = null;
                        }

                        // Anexa o objeto taskToDelete ao contexto para habilitar sua remoção
                        db.TaskTypes.Attach(taskToDelete);

                        // Remove o tipo de tarefa do contexto (marca para exclusão)
                        db.TaskTypes.Remove(taskToDelete);

                        // Salva as alterações no banco (exclusão da tarefa e atualização das tarefas relacionadas)
                        db.SaveChanges();

                        // Informa o usuário que a exclusão foi realizada com sucesso
                        MessageBox.Show("Tipo de Tarefa eliminado com sucesso!");

                        // Limpa os campos do formulário após exclusão
                        ClearFormFields();

                        // Atualiza a lista para refletir a exclusão
                        resetList();
                    }
                }
                catch
                {
                    // Em caso de erro, mostra mensagem genérica para o usuário
                    MessageBox.Show("Erro ao remover tarefa");
                }
            }
            else
            {
                // Caso nenhuma tarefa esteja selecionada, informa o usuário
                MessageBox.Show("Selecione uma tarefa da lista para remover.");
            }
        }
    }
}
