# Kawaii Posing Tool — Türkçe kullanım kılavuzu

Kawaii Posing, masaüstü ve üç noktalı VR için 85 poz sunar: 15 ayakta, 20 çömelme/sandalye, 17 yerde oturma, 17 sırtüstü ve 16 yüzüstü.

Bu kılavuz kurulum, avatar ayarı, VRChat kontrolleri, poz düzenleme, güncelleme ve sorun gidermeyi kapsar. Satın aldığınız ZIP’te en hızlı kurulum yolu için `START_HERE.html` bulunur.

## Başlamadan önce

- VRChat Creator Companion (VCC) veya ALCOM ile oluşturulan ya da yönetilen Unity 2022.3 VRChat **avatar** projesi kullanın.
- Gereken paketler: VRChat Avatars SDK 3.10.4 veya sonrası; Modular Avatar 1.x, 1.15.1 veya sonrası; NDMF 1.x, 1.14.0 veya sonrası.
- Araç masaüstünde ve üç noktalı VR’de (başlık ve iki kontrolör) Humanoid avatarlar içindir. Tam vücut takibi etkin olduğunda poz kilitleme desteklenmez.
- Kurmadan veya güncellemeden önce mevcut projeyi yedekleyin. Önce Unity’deki mevcut derleme hatalarını giderin.
- Kurucu ürünü ve bağımlılıkları paket depolarından indirir. İnternet gerekir. Avatar modelleri, VRChat SDK, Modular Avatar ve NDMF bu ZIP’te bulunmaz.

## 1. Lisansı ve ürünü kurun

1. ZIP’in tamamını Unity projenizin dışındaki normal bir klasöre çıkarın.
2. Hedef avatar projesini Unity’de açın. `Installer/KawaiiPosing_Installer.unitypackage` dosyasını **Assets > Import Package > Custom Package** ile aktarın veya Unity’de açın.
3. İçe aktarma ve kurulum istemlerini okuyun. Lisans onayı hangi ürün lisanslarının kurulacağını açıklar. Kurulum dilini değiştirmek için onay penceresindeki **Dil…** (veya **言語...**) düğmesini kullanın.
4. Lisans kurulumunu onaylayın. Lisans bu ürünün kullandığı ortak Unisaki Posing System’i de kapsar. Kurucu daha sonra kendi kurulum dosyalarını kaldırmayı önerebilir; bu temizlik kurulu ürün lisansını silmez.
5. Otomatik paket kurulumunun onayını inceleyin. Eklenecek paket ve depoları, kaldırılması önerilen eski dosya veya klasörleri listeler. Bunlar istediğiniz öğelerse devam edin.
6. Unity’nin içe aktarma ve derlemeyi bitirmesini bekleyin. Paket kurulumu otomatik bitmezse projeyi VCC veya ALCOM’da açıp **Kawaii Posing Tool** ve **Modular Avatar** ekleyin. Ortak **Unisaki Posing System** ve **NDMF** bağımlılıklardır. `Optional-VCC-Links`, Windows VCC kullanıcıları için ürünle gelen özgün depo kısayollarını içerir.
7. Bir onay iptal edildiyse hazır olduğunuzda kurucuyu yeniden içe aktarın. Etkinleştirici hâlâ varsa **Tools > Unisaki Studio** içindeki lisans kurulum komutu da kullanılabilir. Eski sürümlerde bu alt menü **ゆにさきスタジオ** adını taşır.

### Bu indirme neleri kurar?

**Kawaii Posing Tool 3.2.0 ve Unisaki Posing System 3.2.0.** Bu sürüm geliştirme aşamasındadır ve yayınlanmamıştır. Otuz dilde kurulum iletişimleri, Unity Inspector ve menüleri, standart poz adları, oyun menüleri ve çevrimdışı belgeler ekler. Yayın tarihi belirlenmemiştir. Aracın dilini Inspector’ın üstündeki seçiciden değiştirin. Yayınlandıktan sonra kurucu bu sürümleri ve uyumlu bağımlılıklarını VPM depolarından indirecektir. Yerel yayın hazırlığı paketleri yayınlamaz.

Kawaii Posing Tool; poz kitaplığı, ayar araçları ve avatar düzeltme ön ayarlarını içerir. Kurucu ürünün mevcut yerel lisansını etkinleştirir; yeni bir Gumroad lisans anahtarı alanı gerektirmez. Kurulum dosyalarını veya lisans verilerini hiçbir zaman herkese açık destek iletilerine koymayın.

Dil tercihleri geçerli işletim sistemi kullanıcısı için Unity EditorPrefs’te saklanır ve bu bilgisayardaki Unity projeleri arasında paylaşılır. Kayıtlı tercih yoksa kurucu işletim sisteminin dilini izler; desteklenmeyen dillerde İngilizce kullanılır. Ürün lisansları mevcut depolamayı korur: Windows’ta geçerli kullanıcının `Software/UnisakiStudio` kayıt defteri anahtarı, macOS/Linux’ta kullanıcıya özel lisans dosyaları. Dil değiştirmek lisansı silmez. Tüm poz araçları ve avatarlar aynı dili kullanır. Herhangi bir aracın Inspector’ında dili değiştirmek ortak tercihi günceller; avatara özel dil seçimleri dikkate alınmaz. Dil düğmesi, kayıtlı bir dil yoksa yalnızca ilk kurulum onayında görünür. Daha sonraki dil değişiklikleri Inspector’dan yapılır.

## 2. Aracı avatara ekleyin

1. **Hierarchy** içinde **VRC Avatar Descriptor** olan avatarı veya alt nesnelerinden birini seçin. Project’teki Prefab varlığı veya Prefab Mode yerine sahneye yerleştirilmiş avatar kullanın.
2. Avatara sağ tıklayıp **Unisaki Studio > Kawaii Posing Ekle**yi seçin. Kurulu sürüm Japonca menü kullanıyorsa **ゆにさきスタジオ > 可愛いポーズツール追加**yı seçin.
3. Araç avatarın içine eklenir. Görüntülenen etiketler çevrilse de kaydedilmiş nesne adı **可愛いポーズ** kalabilir.
4. Uyumlu ön ayar sunulursa başlangıç uyumu için uygulayın. Yoksa **Avatar Kurulumu**nu açıp bir ön ayar seçin veya pozları kendiniz düzeltin.
5. Kurucu ön oluşturma önerebilir. İsteğe bağlıdır; normal avatar derlemesi de gerekli veriyi üretir. Sonraki derlemeleri hızlandırmak için ön oluşturmayı yeniden kullanın.
6. Araç nesnesini seçin, poz ve özellikleri ayarlayın, ardından avatarı VRChat SDK üzerinden normal şekilde yükleyin.

### Dil seçimi ve tanıdık etiketler

Bu sürümde Inspector’ın üstünde **Language / 言語** vardır. Tek seçim Inspector’ı ve oluşturulan oyun menüsünü yönetir. Avatar seçilen dili saklar ve son seçim bu bilgisayardaki diğer araç/projelerde hatırlanır. VRChat’te görülen dili değiştirmek için avatarı yeniden yükleyin.

Eski Japonca öğreticileri izlerken aşağıdaki etiket tablosunu kullanın. Bu sürümde 30 dilin tümü için dil seçici, çevrilmiş Inspector, standart poz adları ve oyun menüleri bulunur.

| Türkçe etiket | Eski sürümlerdeki Japonca etiket |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Özellikler | 機能 |
| Pozlar | ポーズ一覧 |
| Avatar Kurulumu | アバター調整 |
| Ayarları aç | 設定を開く |
| Ön oluşturmayı güncelle | プレビルドを更新 |
| Ayarları kontrol et | 設定の確認 |
| Önizleme | プレビュー |
| Animasyon Düzeltmesi | アニメーション調整 |
| Yenile | 再読込 |

Inspector, düzenleyici/kurulum iletişimleri, standart poz adları ve oluşturulan menüler seçilebilir 30 dilin tümüne çevrilmiştir. README, değişiklik geçmişi ve çevrimdışı kılavuz her seçilebilir dilde sağlanır. Avatar adları, kaydedilmiş nesne adları, özel poz adları, varlık dosya adları ve iç parametre kimlikleri özgün yazımlarını koruyabilir.

[30 dilde hızlı başvuru](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html), özellik açıklamalarını ve standart poz adı tablolarını içerir. Bunlar kısa başvuru metinleridir; tam belgeler için dil dizinini kullanın.

## 3. Pozları ve özellikleri seçin

Inspector’ın üç ana sekmesi vardır:

| Sekme | Kullanımı |
| --- | --- |
| **Özellikler** | Oyun menüsü kontrolleri, isteğe bağlı davranışlar, nefes, simgeler ve expression parametre kullanımı. |
| **Pozlar** | Etkin pozlar, kategori/arama, sıralama, animasyon ekleme, önizleme, ayrıntılar ve Animasyon Düzeltmesi. |
| **Avatar Kurulumu** | Avatar ve diz düzeltmeleri, özgün/özel hareket içe aktarma ve ön ayarlar. |

Yalnız kullanacağınız menü kontrollerini açın. Örneğin **Aynala**yı eklemek VRChat’te aynalamayı değiştirmeyi sağlar; her pozu sürekli aynalı tutmaz.

Kawaii Posing avatar ön ayarları ve desteklenen pozlar için IK içerir. Üç standart sırtüstü poza yan yatış hareketleri atanmıştır: **Bacaklar Uzun (足伸ばし)**, **Rahat (リラックス)** ve **Bir Diz Yukarı (膝立て)**. Uyumlu ön ayarı kullanın; bu öğeleri düzenlediyseniz veya değiştirdiyseniz her birinin dönüş ayarını inceleyin.

### Ön ayarlar ve uyarlama

Ön ayarlar **Avatar Kurulumu**nun altındadır. Avatar adıyla arayıp mevcut poz ayarlarını değiştirmek için ön ayarı uygulayın. Ön ayar değiştirmeden önce düzeltmeleri kaydedin veya yedekleyin. Ön ayar başlangıç noktasıdır; vücut oranları, kıyafetler ve avatar değişiklikleri yine elle düzeltme gerektirebilir.

Vücut/uzuv yerleşimini önizleyip düzenlemek için pozun **Animasyon Düzeltmesi**ni kullanın. Bitirince bu pencereden düzeltme animasyonunu kaydedin. Desteklenen yerlerde otomatik el/ayak düzeltmesi (IK) genel ve poz başına açılabilir. Geçerli IK sonucunu düzeltmeye işlemek bir animasyon oluşturur ve elle tamamlamanız için o pozun IK’sini kapatır; özgün kaynak klip korunur.

**Dizin ters bükülmesini önle**, en küçük diz bükülme açısı gibi ek ayarlara sahiptir. Avatar düzeltmeleri yalnızca karşılık gelen veri varsa kullanılabilir; bazı düzeltmeler poz IK’siyle birlikte çalışamaz.

### Özgün ve özel hareketler

**Özgün ayakta, çömelme ve yüzüstü pozları kullan**, üretim sırasında avatarın Base katmanından hareket algılar. **Kendi hareketlerinizi kullanın**, tür başına ayrı içe aktarma ayarı açar. Her türe tek hareket seçin. Elle atama o türün otomatik içe aktarmasına göre önceliklidir.

Otomatik içe aktarma derleme kopyasına uygulanır. Algılanan animasyonları sahnenin elle atama listesine yazmaz veya özgün Controller’ları değiştirmez. Bir türü yeniden otomatik algılatmak için elle geçersiz kılmayı temizleyin. Özel Base katmanları ve diğer hareket sistemleri ayrı ayar gerektirebilir.

## 4. Aracı VRChat’te kullanın

Avatarınızın **Expressions** menüsünü açıp **Kawaii Posing** içine girin. Kullanacağınız her poz kategorisi için bir poz seçin. Poz seçmek ve özellik seçmek ayrı işlemlerdir.

- **Üç noktalı VR:** başınızı kaldırıp indirerek ayakta, çömelme/sandalye, yerde oturma ve yatış arasında geçin. Geçişler erken veya geçse aracın ayarlar menüsündeki yükseklik eşiklerini ayarlayın.
- **Masaüstü:** **C** ile çömelin, **Z** ile yatın. Z sizi oturur bırakıyorsa ayarlardaki yatış yüksekliği eşiğini artırın.
- **Yüzüstü/sırtüstü:** araç yüz yönüyle yatış tarafını seçer. İkisi de seçiliyken yerinde zıplamak aralarında geçebilir. İsterseniz Unity’de **Özellikler > Kolaylıklar** üzerinden zıplamayla geçişi kapatın; ek eşitlenen parametre maliyeti yoktur.
- **Kilitler:** gerektiğinde baş, kol ve ayak kilitlerini kullanın. Kontrolör jesti yerine pozun el şeklini istiyorsanız jestleri kapatın.
- **Aynala:** arkadaşınıza dönmek veya kompozisyona uymak için seçili pozu aynalayın.

### Ayak yüksekliği ve zemin yüksekliği

**Ayak yüksekliği**, başı yerinde tutarak ayakları ayarlar. Baş doğru yükseklikteyken ayaklar havada kalıyor veya zemine gömülüyorsa kullanın.

**Zemin yüksekliği**, baş dâhil tüm vücudu taşır. Koltuk, yatak veya yüksek yüzeylerde, collider’ı olmayan mobilyalarda da kullanın. Ortak sistemin mevcut merkezli kontrolünde **50% özgün yüksekliktir**, 0% 3 m aşağısı, 100% 3 m yukarısıdır. Ofseti bitirmek için yaklaşık 50%’ye dönün. Eski sürümlerde davranış farklı olabilir; kurulu sürümü kontrol edip ortak sistemi ürünle birlikte güncelleyin.

### Fotoğraf modu

Yüklemeden önce Unity’de **Fotoğraf modu** menü öğesini açın. VRChat’te poz seçin, **Mesafe** ile en fazla 3 m öne taşıyın ve **Yön** ile döndürün. Kadrajı hazırlarken ayak kilidi isteğe bağlıdır. **Fotoğraftan çık** mesafeyi/dönüşü sıfırlayıp ayak kilidini açar.

Fotoğraf modu varsayılan olarak yereldir. Konum ve dönüşü diğer kişilere göstermek için yüklemeden önce Unity’de **Fotoğraf modunu eşitle**yi açın; bu 16 eşitlenen bit kullanır. **Fotoğraf modunda başı görünür tut** kendi görünümünüzü etkiler ve eşitlenen bit kullanmaz.

### Nefes ve dönüş

Nefes, poz kategorisi başına **Özellikler > Kolaylıklar > Nefes animasyonu ekle** altında ayarlanabilir. Yok, Hafif, Orta, Güçlü, Hızlı veya özel bir nefes animasyonu seçin. Hareketin kendisi eşitlenen bit kullanmaz. Nefes menü anahtarı 1 bit kullanır.

Dönüş için desteklenen yatış pozu ve **Dön** menü öğesi gerekir. Pozun dönüşünü açın ve gerektiğinde yan yatış animasyonunu atayın. VRChat’te pozu seçin, dönüşü açın ve baş/boyun kilidini kapatın. Başın yan eğimi dönüşü yönetir. Dönüş kullanılırken bu pozda normal MotionTime kontrolü kullanılamaz.

Yukarıda listelenen üç standart sırtüstü pozun yan yatış hareketleri vardır. Diğer pozlar uygun hareket ve poz ayarı gerektirir. İçe aktarılan veya özel ön ayarlar farklı atamalar kullanabilir.

## 5. Poz düzenleme, ekleme ve önizleme

**Pozlar** içinde kategori veya arama sekmesini seçin. Arama, özgün Japonca adları ve mevcut çevirileri kabul eder. Animasyon, simge, sıra ve zamanlamayı değiştirmek için pozun **Ayrıntılar**ını açın.

Birden fazla animasyon eklemek için klipleri ekleme alanına sürükleyin veya Project’te seçip seçili klipleri içe aktarma komutunu kullanın. Aynı klibe yinelenen başvurular çıkarılır. Ayrıntılar’dan hedef sırayı veya yukarı/aşağı kontrollerini kullanın.

**Önizleme**, tam düzeltme penceresini açmadan pozu Scene’de gösterir. Hafif önizleme Modular Avatar veya NDMF çalıştırmaz; kıyafet, zemin düzeltmesi ve diğer derleme zamanı özelliklerini son avatar derlemesinde kontrol edin.

Avatarınızdan oluşturulan poz simgeleri pozları tanımayı kolaylaştırır; ancak üretim zaman alır ve veri boyutunu artırabilir. Yer kazanmak için simge çözünürlüğünü azaltın. Android derlemeleri poz simgesi üretmez. Avatar veya kıyafet değişince gerekirse simgeleri yeniden üretin.

## 6. Parametre belleği

Inspector, tüm avatarın toplamı yerine poz araçlarının katkısını gösterir. Kıyafetler ve diğer sistemler ek parametre belleği kullanabilir. Birden fazla aracın paylaştığı ortak ayarlar iki kez sayılmaz. Çok ek poz içeren özel yapılar daha fazla poz seçim biti gerektirebilir.

| Özellik | Ek eşitlenen bit |
| --- | ---: |
| Poz seçimi, en küçük standart yapı | 8 |
| Aynala | 1 |
| Jestleri kapat | 1 |
| Nefes hareketi | 0 |
| Nefes menü anahtarı | 1 |
| Ayak yüksekliği | 8 |
| Zemin yüksekliği | 8 |
| Fotoğraf modu, yalnızca yerel | 0 |
| Fotoğraf modunu eşitle | 16 |
| Fotoğraf modunda başı görünür tut | 0 |
| VRChat’in varsayılan bekleme sallanmasını kapat | 0 |
| Dön | 10 |

Dönüş, boyun yönü poz düzeltmesiyle 1 bit paylaşır; ikisi birlikte açık olsa da bu iki özellik toplam 10 bit kullanır. Kurulu sürümünüzün gösterdiği kullanım, seçili yapınız için pratik ölçüttür.

## 7. Güncelleme ve ön oluşturma

1. Projeyi yedekleyin ve çalışma sahnesini kaydedin.
2. VCC veya ALCOM’da **Kawaii Posing Tool** ve ortak **Unisaki Posing System**i birlikte güncelleyin. SDK, Modular Avatar ve NDMF sürümlerini de uyumlu tutun.
3. Derlemenin bitmesini bekleyin. Kurulu aracı seçip poz, ayar ve parametre kullanımını inceleyin.
4. Ön oluşturma kullanıyorsanız **Ön oluşturmayı güncelle**yi seçip avatarı yeniden yükleyin.

Mevcut araç ayarları korunur. Eski 8-bit Prefab’lar uyumluluk için tutulur; mevcut başvurular aracı silmenizi veya değiştirmenizi gerektirmez. Yeni kurulumlar normal Prefab kullanır; gereksiz özellikler kapatılarak parametre kullanımı azaltılabilir.

Eski ön oluşturma uyarısı, önbellekteki derleme verileri üretildiğinden beri ayarların değiştiğini belirtir. Ön oluşturmayı güncellemek bu veriyi yeniden üretir. Uyarıyı gizlemek ön oluşturmayı güncellemez ve alttaki sorunu çözmez. Her seferinde elle ön oluşturma yapmasanız da normal avatar derlemesi gereken veriyi üretebilir.

## 8. Sorun giderme

| Belirti | Kontrol edilecekler |
| --- | --- |
| Araç ekleme menüsü yok | Ürünün **ve** Unisaki Posing System’in kurulu olduğunu doğrulayın; Unity Console derleme hatalarını çözün. Yalnız lisans kurucusu poz kitaplığı değildir. |
| Kurulum iptal edildi veya dosyalar silindi | Hazır olduğunuzda satın aldığınız kurucuyu yeniden aktarın; onayları tekrar okuyun. |
| Başka projede lisans yok görünüyor | Satın aldığınız kurucuyu aynı işletim sistemi hesabında aktarın. Bilgisayar/hesap değiştiyse oraya da lisansı kurun. Dil tercihleri bilgisayarlar arasında otomatik taşınmaz. |
| VRChat’te pozlar yok | Aracı doğru sahne avatarının altına ekleyin, pozları açın, Inspector uyarılarını inceleyin ve o avatarı yükleyin. SDK ve diğer hareket araçlarını kontrol edin. |
| Z yatışa geçmiyor | Aracın oyun ayarlarında yatış yüksekliği eşiğini artırın. |
| Eller veya dizler hizalanmıyor | Uyumlu avatar ön ayarını, ardından desteklenen IK ve/veya Animasyon Düzeltmesi’ni deneyin. Son derlemede kıyafet deformasyonunu kontrol edin. |
| Dönüş çalışmıyor | Desteklenen yatış pozu kullanın, pozun dönüş ayarı ve menü öğesini açın, baş/boyun kilidini kapatın. Önce desteklenen üç standart pozdan birini deneyin. |
| Arkadaşlar fotoğraf hareketini görmüyor | Unity’de **Fotoğraf modunu eşitle**yi açın, parametre kullanımını kontrol edip yeniden yükleyin. |
| Dil Unity’de değişiyor ama VRChat’te değişmiyor | Avatarı yeniden yükleyin. Çok dilli sürümde Inspector’ın üstündeki tek dil seçimini kontrol edin. |
| Derleme/ön oluşturma hataları | İlgili **ilk** Console hatasını okuyun. Sahneyi yedekleyin, ürün ve ortak sistemi VCC/ALCOM ile güncelleyin veya yeniden alın; sorun sürerse destekle görüşün. Destek özel bir kurtarma adımı vermedikçe düzeltilmiş nesneleri ve GeneratedResources’ı koruyun. |

Destek için ürün/ortak sistem sürümlerini, Unity/SDK/Modular Avatar/NDMF sürümlerini, avatar adını, tam tekrarlama adımlarını ve ilgili Console hatasını ekleyin. Herkese açık gönderilerden özel dosyaları, kurulum içeriğini, lisans değerlerini ve hesap bilgilerini çıkarın.

- [Destek](https://help.unisakistudio.jp/)
- [Resimli çevrimiçi kılavuz (Japonca)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Gumroad ürün sayfası](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Lisanslar ve katkıda bulunanlar

[Ürün sözleşmesinin İngilizce başvuru çevirisi](../../Terms.en.html), özgün Japonca sözleşmeyle birlikte sağlanır.

Özgün ürün sözleşmesini ve ortak sistem sözleşmesini paket README’sinin yanından veya satın aldığınız ZIP’in `Licenses` klasöründen okuyun. Ekli İngilizce Unisaki Posing System sözleşmesi bu sistemin mevcut başvuru çevirisidir; ürünün Japonca sözleşmesi ayrıca bulunur. Kılavuz sözleşmeleri değiştirmez veya ek hak vermez. Ürün verilerini kullanma ya da yeniden dağıtma soruları için desteğe başvurun.

Kurucu, **anatawa12** tarafından yapılan değiştirilmiş **VPMPackageAutoInstaller** ile **SimpleJson** ve **semver.net** içerir. Telif bildirimleri ve MIT lisansları satın aldığınız ZIP’in `ThirdPartyNotices.txt` dosyasındadır. Poz kitaplığı ve diğer ürün kaynakları kendi ürün lisanslarına sahiptir.
