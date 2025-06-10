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
            this.tb_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.b_Create = new Guna.UI2.WinForms.Guna2Button();
            this.b_read = new Guna.UI2.WinForms.Guna2Button();
            this.b_Update = new Guna.UI2.WinForms.Guna2Button();
            this.b_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lb_TaskTipe
            // 
            this.lb_TaskTipe.FormattingEnabled = true;
            this.lb_TaskTipe.ItemHeight = 16;
            this.lb_TaskTipe.Location = new System.Drawing.Point(105, 66);
            this.lb_TaskTipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_TaskTipe.Name = "lb_TaskTipe";
            this.lb_TaskTipe.Size = new System.Drawing.Size(540, 580);
            this.lb_TaskTipe.TabIndex = 0;
            this.lb_TaskTipe.SelectedIndexChanged += new System.EventHandler(this.lb_TaskTipe_SelectedIndexChanged);
            // 
            // l_TaskType
            // 
            this.l_TaskType.AutoSize = true;
            this.l_TaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TaskType.ForeColor = System.Drawing.Color.White;
            this.l_TaskType.Location = new System.Drawing.Point(101, 43);
            this.l_TaskType.Name = "l_TaskType";
            this.l_TaskType.Size = new System.Drawing.Size(111, 18);
            this.l_TaskType.TabIndex = 1;
            this.l_TaskType.Text = "Tipo de Tarefas";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.Color.White;
            this.l_id.Location = new System.Drawing.Point(1148, 66);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(22, 18);
            this.l_id.TabIndex = 3;
            this.l_id.Text = "ID";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Description.ForeColor = System.Drawing.Color.White;
            this.l_Description.Location = new System.Drawing.Point(1091, 154);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(49, 18);
            this.l_Description.TabIndex = 4;
            this.l_Description.Text = "Nome";
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
            this.tb_Id.Location = new System.Drawing.Point(1004, 92);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.PlaceholderText = "";
            this.tb_Id.SelectedText = "";
            this.tb_Id.Size = new System.Drawing.Size(169, 44);
            this.tb_Id.TabIndex = 10;
            this.tb_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Name
            // 
            this.tb_Name.AutoRoundedCorners = true;
            this.tb_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Name.DefaultText = "";
            this.tb_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Name.Location = new System.Drawing.Point(709, 180);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.PlaceholderText = "";
            this.tb_Name.SelectedText = "";
            this.tb_Name.Size = new System.Drawing.Size(464, 44);
            this.tb_Name.TabIndex = 10;
            this.tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Name.TextOffset = new System.Drawing.Point(10, 0);
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
            this.b_Create.Location = new System.Drawing.Point(709, 298);
            this.b_Create.Margin = new System.Windows.Forms.Padding(4);
            this.b_Create.Name = "b_Create";
            this.b_Create.Size = new System.Drawing.Size(219, 44);
            this.b_Create.TabIndex = 11;
            this.b_Create.Text = "GRAVAR";
            this.b_Create.Click += new System.EventHandler(this.b_Create_Click);
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
            this.b_read.Location = new System.Drawing.Point(955, 298);
            this.b_read.Margin = new System.Windows.Forms.Padding(4);
            this.b_read.Name = "b_read";
            this.b_read.Size = new System.Drawing.Size(219, 44);
            this.b_read.TabIndex = 11;
            this.b_read.Text = "CONSULTAR";
            this.b_read.Click += new System.EventHandler(this.b_read_Click);
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
            this.b_Update.Location = new System.Drawing.Point(709, 386);
            this.b_Update.Margin = new System.Windows.Forms.Padding(4);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(219, 44);
            this.b_Update.TabIndex = 11;
            this.b_Update.Text = "EDITAR";
            this.b_Update.Click += new System.EventHandler(this.b_Update_Click);
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
            this.b_Delete.Location = new System.Drawing.Point(955, 386);
            this.b_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(219, 44);
            this.b_Delete.TabIndex = 11;
            this.b_Delete.Text = "APAGAR";
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
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
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.l_Description);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.l_TaskType);
            this.Controls.Add(this.lb_TaskTipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Guna.UI2.WinForms.Guna2TextBox tb_Name;
        private Guna.UI2.WinForms.Guna2Button b_Create;
        private Guna.UI2.WinForms.Guna2Button b_read;
        private Guna.UI2.WinForms.Guna2Button b_Update;
        private Guna.UI2.WinForms.Guna2Button b_Delete;
    }
}