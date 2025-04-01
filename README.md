# Klasifikasi Kategori Ikan Menggunakan CatBoost dan Perceptron

Proyek ini bertujuan untuk mengklasifikasikan kategori ikan menggunakan dua model pembelajaran mesin, yaitu *CatBoost* dan *Perceptron*. Dataset yang digunakan berisi berbagai fitur yang menggambarkan karakteristik ikan, seperti panjang, berat, dan lebar, yang dapat digunakan untuk memprediksi jenis atau kategori ikan.

## Dataset

Dataset yang digunakan dalam proyek ini adalah *dataset ikan* yang mengandung berbagai informasi mengenai spesies ikan. Fitur-fitur yang ada di dataset ini termasuk:

- *Length*: Panjang ikan (dalam cm)
- *Weight*: Berat ikan (dalam gram)
- *Width*: Lebar ikan (dalam cm)
- *Height*: Tinggi ikan (dalam cm)

Data ini digunakan untuk memprediksi kategori ikan, yang bisa berupa berbagai spesies seperti *Perch, **Roach, **Pike, **Salmon*, dan lain-lain.

## Algoritma yang Digunakan

### 1. *CatBoost*
CatBoost adalah algoritma *Gradient Boosting* yang dirancang untuk bekerja dengan data kategori. CatBoost unggul dalam menangani fitur kategori tanpa perlu proses encoding khusus, seperti one-hot encoding, dan dapat memberikan hasil yang sangat baik dalam masalah klasifikasi.

Dalam proyek ini, CatBoost digunakan untuk melatih model pada dataset ikan, memanfaatkan fitur numerik dan kategori untuk menghasilkan prediksi klasifikasi yang akurat.

### 2. *Perceptron*
Perceptron adalah salah satu algoritma *neural network* dasar yang digunakan untuk masalah klasifikasi biner. Meskipun lebih sederhana dibandingkan jaringan saraf yang lebih kompleks, perceptron masih bisa memberikan hasil yang cukup baik dalam klasifikasi dataset yang tidak terlalu kompleks.

Di sini, perceptron digunakan untuk membandingkan hasilnya dengan CatBoost dan mengevaluasi akurasi pada dataset ikan.

## Proses Pengolahan Data

Sebelum melatih model, data dibersihkan dan diproses sebagai berikut:
1. *Imputasi nilai yang hilang*: Nilai yang hilang pada beberapa kolom diisi menggunakan metode imputasi yang sesuai.
2. *Pembagian data: Data dibagi menjadi **training set* dan *test set* untuk melatih dan menguji model.
3. *Normalisasi fitur numerik*: Fitur numerik distandarisasi untuk memastikan model bekerja dengan baik.
4. *Encoding fitur kategori*: Jika diperlukan, fitur kategori diubah menjadi format yang bisa diterima oleh model pembelajaran mesin.

## Hasil Model

- *CatBoost* memberikan hasil yang lebih baik pada dataset ini, dengan akurasi yang lebih tinggi dibandingkan dengan perceptron. CatBoost mampu menangani fitur kategori dengan lebih efisien dan memberikan prediksi yang lebih akurat.
- *Perceptron* memberikan hasil yang cukup baik pada dataset ini, namun tidak sebaik CatBoost dalam mengklasifikasikan kategori ikan.
