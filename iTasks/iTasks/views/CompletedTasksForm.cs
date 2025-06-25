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
        private List<TaskViewModel> allTasks = new List<TaskViewModel>();   // Lista que armazena todas as tarefas no formato TaskViewModel

        public CompletedTasksForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            VerifyUsers();
            Value();
        }


        /* ---------- Funções de Inicialização  ---------- */
        // Método que carrega o utilizador atual
        private void LoadCurrentUser()
        {
            // Verifica se o utilizador está autenticado na sessão
            if (!sessionManager.IsLoggedIn())
            {
                // Se não estiver autenticado, mostra uma mensagem de aviso
                MessageBox.Show("Utilizador não autenticado.");

                // Fecha a janela ou formulário atual
                this.Close();
            }
        }
        // Método que verifica o usuário atual e carrega as tarefas correspondentes
        private void VerifyUsers()
        {
            // Verifica se existe um utilizador atual definido no sessionManager
            if (sessionManager.CurrentUser == null)
            {
                // Mostra uma mensagem de erro se o utilizador não estiver definido e sai do método
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return;
            }

            // Guarda o utilizador atual numa variável local para uso posterior
            var currentUser = sessionManager.CurrentUser;

            // Cria um contexto para aceder à base de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Lista para armazenar as tarefas concluídas
                    List<Tasks> tasksDone;

                    // Se o utilizador for um programador
                    if (currentUser is Programmer programmer)
                    {
                        // Busca da base de dados as tarefas concluídas associadas ao programador atual
                        tasksDone = db.Tasks
                            .Include(t => t.IdProgrammer) // Inclui os dados do programador relacionados à tarefa
                            .Where(t => t.IdProgrammer.Id == programmer.Id && t.CurrentStatus == CurrentStatus.Done)
                            .ToList();

                        // Cria uma lista de ViewModels para apresentar as tarefas com as informações relevantes
                        var taskViewModels = tasksDone.Select(t => new TaskViewModel
                        {
                            ProgrammerName = programmer.Name,               // Nome do programador
                            Description = t.Description,                      // Descrição da tarefa
                            ActualStartDate = t.ActualStartDate,             // Data real de início
                            ActualEndDate = t.ActualEndDate,                 // Data real de fim
                                                                             // Calcula a duração real da tarefa em dias, se as datas estiverem definidas
                            DurationInDays = t.ActualStartDate.HasValue && t.ActualEndDate.HasValue
                                ? (int?)(t.ActualEndDate.Value - t.ActualStartDate.Value).TotalDays
                                : null,
                            // Calcula a duração esperada da tarefa (parece haver um erro na ordem das datas aqui)
                            ExpectedDurationInDays = (int?)(t.EstimatedStartDate - t.ExpectedEndDate).TotalDays
                        }).ToList();

                        // Define a fonte de dados do DataGridView para mostrar as tarefas concluídas
                        dgv_Done.DataSource = taskViewModels;
                        dgv_Done.ClearSelection();   // Limpa a seleção atual
                        dgv_Done.CurrentCell = null; // Nenhuma célula fica selecionada
                    }
                    // Se o utilizador for um gestor
                    else if (currentUser is Maneger manager)
                    {
                        // Busca as tarefas concluídas associadas ao gestor atual
                        tasksDone = db.Tasks
                            .Include(t => t.IdProgrammer) // Inclui dados do programador relacionado
                            .Include(t => t.IdManeger)    // Inclui dados do gestor relacionado
                            .Where(t => t.IdManeger.Id == manager.Id && t.CurrentStatus == CurrentStatus.Done)
                            .ToList();

                        // Cria a lista de ViewModels para as tarefas
                        var taskViewModels = tasksDone.Select(t => new TaskViewModel
                        {
                            ProgrammerName = t.IdProgrammer?.Name,           // Nome do programador (pode ser null)
                            Description = t.Description,                      // Descrição da tarefa
                            ActualStartDate = t.ActualStartDate,             // Data real de início
                            ActualEndDate = t.ActualEndDate,                 // Data real de fim
                                                                             // Calcula a duração real em dias
                            DurationInDays = t.ActualStartDate.HasValue && t.ActualEndDate.HasValue
                                ? (int?)(t.ActualEndDate.Value - t.ActualStartDate.Value).TotalDays
                                : null,
                            // Calcula a duração esperada da tarefa (atenção que a ordem das datas aqui é diferente da do programador)
                            ExpectedDurationInDays = (int?)(t.ExpectedEndDate - t.EstimatedStartDate).TotalDays
                        }).ToList();

                        // Atualiza o DataGridView com as tarefas do gestor
                        dgv_Done.DataSource = taskViewModels;
                        dgv_Done.ClearSelection();
                        dgv_Done.CurrentCell = null;
                    }
                    else
                    {
                        // Caso o tipo de utilizador não seja reconhecido, mostra uma mensagem
                        MessageBox.Show("Tipo de utilizador não reconhecido.");
                        dgv_Done.DataSource = null; // Limpa o DataGridView
                    }
                }
                catch (Exception ex)
                {
                    // Mostra uma mensagem de erro se ocorrer uma exceção ao carregar as tarefas
                    MessageBox.Show("Erro ao carregar tarefas: " + ex.Message);
                }
            }
        }
        // Método que carrega os tipos de tarefas do banco e popula o ComboBox de filtro
        private void Value()
        {
            try
            {
                // Cria um contexto para acessar o banco de dados usando Entity Framework
                using (var db = new iTasksContext())
                {
                    // Obtém a lista de todos os tipos de tarefas da tabela TaskTypes
                    var TakssType = db.TaskTypes.ToList();

                    // Insere no início da lista uma opção especial para "Todas as Tarefas"
                    // Com Id = -1 para identificar que é um filtro geral
                    TakssType.Insert(0, new TaskType { Id = -1, Name = "Todos as Tarefas" });

                    // Configura o ComboBox para exibir os tipos de tarefas
                    cb_FilterTypeTasks.DataSource = TakssType;      // Define a lista como fonte de dados do ComboBox
                    cb_FilterTypeTasks.DisplayMember = "Name";      // O que será mostrado na lista (nome do tipo)
                    cb_FilterTypeTasks.ValueMember = "Id";          // O valor interno de cada item (Id do tipo)

                    // Define a seleção padrão do ComboBox para o primeiro item (Todos as Tarefas)
                    cb_FilterTypeTasks.SelectedIndex = 0;
                }
            }
            catch
            {
                // Em caso de erro ao carregar os dados, exibe mensagem informativa no ComboBox
                cb_FilterTypeTasks.Text = "Erro ao carregar as Tarefas!";
            }
        }


        /* ---------- Funções da Grelha  ---------- */
        // ViewModel comum a ambos os tipos de utilizador
        public class TaskViewModel
        {
            public string ProgrammerName { get; set; }          // Nome do programador associado à tarefa (pode ser null)
            public string Description { get; set; }             // Descrição detalhada da tarefa
            public DateTime? ActualStartDate { get; set; }      // Data real de início da tarefa (nullable)
            public DateTime? ActualEndDate { get; set; }        // Data real de conclusão da tarefa (nullable)
            public int? DurationInDays { get; set; }            // Duração efetiva da tarefa em dias (nullable)
            public int? ExpectedDurationInDays { get; set; }    // Duração esperada da tarefa em dias (nullable)
        }
        // Filtra e exibe as tarefas concluídas associadas ao utilizador atual
        private void FiltrarTarefas(int tasksId)
        {
            // Verifica se há um utilizador autenticado na sessão
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return; // Sai do método se não houver utilizador autenticado
            }

            try
            {
                // Cria um contexto para acessar a base de dados
                using (var db = new iTasksContext())
                {
                    List<Tasks> filteredTasks; // Lista para armazenar as tarefas filtradas

                    // Se o utilizador atual for um gestor
                    if (sessionManager.CurrentUser is Maneger maneger)
                    {
                        // Obtém os IDs dos programadores associados a esse gestor
                        var programmerIds = db.Users
                            .OfType<Programmer>()                       // Seleciona só programadores
                            .Where(p => p.idManeger.Id == maneger.Id) // Filtra pelos programadores desse gestor
                            .Select(p => p.Id)                         // Obtém só os IDs
                            .ToList();

                        // Prepara a consulta para buscar tarefas feitas por esses programadores
                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)   // Inclui dados do programador
                            .Include(t => t.idTaskType)     // Inclui dados do tipo de tarefa
                            .Where(t => programmerIds.Contains(t.IdProgrammer.Id) && t.CurrentStatus == CurrentStatus.Done);

                        // Se o filtro não for "Todos" (-1), aplica filtro pelo tipo de tarefa
                        if (tasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == tasksId);
                        }

                        // Executa a consulta e obtém a lista filtrada
                        filteredTasks = query.ToList();
                    }
                    // Se o utilizador atual for um programador
                    else if (sessionManager.CurrentUser is Programmer programmer)
                    {
                        // Prepara a consulta para buscar tarefas feitas por esse programador
                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)   // Inclui dados do programador
                            .Include(t => t.idTaskType)     // Inclui dados do tipo de tarefa
                            .Where(t => t.IdProgrammer.Id == programmer.Id && t.CurrentStatus == CurrentStatus.Done);

                        // Se o filtro não for "Todos" (-1), aplica filtro pelo tipo de tarefa
                        if (tasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == tasksId);
                        }

                        // Executa a consulta e obtém a lista filtrada
                        filteredTasks = query.ToList();
                    }
                    else
                    {
                        // Caso o tipo de utilizador não seja reconhecido, retorna lista vazia
                        filteredTasks = new List<Tasks>();
                    }

                    // Converte as tarefas filtradas para a ViewModel para exibição no DataGridView
                    var viewModels = filteredTasks.Select(t =>
                    {
                        // Calcula a duração esperada em dias, caso as datas estejam definidas
                        int? expectedDuration = (int?)(t.ExpectedEndDate - t.EstimatedStartDate).TotalDays;

                        // Cria e retorna um novo objeto TaskViewModel com os dados necessários
                        return new TaskViewModel
                        {
                            ProgrammerName = t.IdProgrammer?.Name,
                            Description = t.Description,
                            ActualStartDate = t.ActualStartDate,
                            ActualEndDate = t.ActualEndDate,
                            DurationInDays = t.ActualStartDate.HasValue && t.ActualEndDate.HasValue
                                ? (int?)(t.ActualEndDate.Value - t.ActualStartDate.Value).TotalDays
                                : null,
                            ExpectedDurationInDays = expectedDuration
                        };
                    }).ToList();

                    // Atualiza a lista global com as tarefas filtradas (se estiver definida)
                    allTasks = viewModels;

                    // Atualiza o DataGridView para mostrar as tarefas filtradas
                    dgv_Done.DataSource = viewModels;

                    // Limpa qualquer seleção anterior no DataGridView
                    dgv_Done.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe mensagem com a descrição do problema
                MessageBox.Show("Erro ao filtrar tarefas.\n" + ex.Message);
            }
        }
        // Evento que formata visualmente as linhas do DataGridView dgv_Done
        private void dgv_Done_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna sendo formatada é a coluna "DurationInDays"
            if (dgv_Done.Columns[e.ColumnIndex].Name == "DurationInDays")
            {
                // Obtém a linha atual
                var row = dgv_Done.Rows[e.RowIndex];

                // Obtém os valores das células "DurationInDays" e "ExpectedDurationInDays"
                var durationObj = row.Cells["DurationInDays"].Value;
                var expectedObj = row.Cells["ExpectedDurationInDays"].Value;

                // Verifica se ambos os valores existem e podem ser convertidos para inteiro
                if (durationObj != null && expectedObj != null &&
                    int.TryParse(durationObj.ToString(), out int duration) &&
                    int.TryParse(expectedObj.ToString(), out int expected))
                {
                    Color backColor;
                    Color foreColor;

                    // Se a duração real for maior que a esperada, pinta a linha de vermelho com texto branco
                    if (duration > expected)
                    {
                        backColor = Color.Red;
                        foreColor = Color.White;
                    }
                    else
                    {
                        // Caso contrário, pinta a linha de verde claro com texto preto
                        backColor = Color.LightGreen;
                        foreColor = Color.Black;
                    }

                    // Aplica as cores de fundo e texto a todas as células da linha
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = backColor;
                        cell.Style.ForeColor = foreColor;
                    }
                }
            }
        }
        // Evento acionado quando o texto do TextBox de filtro é alterado
        private void tb_filterProgrammer_TextChanged(object sender, EventArgs e)
        {
            // Obtém o usuário atualmente logado na sessão
            var currentUser = sessionManager.CurrentUser;

            // Obtém o texto do filtro, já trim (sem espaços extras) e convertido para minúsculas para facilitar a busca
            string filterText = tb_filterProgrammer.Text.Trim().ToLower();

            // Se o filtro estiver vazio ou só com espaços, exibe todas as tarefas e limpa a seleção
            if (string.IsNullOrWhiteSpace(filterText))
            {
                dgv_Done.DataSource = allTasks;
                dgv_Done.ClearSelection();
                return;
            }

            // Se o usuário for gerente, filtra as tarefas pelo nome do programador
            if (currentUser is Maneger maneger)
            {
                var filtered = allTasks
                    .Where(t => t.ProgrammerName != null && t.ProgrammerName.ToLower().Contains(filterText))
                    .ToList();

                dgv_Done.DataSource = filtered;
                dgv_Done.ClearSelection();
            }
            // Se o usuário for programador, filtra as tarefas pela descrição da tarefa
            else if (currentUser is Programmer programmer)
            {
                var filtered = allTasks
                    .Where(t => t.Description != null && t.Description.ToLower().Contains(filterText))
                    .ToList();

                dgv_Done.DataSource = filtered;
                dgv_Done.ClearSelection();
            }
        }
        // Evento disparado quando o usuário altera a seleção do ComboBox de tipos de tarefas
        private void cb_FilterTypeTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se o item selecionado é um objeto do tipo TaskType
            if (cb_FilterTypeTasks.SelectedItem is TaskType selectedTask)
            {
                // Chama o método para filtrar as tarefas baseado no Id do tipo de tarefa selecionado
                FiltrarTarefas(selectedTask.Id);
            }
        }
    }
}
