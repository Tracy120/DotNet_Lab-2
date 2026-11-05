namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim() != "student" || passwordTextBox.Text != "1234")
            {
                MessageBox.Show("Invalid username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }

            var menu = new MenuForm();
            menu.FormClosed += (_, _) => Close();
            Hide();
            menu.Show();
        }

        private void hintLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
