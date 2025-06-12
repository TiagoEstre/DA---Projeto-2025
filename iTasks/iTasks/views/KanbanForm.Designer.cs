namespace iTasks.views
{
    partial class KanbanForm
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
            this.lb_ToDo = new System.Windows.Forms.ListBox();
            this.lb_Doing = new System.Windows.Forms.ListBox();
            this.lb_Done = new System.Windows.Forms.ListBox();
            this.gb_ToDo = new System.Windows.Forms.GroupBox();
            this.gb_Doing = new System.Windows.Forms.GroupBox();
            this.gb_Done = new System.Windows.Forms.GroupBox();
            this.b_seeCompletionForecast = new Guna.UI2.WinForms.Guna2Button();
            this.b_NewTask = new Guna.UI2.WinForms.Guna2Button();
            this.b_FinishTask = new Guna.UI2.WinForms.Guna2Button();
            this.b_RestartTask = new Guna.UI2.WinForms.Guna2Button();
            this.b_ExecuteTask = new Guna.UI2.WinForms.Guna2Button();
            this.gb_ToDo.SuspendLayout();
            this.gb_Doing.SuspendLayout();
            this.gb_Done.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ToDo
            // 
            this.lb_ToDo.FormattingEnabled = true;
            this.lb_ToDo.ItemHeight = 16;
            this.lb_ToDo.Location = new System.Drawing.Point(25, 28);
            this.lb_ToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_ToDo.Name = "lb_ToDo";
            this.lb_ToDo.Size = new System.Drawing.Size(357, 516);
            this.lb_ToDo.TabIndex = 0;
            this.lb_ToDo.DoubleClick += new System.EventHandler(this.lb_ToDo_DoubleClick);
            // 
            // lb_Doing
            // 
            this.lb_Doing.FormattingEnabled = true;
            this.lb_Doing.ItemHeight = 16;
            this.lb_Doing.Location = new System.Drawing.Point(25, 28);
            this.lb_Doing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Doing.Name = "lb_Doing";
            this.lb_Doing.Size = new System.Drawing.Size(357, 516);
            this.lb_Doing.TabIndex = 1;
            this.lb_Doing.DoubleClick += new System.EventHandler(this.lb_Doing_DoubleClick);
            // 
            // lb_Done
            // 
            this.lb_Done.FormattingEnabled = true;
            this.lb_Done.ItemHeight = 16;
            this.lb_Done.Location = new System.Drawing.Point(25, 28);
            this.lb_Done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Done.Name = "lb_Done";
            this.lb_Done.Size = new System.Drawing.Size(357, 516);
            this.lb_Done.TabIndex = 2;
            this.lb_Done.DoubleClick += new System.EventHandler(this.lb_Done_DoubleClick);
            // 
            // gb_ToDo
            // 
            this.gb_ToDo.Controls.Add(this.lb_ToDo);
            this.gb_ToDo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_ToDo.Location = new System.Drawing.Point(28, 74);
            this.gb_ToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_ToDo.Name = "gb_ToDo";
            this.gb_ToDo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_ToDo.Size = new System.Drawing.Size(409, 570);
            this.gb_ToDo.TabIndex = 3;
            this.gb_ToDo.TabStop = false;
            this.gb_ToDo.Text = "ToDo";
            // 
            // gb_Doing
            // 
            this.gb_Doing.Controls.Add(this.lb_Doing);
            this.gb_Doing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Doing.Location = new System.Drawing.Point(449, 74);
            this.gb_Doing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Doing.Name = "gb_Doing";
            this.gb_Doing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Doing.Size = new System.Drawing.Size(409, 570);
            this.gb_Doing.TabIndex = 4;
            this.gb_Doing.TabStop = false;
            this.gb_Doing.Text = "Doing";
            // 
            // gb_Done
            // 
            this.gb_Done.Controls.Add(this.lb_Done);
            this.gb_Done.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Done.Location = new System.Drawing.Point(869, 74);
            this.gb_Done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Done.Name = "gb_Done";
            this.gb_Done.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Done.Size = new System.Drawing.Size(409, 570);
            this.gb_Done.TabIndex = 5;
            this.gb_Done.TabStop = false;
            this.gb_Done.Text = "Done";
            // 
            // b_seeCompletionForecast
            // 
            this.b_seeCompletionForecast.AutoRoundedCorners = true;
            this.b_seeCompletionForecast.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_seeCompletionForecast.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_seeCompletionForecast.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_seeCompletionForecast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_seeCompletionForecast.FillColor = System.Drawing.Color.LightGray;
            this.b_seeCompletionForecast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_seeCompletionForecast.ForeColor = System.Drawing.Color.Black;
            this.b_seeCompletionForecast.Location = new System.Drawing.Point(976, 15);
            this.b_seeCompletionForecast.Margin = new System.Windows.Forms.Padding(4);
            this.b_seeCompletionForecast.Name = "b_seeCompletionForecast";
            this.b_seeCompletionForecast.Size = new System.Drawing.Size(303, 44);
            this.b_seeCompletionForecast.TabIndex = 11;
            this.b_seeCompletionForecast.Text = "VER PREVISÃO DE CONCLUSÃO";
            // 
            // b_NewTask
            // 
            this.b_NewTask.AutoRoundedCorners = true;
            this.b_NewTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_NewTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_NewTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_NewTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_NewTask.FillColor = System.Drawing.Color.LightGray;
            this.b_NewTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_NewTask.ForeColor = System.Drawing.Color.Black;
            this.b_NewTask.Location = new System.Drawing.Point(28, 662);
            this.b_NewTask.Margin = new System.Windows.Forms.Padding(4);
            this.b_NewTask.Name = "b_NewTask";
            this.b_NewTask.Size = new System.Drawing.Size(197, 44);
            this.b_NewTask.TabIndex = 11;
            this.b_NewTask.Text = "NOVA TAREFA";
            this.b_NewTask.Click += new System.EventHandler(this.b_NewTask_Click);
            // 
            // b_FinishTask
            // 
            this.b_FinishTask.AutoRoundedCorners = true;
            this.b_FinishTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_FinishTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_FinishTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_FinishTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_FinishTask.FillColor = System.Drawing.Color.LightGray;
            this.b_FinishTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_FinishTask.ForeColor = System.Drawing.Color.Black;
            this.b_FinishTask.Location = new System.Drawing.Point(869, 662);
            this.b_FinishTask.Margin = new System.Windows.Forms.Padding(4);
            this.b_FinishTask.Name = "b_FinishTask";
            this.b_FinishTask.Size = new System.Drawing.Size(197, 44);
            this.b_FinishTask.TabIndex = 11;
            this.b_FinishTask.Text = "TERMINAR TAREFA";
            this.b_FinishTask.Click += new System.EventHandler(this.b_FinishTask_Click);
            // 
            // b_RestartTask
            // 
            this.b_RestartTask.AutoRoundedCorners = true;
            this.b_RestartTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_RestartTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_RestartTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_RestartTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_RestartTask.FillColor = System.Drawing.Color.LightGray;
            this.b_RestartTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_RestartTask.ForeColor = System.Drawing.Color.Black;
            this.b_RestartTask.Image = global::iTasks.Properties.Resources.icons8_arrow_96__1_;
            this.b_RestartTask.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_RestartTask.Location = new System.Drawing.Point(661, 662);
            this.b_RestartTask.Margin = new System.Windows.Forms.Padding(4);
            this.b_RestartTask.Name = "b_RestartTask";
            this.b_RestartTask.Size = new System.Drawing.Size(197, 44);
            this.b_RestartTask.TabIndex = 11;
            this.b_RestartTask.Text = "REINICIAR TAREFA";
            this.b_RestartTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_RestartTask.Click += new System.EventHandler(this.b_RestartTask_Click);
            // 
            // b_ExecuteTask
            // 
            this.b_ExecuteTask.AutoRoundedCorners = true;
            this.b_ExecuteTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_ExecuteTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_ExecuteTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_ExecuteTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_ExecuteTask.FillColor = System.Drawing.Color.LightGray;
            this.b_ExecuteTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.b_ExecuteTask.ForeColor = System.Drawing.Color.Black;
            this.b_ExecuteTask.Image = global::iTasks.Properties.Resources.icons8_arrow_96;
            this.b_ExecuteTask.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_ExecuteTask.Location = new System.Drawing.Point(240, 662);
            this.b_ExecuteTask.Margin = new System.Windows.Forms.Padding(4);
            this.b_ExecuteTask.Name = "b_ExecuteTask";
            this.b_ExecuteTask.Size = new System.Drawing.Size(197, 44);
            this.b_ExecuteTask.TabIndex = 11;
            this.b_ExecuteTask.Text = "EXECUTAR TAREFA";
            this.b_ExecuteTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_ExecuteTask.Click += new System.EventHandler(this.b_ExecuteTask_Click);
            // 
            // KanbanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.b_FinishTask);
            this.Controls.Add(this.b_RestartTask);
            this.Controls.Add(this.b_ExecuteTask);
            this.Controls.Add(this.b_NewTask);
            this.Controls.Add(this.b_seeCompletionForecast);
            this.Controls.Add(this.gb_Done);
            this.Controls.Add(this.gb_Doing);
            this.Controls.Add(this.gb_ToDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KanbanForm";
            this.Text = "KanbanForm";
            this.gb_ToDo.ResumeLayout(false);
            this.gb_Doing.ResumeLayout(false);
            this.gb_Done.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_ToDo;
        private System.Windows.Forms.ListBox lb_Doing;
        private System.Windows.Forms.ListBox lb_Done;
        private System.Windows.Forms.GroupBox gb_ToDo;
        private System.Windows.Forms.GroupBox gb_Doing;
        private System.Windows.Forms.GroupBox gb_Done;
        private Guna.UI2.WinForms.Guna2Button b_seeCompletionForecast;
        private Guna.UI2.WinForms.Guna2Button b_NewTask;
        private Guna.UI2.WinForms.Guna2Button b_ExecuteTask;
        private Guna.UI2.WinForms.Guna2Button b_RestartTask;
        private Guna.UI2.WinForms.Guna2Button b_FinishTask;
    }
}