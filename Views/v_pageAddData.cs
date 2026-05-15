using MVC.Models;

namespace MVC.View
{
    public partial class Form3 : Form
    {
        private m_userContext db = new m_userContext();
        private m_User _user; // null jika mode tambah


        public Form3(m_User user)
        {
            InitializeComponent();
            _user = user;


            if (_user != null) // mode EDIT, isi field dengan data lama
            {
                txtNama.Text = _user.nama;
                txtUmur.Text = _user.umur.ToString();
                txtAsal.Text = _user.asal;
            }
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi sederhana
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                return;
            }


            if (_user == null) // TAMBAH
            {
                m_User baru = new m_User(0, txtNama.Text, int.Parse(txtUmur.Text), txtAsal.Text);
                db.AddUser(baru);
                MessageBox.Show("User berhasil ditambahkan!");
            }
            else // EDIT
            {
                _user.nama = txtNama.Text;
                _user.umur = int.Parse(txtUmur.Text);
                _user.asal = txtAsal.Text;
                db.UpdateUser(_user);
                MessageBox.Show("User berhasil diupdate!");
            }


            this.Close();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}