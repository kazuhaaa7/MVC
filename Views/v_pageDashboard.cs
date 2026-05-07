using MVC.dbconnect;
using MVC.Models;

namespace MVC.View
{
    public partial class Form2 : Form
    {
        private DatabaseHelper db = new DatabaseHelper();


        public Form2(FormUtama induk)
        {
            InitializeComponent();
            //this.FormClosed += (s, e) => Application.Exit();
            LoadData();
        }


        private void LoadData()
        {
            TableUser.DataSource = db.GetAllUsers();
        }


        // Tombol Tambah
        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form3 formTambah = new Form3(null); // null = mode tambah | kalo mau berinteraksi dengan tampilan lain perlu membuat objek dari class itu sendiri
            formTambah.ShowDialog();
            LoadData(); // refresh tabel setelah tutup
        }


        // Tombol Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TableUser.CurrentRow == null) return;


            m_User selected = (m_User)TableUser.CurrentRow.DataBoundItem;
            Form3 formEdit = new Form3(selected); // kirim data = mode edit
            formEdit.ShowDialog();
            LoadData();
        }


        // Tombol Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (TableUser.CurrentRow == null) return;


            m_User selected = (m_User)TableUser.CurrentRow.DataBoundItem;
            var konfirmasi = MessageBox.Show(
                $"Hapus user '{selected.nama}'?",
                "Konfirmasi", MessageBoxButtons.YesNo);


            if (konfirmasi == DialogResult.Yes)
            {
                db.DeleteUser(selected.id);
                LoadData();
            }
        }
    }
}