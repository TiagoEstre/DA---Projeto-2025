namespace iTasks.views
{
    partial class OngoingTasksForm
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
            this.dgv_Tasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Tasks
            // 
            this.dgv_Tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Tasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tasks.Location = new System.Drawing.Point(15, 23);
            this.dgv_Tasks.Name = "dgv_Tasks";
            this.dgv_Tasks.RowHeadersWidth = 51;
            this.dgv_Tasks.RowTemplate.Height = 24;
            this.dgv_Tasks.Size = new System.Drawing.Size(1266, 680);
            this.dgv_Tasks.TabIndex = 2;
            this.dgv_Tasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Tasks_CellFormatting);
            // 
            // OngoingTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 733);
            this.Controls.Add(this.dgv_Tasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OngoingTasksForm";
            this.Text = "ongoingtasksForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Tasks;
    }
}