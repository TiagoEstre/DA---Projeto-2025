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
            this.l_id = new System.Windows.Forms.Label();
            this.l_Description = new System.Windows.Forms.Label();
            this.tb_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.b_Create = new Guna.UI2.WinForms.Guna2Button();
            this.b_read = new Guna.UI2.WinForms.Guna2Button();
            this.b_Update = new Guna.UI2.WinForms.Guna2Button();
            this.b_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lb_TaskTipe
            // 
            this.lb_TaskTipe.FormattingEnabled = true;
            this.lb_TaskTipe.Location = new System.Drawing.Point(79, 54);
            this.lb_TaskTipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_TaskTipe.Name = "lb_TaskTipe";
            this.lb_TaskTipe.Size = new System.Drawing.Size(406, 472);
            this.lb_TaskTipe.TabIndex = 0;
            // 
            // l_TaskType
            // 
            this.l_TaskType.AutoSize = true;
            this.l_TaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TaskType.ForeColor = System.Drawing.Color.White;
            this.l_TaskType.Location = new System.Drawing.Point(76, 35);
            this.l_TaskType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_TaskType.Name = "l_TaskType";
            this.l_TaskType.Size = new System.Drawing.Size(92, 15);
            this.l_TaskType.TabIndex = 1;
            this.l_TaskType.Text = "Tipo de Tarefas";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.Color.White;
            this.l_id.Location = new System.Drawing.Point(861, 54);
            this.l_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(19, 15);
            this.l_id.TabIndex = 3;
            this.l_id.Text = "ID";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Description.ForeColor = System.Drawing.Color.White;
            this.l_Description.Location = new System.Drawing.Point(818, 125);
            this.l_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(62, 15);
            this.l_Description.TabIndex = 4;
            this.l_Description.Text = "Descrição";
            // 
            // tb_Id
            // 
            this.tb_Id.AutoRoundedCorners = true;
            this.tb_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Id.DefaultText = "";
            this.tb_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Id.Location = new System.Drawing.Point(753, 75);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.PlaceholderText = "";
            this.tb_Id.SelectedText = "";
            this.tb_Id.Size = new System.Drawing.Size(127, 36);
            this.tb_Id.TabIndex = 10;
            // 
            // tb_Description
            // 
            this.tb_Description.AutoRoundedCorners = true;
            this.tb_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Description.DefaultText = "";
            this.tb_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Description.Location = new System.Drawing.Point(532, 146);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.PlaceholderText = "";
            this.tb_Description.SelectedText = "";
            this.tb_Description.Size = new System.Drawing.Size(348, 36);
            this.tb_Description.TabIndex = 10;
            // 
            // b_Create
            // 
            this.b_Create.AutoRoundedCorners = true;
            this.b_Create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Create.FillColor = System.Drawing.Color.LightGray;
            this.b_Create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Create.ForeColor = System.Drawing.Color.Black;
            this.b_Create.Location = new System.Drawing.Point(532, 242);
            this.b_Create.Name = "b_Create";
            this.b_Create.Size = new System.Drawing.Size(164, 36);
            this.b_Create.TabIndex = 11;
            this.b_Create.Text = "GRAVAR";
            // 
            // b_read
            // 
            this.b_read.AutoRoundedCorners = true;
            this.b_read.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_read.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_read.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_read.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_read.FillColor = System.Drawing.Color.LightGray;
            this.b_read.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_read.ForeColor = System.Drawing.Color.Black;
            this.b_read.Location = new System.Drawing.Point(716, 242);
            this.b_read.Name = "b_read";
            this.b_read.Size = new System.Drawing.Size(164, 36);
            this.b_read.TabIndex = 11;
            this.b_read.Text = "CONSULTAR";
            // 
            // b_Update
            // 
            this.b_Update.AutoRoundedCorners = true;
            this.b_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Update.FillColor = System.Drawing.Color.LightGray;
            this.b_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Update.ForeColor = System.Drawing.Color.Black;
            this.b_Update.Location = new System.Drawing.Point(532, 314);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(164, 36);
            this.b_Update.TabIndex = 11;
            this.b_Update.Text = "EDITAR";
            // 
            // b_Delete
            // 
            this.b_Delete.AutoRoundedCorners = true;
            this.b_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Delete.FillColor = System.Drawing.Color.LightGray;
            this.b_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Delete.ForeColor = System.Drawing.Color.Black;
            this.b_Delete.Location = new System.Drawing.Point(716, 314);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(164, 36);
            this.b_Delete.TabIndex = 11;
            this.b_Delete.Text = "APAGAR";
            // 
            // TaskTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Update);
            this.Controls.Add(this.b_read);
            this.Controls.Add(this.b_Create);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.l_Description);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.l_TaskType);
            this.Controls.Add(this.lb_TaskTipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskTypeForm";
            this.Text = "tasktypeForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_TaskTipe;
        private System.Windows.Forms.Label l_TaskType;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_Description;
        private Guna.UI2.WinForms.Guna2TextBox tb_Id;
        private Guna.UI2.WinForms.Guna2TextBox tb_Description;
        private Guna.UI2.WinForms.Guna2Button b_Create;
        private Guna.UI2.WinForms.Guna2Button b_read;
        private Guna.UI2.WinForms.Guna2Button b_Update;
        private Guna.UI2.WinForms.Guna2Button b_Delete;
    }
}