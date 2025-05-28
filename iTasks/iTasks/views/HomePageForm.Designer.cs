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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.p_Bar = new System.Windows.Forms.Panel();
            this.cb_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cb_Maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cb_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.l_NameForm = new System.Windows.Forms.Label();
            this.panelMessage = new Guna.UI2.WinForms.Guna2Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pb_CurrentChildForm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.b_CompletedTasks = new Guna.UI2.WinForms.Guna2Button();
            this.b_OngoingTasks = new Guna.UI2.WinForms.Guna2Button();
            this.b_TaskDetails = new Guna.UI2.WinForms.Guna2Button();
            this.b_Tasks = new Guna.UI2.WinForms.Guna2Button();
            this.b_Users = new Guna.UI2.WinForms.Guna2Button();
            this.pb_Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.p_Menu.SuspendLayout();
            this.p_Tasks.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.p_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
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
            this.p_Menu.Controls.Add(this.b_Users);
            this.p_Menu.Controls.Add(this.panelLogin);
            this.p_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_Menu.Location = new System.Drawing.Point(0, 0);
            this.p_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.p_Menu.Name = "p_Menu";
            this.p_Menu.Size = new System.Drawing.Size(293, 825);
            this.p_Menu.TabIndex = 0;
            // 
            // p_Tasks
            // 
            this.p_Tasks.Controls.Add(this.b_CompletedTasks);
            this.p_Tasks.Controls.Add(this.b_OngoingTasks);
            this.p_Tasks.Controls.Add(this.b_TaskDetails);
            this.p_Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Tasks.Location = new System.Drawing.Point(0, 320);
            this.p_Tasks.Margin = new System.Windows.Forms.Padding(4);
            this.p_Tasks.Name = "p_Tasks";
            this.p_Tasks.Size = new System.Drawing.Size(293, 222);
            this.p_Tasks.TabIndex = 3;
            this.p_Tasks.Visible = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.pb_Logo);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(293, 172);
            this.panelLogin.TabIndex = 0;
            // 
            // p_Bar
            // 
            this.p_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.p_Bar.Controls.Add(this.guna2Button1);
            this.p_Bar.Controls.Add(this.cb_Minimize);
            this.p_Bar.Controls.Add(this.cb_Maximize);
            this.p_Bar.Controls.Add(this.cb_close);
            this.p_Bar.Controls.Add(this.l_NameForm);
            this.p_Bar.Controls.Add(this.pb_CurrentChildForm);
            this.p_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Bar.Location = new System.Drawing.Point(293, 0);
            this.p_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.p_Bar.Name = "p_Bar";
            this.p_Bar.Size = new System.Drawing.Size(1307, 92);
            this.p_Bar.TabIndex = 1;
            this.p_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Bar_MouseDown);
            // 
            // cb_Minimize
            // 
            this.cb_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cb_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.cb_Minimize.IconColor = System.Drawing.Color.White;
            this.cb_Minimize.Location = new System.Drawing.Point(1164, 4);
            this.cb_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Minimize.Name = "cb_Minimize";
            this.cb_Minimize.Size = new System.Drawing.Size(33, 31);
            this.cb_Minimize.TabIndex = 2;
            // 
            // cb_Maximize
            // 
            this.cb_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.cb_Maximize.FillColor = System.Drawing.Color.Transparent;
            this.cb_Maximize.IconColor = System.Drawing.Color.White;
            this.cb_Maximize.Location = new System.Drawing.Point(1211, 4);
            this.cb_Maximize.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Maximize.Name = "cb_Maximize";
            this.cb_Maximize.Size = new System.Drawing.Size(33, 31);
            this.cb_Maximize.TabIndex = 2;
            // 
            // cb_close
            // 
            this.cb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_close.FillColor = System.Drawing.Color.Transparent;
            this.cb_close.IconColor = System.Drawing.Color.White;
            this.cb_close.Location = new System.Drawing.Point(1257, 4);
            this.cb_close.Margin = new System.Windows.Forms.Padding(4);
            this.cb_close.Name = "cb_close";
            this.cb_close.Size = new System.Drawing.Size(33, 31);
            this.cb_close.TabIndex = 2;
            // 
            // l_NameForm
            // 
            this.l_NameForm.AutoSize = true;
            this.l_NameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_NameForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.l_NameForm.Location = new System.Drawing.Point(80, 50);
            this.l_NameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_NameForm.Name = "l_NameForm";
            this.l_NameForm.Size = new System.Drawing.Size(53, 18);
            this.l_NameForm.TabIndex = 1;
            this.l_NameForm.Text = "Home";
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.Location = new System.Drawing.Point(293, 92);
            this.panelMessage.Margin = new System.Windows.Forms.Padding(4);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(1307, 733);
            this.panelMessage.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2Button1.BorderRadius = 24;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(169)))));
            this.guna2Button1.Image = global::iTasks.Properties.Resources.icons8_user_961;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button1.Location = new System.Drawing.Point(1060, 35);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(235, 50);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Nome do Utilizador";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // pb_CurrentChildForm
            // 
            this.pb_CurrentChildForm.Image = global::iTasks.Properties.Resources.icons8_home_96__1_;
            this.pb_CurrentChildForm.ImageRotate = 0F;
            this.pb_CurrentChildForm.Location = new System.Drawing.Point(20, 37);
            this.pb_CurrentChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.pb_CurrentChildForm.Name = "pb_CurrentChildForm";
            this.pb_CurrentChildForm.Size = new System.Drawing.Size(43, 39);
            this.pb_CurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CurrentChildForm.TabIndex = 0;
            this.pb_CurrentChildForm.TabStop = false;
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
            this.b_CompletedTasks.Location = new System.Drawing.Point(0, 148);
            this.b_CompletedTasks.Margin = new System.Windows.Forms.Padding(4);
            this.b_CompletedTasks.Name = "b_CompletedTasks";
            this.b_CompletedTasks.Size = new System.Drawing.Size(293, 74);
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
            this.b_OngoingTasks.Location = new System.Drawing.Point(0, 74);
            this.b_OngoingTasks.Margin = new System.Windows.Forms.Padding(4);
            this.b_OngoingTasks.Name = "b_OngoingTasks";
            this.b_OngoingTasks.Size = new System.Drawing.Size(293, 74);
            this.b_OngoingTasks.TabIndex = 10;
            this.b_OngoingTasks.Text = "Tarefas Em Curso";
            this.b_OngoingTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_OngoingTasks.TextOffset = new System.Drawing.Point(8, 0);
            this.b_OngoingTasks.Click += new System.EventHandler(this.b_OngoingTasks_Click);
            // 
            // b_TaskDetails
            // 
            this.b_TaskDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_TaskDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_TaskDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_TaskDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_TaskDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_TaskDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.b_TaskDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_TaskDetails.ForeColor = System.Drawing.Color.White;
            this.b_TaskDetails.Image = global::iTasks.Properties.Resources.icons8_tasks_96__2_1;
            this.b_TaskDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_TaskDetails.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_TaskDetails.Location = new System.Drawing.Point(0, 0);
            this.b_TaskDetails.Margin = new System.Windows.Forms.Padding(4);
            this.b_TaskDetails.Name = "b_TaskDetails";
            this.b_TaskDetails.Size = new System.Drawing.Size(293, 74);
            this.b_TaskDetails.TabIndex = 9;
            this.b_TaskDetails.Text = "Detalhes Tarefas";
            this.b_TaskDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_TaskDetails.TextOffset = new System.Drawing.Point(8, 0);
            this.b_TaskDetails.Click += new System.EventHandler(this.b_TaskDetails_Click);
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
            this.b_Tasks.Location = new System.Drawing.Point(0, 246);
            this.b_Tasks.Margin = new System.Windows.Forms.Padding(4);
            this.b_Tasks.Name = "b_Tasks";
            this.b_Tasks.Size = new System.Drawing.Size(293, 74);
            this.b_Tasks.TabIndex = 2;
            this.b_Tasks.Text = "Tarefas";
            this.b_Tasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_Tasks.TextOffset = new System.Drawing.Point(8, 0);
            this.b_Tasks.Click += new System.EventHandler(this.b_Tasks_Click);
            // 
            // b_Users
            // 
            this.b_Users.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Users.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Users.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Users.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Users.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.b_Users.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_Users.ForeColor = System.Drawing.Color.White;
            this.b_Users.Image = global::iTasks.Properties.Resources.icons8_queue_96;
            this.b_Users.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_Users.ImageOffset = new System.Drawing.Point(2, 0);
            this.b_Users.Location = new System.Drawing.Point(0, 172);
            this.b_Users.Margin = new System.Windows.Forms.Padding(4);
            this.b_Users.Name = "b_Users";
            this.b_Users.Size = new System.Drawing.Size(293, 74);
            this.b_Users.TabIndex = 1;
            this.b_Users.Text = "Utilizadores";
            this.b_Users.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_Users.TextOffset = new System.Drawing.Point(8, 0);
            this.b_Users.Click += new System.EventHandler(this.b_Users_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.ErrorImage")));
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.ImageRotate = 0F;
            this.pb_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.InitialImage")));
            this.pb_Logo.Location = new System.Drawing.Point(0, 39);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(293, 92);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 825);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.p_Bar);
            this.Controls.Add(this.p_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageForm";
            this.p_Menu.ResumeLayout(false);
            this.p_Tasks.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.p_Bar.ResumeLayout(false);
            this.p_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button b_Tasks;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel p_Tasks;
        private Guna.UI2.WinForms.Guna2Button b_CompletedTasks;
        private Guna.UI2.WinForms.Guna2Button b_OngoingTasks;
        private Guna.UI2.WinForms.Guna2Button b_TaskDetails;
        private System.Windows.Forms.Panel p_Bar;
        private Guna.UI2.WinForms.Guna2PictureBox pb_CurrentChildForm;
        private System.Windows.Forms.Label l_NameForm;
        private Guna.UI2.WinForms.Guna2Panel panelMessage;
        private Guna.UI2.WinForms.Guna2ControlBox cb_close;
        private Guna.UI2.WinForms.Guna2ControlBox cb_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox cb_Maximize;
        private Guna.UI2.WinForms.Guna2PictureBox pb_Logo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}