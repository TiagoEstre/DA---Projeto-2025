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
<<<<<<< HEAD:iTasks/iTasks/views/usermanagementForm1.Designer.cs
            this.l_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.l_Username = new System.Windows.Forms.Label();
            this.l_Password = new System.Windows.Forms.Label();
            this.cb_Manager = new System.Windows.Forms.CheckBox();
            this.cb_Programmater = new System.Windows.Forms.CheckBox();
            this.l_Departamento = new System.Windows.Forms.Label();
            this.tb_Departament = new System.Windows.Forms.TextBox();
            this.l_ExperienceLevel = new System.Windows.Forms.Label();
            this.tb_NivelExperiencia = new System.Windows.Forms.TextBox();
            this.b_Create = new System.Windows.Forms.Button();
            this.b_read = new System.Windows.Forms.Button();
            this.b_Update = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.lb_Users = new System.Windows.Forms.ListBox();
            this.cb_ManagerList = new System.Windows.Forms.ComboBox();
            this.l_ManagerList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(56, 91);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(44, 16);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Nome";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(126, 91);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(328, 22);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(134, 151);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(319, 22);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(138, 217);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(314, 22);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // l_Username
            // 
            this.l_Username.AutoSize = true;
            this.l_Username.Location = new System.Drawing.Point(56, 157);
            this.l_Username.Name = "l_Username";
            this.l_Username.Size = new System.Drawing.Size(70, 16);
            this.l_Username.TabIndex = 4;
            this.l_Username.Text = "Username";
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Location = new System.Drawing.Point(56, 217);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(67, 16);
            this.l_Password.TabIndex = 5;
            this.l_Password.Text = "Password";
            // 
            // cb_Manager
            // 
            this.cb_Manager.AutoSize = true;
            this.cb_Manager.Location = new System.Drawing.Point(78, 286);
            this.cb_Manager.Name = "cb_Manager";
            this.cb_Manager.Size = new System.Drawing.Size(69, 20);
            this.cb_Manager.TabIndex = 6;
            this.cb_Manager.Text = "Gestor";
            this.cb_Manager.UseVisualStyleBackColor = true;
            // 
            // cb_Programmater
            // 
            this.cb_Programmater.AutoSize = true;
            this.cb_Programmater.Location = new System.Drawing.Point(261, 286);
            this.cb_Programmater.Name = "cb_Programmater";
            this.cb_Programmater.Size = new System.Drawing.Size(109, 20);
            this.cb_Programmater.TabIndex = 7;
            this.cb_Programmater.Text = "Programador";
            this.cb_Programmater.UseVisualStyleBackColor = true;
            // 
            // l_Departamento
            // 
            this.l_Departamento.AutoSize = true;
            this.l_Departamento.Location = new System.Drawing.Point(58, 332);
            this.l_Departamento.Name = "l_Departamento";
            this.l_Departamento.Size = new System.Drawing.Size(93, 16);
            this.l_Departamento.TabIndex = 8;
            this.l_Departamento.Text = "Departamento";
            // 
            // tb_Departament
            // 
            this.tb_Departament.Location = new System.Drawing.Point(179, 333);
            this.tb_Departament.Name = "tb_Departament";
            this.tb_Departament.Size = new System.Drawing.Size(150, 22);
            this.tb_Departament.TabIndex = 9;
            // 
            // l_ExperienceLevel
            // 
            this.l_ExperienceLevel.AutoSize = true;
            this.l_ExperienceLevel.Location = new System.Drawing.Point(58, 373);
            this.l_ExperienceLevel.Name = "l_ExperienceLevel";
            this.l_ExperienceLevel.Size = new System.Drawing.Size(131, 16);
            this.l_ExperienceLevel.TabIndex = 10;
            this.l_ExperienceLevel.Text = "Nível de Experiência";
            // 
            // tb_NivelExperiencia
            // 
            this.tb_NivelExperiencia.Location = new System.Drawing.Point(221, 370);
            this.tb_NivelExperiencia.Name = "tb_NivelExperiencia";
            this.tb_NivelExperiencia.Size = new System.Drawing.Size(164, 22);
            this.tb_NivelExperiencia.TabIndex = 11;
            // 
            // b_Create
            // 
            this.b_Create.Location = new System.Drawing.Point(506, 291);
            this.b_Create.Name = "b_Create";
            this.b_Create.Size = new System.Drawing.Size(97, 42);
            this.b_Create.TabIndex = 12;
            this.b_Create.Text = "Criar";
            this.b_Create.UseVisualStyleBackColor = true;
            // 
            // b_read
            // 
            this.b_read.Location = new System.Drawing.Point(670, 288);
            this.b_read.Name = "b_read";
            this.b_read.Size = new System.Drawing.Size(101, 45);
            this.b_read.TabIndex = 13;
            this.b_read.Text = "Consultar";
            this.b_read.UseVisualStyleBackColor = true;
            // 
            // b_Update
            // 
            this.b_Update.Location = new System.Drawing.Point(506, 370);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(86, 43);
            this.b_Update.TabIndex = 14;
            this.b_Update.Text = "Consultar";
            this.b_Update.UseVisualStyleBackColor = true;
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(678, 363);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(92, 49);
            this.b_Delete.TabIndex = 15;
            this.b_Delete.Text = "Apagar";
            this.b_Delete.UseVisualStyleBackColor = true;
            // 
            // lb_Users
            // 
            this.lb_Users.FormattingEnabled = true;
            this.lb_Users.ItemHeight = 16;
            this.lb_Users.Location = new System.Drawing.Point(514, 59);
            this.lb_Users.Name = "lb_Users";
            this.lb_Users.Size = new System.Drawing.Size(255, 196);
            this.lb_Users.TabIndex = 16;
            // 
            // cb_ManagerList
            // 
            this.cb_ManagerList.FormattingEnabled = true;
            this.cb_ManagerList.Location = new System.Drawing.Point(236, 414);
            this.cb_ManagerList.Name = "cb_ManagerList";
            this.cb_ManagerList.Size = new System.Drawing.Size(205, 24);
            this.cb_ManagerList.TabIndex = 17;
            this.cb_ManagerList.Text = "Lista de Gestores";
            // 
            // l_ManagerList
            // 
            this.l_ManagerList.AutoSize = true;
            this.l_ManagerList.Location = new System.Drawing.Point(65, 415);
            this.l_ManagerList.Name = "l_ManagerList";
            this.l_ManagerList.Size = new System.Drawing.Size(112, 16);
            this.l_ManagerList.TabIndex = 18;
            this.l_ManagerList.Text = "Lista de Gestores";
            // 
            // usermanagementForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_ManagerList);
            this.Controls.Add(this.cb_ManagerList);
            this.Controls.Add(this.lb_Users);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Update);
            this.Controls.Add(this.b_read);
            this.Controls.Add(this.b_Create);
            this.Controls.Add(this.tb_NivelExperiencia);
            this.Controls.Add(this.l_ExperienceLevel);
            this.Controls.Add(this.tb_Departament);
            this.Controls.Add(this.l_Departamento);
            this.Controls.Add(this.cb_Programmater);
            this.Controls.Add(this.cb_Manager);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.l_Name);
            this.Name = "usermanagementForm1";
            this.Text = "usermanagementForm1";
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            this.SuspendLayout();
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagementForm";
            this.Text = "usermanagementForm1";
            this.ResumeLayout(false);
>>>>>>> 39ac34ea3a69def3c34c7bcc433c1be8ae68bcf1:iTasks/iTasks/views/UserManagementForm.Designer.cs

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label l_Username;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.CheckBox cb_Manager;
        private System.Windows.Forms.CheckBox cb_Programmater;
        private System.Windows.Forms.Label l_Departamento;
        private System.Windows.Forms.TextBox tb_Departament;
        private System.Windows.Forms.Label l_ExperienceLevel;
        private System.Windows.Forms.TextBox tb_NivelExperiencia;
        private System.Windows.Forms.Button b_Create;
        private System.Windows.Forms.Button b_read;
        private System.Windows.Forms.Button b_Update;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.ListBox lb_Users;
        private System.Windows.Forms.ComboBox cb_ManagerList;
        private System.Windows.Forms.Label l_ManagerList;
    }
}