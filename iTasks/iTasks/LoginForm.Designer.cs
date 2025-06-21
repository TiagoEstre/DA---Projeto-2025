namespace iTasks
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.ElipseLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowFormLogin = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.ts_RememberMe = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnimateWindowLogin = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.DragControlLogin = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ControlBoxClosed = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Pl_Login = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tb_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pl_Register = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tb_CreateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_Register = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tb_CreatePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_CreateConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_CreateUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pl_Login.SuspendLayout();
            this.Pl_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseLogin
            // 
            this.ElipseLogin.BorderRadius = 20;
            this.ElipseLogin.TargetControl = this;
            // 
            // ShadowFormLogin
            // 
            this.ShadowFormLogin.TargetForm = this;
            // 
            // ts_RememberMe
            // 
            this.ts_RememberMe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ts_RememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_RememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_RememberMe.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_RememberMe.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ts_RememberMe.Location = new System.Drawing.Point(23, 192);
            this.ts_RememberMe.Name = "ts_RememberMe";
            this.ts_RememberMe.Size = new System.Drawing.Size(35, 20);
            this.ts_RememberMe.TabIndex = 2;
            this.ts_RememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_RememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_RememberMe.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_RememberMe.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(64, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Relembrar";
            // 
            // bt_Login
            // 
            this.bt_Login.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_Login.Animated = true;
            this.bt_Login.AutoRoundedCorners = true;
            this.bt_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.bt_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.Location = new System.Drawing.Point(23, 250);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.PressedColor = System.Drawing.Color.Empty;
            this.bt_Login.Size = new System.Drawing.Size(243, 45);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "CONECTE-SE";
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // AnimateWindowLogin
            // 
            this.AnimateWindowLogin.TargetForm = this;
            // 
            // DragControlLogin
            // 
            this.DragControlLogin.DockIndicatorTransparencyValue = 0.6D;
            this.DragControlLogin.TargetControl = this;
            this.DragControlLogin.UseTransparentDrag = true;
            // 
            // ControlBoxClosed
            // 
            this.ControlBoxClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClosed.FillColor = System.Drawing.Color.White;
            this.ControlBoxClosed.IconColor = System.Drawing.Color.DimGray;
            this.ControlBoxClosed.Location = new System.Drawing.Point(672, 3);
            this.ControlBoxClosed.Name = "ControlBoxClosed";
            this.ControlBoxClosed.Size = new System.Drawing.Size(29, 29);
            this.ControlBoxClosed.TabIndex = 5;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(637, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox2.TabIndex = 5;
            // 
            // Pl_Login
            // 
            this.Pl_Login.BackColor = System.Drawing.Color.Transparent;
            this.Pl_Login.Controls.Add(this.tb_Username);
            this.Pl_Login.Controls.Add(this.bt_Login);
            this.Pl_Login.Controls.Add(this.tb_Password);
            this.Pl_Login.Controls.Add(this.label1);
            this.Pl_Login.Controls.Add(this.ts_RememberMe);
            this.Pl_Login.FillColor = System.Drawing.Color.White;
            this.Pl_Login.Location = new System.Drawing.Point(375, 81);
            this.Pl_Login.Name = "Pl_Login";
            this.Pl_Login.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.Pl_Login.ShadowDepth = 70;
            this.Pl_Login.ShadowShift = 10;
            this.Pl_Login.Size = new System.Drawing.Size(286, 376);
            this.Pl_Login.TabIndex = 7;
            this.Pl_Login.Visible = false;
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_Username.Animated = true;
            this.tb_Username.BorderRadius = 8;
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Username.DefaultText = "Utilizador";
            this.tb_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Username.IconLeft = global::iTasks.Properties.Resources.icons8_user_96;
            this.tb_Username.Location = new System.Drawing.Point(23, 63);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_Username.PlaceholderText = "";
            this.tb_Username.SelectedText = "";
            this.tb_Username.Size = new System.Drawing.Size(243, 36);
            this.tb_Username.TabIndex = 0;
            this.tb_Username.TextOffset = new System.Drawing.Point(5, 0);
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_Password.Animated = true;
            this.tb_Password.BorderRadius = 8;
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.DefaultText = "Senha";
            this.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.IconLeft = global::iTasks.Properties.Resources.icons8_password_52;
            this.tb_Password.Location = new System.Drawing.Point(23, 126);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_Password.PlaceholderText = "";
            this.tb_Password.SelectedText = "";
            this.tb_Password.Size = new System.Drawing.Size(243, 36);
            this.tb_Password.TabIndex = 1;
            this.tb_Password.TextOffset = new System.Drawing.Point(5, 0);
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // Pl_Register
            // 
            this.Pl_Register.BackColor = System.Drawing.Color.Transparent;
            this.Pl_Register.Controls.Add(this.tb_CreateName);
            this.Pl_Register.Controls.Add(this.bt_Register);
            this.Pl_Register.Controls.Add(this.tb_CreatePassword);
            this.Pl_Register.Controls.Add(this.tb_CreateConfirmPassword);
            this.Pl_Register.Controls.Add(this.tb_CreateUsername);
            this.Pl_Register.FillColor = System.Drawing.Color.White;
            this.Pl_Register.Location = new System.Drawing.Point(375, 81);
            this.Pl_Register.Name = "Pl_Register";
            this.Pl_Register.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.Pl_Register.ShadowDepth = 70;
            this.Pl_Register.ShadowShift = 10;
            this.Pl_Register.Size = new System.Drawing.Size(286, 376);
            this.Pl_Register.TabIndex = 7;
            this.Pl_Register.Visible = false;
            // 
            // tb_CreateName
            // 
            this.tb_CreateName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_CreateName.Animated = true;
            this.tb_CreateName.BorderRadius = 8;
            this.tb_CreateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CreateName.DefaultText = "Nome";
            this.tb_CreateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CreateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CreateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreateName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_CreateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreateName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_CreateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreateName.IconLeft = global::iTasks.Properties.Resources.icons8_user_96;
            this.tb_CreateName.Location = new System.Drawing.Point(23, 44);
            this.tb_CreateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CreateName.Name = "tb_CreateName";
            this.tb_CreateName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_CreateName.PlaceholderText = "";
            this.tb_CreateName.SelectedText = "";
            this.tb_CreateName.Size = new System.Drawing.Size(243, 36);
            this.tb_CreateName.TabIndex = 5;
            this.tb_CreateName.TextOffset = new System.Drawing.Point(5, 0);
            this.tb_CreateName.Enter += new System.EventHandler(this.tb_CreateName_Enter);
            this.tb_CreateName.Leave += new System.EventHandler(this.tb_CreateName_Leave);
            // 
            // bt_Register
            // 
            this.bt_Register.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_Register.Animated = true;
            this.bt_Register.AutoRoundedCorners = true;
            this.bt_Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Register.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.bt_Register.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_Register.ForeColor = System.Drawing.Color.White;
            this.bt_Register.Location = new System.Drawing.Point(23, 250);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.PressedColor = System.Drawing.Color.Empty;
            this.bt_Register.Size = new System.Drawing.Size(243, 45);
            this.bt_Register.TabIndex = 9;
            this.bt_Register.Text = "CRIAR CONTA";
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // tb_CreatePassword
            // 
            this.tb_CreatePassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_CreatePassword.Animated = true;
            this.tb_CreatePassword.BorderRadius = 8;
            this.tb_CreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CreatePassword.DefaultText = "Senha";
            this.tb_CreatePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CreatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CreatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreatePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_CreatePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreatePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_CreatePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreatePassword.IconLeft = global::iTasks.Properties.Resources.icons8_password_52;
            this.tb_CreatePassword.Location = new System.Drawing.Point(23, 132);
            this.tb_CreatePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CreatePassword.Name = "tb_CreatePassword";
            this.tb_CreatePassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_CreatePassword.PlaceholderText = "";
            this.tb_CreatePassword.SelectedText = "";
            this.tb_CreatePassword.Size = new System.Drawing.Size(243, 36);
            this.tb_CreatePassword.TabIndex = 7;
            this.tb_CreatePassword.TextOffset = new System.Drawing.Point(5, 0);
            this.tb_CreatePassword.Enter += new System.EventHandler(this.tb_CreatePassword_Enter);
            this.tb_CreatePassword.Leave += new System.EventHandler(this.tb_CreatePassword_Leave);
            // 
            // tb_CreateConfirmPassword
            // 
            this.tb_CreateConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_CreateConfirmPassword.Animated = true;
            this.tb_CreateConfirmPassword.BorderRadius = 8;
            this.tb_CreateConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CreateConfirmPassword.DefaultText = "Confirmar Senha";
            this.tb_CreateConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CreateConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CreateConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreateConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreateConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_CreateConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreateConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_CreateConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreateConfirmPassword.IconLeft = global::iTasks.Properties.Resources.icons8_password_52;
            this.tb_CreateConfirmPassword.Location = new System.Drawing.Point(23, 176);
            this.tb_CreateConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CreateConfirmPassword.Name = "tb_CreateConfirmPassword";
            this.tb_CreateConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_CreateConfirmPassword.PlaceholderText = "";
            this.tb_CreateConfirmPassword.SelectedText = "";
            this.tb_CreateConfirmPassword.Size = new System.Drawing.Size(243, 36);
            this.tb_CreateConfirmPassword.TabIndex = 8;
            this.tb_CreateConfirmPassword.TextOffset = new System.Drawing.Point(5, 0);
            this.tb_CreateConfirmPassword.Enter += new System.EventHandler(this.tb_CreateConfirmPassword_Enter);
            this.tb_CreateConfirmPassword.Leave += new System.EventHandler(this.tb_CreateConfirmPassword_Leave);
            // 
            // tb_CreateUsername
            // 
            this.tb_CreateUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_CreateUsername.Animated = true;
            this.tb_CreateUsername.BorderRadius = 8;
            this.tb_CreateUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CreateUsername.DefaultText = "Utilizador";
            this.tb_CreateUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CreateUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CreateUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreateUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CreateUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_CreateUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreateUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_CreateUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CreateUsername.IconLeft = global::iTasks.Properties.Resources.icons8_user_96;
            this.tb_CreateUsername.Location = new System.Drawing.Point(23, 88);
            this.tb_CreateUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CreateUsername.Name = "tb_CreateUsername";
            this.tb_CreateUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_CreateUsername.PlaceholderText = "";
            this.tb_CreateUsername.SelectedText = "";
            this.tb_CreateUsername.Size = new System.Drawing.Size(243, 36);
            this.tb_CreateUsername.TabIndex = 6;
            this.tb_CreateUsername.TextOffset = new System.Drawing.Point(5, 0);
            this.tb_CreateUsername.Enter += new System.EventHandler(this.tb_CreateUsername_Enter);
            this.tb_CreateUsername.Leave += new System.EventHandler(this.tb_CreateUsername_Leave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::iTasks.Properties.Resources.Fundo_Login_iTasks;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(372, 522);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 511);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Pl_Register);
            this.Controls.Add(this.Pl_Login);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.ControlBoxClosed);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Pl_Login.ResumeLayout(false);
            this.Pl_Login.PerformLayout();
            this.Pl_Register.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseLogin;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowFormLogin;
        private Guna.UI2.WinForms.Guna2TextBox tb_Password;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ts_RememberMe;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton bt_Login;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindowLogin;
        private Guna.UI2.WinForms.Guna2DragControl DragControlLogin;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClosed;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ShadowPanel Pl_Login;
        private Guna.UI2.WinForms.Guna2ShadowPanel Pl_Register;
        private Guna.UI2.WinForms.Guna2TextBox tb_CreateName;
        private Guna.UI2.WinForms.Guna2GradientButton bt_Register;
        private Guna.UI2.WinForms.Guna2TextBox tb_CreatePassword;
        private Guna.UI2.WinForms.Guna2TextBox tb_CreateConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox tb_CreateUsername;
        private Guna.UI2.WinForms.Guna2TextBox tb_Username;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

