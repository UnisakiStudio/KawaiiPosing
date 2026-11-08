# Kawaii Posing Tool — Panduan Pengguna Bahasa Indonesia

Kawaii Posing menyediakan 85 pose untuk desktop dan VR tiga titik: 15 berdiri, 20 jongkok/kursi, 17 duduk di lantai, 17 berbaring telentang, dan 16 berbaring tengkurap.

Panduan ini mencakup pemasangan, pengaturan avatar, kontrol VRChat, penyuntingan pose, pembaruan, dan pemecahan masalah. ZIP yang dibeli berisi `START_HERE.html` untuk jalur pemasangan tercepat.

## Sebelum memulai

- Gunakan proyek **avatar** VRChat Unity 2022.3 yang dibuat atau dikelola dengan VRChat Creator Companion (VCC) atau ALCOM.
- Paket yang diperlukan: VRChat Avatars SDK 3.10.4 atau lebih baru; Modular Avatar 1.x, versi 1.15.1 atau lebih baru; dan NDMF 1.x, versi 1.14.0 atau lebih baru.
- Alat ini ditujukan untuk avatar Humanoid dalam mode desktop dan VR tiga titik (headset dan dua pengontrol). Penguncian pose saat pelacakan seluruh tubuh aktif tidak didukung.
- Cadangkan proyek yang ada sebelum pemasangan atau pembaruan. Selesaikan terlebih dahulu kesalahan kompilasi Unity yang masih ada.
- Penginstal mengunduh produk dan dependensi dari repositori paketnya. Diperlukan koneksi internet. Model avatar, VRChat SDK, Modular Avatar, dan NDMF tidak disertakan dalam ZIP ini.

## 1. Memasang lisensi dan produk

1. Ekstrak seluruh ZIP ke folder biasa di luar proyek Unity.
2. Buka proyek avatar tujuan di Unity. Impor `Installer/KawaiiPosing_Installer.unitypackage` melalui **Assets > Import Package > Custom Package**, atau buka file dengan Unity.
3. Baca petunjuk impor dan pemasangan. Konfirmasi lisensi menjelaskan lisensi produk yang akan dipasang. Gunakan **Bahasa…** (atau **言語...**) dalam dialog konfirmasi untuk mengganti bahasa penginstal.
4. Konfirmasikan pemasangan lisensi. Lisensi juga mencakup Unisaki Posing System bersama yang digunakan produk ini. Penginstal dapat menawarkan penghapusan file penyiapannya sendiri setelah selesai; pembersihan ini tidak menghapus lisensi produk yang terpasang.
5. Periksa konfirmasi penginstal paket otomatis. Daftar mencakup paket dan repositori yang akan ditambahkan serta file atau folder lama yang diusulkan untuk dihapus. Lanjutkan jika item tersebut sesuai tujuan Anda.
6. Tunggu hingga Unity selesai mengimpor dan mengompilasi. Jika pemasangan paket tidak selesai otomatis, buka proyek ini di VCC atau ALCOM lalu tambahkan **Kawaii Posing Tool** dan **Modular Avatar**. **Unisaki Posing System** bersama dan **NDMF** adalah dependensi. `Optional-VCC-Links` berisi pintasan repositori asli yang disertakan bersama produk untuk pengguna VCC Windows.
7. Jika konfirmasi dibatalkan, impor penginstal lagi saat siap. Anda juga dapat memakai perintah pemasangan lisensinya di **Tools > Unisaki Studio** selama aktivator masih ada. Pada build lama, submenu ini bernama **ゆにさきスタジオ**.

### Yang dipasang oleh unduhan ini

**Kawaii Posing Tool 3.2.0 dengan Unisaki Posing System 3.2.0.** Versi ini masih dikembangkan dan belum dirilis. Versi ini menambahkan dialog pemasangan, Inspector dan menu Unity, nama pose standar, menu dalam permainan, serta dokumentasi luring dalam tiga puluh bahasa. Tanggal rilis belum ditentukan. Gunakan pemilih bahasa di bagian atas Inspector untuk mengganti bahasa alat. Setelah dipublikasikan, penginstal akan mengunduh versi tersebut beserta dependensi yang kompatibel dari repositori VPM. Persiapan rilis lokal tidak memublikasikan paket tersebut.

Kawaii Posing Tool berisi pustaka pose, alat konfigurasi, dan prasetel penyesuaian avatar. Penginstal mengaktifkan lisensi lokal produk yang sudah ada; tidak diperlukan kolom kunci lisensi Gumroad baru. Jangan pernah memposting file penginstal atau data lisensi dalam permintaan dukungan publik.

Preferensi bahasa disimpan melalui Unity EditorPrefs untuk pengguna OS saat ini dan digunakan bersama antarproyek Unity pada komputer ini. Jika belum ada preferensi tersimpan, penginstal mengikuti bahasa OS; bahasa yang tidak didukung menggunakan bahasa Inggris. Lisensi produk mempertahankan penyimpanan yang ada: kunci registri `Software/UnisakiStudio` pengguna saat ini di Windows dan file lisensi per pengguna di macOS/Linux. Mengubah bahasa tidak menghapus lisensi.

## 2. Menambahkan alat ke avatar

1. Di **Hierarchy**, pilih avatar yang memiliki **VRC Avatar Descriptor**, atau salah satu anaknya. Gunakan avatar yang ditempatkan di Scene, bukan aset prefab dalam jendela Project atau Prefab Mode.
2. Klik kanan avatar dan pilih **Unisaki Studio > Tambah Kawaii Posing**. Jika build terpasang menggunakan menu Jepang, pilih **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Alat ditambahkan di dalam avatar. Nama objek tersimpannya mungkin tetap **可愛いポーズ** meskipun label tampilan diterjemahkan.
4. Jika prasetel avatar yang cocok ditawarkan, terapkan sebagai penyesuaian awal. Jika tidak, buka **Pengaturan Avatar** lalu pilih prasetel atau sesuaikan pose sendiri.
5. Penginstal dapat menawarkan prabuild. Prabuild bersifat opsional; build avatar biasa juga menghasilkan data yang diperlukan. Gunakan kembali prabuild untuk mengurangi waktu build berikutnya.
6. Pilih objek alat, tentukan pose serta fitur yang diinginkan, lalu unggah avatar seperti biasa melalui VRChat SDK.

### Pemilihan bahasa dan label yang dikenal

Versi ini menyediakan **Language / 言語** di bagian atas Inspector alat. Satu pilihan tersebut mengatur Inspector dan menu dalam permainan yang dihasilkan. Avatar menyimpan bahasa pilihannya, dan pilihan terakhir diingat untuk alat/proyek lain di komputer ini. Unggah ulang avatar untuk mengubah bahasa yang terlihat di VRChat.

Gunakan tabel label berikut saat mengikuti tutorial Jepang versi lama. Versi ini mencakup pemilih bahasa, Inspector yang dilokalkan, nama pose standar terjemahan, dan menu dalam permainan untuk semua 30 bahasa.

| Label bahasa Indonesia | Label Jepang pada build lama |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Fitur | 機能 |
| Pose | ポーズ一覧 |
| Pengaturan Avatar | アバター調整 |
| Buka pengaturan | 設定を開く |
| Perbarui prabuild | プレビルドを更新 |
| Periksa pengaturan | 設定の確認 |
| Pratinjau | プレビュー |
| Penyesuaian Animasi | アニメーション調整 |
| Muat ulang | 再読込 |

Inspector, dialog editor/pemasangan, nama pose standar, dan menu yang dihasilkan memiliki terjemahan untuk semua 30 bahasa yang dapat dipilih. README, riwayat perubahan, dan panduan luring disediakan dalam setiap bahasa tersebut. Nama avatar, nama objek tersimpan, nama pose khusus, nama file aset, dan pengenal parameter internal dapat mempertahankan ejaan aslinya.

[Referensi singkat 30 bahasa](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) mencakup penjelasan fitur dan tabel nama pose standar. Ini merupakan referensi ringkas; gunakan indeks bahasa untuk dokumentasi lengkap.

## 3. Memilih pose dan fitur

Inspector memiliki tiga tab utama:

| Tab | Kegunaan |
| --- | --- |
| **Fitur** | Kontrol menu dalam permainan, perilaku opsional, napas, pilihan ikon, dan penggunaan parameter ekspresi. |
| **Pose** | Pose aktif, kategori/pencarian, pengurutan, penambahan animasi, pratinjau, rincian, dan penyesuaian animasi. |
| **Pengaturan Avatar** | Koreksi khusus avatar dan lutut, impor gerakan asli/khusus, dan prasetel. |

Aktifkan hanya kontrol menu yang akan digunakan. Misalnya, menambahkan **Cerminkan** ke menu memungkinkan Anda mengganti pencerminan di VRChat; ini tidak memaksa semua pose tetap dicerminkan.

Kawaii Posing mencakup prasetel avatar dan IK untuk pose yang didukung. Tiga pose standar telentang sudah memiliki gerakan menyamping: **Kaki Lurus (足伸ばし)**, **Rileks (リラックス)**, dan **Satu Lutut Naik (膝立て)**. Gunakan prasetel yang cocok dan periksa pengaturan berguling setiap pose jika entri tersebut telah diedit atau diganti.

### Prasetel dan penyesuaian kecocokan

Prasetel berada dekat bagian bawah **Pengaturan Avatar**. Cari berdasarkan nama avatar, lalu terapkan prasetel untuk mengganti pengaturan pose saat ini. Simpan atau cadangkan penyesuaian sebelum mengganti prasetel. Prasetel adalah titik awal: proporsi tubuh, pakaian, dan modifikasi avatar mungkin tetap memerlukan koreksi manual.

Gunakan **Penyesuaian Animasi** pada pose untuk melihat pratinjau dan mengedit posisi tubuh/anggota tubuh. Simpan animasi penyesuaian dari jendela itu setelah selesai. Jika didukung, penyesuaian tangan dan kaki otomatis (IK) dapat diaktifkan secara keseluruhan dan per pose. Merekam hasil IK saat ini ke penyesuaian membuat animasi penyesuaian dan menonaktifkan IK pose tersebut agar dapat disempurnakan manual; klip sumber asli dipertahankan.

**Cegah lutut menekuk terbalik** memiliki pengaturan tambahan, seperti sudut tekukan lutut minimum. Koreksi khusus avatar hanya tersedia jika data koreksi yang sesuai ada, dan beberapa koreksi tidak dapat digabungkan dengan IK pose.

### Gerakan asli dan khusus

**Gunakan pose berdiri, jongkok, dan tengkurap asli** mendeteksi gerakan dari layer Base avatar saat pembuatan. **Gunakan gerakan sendiri** membuka pengaturan impor terpisah untuk setiap jenis gerakan. Pilih satu gerakan per jenis. Pilihan manual diprioritaskan dibanding impor otomatis untuk jenis itu.

Impor otomatis diterapkan pada salinan build. Hasil deteksi animasi tidak ditulis kembali ke daftar pilihan manual di Scene dan Controller asli tidak diubah. Hapus pilihan manual suatu jenis jika ingin deteksi otomatis menanganinya lagi. Layer Base khusus dan sistem perpindahan lain mungkin memerlukan penyesuaian tersendiri.

## 4. Menggunakan alat di VRChat

Buka menu **Expressions** avatar dan masuk ke **Kawaii Posing**. Pilih satu pose untuk setiap kategori posisi tubuh yang ingin digunakan. Memilih pose dan memilih fitur merupakan tindakan terpisah.

- **VR tiga titik:** turunkan atau naikkan kepala untuk beralih antara berdiri, jongkok/kursi, duduk di lantai, dan berbaring. Sesuaikan ambang tinggi di menu pengaturan alat jika pergantian terjadi terlalu awal atau terlambat.
- **Desktop:** gunakan **C** untuk jongkok dan **Z** untuk berbaring. Jika Z membuat Anda tetap duduk, naikkan ambang tinggi berbaring di menu pengaturan.
- **Tengkurap/telentang:** alat memakai arah wajah untuk memilih tengkurap atau telentang. Jika keduanya dipilih, melompat di tempat dapat menggantinya. Jika diinginkan, nonaktifkan peralihan dengan melompat di **Fitur > Kemudahan** Unity; fitur ini tidak menambah penggunaan parameter tersinkron.
- **Penguncian:** gunakan kunci kepala, lengan, dan kaki sesuai kebutuhan. Nonaktifkan gestur jika ingin memakai bentuk tangan pose, bukan input gestur pengontrol.
- **Cerminkan:** balik pose terpilih agar menghadap teman atau sesuai komposisi.

### Tinggi kaki dan Tinggi lantai

**Tinggi kaki** menyesuaikan kaki sambil mempertahankan posisi kepala. Gunakan jika kaki melayang atau tenggelam padahal kepala sudah berada pada tinggi yang benar.

**Tinggi lantai** menggerakkan seluruh tubuh termasuk kepala. Gunakan untuk sofa, tempat tidur, atau permukaan tinggi, termasuk furnitur tanpa collider. Pada kontrol terpusat sistem bersama saat ini, **50% adalah tinggi asli**, 0% berarti 3 m lebih rendah, dan 100% berarti 3 m lebih tinggi. Kembalikan mendekati 50% untuk mengakhiri pergeseran. Rilis lama mungkin memiliki perilaku kontrol berbeda; periksa versi terpasang dan perbarui sistem bersama bersamaan dengan produk.

### Mode foto

Aktifkan item menu **Mode foto** di Unity sebelum mengunggah. Di VRChat, pilih pose, gunakan **Jarak** untuk bergerak hingga 3 m ke depan, dan gunakan **Arah** untuk memutar avatar. Kunci kaki bersifat opsional saat mengatur foto. **Keluar foto** mengembalikan jarak/rotasi dan melepas kunci kaki.

Mode foto secara bawaan hanya lokal. Untuk memperlihatkan posisi dan rotasi kepada orang lain, aktifkan **Sinkronkan mode foto** di Unity sebelum mengunggah; ini menggunakan 16 bit tersinkron. **Tetap tampilkan kepala dalam mode foto** memengaruhi tampilan sendiri dan tidak menggunakan bit tersinkron.

### Napas dan berguling

Napas dapat diatur per kategori pose melalui **Fitur > Kemudahan > Animasikan napas**. Pilih Tidak ada, Lemah, Sedang, Kuat, Cepat, atau animasi napas Khusus. Gerakannya sendiri tidak menggunakan bit tersinkron. Tombol menu napas menggunakan 1 bit.

Berguling memerlukan pose berbaring yang didukung dan item menu **Berguling**. Aktifkan berguling untuk pose tersebut dan berikan animasi menyampingnya jika diperlukan. Di VRChat, pilih pose itu, aktifkan berguling, lalu lepas kunci kepala/leher. Kemiringan kepala ke samping kemudian mengatur gerakan berguling. Kontrol MotionTime biasa tidak tersedia untuk pose tersebut selama berguling digunakan.

Tiga pose standar telentang yang disebutkan di atas mencakup gerakan menyamping. Pose lain memerlukan gerakan serta pengaturan pose yang sesuai. Prasetel impor/khusus dapat memiliki pilihan gerakan berbeda.

## 5. Mengedit, menambah, dan melihat pratinjau pose

Dalam **Pose**, pilih kategori atau gunakan tab pencarian. Pencarian menerima nama Jepang asli dan terjemahan yang tersedia. Buka **Rincian** pose untuk mengedit animasi, ikon, urutan, dan pilihan waktunya.

Untuk menambah beberapa animasi, seret klip ke area penambahan atau pilih klip di jendela Project lalu gunakan perintah impor klip terpilih. Referensi duplikat ke klip yang sama dihapus. Ubah posisi tujuan dalam Rincian atau gunakan kontrol naik/turun.

**Pratinjau** menampilkan pose di Scene tanpa membuka jendela penyesuaian lengkap. Pratinjau ringan ini tidak menjalankan Modular Avatar atau NDMF, jadi periksa hasil build akhir avatar untuk pakaian, koreksi lantai, dan fitur saat build lainnya.

Ikon pose yang dibuat dari avatar membantu mengenali pose, tetapi pembuatannya memerlukan waktu dan dapat menambah ukuran data avatar. Kurangi resolusi ikon untuk menghemat ruang. Build Android tidak membuat ikon pose. Buat ulang ikon setelah mengubah avatar atau pakaian jika diperlukan.

## 6. Memori parameter

Inspector menunjukkan penggunaan alat pose, bukan jumlah seluruh avatar. Pakaian dan sistem lain dapat menggunakan memori parameter tambahan. Pengaturan bersama beberapa alat pose tidak dihitung dua kali. Konfigurasi khusus dengan banyak pose tambahan mungkin memerlukan lebih banyak bit pemilihan pose.

| Fitur | Bit tersinkron tambahan |
| --- | ---: |
| Pemilihan pose, konfigurasi standar minimum | 8 |
| Cerminkan | 1 |
| Gestur mati | 1 |
| Animasi napas | 0 |
| Tombol menu Napas | 1 |
| Tinggi kaki | 8 |
| Tinggi lantai | 8 |
| Mode foto, hanya lokal | 0 |
| Sinkronkan mode foto | 16 |
| Tetap tampilkan kepala dalam mode foto | 0 |
| Nonaktifkan goyangan diam VRChat | 0 |
| Berguling | 10 |

Berguling berbagi 1 bit dengan koreksi pose akibat arah leher: mengaktifkan keduanya tetap menggunakan total 10 bit untuk dua fitur tersebut. Penggunaan yang ditampilkan pada versi terpasang menjadi acuan praktis untuk konfigurasi terpilih.

## 7. Pembaruan dan prabuild

1. Cadangkan proyek dan simpan Scene yang sedang dikerjakan.
2. Di VCC atau ALCOM, perbarui **Kawaii Posing Tool** dan **Unisaki Posing System** bersama secara bersamaan. Pastikan versi SDK, Modular Avatar, dan NDMF yang diperlukan tetap kompatibel.
3. Tunggu hingga kompilasi selesai. Pilih alat yang sudah dipasang lalu periksa pose, pengaturan, dan penggunaan parameternya.
4. Jika menggunakan prabuild, pilih **Perbarui prabuild**, lalu unggah avatar lagi.

Pengaturan alat yang ada dipertahankan. Prefab 8-bit lama tetap tersedia untuk kompatibilitas; referensi yang ada tidak mengharuskan alat dihapus/diganti. Pemasangan baru menggunakan prefab biasa, dan fitur yang tidak digunakan dapat dinonaktifkan untuk mengurangi penggunaan parameter.

Peringatan prabuild usang berarti pengaturan telah berubah sejak data build cache dihasilkan. Memperbarui prabuild membuat ulang data itu. Menyembunyikan peringatan tidak memperbarui prabuild atau menyelesaikan penyebabnya. Build avatar biasa dapat membuat data yang diperlukan meskipun Anda tidak melakukan prabuild manual setiap kali.

## 8. Pemecahan masalah

| Gejala | Yang perlu diperiksa |
| --- | --- |
| Menu penambahan alat tidak ada | Pastikan produk **dan** Unisaki Posing System sudah dipasang, dan selesaikan kesalahan kompilasi Console Unity. Penginstal lisensi saja bukan pustaka pose. |
| Penginstal dibatalkan atau file dihapus | Impor kembali penginstal yang dibeli saat siap. Baca kembali konfirmasinya. |
| Lisensi tampak hilang di proyek lain | Impor penginstal yang dibeli dengan akun OS yang sama. Jika komputer/akun berubah, pasang lisensi juga di sana. Preferensi bahasa tidak otomatis berpindah antarkomputer. |
| Tidak ada pose di VRChat | Tambahkan alat di bawah avatar Scene yang benar, aktifkan pose yang diinginkan, periksa peringatan Inspector, lalu unggah avatar tersebut. Periksa SDK dan alat perpindahan lainnya. |
| Z tidak mencapai posisi berbaring | Naikkan ambang tinggi berbaring dalam pengaturan alat di permainan. |
| Tangan atau lutut tidak sejajar | Coba prasetel avatar yang cocok, lalu gunakan IK yang didukung dan/atau Penyesuaian Animasi. Periksa deformasi pakaian dalam build akhir. |
| Berguling tidak bekerja | Gunakan pose berbaring yang didukung, aktifkan pengaturan berguling pose dan item menunya, lalu lepas kunci kepala/leher. Coba salah satu dari tiga pose standar yang didukung terlebih dahulu. |
| Teman tidak melihat gerakan foto | Aktifkan **Sinkronkan mode foto** di Unity, periksa penggunaan parameter, lalu unggah lagi. |
| Bahasa berubah di Unity tetapi tidak di VRChat | Unggah ulang avatar. Periksa pemilih bahasa tunggal di bagian atas Inspector pada build yang mendukung pelokalan. |
| Kesalahan build/prabuild | Baca kesalahan Console **pertama** yang relevan. Cadangkan Scene, perbarui/peroleh kembali produk dan sistem bersama melalui VCC/ALCOM, lalu hubungi dukungan jika masalah berlanjut. Pertahankan objek yang sudah disesuaikan dan GeneratedResources kecuali dukungan memberikan langkah pemulihan khusus. |

Untuk dukungan, sertakan versi produk/sistem bersama, versi Unity/SDK/Modular Avatar/NDMF, nama avatar, langkah tepat untuk mengulangi masalah, dan kesalahan Console yang relevan. Hapus file pribadi, isi penginstal, nilai lisensi, dan rincian akun dari posting publik.

- [Dukungan](https://help.unisakistudio.jp/)
- [Panduan daring bergambar (bahasa Jepang)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Halaman produk Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Lisensi dan kredit

[Terjemahan referensi bahasa Inggris dari perjanjian produk](../../Terms.en.html) disertakan bersama perjanjian asli bahasa Jepang.

Baca perjanjian produk asli dan perjanjian sistem bersama di samping README paket atau dalam folder `Licenses` pada ZIP yang dibeli. Perjanjian Unisaki Posing System bahasa Inggris yang disediakan merupakan terjemahan referensi sistem tersebut yang sudah ada; perjanjian produk bahasa Jepang tetap disertakan secara terpisah. Panduan ini tidak mengubah perjanjian atau memberikan hak tambahan. Hubungi dukungan untuk pertanyaan tentang penggunaan atau distribusi ulang data produk.

Penginstal menyertakan **VPMPackageAutoInstaller** yang dimodifikasi karya **anatawa12**, beserta **SimpleJson** dan **semver.net**. Pemberitahuan hak cipta dan teks lisensi MIT-nya terdapat dalam `ThirdPartyNotices.txt` pada ZIP yang dibeli. Pustaka pose dan sumber daya produk lain memiliki lisensi produknya sendiri.
