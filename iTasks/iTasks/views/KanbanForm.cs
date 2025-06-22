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
        private readonly Action<Form> _trocarForm;  // Campo somente leitura que armazena uma ação para trocar de formulario
        private Task selectedTask;                  // Tarefa atualmente selecionada

        public KanbanForm(Action<Form> trocarForm)
        {
            InitializeComponent();
            Value();
            LoadCurrentUser();
            VerifyUsers();
            _trocarForm = trocarForm;
        }


        /* ---------- Funções de Inicialização  ---------- */
        // Metedo responsavel por carregar os tipos de tarefas e preencher o ComboBox (cb_TypeTasks)
        private void Value()
        {
            try
            {
                // Cria um contexto de base de dados
                using (var db = new iTasksContext())
                {
                    // Obtem a lista de tipos de tarefas da base de dados
                    var TakssType = db.TaskTypes.ToList();  

                    // Adiciona uma opção adicional no início da lista para exibir todos as Tarefas
                    TakssType.Insert(0, new TaskType { Id = -1, Name = "Todos as Tarefas" });

                    cb_TypeTasks.DataSource = TakssType;    // Define as propriadades do ComboBox com os dados carregados
                    cb_TypeTasks.DisplayMember = "Name";    // Propriedade a ser exibida no ComboBox
                    cb_TypeTasks.ValueMember = "Id";        // Valor associado a cada item do ComboBox
                    cb_TypeTasks.SelectedIndex = 0;         // Seleciona o primeiro item por padrão
                }
            }
            catch
            {
                // Caso ocorra um erro ao carregar os dados, exibe uma mensagem no ComboBox
                cb_TypeTasks.Text = "Erro ao carregar as Tarefas!";
            }
        }
        // Metedo responsavel por carregar as informações do utilizador atual da sessão
        private void LoadCurrentUser()
        {
            // Verifica se existe um utilizador com sessão iniciada
            if (sessionManager.IsLoggedIn())
            {   
                // Se sim, obtém o objeto do utilizador atual
                var currentUser = sessionManager.CurrentUser;
            }
        }
        // Metedo responsavel por verificar o tipo de utilizador (Programador ou Gestor)
        private void VerifyUsers()
        {
            // Verifica se o utilizador atual está definido na sessão
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return; // Interrompe a execução do metedo
            }

            var currentUser = sessionManager.CurrentUser;
            List<Tasks> tasksToDisplay = new List<Tasks>(); // Lista onde serão guadadas as tarefas a mostrar

            // Acede a base de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Se o utilizador atual for um Programador
                    if (currentUser is Programmer programmer)
                    {
                        // Vai buscar todas as tarefas, incluindo dados relacionados
                        tasksToDisplay = db.Tasks
                                           .Include(t => t.IdProgrammer)
                                           .Include(t => t.idTaskType)
                                           .ToList();

                        // Esconde botões que só devem estar visíveis para gestores
                        b_NewTask.Visible = false;
                        b_ExportCSV.Visible = false;

                        // Filtra e ordena as tarefas por estado: ToDo, Doing, Done
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

                        // Atualiza as ListBoxes com tarefas, destacando as do programador atual
                        UpdateListBoxWithColor(lb_ToDo, tasksToDo, programmer.Id);
                        UpdateListBoxWithColor(lb_Doing, tasksDoing, programmer.Id);
                        UpdateListBoxWithColor(lb_Done, tasksDone, programmer.Id);
                    }
                    // Se o utilizador for um Gestor
                    else if (currentUser is Maneger manager)
                    {
                        // Vai buscar todos os programdores associados ao gestor atual
                        var assocaciatedProgrammers = db.Users
                            .OfType<Programmer>()
                            .Include(p => p.idManeger)
                            .Where(p => p.idManeger != null && p.idManeger.Id == manager.Id)
                            .ToList();

                        // Obtem os ids desses programdores
                        var programmerIds = assocaciatedProgrammers.Select(p => p.Id).ToList();

                        // Vai buscar todas as tarefas atribuídas a esse programadores
                        tasksToDisplay = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.idTaskType)
                            .Where(t => t.IdProgrammer != null && programmerIds.Contains(t.IdProgrammer.Id))
                            .ToList();

                        // Torna os botões visiveis (apenas para gestores)
                        b_NewTask.Visible = true;
                        b_ExportCSV.Visible = true;

                        // Agrupa as tarefas por estado
                        var tasksToDo = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.ToDo).ToList();
                        var tasksDoing = tasksToDisplay.Where(t => t.CurrentStatus == CurrentStatus.Doing).ToList();
                        var tasksDone = tasksToDisplay
                            .Where(t => t.CurrentStatus == CurrentStatus.Done &&
                                        t.ActualStartDate != null &&
                                        t.ActualEndDate != null)
                            .ToList();

                        // Calcular médias por duração das tarefas concluidas agrupadas por StoryPoints
                        var avgDurationsBySP = tasksDone
                            .GroupBy(t => t.StoryPoints)
                            .ToDictionary(
                                g => g.Key,
                                g => g.Average(t => (t.ActualEndDate.Value - t.ActualStartDate.Value).TotalHours)
                            );

                        // Variavel para acumular o total estimado em horas
                        double totalEstimatedHours = 0;

                        // Atribui estimativa de tempo as tarefas por fazer com base nos StoryPoints
                        foreach (var task in tasksToDo)
                        {
                            double estimated = 0;

                            if (avgDurationsBySP.ContainsKey(task.StoryPoints))
                            {
                                estimated = avgDurationsBySP[task.StoryPoints];
                            }
                            else if (avgDurationsBySP.Any())
                            {
                                // Se não hover correspondencia exata, escolhe os StoryPoints mais proximos 
                                var closestSP = avgDurationsBySP.Keys
                                    .OrderBy(sp => Math.Abs(sp - task.StoryPoints))
                                    .First();

                                estimated = avgDurationsBySP[closestSP];   
                            }

                            // Acrescenta a estimativa a descrição da tarefa
                            task.Description += $" ( {estimated:F1} h estimado)";
                            totalEstimatedHours += estimated;
                        }

                        // Atualiza as listBoxes com as tarefas (já com estimativas)
                        UpdateListBox(lb_ToDo, tasksToDo);
                        UpdateListBox(lb_Doing, tasksDoing);
                        UpdateListBox(lb_Done, tasksDone);

                    }
                    // Caso o utilizador não seja nem Programador nem Gestor
                    else
                    {
                        MessageBox.Show("Tipo de utilizador não reconhecido ou sem permissões para visualizar tarefas.");
                        b_NewTask.Visible = false;

                        // Limpa todas as ListBoxes
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
                    // Mostra erro caso aconteça alguma exceção ao carregar tarefas
                    MessageBox.Show($"Erro ao carregar tarefas: {ex.Message}");
                }
            }
        }


        /* ---------- ListBox  ---------- */
        // Metedo responsavel por desenhar manualmente os itens nema ListBox, atribuindo-lhes cores diferentes
        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Se não houver item valido no indice atual, sai do metedo
            if (e.Index < 0) return;

            
            var listBox = sender as ListBox;                            // Obtem a ListBox que disparou o evento
            var item = listBox.Items[e.Index] as Tasks;                 // Obtem o item da lista, assumindo que é do tipo tasks
            var currentUser = sessionManager.CurrentUser as Programmer; // Obtem o utilizador atual da sessão, assumindo que é um programador
            
            // Verifica se a tarefa pertence ao programador atual
            bool isMine = item?.IdProgrammer != null && 
                          currentUser != null &&
                          item.IdProgrammer.Id == currentUser.Id;

            // Desenha o fundo do item
            e.DrawBackground();

            // Esclhe a cor do texto com base na propriedade "isMine"
            // Verde se for o programadore atual, Vermelho caso contrario
            using (Brush brush = new SolidBrush(isMine ? Color.Green : Color.Red))
            {
                // Desenha o texto da tarefa
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds);
            }

            // Desenha o contorno da seleção à volta do item, se estiver selecionado
            e.DrawFocusRectangle();
        }
        // Metedo que atualiza uma ListBox com uma lista de tarefas, aplicando uma cor presonalizada a cada item
        private void UpdateListBoxWithColor(ListBox listBox, List<Tasks> tasks, int currentUserId)
        {
            listBox.DrawMode = DrawMode.OwnerDrawFixed; // Define o modo de desenho da ListBox como "desenho manual"
            listBox.Items.Clear();                      // Limpa todos os itens atualmente na ListBox

            // Adiciona as taredas ordenadas pelo propriedade "ExecutioOrder"
            foreach (var task in tasks.OrderBy(t => t.ExecutionOrder))
            {
                listBox.Items.Add(task);
            }

            listBox.DrawItem -= ListBox_DrawItem;   // Remove qualquer ligação anterior ao evento DrawItem (evita multiplas subscrições)
            listBox.DrawItem += ListBox_DrawItem;   // Liga o evento DrawItem ao metedo personalizado para desenhar os itens com cor
        }
        // Metedo que atualiza uma ListBox com uma lista de tarefas, sem aplicar formatação personalizada
        private void UpdateListBox(ListBox listBox, List<Tasks> tasks)
        {
            // Limpa todos os itens atualmente na ListBox
            listBox.Items.Clear();

            // Adiciona as tarefas ordenadas pela propriedade "ExecutionOrder"
            foreach (var task in tasks.OrderBy(t => t.ExecutionOrder))
            {
                listBox.Items.Add(task);
            }
        }
        // Metodo responsavel por abrir o formulario de detalhe de uma tarefa selecionada numa ListBox
        private void SelectTaskDetail(object sender)
        {
            // Converte o remetente do evento para ListBox
            ListBox clickedListBox = sender as ListBox;

            // verifica se a ListBox não é nula e se um item está selecionado
            if (clickedListBox != null && clickedListBox.SelectedItem != null)
            {
                // Converte o item selecionado para o tipo Tasks
                Tasks selectedTask = clickedListBox.SelectedItem as Tasks;

                if (selectedTask != null)
                {
                    // Define se o formulario será apenas de leitura, conforme o tipo de utilizador
                    bool isReadOnly = (sessionManager.CurrentUser is Programmer);

                    // Chama a função "_trocarForm" para abrir o formulario de detalhes da tarefa
                    // o formulario será só de leitura se o utilizador for um programador
                    _trocarForm(new TaskDetailForm(selectedTask, isReadOnly));
                }
            }
        }
        // Evento que é acionado quendo o utilizador dá duplo clique num item da ListBox
        private void lb_ToDo_DoubleClick(object sender, EventArgs e)
        {
            // chama a função "SeletectTaskDetaill"
            SelectTaskDetail(sender);
        }
        // Evento que é acionado quendo o utilizador dá duplo clique num item da ListBox
        private void lb_Doing_DoubleClick(object sender, EventArgs e)
        {
            // chama a função "SeletectTaskDetaill"
            SelectTaskDetail(sender);

        }
        // Evento que é acionado quendo o utilizador dá duplo clique num item da ListBox
        private void lb_Done_DoubleClick(object sender, EventArgs e)
        {
            // chama a função "SeletectTaskDetaill"
            SelectTaskDetail(sender);

        }


        /* ---------- Filtro  ---------- */
        // Evento acionado quando o utilizador altera a seleção na ComboBox "cb_TypeTasks"
        private void cb_TypeTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se o item selecionado é do tipo TaskType
            if (cb_TypeTasks.SelectedItem is TaskType selectedTask)
            {
                // Chama o método para filtrar as tarefas
                FiltrarTarefas(selectedTask.Id);
            }
        }
        // Método que filtra as tarefas consoante o tarefas selecionado (TasksId)
        private void FiltrarTarefas(int TasksId)
        {
            // Verifica se o utilizador atual está definido na sessão
            if (sessionManager.CurrentUser == null)
            {
                MessageBox.Show("Erro: Utilizador atual não definido no SessionManager.");
                return;
            }

            try
            {
                using (var db = new iTasksContext())
                {
                    List<Tasks> tasksFiltradas;

                    // Se o utilizador for um Gestor
                    if (sessionManager.CurrentUser is Maneger maneger)
                    {
                        // Obtém os programadores associados ao gestor atual
                        var associatedProgrammers = db.Users
                            .OfType<Programmer>()
                            .Include(p => p.idManeger)
                            .Where(p => p.idManeger.Id == maneger.Id)
                            .Select(p => p.Id)
                            .ToList();

                        // Prepara a query com as tarefas atribuídas aos programadores associados
                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.idTaskType)
                            .Where(t => t.IdProgrammer != null && associatedProgrammers.Contains(t.IdProgrammer.Id));

                        // Aplica o filtro por tarefa, se o ID não for -1 (ou seja, "Todos os Tasks")
                        if (TasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == TasksId);
                        }

                        // Executa a query e guarda o resultado
                        tasksFiltradas = query.ToList();
                    }
                    // Se o utilizador for um Programador
                    else if (sessionManager.CurrentUser is Programmer programmer)
                    {
                        // Prepara a query com as tarefas do programador atual
                        var query = db.Tasks
                            .Include(t => t.IdProgrammer)
                            .Include(t => t.idTaskType)
                            .Where(t => t.IdProgrammer.Id == programmer.Id);

                        // Aplica o filtro por tarefa, se necessário
                        if (TasksId != -1)
                        {
                            query = query.Where(t => t.idTaskType.Id == TasksId);
                        }

                        // Executa a query e guarda o resultado
                        tasksFiltradas = query.ToList();
                    }
                    // Caso o tipo de utilizador não seja reconhecido
                    else
                    {
                        tasksFiltradas = new List<Tasks>();
                    }

                    // Separa as tarefas por estado
                    var tasksToDo = tasksFiltradas.Where(t => t.CurrentStatus == CurrentStatus.ToDo).ToList();
                    var tasksDoing = tasksFiltradas.Where(t => t.CurrentStatus == CurrentStatus.Doing).ToList();
                    var tasksDone = tasksFiltradas.Where(t => t.CurrentStatus == CurrentStatus.Done).ToList();

                    // Atualiza as ListBoxes com as tarefas filtradas
                    UpdateListBox(lb_ToDo, tasksToDo);
                    UpdateListBox(lb_Doing, tasksDoing);
                    UpdateListBox(lb_Done, tasksDone);
                }
            }
            catch
            {
                // Mensagem de erro genérica em caso de falha no processo
                MessageBox.Show("Erro ao filtrar tarefas.");
            }
        }


        /* ---------- Botões  ---------- */
        // Evento acionado quando o botão de exportação (b_ExportCSV) é ativado/desativado (por exemplo, um CheckBox)
        private void b_ExportCSV_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se o utilizador atual é um gestor
            if (!(sessionManager.CurrentUser is Maneger maneger))
            {
                MessageBox.Show("Apenas gestores podem exportar tarefas.");
                return;
            }

            // Cria uma nova ligação à base de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Obtém todos os programadores associados ao gestor atual
                    var associatedProgrammer = db.Users
                        .OfType<Programmer>()
                        .Include(p => p.idManeger)
                        .Where(p => p.idManeger != null && p.idManeger.Id == maneger.Id)
                        .ToList();

                    // Extrai os IDs desses programadores
                    var programmerIds = associatedProgrammer.Select(p => p.Id).ToList();

                    // Filtra as tarefas concluídas (status == Done) desses programadores
                    var doneTasks = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .Include(t => t.idTaskType)
                        .Where(t => t.CurrentStatus == CurrentStatus.Done &&
                                    t.IdProgrammer != null &&
                                    programmerIds.Contains(t.IdProgrammer.Id))
                        .ToList();

                    // Caso não haja tarefas concluídas, mostra mensagem e termina
                    if (!doneTasks.Any())
                    {
                        MessageBox.Show("Não há tarefas concluidas para exportar.");
                        return;
                    }

                    // Abre um diálogo para o utilizador escolher o local para guardar o ficheiro
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "CSV files (*.csv)|*.csv",
                        FileName = "TarefasConcluídas.csv"
                    };

                    // Cria o conteúdo do ficheiro CSV
                    var sb = new StringBuilder();
                    // Cabeçalho do CSV
                    sb.AppendLine("Programador;Descricao;DataPrevistaInicio;DataPrevista;TipoTarefa;DataRealInicio;DataRealFim");

                    // Preenche as linhas com os dados das tarefas concluídas
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

                    // Se o utilizador confirmar o local no diálogo, guarda o ficheiro CSV
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Tarefas exportadas com sucesso.");
                    }
                    
                    
                }
                catch
                {
                    // Em caso de erro durante a exportação, mostra mensagem genérica
                    MessageBox.Show("Erro ao exportar tarefas");
                }
            }
        }
        // Evento acionado quando o utilizador clica no botão "Ver Previsão de Conclusão"
        private void b_SeeCompletionForecast_Click(object sender, EventArgs e)
        {
            // Abre uma ligação à base de dados através do contexto iTasks
            using (var db = new iTasksContext())
            {
                // Obtém todas as tarefas concluídas com datas reais de início e fim
                var tasksDone = db.Tasks
                    .Where(t => t.CurrentStatus == CurrentStatus.Done &&
                                t.ActualStartDate != null &&
                                t.ActualEndDate != null)
                    .ToList();

                // Obtém todas as tarefas que ainda estão por fazer
                var tasksToDo = db.Tasks
                    .Where(t => t.CurrentStatus == CurrentStatus.ToDo)
                    .ToList();

                // Agrupa as tarefas concluídas por "StoryPoints" e calcula a duração média por grupo
                var avgDurationsBySP = tasksDone
                    .GroupBy(t => t.StoryPoints)
                    .ToDictionary(
                        g => g.Key,     // StoryPoints
                        g => g.Average(t => (t.ActualEndDate.Value - t.ActualStartDate.Value).TotalHours)   // média em horas
                    );

                double totalEstimatedHours = 0;     // acumulador do tempo estimado total

                // Percorre todas as tarefas pendentes
                foreach (var task in tasksToDo)
                {
                    double estimated = 0;

                    // Se existirem dados de tarefas anteriores com os mesmos StoryPoints, usa essa média
                    if (avgDurationsBySP.ContainsKey(task.StoryPoints))
                    {
                        estimated = avgDurationsBySP[task.StoryPoints];
                    }
                    // Se não houver correspondência direta, usa o StoryPoint mais próximo
                    else if (avgDurationsBySP.Any())
                    {
                        var closestSP = avgDurationsBySP.Keys
                            .OrderBy(sp => Math.Abs(sp - task.StoryPoints))
                            .First();

                        estimated = avgDurationsBySP[closestSP];
                    }

                    // Soma ao total estimado
                    totalEstimatedHours += estimated;
                }

                // Exibe uma mensagem com o tempo total estimado para conclusão de todas as tarefas pendentes
                MessageBox.Show($"Tempo estimado para conclusão de todas as tarefas pendentes: {totalEstimatedHours:F1} horas.");
            }
        }
        // Evento acionado quando o utilizador clica no botão "Nova Tarefa"
        private void b_NewTask_Click(object sender, EventArgs e)
        {
            // Chama a função "_trocarForm" para abrir o formulário de detalhes da tarefa
            _trocarForm(new TaskDetailForm(null));
        }
        // Evento acionado quando o utilizador clica no botão "Executar Tarefa"
        private void b_ExecuteTask_Click(object sender, EventArgs e)
        {
            // Verifica se alguma tarefa está selecionada na lista 'To Do'
            if (lb_ToDo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa na coluna 'To Do' para iniciar.");
                return;
            }

            // Converte o item selecionado para o tipo Tasks
            Tasks taskToUpdateStatus = lb_ToDo.SelectedItem as Tasks;

            // Valida se a tarefa é válida e está no estado 'To Do'
            if (taskToUpdateStatus == null || taskToUpdateStatus.CurrentStatus != CurrentStatus.ToDo)
            {
                MessageBox.Show("A tarefa selecionada não é válida ou não está no estado 'To Do'.");
                return;
            }

            // Abre contexto para acesso à base de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Obtém a tarefa da base de dados correspondente à selecionada
                    var taskInDb = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Id == taskToUpdateStatus.Id);

                    // Verifica se a tarefa existe na base de dados
                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
                    }

                    // Se o utilizador atual for um programador, valida permissões e regras
                    if (sessionManager.CurrentUser is Programmer prog)
                    {
                        // Só pode mover tarefas que estejam atribuídas a si
                        if (taskInDb.IdProgrammer == null || taskInDb.IdProgrammer.Id != prog.Id)
                        {
                            MessageBox.Show("Não pode mover tarefas que não lhe estão atribuídas.");
                            lb_ToDo.SelectedItem = null;
                            return;
                        }

                        // Conta quantas tarefas estão a decorrer (Doing) para este programador
                        int doingCount = db.Tasks.Count(t => t.IdProgrammer.Id == prog.Id && t.CurrentStatus == CurrentStatus.Doing);

                        // Limita a 2 tarefas em execução em simultâneo
                        if (doingCount >= 2)
                        {
                            MessageBox.Show("Já possui duas tarefas em execução (Doing). Termine uma antes de iniciar outra.");
                            return;
                        }

                        // Garante que as tarefas são executadas pela ordem definida (ex: 1, 2, 3...)
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

                    taskInDb.CurrentStatus = CurrentStatus.Doing;   // Atualiza o estado da tarefa para 'Doing' (em execução)
                    taskInDb.ActualStartDate = DateTime.Now;        // Regista a data e hora de início real da tarefa

                    db.SaveChanges();                               // Salva as alterações na base de dados

                    VerifyUsers();                                  // Atualiza a interface para refletir as alterações
                }
                catch
                {
                    // Exibe mensagem de erro em caso de exceção
                    MessageBox.Show("Erro ao mover tarefa");
                }
            }
        }
        // Evento acionado ao clicar no botão para retroceder uma tarefa ao estado anterior
        private void b_RestartTask_Click(object sender, EventArgs e)
        {
            Tasks taskToRetrocede = null;
            ListBox sourceListBox = null;

            // Verifica se há uma tarefa selecionada em alguma das listas (Done, Doing, ToDo)
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

            // Se não houver nenhuma tarefa selecionada, exibe mensagem e sai
            if (taskToRetrocede == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa para retroceder.");
                return;
            }

            // Abre o contexto da base de dados para buscar a tarefa selecionada
            using (var db = new iTasksContext())
            {
                try
                {
                    // Obtém a tarefa da base de dados com todas as suas associações necessárias
                    var taskInDb = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Id == taskToRetrocede.Id);

                    // Se não encontrar a tarefa na BD, avisa e sai
                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
                    }

                    // Se o utilizador atual for programador, só pode mexer nas suas próprias tarefas
                    if (sessionManager.CurrentUser is Programmer prog)
                    {
                        if (taskInDb.IdProgrammer == null || taskInDb.IdProgrammer.Id != prog.Id)
                        {
                            MessageBox.Show("Não pode mover tarefas que não lhe estão atribuídas.");
                            lb_Done.SelectedItem = null;
                            return;
                        }
                    }

                    // Lógica para retroceder a tarefa ao estado anterior
                    switch (taskInDb.CurrentStatus)
                    {
                        case CurrentStatus.Doing:
                            // Se está "Doing", volta para "To Do" e remove a data de início real
                            taskInDb.CurrentStatus = CurrentStatus.ToDo;
                            taskInDb.ActualStartDate = null;
                            break;

                        case CurrentStatus.ToDo:
                            // Se já está em "To Do", não pode retroceder mais
                            MessageBox.Show("A tarefa já está no estado 'To Do' e não pode ser retrocedida mais.");
                            return;

                        default:
                            // Qualquer outro estado é considerado inválido para retrocesso
                            MessageBox.Show("Estado da tarefa não reconhecido para retrocesso.");
                            return;
                    }

                    // Guarda as alterações na base de dados
                    db.SaveChanges();

                    // Atualiza a interface para refletir as mudanças
                    VerifyUsers();
                }
                catch
                {
                    // Mostra mensagem de erro em caso de falha na operação
                    MessageBox.Show("Erro ao retroceder tarefa");
                }
            }
        }
        // Evento disparado ao clicar no botão "Finalizar Tarefa".
        private void b_FinishTask_Click(object sender, EventArgs e)
        {
            // Verifica se há uma tarefa selecionada na lista 'Doing'
            if (lb_Doing.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa na coluna 'Doing' para finalizar.");
                return;
            }

            Tasks taskToUpdateStatus = lb_Doing.SelectedItem as Tasks;

            // Verifica se a tarefa é válida e está no estado 'Doing'
            if (taskToUpdateStatus == null || taskToUpdateStatus.CurrentStatus != CurrentStatus.Doing)
            {
                MessageBox.Show("A tarefa selecionada não é válida ou não está no estado 'Doing'.");
                return;
            }

            using (var db = new iTasksContext())
            {
                try
                {
                    // Busca a tarefa na BD com o programador associado
                    var taskInDb = db.Tasks
                        .Include(t => t.IdProgrammer)
                        .FirstOrDefault(t => t.Id == taskToUpdateStatus.Id);

                    if (taskInDb == null)
                    {
                        MessageBox.Show("Tarefa não encontrada na base de dados.");
                        return;
                    }

                    // Garante que apenas o programador associado pode finalizar a tarefa
                    if (sessionManager.CurrentUser is Programmer prog)
                    {
                        if (taskInDb.IdProgrammer == null || taskInDb.IdProgrammer.Id != prog.Id)
                        {
                            MessageBox.Show("Não pode mover tarefas que não lhe estão atribuídas.");
                            lb_Doing.SelectedItem = null;
                            return;
                        }
                    }

                    // Atualiza o status e a data de fim real
                    taskInDb.CurrentStatus = CurrentStatus.Done;    
                    taskInDb.ActualEndDate = DateTime.Now;

                    // Salva as alterações na base de dados
                    db.SaveChanges();

                    // Atualiza a interface do utilizador
                    VerifyUsers();
                }
                catch
                {
                    MessageBox.Show("Erro ao mover tarefa");
                }
            }
        }

    }
}
