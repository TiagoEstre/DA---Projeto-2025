namespace iTasks.views
{
    partial class TaskTypeForm
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
            this.lb_TaskTipe = new System.Windows.Forms.ListBox();
            this.l_TaskType = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.l_Description = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.b_Create = new System.Windows.Forms.Button();
            this.b_read = new System.Windows.Forms.Button();
            this.b_Update = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_TaskTipe
            // 
            this.lb_TaskTipe.FormattingEnabled = true;
            this.lb_TaskTipe.ItemHeight = 16;
            this.lb_TaskTipe.Location = new System.Drawing.Point(105, 83);
            this.lb_TaskTipe.Name = "lb_TaskTipe";
            this.lb_TaskTipe.Size = new System.Drawing.Size(384, 500);
            this.lb_TaskTipe.TabIndex = 0;
            // 
            // l_TaskType
            // 
            this.l_TaskType.AutoSize = true;
            this.l_TaskType.Location = new System.Drawing.Point(114, 59);
            this.l_TaskType.Name = "l_TaskType";
            this.l_TaskType.Size = new System.Drawing.Size(104, 16);
            this.l_TaskType.TabIndex = 1;
            this.l_TaskType.Text = "Tipo de Tarefas";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(642, 59);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 22);
            this.tb_Id.TabIndex = 2;
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(559, 65);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(20, 16);
            this.l_id.TabIndex = 3;
            this.l_id.Text = "ID";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Location = new System.Drawing.Point(559, 127);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(69, 16);
            this.l_Description.TabIndex = 4;
            this.l_Description.Text = "Descrição";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(642, 127);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(311, 22);
            this.tb_Description.TabIndex = 5;
            // 
            // b_Create
            // 
            this.b_Create.Location = new System.Drawing.Point(853, 211);
            this.b_Create.Name = "b_Create";
            this.b_Create.Size = new System.Drawing.Size(144, 30);
            this.b_Create.TabIndex = 6;
            this.b_Create.Text = "Gravar";
            this.b_Create.UseVisualStyleBackColor = true;
            // 
            // b_read
            // 
            this.b_read.Location = new System.Drawing.Point(853, 278);
            this.b_read.Name = "b_read";
            this.b_read.Size = new System.Drawing.Size(144, 29);
            this.b_read.TabIndex = 7;
            this.b_read.Text = "Consultar";
            this.b_read.UseVisualStyleBackColor = true;
            // 
            // b_Update
            // 
            this.b_Update.Location = new System.Drawing.Point(853, 347);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(144, 26);
            this.b_Update.TabIndex = 8;
            this.b_Update.Text = "Editar";
            this.b_Update.UseVisualStyleBackColor = true;
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(853, 412);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(144, 33);
            this.b_Delete.TabIndex = 9;
            this.b_Delete.Text = "Apagar";
            this.b_Delete.UseVisualStyleBackColor = true;
            // 
            // TaskTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Update);
            this.Controls.Add(this.b_read);
            this.Controls.Add(this.b_Create);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.l_Description);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.l_TaskType);
            this.Controls.Add(this.lb_TaskTipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaskTypeForm";
            this.Text = "tasktypeForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_TaskTipe;
        private System.Windows.Forms.Label l_TaskType;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Button b_Create;
        private System.Windows.Forms.Button b_read;
        private System.Windows.Forms.Button b_Update;
        private System.Windows.Forms.Button b_Delete;
    }
}