using BusinessAccessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer.UI.Forms
{
    public partial class LoginForm : Form
    {
        DBNhanVien dbnv = null;
        public LoginForm()
        {
            InitializeComponent();
            dbnv = new DBNhanVien();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isAuthenticated = dbnv.CheckLogin(textBoxUsername.Text, textBoxPassword.Text);
            if (isAuthenticated)
            {
                this.Hide();
                MainForm form2 = new MainForm(textBoxUsername.Text);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar != '\0')
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(this, null);
            }
        }
    }
}
