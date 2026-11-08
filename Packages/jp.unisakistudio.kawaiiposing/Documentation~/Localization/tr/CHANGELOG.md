# Değişiklik geçmişi

## [3.2.0] - Yayınlanmadı

### Eklenenler

- Inspector, düzenleme işlemleri, kurulum iletişimleri, standart poz adları ve oluşturulan VRChat menüleri 30 dilde görüntülenebilir.
- Inspector ve oyun menüsünün dil seçimi birleştirildi. Başlangıçta bilgisayarın dili kullanılır ve son seçim aynı işletim sistemi kullanıcısının diğer projelerinde de uygulanır.
- README, değişiklik geçmişi ve çevrimdışı kılavuz seçilen dilde açılabilir.
- 128 standart pozun görüntüleme adları ve özellik açıklamaları mevcut terimlere göre hazırlandı.

### Uyumluluk

- Avatarın mevcut ayarları, özel adlar, varlık başvuruları, parametre kimlikleri ve lisans saklama yöntemi korunur.

## [3.1.2] - 2026-11-09

- Ayak yüksekliği kapalı olsa da EX menüsündeki “Ayarlar → Sırtüstüyken başı otomatik kilitle” ile baş kilidi değiştirilebilir. Eski sürümlerde kaybolan öğe, güncelleme sonrası derlenince geri gelir.
- Unisaki Posing System 3.1.2 desteği eklendi. Baş dönüşünden kaynaklanan poz bozulmasını azalt kullanılırken yüzüstünden kalktıktan sonra yüzün yukarı bakmaya devam etmesi düzeltildi.

ALCOM / VCC’de Kawaii Posing Tool’u 3.1.2’ye güncelleyin. Unisaki Posing System 3.1.2 de gerekir. Ön oluşturma kullandıysanız Ön oluşturmayı güncelle’ye basın, sahneyi kaydedin ve avatarı yeniden derleyip yükleyin.

## [3.1.1] - 2026-11-08

- Aynala kapalı olsa da etkin Zemin yüksekliği ve Dön, VRChat EX menüsünün Ayarlar bölümünde görünür.
- Eski sürümde pozlar sıralansa, silinse veya yeniden adlandırılsa da Bacaklar Uzun, Rahat ve Bir Diz Yukarı doğru dönüşlerini korur. Tam Unpack yapılmışsa da özgün poz tanınabildiği sürece korunur. Kendi pozlarınız, elle kapattığınız dönüşler ve değiştirdiğiniz yan hareketler korunur.
- VRChat’te avatar seçildiğinde kısa süre yüzüstü olması düzeltildi. Yalnız yüzüstü seçiliyken zıplayınca kısa süre sırtüstü olması da düzeltildi. Zıplama geçişi “Özellikler → Kolaylıklar → Zıplayarak yatış pozunu değiştir”den kapatılabilir; varsayılan olarak açıktır.
- Güncelleme sonrası ortak poz Animator Controller başvurusu kaybolduysa ve kurtarılabiliyorsa uyarı gösterilip ayarlardan yeniden oluşturulur. Birden fazla avatarın paylaştığı Controller başvuruları da korunur.
- Kendi kaydettiğiniz aynı adlı 可愛いポーズ (Kawaii Posing) Prefab’ı olsa da araç ekleme menüsü artık resmî Prefab’ı yerleştirir.
- Sleep-together tool eklenirken bütünleştirme için gereken ürün bulunamazsa önce kurulacak ürün gösterilir.

ALCOM / VCC’de Kawaii Posing Tool ve Unisaki Posing System’i birlikte 3.1.1’e güncelleyin. Ön oluşturma kullandıysanız sahnedeki 可愛いポーズ (Kawaii Posing) üzerinde Ön oluşturmayı güncelle’ye basıp sahneyi kaydedin. VRChat’e yansıtmak için avatarı yeniden derleyip yükleyin.

## [3.1.0] - 2026-11-07

- 85 pozun 53’ünde uzuvlar avatarın vücut yapısına IK ile otomatik uydurulur.
- Sırtüstü Bacaklar Uzun, Rahat ve Bir Diz Yukarı, baş eğimiyle dönüşü destekler.
- Fotoğraf modunda avatarın konumu ve yönü ayarlanabilir. Konum/yön eşitlemesi ve fotoğraf sırasında kendi başınızın görünmesi seçilebilir.
- Zemin yüksekliği tüm vücudu en fazla 3m yukarı veya aşağı taşır; ayak yüksekliğinden ayrı amaçla kullanılabilir.
- Nefes hareketi, varsayılan bekleme sallanmasını kapatma ve baş yönünden kaynaklanan poz bozulmasını azaltma eklendi.
- Kullanılan özellikler ve parametre maliyeti Inspector’da görülebilir. Poz arama, toplu ekleme, sıralama ve Scene’de hafif önizleme eklendi.
- Masaüstünde ayakta, çömelme ve oturma geçişleri hızlandırıldı.
- Ayar değişikliği sonrası ön oluşturma uyarıları, Inspector kaydırma yükü ve oluşturulan verilerin temizliğindeki uzun durmalar iyileştirildi.
- Unisaki Posing System 3.1.0 desteği eklendi.

## [3.1.0-beta.2] - Açık beta (2026-11-05)

- GitHub Releases ve VPM üzerinden açık beta dağıtımı başladı. 85 pozun 53’ünde uzuvlar vücut yapısına IK ile otomatik uydurulur.
- Ortak paket 3.1.0-beta.2 desteği eklendi. Ön oluşturma sonrası değişiklik gösterimi, Inspector kaydırma yükü ve oluşturulan verilerin temizliğindeki durmalar iyileştirildi.

## [3.1.0-beta.1] - Açık beta (2026-11-04)

- Unisaki Posing System 3.1.0-beta.1 desteği eklendi.
- Masaüstünün normal poz geçişleri tek değerlendirme yöntemine geçirildi. Normal derlemede ve ön oluşturmada etkindir; VR ve özel koşullar önceki yolu korur.
- alpha.3 ve önceki ön oluşturmalar güncelleme gerektiren olarak tanınır.
- Fotoğraf sırasında zemin yüksekliği değişince bakış noktası korunur; fotoğraf bitince son zemin yüksekliğine dönülür.
- Otomatik içe aktarma, içe aktarılan hareket düzeltmesi ve oluşturulan Controller yönetiminde alpha.3’e kadarki iyileştirmeler eklendi.

## [3.1.0-alpha.2] - Kapalı test sürümü (2026-10-26)

### Düzeltmeler ve değişiklikler

- Ortak poz sistemi 3.1.0-alpha.2’ye güncellenip hata düzeltmeleri uygulandı.
- Zemin yüksekliği 3m yukarı/aşağıya genişletildi. 50% özgün yükseklik ve başlangıç değeridir.
- Seçilmemiş varsayılan/özel hareketler de fotoğraf ve zemin yüksekliği düzeltmesine dâhil edildi.
- Elle düzeltme, aynı adlı pozlar, başlangıç pozu ve eski ön ayar dönüş ayarları gibi sorunlar düzeltildi.

## [3.1.0-alpha.1] - Yayın öncesi

### Eklenenler

- Vücut yapısına uyan otomatik uzuv düzeltmesi (IK) eklendi.
- Genel ve poz başına IK açma/kapatma ile sonucu düzeltme animasyonuna işleme eklendi.
- Sırtüstü Bacaklar Uzun, Rahat ve Bir Diz Yukarı baş eğimiyle dönüşü destekler.
- Poz başına dönüş ayarı ve yan animasyon ataması eklendi.
- Öne taşıma ve dönüşü ayarlayan fotoğraf modu eklendi.
- Fotoğraf modu eşitlemesi eklendi: yalnızca yerel 0 bit, eşitlemede 16 bit.
- Fotoğraf modunda kendi avatarınızın başını gizlememe eklendi.
- Baş dâhil tüm vücudu yükselten Zemin yüksekliği eklendi.
- Nefes hareketi, güç ayarları ve oyun içi anahtar eklendi.
- VRChat’in varsayılan sallanmasını kapatma eklendi.
- Baş yönü farkından kaynaklanan poz bozulmasını azaltma eklendi.
- Dizin ters bükülmesini önleme ve en küçük açı eklendi.
- Özellik başına açma/kapatma ve ExpressionParameters göstergesi eklendi.
- Scene’de hafif önizleme, poz arama, toplu ekleme ve hedef sıra seçimi eklendi.
- Inspector içinde değişiklik geçmişi eklendi.

### Değişenler

- Inspector, Özellikler, Pozlar ve Avatar Kurulumu adlı 3 sekmeye ayrıldı.
- Nefes ayrıntıları, kendi hareketlerinizi içe aktarma ve ön ayarların yerleri düzenlendi.
- Ayak yüksekliği için oluşturulan animasyonların tekrarı azaltıldı.
- Poz görüntüsü yenilemeye onay eklendi; uyarı ayarları Ayarları kontrol et’te toplandı.
- 8bit için yeni ekleme menüsü kaldırılıp normal Prefab’ın özellik seçimine geçildi. Mevcut başvurular korunur.
- Unisaki Posing System 3.1.0-alpha.1 desteklendi. VRChat Avatars SDK minimum sürümü 3.10.4 oldu.

### Düzeltilenler

- Poz adı girişinin başka poza kayması ve sıralamada ayrıntıların kapanması düzeltildi.
- Önizleme çakışması, yerleştirme konumunun sapması ve bazı avatar hataları düzeltildi.
- Ayar değişikliği sonrası uyarı/ön oluşturma durumunun güncellenmesi ve bazı derleme hataları düzeltildi.

## [3.0.13] - 2026-09-22
- PosingSystem 3.0.17’ye geçilerek tüm avatarın eşit ölçeklenmesinden doğan yatay poz sapması düzeltildi
- Otomatik adım, yapılmamış ön oluşturma ve ayar değişikliği uyarılarını tek tek veya topluca yok sayma eklendi
- Hareketlerin elle içe aktarımında uygunsuz tek animasyonların alınması düzeltildi

## [3.0.12] - 2026-09-15
- Avatar ön ayarı eklendi (ルリエ)

## [3.0.11] - 2026-09-09
- Avatar ön ayarları eklendi (メルヴィ, ミダリス)
- うらら ön ayarının hareket değiştirmesi düzeltildi

## [3.0.10] - 2026-08-31
- PosingSystem 3.0.11’e geçilerek yeni NDMF’de ön oluşturma başarısızlığı ve hata ekranındaki istisna düzeltildi

## [3.0.9] - 2026-08-29
- PosingSystem 3.0.10’a geçilerek ön ayar yükleme ve Hierarchy simge değerlendirme yükü azaltıldı
- Aynı avatarda birden fazla poz sistemiyle ön oluşturma hatası düzeltildi

## [3.0.8] - 2026-08-26
- PosingSystem 3.0.9’a geçilerek NDMF sonrası önizleme Avatar’ının geçersizleşip Play’de `Avatar is null` vermesi düzeltildi

## [3.0.7] - 2026-08-18
- PosingSystem 3.0.8’e geçilerek yeniden yükseklik düzeltmesinde poz verisinin bozulma olasılığı düzeltildi

## [3.0.6] - 2026-08-12
- Avatar ön ayarları eklendi (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ)

## [3.0.5] - 2026-03-17
- Avatar ön ayarları eklendi (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール)

## [3.0.4] - 2026-01-31
- Avatar ön ayarları eklendi (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing)

## [3.0.3] - 2026-01-11
- Lisans kurma ve silme işlevleri iyileştirildi

## [3.0.2] - 2026-01-04
- Mac ve Linux lisans işlemi sorunu düzeltildi

## [3.0.1] - 2025-12-28
- Avatar ön ayarları eklendi (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ)

## [3.0.0] - 2025-12-28
- Ön oluşturma eklendi
- Animasyon Düzeltmesi eklendi
- Ön ayarlar eklendi
- Ürün unitypackage ile projeye eklenebilir
- Avatar ön ayarları eklendi (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ)

## [2.2.5] - 2025-05-08
- Bazı avatar özellikleriyle uyumluluk sorunları çözüldü

## [2.2.4] - 2025-04-04
- Bazı avatar ve ModularAvatar sürümlerinde pozun değişmemesi düzeltildi

## [2.2.3] - 2025-03-13
- 森羅’nın zıplaması gibi bazı avatar hareketlerinin bozulması düzeltildi
- Jestleri kapat başlangıç değerinin bazen yanlış olması düzeltildi

## [2.2.2] - 2025-03-06
- Bazı ortamlarda oluşan hata düzeltildi

## [2.2.1] - 2025-02-05
- Unity çökmesi düzeltildi
- NDMF Console’daki araç adına sürüm eklendi

## [2.2.0] - 2025-02-02
- Jestleri kapatıp animasyonun el şeklini kullanma eklendi
- Tüm pozlara el şekli verileri eklendi

## [2.1.6] - 2025-02-02
- Bazı araçlarla birlikte pozların bozulması düzeltildi
- Ayarlara bağlı hatalar düzeltildi

## [2.1.5] - 2024-12-10
- Bazı özelliklerle çakışmalar çözüldü
- Unitypackage sürümünü kaldırma düğmesi eklendi
- 三点だいしゅきツール VCC sürümü yayınlandığı için bütünleştirme Prefab’ları kaldırıldı

## [2.1.4] - 2024-12-08
- Avatara bağlı hata düzeltildi
- Özellik veya avatar çakışmasıyla ayak kilidinin kullanılamaması düzeltildi
- Masaüstünde avatar pozunun VRC varsayılanına dönmesi düzeltildi

## [2.1.3] - 2024-12-01
- VRMode’u yanlış türde kullanan avatar veya özelliklerle pozun değişmemesi düzeltildi
- Farklı parametre türü çakışmalarını NDMF-Console’da gösterme eklendi

## [2.1.2] - 2024-12-01
- Diğer araçta hata varken avatar derlemesinde Unisaki Posing System hatası oluştuğunda NDMF-Console’a açıklama eklendi
- Bazı avatarların derleme hatası düzeltildi
- Avatar yüklenir yüklenmez davranış iyileştirildi
- Bazı avatarları çalışamaz hâle getirdiği için avatarın özgün hareket işlemi artık kaldırılır

## [2.1.1] - 2024-11-20
- Derleme yapılamaması düzeltildi

## [2.1.0] - 2024-11-20
- Masaüstünde ayak ve kalçanın zemine gömülmesi giderilerek her pozun düzgün alınması sağlandı
- Baş yüksekliğini dikkate almadan poz değiştirme eklendi
- Quest avatarı yüklemek için simge oluşturmayan mod eklendi
- Avatar sorunları için çeşitli uyarılar eklendi
- AFK ve diğer araçların kol kilidi gibi özelliklerle kilitleme çakışmaları çözüldü
- Sırtüstüyken otomatik baş kilidi eklendi
- ExpressionsMenu değiştirildi: poz seçimi klasöre ayrıldı, kilitler üst düzeye taşındı

## [2.0.0] - 2024-11-14
### Düzeltilenler
- VCC desteği için VPM paketi yapıldı
- 8bit sürümün 17bit kullanması düzeltildi

## [1.15.0] - 2024-11-04
### Düzeltilenler
- Hata ve sorunlar düzeltildi

## [1.14.0] - 2024-07-05
### Düzeltilenler
- VRCFury ile sorun düzeltildi

## [1.13.0] - 2024-04-11
### Düzeltilenler
- ごろ寝システムEX bütünleştirme ayarları eklendi

## [1.12.0] - 2024-03-31
### Düzeltilenler
- Bazı ExMenu durumlarında aracın kullanılamaması düzeltildi
- Ayarlara aynalama eklendi
- Kedi pozu düzeltildi
- ５ yan yatış pozu eklendi

## [1.11.0] - 2024-03-12
### Düzeltilenler
- Baş yüksek konumdayken pozun bozulması düzeltildi

## [1.10.0] - 2024-03-10
### Düzeltilenler
- Ayakta durma işlevi ve 15 poz eklendi
- Bazı avatar ve ortamlarda ayakların kendi kendine hareket etmesi düzeltildi
- ExpressionParameters8bit sürümü eklendi

## [1.9.0] - 2024-03-05
### Düzeltilenler
- Bazı avatarlarda ayakların kendi kendine hareket etmesi düzeltildi
- WriteDefaults birleştirildi
- ７ çömelme ve ８ oturma pozu eklendi

## [1.8.0] - 2024-02-25
### Düzeltilenler
- ModularAvatar1.9.0 ve sonrasında yüklemenin başarısız olması düzeltildi
- ModualrAvatar1.9.0 veya sonrası artık zorunludur

## [1.7.0] - 2024-02-23
### Düzeltilenler
- Her poz için baş yüksekliği eşiğini değiştirme eklendi
- Bazı avatarların zıplama gibi durumlarda poz ve ayaklarının bozulması düzeltildi
- ExpressionParameter kullanımı 54’ten 16bit’e düşürüldü

## [1.6.0] - 2024-02-20
### Düzeltilenler
- VR’de oturma pozuna geçilememesi düzeltildi

## [1.5.0] - 2024-02-18
### Düzeltilenler
- Masaüstünde C basılıyken de oturma pozu kullanılabilir

## [1.4.0] - 2024-02-17
### Düzeltilenler
- 三点だいしゅき bütünleştirmesi olmadan 添い寝 bütünleştirmesinin çalışmaması düzeltildi
- Zıplayınca ayakların kilitlenmesi düzeltildi

## [1.3.0] - 2024-02-16
### Düzeltilenler
- Anormal sayıda VRCContactSender/Receiver atanması düzeltildi

## [1.2.0] - 2024-02-16
### Düzeltilenler
- Yükleme sırasında derleme hatası düzeltildi

## [1.1.0] - 2024-02-15
### Düzeltilenler
- Birden fazla Prefabs kullanırken varsayılanların bozuk olması düzeltildi
- 可愛い座り bütünleştirmesinin yanlış ayarları düzeltildi

## [1.0.0] - 2024-02-14
### Yayın
