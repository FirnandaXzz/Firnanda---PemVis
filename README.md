**Deskripsi Aplikasi: PenjualanMebelApp**

PenjualanMebelApp adalah aplikasi desktop berbasis Windows Forms yang digunakan untuk mencatat dan mengelola transaksi penjualan mebel seperti kursi, meja, lemari, dan lainnya. Aplikasi ini dibuat menggunakan bahasa pemrograman C# dan memanfaatkan database lokal SQLite untuk menyimpan data transaksi.

Tujuan Aplikasi
Aplikasi ini dirancang untuk:

  - Membantu pemilik toko mebel mencatat transaksi harian.
  - Menyimpan data secara lokal tanpa memerlukan koneksi internet.
  - Memudahkan pengguna dalam menambahkan, melihat, dan mengelola data penjualan.

Fitur-Fitur Utama
  - Formulir Input Data Penjualan
  - Pengguna dapat mengisi nama barang, jumlah barang yang dijual, dan harga satuan.
  - Daftar Transaksi
  - Menampilkan semua data penjualan yang sudah dicatat dalam bentuk daftar.

Database Otomatis

  - Aplikasi akan otomatis membuat file database lokal bernama penjualan.db jika belum tersedia saat dijalankan pertama kali.
  - Koneksi Database SQLite
  - Menggunakan database ringan dan lokal sehingga tidak memerlukan instalasi server database eksternal.
  - Struktur Data yang Jelas

Data penjualan disimpan dalam tabel Penjualan dengan kolom:

  - ID (otomatis)
  - Nama Barang
  - Jumlah
  - Harga Satuan

Struktur Proyek

  - Program.cs: Titik awal aplikasi, berfungsi untuk menjalankan form utama.
  - MainForm.cs: Form utama tempat pengguna berinteraksi (input dan melihat data).
  - MebelItem.cs: Representasi satu data penjualan (model data).
  - DatabaseHelper.cs: Kelas khusus untuk menangani pembuatan database dan koneksi SQLite.
  - PenjualanMebelApp.csproj: File konfigurasi proyek .NET.
  - Properties/: Folder sistem bawaan dari proyek Visual Studio.

Cara Kerja Umum Aplikasi

  - Saat dijalankan, aplikasi akan mengecek apakah file database penjualan.db sudah ada.
  - Jika belum ada, file database akan otomatis dibuat dan tabel Penjualan disiapkan.
  - Pengguna dapat mengisi nama barang, jumlah, dan harga lalu menekan tombol untuk menyimpan transaksi.
  - Data yang diinput akan langsung tersimpan ke dalam database dan ditampilkan di daftar.
