namespace iTasks.views
{
    partial class TaskDetailForm
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
            this.l_SartDate = new System.Windows.Forms.Label();
            this.l_EndDate = new System.Windows.Forms.Label();
            this.l_CurrentStatus = new System.Windows.Forms.Label();
            this.l_CriationDate = new System.Windows.Forms.Label();
            this.tb_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_StartRealDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_EndRealDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_CurrentStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_CreationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.b_Update = new Guna.UI2.WinForms.Guna2Button();
            this.b_Read = new Guna.UI2.WinForms.Guna2Button();
            this.b_create = new Guna.UI2.WinForms.Guna2Button();
            this.cb_Programmer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_EndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_StartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cb_TaskType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_StoryPoints = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Order = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.EndDate = new System.Windows.Forms.Label();
            this.l_StartDate = new System.Windows.Forms.Label();
            this.l_StoryPoints = new System.Windows.Forms.Label();
            this.l_Order = new System.Windows.Forms.Label();
            this.l_Programmer = new System.Windows.Forms.Label();
            this.l_TaskTipe = new System.Windows.Forms.Label();
            this.l_Description = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_SartDate
            // 
            this.l_SartDate.AutoSize = true;
            this.l_SartDate.ForeColor = System.Drawing.Color.White;
            this.l_SartDate.Location = new System.Drawing.Point(55, 94);
            this.l_SartDate.Name = "l_SartDate";
            this.l_SartDate.Size = new System.Drawing.Size(121, 16);
            this.l_SartDate.TabIndex = 1;
            this.l_SartDate.Text = "Data Real de Início";
            // 
            // l_EndDate
            // 
            this.l_EndDate.AutoSize = true;
            this.l_EndDate.ForeColor = System.Drawing.Color.White;
            this.l_EndDate.Location = new System.Drawing.Point(55, 190);
            this.l_EndDate.Name = "l_EndDate";
            this.l_EndDate.Size = new System.Drawing.Size(112, 16);
            this.l_EndDate.TabIndex = 2;
            this.l_EndDate.Text = "Data Real de Fim";
            // 
            // l_CurrentStatus
            // 
            this.l_CurrentStatus.AutoSize = true;
            this.l_CurrentStatus.ForeColor = System.Drawing.Color.White;
            this.l_CurrentStatus.Location = new System.Drawing.Point(55, 36);
            this.l_CurrentStatus.Name = "l_CurrentStatus";
            this.l_CurrentStatus.Size = new System.Drawing.Size(83, 16);
            this.l_CurrentStatus.TabIndex = 3;
            this.l_CurrentStatus.Text = "Estado Atual";
            // 
            // l_CriationDate
            // 
            this.l_CriationDate.AutoSize = true;
            this.l_CriationDate.ForeColor = System.Drawing.Color.White;
            this.l_CriationDate.Location = new System.Drawing.Point(55, 124);
            this.l_CriationDate.Name = "l_CriationDate";
            this.l_CriationDate.Size = new System.Drawing.Size(105, 16);
            this.l_CriationDate.TabIndex = 4;
            this.l_CriationDate.Text = "Data da Criação";
            // 
            // tb_Id
            // 
            this.tb_Id.AutoRoundedCorners = true;
            this.tb_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Id.DefaultText = "ID";
            this.tb_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Id.Enabled = false;
            this.tb_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Id.Location = new System.Drawing.Point(59, 37);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.PlaceholderText = "";
            this.tb_Id.SelectedText = "";
            this.tb_Id.Size = new System.Drawing.Size(129, 44);
            this.tb_Id.TabIndex = 28;
            this.tb_Id.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dtp_StartRealDate
            // 
            this.dtp_StartRealDate.AutoRoundedCorners = true;
            this.dtp_StartRealDate.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_StartRealDate.Checked = true;
            this.dtp_StartRealDate.Enabled = false;
            this.dtp_StartRealDate.FillColor = System.Drawing.Color.White;
            this.dtp_StartRealDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_StartRealDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_StartRealDate.Location = new System.Drawing.Point(59, 121);
            this.dtp_StartRealDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_StartRealDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_StartRealDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_StartRealDate.Name = "dtp_StartRealDate";
            this.dtp_StartRealDate.Size = new System.Drawing.Size(231, 44);
            this.dtp_StartRealDate.TabIndex = 29;
            this.dtp_StartRealDate.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
            // 
            // dtp_EndRealDate
            // 
            this.dtp_EndRealDate.AutoRoundedCorners = true;
            this.dtp_EndRealDate.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_EndRealDate.Checked = true;
            this.dtp_EndRealDate.Enabled = false;
            this.dtp_EndRealDate.FillColor = System.Drawing.Color.White;
            this.dtp_EndRealDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_EndRealDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_EndRealDate.Location = new System.Drawing.Point(59, 215);
            this.dtp_EndRealDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_EndRealDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_EndRealDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_EndRealDate.Name = "dtp_EndRealDate";
            this.dtp_EndRealDate.Size = new System.Drawing.Size(231, 44);
            this.dtp_EndRealDate.TabIndex = 29;
            this.dtp_EndRealDate.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_EndRealDate);
            this.panel1.Controls.Add(this.dtp_StartRealDate);
            this.panel1.Controls.Add(this.tb_Id);
            this.panel1.Controls.Add(this.l_EndDate);
            this.panel1.Controls.Add(this.l_SartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 322);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_CurrentStatus);
            this.panel3.Controls.Add(this.dtp_CreationDate);
            this.panel3.Controls.Add(this.l_CriationDate);
            this.panel3.Controls.Add(this.l_CurrentStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 322);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 410);
            this.panel3.TabIndex = 32;
            // 
            // cb_CurrentStatus
            // 
            this.cb_CurrentStatus.AutoRoundedCorners = true;
            this.cb_CurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.cb_CurrentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_CurrentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CurrentStatus.Enabled = false;
            this.cb_CurrentStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CurrentStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CurrentStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_CurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_CurrentStatus.ItemHeight = 30;
            this.cb_CurrentStatus.Location = new System.Drawing.Point(59, 60);
            this.cb_CurrentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_CurrentStatus.Name = "cb_CurrentStatus";
            this.cb_CurrentStatus.Size = new System.Drawing.Size(231, 36);
            this.cb_CurrentStatus.TabIndex = 30;
            this.cb_CurrentStatus.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dtp_CreationDate
            // 
            this.dtp_CreationDate.AutoRoundedCorners = true;
            this.dtp_CreationDate.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_CreationDate.Checked = true;
            this.dtp_CreationDate.Enabled = false;
            this.dtp_CreationDate.FillColor = System.Drawing.Color.White;
            this.dtp_CreationDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_CreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_CreationDate.Location = new System.Drawing.Point(59, 153);
            this.dtp_CreationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_CreationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_CreationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_CreationDate.Name = "dtp_CreationDate";
            this.dtp_CreationDate.Size = new System.Drawing.Size(231, 44);
            this.dtp_CreationDate.TabIndex = 29;
            this.dtp_CreationDate.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 732);
            this.panel4.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b_Delete);
            this.panel2.Controls.Add(this.b_Update);
            this.panel2.Controls.Add(this.b_Read);
            this.panel2.Controls.Add(this.b_create);
            this.panel2.Controls.Add(this.cb_Programmer);
            this.panel2.Controls.Add(this.dtp_EndDate);
            this.panel2.Controls.Add(this.dtp_StartDate);
            this.panel2.Controls.Add(this.cb_TaskType);
            this.panel2.Controls.Add(this.tb_StoryPoints);
            this.panel2.Controls.Add(this.tb_Order);
            this.panel2.Controls.Add(this.tb_Description);
            this.panel2.Controls.Add(this.EndDate);
            this.panel2.Controls.Add(this.l_StartDate);
            this.panel2.Controls.Add(this.l_StoryPoints);
            this.panel2.Controls.Add(this.l_Order);
            this.panel2.Controls.Add(this.l_Programmer);
            this.panel2.Controls.Add(this.l_TaskTipe);
            this.panel2.Controls.Add(this.l_Description);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 732);
            this.panel2.TabIndex = 33;
            // 
            // b_Delete
            // 
            this.b_Delete.AutoRoundedCorners = true;
            this.b_Delete.BorderColor = System.Drawing.Color.White;
            this.b_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Delete.FillColor = System.Drawing.Color.LightGray;
            this.b_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_Delete.ForeColor = System.Drawing.Color.Black;
            this.b_Delete.Location = new System.Drawing.Point(708, 535);
            this.b_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(164, 44);
            this.b_Delete.TabIndex = 30;
            this.b_Delete.Text = "APAGAR";
            // 
            // b_Update
            // 
            this.b_Update.AutoRoundedCorners = true;
            this.b_Update.BorderColor = System.Drawing.Color.White;
            this.b_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Update.FillColor = System.Drawing.Color.LightGray;
            this.b_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_Update.ForeColor = System.Drawing.Color.Black;
            this.b_Update.Location = new System.Drawing.Point(496, 535);
            this.b_Update.Margin = new System.Windows.Forms.Padding(4);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(164, 44);
            this.b_Update.TabIndex = 30;
            this.b_Update.Text = "EDITAR";
            this.b_Update.Click += new System.EventHandler(this.b_Update_Click);
            // 
            // b_Read
            // 
            this.b_Read.AutoRoundedCorners = true;
            this.b_Read.BorderColor = System.Drawing.Color.White;
            this.b_Read.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Read.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Read.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Read.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Read.FillColor = System.Drawing.Color.LightGray;
            this.b_Read.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_Read.ForeColor = System.Drawing.Color.Black;
            this.b_Read.Location = new System.Drawing.Point(304, 535);
            this.b_Read.Margin = new System.Windows.Forms.Padding(4);
            this.b_Read.Name = "b_Read";
            this.b_Read.Size = new System.Drawing.Size(164, 44);
            this.b_Read.TabIndex = 30;
            this.b_Read.Text = "CONSULTAR";
            this.b_Read.Click += new System.EventHandler(this.b_Read_Click);
            // 
            // b_create
            // 
            this.b_create.AutoRoundedCorners = true;
            this.b_create.BorderColor = System.Drawing.Color.White;
            this.b_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_create.FillColor = System.Drawing.Color.LightGray;
            this.b_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_create.ForeColor = System.Drawing.Color.Black;
            this.b_create.Location = new System.Drawing.Point(92, 535);
            this.b_create.Margin = new System.Windows.Forms.Padding(4);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(164, 44);
            this.b_create.TabIndex = 30;
            this.b_create.Text = "CRIAR";
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // cb_Programmer
            // 
            this.cb_Programmer.AutoRoundedCorners = true;
            this.cb_Programmer.BackColor = System.Drawing.Color.Transparent;
            this.cb_Programmer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Programmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Programmer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Programmer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Programmer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Programmer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Programmer.ItemHeight = 30;
            this.cb_Programmer.Location = new System.Drawing.Point(496, 236);
            this.cb_Programmer.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Programmer.Name = "cb_Programmer";
            this.cb_Programmer.Size = new System.Drawing.Size(375, 36);
            this.cb_Programmer.TabIndex = 29;
            this.cb_Programmer.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.AutoRoundedCorners = true;
            this.dtp_EndDate.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_EndDate.Checked = true;
            this.dtp_EndDate.FillColor = System.Drawing.Color.White;
            this.dtp_EndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_EndDate.Location = new System.Drawing.Point(496, 410);
            this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_EndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_EndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(376, 44);
            this.dtp_EndDate.TabIndex = 29;
            this.dtp_EndDate.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.AutoRoundedCorners = true;
            this.dtp_StartDate.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_StartDate.Checked = true;
            this.dtp_StartDate.FillColor = System.Drawing.Color.White;
            this.dtp_StartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_StartDate.Location = new System.Drawing.Point(92, 410);
            this.dtp_StartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_StartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_StartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(376, 44);
            this.dtp_StartDate.TabIndex = 29;
            this.dtp_StartDate.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
            // 
            // cb_TaskType
            // 
            this.cb_TaskType.AutoRoundedCorners = true;
            this.cb_TaskType.BackColor = System.Drawing.Color.Transparent;
            this.cb_TaskType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TaskType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TaskType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TaskType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_TaskType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_TaskType.ItemHeight = 30;
            this.cb_TaskType.Location = new System.Drawing.Point(92, 236);
            this.cb_TaskType.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TaskType.Name = "cb_TaskType";
            this.cb_TaskType.Size = new System.Drawing.Size(375, 36);
            this.cb_TaskType.TabIndex = 29;
            this.cb_TaskType.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // tb_StoryPoints
            // 
            this.tb_StoryPoints.Animated = true;
            this.tb_StoryPoints.AutoRoundedCorners = true;
            this.tb_StoryPoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_StoryPoints.DefaultText = "";
            this.tb_StoryPoints.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_StoryPoints.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_StoryPoints.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_StoryPoints.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_StoryPoints.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_StoryPoints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_StoryPoints.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_StoryPoints.Location = new System.Drawing.Point(496, 324);
            this.tb_StoryPoints.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tb_StoryPoints.Name = "tb_StoryPoints";
            this.tb_StoryPoints.PlaceholderText = "";
            this.tb_StoryPoints.SelectedText = "";
            this.tb_StoryPoints.Size = new System.Drawing.Size(376, 44);
            this.tb_StoryPoints.TabIndex = 28;
            this.tb_StoryPoints.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // tb_Order
            // 
            this.tb_Order.Animated = true;
            this.tb_Order.AutoRoundedCorners = true;
            this.tb_Order.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Order.DefaultText = "";
            this.tb_Order.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Order.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Order.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Order.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_Order.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Order.Location = new System.Drawing.Point(92, 324);
            this.tb_Order.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tb_Order.Name = "tb_Order";
            this.tb_Order.PlaceholderText = "";
            this.tb_Order.SelectedText = "";
            this.tb_Order.Size = new System.Drawing.Size(376, 44);
            this.tb_Order.TabIndex = 28;
            this.tb_Order.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // tb_Description
            // 
            this.tb_Description.Animated = true;
            this.tb_Description.AutoRoundedCorners = true;
            this.tb_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Description.DefaultText = "";
            this.tb_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Description.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Description.Location = new System.Drawing.Point(92, 149);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.PlaceholderText = "";
            this.tb_Description.SelectedText = "";
            this.tb_Description.Size = new System.Drawing.Size(780, 44);
            this.tb_Description.TabIndex = 28;
            this.tb_Description.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.ForeColor = System.Drawing.Color.White;
            this.EndDate.Location = new System.Drawing.Point(492, 383);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(145, 18);
            this.EndDate.TabIndex = 16;
            this.EndDate.Text = "Data Prevista de Fim";
            // 
            // l_StartDate
            // 
            this.l_StartDate.AutoSize = true;
            this.l_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_StartDate.ForeColor = System.Drawing.Color.White;
            this.l_StartDate.Location = new System.Drawing.Point(88, 384);
            this.l_StartDate.Name = "l_StartDate";
            this.l_StartDate.Size = new System.Drawing.Size(151, 18);
            this.l_StartDate.TabIndex = 15;
            this.l_StartDate.Text = "Data Prevista de Incio";
            // 
            // l_StoryPoints
            // 
            this.l_StoryPoints.AutoSize = true;
            this.l_StoryPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_StoryPoints.ForeColor = System.Drawing.Color.White;
            this.l_StoryPoints.Location = new System.Drawing.Point(492, 295);
            this.l_StoryPoints.Name = "l_StoryPoints";
            this.l_StoryPoints.Size = new System.Drawing.Size(131, 18);
            this.l_StoryPoints.TabIndex = 14;
            this.l_StoryPoints.Text = "Pontos de História";
            // 
            // l_Order
            // 
            this.l_Order.AutoSize = true;
            this.l_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Order.ForeColor = System.Drawing.Color.White;
            this.l_Order.Location = new System.Drawing.Point(88, 295);
            this.l_Order.Name = "l_Order";
            this.l_Order.Size = new System.Drawing.Size(54, 18);
            this.l_Order.TabIndex = 13;
            this.l_Order.Text = "Ordem";
            // 
            // l_Programmer
            // 
            this.l_Programmer.AutoSize = true;
            this.l_Programmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Programmer.ForeColor = System.Drawing.Color.White;
            this.l_Programmer.Location = new System.Drawing.Point(492, 209);
            this.l_Programmer.Name = "l_Programmer";
            this.l_Programmer.Size = new System.Drawing.Size(96, 18);
            this.l_Programmer.TabIndex = 12;
            this.l_Programmer.Text = "Programador";
            // 
            // l_TaskTipe
            // 
            this.l_TaskTipe.AutoSize = true;
            this.l_TaskTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TaskTipe.ForeColor = System.Drawing.Color.White;
            this.l_TaskTipe.Location = new System.Drawing.Point(88, 209);
            this.l_TaskTipe.Name = "l_TaskTipe";
            this.l_TaskTipe.Size = new System.Drawing.Size(103, 18);
            this.l_TaskTipe.TabIndex = 11;
            this.l_TaskTipe.Text = "Tipo de Tarefa";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Description.ForeColor = System.Drawing.Color.White;
            this.l_Description.Location = new System.Drawing.Point(88, 121);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(76, 18);
            this.l_Description.TabIndex = 10;
            this.l_Description.Text = "Descrição";
            // 
            // TaskDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskDetailForm";
            this.Text = "taskdetailForm1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label l_SartDate;
        private System.Windows.Forms.Label l_EndDate;
        private System.Windows.Forms.Label l_CurrentStatus;
        private System.Windows.Forms.Label l_CriationDate;
        private Guna.UI2.WinForms.Guna2TextBox tb_Id;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_StartRealDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_EndRealDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.Label l_StartDate;
        private System.Windows.Forms.Label l_StoryPoints;
        private System.Windows.Forms.Label l_Order;
        private System.Windows.Forms.Label l_Programmer;
        private System.Windows.Forms.Label l_TaskTipe;
        private System.Windows.Forms.Label l_Description;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_CreationDate;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CurrentStatus;
        private Guna.UI2.WinForms.Guna2TextBox tb_Description;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TaskType;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Programmer;
        private Guna.UI2.WinForms.Guna2TextBox tb_StoryPoints;
        private Guna.UI2.WinForms.Guna2TextBox tb_Order;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_EndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_StartDate;
        private Guna.UI2.WinForms.Guna2Button b_create;
        private Guna.UI2.WinForms.Guna2Button b_Delete;
        private Guna.UI2.WinForms.Guna2Button b_Update;
        private Guna.UI2.WinForms.Guna2Button b_Read;
    }
}