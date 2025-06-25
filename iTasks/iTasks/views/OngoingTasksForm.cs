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
        private List<TaskViewModel> allTasks = new List<TaskViewModel>();   // Lista que armazena todas as tarefas no formato TaskViewModel
        public OngoingTasksForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            VerifyUsers();
            Value();
        }


        /* ---------- Funções de Inicialização  ---------- */
        // Método para carregar os dados do usuário atualmente logado
        private void LoadCurrentUser()
        {
            // Verifica se o usuário está logado na sessão
            if (sessionManager.IsLoggedIn())
            {
                // Obtém o usuário atualmente logado da sessão
                var currentUser = sessionManager.CurrentUser;

                // Aqui você pode usar currentUser para preencher campos, permissões, etc.
            }
        }
        // Método que verifica o usuário atual e carrega as tarefas correspondentes
        private void VerifyUsers()
        {
            // Verifica se o usuário atual está definido no sessionManager
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return;
            }

            // Obtém o usuário atualmente logado
            var currentUser = sessionManager.CurrentUser;

            // Cria uma instância do contexto do banco de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Caso o usuário seja um Programador
                    if (currentUser is Programmer programmer)
                    {
                        // Consulta as tarefas associadas a este programador que estão com status ToDo ou Doing
                        var tasks = db.Tasks
                            .Include(t => t.IdProgrammer) // Inclui dados do programador na consulta
                            .Where(t => t.IdProgrammer.Id == programmer.Id &&
                                        (t.CurrentStatus == CurrentStatus.ToDo || t.CurrentStatus == CurrentStatus.Doing))
                            .OrderBy(t => t.CurrentStatus) // Ordena pelo status atual
                            .ToList();

                        // Projeta as tarefas em TaskViewModel para facilitar a exibição
                        var taskViewModels = tasks.Select(t =>
                        {
                            // Calcula a duração estimada em dias entre início e fim esperado
                            int estimatedDurationDays = (t.ExpectedEndDate - t.EstimatedStartDate).Days;

                            // Calcula os dias decorridos desde o início real ou estimado
                            int daysElapsed = (DateTime.Today - (t.ActualStartDate ?? t.EstimatedStartDate)).Days;

                            // Calcula os dias restantes para o fim esperado
                            int daysRemaining = estimatedDurationDays - daysElapsed;

                            // Garante que dias restantes não sejam negativos
                            if (daysRemaining < 0) daysRemaining = 0;

                            // Retorna a ViewModel com os dados necessários para a interface
                            return new TaskViewModel
                            {
                                Description = t.Description,
                                ProgrammerName = t.IdProgrammer.Name,
                                ExpectedEndDate = t.ExpectedEndDate,
                                DaysRemaining = daysRemaining,
                                DaysLate = daysRemaining < 0 ? -daysRemaining : 0, // Dias de atraso (sempre >= 0)
                            };
                        }).ToList();

                        // Atualiza a lista interna e o DataGridView para exibir as tarefas
                        allTasks = taskViewModels;
                        dgv_Tasks.DataSource = taskViewModels;
                        dgv_Tasks.ClearSelection();
                    }
                    // Caso o usuário seja um Gestor (Manager)
                    else if (currentUser is Maneger manager)
                    {
                        // Obtém os Ids dos programadores que são gerenciados por esse gestor
                        var programmerIds = db.Users
                            .OfType<Programmer>()
                            .Where(p => p.idManeger != null && p.idManeger.Id == manager.Id)
                            .Select(p => p.Id)
                            .ToList();

                        // Consulta as tarefas desses programadores que não estejam concluídas (status diferente de Done)
                        var tasks = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Where(t => programmerIds.Contains(t.IdProgrammer.Id) &&
                                        t.CurrentStatus != CurrentStatus.Done)
                            .ToList();

                        // Projeta as tarefas para TaskViewModel
                        var taskViewModels = tasks.Select(t =>
                        {
                            // Calcula dias restantes até a data esperada
                            int daysRemaining = (t.ExpectedEndDate - DateTime.Today).Days;

                            return new TaskViewModel
                            {
                                Description = t.Description,
                                ProgrammerName = t.IdProgrammer.Name,
                                ExpectedEndDate = t.ExpectedEndDate,
                                DaysRemaining = daysRemaining >= 0 ? daysRemaining : 0, // Nunca negativo
                                DaysLate = daysRemaining < 0 ? -daysRemaining : 0,       // Dias atrasados
                            };
                        }).ToList();

                        // Atualiza a lista interna e o DataGridView
                        allTasks = taskViewModels;
                        dgv_Tasks.DataSource = taskViewModels;
                        dgv_Tasks.ClearSelection();
                    }
                    // Caso o usuário não seja reconhecido ou não tenha permissões
                    else
                    {
                        MessageBox.Show("Tipo de utilizador não reconhecido ou sem permissões para visualizar tarefas.");
                        dgv_Tasks.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    // Em caso de erro, exibe mensagem com o detalhe do erro
                    MessageBox.Show("Erro ao carregar tarefas." + ex.Message);
                }
            }
        }
        // Método que carrega os tipos de tarefas do banco e popula o ComboBox de filtro
        private void Value()
        {
            try
            {
                // Cria um contexto para acessar o banco de dados
                using (var db = new iTasksContext())
                {
                    // Obtém todos os tipos de tarefas da base de dados
                    var TakssType = db.TaskTypes.ToList();

                    // Insere no início da lista uma opção para "Todas as Tarefas" com Id = -1
                    TakssType.Insert(0, new TaskType { Id = -1, Name = "Todos as Tarefas" });

                    // Configura o ComboBox para exibir a lista de tipos de tarefas
                    cb_FilterTypeTasks.DataSource = TakssType;      // Define a lista como fonte de dados
                    cb_FilterTypeTasks.DisplayMember = "Name";      // Exibe o nome de cada tipo no ComboBox
                    cb_FilterTypeTasks.ValueMember = "Id";          // Usa o Id como valor interno para cada item

                    // Seleciona a primeira opção por padrão, que é "Todos as Tarefas"
                    cb_FilterTypeTasks.SelectedIndex = 0;
                }
            }
            catch
            {
                // Caso ocorra erro, exibe uma mensagem no ComboBox para informar ao usuário
                cb_FilterTypeTasks.Text = "Erro ao carregar as Tarefas!";
            }
        }


        /* ---------- Funções da Grelha  ---------- */
        // Classe que representa a visualização de uma tarefa, com dados para exibição na interface
        public class TaskViewModel
        {
            // Descrição da tarefa
            public string Description { get; set; }

            // Nome do programador responsável pela tarefa
            public string ProgrammerName { get; set; }

            // Data esperada para a conclusão da tarefa (pode ser nula)
            public DateTime? ExpectedEndDate { get; set; }

            // Número de dias restantes até a data esperada de término da tarefa
            public int DaysRemaining { get; set; }

            // Número de dias que a tarefa está atrasada (0 se não estiver atrasada)
            public int DaysLate { get; set; }
        }
        // Evento disparado quando o índice selecionado no ComboBox de filtro de tipos de tarefas é alterado
        private void cb_FilterTypeTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se o item selecionado no ComboBox é um objeto do tipo TaskType
            if (cb_FilterTypeTasks.SelectedItem is TaskType selectedTask)
            {
                // Chama o método responsável por filtrar as tarefas, passando o Id do tipo selecionado
                FiltrarTarefas(selectedTask.Id);
            }
        }
        // Método para filtrar as tarefas exibidas, baseado no tipo de tarefa selecionado e no usuário atual
        private void FiltrarTarefas(int tasksId)
        {
            // Verifica se há um usuário logado no sistema
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return;
            }

            try
            {
                // Cria um contexto para acessar o banco de dados
                using (var db = new iTasksContext())
                {
                    List<Tasks> filteredTasks;

                    // Se o usuário atual for um gerente, busca as tarefas dos programadores gerenciados
                    if (sessionManager.CurrentUser is Maneger maneger)
                    {
                        // Obtém os IDs dos programadores vinculados ao gerente
                        var programmerIds = db.Users
                            .OfType<Programmer>()
                            .Where(p => p.idManeger.Id == maneger.Id)
                            .Select(p => p.Id)
                            .ToList();

                        // Query base para pegar as tarefas desses programadores
                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)   // Inclui dados do programador na query
                            .Include(t => t.idTaskType)     // Inclui dados do tipo da tarefa na query
                            .Where(t => programmerIds.Contains(t.IdProgrammer.Id) && t.CurrentStatus == CurrentStatus.ToDo || t.CurrentStatus == CurrentStatus.Doing);

                        // Se o filtro não for "Todos as Tarefas" (id -1), filtra pelo tipo selecionado
                        if (tasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == tasksId);
                        }

                        // Executa a query e obtém a lista de tarefas filtradas
                        filteredTasks = query.ToList();
                    }
                    // Se o usuário atual for um programador, busca somente suas tarefas
                    else if (sessionManager.CurrentUser is Programmer programmer)
                    {
                        // Query base para pegar as tarefas do programador atual
                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.idTaskType)
                            .Where(t => t.IdProgrammer.Id == programmer.Id);

                        // Aplica filtro pelo tipo de tarefa se necessário
                        if (tasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == tasksId);
                        }

                        // Executa a query e obtém as tarefas filtradas
                        filteredTasks = query.ToList();
                    }
                    // Se o usuário não for gerente nem programador, não retorna tarefas
                    else
                    {
                        filteredTasks = new List<Tasks>();
                    }

                    // Converte a lista de tarefas para a lista de ViewModels, para exibição na interface
                    var viewModels = filteredTasks.Select(t =>
                    {
                        // Calcula os dias restantes para a tarefa (pode ser negativo)
                        int daysRemaining = (t.ExpectedEndDate - DateTime.Today).Days;

                        return new TaskViewModel
                        {
                            Description = t.Description,
                            ProgrammerName = t.IdProgrammer?.Name ?? "", // Proteção contra null
                            ExpectedEndDate = t.ExpectedEndDate,
                            DaysRemaining = daysRemaining >= 0 ? daysRemaining : 0, // 0 se negativo
                            DaysLate = daysRemaining < 0 ? -daysRemaining : 0,       // valor absoluto do atraso
                        };
                    }).ToList();

                    // Atualiza a lista geral e o DataGridView para mostrar as tarefas filtradas
                    allTasks = viewModels;
                    dgv_Tasks.DataSource = viewModels;
                    dgv_Tasks.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe uma mensagem informando o problema
                MessageBox.Show("Erro ao filtrar tarefas.\n" + ex.Message);
            }
        }
        // Evento disparado quando o texto do campo de filtro de programador/tarefa é alterado
        private void tb_filterProgrammer_TextChanged(object sender, EventArgs e)
        {
            // Obtém o usuário atualmente logado na sessão
            var currentUser = sessionManager.CurrentUser;

            // Obtém o texto do filtro, já trim e convertido para minúsculas para facilitar a busca
            string filterText = tb_filterProgrammer.Text.Trim().ToLower();

            // Se o filtro estiver vazio ou só com espaços, exibe todas as tarefas e limpa a seleção
            if (string.IsNullOrWhiteSpace(filterText))
            {
                dgv_Tasks.DataSource = allTasks;
                dgv_Tasks.ClearSelection();
                return;
            }

            // Se o usuário for gerente, filtra as tarefas pelo nome do programador
            if (currentUser is Maneger maneger)
            {
                var filtered = allTasks
                    .Where(t => t.ProgrammerName.ToLower().Contains(filterText))
                    .ToList();

                dgv_Tasks.DataSource = filtered;
                dgv_Tasks.ClearSelection();
            }
            // Se o usuário for programador, filtra as tarefas pela descrição da tarefa
            else if (currentUser is Programmer programmer)
            {
                var filtered = allTasks
                    .Where(t => t.Description != null && t.Description.ToLower().Contains(filterText))
                    .ToList();

                dgv_Tasks.DataSource = filtered;
                dgv_Tasks.ClearSelection();
            }
        }
        // Evento que formata as células do DataGridView dgv_Tasks enquanto elas são exibidas
        private void dgv_Tasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Obtém o objeto da linha atual como TaskViewModel
            if (dgv_Tasks.Rows[e.RowIndex].DataBoundItem is TaskViewModel task)
            {
                Color backColor;
                Color foreColor;

                // Define a cor de fundo e a cor da fonte com base nos dias restantes da tarefa
                if (task.DaysRemaining <= 7)  // Se a tarefa está com prazo curto (7 dias ou menos)
                {
                    backColor = Color.Red;    // Fundo vermelho para indicar urgência
                    foreColor = Color.White;  // Texto branco para melhor contraste
                }
                else
                {
                    backColor = Color.LightGreen; // Fundo verde claro para tarefas com prazo confortável
                    foreColor = Color.Black;       // Texto preto padrão
                }

                // Aplica as cores definidas para todas as células da linha atual
                foreach (DataGridViewCell cell in dgv_Tasks.Rows[e.RowIndex].Cells)
                {
                    cell.Style.BackColor = backColor;
                    cell.Style.ForeColor = foreColor;
                }
            }
        }
    }
}