namespace Client
{
    partial class frm_register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_started = new Label();
            lbl_username = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            lbl_password = new Label();
            txt_confirm = new TextBox();
            lbl_confirm = new Label();
            checkbx_showpwd = new CheckBox();
            btn_register = new Button();
            btn_clear = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbl_started
            // 
            lbl_started.AutoSize = true;
            lbl_started.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_started.ForeColor = Color.FromArgb(116, 86, 174);
            lbl_started.Location = new Point(82, 43);
            lbl_started.Name = "lbl_started";
            lbl_started.Size = new Size(155, 27);
            lbl_started.TabIndex = 0;
            lbl_started.Text = "Get Started";
            lbl_started.TextAlign = ContentAlignment.MiddleCenter;
            lbl_started.Click += label1_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(56, 108);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(73, 17);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username:";
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(56, 128);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.RightToLeft = RightToLeft.No;
            txt_username.Size = new Size(216, 23);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(230, 231, 233);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(56, 198);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '•';
            txt_password.Size = new Size(216, 28);
            txt_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(56, 178);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(70, 17);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password:";
            lbl_password.TextAlign = ContentAlignment.MiddleCenter;
            lbl_password.Click += lbl_password_Click;
            // 
            // txt_confirm
            // 
            txt_confirm.BackColor = Color.FromArgb(230, 231, 233);
            txt_confirm.BorderStyle = BorderStyle.None;
            txt_confirm.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_confirm.Location = new Point(56, 264);
            txt_confirm.Multiline = true;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.PasswordChar = '•';
            txt_confirm.Size = new Size(216, 28);
            txt_confirm.TabIndex = 6;
            // 
            // lbl_confirm
            // 
            lbl_confirm.AutoSize = true;
            lbl_confirm.Location = new Point(56, 244);
            lbl_confirm.Name = "lbl_confirm";
            lbl_confirm.Size = new Size(124, 17);
            lbl_confirm.TabIndex = 5;
            lbl_confirm.Text = "Confirm Password:";
            lbl_confirm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkbx_showpwd
            // 
            checkbx_showpwd.AutoSize = true;
            checkbx_showpwd.Cursor = Cursors.Hand;
            checkbx_showpwd.FlatStyle = FlatStyle.Flat;
            checkbx_showpwd.Location = new Point(106, 309);
            checkbx_showpwd.Name = "checkbx_showpwd";
            checkbx_showpwd.Size = new Size(119, 21);
            checkbx_showpwd.TabIndex = 7;
            checkbx_showpwd.Text = "Show Password";
            checkbx_showpwd.TextAlign = ContentAlignment.MiddleCenter;
            checkbx_showpwd.UseVisualStyleBackColor = true;
            checkbx_showpwd.CheckedChanged += checkbx_showpwd_CheckedChanged;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(116, 86, 174);
            btn_register.Cursor = Cursors.Hand;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(56, 356);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(216, 35);
            btn_register.TabIndex = 8;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.FromArgb(116, 86, 174);
            btn_clear.Location = new Point(56, 411);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(216, 35);
            btn_clear.TabIndex = 9;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 471);
            label1.Name = "label1";
            label1.Size = new Size(165, 17);
            label1.TabIndex = 10;
            label1.Text = "Already Have An Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(116, 500);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 11;
            label2.Text = "Back To Login";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // frm_register
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(340, 545);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_clear);
            Controls.Add(btn_register);
            Controls.Add(checkbx_showpwd);
            Controls.Add(txt_confirm);
            Controls.Add(lbl_confirm);
            Controls.Add(txt_password);
            Controls.Add(lbl_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_username);
            Controls.Add(lbl_started);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_started;
        private Label lbl_username;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label lbl_password;
        private TextBox txt_confirm;
        private Label lbl_confirm;
        private CheckBox checkbx_showpwd;
        private Button btn_register;
        private Button btn_clear;
        private Label label1;
        private Label label2;
    }
}