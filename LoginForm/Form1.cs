namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool hopLe = true;

            if (txtUsername.Text == "")
            {
                errorProvider.SetError(txtUsername, "Không được để trống tên đăng nhập!");
                hopLe = false;
            }

            if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Không được để trống mật khẩu!");
                hopLe = false;
            }

            if (hopLe)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
