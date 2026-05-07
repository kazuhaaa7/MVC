namespace MVC.View
{


    public partial class Form1 : Form
    {
        private string username;
        private string password;
        private FormUtama _induk;
        public Form1(FormUtama induk)
        {
            InitializeComponent();
            username = "ahmad";
            password = "ahmad123";
            _induk = induk;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = TbUsername.Text.Trim();
            string passwordInput = TbPassword.Text;

            if (usernameInput == this.username && passwordInput == this.password)
            {
                MessageBox.Show("Login Berhasil", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_induk != null)
                {
                    _induk.BukaFormDiPanel(new Form2(_induk));
                }
                else
                {
                    MessageBox.Show("Username Atau Password Salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Form2 formDashboard = new Form2(_induk);
                formDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Atau Password Salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
