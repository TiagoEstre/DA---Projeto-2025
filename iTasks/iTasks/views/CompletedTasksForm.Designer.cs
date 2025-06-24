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
            this.dgv_Done = new System.Windows.Forms.DataGridView();
            this.tb_filterProgrammer = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_FilterProjeto = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Done)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Done
            // 
            this.dgv_Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Done.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Done.Location = new System.Drawing.Point(11, 80);
            this.dgv_Done.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Done.Name = "dgv_Done";
            this.dgv_Done.RowHeadersWidth = 51;
            this.dgv_Done.RowTemplate.Height = 24;
            this.dgv_Done.Size = new System.Drawing.Size(950, 492);
            this.dgv_Done.TabIndex = 1;
            this.dgv_Done.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Done_CellFormatting);
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
            this.tb_filterProgrammer.Location = new System.Drawing.Point(11, 27);
            this.tb_filterProgrammer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_filterProgrammer.Name = "tb_filterProgrammer";
            this.tb_filterProgrammer.PlaceholderText = "Filtra Nome";
            this.tb_filterProgrammer.SelectedText = "";
            this.tb_filterProgrammer.Size = new System.Drawing.Size(245, 39);
            this.tb_filterProgrammer.TabIndex = 6;
            this.tb_filterProgrammer.TextOffset = new System.Drawing.Point(10, 0);
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
            this.cb_FilterProjeto.Location = new System.Drawing.Point(270, 27);
            this.cb_FilterProjeto.Margin = new System.Windows.Forms.Padding(2);
            this.cb_FilterProjeto.Name = "cb_FilterProjeto";
            this.cb_FilterProjeto.Size = new System.Drawing.Size(138, 36);
            this.cb_FilterProjeto.TabIndex = 5;
            // 
            // CompletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.tb_filterProgrammer);
            this.Controls.Add(this.cb_FilterProjeto);
            this.Controls.Add(this.dgv_Done);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompletedTasksForm";
            this.Text = "completedtasksForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Done)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Done;
        private Guna.UI2.WinForms.Guna2TextBox tb_filterProgrammer;
        private Guna.UI2.WinForms.Guna2ComboBox cb_FilterProjeto;
    }
}