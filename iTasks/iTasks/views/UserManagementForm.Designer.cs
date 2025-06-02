namespace iTasks.views
{
    partial class UserManagementForm
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
            this.cb_Programmer = new System.Windows.Forms.CheckBox();
            this.cb_Manager = new System.Windows.Forms.CheckBox();
            this.l_ExperienceLevel = new System.Windows.Forms.Label();
            this.l_Manager = new System.Windows.Forms.Label();
            this.l_Department = new System.Windows.Forms.Label();
            this.lb_Manager = new System.Windows.Forms.ListBox();
            this.tb_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_ExperienceLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Maneger = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Department = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ts_ManegerUsername = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.l_ManegerUsername = new System.Windows.Forms.Label();
            this.b_Create = new Guna.UI2.WinForms.Guna2Button();
            this.b_Consult = new Guna.UI2.WinForms.Guna2Button();
            this.b_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.b_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.p_Manager = new System.Windows.Forms.Panel();
            this.p_Programmer = new System.Windows.Forms.Panel();
            this.lb_Programmer = new System.Windows.Forms.ListBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.p_Manager.SuspendLayout();
            this.p_Programmer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Programmer
            // 
            this.cb_Programmer.AutoSize = true;
            this.cb_Programmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Programmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_Programmer.Location = new System.Drawing.Point(244, 98);
            this.cb_Programmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Programmer.Name = "cb_Programmer";
            this.cb_Programmer.Size = new System.Drawing.Size(128, 24);
            this.cb_Programmer.TabIndex = 6;
            this.cb_Programmer.Text = "Programador";
            this.cb_Programmer.UseVisualStyleBackColor = true;
            this.cb_Programmer.CheckedChanged += new System.EventHandler(this.cb_Programmer_CheckedChanged);
            // 
            // cb_Manager
            // 
            this.cb_Manager.AutoSize = true;
            this.cb_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Manager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_Manager.Location = new System.Drawing.Point(465, 98);
            this.cb_Manager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Manager.Name = "cb_Manager";
            this.cb_Manager.Size = new System.Drawing.Size(82, 24);
            this.cb_Manager.TabIndex = 7;
            this.cb_Manager.Text = "Gestor";
            this.cb_Manager.UseVisualStyleBackColor = true;
            this.cb_Manager.CheckedChanged += new System.EventHandler(this.cb_Manager_CheckedChanged);
            // 
            // l_ExperienceLevel
            // 
            this.l_ExperienceLevel.AutoSize = true;
            this.l_ExperienceLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_ExperienceLevel.Location = new System.Drawing.Point(5, 15);
            this.l_ExperienceLevel.Name = "l_ExperienceLevel";
            this.l_ExperienceLevel.Size = new System.Drawing.Size(131, 16);
            this.l_ExperienceLevel.TabIndex = 9;
            this.l_ExperienceLevel.Text = "Nível de Experiencia";
            // 
            // l_Manager
            // 
            this.l_Manager.AutoSize = true;
            this.l_Manager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Manager.Location = new System.Drawing.Point(5, 101);
            this.l_Manager.Name = "l_Manager";
            this.l_Manager.Size = new System.Drawing.Size(47, 16);
            this.l_Manager.TabIndex = 10;
            this.l_Manager.Text = "Gestor";
            // 
            // l_Department
            // 
            this.l_Department.AutoSize = true;
            this.l_Department.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Department.Location = new System.Drawing.Point(8, 15);
            this.l_Department.Name = "l_Department";
            this.l_Department.Size = new System.Drawing.Size(93, 16);
            this.l_Department.TabIndex = 13;
            this.l_Department.Text = "Departamento";
            // 
            // lb_Manager
            // 
            this.lb_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Manager.FormattingEnabled = true;
            this.lb_Manager.ItemHeight = 25;
            this.lb_Manager.Location = new System.Drawing.Point(711, 87);
            this.lb_Manager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Manager.Name = "lb_Manager";
            this.lb_Manager.Size = new System.Drawing.Size(484, 429);
            this.lb_Manager.TabIndex = 21;
            this.lb_Manager.Visible = false;
            // 
            // tb_Name
            // 
            this.tb_Name.AutoRoundedCorners = true;
            this.tb_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Name.DefaultText = "Nome";
            this.tb_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Name.Location = new System.Drawing.Point(80, 161);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.PlaceholderText = "";
            this.tb_Name.SelectedText = "";
            this.tb_Name.Size = new System.Drawing.Size(485, 44);
            this.tb_Name.TabIndex = 22;
            // 
            // tb_Username
            // 
            this.tb_Username.AutoRoundedCorners = true;
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Username.DefaultText = "Utilizador";
            this.tb_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Username.Location = new System.Drawing.Point(80, 241);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.PlaceholderText = "";
            this.tb_Username.SelectedText = "";
            this.tb_Username.Size = new System.Drawing.Size(485, 44);
            this.tb_Username.TabIndex = 22;
            // 
            // tb_Password
            // 
            this.tb_Password.AutoRoundedCorners = true;
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.DefaultText = "Senha";
            this.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.Location = new System.Drawing.Point(80, 321);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PlaceholderText = "";
            this.tb_Password.SelectedText = "";
            this.tb_Password.Size = new System.Drawing.Size(485, 44);
            this.tb_Password.TabIndex = 22;
            // 
            // cb_ExperienceLevel
            // 
            this.cb_ExperienceLevel.AutoRoundedCorners = true;
            this.cb_ExperienceLevel.BackColor = System.Drawing.Color.Transparent;
            this.cb_ExperienceLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ExperienceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ExperienceLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ExperienceLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ExperienceLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_ExperienceLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_ExperienceLevel.ItemHeight = 30;
            this.cb_ExperienceLevel.Location = new System.Drawing.Point(0, 38);
            this.cb_ExperienceLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ExperienceLevel.Name = "cb_ExperienceLevel";
            this.cb_ExperienceLevel.Size = new System.Drawing.Size(484, 36);
            this.cb_ExperienceLevel.TabIndex = 23;
            // 
            // cb_Maneger
            // 
            this.cb_Maneger.AutoRoundedCorners = true;
            this.cb_Maneger.BackColor = System.Drawing.Color.Transparent;
            this.cb_Maneger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Maneger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Maneger.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Maneger.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Maneger.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Maneger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Maneger.ItemHeight = 30;
            this.cb_Maneger.Location = new System.Drawing.Point(0, 124);
            this.cb_Maneger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Maneger.Name = "cb_Maneger";
            this.cb_Maneger.Size = new System.Drawing.Size(484, 36);
            this.cb_Maneger.TabIndex = 23;
            // 
            // cb_Department
            // 
            this.cb_Department.AutoRoundedCorners = true;
            this.cb_Department.BackColor = System.Drawing.Color.Transparent;
            this.cb_Department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Department.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Department.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Department.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Department.ItemHeight = 30;
            this.cb_Department.Location = new System.Drawing.Point(0, 38);
            this.cb_Department.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(484, 36);
            this.cb_Department.TabIndex = 23;
            // 
            // ts_ManegerUsername
            // 
            this.ts_ManegerUsername.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_ManegerUsername.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_ManegerUsername.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_ManegerUsername.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ts_ManegerUsername.Location = new System.Drawing.Point(12, 134);
            this.ts_ManegerUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ts_ManegerUsername.Name = "ts_ManegerUsername";
            this.ts_ManegerUsername.Size = new System.Drawing.Size(47, 25);
            this.ts_ManegerUsername.TabIndex = 24;
            this.ts_ManegerUsername.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_ManegerUsername.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_ManegerUsername.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_ManegerUsername.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // l_ManegerUsername
            // 
            this.l_ManegerUsername.AutoSize = true;
            this.l_ManegerUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_ManegerUsername.Location = new System.Drawing.Point(75, 139);
            this.l_ManegerUsername.Name = "l_ManegerUsername";
            this.l_ManegerUsername.Size = new System.Drawing.Size(145, 16);
            this.l_ManegerUsername.TabIndex = 13;
            this.l_ManegerUsername.Text = "GERE UTILIZADORES";
            // 
            // b_Create
            // 
            this.b_Create.AutoRoundedCorners = true;
            this.b_Create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Create.FillColor = System.Drawing.Color.LightGray;
            this.b_Create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_Create.ForeColor = System.Drawing.Color.Black;
            this.b_Create.Location = new System.Drawing.Point(80, 597);
            this.b_Create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Create.Name = "b_Create";
            this.b_Create.Size = new System.Drawing.Size(159, 44);
            this.b_Create.TabIndex = 25;
            this.b_Create.Text = "Criar";
            this.b_Create.Click += new System.EventHandler(this.b_Create_Click);
            // 
            // b_Consult
            // 
            this.b_Consult.AutoRoundedCorners = true;
            this.b_Consult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Consult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Consult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Consult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Consult.FillColor = System.Drawing.Color.LightGray;
            this.b_Consult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_Consult.ForeColor = System.Drawing.Color.Black;
            this.b_Consult.Location = new System.Drawing.Point(407, 597);
            this.b_Consult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Consult.Name = "b_Consult";
            this.b_Consult.Size = new System.Drawing.Size(159, 44);
            this.b_Consult.TabIndex = 25;
            this.b_Consult.Text = "Consultar";
            // 
            // b_Edit
            // 
            this.b_Edit.AutoRoundedCorners = true;
            this.b_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Edit.FillColor = System.Drawing.Color.LightGray;
            this.b_Edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_Edit.ForeColor = System.Drawing.Color.Black;
            this.b_Edit.Location = new System.Drawing.Point(711, 597);
            this.b_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(159, 44);
            this.b_Edit.TabIndex = 25;
            this.b_Edit.Text = "Editar";
            // 
            // b_Delete
            // 
            this.b_Delete.AutoRoundedCorners = true;
            this.b_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Delete.FillColor = System.Drawing.Color.LightGray;
            this.b_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_Delete.ForeColor = System.Drawing.Color.Black;
            this.b_Delete.Location = new System.Drawing.Point(1037, 597);
            this.b_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(159, 44);
            this.b_Delete.TabIndex = 25;
            this.b_Delete.Text = "Apagar";
            // 
            // p_Manager
            // 
            this.p_Manager.Controls.Add(this.cb_Department);
            this.p_Manager.Controls.Add(this.l_Department);
            this.p_Manager.Controls.Add(this.l_ManegerUsername);
            this.p_Manager.Controls.Add(this.ts_ManegerUsername);
            this.p_Manager.Location = new System.Drawing.Point(80, 366);
            this.p_Manager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_Manager.Name = "p_Manager";
            this.p_Manager.Size = new System.Drawing.Size(485, 186);
            this.p_Manager.TabIndex = 26;
            this.p_Manager.Visible = false;
            // 
            // p_Programmer
            // 
            this.p_Programmer.Controls.Add(this.cb_ExperienceLevel);
            this.p_Programmer.Controls.Add(this.l_ExperienceLevel);
            this.p_Programmer.Controls.Add(this.l_Manager);
            this.p_Programmer.Controls.Add(this.cb_Maneger);
            this.p_Programmer.Location = new System.Drawing.Point(80, 366);
            this.p_Programmer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_Programmer.Name = "p_Programmer";
            this.p_Programmer.Size = new System.Drawing.Size(485, 186);
            this.p_Programmer.TabIndex = 26;
            this.p_Programmer.Visible = false;
            // 
            // lb_Programmer
            // 
            this.lb_Programmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Programmer.FormattingEnabled = true;
            this.lb_Programmer.ItemHeight = 25;
            this.lb_Programmer.Location = new System.Drawing.Point(711, 87);
            this.lb_Programmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Programmer.Name = "lb_Programmer";
            this.lb_Programmer.Size = new System.Drawing.Size(484, 429);
            this.lb_Programmer.TabIndex = 21;
            this.lb_Programmer.Visible = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "ID";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Enabled = false;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(80, 87);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(107, 44);
            this.guna2TextBox1.TabIndex = 22;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.p_Programmer);
            this.Controls.Add(this.p_Manager);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Edit);
            this.Controls.Add(this.b_Consult);
            this.Controls.Add(this.b_Create);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Programmer);
            this.Controls.Add(this.lb_Manager);
            this.Controls.Add(this.cb_Manager);
            this.Controls.Add(this.cb_Programmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserManagementForm";
            this.Text = "usermanagementForm1";
            this.p_Manager.ResumeLayout(false);
            this.p_Manager.PerformLayout();
            this.p_Programmer.ResumeLayout(false);
            this.p_Programmer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_Programmer;
        private System.Windows.Forms.CheckBox cb_Manager;
        private System.Windows.Forms.Label l_ExperienceLevel;
        private System.Windows.Forms.Label l_Manager;
        private System.Windows.Forms.Label l_Department;
        private System.Windows.Forms.ListBox lb_Manager;
        private Guna.UI2.WinForms.Guna2TextBox tb_Name;
        private Guna.UI2.WinForms.Guna2TextBox tb_Username;
        private Guna.UI2.WinForms.Guna2TextBox tb_Password;
        private Guna.UI2.WinForms.Guna2ComboBox cb_ExperienceLevel;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Maneger;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Department;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ts_ManegerUsername;
        private System.Windows.Forms.Label l_ManegerUsername;
        private Guna.UI2.WinForms.Guna2Button b_Create;
        private Guna.UI2.WinForms.Guna2Button b_Consult;
        private Guna.UI2.WinForms.Guna2Button b_Edit;
        private Guna.UI2.WinForms.Guna2Button b_Delete;
        private System.Windows.Forms.Panel p_Manager;
        private System.Windows.Forms.Panel p_Programmer;
        private System.Windows.Forms.ListBox lb_Programmer;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}