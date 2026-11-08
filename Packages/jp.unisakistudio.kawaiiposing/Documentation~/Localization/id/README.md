# Kawaii Posing Tool

Alat pengunci pose untuk VRChat yang memungkinkan pose duduk dan berbaring imut, termasuk dengan pelacakan 3 titik atau desktop. Berisi total 85 pose: 15 berdiri, 20 setengah jongkok, 17 duduk, 16 tidur tengkurap, dan 17 tidur telentang.

README ini ditujukan untuk v3.2.0 yang sedang dikembangkan. Tanggal rilis resmi belum ditentukan. Versi terpasang dapat diperiksa di bagian atas Inspector.

- [Halaman produk BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Riwayat perubahan](CHANGELOG.md)

## Bahasa tampilan dan dokumen offline

Pilih bahasa melalui “Language / 言語” di bagian atas Inspector. Satu pilihan berlaku untuk Inspector dan menu VRChat yang dibuat. Unggah ulang avatar untuk mengubah bahasa di dalam gim.

Jika belum dipilih, bahasa komputer digunakan; bahasa yang tidak didukung memakai bahasa Inggris. Windows, macOS, dan Linux didukung. Pilihan terakhir disimpan di EditorPrefs dan digunakan di proyek lain milik pengguna OS yang sama pada komputer ini. Pilihan eksplisit yang sudah tersimpan pada avatar dipertahankan. Pilihan tidak disinkronkan ke komputer lain. Cara penyimpanan lisensi tidak berubah.

README, riwayat perubahan, dan panduan dapat dipilih melalui [daftar bahasa](../index.html) yang disertakan. Tombol panduan dan riwayat perubahan di Inspector juga mengikuti bahasa pilihan. Ketentuan asli dan terjemahan referensi tetap disediakan secara terpisah.

## Fitur utama

- Mode foto: memindahkan avatar hingga 3m ke depan dan menyesuaikan arahnya. Hanya pada layar sendiri menggunakan 0 bit; memperlihatkan posisi dan arah kepada orang lain menggunakan 16 bit.
- Tampilan kepala saat pemotretan: mencegah kepala avatar sendiri menghilang saat berada dekat, khusus selama Mode foto.
- Tinggi lantai: menggerakkan seluruh tubuh, termasuk kepala, 3m ke atas dan ke bawah. 50% adalah tinggi asli dan nilai awal, 0% berarti 3m lebih rendah, dan 100% berarti 3m lebih tinggi. Dapat digunakan terpisah dari “Tinggi kaki”, yang menggerakkan bagian kaki sambil mempertahankan posisi kepala.
- Berguling: berguling ke kiri dan kanan mengikuti kemiringan kepala pada pose berbaring yang didukung.
- Napas: menambahkan animasi napas pada dada dan bagian lain. Pilih “Tidak ada, Lemah, Sedang, Kuat, Cepat, Khusus” untuk setiap kategori pose.
- Nonaktifkan goyangan diam VRChat: mengurangi goyangan diam bawaan sambil tetap menggunakan animasi napas alat pose dan gerakan khusus lain.
- Kurangi perubahan pose akibat rotasi kepala: mengurangi perubahan pose ketika kunci leher dilepas dan arah leher berbeda dari pose asli.
- Pilihan fitur: hanya menambahkan menu dalam permainan yang diperlukan dan memeriksa penggunaan ExpressionParameters di Inspector.
- Pencarian, penambahan sekaligus, dan pengurutan daftar pose: mencari lintas kategori, memuat beberapa klip, dan menentukan posisi tujuan.
- Pratinjau sederhana di Scene: periksa pose langsung melalui “Pratinjau” dalam daftar pose.

- Penyesuaian anggota tubuh otomatis (IK): menyesuaikan posisi anggota tubuh dengan proporsi avatar pada pose yang didukung. Anda dapat mengaktifkan atau menonaktifkannya per pose serta merekam hasilnya ke animasi penyesuaian.

### Berguling dengan pose bawaan

Pose tidur telentang “Kaki Lurus”, “Rileks”, dan “Satu Lutut Naik” memiliki pose menyamping untuk berguling. Masing-masing menggunakan gerakan berguling berdasarkan pose tidur menyamping, “Tidur Siang”, dan “Tidur Kucing”.

Aktifkan “Fitur > Fitur menu > Berguling”, lalu unggah avatar. Di VRChat, pilih pose yang didukung dan “Berguling”. Gunakan dengan kunci leher dilepas.

Untuk menambahkan dukungan sendiri, aktifkan “Pose > Rincian > Aktifkan berguling” dan tentukan animasi pada “Pose berguling samping”. Pengaturan MotionTime biasa tidak tersedia untuk pose yang menggunakan berguling.

### Menyesuaikan dengan proporsi tubuh

Anda dapat menggunakan penyesuaian anggota tubuh otomatis bawaan, tetapi tidak semua pose memerlukan IK. Di layar Penyesuaian Animasi, gunakan “Aktifkan penyesuaian anggota tubuh otomatis” untuk keseluruhan dan “Aktifkan IK pose ini” untuk masing-masing pose.

“Rekam hasil IK ke penyesuaian” menulis hasil penyesuaian otomatis saat itu ke animasi penyesuaian baru dan menonaktifkan IK pose terkait. Setelah itu, Anda dapat menyempurnakannya secara manual. Tersedia ketika penyesuaian otomatis keseluruhan dan pose terkait aktif serta terdapat pengaturan IK yang dapat diterapkan.

“Pengaturan Avatar” juga berisi “Cegah lutut menekuk terbalik” dan “Tekukan lutut minimum (derajat)” pada rincian.

## Cara pemasangan

1. Unduh file dari halaman produk di toko tempat Anda membelinya.
2. Impor “可愛いポーズツール.unitypackage” yang disertakan ke Unity, lalu daftarkan lisensi dan sumber distribusi paket.
3. Dengan VCC atau ALCOM, tambahkan Kawaii Posing Tool dan Modular Avatar ke proyek Unity yang digunakan. Unisaki Posing System dan NDMF juga dipasang sebagai dependensi.
4. Klik kanan avatar tujuan di Hierarchy dan pilih “Unisaki Studio > Tambah Kawaii Posing”.
5. Pilih “可愛いポーズ” (Kawaii Posing) yang ditambahkan di dalam avatar, lalu atur fitur dan pose yang diinginkan di Inspector.
6. Unggah avatar seperti biasa.

Persyaratan: Unity 2022.3, VRChat Avatars SDK 3.10.4 atau lebih baru, Modular Avatar seri 1.x versi 1.15.1 atau lebih baru, dan NDMF seri 1.x versi 1.14.0 atau lebih baru. Perbarui juga paket yang diperlukan melalui VCC atau ALCOM.

## Memperbarui dari versi sebelumnya

Perbarui produk ini bersama Unisaki Posing System. Pengaturan alat yang sudah ditempatkan tetap dipertahankan. Periksa fitur yang digunakan dan penggunaan ExpressionParameters di Inspector. Jika sebelumnya menggunakan prabuild, tekan “Perbarui prabuild” sebelum mengunggah ulang.

Sejak v3.1.0, penambahan baru disatukan pada Prefab biasa “可愛いポーズ” (Kawaii Posing). Nonaktifkan item yang tidak diperlukan pada “Fitur” untuk konfigurasi minimum pemilihan pose saja sebesar 8 bit. Konfigurasi dengan banyak pose mungkin memerlukan bit tambahan untuk pemilihan pose.

Prefab 8bit lama tetap berada di “Editor/Legacy” untuk mempertahankan referensi avatar dan prasetel yang sudah ada. Prefab yang ada tidak perlu dihapus atau diganti. Versi 8bit tidak muncul dalam menu penambahan baru Unity.

## Lokasi pengaturan

| Tab | Kegunaan |
| --- | --- |
| Fitur | Menambah menu dalam permainan, kemudahan, pengaturan napas, gambar ikon, dan pemeriksaan penggunaan ExpressionParameters |
| Pose | Memilih pose, pengaturan rinci, pencarian, penambahan sekaligus, pengurutan, pratinjau, dan Penyesuaian Animasi |
| Pengaturan Avatar | Koreksi khusus avatar dan lutut, impor pose asli atau gerakan sendiri, dan penggantian prasetel |

Tekan “Buka pengaturan” untuk membuka pengaturan rinci di bawah item tersebut. Atur napas melalui “Fitur > Kemudahan > Animasikan napas”.

“Gunakan pose berdiri, jongkok, dan tengkurap asli” mengimpor pose yang sudah ada pada avatar secara otomatis. Untuk menggunakan gerakan sendiri, buka pengaturan terpisah “Buka pengaturan impor” dan tentukan gerakan bagi setiap jenis, seperti berdiri, jongkok (Crouching), dan tengkurap (Prone).

Prasetel berada di bagian paling bawah “Pengaturan Avatar”. “Terapkan prasetel ini” mengganti pengaturan pose saat ini, jadi simpan penyesuaian yang sudah dibuat sebelum beralih.

### Penggunaan per fitur

- Animasi napas menggunakan 0 bit. Hanya jika menggunakan “Fitur menu > Napas” untuk menghentikan dan melanjutkannya dalam permainan, sinkronisasi ON/OFF menggunakan 1 bit.
- Mode foto menggunakan 0 bit jika hanya terlihat pada layar sendiri. Memilih “Kemudahan > Sinkronkan mode foto” menggunakan 16 bit. “Tetap tampilkan kepala dalam mode foto” menggunakan 0 bit.
- “Tinggi kaki” dan “Tinggi lantai” masing-masing menggunakan 8 bit. Tinggi lantai menggerakkan tubuh ke atas atau ke bawah saat digeser dari tengah, dan koreksi berakhir saat dikembalikan mendekati 50%.
- “Berguling” sendiri menggunakan 10 bit. Fitur ini berbagi 1 bit dengan “Kurangi perubahan pose akibat rotasi kepala”, sehingga penggunaan keduanya tetap berjumlah 10 bit.
- “Cerminkan” dan “Gestur mati” masing-masing menggunakan 1 bit.

Jumlah di Inspector hanya mencakup alat pose yang dipasang pada avatar. Alat lain, seperti pakaian, tidak termasuk. Jika menggunakan beberapa alat pose, pengaturan bersama tidak dihitung dua kali.

### Pratinjau dan penyuntingan pose

Gunakan “Pratinjau” pada setiap pose dalam “Pose” untuk menampilkan pose di Scene. Untuk penyempurnaan, buka “Penyesuaian Animasi”, sesuaikan sambil memeriksa pose, lalu simpan.

Pratinjau sederhana tidak menjalankan proses build MA atau NDMF. Periksa juga pakaian dan koreksi posisi lantai yang diterapkan saat build melalui hasil build sebelum unggah.

Cari nama pose melalui tab kaca pembesar di kiri. Pilih posisi tujuan pada “Urutan” di “Rincian”, atau gunakan tombol naik/turun untuk mengurutkan ulang. Tambahkan beberapa animasi sekaligus dengan menyeret dan melepasnya ke area penambahan atau menggunakan “Muat klip yang dipilih di Project”.

“Perbarui gambar mini pose” membuat gambar setelah dialog konfirmasi. “Buat ikon pose” membantu mengenali pose dalam menu permainan, tetapi pembuatan gambar menambah waktu build. Untuk mengurangi ukuran, pilih “Kurangi ukuran ikon”. Ikon pose tidak dibuat untuk Android.

## Kontrol dasar dalam permainan

- Pilih pose dari setiap kategori melalui menu Expressions. Dalam VR, kategori berdiri, setengah jongkok, duduk, dan berbaring beralih sesuai tinggi kepala.
- Dalam pose berbaring, arah wajah menentukan telentang atau tengkurap. Jika keduanya dipilih, melompat di tempat juga dapat menggantinya. Peralihan dengan melompat dapat dinonaktifkan di Unity melalui “Fitur → Kemudahan → Beralih pose berbaring dengan melompat” (aktif secara bawaan). Tinggi peralihan kategori dapat disesuaikan melalui nilai ambang di menu pengaturan.
- Di desktop, ganti pose dengan tombol C dan Z. Jika tombol Z tidak mengaktifkan pose berbaring, naikkan ambang tinggi berbaring di menu pengaturan.
- Aktifkan “Gestur mati” untuk memakai bentuk tangan yang diatur pada pose, menggantikan bentuk jari dari pengontrol.
- “Tinggi kaki” menyesuaikan bagian kaki sambil mempertahankan posisi kepala. “Tinggi lantai” menggerakkan seluruh tubuh termasuk kepala ke atas dan ke bawah. Keduanya muncul dalam urutan ini di menu pengaturan.
- Jika bergerak ke depan melalui “Jarak” dalam “Mode foto”, avatar menghadap Anda. Putar dengan “Arah” dan aktifkan “Kunci kaki” saat diperlukan. “Keluar foto” mengembalikan jarak serta arah dan melepas kunci kaki.
- “Napas” tersedia jika animasi napas aktif. Kekuatan diatur di Unity, sedangkan ON/OFF dialihkan dalam permainan.

## Prabuild dan peringatan

“Perbarui prabuild” menggunakan kembali data yang dihasilkan untuk mempercepat build avatar. Tanpa prabuild pun, data yang diperlukan dibuat saat build biasa.

Setelah pengaturan berubah, “Periksa pengaturan” di bagian atas Inspector dan tanda Hierarchy memberi tahu bahwa pembaruan diperlukan. “Tampilan peringatan” berada dalam panel “Periksa pengaturan”. Menyembunyikannya tidak menyelesaikan masalah pengaturan atau memperbarui data yang dihasilkan.

## Catatan penggunaan

- Penguncian pose selama pelacakan seluruh tubuh tidak didukung.
- Penyesuaian tambahan mungkin diperlukan sesuai proporsi tubuh, pakaian, dan modifikasi avatar.
- Integrasi dengan layer Base khusus atau alat pengubah pose lain mungkin tidak bekerja sesuai harapan. Jika penguncian bermasalah, periksa juga “Pengaturan Avatar > Integrasikan kunci pelacakan dengan alat lain”.
- Perpindahan serta rotasi Mode foto dan Tinggi lantai juga mengoreksi gerakan bawaan dan khusus ketika tidak ada pose yang dipilih. Periksa sudut pandang dan perilaku setelah penggantian gerakan bawaan dalam VRChat pada perangkat sebenarnya.
- “Nonaktifkan goyangan diam VRChat” hanya menargetkan gerakan diam bawaan, bukan semua goyangan dari penyebab lain.

## Panduan dan dukungan

Buka panduan, dukungan, dan riwayat perubahan melalui “Bantuan / riwayat perubahan” di bagian atas Inspector. Penjelasan rinci fitur bersama juga tersedia melalui “Packages > Unisaki Posing System > README” di Project Unity.

- [Panduan resmi](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Hubungi kami](https://help.unisakistudio.jp/)

Saat melaporkan masalah, sertakan versi produk ini dan Unisaki Posing System, versi Unity, VRChat SDK, Modular Avatar, dan NDMF, avatar yang digunakan, langkah untuk mengulangi masalah, serta rincian kesalahan Console.

## Distribusi prasetel

Informasi berikut berlaku untuk data yang dibuat dengan fitur Penyesuaian Animasi.

File animasi penyesuaian yang dibuat dengan fitur ini dan prasetel yang dibuat dengan file tersebut
boleh didistribusikan dan dijual secara bebas tanpa meminta izin Unisaki Studio.
Silakan bagikan, misalnya bersama avatar buatan sendiri atau sebagai prasetel untuk avatar yang tidak disertakan dalam alat ini.

## Produk dengan pengaturan integrasi bawaan

※ Pengaturan integrasi dibuat atas inisiatif toko kami. Kami menganggap izin pembuat produk terkait tidak diperlukan dan tidak memintanya.
Untuk meminta distribusi pengaturan integrasi atau penghentian distribusinya, kirim pesan melalui toko.
Penggunaan pengaturan integrasi memerlukan pembelian atau pengunduhan produk yang diintegrasikan.
Jika terjadi masalah pengaturan, hubungi toko kami, bukan pembuat masing-masing produk.

“可愛い座りツール”
https://yunisaki.booth.pm/items/3611536

“添い寝ツール”
https://yunisaki.booth.pm/items/3670993

“少女モーション集vol.1” oleh ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

“VRC想定移動モーション（無料配布）” oleh カトのVRC道具屋
https://booth.pm/ja/items/1285101

“ごろ寝システムEX” oleh minminmart
https://minminmart.booth.pm/items/4233545

## Ketentuan penggunaan

Alat ini hanya dapat digunakan oleh mereka yang menyetujui ketentuan penggunaan berikut, yang dibuat dengan lisensi VN3.

[Ketentuan penggunaan (bahasa Jepang)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Kode sumber dan sumber daya repositori ini bukan sumber terbuka. Diperlukan pembelian produk secara sah dan persetujuan atas ketentuan penggunaan.

[Ketentuan penggunaan (bahasa Inggris)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
