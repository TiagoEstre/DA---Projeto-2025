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
            this.l_Id = new System.Windows.Forms.Label();
            this.l_SartDate = new System.Windows.Forms.Label();
            this.l_EndDate = new System.Windows.Forms.Label();
            this.l_CurrentStatus = new System.Windows.Forms.Label();
            this.l_CriationDate = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_StartDate = new System.Windows.Forms.TextBox();
            this.tb_endDate = new System.Windows.Forms.TextBox();
            this.tb_CurrentStatus = new System.Windows.Forms.TextBox();
            this.tb_CreationDate = new System.Windows.Forms.TextBox();
            this.l_Description = new System.Windows.Forms.Label();
            this.l_TaskTipe = new System.Windows.Forms.Label();
            this.l_Programmer = new System.Windows.Forms.Label();
            this.l_Order = new System.Windows.Forms.Label();
            this.l_StoryPoints = new System.Windows.Forms.Label();
            this.l_StartDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.cb_TaskTipe = new System.Windows.Forms.ComboBox();
            this.cb_Programmer = new System.Windows.Forms.ComboBox();
            this.tb_Order = new System.Windows.Forms.TextBox();
            this.tb_StoryPoints = new System.Windows.Forms.TextBox();
            this.dtp_SartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.b_creat = new System.Windows.Forms.Button();
            this.b_Read = new System.Windows.Forms.Button();
            this.b_Update = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Id
            // 
            this.l_Id.AutoSize = true;
            this.l_Id.Location = new System.Drawing.Point(129, 47);
            this.l_Id.Name = "l_Id";
            this.l_Id.Size = new System.Drawing.Size(18, 16);
            this.l_Id.TabIndex = 0;
            this.l_Id.Text = "Id";
            // 
            // l_SartDate
            // 
            this.l_SartDate.AutoSize = true;
            this.l_SartDate.Location = new System.Drawing.Point(132, 114);
            this.l_SartDate.Name = "l_SartDate";
            this.l_SartDate.Size = new System.Drawing.Size(121, 16);
            this.l_SartDate.TabIndex = 1;
            this.l_SartDate.Text = "Data Real de Início";
            // 
            // l_EndDate
            // 
            this.l_EndDate.AutoSize = true;
            this.l_EndDate.Location = new System.Drawing.Point(135, 164);
            this.l_EndDate.Name = "l_EndDate";
            this.l_EndDate.Size = new System.Drawing.Size(112, 16);
            this.l_EndDate.TabIndex = 2;
            this.l_EndDate.Text = "Data Real de Fim";
            // 
            // l_CurrentStatus
            // 
            this.l_CurrentStatus.AutoSize = true;
            this.l_CurrentStatus.Location = new System.Drawing.Point(813, 47);
            this.l_CurrentStatus.Name = "l_CurrentStatus";
            this.l_CurrentStatus.Size = new System.Drawing.Size(83, 16);
            this.l_CurrentStatus.TabIndex = 3;
            this.l_CurrentStatus.Text = "Estado Atual";
            // 
            // l_CriationDate
            // 
            this.l_CriationDate.AutoSize = true;
            this.l_CriationDate.Location = new System.Drawing.Point(816, 114);
            this.l_CriationDate.Name = "l_CriationDate";
            this.l_CriationDate.Size = new System.Drawing.Size(105, 16);
            this.l_CriationDate.TabIndex = 4;
            this.l_CriationDate.Text = "Data da Criação";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(189, 47);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 22);
            this.tb_Id.TabIndex = 5;
            // 
            // tb_StartDate
            // 
            this.tb_StartDate.Location = new System.Drawing.Point(274, 114);
            this.tb_StartDate.Name = "tb_StartDate";
            this.tb_StartDate.Size = new System.Drawing.Size(100, 22);
            this.tb_StartDate.TabIndex = 6;
            // 
            // tb_endDate
            // 
            this.tb_endDate.Location = new System.Drawing.Point(274, 158);
            this.tb_endDate.Name = "tb_endDate";
            this.tb_endDate.Size = new System.Drawing.Size(100, 22);
            this.tb_endDate.TabIndex = 7;
            // 
            // tb_CurrentStatus
            // 
            this.tb_CurrentStatus.Location = new System.Drawing.Point(926, 41);
            this.tb_CurrentStatus.Name = "tb_CurrentStatus";
            this.tb_CurrentStatus.Size = new System.Drawing.Size(100, 22);
            this.tb_CurrentStatus.TabIndex = 8;
            // 
            // tb_CreationDate
            // 
            this.tb_CreationDate.Location = new System.Drawing.Point(939, 108);
            this.tb_CreationDate.Name = "tb_CreationDate";
            this.tb_CreationDate.Size = new System.Drawing.Size(100, 22);
            this.tb_CreationDate.TabIndex = 9;
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Location = new System.Drawing.Point(112, 267);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(69, 16);
            this.l_Description.TabIndex = 10;
            this.l_Description.Text = "Descrição";
            // 
            // l_TaskTipe
            // 
            this.l_TaskTipe.AutoSize = true;
            this.l_TaskTipe.Location = new System.Drawing.Point(112, 308);
            this.l_TaskTipe.Name = "l_TaskTipe";
            this.l_TaskTipe.Size = new System.Drawing.Size(97, 16);
            this.l_TaskTipe.TabIndex = 11;
            this.l_TaskTipe.Text = "Tipo de Tarefa";
            // 
            // l_Programmer
            // 
            this.l_Programmer.AutoSize = true;
            this.l_Programmer.Location = new System.Drawing.Point(111, 358);
            this.l_Programmer.Name = "l_Programmer";
            this.l_Programmer.Size = new System.Drawing.Size(87, 16);
            this.l_Programmer.TabIndex = 12;
            this.l_Programmer.Text = "Programador";
            // 
            // l_Order
            // 
            this.l_Order.AutoSize = true;
            this.l_Order.Location = new System.Drawing.Point(113, 404);
            this.l_Order.Name = "l_Order";
            this.l_Order.Size = new System.Drawing.Size(48, 16);
            this.l_Order.TabIndex = 13;
            this.l_Order.Text = "Ordem";
            // 
            // l_StoryPoints
            // 
            this.l_StoryPoints.AutoSize = true;
            this.l_StoryPoints.Location = new System.Drawing.Point(111, 447);
            this.l_StoryPoints.Name = "l_StoryPoints";
            this.l_StoryPoints.Size = new System.Drawing.Size(78, 16);
            this.l_StoryPoints.TabIndex = 14;
            this.l_StoryPoints.Text = "Story Points";
            // 
            // l_StartDate
            // 
            this.l_StartDate.AutoSize = true;
            this.l_StartDate.Location = new System.Drawing.Point(109, 492);
            this.l_StartDate.Name = "l_StartDate";
            this.l_StartDate.Size = new System.Drawing.Size(138, 16);
            this.l_StartDate.TabIndex = 15;
            this.l_StartDate.Text = "Data Prevista de Incio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data Prevista de Fim";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(274, 267);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(222, 22);
            this.tb_Description.TabIndex = 17;
            // 
            // cb_TaskTipe
            // 
            this.cb_TaskTipe.FormattingEnabled = true;
            this.cb_TaskTipe.Location = new System.Drawing.Point(274, 308);
            this.cb_TaskTipe.Name = "cb_TaskTipe";
            this.cb_TaskTipe.Size = new System.Drawing.Size(241, 24);
            this.cb_TaskTipe.TabIndex = 18;
            // 
            // cb_Programmer
            // 
            this.cb_Programmer.FormattingEnabled = true;
            this.cb_Programmer.Location = new System.Drawing.Point(274, 350);
            this.cb_Programmer.Name = "cb_Programmer";
            this.cb_Programmer.Size = new System.Drawing.Size(242, 24);
            this.cb_Programmer.TabIndex = 19;
            // 
            // tb_Order
            // 
            this.tb_Order.Location = new System.Drawing.Point(274, 401);
            this.tb_Order.Name = "tb_Order";
            this.tb_Order.Size = new System.Drawing.Size(262, 22);
            this.tb_Order.TabIndex = 20;
            // 
            // tb_StoryPoints
            // 
            this.tb_StoryPoints.Location = new System.Drawing.Point(274, 447);
            this.tb_StoryPoints.Name = "tb_StoryPoints";
            this.tb_StoryPoints.Size = new System.Drawing.Size(233, 22);
            this.tb_StoryPoints.TabIndex = 21;
            // 
            // dtp_SartDate
            // 
            this.dtp_SartDate.Location = new System.Drawing.Point(276, 492);
            this.dtp_SartDate.Name = "dtp_SartDate";
            this.dtp_SartDate.Size = new System.Drawing.Size(259, 22);
            this.dtp_SartDate.TabIndex = 22;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(275, 531);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(259, 22);
            this.dtp_EndDate.TabIndex = 23;
            // 
            // b_creat
            // 
            this.b_creat.Location = new System.Drawing.Point(768, 288);
            this.b_creat.Name = "b_creat";
            this.b_creat.Size = new System.Drawing.Size(75, 23);
            this.b_creat.TabIndex = 24;
            this.b_creat.Text = "Criar";
            this.b_creat.UseVisualStyleBackColor = true;
            // 
            // b_Read
            // 
            this.b_Read.Location = new System.Drawing.Point(950, 288);
            this.b_Read.Name = "b_Read";
            this.b_Read.Size = new System.Drawing.Size(75, 23);
            this.b_Read.TabIndex = 25;
            this.b_Read.Text = "Consultar";
            this.b_Read.UseVisualStyleBackColor = true;
            // 
            // b_Update
            // 
            this.b_Update.Location = new System.Drawing.Point(768, 396);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(75, 23);
            this.b_Update.TabIndex = 26;
            this.b_Update.Text = "Editar";
            this.b_Update.UseVisualStyleBackColor = true;
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(950, 396);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(75, 23);
            this.b_Delete.TabIndex = 27;
            this.b_Delete.Text = "Apagar";
            this.b_Delete.UseVisualStyleBackColor = true;
            // 
            // TaskDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Update);
            this.Controls.Add(this.b_Read);
            this.Controls.Add(this.b_creat);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_SartDate);
            this.Controls.Add(this.tb_StoryPoints);
            this.Controls.Add(this.tb_Order);
            this.Controls.Add(this.cb_Programmer);
            this.Controls.Add(this.cb_TaskTipe);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l_StartDate);
            this.Controls.Add(this.l_StoryPoints);
            this.Controls.Add(this.l_Order);
            this.Controls.Add(this.l_Programmer);
            this.Controls.Add(this.l_TaskTipe);
            this.Controls.Add(this.l_Description);
            this.Controls.Add(this.tb_CreationDate);
            this.Controls.Add(this.tb_CurrentStatus);
            this.Controls.Add(this.tb_endDate);
            this.Controls.Add(this.tb_StartDate);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.l_CriationDate);
            this.Controls.Add(this.l_CurrentStatus);
            this.Controls.Add(this.l_EndDate);
            this.Controls.Add(this.l_SartDate);
            this.Controls.Add(this.l_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaskDetailForm";
            this.Text = "taskdetailForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Id;
        private System.Windows.Forms.Label l_SartDate;
        private System.Windows.Forms.Label l_EndDate;
        private System.Windows.Forms.Label l_CurrentStatus;
        private System.Windows.Forms.Label l_CriationDate;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_StartDate;
        private System.Windows.Forms.TextBox tb_endDate;
        private System.Windows.Forms.TextBox tb_CurrentStatus;
        private System.Windows.Forms.TextBox tb_CreationDate;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.Label l_TaskTipe;
        private System.Windows.Forms.Label l_Programmer;
        private System.Windows.Forms.Label l_Order;
        private System.Windows.Forms.Label l_StoryPoints;
        private System.Windows.Forms.Label l_StartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.ComboBox cb_TaskTipe;
        private System.Windows.Forms.ComboBox cb_Programmer;
        private System.Windows.Forms.TextBox tb_Order;
        private System.Windows.Forms.TextBox tb_StoryPoints;
        private System.Windows.Forms.DateTimePicker dtp_SartDate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Button b_creat;
        private System.Windows.Forms.Button b_Read;
        private System.Windows.Forms.Button b_Update;
        private System.Windows.Forms.Button b_Delete;
    }
}