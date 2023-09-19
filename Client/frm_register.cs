using System;
using System.Data.OleDb;

namespace Client
{
    public partial class frm_register : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public frm_register()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_confirm.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.Text == txt_confirm.Text && txt_password.Text.Length >= 8)
            {
                
                con.Open();
                string checkUsernameQuery = "SELECT COUNT(*) FROM tbl_users WHERE username = @username";
                cmd = new OleDbCommand(checkUsernameQuery, con);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    con.Close();
                    MessageBox.Show("Username already exists. Please choose another username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Text = "";
                    txt_password.Text = "";
                    txt_confirm.Text = "";
                }
                else
                {

                    string register = "INSERT INTO tbl_users (username, [password]) VALUES (@username, @password)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    txt_username.Text = "";
                    txt_password.Text = "";
                    txt_confirm.Text = "";

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new frm_login().Show();
                    this.Hide();
                }
            }
            else if (txt_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long! ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-Enter!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Text = "";
                txt_confirm.Text = "";
                txt_password.Focus();
            }
        }



        private void checkbx_showpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbx_showpwd.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_confirm.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '•';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_confirm.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frm_login().Show();
            this.Hide();
        }
    }
}