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
            this.cb_FilterProjeto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_filterProgrammer = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.dgv_Tasks.Location = new System.Drawing.Point(15, 98);
            this.dgv_Tasks.Name = "dgv_Tasks";
            this.dgv_Tasks.RowHeadersWidth = 51;
            this.dgv_Tasks.RowTemplate.Height = 24;
            this.dgv_Tasks.Size = new System.Drawing.Size(1266, 605);
            this.dgv_Tasks.TabIndex = 2;
            this.dgv_Tasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Tasks_CellFormatting);
            // 
            // cb_FilterProjeto
            // 
            this.cb_FilterProjeto.AutoRoundedCorners = true;
            this.cb_FilterProjeto.BackColor = System.Drawing.Color.Transparent;
            this.cb_FilterProjeto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_FilterProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterProjeto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_FilterProjeto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_FilterProjeto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_FilterProjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_FilterProjeto.ItemHeight = 30;
            this.cb_FilterProjeto.Location = new System.Drawing.Point(360, 33);
            this.cb_FilterProjeto.Name = "cb_FilterProjeto";
            this.cb_FilterProjeto.Size = new System.Drawing.Size(183, 36);
            this.cb_FilterProjeto.TabIndex = 3;
            // 
            // tb_filterProgrammer
            // 
            this.tb_filterProgrammer.AutoRoundedCorners = true;
            this.tb_filterProgrammer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_filterProgrammer.DefaultText = "";
            this.tb_filterProgrammer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_filterProgrammer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_filterProgrammer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_filterProgrammer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_filterProgrammer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_filterProgrammer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_filterProgrammer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_filterProgrammer.Location = new System.Drawing.Point(15, 33);
            this.tb_filterProgrammer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_filterProgrammer.Name = "tb_filterProgrammer";
            this.tb_filterProgrammer.PlaceholderText = "Filtra Nome";
            this.tb_filterProgrammer.SelectedText = "";
            this.tb_filterProgrammer.Size = new System.Drawing.Size(327, 48);
            this.tb_filterProgrammer.TabIndex = 4;
            this.tb_filterProgrammer.TextOffset = new System.Drawing.Point(10, 0);
            this.tb_filterProgrammer.TextChanged += new System.EventHandler(this.tb_filterProgrammer_TextChanged);
            // 
            // OngoingTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1307, 733);
            this.Controls.Add(this.tb_filterProgrammer);
            this.Controls.Add(this.cb_FilterProjeto);
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
        private Guna.UI2.WinForms.Guna2ComboBox cb_FilterProjeto;
        private Guna.UI2.WinForms.Guna2TextBox tb_filterProgrammer;
    }
}