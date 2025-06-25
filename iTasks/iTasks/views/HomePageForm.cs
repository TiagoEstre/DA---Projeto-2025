using iTasks.controller;
using iTasks.models;
using iTasks.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace iTasks.views
{
    public partial class HomePageForm : Form
    {
        // Armazena uma referência para o formulario atualmente ativo no painel principal
        private Form formAtivo;

        public HomePageForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            trocarForm(new KanbanForm(trocarForm));
            VerifyUsers();

        }


        /* ---------- Funções de Inicialização  ---------- */
        // Método que carrega os dados do utilizador atual na interface
        private void LoadCurrentUser()
        {
            // Verifica se existe uma sessão iniciada (se o utilizador está autenticado)
            if (sessionManager.IsLoggedIn())
            {
                // Obtém o utlizador autal a partir do gestor de sessão
                var currentUser = sessionManager.CurrentUser;

                // Define o nome do utilizador no camponente da interface (b_User)
                b_User.Text = currentUser.Name;
            }
        }
        // Método que verifica se existe gestores com base no nome do utilizador atual
        private void VerifyUsers()
        {
            // obtém o utilizador atualmente com sessão iniciada
            var currentUser = sessionManager.CurrentUser;

            // Guarda o nome do utilizador uma variável
            string name = currentUser.Name;

            // Criar uma instência do contexto da base de dados
            using (var db = new iTasksContext())
            {
                try
                {
                    // Filtra os utilizadores do tipo "Maneger" cujo nome contenha o nome do utilizador atual
                    var Managers = db.Users
                        .OfType<Maneger>()                                              // Apenas objetos do tipo Maneger
                        .Where(m =>
                                (string.IsNullOrEmpty(name) || m.Name.Contains(name)))  // Se o nome estiver vazio ou contido no nome gestor
                        .ToList();

                    // Se não forem encontrados gestores com o nome do utilizador atual
                    if (Managers.Count == 0)
                    {
                        // Esconde o botão ou compenente relacionado com utilizadores
                        b_Users.Visible = false;
                        // Ajusta o tamanho do painel "p_ManagerApp"
                        p_ManagerApp.Size = new System.Drawing.Size(220, 60);
                    }


                }
                catch
                {
                    // Em caso de erro ao aceder a base de dados, mostra uma mensagem
                    MessageBox.Show("Erro ao consultar gestores");
                }
            }
        }


        /* ---------- Funções  ---------- */

        /* ---------- Mover NavBar  ---------- */
        // Codigo necessário para primitir mover o formulário ao arrastar com o rato
        // Importação da ReleaseCapture da biblioteca user32.dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        // Importação da função SendMessage da biblioteca user32.dll
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Evento que permite mover o furmulario ao clicar e arrastar no painel "p_Bar"
        private void p_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                               // Liberta o controlo do rato do painel
            SendMessage(this.Handle, 0x112, 0xf012, 0);     // Envia uma mensagem ao sistema para iniciar o movimento do formulario
        }


        /* ---------- Funções dos formularios  ---------- */
        // Função para trocar o formulario dentro do painel (p_Message)
        public void trocarForm(Form novoForm)
        {
            // Se já existir um formulário ativo, fecha-o e remove-o do painel
            if (formAtivo != null)
            {
                formAtivo.Close();
                p_Message.Controls.Remove(formAtivo);
            }

            formAtivo = novoForm;                               // Define o novo formulario como o formulario ativo
            novoForm.TopLevel = false;                          // Define que o formulario não será de nivel superior (não abre como janela separada)
            novoForm.FormBorderStyle = FormBorderStyle.None;    // Remove a borda do novo formulario
            novoForm.Dock = DockStyle.Fill;                     // Faz com que o formulario ocupe rodo o espaço do painel

            // Adiciona o novo formulario ao painel e mostra-o
            p_Message.Controls.Add(novoForm);
            novoForm.Show();
        }
        
        // Evento que trata o fecho do formulário principal (HomepageForm)
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fecho a aplicação quando o formulario principal é encerrado
            Close();
        }


        /* ---------- Botões Menu  ---------- */
        // Métedo responsavel por redefinir o alinhamento dos icons dos botões para a esquerda
        private void ResetButtonAlignments()
        {
            b_ManagerApp.ImageAlign = HorizontalAlignment.Left;         // Alinha o icone do botão "ManegerApp" a esquerda
            b_Users.ImageAlign = HorizontalAlignment.Left;              // Alinha o icone do botão "Users" a esquerda
            b_TaskType.ImageAlign = HorizontalAlignment.Left;           // Alinha o icone do botão "TaskType" a esquerda

            b_Tasks.ImageAlign = HorizontalAlignment.Left;              // Alinha o icone do botão "Tasks" a esquerda
            b_OngoingTasks.ImageAlign = HorizontalAlignment.Left;       // Alinha o icone do botão "OngoingTasks" a esquerda
            b_CompletedTasks.ImageAlign = HorizontalAlignment.Left;     // Alinha o icone do botão "CompletedTasks" a esquerda
        }

        /* ---------- Logo  ---------- */
        // Ao clicar no logótipo, volta ao painel principal "Kanban"
        private void pb_Logo_Click(object sender, EventArgs e)
        {
            // Restaura o alinhamento padrão dos icons dos botões (alinhamento a esquerda)
            ResetButtonAlignments();

            // Oculta submenus
            p_ManagerApp.Visible = false;
            p_Tasks.Visible = false;

            // Atualiza o nome e icone do formulario atual
            l_NameForm.Text = "Menu";
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_home_96__1_;
            
            // Troca o formulario mostrado no painel principal
            trocarForm(new KanbanForm(trocarForm));
        }


        /* ---------- Gestão  ---------- */
        // Expande/recolhe o submenu da gestão
        private void b_ManagerApp_Click(object sender, EventArgs e)
        {
            // Guarda o estado atual de visibilidade do painel "p_ManagerApp"
            bool isVisible = p_ManagerApp.Visible;

            // Se o icone do botão estiver linhado a esquerda, indica que o submenu ainda esta recolhido
            if(b_ManagerApp.ImageAlign == HorizontalAlignment.Left)
            {
                ResetButtonAlignments();                                // Restaura o alinhamento padrão de todos os botões
                b_ManagerApp.ImageAlign = HorizontalAlignment.Right;    // Alinha o icone do botão atual (ManagerApp) a direita, indicando que esta ativo
            }
            else
            {
                // se o submenu já estiver aberto, apenas reseta os alinhamentos novamente
                ResetButtonAlignments();
            }

            // Sempre que o submenu da gestão for aberto ou fechado,
            // esconde o painel "p_Tasks" (submenu de tarefas)
            p_Tasks.Visible = false;
            // Alterna a visibilidade do painel "p_ManagerApp" (submenu da gestão)
            p_ManagerApp.Visible = !isVisible;
        }
        // Alinha o botão, atualiza o cabeçalho e exibe o formulario correspondente
        private void b_Users_Click(object sender, EventArgs e)
        {
            // Se o icone do botão estiver linhado a esquerda, indica que o submenu ainda esta recolhido
            if (b_Users.ImageAlign == HorizontalAlignment.Left)
            {
                ResetButtonAlignments();                                // Restaura o alinhamento padrão de todos os botões
                b_Users.ImageAlign = HorizontalAlignment.Right;    // Alinha o icone do botão atual (Users) a direita, indicando que esta ativo
            }
            else
            {
                // se o submenu já estiver aberto, apenas reseta os alinhamentos novamente
                ResetButtonAlignments();
            }

            // Atualiza o texto do rótulo "l_NameForm" para indicar o formulário atual
            l_NameForm.Text = "Utilizadores";
            // Atualiza a imagem do PictureBox "pb_CurrentChildForm" para o ícone correspondente ao formulário de Utilizadores
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;

            // Chama o método "trocarForm" para carregar e exibir o formulário "UserManagementForm"
            trocarForm(new UserManagementForm());
        }
        // Alinha o botão, atualiza o cabeçalho e exibe o formulario correspondente
        private void b_TaskType_Click(object sender, EventArgs e)
        {
            // Se o icone do botão estiver linhado a esquerda, indica que o submenu ainda esta recolhido
            if (b_TaskType.ImageAlign == HorizontalAlignment.Left)
            {
                ResetButtonAlignments();                                // Restaura o alinhamento padrão de todos os botões
                b_TaskType.ImageAlign = HorizontalAlignment.Right;    // Alinha o icone do botão atual (TaskType) a direita, indicando que esta ativo
            }
            else
            {
                // se o submenu já estiver aberto, apenas reseta os alinhamentos novamente
                ResetButtonAlignments();
            }

            
            l_NameForm.Text = "Tipo de Tarefas";                                        // Atualiza o nome do formulario exibido no cabeçalho
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_queue_96;    // Atualiza o icone no cabeçalho
            trocarForm(new TaskTypeForm());                                             // Substitui o formulario principal pelo formulario de tipo de tarefas
        }


        /* ---------- Tarefas  ---------- */
        // Expande/recolhe o submenu da Tarefas
        private void b_Tasks_Click(object sender, EventArgs e)
        {
            // Guarda o estado atual de visibilidade do painel "p_Tasks"
            bool isVisible = p_Tasks.Visible;

            // Se o icone do botão estiver linhado a esquerda, indica que o submenu ainda esta recolhido
            if (b_Tasks.ImageAlign == HorizontalAlignment.Left)
            {
                ResetButtonAlignments();                                // Restaura o alinhamento padrão de todos os botões
                b_Tasks.ImageAlign = HorizontalAlignment.Right;    // Alinha o icone do botão atual (Tasks) a direita, indicando que esta ativo
            }
            else
            {
                // se o submenu já estiver aberto, apenas reseta os alinhamentos novamente
                ResetButtonAlignments();
            }


            p_ManagerApp.Visible = false;   // Oculta o submenu de gestão, garantindo que apenas um submenu fique visivel
            p_Tasks.Visible = !isVisible;   // Alterna a visibilidade do submenu de tarefas
        }
        // Alinha o botão, atualiza o cabeçalho e exibe o formulario correspondente
        private void b_OngoingTasks_Click(object sender, EventArgs e)
        {
            // Se o icone do botão estiver linhado a esquerda, indica que o submenu ainda esta recolhido
            if (b_OngoingTasks.ImageAlign == HorizontalAlignment.Left)
            {
                ResetButtonAlignments();                                // Restaura o alinhamento padrão de todos os botões
                b_OngoingTasks.ImageAlign = HorizontalAlignment.Right;    // Alinha o icone do botão atual (OngoingTasks) a direita, indicando que esta ativo
            }
            else
            {
                // se o submenu já estiver aberto, apenas reseta os alinhamentos novamente
                ResetButtonAlignments();
            }


            l_NameForm.Text = "Tarefas Em Curso";                                           // Atualiza o titulo do formalario exibido no cabeçalho
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_tasks_96__1_;    // Atualiza o icone do cabeçalho
            trocarForm(new OngoingTasksForm());                                             // Substitui o formulario principal pelo formulario de tarefas em curso
         
        }
        // Alinha o botão, atualiza o cabeçalho e exibe o formulario correspondente
        private void b_CompletedTasks_Click(object sender, EventArgs e)
        {
            // Se o icone do botão estiver linhado a esquerda, indica que o submenu ainda esta recolhido
            if (b_CompletedTasks.ImageAlign == HorizontalAlignment.Left)
            {
                ResetButtonAlignments();                                // Restaura o alinhamento padrão de todos os botões
                b_CompletedTasks.ImageAlign = HorizontalAlignment.Right;    // Alinha o icone do botão atual (CompletedTasks) a direita, indicando que esta ativo
            }
            else
            {
                // se o submenu já estiver aberto, apenas reseta os alinhamentos novamente
                ResetButtonAlignments();
            }


            l_NameForm.Text = "Tarefas Concluidas";                                     // Atualiza o titulo do formalario exibido no cabeçalho
            pb_CurrentChildForm.Image = iTasks.Properties.Resources.icons8_to_do_96;    // Atualiza o icone do cabeçalho
            trocarForm(new CompletedTasksForm());                                       // Substitui o formulario principal pelo formulario de tarefas em curso
        }


        /* ---------- Terminar Sessão  ---------- */
        // Termina a sessão atual e retorna para o formulario de login
        private void itb_logout_CheckedChanged(object sender, EventArgs e)
        {
            sessionManager.Logout();                    // Executa o logout da sessão atual

            LoginForm loginForm = new LoginForm();      // Cria uma nova instancia do formulario de login

            Hide();                                     // Oculta o formulario atual (sem encerra-lo ainda)
            loginForm.FormClosed += Closed_FormClosed;  // Garante que, quando o formulario de login for fechado, este formulario tambem seja encerrado corretamente
            loginForm.ShowDialog();                     // Exibe o formulario de login como dialogo modal (bloqueia a interação com outras janelas até ser fechado)
        }
    }
}
