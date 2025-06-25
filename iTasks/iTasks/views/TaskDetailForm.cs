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
        private Tasks selectedTasks;        // Armazena a tarefa atualmente selecionada
        private Maneger currentManeger;     // Representa o gestor atual logado que está manipulando as tarefas
        private bool isReadOnlyMode;        // Indica se o sistema está em modo somente leitura (visualização), bloqueando operações que alteram dados

        public TaskDetailForm(string Tasks)
        {
            InitializeComponent();
            ConfirmUser();
            Value();
            DateToUpdate();

        }


        /* ---------- Funções de Inicialização  ---------- */
        // Método responsável por confirmar o tipo de utilizador que está atualmente na sessão
        private void ConfirmUser()
        {
            // Verifica se o utilizador atual da sessão é um gestor (Maneger)
            if (sessionManager.CurrentUser is Maneger maneger)
            {
                // Armazena a instância do gestor na variável 'currentManeger' para uso posterior
                currentManeger = maneger;
            }
            // Verifica se o utilizador atual é um programador
            else if (sessionManager.CurrentUser is Programmer)
            {
                // Programadores são permitidos a aceder ao formulário,
                // mas não é necessário guardar referência nem tomar ação adicional aqui
            }
            // Se o utilizador não for nem gestor nem programador
            else
            {
                // Exibe uma mensagem de erro informando que o acesso é restrito
                MessageBox.Show("Apenas gestores e programadores podem aceder a este formulário.");

                // Fecha o formulário pois o utilizador não tem permissão
                this.Close();
            }
        }
        // Carrega os valores iniciais dos combos (listas suspensas) no formulário
        private void Value()
        {
            // Define a lista de opções do comboBox 'cb_CurrentStatus' com todos os valores possíveis do enum 'CurrentStatus'
            cb_CurrentStatus.DataSource = Enum.GetValues(typeof(CurrentStatus)).Cast<CurrentStatus>().ToList();

            // Nenhum item é selecionado inicialmente no comboBox 'cb_CurrentStatus'
            cb_CurrentStatus.SelectedIndex = -1;

            // Chama o método que carrega os tipos de tarefas no comboBox correspondente
            ListTaskType();   // Lista os tipos de tarefa

            // Chama o método que carrega os programadores disponíveis no comboBox correspondente
            ListProgrammer(); // Lista os programadores
        }
        // Define valores padrão (data atual) para os campos de data do formulário
        private void DateToUpdate()
        {
            // Define a data atual como valor inicial para o campo de data de criação da tarefa
            dtp_CreationDate.Value = DateTime.Now;

            // Define a data atual como valor inicial para a data estimada de início
            dtp_StartDate.Value = DateTime.Now;

            // Define a data atual como valor inicial para a data estimada de fim
            dtp_EndDate.Value = DateTime.Now;

            // Define a data atual como valor inicial para a data real de início
            dtp_StartRealDate.Value = DateTime.Now;

            // Define a data atual como valor inicial para a data real de fim
            dtp_EndRealDate.Value = DateTime.Now;
        }


        /* ---------- Funções de Inicialização (Kanban)   ---------- */
        // Construtor utilizado para visualizar ou editar uma tarefa já existente (usado no modo Kanban)
        public TaskDetailForm(Tasks task, bool readOnly = false)
        {
            // Inicializa os componentes gráficos do formulário
            InitializeComponent();

            // Armazena a tarefa recebida como parâmetro
            this.selectedTasks = task;

            // Armazena o modo de visualização (se for true, o formulário será somente leitura)
            this.isReadOnlyMode = readOnly;

            // Verifica se o utilizador atual da sessão é um gestor
            if (sessionManager.CurrentUser is Maneger manager)
            {
                // Guarda o gestor atual
                currentManeger = manager;

                // Carrega os dados das listas suspensas (status, tipo de tarefa, programadores)
                Value();

                // Se uma tarefa foi fornecida (edição ou visualização)
                if (selectedTasks != null)
                {
                    // Carrega os detalhes da tarefa nos campos do formulário
                    LoadTaskDetails(selectedTasks);

                    // Define o modo de leitura ou edição conforme o parâmetro 'readOnly'
                    SetReadOnlyMode(isReadOnlyMode);
                }
                else
                {
                    // Se não há tarefa fornecida, prepara o formulário para criação de nova tarefa
                    SetupFormForCreation();
                }
            }
            // Caso o utilizador seja um programador
            else if (sessionManager.CurrentUser is Programmer programmer)
            {
                // Programadores só podem visualizar tarefas, não criar
                if (selectedTasks != null)
                {
                    // Carrega valores dos combos
                    Value();

                    // Carrega os detalhes da tarefa
                    LoadTaskDetails(selectedTasks);

                    // Sempre em modo de leitura para programadores
                    SetReadOnlyMode(true);
                }
                else
                {
                    // Programador tentou criar uma nova tarefa — operação não permitida
                    MessageBox.Show("Programadores não podem criar tarefas.");
                    this.Close();
                }
            }
            // Caso o utilizador não seja nem gestor nem programador
            else
            {
                // Exibe mensagem de erro e fecha o formulário
                MessageBox.Show("Tipo de utilizador não autorizado a aceder a este formulário.");
                this.Close();
            }
        }
        // Prepara o formulário para a criação de uma nova tarefa
        private void SetupFormForCreation()
        {
            // Carrega os dados das listas suspensas (status, tipo de tarefa, programadores)
            Value();

            // Esconde o campo de ID, pois ele será gerado automaticamente no banco de dados
            tb_Id.Visible = false;

            // Esconde os campos de datas reais (início e fim), pois ainda não foram iniciadas
            dtp_StartRealDate.Visible = false;
            dtp_EndRealDate.Visible = false;

            // Esconde o campo de data de criação (será definida automaticamente)
            dtp_CreationDate.Visible = false;

            // Exibe apenas o botão de criar tarefa
            b_create.Visible = true;

            // Oculta os botões de leitura, atualização e exclusão (não aplicáveis ao criar)
            b_Read.Visible = false;
            b_Update.Visible = false;
            b_Delete.Visible = false;

            // Limpa todos os campos do formulário para inserir uma nova tarefa
            ClearFormFields();
        }
        // Carrega os dados da tarefa fornecida nos campos do formulário
        private void LoadTaskDetails(Tasks task)
        {
            // Preenche o campo de ID da tarefa
            tb_Id.Text = task.Id.ToString();

            // Preenche a descrição da tarefa
            tb_Description.Text = task.Description;

            // Preenche a ordem de execução da tarefa
            tb_Order.Text = task.ExecutionOrder.ToString();

            // Preenche os pontos de história da tarefa
            tb_StoryPoints.Text = task.StoryPoints.ToString();

            // Preenche as datas estimadas de início e fim da tarefa
            dtp_StartDate.Value = task.EstimatedStartDate;
            dtp_EndDate.Value = task.ExpectedEndDate;

            // Preenche a data de criação da tarefa
            dtp_CreationDate.Value = task.CreationDate;

            // Preenche as datas reais de início e fim (caso não existam, usa a data atual como fallback)
            dtp_StartRealDate.Value = task.ActualStartDate ?? DateTime.Today;
            dtp_EndRealDate.Value = task.ActualEndDate ?? DateTime.Today;

            // Define o estado atual da tarefa no combo box
            cb_CurrentStatus.SelectedItem = task.CurrentStatus;

            // Define o tipo da tarefa selecionado no combo box (se existir, senão seleciona "nenhum")
            cb_TaskType.SelectedValue = task.idTaskType?.Id ?? -1;

            // Define o programador associado no combo box (se existir, senão seleciona "nenhum")
            cb_Programmer.SelectedValue = task.IdProgrammer?.Id ?? -1;
        }
        // Define o modo somente leitura nos campos do formulário
        private void SetReadOnlyMode(bool readOnly)
        {
            // Atualiza o estado interno do modo somente leitura
            isReadOnlyMode = readOnly;

            // Define os campos de texto como somente leitura ou editáveis
            tb_Description.ReadOnly = readOnly;
            tb_Order.ReadOnly = readOnly;
            tb_StoryPoints.ReadOnly = readOnly;

            // Define os controles de data como habilitados ou desabilitados
            dtp_StartDate.Enabled = !readOnly;
            dtp_EndDate.Enabled = !readOnly;
            dtp_CreationDate.Enabled = !readOnly;
            dtp_StartRealDate.Enabled = !readOnly;
            dtp_EndRealDate.Enabled = !readOnly;

            // Define os comboboxes como habilitados ou desabilitados
            cb_CurrentStatus.Enabled = !readOnly;
            cb_TaskType.Enabled = !readOnly;
            cb_Programmer.Enabled = !readOnly;

            // Define visibilidade dos botões com base no tipo de utilizador e modo de leitura
            b_create.Visible = !readOnly && (sessionManager.CurrentUser is Maneger);
            b_Read.Visible = true; // Sempre visível, exceto se estiver em modo somente leitura abaixo
            b_Update.Visible = !readOnly && (sessionManager.CurrentUser is Maneger);
            b_Delete.Visible = !readOnly && (sessionManager.CurrentUser is Maneger);

            // Se estiver em modo somente leitura, esconde todos os botões de ação
            if (readOnly)
            {
                b_create.Visible = false;
                b_Read.Visible = false;
                b_Update.Visible = false;
                b_Delete.Visible = false;
            }

            // O campo de ID sempre permanece somente leitura
            tb_Id.ReadOnly = true;
        }



        /* ---------- Listas  ---------- */
        // Carrega programadores do gestor logado (ou todos, se não for gestor)
        private void ListProgrammer()
        {
            try
            {
                // Abre uma conexão com a base de dados usando o contexto iTasks
                using (var db = new iTasksContext())
                {
                    List<Programmer> programadors;

                    // Se o utilizador atual for um gestor
                    if (sessionManager.CurrentUser is Maneger manager)
                    {
                        // Carrega apenas os programadores associados a este gestor
                        programadors = db.Users
                            .OfType<Programmer>() // Filtra apenas os usuários do tipo Programmer
                            .Where(p => p.idManeger != null && p.idManeger.Id == manager.Id) // Verifica se pertencem ao gestor atual
                            .ToList();
                    }
                    else
                    {
                        // Caso contrário (por exemplo, administrador), carrega todos os programadores
                        programadors = db.Users.OfType<Programmer>().ToList();
                    }

                    // Define a lista de programadores como origem de dados do ComboBox
                    cb_Programmer.DataSource = programadors;
                    cb_Programmer.DisplayMember = "Name"; // O que será exibido no combo
                    cb_Programmer.ValueMember = "Id";     // Valor interno (para obter o ID selecionado)
                    cb_Programmer.SelectedIndex = -1;     // Nenhum item selecionado por padrão
                }
            }
            catch
            {
                // Em caso de erro ao carregar os dados, exibe mensagem no ComboBox
                cb_Programmer.Text = "Erro ao carregar Programadores!";
            }
        }
        // Carrega tipos de tarefa
        private void ListTaskType()
        {
            try
            {
                using (var db = new iTasksContext())
                {
                    // Obtém todos os tipos de tarefa do banco de dados
                    var taskTypes = db.TaskTypes.ToList();

                    // Define a fonte de dados do ComboBox com os tipos de tarefa
                    cb_TaskType.DataSource = taskTypes;
                    cb_TaskType.DisplayMember = "Name"; // Exibe o nome do tipo no ComboBox
                    cb_TaskType.ValueMember = "Id";     // Valor interno (ID do tipo de tarefa)
                    cb_TaskType.SelectedIndex = -1;     // Nenhum item selecionado por padrão
                }
            }
            catch
            {
                // Em caso de erro, mostra mensagem de erro no ComboBox
                cb_TaskType.Text = "Erro ao carregar Tipo de Tarefas!";
            }
        }


        /* ---------- Botões  ---------- */
        // Limpa e reseta todos os campos do formulário para seus valores iniciais padrão.
        private void ClearFormFields()
        {
            tb_Id.Text = "ID";                          // Coloca o texto "ID" no campo de ID (não editável)
            tb_Description.Clear();                     // Limpa o campo de descrição da tarefa
            tb_Order.Clear();                           // Limpa o campo de ordem de execução
            tb_StoryPoints.Clear();                     // Limpa o campo de story points

            dtp_StartDate.Value = DateTime.Today;       // Define a data de início para hoje
            dtp_EndDate.Value = DateTime.Today;         // Define a data prevista para hoje
            dtp_StartRealDate.Value = DateTime.Today;   // Define a data real de início para hoje
            dtp_EndRealDate.Value = DateTime.Today;     // Define a data real de fim para hoje
            dtp_CreationDate.Value = DateTime.Today;    // Define a data de criação para hoje

            cb_CurrentStatus.SelectedIndex = -1;        // Deseleciona o status atual
            cb_CurrentStatus.Text = "";                 // Limpa o texto do combo de status

            // Reseta a fonte de dados do combo de tipos de tarefa e recarrega os valores
            cb_TaskType.DataSource = null;
            cb_TaskType.Items.Clear();
            ListTaskType();

            // Reseta a fonte de dados do combo de programadores e recarrega os valores
            cb_Programmer.DataSource = null;
            cb_Programmer.Items.Clear();
            ListProgrammer();
        }
        // Evento disparado ao clicar no botão de criação de tarefa.
        private void b_create_Click(object sender, EventArgs e)
        {
            // Impede criação se estiver no modo somente leitura
            if (isReadOnlyMode)
            {
                MessageBox.Show("Não pode criar tarefas no modo de visualização.");
                return;
            }

            // Valida que a descrição não está vazia ou só com espaços
            if (string.IsNullOrWhiteSpace(tb_Description.Text))
            {
                MessageBox.Show("Descrição não pode estar vazia.");
                return;
            }

            // Valida que o campo ordem é um número inteiro válido
            if (!int.TryParse(tb_Order.Text.Trim(), out int order))
            {
                MessageBox.Show("Ordem inválida. Por favor, insira um número inteiro.");
                return;
            }

            // Valida que o campo story points é um número inteiro válido
            if (!int.TryParse(tb_StoryPoints.Text.Trim(), out int storyPoint))
            {
                MessageBox.Show("Story Points inválidos. Por favor, insira um número inteiro.");
                return;
            }

            // Valida que foi selecionado um tipo de tarefa válido no combo
            if (!(cb_TaskType.SelectedItem is TaskType taskType))
            {
                MessageBox.Show("Selecione um tipo de tarefa válido.");
                return;
            }

            // Valida que foi selecionado um programador válido no combo
            if (!(cb_Programmer.SelectedItem is Programmer programmer))
            {
                MessageBox.Show("Selecione um programador válido.");
                return;
            }

            // Verifica se o gestor atual está definido
            if (currentManeger == null)
            {
                MessageBox.Show("Gestor não identificado.");
                return;
            }

            // Obtém as datas do formulário, removendo a parte da hora
            DateTime startDate = dtp_StartDate.Value.Date;
            DateTime endDate = dtp_EndDate.Value.Date;

            // Valida que a data de término não é anterior à de início
            if (endDate < startDate)
            {
                MessageBox.Show("Data de término não pode ser anterior à data de início.");
                return;
            }

            try
            {
                using (var db = new iTasksContext())
                {
                    // Verifica se já existe tarefa com essa ordem para o programador e gestor atuais
                    bool orderExists = db.Tasks.Any(t => t.IdProgrammer.Id == programmer.Id
                                                        && t.ExecutionOrder == order
                                                        && t.IdManeger.Id == currentManeger.Id);

                    if (orderExists)
                    {
                        MessageBox.Show("Já existe uma tarefa com essa ordem para este programador sob sua gestão.");
                        return;
                    }

                    // Anexa as entidades relacionadas para evitar duplicações no contexto do Entity Framework
                    db.Users.Attach(programmer);
                    db.Users.Attach(currentManeger);
                    db.TaskTypes.Attach(taskType);

                    // Cria a nova tarefa com os dados fornecidos pelo usuário
                    var newTask = new Tasks()
                    {
                        IdManeger = currentManeger,
                        IdProgrammer = programmer,
                        ExecutionOrder = order,
                        Description = tb_Description.Text.Trim(),
                        EstimatedStartDate = startDate,
                        ExpectedEndDate = endDate,
                        idTaskType = taskType,
                        StoryPoints = storyPoint,
                        CurrentStatus = CurrentStatus.ToDo,  // Status inicial definido como "To Do"
                        CreationDate = DateTime.Now
                    };

                    // Adiciona a nova tarefa ao contexto e salva no banco
                    db.Tasks.Add(newTask);
                    db.SaveChanges();

                    // Atualiza a tarefa selecionada na interface para a recém criada
                    selectedTasks = newTask;

                    // Notifica o usuário do sucesso da operação
                    MessageBox.Show("Nova tarefa criada com sucesso!");

                    // Limpa o formulário para nova entrada
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe mensagem com detalhes para o usuário
                MessageBox.Show($"Erro ao criar tarefa na base de dados: {ex.Message}");
            }
        }
        // Evento disparado ao clicar no botão de consulta de tarefa.
        private void b_Read_Click(object sender, EventArgs e)
        {
            // Captura o texto digitado no campo de descrição para pesquisa
            string descricao = tb_Description.Text;

            // Valida se o campo de descrição está vazio
            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Preenchimento obrigatório no campo da descrição");
                return;
            }

            // Abre o contexto do banco de dados para realizar a consulta
            using (var db = new iTasksContext())
            {
                try
                {
                    // Busca a primeira tarefa cujo texto da descrição contenha o termo pesquisado
                    // e que pertença ao gestor atual (filtra pelo Id do gestor)
                    var tasks = db.Tasks
                        .Include(t => t.idTaskType)     // Inclui os dados do tipo de tarefa relacionados
                        .Include(t => t.IdProgrammer)   // Inclui os dados do programador relacionados
                        .FirstOrDefault(t => t.Description.Contains(descricao) && t.IdManeger.Id == currentManeger.Id);

                    // Se não encontrou tarefa, avisa o usuário e sai
                    if (tasks == null)
                    {
                        MessageBox.Show("Tarefa não encontrada ou não pertence a este gestor.");
                        return;
                    }

                    // Define a tarefa encontrada como a selecionada no formulário
                    selectedTasks = tasks;

                    // Preenche os campos do formulário com os dados da tarefa encontrada
                    tb_Id.Text = tasks.Id.ToString();
                    dtp_StartRealDate.Value = tasks.ActualStartDate ?? DateTime.Today;
                    dtp_EndRealDate.Value = tasks.ActualEndDate ?? DateTime.Today;
                    dtp_CreationDate.Value = tasks.CreationDate;

                    cb_CurrentStatus.SelectedItem = tasks.CurrentStatus;
                    tb_Description.Text = tasks.Description;

                    cb_TaskType.SelectedValue = tasks.idTaskType?.Id ?? -1;
                    cb_Programmer.SelectedValue = tasks.IdProgrammer?.Id ?? -1;

                    tb_Order.Text = tasks.ExecutionOrder.ToString();
                    tb_StoryPoints.Text = tasks.StoryPoints.ToString();
                    dtp_StartDate.Value = tasks.EstimatedStartDate;
                    dtp_EndDate.Value = tasks.ExpectedEndDate;
                }
                catch
                {
                    // Em caso de erro genérico, mostra uma mensagem para o usuário
                    MessageBox.Show("Erro ao consultar tarefa.");
                }
            }
        }
        // Evento disparado ao clicar no botão de atualização da tarefa.
        private void b_Update_Click(object sender, EventArgs e)
        {
            // Impede atualização se estiver no modo somente leitura
            if (isReadOnlyMode)
            {
                MessageBox.Show("Não pode atualizar tarefas no modo de visualização.");
                return;
            }

            // Verifica se alguma tarefa está selecionada para edição
            if (selectedTasks == null)
            {
                MessageBox.Show("Nenhuma tarefa selecionada para edição. Por favor, procure uma tarefa primeiro.");
                return;
            }

            // Obtém os objetos selecionados nos combos de tipo de tarefa e programador
            TaskType taskType = cb_TaskType.SelectedItem as TaskType;
            Programmer programmer = cb_Programmer.SelectedItem as Programmer;

            using (var db = new iTasksContext())
            {
                try
                {
                    // Busca no banco a tarefa a ser atualizada, garantindo que pertence ao gestor atual
                    var taskToUpdate = db.Tasks
                        .FirstOrDefault(t => t.Id == selectedTasks.Id && t.IdManeger.Id == currentManeger.Id);

                    // Se não encontrar a tarefa, informa o usuário e sai
                    if (taskToUpdate == null)
                    {
                        MessageBox.Show("A tarefa não foi encontrada ou não pertence a este gestor.");
                        return;
                    }

                    // Atualiza os campos da tarefa com os valores do formulário
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

                    // Anexa as entidades relacionadas para o contexto do Entity Framework
                    db.Users.Attach(programmer);
                    db.TaskTypes.Attach(taskType);

                    // Atualiza a tarefa selecionada no formulário para o objeto atualizado
                    selectedTasks = taskToUpdate;

                    // Marca a entidade como modificada e salva as alterações no banco
                    db.Entry(selectedTasks).State = EntityState.Modified;
                    db.SaveChanges();

                    // Confirmação para o usuário
                    MessageBox.Show("Tarefa atualizada com sucesso!");
                }
                catch
                {
                    // Em caso de erro genérico, informa o usuário
                    MessageBox.Show("Erro ao atualizar tarefa.");
                }
            }
        }
        // Evento disparado ao clicar no botão de apagar tarefa.
        private void b_Delete_Click(object sender, EventArgs e)
        {
            // Impede exclusão se estiver no modo somente leitura
            if (isReadOnlyMode)
            {
                MessageBox.Show("Não pode apagar tarefas no modo de visualização.");
                return;
            }

            // Verifica se há alguma tarefa selecionada para apagar
            if (selectedTasks == null)
            {
                MessageBox.Show("Nenhuma tarefa selecionada para apagar.");
                return;
            }

            // Cria um contexto para acessar o banco de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Busca no banco a tarefa que será apagada, certificando-se que pertence ao gestor atual
                    var taskToDelete = db.Tasks
                        .FirstOrDefault(t => t.Id == selectedTasks.Id && t.IdManeger.Id == currentManeger.Id);

                    // Se a tarefa não existir ou não pertencer ao gestor, informa o usuário e encerra
                    if (taskToDelete == null)
                    {
                        MessageBox.Show("A tarefa não foi encontrada ou não pertence a este gestor.");
                        return;
                    }

                    // Remove a tarefa do contexto e salva as alterações no banco
                    db.Tasks.Remove(taskToDelete);
                    db.SaveChanges();

                    // Informa que a exclusão foi realizada com sucesso
                    MessageBox.Show("Tarefa apagada com sucesso!");

                    // Limpa o formulário e reseta a tarefa selecionada para null
                    ClearFormFields();
                    selectedTasks = null;
                }
                catch
                {
                    // Em caso de erro, exibe mensagem de falha para o usuário
                    MessageBox.Show("Erro ao apagar tarefa.");
                }
            }
        }
        // Evento disparado ao clicar no botão ou picture box de limpar formulário.
        private void pb_Clear_Click(object sender, EventArgs e)
        {
            // Chama a função que limpa e reseta todos os campos do formulário
            ClearFormFields();
        }
    }
}
