# Riwayat perubahan

## [3.2.0] - Belum dirilis

### Ditambahkan

- Inspector, operasi penyuntingan, dialog pemasangan, nama pose standar, dan menu VRChat yang dihasilkan kini tersedia dalam 30 bahasa.
- Pemilihan bahasa Inspector dan menu dalam permainan telah disatukan. Bahasa komputer digunakan pada awalnya, dan pilihan terakhir juga digunakan di proyek lain milik pengguna OS yang sama.
- README, riwayat perubahan, dan panduan luring kini dapat dibuka dalam bahasa terpilih.
- Nama tampilan 128 pose standar dan deskripsi setiap fitur disediakan sesuai istilah yang sudah ada.

### Kompatibilitas

- Pengaturan avatar yang ada, nama khusus, referensi aset, pengenal parameter, dan metode penyimpanan lisensi tetap dipertahankan.

## [3.1.2] - 2026-11-09

- Kunci kepala kini dapat dialihkan melalui “Pengaturan → Kunci Kepala Otomatis Saat Telentang” pada menu EX meskipun “Tinggi kaki” nonaktif. Item yang hilang dari avatar pada versi sebelumnya kembali setelah pembaruan dan build.
- Mendukung Unisaki Posing System 3.1.2. Memperbaiki wajah yang tetap menghadap ke atas setelah bangkit dari tengkurap saat “Kurangi perubahan pose akibat rotasi kepala” digunakan.

Perbarui Kawaii Posing Tool ke 3.1.2 melalui ALCOM / VCC. Unisaki Posing System 3.1.2 juga diperlukan. Jika sebelumnya menggunakan prabuild, tekan “Perbarui prabuild”, simpan Scene, lalu lakukan build dan unggah avatar kembali.

## [3.1.1] - 2026-11-08

- “Tinggi lantai” dan “Berguling” yang diaktifkan kini muncul di “Pengaturan” menu EX VRChat meskipun “Cerminkan” nonaktif.
- Meskipun pose diurutkan ulang, dihapus, atau diganti namanya di versi lama, gerakan berguling yang benar tetap diwariskan ke “Kaki Lurus”, “Rileks”, dan “Satu Lutut Naik”. Ini juga berlaku setelah Unpack sepenuhnya jika pose asli dapat dikenali. Pose buatan sendiri, berguling yang Anda nonaktifkan, dan gerakan menyamping pengganti tetap dipertahankan.
- Memperbaiki masalah ketika avatar sesaat tengkurap saat dipilih di VRChat. Memperbaiki juga masalah ketika avatar sesaat telentang saat melompat dengan hanya pose tengkurap dipilih. Peralihan dengan melompat dapat dinonaktifkan melalui “Fitur → Kemudahan → Beralih pose berbaring dengan melompat”. Secara bawaan fitur ini aktif.
- Jika referensi Animator Controller untuk pose bersama hilang setelah pembaruan dan dapat dipulihkan, peringatan ditampilkan dan Controller dibuat ulang dari pengaturan. Referensi Controller yang digunakan bersama beberapa avatar juga dipertahankan.
- Prefab resmi kini dapat ditambahkan melalui menu penambahan alat meskipun Anda menyimpan Prefab lain bernama “可愛いポーズ” (Kawaii Posing).
- Saat “Tambah 添い寝ツール” dipilih dan 添い寝ツール yang diperlukan untuk integrasi tidak ditemukan, alat menunjukkan produk yang harus dipasang terlebih dahulu.

Perbarui Kawaii Posing Tool dan Unisaki Posing System ke 3.1.1 melalui ALCOM / VCC. Jika sebelumnya menggunakan prabuild, tekan “Perbarui prabuild” pada “可愛いポーズ” (Kawaii Posing) di Scene, lalu simpan Scene. Untuk menerapkannya di VRChat, lakukan build dan unggah avatar kembali.

## [3.1.0] - 2026-11-07

- Dari 85 pose bawaan, 53 menyesuaikan posisi anggota tubuh secara otomatis dengan IK sesuai proporsi avatar.
- Pose tidur telentang “Kaki Lurus”, “Rileks”, dan “Satu Lutut Naik” kini mendukung berguling mengikuti kemiringan kepala.
- Mode foto memungkinkan penyesuaian posisi dan arah avatar. Sinkronisasi posisi dan arah serta tampilan kepala sendiri selama pemotretan juga dapat dipilih.
- “Tinggi lantai” dapat menggerakkan seluruh tubuh hingga 3m ke atas dan ke bawah, terpisah dari “Tinggi kaki”.
- Menambahkan animasi napas, pengaturan untuk menghentikan goyangan diam bawaan, serta pengurangan perubahan pose akibat arah leher.
- Fitur yang digunakan dan penggunaan parameter dapat diperiksa di Inspector. Menambahkan pencarian pose, penambahan sekaligus, pengurutan, dan pratinjau sederhana di Scene.
- Mempercepat peralihan berdiri, setengah jongkok, dan duduk dalam mode desktop.
- Memperbaiki peringatan prabuild setelah perubahan pengaturan, beban pengguliran Inspector, dan jeda panjang saat membersihkan hasil yang dihasilkan.
- Mendukung Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Beta terbuka (2026-11-05)

- Memulai distribusi beta terbuka melalui GitHub Releases dan VPM. Dari 85 pose bawaan, 53 menyesuaikan anggota tubuh dengan IK sesuai proporsi tubuh.
- Mendukung paket bersama 3.1.0-beta.2. Memperbaiki tampilan perubahan setelah prabuild, beban pengguliran Inspector, dan jeda saat pembersihan hasil.

## [3.1.0-beta.1] - Beta terbuka (2026-11-04)

- Mendukung Unisaki Posing System 3.1.0-beta.1.
- Mengubah peralihan pose normal dalam mode desktop menjadi satu evaluasi. Berlaku untuk build biasa dan prabuild; VR dan kondisi khusus tetap menggunakan jalur sebelumnya.
- Prabuild dari alpha.3 atau versi sebelumnya kini dikenali sebagai perlu diperbarui.
- Mempertahankan sudut pandang saat Tinggi lantai diubah selama pemotretan, lalu kembali ke Tinggi lantai terbaru setelah pemotretan selesai.
- Menyertakan perbaikan hingga alpha.3 untuk impor otomatis, penyesuaian gerakan impor, dan pengelolaan Controller hasil.

## [3.1.0-alpha.2] - Uji tertutup (2026-10-26)

### Perbaikan dan perubahan

- Memperbarui sistem pose bersama ke 3.1.0-alpha.2 dan menyertakan perbaikan debug.
- Memperluas Tinggi lantai menjadi 3m ke atas dan ke bawah. 50% adalah tinggi asli dan nilai awal.
- Menambahkan pose bawaan dan khusus saat tidak ada pilihan sebagai target koreksi Mode foto dan Tinggi lantai.
- Memperbaiki masalah koreksi manual, pose bernama sama, pose awal, dan pengaturan berguling prasetel lama.

## [3.1.0-alpha.1] - Sebelum publikasi

### Ditambahkan

- Menambahkan penyesuaian anggota tubuh otomatis (IK) sesuai proporsi tubuh.
- Menambahkan ON/OFF IK keseluruhan dan per pose serta perekaman hasil ke animasi penyesuaian.
- Pose tidur telentang “Kaki Lurus”, “Rileks”, dan “Satu Lutut Naik” mendukung berguling mengikuti kemiringan kepala.
- Menambahkan pengaturan berguling per pose dan pemilihan animasi menyamping.
- Menambahkan Mode foto untuk menyesuaikan perpindahan ke depan dan rotasi.
- Menambahkan pengaturan sinkronisasi Mode foto. Hanya lokal menggunakan 0 bit; sinkronisasi menggunakan 16 bit.
- Menambahkan pengaturan agar kepala avatar sendiri tetap terlihat selama Mode foto.
- Menambahkan “Tinggi lantai” untuk mengangkat seluruh tubuh termasuk kepala.
- Menambahkan animasi napas, pengaturan kekuatannya, dan menu ON/OFF dalam permainan.
- Menambahkan pengaturan Nonaktifkan goyangan diam VRChat.
- Menambahkan pengaturan Kurangi perubahan pose akibat rotasi kepala.
- Menambahkan pencegahan lutut menekuk terbalik dan pengaturan sudut tekukan minimum.
- Menambahkan ON/OFF per fitur dan tampilan penggunaan ExpressionParameters.
- Menambahkan pratinjau sederhana di Scene, pencarian pose, penambahan sekaligus, dan penentuan posisi tujuan.
- Menambahkan tampilan riwayat perubahan di Inspector.

### Diubah

- Menata Inspector dalam 3 tab: “Fitur”, “Pose”, dan “Pengaturan Avatar”.
- Menata lokasi rincian napas, impor gerakan sendiri, dan pengaturan prasetel.
- Mengurangi duplikasi animasi yang dihasilkan untuk penyesuaian Tinggi kaki.
- Menambahkan dialog konfirmasi pembaruan gambar pose dan mengumpulkan pengaturan peringatan dalam “Periksa pengaturan”.
- Menghapus menu penambahan baru versi 8bit dan menyatukannya dengan pilihan fitur pada Prefab biasa. Referensi yang ada dipertahankan.
- Mendukung Unisaki Posing System 3.1.0-alpha.1. Mengubah versi minimum VRChat Avatars SDK menjadi 3.10.4.

### Diperbaiki

- Memperbaiki input nama pose yang berpindah ke pose lain dan rincian yang tertutup saat pengurutan ulang.
- Memperbaiki pratinjau tumpang tindih, posisi penempatan bergeser, dan kesalahan pada avatar tertentu.
- Memperbaiki pembaruan peringatan/status prabuild setelah perubahan pengaturan serta beberapa kesalahan build.

## [3.0.13] - 2026-09-22
- Memperbarui PosingSystem ke 3.0.17 dan memperbaiki pergeseran horizontal pose akibat perubahan skala seragam seluruh avatar.
- Menambahkan pengaturan untuk mengabaikan peringatan langkah otomatis, prabuild belum dijalankan, dan perubahan pengaturan secara terpisah atau sekaligus.
- Memperbaiki animasi sekali putar yang tidak sesuai ikut diimpor saat impor manual gerakan perpindahan.

## [3.0.12] - 2026-09-15
- Menambahkan prasetel avatar (ルリエ).

## [3.0.11] - 2026-09-09
- Menambahkan prasetel avatar (メルヴィ, ミダリス).
- Memperbaiki penggantian gerakan pada prasetel うらら.

## [3.0.10] - 2026-08-31
- Memperbarui PosingSystem ke 3.0.11 untuk memperbaiki kegagalan prabuild pada NDMF terbaru dan pengecualian saat menampilkan kesalahan.

## [3.0.9] - 2026-08-29
- Memperbarui PosingSystem ke 3.0.10 untuk mengurangi beban pemuatan prasetel dan penentuan ikon Hierarchy.
- Memperbaiki kesalahan prabuild ketika beberapa sistem pose berada pada avatar yang sama.

## [3.0.8] - 2026-08-26
- Memperbarui PosingSystem ke 3.0.9 untuk memperbaiki Avatar pratinjau yang menjadi tidak valid setelah pemrosesan NDMF dan menyebabkan kegagalan `Avatar is null` saat Play.

## [3.0.7] - 2026-08-18
- Memperbarui PosingSystem ke 3.0.8 untuk memperbaiki kemungkinan data pose tidak valid saat koreksi ulang tinggi.

## [3.0.6] - 2026-08-12
- Menambahkan prasetel avatar (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Menambahkan prasetel avatar (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Menambahkan prasetel avatar (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Memperbaiki fitur pemasangan dan penghapusan lisensi.

## [3.0.2] - 2026-01-04
- Memperbaiki pemrosesan lisensi pada versi Mac dan Linux.

## [3.0.1] - 2025-12-28
- Menambahkan prasetel avatar (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Menambahkan fitur prabuild.
- Menambahkan fitur Penyesuaian Animasi.
- Menambahkan fitur prasetel.
- Memungkinkan penambahan ke proyek melalui unitypackage.
- Menambahkan prasetel avatar (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Menyelesaikan masalah kompatibilitas dengan beberapa alat.

## [2.2.4] - 2025-04-04
- Memperbaiki pose yang tidak dapat berubah pada kombinasi avatar dan versi ModularAvatar tertentu.

## [2.2.3] - 2025-03-13
- Memperbaiki gerakan yang tidak benar pada beberapa avatar, termasuk lompatan 森羅.
- Memperbaiki nilai awal Gestur mati yang terkadang tidak benar.

## [2.2.2] - 2025-03-06
- Memperbaiki kesalahan pada lingkungan tertentu.

## [2.2.1] - 2025-02-05
- Memperbaiki Unity yang mengalami crash.
- Menambahkan versi pada nama alat yang ditampilkan di NDMF Console.

## [2.2.0] - 2025-02-02
- Menambahkan pengaturan untuk menonaktifkan gestur dan menggunakan bentuk tangan animasi.
- Menambahkan data bentuk tangan ke semua pose.

## [2.1.6] - 2025-02-02
- Memperbaiki pose yang rusak saat digunakan bersama alat tertentu.
- Memperbaiki kesalahan akibat pengaturan tertentu.

## [2.1.5] - 2024-12-10
- Menyelesaikan konflik dengan beberapa alat.
- Menambahkan tombol penghapusan versi Unitypackage.
- Menghapus Prefabs integrasi 三点だいしゅきツール karena versi VCC-nya sudah dirilis.

## [2.1.4] - 2024-12-08
- Memperbaiki kesalahan pada avatar tertentu.
- Memperbaiki Kunci kaki yang tidak dapat digunakan akibat konflik dengan alat atau avatar.
- Memperbaiki pose avatar yang kembali ke pose bawaan VRC dalam mode desktop.

## [2.1.3] - 2024-12-01
- Memperbaiki pose yang tidak berubah jika digunakan bersama avatar atau alat yang menggunakan tipe VRMode yang salah.
- Menambahkan tampilan NDMF-Console untuk konflik antaralat akibat perbedaan tipe parameter.

## [2.1.2] - 2024-12-01
- Menambahkan penjelasan di NDMF-Console karena kesalahan alat lain menyebabkan kesalahan Unisaki Posing System saat build avatar.
- Memperbaiki kesalahan build pada beberapa avatar.
- Memperbaiki perilaku segera setelah avatar dimuat.
- Menghapus pemrosesan perpindahan asli avatar karena dapat mencegah alat bekerja pada avatar tertentu.

## [2.1.1] - 2024-11-20
- Memperbaiki masalah yang mencegah build.

## [2.1.0] - 2024-11-20
- Mengatasi kaki atau pinggul yang tenggelam ke lantai dalam mode desktop sehingga semua pose dapat ditampilkan dengan baik.
- Menambahkan fitur mengubah pose tanpa memperhitungkan tinggi kepala.
- Menambahkan mode tanpa pembuatan ikon untuk unggah avatar Quest.
- Menambahkan beberapa peringatan jika avatar bermasalah.
- Menyelesaikan konflik penguncian dengan AFK atau alat pengunci lengan lain.
- Menambahkan pengaturan kunci leher otomatis saat telentang.
- Mengubah ExpressionsMenu: memisahkan pemilihan pose ke folder dan memindahkan fungsi penguncian ke tingkat teratas.

## [2.0.0] - 2024-11-14
### Diperbaiki
- Mengubah menjadi paket VPM untuk mendukung VCC.
- Memperbaiki versi 8bit yang menggunakan 17bit.

## [1.15.0] - 2024-11-04
### Diperbaiki
- Memperbaiki kesalahan dan masalah.

## [1.14.0] - 2024-07-05
### Diperbaiki
- Memperbaiki masalah saat menggunakan VRCFury.

## [1.13.0] - 2024-04-11
### Diperbaiki
- Menambahkan pengaturan integrasi dengan “ごろ寝システムEX”.

## [1.12.0] - 2024-03-31
### Diperbaiki
- Memperbaiki alat yang tidak dapat digunakan pada status ExMenu tertentu.
- Menambahkan fitur pencerminan ke pengaturan.
- Memperbaiki pose kucing.
- Menambahkan ５ pose tidur menyamping.

## [1.11.0] - 2024-03-12
### Diperbaiki
- Memperbaiki pose yang menjadi tidak benar ketika posisi kepala tinggi.

## [1.10.0] - 2024-03-10
### Diperbaiki
- Menambahkan fitur pose berdiri dengan 15 jenis pose.
- Memperbaiki kaki yang bergerak sendiri pada avatar dan lingkungan tertentu.
- Menambahkan versi ExpressionParameters8bit.

## [1.9.0] - 2024-03-05
### Diperbaiki
- Memperbaiki kaki yang bergerak sendiri pada avatar tertentu.
- Menyeragamkan WriteDefaults.
- Menambahkan ７ pose setengah jongkok dan ８ pose duduk.

## [1.8.0] - 2024-02-25
### Diperbaiki
- Memperbaiki kegagalan unggah saat menggunakan ModularAvatar1.9.0 atau lebih baru.
- ModualrAvatar1.9.0 atau lebih baru kini diperlukan.

## [1.7.0] - 2024-02-23
### Diperbaiki
- Menambahkan fitur mengubah ambang tinggi kepala untuk setiap kategori pose.
- Memperbaiki pose atau kaki yang menjadi tidak benar, misalnya saat melompat, pada avatar tertentu.
- Mengurangi penggunaan bit ExpressionParameter dari 54 menjadi 16bit.

## [1.6.0] - 2024-02-20
### Diperbaiki
- Memperbaiki pose duduk yang tidak dapat diaktifkan dalam mode VR.

## [1.5.0] - 2024-02-18
### Diperbaiki
- Dalam mode desktop, pose duduk kini dapat digunakan sambil menahan tombol C.

## [1.4.0] - 2024-02-17
### Diperbaiki
- Memperbaiki integrasi 添い寝 yang tidak dapat digunakan tanpa integrasi 三点だいしゅき.
- Memperbaiki kaki yang terkunci saat melompat.

## [1.3.0] - 2024-02-16
### Diperbaiki
- Memperbaiki jumlah VRCContactSender/Receiver yang tidak wajar pada pengaturan.

## [1.2.0] - 2024-02-16
### Diperbaiki
- Memperbaiki kesalahan build saat unggah.

## [1.1.0] - 2024-02-15
### Diperbaiki
- Memperbaiki nilai bawaan yang tidak benar saat menggunakan beberapa Prefabs.
- Memperbaiki pengaturan integrasi 可愛い座り yang keliru.

## [1.0.0] - 2024-02-14
### Rilis
