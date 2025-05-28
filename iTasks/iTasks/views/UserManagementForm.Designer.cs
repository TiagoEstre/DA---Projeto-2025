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
            this.l_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.l_Username = new System.Windows.Forms.Label();
            this.l_Password = new System.Windows.Forms.Label();
            this.cb_Programmer = new System.Windows.Forms.CheckBox();
            this.cb_Manager = new System.Windows.Forms.CheckBox();
            this.cb_ExperienceLevel = new System.Windows.Forms.ComboBox();
            this.l_ExperienceLevel = new System.Windows.Forms.Label();
            this.l_Manager = new System.Windows.Forms.Label();
            this.cb_Maneger = new System.Windows.Forms.ComboBox();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.l_ = new System.Windows.Forms.Label();
            this.cb_ManageUsers = new System.Windows.Forms.CheckBox();
            this.lb_Programmer = new System.Windows.Forms.ListBox();
            this.b_Create = new System.Windows.Forms.Button();
            this.b_Edit = new System.Windows.Forms.Button();
            this.b_Consult = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.lb_Manager = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Name.Location = new System.Drawing.Point(87, 97);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(44, 16);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Nome";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(163, 86);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(284, 22);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(163, 152);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(283, 22);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(163, 215);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(282, 22);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // l_Username
            // 
            this.l_Username.AutoSize = true;
            this.l_Username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Username.Location = new System.Drawing.Point(76, 152);
            this.l_Username.Name = "l_Username";
            this.l_Username.Size = new System.Drawing.Size(70, 16);
            this.l_Username.TabIndex = 4;
            this.l_Username.Text = "Username";
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Password.Location = new System.Drawing.Point(79, 218);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(67, 16);
            this.l_Password.TabIndex = 5;
            this.l_Password.Text = "Password";
            // 
            // cb_Programmer
            // 
            this.cb_Programmer.AutoSize = true;
            this.cb_Programmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_Programmer.Location = new System.Drawing.Point(193, 340);
            this.cb_Programmer.Name = "cb_Programmer";
            this.cb_Programmer.Size = new System.Drawing.Size(109, 20);
            this.cb_Programmer.TabIndex = 6;
            this.cb_Programmer.Text = "Programador";
            this.cb_Programmer.UseVisualStyleBackColor = true;
            // 
            // cb_Manager
            // 
            this.cb_Manager.AutoSize = true;
            this.cb_Manager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_Manager.Location = new System.Drawing.Point(347, 340);
            this.cb_Manager.Name = "cb_Manager";
            this.cb_Manager.Size = new System.Drawing.Size(69, 20);
            this.cb_Manager.TabIndex = 7;
            this.cb_Manager.Text = "Gestor";
            this.cb_Manager.UseVisualStyleBackColor = true;
            // 
            // cb_ExperienceLevel
            // 
            this.cb_ExperienceLevel.FormattingEnabled = true;
            this.cb_ExperienceLevel.Location = new System.Drawing.Point(193, 415);
            this.cb_ExperienceLevel.Name = "cb_ExperienceLevel";
            this.cb_ExperienceLevel.Size = new System.Drawing.Size(139, 24);
            this.cb_ExperienceLevel.TabIndex = 8;
            // 
            // l_ExperienceLevel
            // 
            this.l_ExperienceLevel.AutoSize = true;
            this.l_ExperienceLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_ExperienceLevel.Location = new System.Drawing.Point(56, 422);
            this.l_ExperienceLevel.Name = "l_ExperienceLevel";
            this.l_ExperienceLevel.Size = new System.Drawing.Size(131, 16);
            this.l_ExperienceLevel.TabIndex = 9;
            this.l_ExperienceLevel.Text = "Nível de Experiencia";
            // 
            // l_Manager
            // 
            this.l_Manager.AutoSize = true;
            this.l_Manager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Manager.Location = new System.Drawing.Point(66, 477);
            this.l_Manager.Name = "l_Manager";
            this.l_Manager.Size = new System.Drawing.Size(47, 16);
            this.l_Manager.TabIndex = 10;
            this.l_Manager.Text = "Gestor";
            // 
            // cb_Maneger
            // 
            this.cb_Maneger.FormattingEnabled = true;
            this.cb_Maneger.Location = new System.Drawing.Point(193, 467);
            this.cb_Maneger.Name = "cb_Maneger";
            this.cb_Maneger.Size = new System.Drawing.Size(138, 24);
            this.cb_Maneger.TabIndex = 11;
            // 
            // cb_Department
            // 
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(490, 410);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(142, 24);
            this.cb_Department.TabIndex = 12;
            // 
            // l_
            // 
            this.l_.AutoSize = true;
            this.l_.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_.Location = new System.Drawing.Point(377, 418);
            this.l_.Name = "l_";
            this.l_.Size = new System.Drawing.Size(93, 16);
            this.l_.TabIndex = 13;
            this.l_.Text = "Departamento";
            // 
            // cb_ManageUsers
            // 
            this.cb_ManageUsers.AutoSize = true;
            this.cb_ManageUsers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_ManageUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_ManageUsers.Location = new System.Drawing.Point(380, 467);
            this.cb_ManageUsers.Name = "cb_ManageUsers";
            this.cb_ManageUsers.Size = new System.Drawing.Size(133, 20);
            this.cb_ManageUsers.TabIndex = 15;
            this.cb_ManageUsers.Text = "Gere Utilizadores";
            this.cb_ManageUsers.UseVisualStyleBackColor = true;
            // 
            // lb_Programmer
            // 
            this.lb_Programmer.FormattingEnabled = true;
            this.lb_Programmer.ItemHeight = 16;
            this.lb_Programmer.Location = new System.Drawing.Point(755, 86);
            this.lb_Programmer.Name = "lb_Programmer";
            this.lb_Programmer.Size = new System.Drawing.Size(199, 292);
            this.lb_Programmer.TabIndex = 16;
            // 
            // b_Create
            // 
            this.b_Create.Location = new System.Drawing.Point(796, 444);
            this.b_Create.Name = "b_Create";
            this.b_Create.Size = new System.Drawing.Size(109, 43);
            this.b_Create.TabIndex = 17;
            this.b_Create.Text = "Criar";
            this.b_Create.UseVisualStyleBackColor = true;
            // 
            // b_Edit
            // 
            this.b_Edit.Location = new System.Drawing.Point(1020, 444);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(115, 43);
            this.b_Edit.TabIndex = 18;
            this.b_Edit.Text = "Editar";
            this.b_Edit.UseVisualStyleBackColor = true;
            // 
            // b_Consult
            // 
            this.b_Consult.Location = new System.Drawing.Point(795, 519);
            this.b_Consult.Name = "b_Consult";
            this.b_Consult.Size = new System.Drawing.Size(110, 36);
            this.b_Consult.TabIndex = 19;
            this.b_Consult.Text = "Consultar";
            this.b_Consult.UseVisualStyleBackColor = true;
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(1020, 516);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(115, 39);
            this.b_Delete.TabIndex = 20;
            this.b_Delete.Text = "Apagar";
            this.b_Delete.UseVisualStyleBackColor = true;
            // 
            // lb_Manager
            // 
            this.lb_Manager.FormattingEnabled = true;
            this.lb_Manager.ItemHeight = 16;
            this.lb_Manager.Location = new System.Drawing.Point(1037, 86);
            this.lb_Manager.Name = "lb_Manager";
            this.lb_Manager.Size = new System.Drawing.Size(197, 292);
            this.lb_Manager.TabIndex = 21;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.lb_Manager);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Consult);
            this.Controls.Add(this.b_Edit);
            this.Controls.Add(this.b_Create);
            this.Controls.Add(this.lb_Programmer);
            this.Controls.Add(this.cb_ManageUsers);
            this.Controls.Add(this.l_);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.cb_Maneger);
            this.Controls.Add(this.l_Manager);
            this.Controls.Add(this.l_ExperienceLevel);
            this.Controls.Add(this.cb_ExperienceLevel);
            this.Controls.Add(this.cb_Manager);
            this.Controls.Add(this.cb_Programmer);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.l_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagementForm";
            this.Text = "usermanagementForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label l_Username;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.CheckBox cb_Programmer;
        private System.Windows.Forms.CheckBox cb_Manager;
        private System.Windows.Forms.ComboBox cb_ExperienceLevel;
        private System.Windows.Forms.Label l_ExperienceLevel;
        private System.Windows.Forms.Label l_Manager;
        private System.Windows.Forms.ComboBox cb_Maneger;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.Label l_;
        private System.Windows.Forms.CheckBox cb_ManageUsers;
        private System.Windows.Forms.ListBox lb_Programmer;
        private System.Windows.Forms.Button b_Create;
        private System.Windows.Forms.Button b_Edit;
        private System.Windows.Forms.Button b_Consult;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.ListBox lb_Manager;
    }
}