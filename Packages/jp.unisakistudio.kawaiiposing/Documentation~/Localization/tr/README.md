# Kawaii Posing Tool

3 noktalı takipte ve masaüstünde bile sevimli oturma/yatış pozları sunan VRChat poz kilitleme aracıdır. Toplam 85 poz içerir: 15 ayakta, 20 çömelme, 17 oturma, 16 yüzüstü ve 17 sırtüstü.

Bu README, geliştirilmekte olan v3.2.0 içindir. Resmî yayın tarihi henüz belirlenmemiştir. Kurulu sürümü Inspector’ın üstünde görebilirsiniz.

- [BOOTH ürün sayfası](https://yunisaki.booth.pm/items/5479202)
- [Değişiklik geçmişi](CHANGELOG.md)

## Görüntüleme dili ve çevrimdışı belgeler

Inspector’ın üstündeki “Language / 言語” alanından dili seçin. Tek seçim hem Inspector’ı hem oluşturulan VRChat menüsünü etkiler. Oyundaki dili değiştirmek için avatarı yeniden yükleyin.

Dil seçilmemişse bilgisayarın dili, desteklenmeyen dillerde İngilizce kullanılır. Windows, macOS ve Linux desteklenir. Son seçim EditorPrefs’e kaydedilir ve bu bilgisayardaki aynı işletim sistemi kullanıcısının diğer projelerinde de kullanılır. Tüm poz araçları ve avatarlar aynı dili kullanır. Herhangi bir aracın Inspector’ında dili değiştirmek ortak tercihi günceller; avatara özel dil seçimleri dikkate alınmaz. Başka bilgisayarlara eşitlenmez. Lisans saklama yöntemi değişmez. Dil düğmesi, kayıtlı bir dil yoksa yalnızca ilk kurulum onayında görünür. Daha sonraki dil değişiklikleri Inspector’dan yapılır.

README, değişiklik geçmişi ve kullanım kılavuzu, paketteki [dil listesinden](../index.html) seçilebilir. Inspector’daki kılavuz ve değişiklik geçmişi de seçilen dili izler. Özgün kullanım koşulları ve başvuru çevirileri eskisi gibi ayrı sağlanır.

## Temel özellikler

- Fotoğraf modu: avatarı en fazla 3m öne taşıyıp yönünü ayarlar. Yalnız kendi ekranınızda 0 bit, konum ve yönü diğerlerine göstermek için 16 bit kullanır.
- Fotoğrafta baş görünümü: yalnızca fotoğraf modunda yakındaki kendi avatarınızın başının gizlenmesini önler.
- Zemin yüksekliği: baş dâhil tüm vücudu 3m yukarı/aşağı taşır. 50% özgün yükseklik ve başlangıç değeri, 0% 3m aşağısı, 100% 3m yukarısıdır. Başı yerinde tutup ayak tarafını ayarlayan Ayak yüksekliği ile farklı amaçlarla kullanılabilir.
- Dön: desteklenen yatış pozlarında baş eğimine göre sağa/sola döner.
- Nefes: göğüs gibi bölgelere nefes hareketi ekler. Kategori başına Yok, Hafif, Orta, Güçlü, Hızlı veya Özel seçilir.
- VRChat bekleme sallanmasını kapat: varsayılan sallanmayı bastırırken aracın nefesini ve diğer özel hareketleri korur.
- Baş dönüşünden kaynaklanan poz bozulmasını azalt: baş kilidi açıldığında baş yönünün özgün pozdan farklı olmasının neden olduğu bozulmayı azaltır.
- Özellik seçimi: yalnızca gereken oyun menülerini ekler; ExpressionParameters kullanımını Inspector’da görebilirsiniz.
- Poz arama, toplu ekleme ve sıralama: kategoriler arası arama, çoklu klip yükleme ve hedef sıra seçimi sağlar.
- Scene’de hafif önizleme: Pozlar’daki Önizleme ile pozu yerinde kontrol edin.

- Otomatik uzuv düzeltmesi (IK): desteklenen pozlarda el ve ayak konumlarını avatarın vücut yapısına uyarlar. Poz başına açıp kapatabilir ve sonucu düzeltme animasyonuna işleyebilirsiniz.

### Hazır pozlarla dönüş

Sırtüstü Bacaklar Uzun, Rahat ve Bir Diz Yukarı pozlarına dönüş için yan pozlar atanmıştır. Bunlar sırasıyla Yan Yatış, Kestirme ve Kedi Uykusu’na dayalı dönüşlerdir.

“Özellikler > Menü özellikleri > Dön”ü açıp yükleyin, VRChat’te desteklenen pozu ve Dön’ü seçin. Baş kilidini açarak kullanın.

Kendiniz ayarlamak için “Pozlar > Ayrıntılar > Dönüşü etkinleştir”i açıp Yan dönüş pozu’na animasyon atayın. Dönüş kullanan pozlarda normal MotionTime ayarı kullanılamaz.

### Vücut yapısına uyarlama

Hazır otomatik uzuv düzeltmesi kullanılabilir, ancak her poz IK gerektirmez. Animasyon Düzeltmesi’ndeki Otomatik uzuv düzeltmesini etkinleştir genel, Bu poz için IK’yi etkinleştir ise poz başına ayarı değiştirir.

IK’yi düzeltmeye işle, o anki otomatik sonucu yeni bir düzeltme animasyonuna yazıp ilgili pozun IK’sini kapatır. Sonra elle son düzenlemeyi yapabilirsiniz. Genel ve hedef pozun otomatik düzeltmesi açık ve uygulanabilir IK ayarları varsa kullanılabilir.

Avatar Kurulumu’nda Dizin ters bükülmesini önle ve ayrıntılarda En küçük diz bükülmesi (derece) de vardır.

## Kurulum

1. Satın aldığınız mağazanın ürün sayfasından dosyaları indirin.
2. Ekli “可愛いポーズツール.unitypackage” dosyasını Unity’ye aktarın, lisansı ve paket kaynağını kaydedin.
3. VCC veya ALCOM’da hedef Unity projesine Kawaii Posing Tool ve Modular Avatar ekleyin. Ortak Unisaki Posing System ve NDMF bağımlılık olarak kurulur.
4. Hierarchy’de hedef avatara sağ tıklayıp “Unisaki Studio > Kawaii Posing Ekle”yi seçin.
5. Avatarın içine eklenen 可愛いポーズ (Kawaii Posing)’i seçip Inspector’da kullanacağınız özellik ve pozları ayarlayın.
6. Avatarı normal biçimde yükleyin.

Unity 2022.3, VRChat Avatars SDK 3.10.4 veya sonrası, Modular Avatar 1.x serisi 1.15.1 veya sonrası ve NDMF 1.x serisi 1.14.0 veya sonrası gerekir. Gerekli paketleri VCC veya ALCOM ile birlikte güncelleyin.

## Önceki sürümden güncelleme

Ürünü ve Unisaki Posing System’i birlikte güncelleyin. Yerleştirilmiş araçların ayarları korunur. Inspector’da kullanılan özellikleri ve ExpressionParameters maliyetini kontrol edin. Ön oluşturma kullandıysanız yeniden yüklemeden önce Ön oluşturmayı güncelle’ye basın.

v3.1.0’dan itibaren yeni eklemeler normal 可愛いポーズ (Kawaii Posing) Prefab’ını kullanır. Özellikler’de gereksiz seçenekleri kapatırsanız yalnız poz seçimi olan en küçük yapı 8 bit kullanır. Çok pozlu yapılarda poz seçimi için ek bit gerekebilir.

Eski 8bit Prefab, mevcut avatar ve ön ayar başvurularını korumak için Editor/Legacy’de tutulur. Mevcut Prefab’ı silmeniz veya değiştirmeniz gerekmez. Unity’nin yeni ekleme menüsünde 8bit görünmez.

## Ayarların konumu

| Sekme | İşlevler |
| --- | --- |
| Özellikler | Oyun menüsü ekleme, kolaylıklar, nefes ayarı, simgeler ve ExpressionParameters kullanımını kontrol etme |
| Pozlar | Poz seçimi, ayrıntılar, arama, toplu ekleme, sıra, önizleme ve Animasyon Düzeltmesi |
| Avatar Kurulumu | Avatar ve diz düzeltmeleri, özgün pozları/kendi hareketlerinizi içe aktarma ve ön ayar değiştirme |

Ayarları aç, öğenin altındaki ayrıntıları açar. Nefes “Özellikler > Kolaylıklar > Nefes animasyonu ekle”den ayarlanır.

Özgün ayakta, çömelme ve yüzüstü pozları kullan, avatarın mevcut pozlarını otomatik içe aktarır. Kendi hareketlerinizi kullanmak için ayrı içe aktarma ayarlarından ayakta, çömelme (Crouching), yüzüstü (Prone) gibi türleri tek tek atayın.

Ön ayarlar Avatar Kurulumu’nun en altındadır. Bu ön ayarı uygula mevcut poz ayarlarını değiştirdiğinden, geçişten önce yapılmış düzeltmeleri kaydedin.

### Özellik başına kullanım

- Nefes hareketi 0 bit’tir. Oyunda durdurup sürdüren “Menü özellikleri > Nefes” anahtarı kullanılırsa eşitleme için 1 bit gerekir.
- Fotoğraf modu yalnız kendi ekranınızda 0 bit’tir. “Kolaylıklar > Fotoğraf modunu eşitle” 16 bit kullanır. Fotoğraf modunda başı görünür tut 0 bit’tir.
- Ayak yüksekliği ve Zemin yüksekliği ayrı ayrı 8 bit kullanır. Zemini merkezden uzaklaştırmak vücudu yukarı/aşağı taşır; yaklaşık 50%’ye dönmek düzeltmeyi bitirir.
- Dönüş tek başına 10 bit’tir. Baş dönüşünden kaynaklanan poz bozulmasını azalt ile 1 bit ortaktır; ikisi birlikte de toplam 10 bit kullanır.
- Aynala ve Jestleri kapat ayrı ayrı 1 bit’tir.

Inspector toplamı avatara kurulu poz araçlarına aittir; kıyafet ve diğer özellikleri içermez. Birden fazla araç kullanılsa da ortak ayarlar tekrar sayılmaz.

### Önizleme ve poz düzenleme

Pozlar’daki her pozun Önizleme düğmesi pozu Scene’de gösterir. Ayrıntılı düzeltme için Animasyon Düzeltmesi’ni açın, pozu kontrol ederek düzenleyip kaydedin.

Hafif önizleme MA veya NDMF derlemesini çalıştırmaz. Derlemede eklenen kıyafet ve zemin konumu düzeltmelerini yükleme öncesindeki derleme sonucunda da inceleyin.

Soldaki büyüteç sekmesinde poz adı arayabilirsiniz. “Ayrıntılar > Sıra”dan hedef yeri seçebilir veya yukarı/aşağı düğmelerini kullanabilirsiniz. Birden fazla animasyonu ekleme alanına sürükleyerek ya da Project’te seçili klipleri içe aktarma komutuyla topluca ekleyin.

Poz küçük resimlerini güncelle, onaydan sonra görüntü üretir. Poz simgeleri oluştur, oyun menüsünde ayırt etmeyi kolaylaştırır ancak görüntü üretimi derlemeyi uzatır. Boyutu azaltmak için Simge boyutunu küçült’ü seçin. Android için poz simgeleri üretilmez.

## Oyundaki temel kullanım

- Expressions menüsünde her kategori için poz seçin. VR’de baş yüksekliği ayakta, çömelme, oturma ve yatış arasında geçiş yapar.
- Yatışta yüzün yönüne göre sırtüstü/yüzüstü değişir. İkisi de seçiliyse yerinizde zıplayarak da geçebilirsiniz. Unity’de “Özellikler → Kolaylıklar → Zıplayarak yatış pozunu değiştir”den kapatılabilir (varsayılan açık). Kategorilerin geçiş yükseklikleri ayarlar menüsündeki eşiklerle ayarlanır.
- Masaüstünde C ve Z ile poz değiştirin. Z ile yatışa geçilmiyorsa ayarlarda yatış yüksekliği eşiğini artırın.
- Jestleri kapat açıkken kontrolörün parmak hareketi yerine pozda ayarlanmış el şekli kullanılır.
- Ayak yüksekliği başı yerinde tutup ayak tarafını ayarlar. Zemin yüksekliği baş dâhil tüm vücudu yukarı/aşağı taşır. Ayarlarda bu sırayla görünürler.
- Fotoğraf modunda Mesafe ile öne hareket edince avatar size bakar. Yön ile döndürüp uygun anda Ayakları kilitle’yi açın. Fotoğraftan çık, mesafeyi ve yönü sıfırlayıp ayak kilidini açar.
- Nefes, nefes hareketi etkinse kullanılabilir. Gücü Unity’de ayarlanır; oyunda yalnız açma/kapatma değişir.

## Ön oluşturma ve uyarılar

Ön oluşturmayı güncelle, oluşturulan verileri yeniden kullanarak avatar derlemesini hızlandırır. Ön oluşturma olmadan da normal derleme gerekli verileri üretir.

Ayarları değiştirdikten sonra Inspector’ın üstündeki Ayarları kontrol et ve Hierarchy işareti güncellemeyi bildirir. Uyarı gösterim ayarları, Ayarları kontrol et çerçevesinin içindedir. Görünümü gizlemek ayar sorununu çözmez veya üretilen veriyi yenilemez.

## Kullanım notları

- Tam vücut takibi sırasında poz kilitleme desteklenmez.
- Vücut yapısı, kıyafet ve avatar değişiklikleri ek düzeltme gerektirebilir.
- Özel Base katmanları ve diğer poz değiştirme sistemleri beklenen şekilde birleşmeyebilir. Kilit çalışmıyorsa “Avatar Kurulumu > Takip kilitlerini diğer araçlarla bütünleştir”i de kontrol edin.
- Fotoğraf modunun hareket/dönüşü ve zemin yüksekliği, poz seçilmemişken varsayılan ve özel hareketleri de düzeltir. VRChat’te bakış noktasını ve varsayılan hareketler değiştikten sonraki davranışı uygulamada inceleyin.
- VRChat bekleme sallanmasını kapat, varsayılan bekleme hareketini hedefler. Diğer nedenlerle oluşan her sallanmayı durdurmaz.

## Kullanım ve destek

Inspector’ın üstündeki yardım ve geçmiş panelinden kılavuzu, iletişimi ve değişiklik geçmişini açabilirsiniz. Ortak özelliklerin ayrıntıları Unity Project’te “Packages > Unisaki Posing System > README” içinde de bulunur.

- [Resmî kılavuz](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [İletişim](https://help.unisakistudio.jp/)

Hata bildirirken bu ürün ve Unisaki Posing System sürümlerini, Unity/VRChat SDK/Modular Avatar/NDMF sürümlerini, kullanılan avatarı, tekrarlama adımlarını ve Console hata içeriğini ekleyin.

## Ön ayar dağıtımı

Aşağıdaki bilgiler Animasyon Düzeltmesi ile oluşturulan verilere ilişkindir.

Bu özellikle oluşturulan düzeltme animasyonu dosyalarını ve bunlar atanmışken oluşturulan ön ayarları Unisaki Studio’dan izin almadan özgürce dağıtabilir ve satabilirsiniz. Kendi avatarınızı dağıtırken veya araçta bulunmayan avatarlar için ön ayarlar hazırlarken paylaşabilirsiniz.

## Bütünleştirme ayarları bulunan ürünler

Not: bütünleştirme ayarlarını mağazamız tek taraflı hazırlamaktadır. İlgili ürün yazarlarının izninin gerekmediğini düşündüğümüz için izin istemedik. Bu ayarların dağıtılması veya dağıtımının durdurulması taleplerini mağaza mesajlarıyla iletin. Bütünleştirme için ilgili ürünün satın alınması veya indirilmesi gerekir. Ayarlarla ilgili sorunlarda ürün yazarları yerine mağazamızla iletişime geçin.

“可愛い座りツール”
https://yunisaki.booth.pm/items/3611536

“添い寝ツール”
https://yunisaki.booth.pm/items/3670993

“少女モーション集vol.1”, hazırlayan: ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

“VRC想定移動モーション（無料配布）”, hazırlayan: カトのVRC道具屋
https://booth.pm/ja/items/1285101

“ごろ寝システムEX”, hazırlayan: minminmart
https://minminmart.booth.pm/items/4233545

## Kullanım koşulları

Bu aracı yalnızca VN3 lisansı temel alınarak hazırlanan aşağıdaki kullanım koşullarını kabul edenler kullanabilir.

[Kullanım koşulları (Japonca)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Bu depodaki kaynak kodu ve kaynaklar açık kaynak değildir. Ürünün yasal olarak satın alınması ve kullanım koşullarının kabulü gerekir.

[Kullanım koşulları (İngilizce)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
