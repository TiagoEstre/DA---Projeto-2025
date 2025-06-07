namespace iTasks.views
{
    partial class HomePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.ElipseHomePage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowFormHomePage = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.AnimateWindowHomePage = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.DragControl1HomePage = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.p_Menu = new System.Windows.Forms.Panel();
            this.p_Tasks = new Guna.UI2.WinForms.Guna2Panel();
            this.b_CompletedTasks = new Guna.UI2.WinForms.Guna2Button();
            this.b_OngoingTasks = new Guna.UI2.WinForms.Guna2Button();
            this.b_Tasks = new Guna.UI2.WinForms.Guna2Button();
            this.p_ManagerApp = new Guna.UI2.WinForms.Guna2Panel();
            this.b_TaskType = new Guna.UI2.WinForms.Guna2Button();
            this.b_Users = new Guna.UI2.WinForms.Guna2Button();
            this.b_ManagerApp = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pb_Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.p_Bar = new System.Windows.Forms.Panel();
            this.b_User = new Guna.UI2.WinForms.Guna2Button();
            this.cb_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cb_Maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cb_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.l_NameForm = new System.Windows.Forms.Label();
            this.pb_CurrentChildForm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMessage = new Guna.UI2.WinForms.Guna2Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.p_Menu.SuspendLayout();
            this.p_Tasks.SuspendLayout();
            this.p_ManagerApp.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.p_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseHomePage
            // 
            this.ElipseHomePage.BorderRadius = 20;
            this.ElipseHomePage.TargetControl = this;
            // 
            // ShadowFormHomePage
            // 
            this.ShadowFormHomePage.TargetForm = this;
            // 
            // AnimateWindowHomePage
            // 
            this.AnimateWindowHomePage.TargetForm = this;
            // 
            // DragControl1HomePage
            // 
            this.DragControl1HomePage.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1HomePage.UseTransparentDrag = true;
            // 
            // p_Menu
            // 
            this.p_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.p_Menu.Controls.Add(this.p_Tasks);
            this.p_Menu.Controls.Add(this.b_Tasks);
            this.p_Menu.Controls.Add(this.p_ManagerApp);
            this.p_Menu.Controls.Add(this.b_ManagerApp);
            this.p_Menu.Controls.Add(this.panelLogin);
            this.p_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_Menu.Location = new System.Drawing.Point(0, 0);
            this.p_Menu.Name = "p_Menu";
            this.p_Menu.Size = new System.Drawing.Size(220, 670);
            this.p_Menu.TabIndex = 0;
            // 
            // p_Tasks
            // 
            this.p_Tasks.Controls.Add(this.b_CompletedTasks);
            this.p_Tasks.Controls.Add(this.b_OngoingTasks);
            this.p_Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Tasks.Location = new System.Drawing.Point(0, 384);
            this.p_Tasks.Name = "p_Tasks";
            this.p_Tasks.Size = new System.Drawing.Size(220, 125);
            this.p_Tasks.TabIndex = 8;
            this.p_Tasks.Visible = false;
            // 
            // b_CompletedTasks
            // 
            this.b_CompletedTasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_CompletedTasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_CompletedTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_CompletedTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_CompletedTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_CompletedTasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.b_CompletedTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_CompletedTasks.ForeColor = System.Drawing.Color.White;
            this.b_CompletedTasks.Image = global::iTasks.Properties.Resources.icons8_to_do_96__1_1;
            this.b_CompletedTasks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_CompletedTasks.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_CompletedTasks.Location = new System.Drawing.Point(0, 60);
            this.b_CompletedTasks.Name = "b_CompletedTasks";
            this.b_CompletedTasks.Size = new System.Drawing.Size(220, 60);
            this.b_CompletedTasks.TabIndex = 11;
            this.b_CompletedTasks.Text = "Tarefas Concluidas";
            this.b_CompletedTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_CompletedTasks.TextOffset = new System.Drawing.Point(8, 0);
            this.b_CompletedTasks.Click += new System.EventHandler(this.b_CompletedTasks_Click);
            // 
            // b_OngoingTasks
            // 
            this.b_OngoingTasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_OngoingTasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_OngoingTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_OngoingTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_OngoingTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_OngoingTasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.b_OngoingTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_OngoingTasks.ForeColor = System.Drawing.Color.White;
            this.b_OngoingTasks.Image = global::iTasks.Properties.Resources.icons8_tasks_96__3_1;
            this.b_OngoingTasks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_OngoingTasks.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_OngoingTasks.Location = new System.Drawing.Point(0, 0);
            this.b_OngoingTasks.Name = "b_OngoingTasks";
            this.b_OngoingTasks.Size = new System.Drawing.Size(220, 60);
            this.b_OngoingTasks.TabIndex = 10;
            this.b_OngoingTasks.Text = "Tarefas Em Curso";
            this.b_OngoingTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_OngoingTasks.TextOffset = new System.Drawing.Point(8, 0);
            this.b_OngoingTasks.Click += new System.EventHandler(this.b_OngoingTasks_Click);
            // 
            // b_Tasks
            // 
            this.b_Tasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Tasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Tasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Tasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Tasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.b_Tasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_Tasks.ForeColor = System.Drawing.Color.White;
            this.b_Tasks.Image = global::iTasks.Properties.Resources.icons8_list_view_96;
            this.b_Tasks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_Tasks.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_Tasks.Location = new System.Drawing.Point(0, 324);
            this.b_Tasks.Name = "b_Tasks";
            this.b_Tasks.Size = new System.Drawing.Size(220, 60);
            this.b_Tasks.TabIndex = 7;
            this.b_Tasks.Text = "Tarefas";
            this.b_Tasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_Tasks.TextOffset = new System.Drawing.Point(8, 0);
            this.b_Tasks.Click += new System.EventHandler(this.b_Tasks_Click);
            // 
            // p_ManagerApp
            // 
            this.p_ManagerApp.Controls.Add(this.b_TaskType);
            this.p_ManagerApp.Controls.Add(this.b_Users);
            this.p_ManagerApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_ManagerApp.Location = new System.Drawing.Point(0, 200);
            this.p_ManagerApp.Name = "p_ManagerApp";
            this.p_ManagerApp.Size = new System.Drawing.Size(220, 124);
            this.p_ManagerApp.TabIndex = 6;
            this.p_ManagerApp.Visible = false;
            // 
            // b_TaskType
            // 
            this.b_TaskType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_TaskType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_TaskType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_TaskType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_TaskType.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_TaskType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.b_TaskType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_TaskType.ForeColor = System.Drawing.Color.White;
            this.b_TaskType.Image = global::iTasks.Properties.Resources.icons8_queue_96;
            this.b_TaskType.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_TaskType.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_TaskType.Location = new System.Drawing.Point(0, 60);
            this.b_TaskType.Name = "b_TaskType";
            this.b_TaskType.Size = new System.Drawing.Size(220, 60);
            this.b_TaskType.TabIndex = 4;
            this.b_TaskType.Text = "Tipos de Tarefas";
            this.b_TaskType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_TaskType.TextOffset = new System.Drawing.Point(8, 0);
            this.b_TaskType.Click += new System.EventHandler(this.b_TaskType_Click);
            // 
            // b_Users
            // 
            this.b_Users.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Users.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Users.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Users.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Users.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.b_Users.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_Users.ForeColor = System.Drawing.Color.White;
            this.b_Users.Image = global::iTasks.Properties.Resources.icons8_queue_96;
            this.b_Users.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_Users.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_Users.Location = new System.Drawing.Point(0, 0);
            this.b_Users.Name = "b_Users";
            this.b_Users.Size = new System.Drawing.Size(220, 60);
            this.b_Users.TabIndex = 2;
            this.b_Users.Text = "Utilizadores";
            this.b_Users.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_Users.TextOffset = new System.Drawing.Point(8, 0);
            this.b_Users.Click += new System.EventHandler(this.b_Users_Click);
            // 
            // b_ManagerApp
            // 
            this.b_ManagerApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_ManagerApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_ManagerApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_ManagerApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_ManagerApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_ManagerApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.b_ManagerApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_ManagerApp.ForeColor = System.Drawing.Color.White;
            this.b_ManagerApp.Image = global::iTasks.Properties.Resources.icons8_queue_96;
            this.b_ManagerApp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_ManagerApp.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_ManagerApp.Location = new System.Drawing.Point(0, 140);
            this.b_ManagerApp.Name = "b_ManagerApp";
            this.b_ManagerApp.Size = new System.Drawing.Size(220, 60);
            this.b_ManagerApp.TabIndex = 1;
            this.b_ManagerApp.Text = "Gestão da Aplicação";
            this.b_ManagerApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_ManagerApp.TextOffset = new System.Drawing.Point(8, 0);
            this.b_ManagerApp.Click += new System.EventHandler(this.b_ManagerApp_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.pb_Logo);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(220, 140);
            this.panelLogin.TabIndex = 0;
            // 
            // pb_Logo
            // 
            this.pb_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.ErrorImage")));
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.ImageRotate = 0F;
            this.pb_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.InitialImage")));
            this.pb_Logo.Location = new System.Drawing.Point(0, 32);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(220, 75);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.pb_Logo_Click);
            // 
            // p_Bar
            // 
            this.p_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.p_Bar.Controls.Add(this.b_User);
            this.p_Bar.Controls.Add(this.cb_Minimize);
            this.p_Bar.Controls.Add(this.cb_Maximize);
            this.p_Bar.Controls.Add(this.cb_close);
            this.p_Bar.Controls.Add(this.l_NameForm);
            this.p_Bar.Controls.Add(this.pb_CurrentChildForm);
            this.p_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Bar.Location = new System.Drawing.Point(220, 0);
            this.p_Bar.Name = "p_Bar";
            this.p_Bar.Size = new System.Drawing.Size(980, 75);
            this.p_Bar.TabIndex = 1;
            this.p_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Bar_MouseDown);
            // 
            // b_User
            // 
            this.b_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_User.AutoRoundedCorners = true;
            this.b_User.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.b_User.BorderRadius = 19;
            this.b_User.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_User.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_User.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.b_User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(169)))));
            this.b_User.Image = global::iTasks.Properties.Resources.icons8_user_961;
            this.b_User.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_User.ImageSize = new System.Drawing.Size(32, 32);
            this.b_User.Location = new System.Drawing.Point(795, 28);
            this.b_User.Margin = new System.Windows.Forms.Padding(2);
            this.b_User.Name = "b_User";
            this.b_User.Size = new System.Drawing.Size(176, 41);
            this.b_User.TabIndex = 6;
            this.b_User.Text = "Nome do Utilizador";
            this.b_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_User.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // cb_Minimize
            // 
            this.cb_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cb_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.cb_Minimize.IconColor = System.Drawing.Color.White;
            this.cb_Minimize.Location = new System.Drawing.Point(873, 3);
            this.cb_Minimize.Name = "cb_Minimize";
            this.cb_Minimize.Size = new System.Drawing.Size(25, 25);
            this.cb_Minimize.TabIndex = 2;
            // 
            // cb_Maximize
            // 
            this.cb_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.cb_Maximize.FillColor = System.Drawing.Color.Transparent;
            this.cb_Maximize.IconColor = System.Drawing.Color.White;
            this.cb_Maximize.Location = new System.Drawing.Point(908, 3);
            this.cb_Maximize.Name = "cb_Maximize";
            this.cb_Maximize.Size = new System.Drawing.Size(25, 25);
            this.cb_Maximize.TabIndex = 2;
            // 
            // cb_close
            // 
            this.cb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_close.FillColor = System.Drawing.Color.Transparent;
            this.cb_close.IconColor = System.Drawing.Color.White;
            this.cb_close.Location = new System.Drawing.Point(943, 3);
            this.cb_close.Name = "cb_close";
            this.cb_close.Size = new System.Drawing.Size(25, 25);
            this.cb_close.TabIndex = 2;
            // 
            // l_NameForm
            // 
            this.l_NameForm.AutoSize = true;
            this.l_NameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_NameForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.l_NameForm.Location = new System.Drawing.Point(60, 41);
            this.l_NameForm.Name = "l_NameForm";
            this.l_NameForm.Size = new System.Drawing.Size(53, 18);
            this.l_NameForm.TabIndex = 1;
            this.l_NameForm.Text = "Home";
            // 
            // pb_CurrentChildForm
            // 
            this.pb_CurrentChildForm.Image = global::iTasks.Properties.Resources.icons8_home_96__1_;
            this.pb_CurrentChildForm.ImageRotate = 0F;
            this.pb_CurrentChildForm.Location = new System.Drawing.Point(15, 30);
            this.pb_CurrentChildForm.Name = "pb_CurrentChildForm";
            this.pb_CurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.pb_CurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CurrentChildForm.TabIndex = 0;
            this.pb_CurrentChildForm.TabStop = false;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.Location = new System.Drawing.Point(220, 75);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(980, 595);
            this.panelMessage.TabIndex = 2;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.p_Bar);
            this.Controls.Add(this.p_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageForm";
            this.p_Menu.ResumeLayout(false);
            this.p_Tasks.ResumeLayout(false);
            this.p_ManagerApp.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.p_Bar.ResumeLayout(false);
            this.p_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseHomePage;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowFormHomePage;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindowHomePage;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1HomePage;
        private System.Windows.Forms.Panel p_Menu;
        private System.Windows.Forms.Panel panelLogin;
        private Guna.UI2.WinForms.Guna2Button b_Users;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel p_Bar;
        private Guna.UI2.WinForms.Guna2PictureBox pb_CurrentChildForm;
        private System.Windows.Forms.Label l_NameForm;
        private Guna.UI2.WinForms.Guna2Panel panelMessage;
        private Guna.UI2.WinForms.Guna2ControlBox cb_close;
        private Guna.UI2.WinForms.Guna2ControlBox cb_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox cb_Maximize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button b_User;
        private Guna.UI2.WinForms.Guna2Panel p_ManagerApp;
        private Guna.UI2.WinForms.Guna2Button b_ManagerApp;
        private Guna.UI2.WinForms.Guna2PictureBox pb_Logo;
        private Guna.UI2.WinForms.Guna2Button b_TaskType;
        private Guna.UI2.WinForms.Guna2Panel p_Tasks;
        private Guna.UI2.WinForms.Guna2Button b_CompletedTasks;
        private Guna.UI2.WinForms.Guna2Button b_OngoingTasks;
        private Guna.UI2.WinForms.Guna2Button b_Tasks;
    }
}