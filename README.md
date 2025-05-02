**Deskripsi Aplikasi: PenjualanMebelApp**

PenjualanMebelApp adalah aplikasi desktop berbasis Windows Forms yang dirancang untuk mencatat dan mengelola transaksi penjualan mebel seperti meja, kursi, lemari, dan produk sejenis. Aplikasi ini dibangun menggunakan bahasa pemrograman C# dengan dukungan database lokal SQLite, sehingga ringan, cepat, dan tidak membutuhkan koneksi internet.

Tujuan Aplikasi
  - Aplikasi ini dibuat dengan tujuan utama:
  - Membantu pemilik toko mebel dalam mencatat transaksi penjualan harian.
  - Menyimpan data secara lokal dengan cara yang praktis dan aman.
  - Mempermudah pengguna untuk menambahkan dan melihat data transaksi kapan pun dibutuhkan.

**Fitur-Fitur Utama**
Formulir Input Data Penjualan
Pengguna dapat mengisi:
  - Kode Barang
  - Nama Barang
  - Harga Barang
Tersedia tombol Simpan untuk mencatat transaksi ke database.

Tombol Lihat Data
  - Menampilkan seluruh data penjualan yang telah disimpan dalam bentuk daftar terstruktur.
  - Daftar mencakup kolom: ID, Kode, Nama, dan Harga.

Daftar Transaksi
  - Data ditampilkan dalam format tabel seperti pada mockup.
  - Transaksi yang baru ditambahkan akan langsung muncul pada daftar setelah penyimpanan.

Database Otomatis
  - Saat pertama kali dijalankan, aplikasi akan otomatis memeriksa apakah file database penjualan.db sudah tersedia.
  - Jika belum ada, file tersebut akan dibuat secara otomatis bersama dengan struktur tabel Penjualan.

Struktur Tabel:
  - ID: Auto Increment (sebagai Primary Key)
  - Kode: Kode unik untuk setiap barang
  - NamaBarang: Nama produk mebel
  - Harga: Harga satuan barang


Cara Kerja Umum Aplikasi
  - Aplikasi dijalankan dan memeriksa keberadaan file database penjualan.db.
  - Jika belum ada, database otomatis dibuat beserta tabel Penjualan.
  - Pengguna mengisi kode, nama, dan harga barang, lalu menekan tombol Simpan.
  - Data transaksi akan disimpan ke database dan ditampilkan dalam daftar penjualan.
  - Tombol Lihat Data akan memuat ulang data dari database untuk ditampilkan ulang.

Kesimpulan
PenjualanMebelApp merupakan solusi praktis untuk toko mebel dalam mencatat transaksi penjualan secara digital dan lokal. Dengan antarmuka sederhana, fitur event-driven, dan penyimpanan menggunakan SQLite, aplikasi ini menjadi pilihan tepat untuk pengelolaan data tanpa internet, namun tetap efisien dan terstruktur.
