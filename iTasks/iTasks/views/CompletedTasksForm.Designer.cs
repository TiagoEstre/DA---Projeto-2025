namespace iTasks.views
{
    partial class CompletedTasksForm
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
            this.lb_Done = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_Done
            // 
            this.lb_Done.Enabled = false;
            this.lb_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Done.FormattingEnabled = true;
            this.lb_Done.ItemHeight = 26;
            this.lb_Done.Location = new System.Drawing.Point(15, 23);
            this.lb_Done.Name = "lb_Done";
            this.lb_Done.Size = new System.Drawing.Size(1266, 680);
            this.lb_Done.TabIndex = 0;
            // 
            // CompletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.lb_Done);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompletedTasksForm";
            this.Text = "completedtasksForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Done;
    }
}