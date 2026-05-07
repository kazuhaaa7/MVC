perusahaan butuh org yg siap
cv strandard ATS
MVC
## Model =  logika akses data
	- berisi atribut yang akan dideklarasikan.
	- Mengelola data: Menyimpan data sementara (dalam bentuk objek) atau permanen (ke database, file, API).
	- Melakukan operasi CRUD (Create, Read, Update, Delete) ke sumber data.
	- Menjaga konsistensi data: Menerapkan aturan bisnis dan validasi sebelum menyimpan.
	- Memberi notifikasi ke View/Controller jika ada perubahan data (misalnya melalui observer pattern).
## View =
	- berisi file design dan desainer.
	- hanya menampilkan data yang diterima dari Model/Controller. Tidak boleh mengakses penyimpanan langsung.
## Control = hanya menerima input dari pengguna, memanggil fungsi Model untuk menyimpan/mengambil data, lalu memilih View. Tidak tahu bagaimana data disimpan (SQL, file, dll).
