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
            this.b_NewTask = new System.Windows.Forms.Button();
            this.b_ExecuteTask = new System.Windows.Forms.Button();
            this.b_RestartTask = new System.Windows.Forms.Button();
            this.b_FinishTask = new System.Windows.Forms.Button();
            this.b_seeCompletionForecast = new System.Windows.Forms.Button();
            this.gb_ToDo.SuspendLayout();
            this.gb_Doing.SuspendLayout();
            this.gb_Done.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ToDo
            // 
            this.lb_ToDo.FormattingEnabled = true;
            this.lb_ToDo.ItemHeight = 16;
            this.lb_ToDo.Location = new System.Drawing.Point(29, 46);
            this.lb_ToDo.Name = "lb_ToDo";
            this.lb_ToDo.Size = new System.Drawing.Size(336, 468);
            this.lb_ToDo.TabIndex = 0;
            // 
            // lb_Doing
            // 
            this.lb_Doing.FormattingEnabled = true;
            this.lb_Doing.ItemHeight = 16;
            this.lb_Doing.Location = new System.Drawing.Point(24, 46);
            this.lb_Doing.Name = "lb_Doing";
            this.lb_Doing.Size = new System.Drawing.Size(316, 468);
            this.lb_Doing.TabIndex = 1;
            // 
            // lb_Done
            // 
            this.lb_Done.FormattingEnabled = true;
            this.lb_Done.ItemHeight = 16;
            this.lb_Done.Location = new System.Drawing.Point(27, 36);
            this.lb_Done.Name = "lb_Done";
            this.lb_Done.Size = new System.Drawing.Size(324, 468);
            this.lb_Done.TabIndex = 2;
            // 
            // gb_ToDo
            // 
            this.gb_ToDo.Controls.Add(this.lb_ToDo);
            this.gb_ToDo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_ToDo.Location = new System.Drawing.Point(72, 98);
            this.gb_ToDo.Name = "gb_ToDo";
            this.gb_ToDo.Size = new System.Drawing.Size(385, 545);
            this.gb_ToDo.TabIndex = 3;
            this.gb_ToDo.TabStop = false;
            this.gb_ToDo.Text = "ToDo";
            // 
            // gb_Doing
            // 
            this.gb_Doing.Controls.Add(this.lb_Doing);
            this.gb_Doing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Doing.Location = new System.Drawing.Point(499, 98);
            this.gb_Doing.Name = "gb_Doing";
            this.gb_Doing.Size = new System.Drawing.Size(351, 545);
            this.gb_Doing.TabIndex = 4;
            this.gb_Doing.TabStop = false;
            this.gb_Doing.Text = "Doing";
            // 
            // gb_Done
            // 
            this.gb_Done.Controls.Add(this.lb_Done);
            this.gb_Done.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Done.Location = new System.Drawing.Point(889, 98);
            this.gb_Done.Name = "gb_Done";
            this.gb_Done.Size = new System.Drawing.Size(368, 544);
            this.gb_Done.TabIndex = 5;
            this.gb_Done.TabStop = false;
            this.gb_Done.Text = "Done";
            // 
            // b_NewTask
            // 
            this.b_NewTask.Location = new System.Drawing.Point(99, 659);
            this.b_NewTask.Name = "b_NewTask";
            this.b_NewTask.Size = new System.Drawing.Size(210, 31);
            this.b_NewTask.TabIndex = 6;
            this.b_NewTask.Text = "Nova Tarefa";
            this.b_NewTask.UseVisualStyleBackColor = true;
            // 
            // b_ExecuteTask
            // 
            this.b_ExecuteTask.Location = new System.Drawing.Point(366, 657);
            this.b_ExecuteTask.Name = "b_ExecuteTask";
            this.b_ExecuteTask.Size = new System.Drawing.Size(191, 32);
            this.b_ExecuteTask.TabIndex = 7;
            this.b_ExecuteTask.Text = "Executar Tarefa >>";
            this.b_ExecuteTask.UseVisualStyleBackColor = true;
            // 
            // b_RestartTask
            // 
            this.b_RestartTask.Location = new System.Drawing.Point(604, 658);
            this.b_RestartTask.Name = "b_RestartTask";
            this.b_RestartTask.Size = new System.Drawing.Size(164, 31);
            this.b_RestartTask.TabIndex = 8;
            this.b_RestartTask.Text = "<< Reiniciar Tarefa";
            this.b_RestartTask.UseVisualStyleBackColor = true;
            // 
            // b_FinishTask
            // 
            this.b_FinishTask.Location = new System.Drawing.Point(828, 658);
            this.b_FinishTask.Name = "b_FinishTask";
            this.b_FinishTask.Size = new System.Drawing.Size(173, 31);
            this.b_FinishTask.TabIndex = 9;
            this.b_FinishTask.Text = "Terminar Tarefa";
            this.b_FinishTask.UseVisualStyleBackColor = true;
            // 
            // b_seeCompletionForecast
            // 
            this.b_seeCompletionForecast.Location = new System.Drawing.Point(90, 47);
            this.b_seeCompletionForecast.Name = "b_seeCompletionForecast";
            this.b_seeCompletionForecast.Size = new System.Drawing.Size(195, 32);
            this.b_seeCompletionForecast.TabIndex = 10;
            this.b_seeCompletionForecast.Text = "Ver Previsão da Conclusão";
            this.b_seeCompletionForecast.UseVisualStyleBackColor = true;
            // 
            // KanbanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.b_seeCompletionForecast);
            this.Controls.Add(this.b_FinishTask);
            this.Controls.Add(this.b_RestartTask);
            this.Controls.Add(this.b_ExecuteTask);
            this.Controls.Add(this.b_NewTask);
            this.Controls.Add(this.gb_Done);
            this.Controls.Add(this.gb_Doing);
            this.Controls.Add(this.gb_ToDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KanbanForm";
            this.Text = "KanbanForm";
            this.Load += new System.EventHandler(this.KanbanForm_Load);
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
        private System.Windows.Forms.Button b_NewTask;
        private System.Windows.Forms.Button b_ExecuteTask;
        private System.Windows.Forms.Button b_RestartTask;
        private System.Windows.Forms.Button b_FinishTask;
        private System.Windows.Forms.Button b_seeCompletionForecast;
    }
}