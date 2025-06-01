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
            this.label7 = new System.Windows.Forms.Label();
            this.l_StartDate = new System.Windows.Forms.Label();
            this.l_StoryPoints = new System.Windows.Forms.Label();
            this.l_Order = new System.Windows.Forms.Label();
            this.l_Programmer = new System.Windows.Forms.Label();
            this.l_TaskTipe = new System.Windows.Forms.Label();
            this.l_Description = new System.Windows.Forms.Label();
            this.tb_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_TaskTipe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Programmer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_Order = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_StoryPoints = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.b_create = new Guna.UI2.WinForms.Guna2Button();
            this.b_Read = new Guna.UI2.WinForms.Guna2Button();
            this.b_Update = new Guna.UI2.WinForms.Guna2Button();
            this.b_Delete = new Guna.UI2.WinForms.Guna2Button();
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
            this.l_SartDate.Location = new System.Drawing.Point(41, 76);
            this.l_SartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_SartDate.Name = "l_SartDate";
            this.l_SartDate.Size = new System.Drawing.Size(100, 13);
            this.l_SartDate.TabIndex = 1;
            this.l_SartDate.Text = "Data Real de Início";
            // 
            // l_EndDate
            // 
            this.l_EndDate.AutoSize = true;
            this.l_EndDate.ForeColor = System.Drawing.Color.White;
            this.l_EndDate.Location = new System.Drawing.Point(41, 154);
            this.l_EndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_EndDate.Name = "l_EndDate";
            this.l_EndDate.Size = new System.Drawing.Size(89, 13);
            this.l_EndDate.TabIndex = 2;
            this.l_EndDate.Text = "Data Real de Fim";
            // 
            // l_CurrentStatus
            // 
            this.l_CurrentStatus.AutoSize = true;
            this.l_CurrentStatus.ForeColor = System.Drawing.Color.White;
            this.l_CurrentStatus.Location = new System.Drawing.Point(41, 29);
            this.l_CurrentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_CurrentStatus.Name = "l_CurrentStatus";
            this.l_CurrentStatus.Size = new System.Drawing.Size(67, 13);
            this.l_CurrentStatus.TabIndex = 3;
            this.l_CurrentStatus.Text = "Estado Atual";
            // 
            // l_CriationDate
            // 
            this.l_CriationDate.AutoSize = true;
            this.l_CriationDate.ForeColor = System.Drawing.Color.White;
            this.l_CriationDate.Location = new System.Drawing.Point(41, 101);
            this.l_CriationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_CriationDate.Name = "l_CriationDate";
            this.l_CriationDate.Size = new System.Drawing.Size(84, 13);
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
            this.tb_Id.Location = new System.Drawing.Point(44, 30);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.PlaceholderText = "";
            this.tb_Id.SelectedText = "";
            this.tb_Id.Size = new System.Drawing.Size(97, 36);
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
            this.dtp_StartRealDate.Location = new System.Drawing.Point(44, 98);
            this.dtp_StartRealDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_StartRealDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_StartRealDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_StartRealDate.Name = "dtp_StartRealDate";
            this.dtp_StartRealDate.Size = new System.Drawing.Size(173, 36);
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
            this.dtp_EndRealDate.Location = new System.Drawing.Point(44, 175);
            this.dtp_EndRealDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_EndRealDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_EndRealDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_EndRealDate.Name = "dtp_EndRealDate";
            this.dtp_EndRealDate.Size = new System.Drawing.Size(173, 36);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 262);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_CurrentStatus);
            this.panel3.Controls.Add(this.dtp_CreationDate);
            this.panel3.Controls.Add(this.l_CriationDate);
            this.panel3.Controls.Add(this.l_CurrentStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 262);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 333);
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
            this.cb_CurrentStatus.Location = new System.Drawing.Point(44, 49);
            this.cb_CurrentStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_CurrentStatus.Name = "cb_CurrentStatus";
            this.cb_CurrentStatus.Size = new System.Drawing.Size(174, 36);
            this.cb_CurrentStatus.TabIndex = 30;
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
            this.dtp_CreationDate.Location = new System.Drawing.Point(44, 124);
            this.dtp_CreationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_CreationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_CreationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_CreationDate.Name = "dtp_CreationDate";
            this.dtp_CreationDate.Size = new System.Drawing.Size(173, 36);
            this.dtp_CreationDate.TabIndex = 29;
            this.dtp_CreationDate.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 595);
            this.panel4.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b_Delete);
            this.panel2.Controls.Add(this.b_Update);
            this.panel2.Controls.Add(this.b_Read);
            this.panel2.Controls.Add(this.b_create);
            this.panel2.Controls.Add(this.cb_Programmer);
            this.panel2.Controls.Add(this.guna2DateTimePicker2);
            this.panel2.Controls.Add(this.guna2DateTimePicker1);
            this.panel2.Controls.Add(this.cb_TaskTipe);
            this.panel2.Controls.Add(this.tb_StoryPoints);
            this.panel2.Controls.Add(this.tb_Order);
            this.panel2.Controls.Add(this.tb_Description);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.l_StartDate);
            this.panel2.Controls.Add(this.l_StoryPoints);
            this.panel2.Controls.Add(this.l_Order);
            this.panel2.Controls.Add(this.l_Programmer);
            this.panel2.Controls.Add(this.l_TaskTipe);
            this.panel2.Controls.Add(this.l_Description);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 595);
            this.panel2.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(369, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data Prevista de Fim";
            // 
            // l_StartDate
            // 
            this.l_StartDate.AutoSize = true;
            this.l_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_StartDate.ForeColor = System.Drawing.Color.White;
            this.l_StartDate.Location = new System.Drawing.Point(66, 312);
            this.l_StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_StartDate.Name = "l_StartDate";
            this.l_StartDate.Size = new System.Drawing.Size(125, 15);
            this.l_StartDate.TabIndex = 15;
            this.l_StartDate.Text = "Data Prevista de Incio";
            // 
            // l_StoryPoints
            // 
            this.l_StoryPoints.AutoSize = true;
            this.l_StoryPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_StoryPoints.ForeColor = System.Drawing.Color.White;
            this.l_StoryPoints.Location = new System.Drawing.Point(369, 240);
            this.l_StoryPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_StoryPoints.Name = "l_StoryPoints";
            this.l_StoryPoints.Size = new System.Drawing.Size(107, 15);
            this.l_StoryPoints.TabIndex = 14;
            this.l_StoryPoints.Text = "Pontos de História";
            // 
            // l_Order
            // 
            this.l_Order.AutoSize = true;
            this.l_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Order.ForeColor = System.Drawing.Color.White;
            this.l_Order.Location = new System.Drawing.Point(66, 240);
            this.l_Order.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Order.Name = "l_Order";
            this.l_Order.Size = new System.Drawing.Size(45, 15);
            this.l_Order.TabIndex = 13;
            this.l_Order.Text = "Ordem";
            // 
            // l_Programmer
            // 
            this.l_Programmer.AutoSize = true;
            this.l_Programmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Programmer.ForeColor = System.Drawing.Color.White;
            this.l_Programmer.Location = new System.Drawing.Point(369, 170);
            this.l_Programmer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Programmer.Name = "l_Programmer";
            this.l_Programmer.Size = new System.Drawing.Size(80, 15);
            this.l_Programmer.TabIndex = 12;
            this.l_Programmer.Text = "Programador";
            // 
            // l_TaskTipe
            // 
            this.l_TaskTipe.AutoSize = true;
            this.l_TaskTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TaskTipe.ForeColor = System.Drawing.Color.White;
            this.l_TaskTipe.Location = new System.Drawing.Point(66, 170);
            this.l_TaskTipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_TaskTipe.Name = "l_TaskTipe";
            this.l_TaskTipe.Size = new System.Drawing.Size(86, 15);
            this.l_TaskTipe.TabIndex = 11;
            this.l_TaskTipe.Text = "Tipo de Tarefa";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Description.ForeColor = System.Drawing.Color.White;
            this.l_Description.Location = new System.Drawing.Point(66, 98);
            this.l_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(62, 15);
            this.l_Description.TabIndex = 10;
            this.l_Description.Text = "Descrição";
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
            this.tb_Description.Location = new System.Drawing.Point(69, 121);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.PlaceholderText = "";
            this.tb_Description.SelectedText = "";
            this.tb_Description.Size = new System.Drawing.Size(585, 36);
            this.tb_Description.TabIndex = 28;
            this.tb_Description.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // cb_TaskTipe
            // 
            this.cb_TaskTipe.AutoRoundedCorners = true;
            this.cb_TaskTipe.BackColor = System.Drawing.Color.Transparent;
            this.cb_TaskTipe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TaskTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TaskTipe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TaskTipe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TaskTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_TaskTipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_TaskTipe.ItemHeight = 30;
            this.cb_TaskTipe.Location = new System.Drawing.Point(69, 192);
            this.cb_TaskTipe.Name = "cb_TaskTipe";
            this.cb_TaskTipe.Size = new System.Drawing.Size(282, 36);
            this.cb_TaskTipe.TabIndex = 29;
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
            this.cb_Programmer.Location = new System.Drawing.Point(372, 192);
            this.cb_Programmer.Name = "cb_Programmer";
            this.cb_Programmer.Size = new System.Drawing.Size(282, 36);
            this.cb_Programmer.TabIndex = 29;
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
            this.tb_Order.Location = new System.Drawing.Point(69, 263);
            this.tb_Order.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tb_Order.Name = "tb_Order";
            this.tb_Order.PlaceholderText = "";
            this.tb_Order.SelectedText = "";
            this.tb_Order.Size = new System.Drawing.Size(282, 36);
            this.tb_Order.TabIndex = 28;
            this.tb_Order.TextOffset = new System.Drawing.Point(10, 0);
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
            this.tb_StoryPoints.Location = new System.Drawing.Point(372, 263);
            this.tb_StoryPoints.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tb_StoryPoints.Name = "tb_StoryPoints";
            this.tb_StoryPoints.PlaceholderText = "";
            this.tb_StoryPoints.SelectedText = "";
            this.tb_StoryPoints.Size = new System.Drawing.Size(282, 36);
            this.tb_StoryPoints.TabIndex = 28;
            this.tb_StoryPoints.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(69, 333);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(282, 36);
            this.guna2DateTimePicker1.TabIndex = 29;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.AutoRoundedCorners = true;
            this.guna2DateTimePicker2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(372, 333);
            this.guna2DateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(282, 36);
            this.guna2DateTimePicker2.TabIndex = 29;
            this.guna2DateTimePicker2.Value = new System.DateTime(2025, 5, 31, 16, 22, 43, 794);
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
            this.b_create.Location = new System.Drawing.Point(69, 435);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(123, 36);
            this.b_create.TabIndex = 30;
            this.b_create.Text = "CRIAR";
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
            this.b_Read.Location = new System.Drawing.Point(228, 435);
            this.b_Read.Name = "b_Read";
            this.b_Read.Size = new System.Drawing.Size(123, 36);
            this.b_Read.TabIndex = 30;
            this.b_Read.Text = "CONSULTAR";
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
            this.b_Update.Location = new System.Drawing.Point(372, 435);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(123, 36);
            this.b_Update.TabIndex = 30;
            this.b_Update.Text = "EDITAR";
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
            this.b_Delete.Location = new System.Drawing.Point(531, 435);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(123, 36);
            this.b_Delete.TabIndex = 30;
            this.b_Delete.Text = "APAGAR";
            // 
            // TaskDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_StartDate;
        private System.Windows.Forms.Label l_StoryPoints;
        private System.Windows.Forms.Label l_Order;
        private System.Windows.Forms.Label l_Programmer;
        private System.Windows.Forms.Label l_TaskTipe;
        private System.Windows.Forms.Label l_Description;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_CreationDate;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CurrentStatus;
        private Guna.UI2.WinForms.Guna2TextBox tb_Description;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TaskTipe;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Programmer;
        private Guna.UI2.WinForms.Guna2TextBox tb_StoryPoints;
        private Guna.UI2.WinForms.Guna2TextBox tb_Order;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button b_create;
        private Guna.UI2.WinForms.Guna2Button b_Delete;
        private Guna.UI2.WinForms.Guna2Button b_Update;
        private Guna.UI2.WinForms.Guna2Button b_Read;
    }
}