namespace Client
{
    partial class frm_login
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
            label2 = new Label();
            label1 = new Label();
            btn_clear = new Button();
            btn_login = new Button();
            checkbx_showpwd = new CheckBox();
            txt_password = new TextBox();
            lbl_password = new Label();
            txt_username = new TextBox();
            lbl_username = new Label();
            lbl_started = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(137, 459);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 23;
            label2.Text = "Create Account";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 432);
            label1.Name = "label1";
            label1.Size = new Size(152, 17);
            label1.TabIndex = 22;
            label1.Text = "Don't Have An Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.FromArgb(116, 86, 174);
            btn_clear.Location = new Point(77, 370);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(216, 35);
            btn_clear.TabIndex = 21;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(116, 86, 174);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(77, 315);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(216, 35);
            btn_login.TabIndex = 20;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_register_Click;
            // 
            // checkbx_showpwd
            // 
            checkbx_showpwd.AutoSize = true;
            checkbx_showpwd.Cursor = Cursors.Hand;
            checkbx_showpwd.FlatStyle = FlatStyle.Flat;
            checkbx_showpwd.Location = new Point(119, 264);
            checkbx_showpwd.Name = "checkbx_showpwd";
            checkbx_showpwd.Size = new Size(119, 21);
            checkbx_showpwd.TabIndex = 19;
            checkbx_showpwd.Text = "Show Password";
            checkbx_showpwd.TextAlign = ContentAlignment.MiddleCenter;
            checkbx_showpwd.UseVisualStyleBackColor = true;
            checkbx_showpwd.CheckedChanged += checkbx_showpwd_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(230, 231, 233);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(77, 214);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '•';
            txt_password.Size = new Size(216, 28);
            txt_password.TabIndex = 16;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(77, 194);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(70, 17);
            lbl_password.TabIndex = 15;
            lbl_password.Text = "Password:";
            lbl_password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(77, 144);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(216, 28);
            txt_username.TabIndex = 14;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(77, 124);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(73, 17);
            lbl_username.TabIndex = 13;
            lbl_username.Text = "Username:";
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_started
            // 
            lbl_started.AutoSize = true;
            lbl_started.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_started.ForeColor = Color.FromArgb(116, 86, 174);
            lbl_started.Location = new Point(103, 48);
            lbl_started.Name = "lbl_started";
            lbl_started.Size = new Size(155, 27);
            lbl_started.TabIndex = 12;
            lbl_started.Text = "Get Started";
            lbl_started.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(379, 537);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_clear);
            Controls.Add(btn_login);
            Controls.Add(checkbx_showpwd);
            Controls.Add(txt_password);
            Controls.Add(lbl_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_username);
            Controls.Add(lbl_started);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_login";
            Load += frm_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_clear;
        private Button btn_login;
        private CheckBox checkbx_showpwd;
        private TextBox txt_password;
        private Label lbl_password;
        private TextBox txt_username;
        private Label lbl_username;
        private Label lbl_started;
    }
}