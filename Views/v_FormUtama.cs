namespace MVC;

public partial class FormUtama : Form
{
    public FormUtama()
    {
        InitializeComponent();

        // Saat aplikasi jalan, langsung buka Form 1 (Login) ke dalam panel.
        // Kita mengirimkan 'this' (FormUtama) agar Form 1 mengenali siapa induknya.
        BukaFormDiPanel(new View.Form1(this));
    }


    // Fungsi ajaib untuk mengganti isi panel
    public void BukaFormDiPanel(Form formAnak) //parameter disisni mengarah ke form yg ingin ditampilkan. dan hanya bisa class turunan dan form itu saja.
    {
        if (this.panelUtama.Controls.Count > 0)
        {
            this.panelUtama.Controls[0].Dispose(); // Bersihkan form sebelumnya(paling awal)
            this.panelUtama.Controls.Clear(); //menghapus semua control(ex: semua alat yg ada di toolbox). untukk  Memastikan daftar kontrol benar-benar kosong, sebagai pelengkap setelah
        }


        formAnak.TopLevel = false;
        formAnak.FormBorderStyle = FormBorderStyle.None; //Menghilangkan border (bingkai) dan tombol minimize/maximize/close dari form.
        formAnak.Dock = DockStyle.Fill; //Mengatur form agar mengisi penuh seluruh area panel. untuk Memastikan form memanjang dan melebar sesuai ukuran panel, jika panel diubah ukurannya, form akan ikut berubah.

        this.panelUtama.Controls.Add(formAnak);
        this.panelUtama.Tag = formAnak; //enyimpan referensi form ke dalam properti Tag milik panel. Tag adalah properti serbaguna yang bisa diisi object apapun.
        formAnak.Show();
    }

    private void panelUtama_Paint(object sender, PaintEventArgs e)
    {

    }
}

