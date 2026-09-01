# 🚀 Praktikum Pemrograman Visual 



---

## 🛠️ Stack & Perkakas Pengembangan

* **Bahasa Pemrograman:** [Visual Basic .NET (VB.NET)](https://docs.microsoft.com/en-us/dotnet/visual-basic/)
* **IDE Utama:** [Visual Studio](https://visualstudio.microsoft.com/)
* **Platform Framework:** [.NET Framework / .NET Core Desktop](https://dotnet.microsoft.com/)

---

## 📌 Modul 01: Fundamental & Paradigma Pemrograman Visual

### 💡 Konsep Utama
Pemrograman visual mengubah pendekatan perancangan antarmuka aplikasi. Jika paradigma berbasis teks tradisional mengharuskan penulisan baris kode manual untuk mengatur letak dan dimensi elemen UI, pemrograman visual memungkinkan pengembang langsung merancang antarmuka di atas kanvas (*WYSIWYG - What You See Is What You Get*). 

Setelah struktur visual antarmuka selesai disusun, pengembang baru menambahkan logika pemrograman pada *code-behind* agar setiap elemen dapat merespons aksi pengguna.

### 🔄 Perbandingan Paradigma

```
+-------------------------------------------------------------------------+
|                      PEMROGRAMAN KONVENSIONAL                           |
|  [Tulis Kode UI Manual] ---> [Kompilasi / Run] ---> [Lihat Tampilan UI] |
+-------------------------------------------------------------------------+

+-------------------------------------------------------------------------+
|                        PEMROGRAMAN VISUAL                               |
|  [Drag & Drop Komponen] ---> [Pratinjau UI Langsung] ---> [Tulis Logic] |
+-------------------------------------------------------------------------+
```
| Dimensi Perbandingan | Pemrograman Berbasis Teks | Pemrograman Visual |
| :--- | :--- | :--- |
| **Konstruksi UI** | Didefinisikan murni melalui sintaks kode. | Disusun secara interaktif melalui kanvas visual. |
| **Umpan Balik Visual** | Memerlukan *build/run* untuk mengevaluasi layout. | Terlihat secara instan (*real-time preview*). |
| **Fokus Alur Kerja** | Pembentukan struktur data dan algoritma teks. | Harmonisasi tata letak grafis dan logika pemicu. |

---

## 📌 Modul 02: Ekosistem Windows Forms & Komponen Dasar

### 🧩 Elemen Kontrol Antarmuka

| Kontrol | Fungsi Utama |
| :--- | :--- |
| `Form` | Wadah utama (container) yang menampung seluruh komponen UI. |
| `Label` | Menampilkan teks statis atau informasi baca-saja (*read-only*). |
| `TextBox` | Menampung masukan data berbasis teks dari pengguna. |
| `Button` | Memicu pemicu kejadian (*event*) saat diklik oleh pengguna. |

---

### ⚡ Arsitektur Properti & *Event Handling*

1. **Atribut / Properti (`Properties`)**  
   Pengaturan karakteristik fisik dan identitas komponen (seperti `Name`, `Text`, `BackColor`, atau `Font`) yang dapat dikonfigurasi langsung via panel *Properties* IDE tanpa perlu koding.

2. **Penanganan Kejadian (`Event Handling`)**  
   Mekanisme yang mengeksekusi blok kode tertentu ketika terjadi aksi interaktif dari pengguna (contoh: `Click`, `TextChanged`, `KeyDown`).

---

## 📂 Alur Kerja Proyek Latihan Pertama

### 1. Inisialisasi Proyek
* Buka Visual Studio $\rightarrow$ **Create a new project**.
* Pilih template **Windows Forms App (.NET Framework)** berlabel **Visual Basic**.
* Atur nama proyek (contoh: `Lab02_WindowsForms`) dan direktori penyimpanan.

### 2. Layouting Kanvas (`Form1.vb [Design]`)
Tambahkan elemen-elemen berikut dari **Toolbox**:
* 3 Unit `Label` $\rightarrow$ Ubah teks masing-masing menjadi: `Nama`, `NIM`, dan `KOM`.
* 3 Unit `TextBox` $\rightarrow$ Set nama variabel: `txtNama`, `txtNIM`, `txtKOM`.
* 3 Unit `Button` $\rightarrow$ Set teks tombol: `Tampilkan`, `Hapus`, `Keluar`.

### 3. Implementasi Kode (`Form1.vb`)

```vb
Public Class Form1

    ' Event Handler: Menampilkan Data Pengguna
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Dim pesan As String = $"Guten Morgen{vbCrLf}" &
                             $"Nama  : {txtNama.Text}{vbCrLf}" &
                             $"NIM   : {txtNIM.Text}{vbCrLf}" &
                             $"KOM   : {txtKOM.Text}"
        
        MessageBox.Show(pesan, "Informasi Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Event Handler: Pengosongan Input Form
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNIM.Clear()
        txtKOM.Clear()
        txtNama.Focus()
    End Sub

    ' Event Handler: Menutup Aplikasi
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

End Class
