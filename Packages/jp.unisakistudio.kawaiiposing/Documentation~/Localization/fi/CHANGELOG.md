# Muutosloki

## [3.2.0] - Julkaisematon

### Lisätty

- Inspectorin, muokkaustoimintojen, asennusikkunoiden, vakioasentojen nimien ja luotavan VRChat-valikon näyttö 30 kielellä.
- Inspectorin ja pelivalikon kielivalinnat yhdistetty. Oletuksena käytetään tietokoneen kieltä, ja viimeinen valinta koskee myös saman käyttöjärjestelmäkäyttäjän muita projekteja.
- README, muutosloki ja offline-käyttöohje voidaan avata valitulla kielellä.
- Kaikkien 128 vakioasennon näyttönimet ja toimintojen kuvaukset laadittu olemassa olevien termien mukaisesti.

### Yhteensopivuus

- Avatarin nykyiset asetukset, omat nimet, resurssiviittaukset, parametrien tunnisteet ja lisenssin tallennustapa säilyvät.

## [3.1.2] - 2026-11-09

- Pään lukitusta voi vaihtaa EX-valikon kohdassa ”Asetukset → Lukitse pää automaattisesti selällään” myös Jalkojen kork. -toiminnon ollessa pois käytöstä. Aiemmissa versioissa kadonnut kohde palautuu, kun avatar kootaan päivityksen jälkeen.
- Lisätty Unisaki Posing System 3.1.2:n tuki. Korjattu ongelma, jossa kasvot jäivät ylöspäin vatsamakuulta noustessa, kun pään kierrosta aiheutuvan asennon vääristymän vähentäminen oli käytössä.

Päivitä Kawaii Posing Tool versioon 3.1.2 ALCOMissa / VCC:ssä. Myös Unisaki Posing System 3.1.2 vaaditaan. Jos käytit esikoontia, paina ”Päivitä esikoonti”, tallenna kohtaus ja kokoa sekä lataa avatar uudelleen.

## [3.1.1] - 2026-11-08

- Käytössä olevat ”Lattian kork.” ja ”Käänny” näkyvät VRChatin EX-valikon Asetuksissa myös Peilaa-toiminnon ollessa pois käytöstä.
- Vanhassa versiossa järjestettyjen, poistettujen tai uudelleennimettyjen asentojen ”Jalat ojossa”, ”Rentona” ja ”Yksi polvi ylös” oikeat kääntymiset säilyvät. Tämä toimii myös täysin Unpackatuille objekteille, jos alkuperäinen asento voidaan tunnistaa. Omat asennot, itse käytöstä poistetut kääntymiset ja vaihdetut sivuttaisliikkeet säilyvät.
- Korjattu avatarin hetkellinen vatsamakuu VRChatissa avataria valittaessa. Korjattu myös hetkellinen selinmakuu hypätessä, kun vain vatsamakuu on valittuna. Hypyllä vaihtamisen voi poistaa käytöstä kohdasta ”Toiminnot → Lisätoiminnot → Vaihda makuuasentoa hyppäämällä”. Oletuksena se on käytössä.
- Jos yhteisen asentojen Animator Controllerin viittaus irtoaa päivityksessä ja se voidaan palauttaa, näytetään varoitus ja Controller luodaan uudelleen asetuksista. Usean avatarin jakaman Controllerin viittaukset säilyvät.
- Työkalun lisäysvalikko sijoittaa nyt virallisen Prefabin, vaikka oma samanniminen 可愛いポーズ (Kawaii Posing) -Prefab olisi tallennettu.
- Jos Sleep-together toolin lisäyksessä tarvittavaa yhteensopivuustuotetta ei löydy, näytetään ensin asennettava tuote.

Päivitä Kawaii Posing Tool ja Unisaki Posing System molemmat versioon 3.1.1 ALCOMissa / VCC:ssä. Jos käytit esikoontia, paina kohtauksen 可愛いポーズ (Kawaii Posing) -työkalusta ”Päivitä esikoonti” ja tallenna kohtaus. Kokoa ja lataa avatar uudelleen, jotta muutos näkyy VRChatissa.

## [3.1.0] - 2026-11-07

- Mukana olevista 85 asennosta 53 mukauttaa raajat automaattisesti avatarin mittasuhteisiin IK:n avulla.
- Selinmakuuasennot ”Jalat ojossa”, ”Rentona” ja ”Yksi polvi ylös” tukevat pään kallistuksen ohjaamaa kääntymistä.
- Kuvatilassa voi säätää avatarin sijaintia ja suuntaa. Voit valita sijainnin ja suunnan synkronoinnin sekä oman pään näkyvyyden kuvauksessa.
- Lattian korkeudella voi siirtää koko kehoa enintään 3m ylös tai alas. Sitä voi käyttää eri tarkoitukseen kuin jalkojen korkeutta.
- Lisätty hengitysliike, oletusarvoisen joutokäyntihuojunnan poisto ja pään suunnan aiheuttaman asennon vääristymän vähentäminen.
- Käytössä olevat toiminnot ja parametrien muistinkulutus näkyvät Inspectorissa. Lisätty asentohaku, joukkolisäys, järjestäminen ja kevyt esikatselu Scenessä.
- Nopeutettu seisoma-, kyykky- ja istuma-asentojen vaihtoa työpöytätilassa.
- Parannettu asetusmuutosten jälkeisiä esikoontivaroituksia, Inspectorin vierityksen kuormitusta ja luotujen resurssien siivouksen pitkiä pysähdyksiä.
- Lisätty Unisaki Posing System 3.1.0:n tuki.

## [3.1.0-beta.2] - Avoin beetaversio (2026-11-05)

- Aloitettu avoimen beetaversion jakelu GitHub Releasesissa ja VPM:ssä. Mukana olevista 85 asennosta 53 mukauttaa raajat avatarin mittasuhteisiin IK:lla.
- Lisätty yhteisen paketin 3.1.0-beta.2:n tuki. Parannettu esikoonnin jälkeisten muutosten näyttöä, Inspectorin vierityksen kuormitusta ja luotujen resurssien siivouksen pysähdyksiä.

## [3.1.0-beta.1] - Avoin beetaversio (2026-11-04)

- Lisätty Unisaki Posing System 3.1.0-beta.1:n tuki.
- Työpöytätilan tavallinen asennonvaihto muutettu yhden arvioinnin malliin. Käytössä tavallisessa koonnissa ja esikoonnissa. VR ja erityistilanteet käyttävät aiempaa käsittelyä.
- alpha.3:n ja vanhempien versioiden esikoonnit tunnistetaan päivitettäviksi.
- Näkymä säilyy lattian korkeutta kuvauksen aikana muutettaessa. Kuvauksen jälkeen palataan uusimpaan lattian korkeuteen.
- Mukana alpha.3:een asti tehdyt automaattituonnin, tuotujen liikkeiden säädön ja luotujen Controllerien hallinnan parannukset.

## [3.1.0-alpha.2] - Suljettu testiversio (2026-10-26)

### Korjaukset ja muutokset

- Yhteinen asentojärjestelmä päivitetty versioon 3.1.0-alpha.2 sisältäen virheenkorjaukset.
- Lattian korkeuden alue laajennettu 3m ylös ja alas. 50% on alkuperäinen korkeus ja oletusarvo.
- Myös oletus- ja omat liikkeet ilman valittua asentoa huomioidaan kuvaus- ja lattian korkeuden korjauksissa.
- Korjattu manuaaliseen korjaukseen, samannimisiin asentoihin, alkuasentoon ja vanhojen esiasetusten kääntymisasetuksiin liittyviä ongelmia.

## [3.1.0-alpha.1] - Ennen julkaisua

### Lisätty

- Lisätty raajojen automaattinen säätö (IK) avatarin mittasuhteisiin.
- Lisätty yleinen ja asentokohtainen IK-kytkin sekä tuloksen tallennus säätöanimaatioon.
- Selinmakuuasennot ”Jalat ojossa”, ”Rentona” ja ”Yksi polvi ylös” tukevat pään kallistuksen ohjaamaa kääntymistä.
- Lisätty asentokohtaiset kääntymisasetukset ja sivuttaisanimaation määritys.
- Lisätty Kuvatila eteenpäin siirtymisen ja kierron säätämiseen.
- Lisätty Kuvatilan synkronointiasetus. Paikallinen käyttö kuluttaa 0 bit, synkronointi 16 bit.
- Lisätty asetus oman avatarin pään säilyttämiseen näkyvissä Kuvatilassa.
- Lisätty Lattian kork. -toiminto, joka nostaa koko kehoa pää mukaan lukien.
- Lisätty hengitysliike, sen voimakkuusasetukset ja pelivalikon kytkin.
- Lisätty VRChatin oletushuojunnan poisto.
- Lisätty pään suunnan aiheuttaman asennon vääristymän vähentäminen.
- Lisätty polvien taakse taittumisen esto ja vähimmäistaivutuskulma.
- Lisätty toimintokohtaiset kytkimet ja ExpressionParameters-kulutuksen näyttö.
- Lisätty kevyt esikatselu Scenessä, asentohaku, joukkolisäys ja siirtokohdan järjestysnumeron määritys.
- Lisätty muutoslokin näyttö Inspectorissa.

### Muutettu

- Inspector järjestetty 3 välilehteen: Toiminnot, Asennot ja Avatarin asetukset.
- Hengityksen lisätiedot, omien liikkeiden tuonti ja esiasetukset järjestetty selkeisiin paikkoihin.
- Vähennetty jalkojen korkeussäädön luomien animaatioiden päällekkäisyyttä.
- Asentokuvien päivitykseen lisätty vahvistusikkuna ja varoitusasetukset koottu Tarkista asetukset -kohdan sisälle.
- 8bit-version uuden asennuksen valikko poistettu ja korvattu tavallisen Prefabin toimintovalinnoilla. Nykyiset viittaukset säilyvät.
- Lisätty Unisaki Posing System 3.1.0-alpha.1:n tuki. VRChat Avatars SDK:n vähimmäisversio muutettu versioon 3.10.4.

### Korjattu

- Korjattu nimikentän syötteen siirtyminen toiseen asentoon ja lisätietojen sulkeutuminen järjestämisessä.
- Korjattu esikatselujen päällekkäisyys, sijainnin poikkeamat ja joidenkin avatarien virheet.
- Korjattu varoitusten ja esikoontitilan päivittyminen asetusmuutosten jälkeen sekä joitakin koontivirheitä.

## [3.0.13] - 2026-09-22
- Päivitetty PosingSystem versioon 3.0.17 ja korjattu koko avatarin tasaisen mittakaavamuutoksen aiheuttama asentojen vaakasijainnin poikkeama
- Lisätty asetukset automaattisen askelluksen, puuttuvan esikoonnin ja asetusmuutosten varoitusten ohittamiseen yksittäin tai yhdessä
- Korjattu sopimattomien yksittäisten animaatioiden tuonti liikkumisanimaatioiden manuaalisessa tuonnissa

## [3.0.12] - 2026-09-15
- Lisätty avatarin esiasetus (ルリエ)

## [3.0.11] - 2026-09-09
- Lisätty avatarien esiasetukset (メルヴィ, ミダリス)
- Korjattu うらら-esiasetuksen liikkeiden korvaus

## [3.0.10] - 2026-08-31
- Päivitetty PosingSystem versioon 3.0.11 ja korjattu uusimman NDMF:n esikoonnin epäonnistuminen sekä virhenäytön poikkeus

## [3.0.9] - 2026-08-29
- Päivitetty PosingSystem versioon 3.0.10 ja kevennetty esiasetusten latausta sekä Hierarchyn kuvakkeiden arviointia
- Korjattu esikoontivirhe, kun samassa avatarissa on useita asentojärjestelmiä

## [3.0.8] - 2026-08-26
- Päivitetty PosingSystem versioon 3.0.9 ja korjattu esikatselu-Avatarin muuttuminen virheelliseksi NDMF-käsittelyn jälkeen, mikä johti Play-tilassa virheeseen `Avatar is null`

## [3.0.7] - 2026-08-18
- Päivitetty PosingSystem versioon 3.0.8 ja korjattu mahdollinen asentodatan vioittuminen korkeutta uudelleen korjattaessa

## [3.0.6] - 2026-08-12
- Lisätty avatarien esiasetukset (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ)

## [3.0.5] - 2026-03-17
- Lisätty avatarien esiasetukset (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール)

## [3.0.4] - 2026-01-31
- Lisätty avatarien esiasetukset (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing)

## [3.0.3] - 2026-01-11
- Parannettu lisenssin asennus- ja poistotoimintoja

## [3.0.2] - 2026-01-04
- Korjattu lisenssikäsittelyn ongelma Mac- ja Linux-versioissa

## [3.0.1] - 2025-12-28
- Lisätty avatarien esiasetukset (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ)

## [3.0.0] - 2025-12-28
- Lisätty esikoonti
- Lisätty animaatiosäätö
- Lisätty esiasetukset
- Tuotteen voi nyt lisätä projektiin unitypackagella
- Lisätty avatarien esiasetukset (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ)

## [2.2.5] - 2025-05-08
- Ratkaistu yhteensopivuusongelmia joidenkin avatarin toimintojen kanssa

## [2.2.4] - 2025-04-04
- Korjattu asentojen vaihtumisen estävä ongelma joillakin avatarin ja ModularAvatar-version yhdistelmillä

## [2.2.3] - 2025-03-13
- Korjattu joidenkin avatarien, kuten 森羅-hahmon hypyn, virheelliset liikkeet
- Korjattu ajoittain väärä Eleet pois -oletusarvo

## [2.2.2] - 2025-03-06
- Korjattu tietyissä ympäristöissä ilmenevä virhe

## [2.2.1] - 2025-02-05
- Korjattu Unityn kaatuminen
- Lisätty versio NDMF Consolessa näkyvään työkalun nimeen

## [2.2.0] - 2025-02-02
- Lisätty asetus eleiden poistamiseen ja animaation kädenmuotojen käyttämiseen
- Lisätty kädenmuodon data kaikkiin asentoihin

## [2.1.6] - 2025-02-02
- Korjattu asentojen rikkoutuminen tiettyjen työkalujen kanssa
- Korjattu asetuksista riippuva virhe

## [2.1.5] - 2024-12-10
- Ratkaistu ristiriitoja joidenkin avatarin toimintojen kanssa
- Lisätty painike Unitypackage-version poistamiseen
- 三点だいしゅきツール-työkalusta julkaistiin VCC-versio, joten yhteensopivuus-Prefabit poistettiin

## [2.1.4] - 2024-12-08
- Korjattu avatarista riippuva virhe
- Korjattu jalkojen lukituksen estyminen avatarin tai muiden toimintojen ristiriidassa
- Korjattu avatarin asennon palautuminen VRC:n oletusasentoon työpöytätilassa

## [2.1.3] - 2024-12-01
- Korjattu asennon vaihtumisen estyminen käytettäessä avataria tai toimintoa, joka käyttää vääräntyyppistä VRMode-parametria
- Lisätty ilmoitus NDMF-Consoleen toimintojen parametrityyppien välisistä ristiriidoista

## [2.1.2] - 2024-12-01
- NDMF-Consoleen lisätty selitys tilanteeseen, jossa toisen työkalun virhe aiheuttaa avatarin koonnissa virheen Unisaki Posing Systemiin
- Korjattu joidenkin avatarien koontivirhe
- Parannettu toimintaa heti avatarin lataamisen jälkeen
- Avatarin alkuperäinen liikkumiskäsittely poistetaan nyt, koska se esti joidenkin avatarien toiminnan

## [2.1.1] - 2024-11-20
- Korjattu koonnin estävä ongelma

## [2.1.0] - 2024-11-20
- Korjattu jalkojen ja lantion uppoaminen maahan työpöytätilassa, jotta kaikki asennot toimivat oikein
- Lisätty mahdollisuus vaihtaa asentoa pään korkeudesta riippumatta
- Lisätty kuvakkeiden luonnin poistava tila Quest-avatarien latausta varten
- Lisätty useita varoituksia avatarin ongelmista
- Ratkaistu lukitustoimintojen ristiriidat esimerkiksi AFK:n ja muiden työkalujen käsien lukitusten kanssa
- Lisätty automaattinen pään lukitus selinmakuulla
- Muutettu ExpressionsMenua: asennon valinta erotettu kansioon ja lukitustoiminnot siirretty ylätasolle

## [2.0.0] - 2024-11-14
### Korjattu
- Muutettu VPM-paketiksi VCC-tukea varten
- Korjattu 8bit-version 17bit-kulutus

## [1.15.0] - 2024-11-04
### Korjattu
- Korjattu virheitä ja ongelmia

## [1.14.0] - 2024-07-05
### Korjattu
- Korjattu ongelma VRCFuryn kanssa

## [1.13.0] - 2024-04-11
### Korjattu
- Lisätty yhteensopivuusasetukset ”ごろ寝システムEX”-tuotteelle

## [1.12.0] - 2024-03-31
### Korjattu
- Korjattu työkalun toimimattomuus joissakin ExMenu-tiloissa
- Lisätty asetuksiin peilaustoiminto
- Korjattu kissan asento
- Lisätty ５ kylkimakuuasentoa

## [1.11.0] - 2024-03-12
### Korjattu
- Korjattu asennon vääristyminen pään ollessa korkealla

## [1.10.0] - 2024-03-10
### Korjattu
- Lisätty seisoma-asentotoiminto ja 15 asentoa
- Korjattu jalkojen itsestään liikkuminen joillakin avatareilla ja ympäristöissä
- Lisätty ExpressionParameters8bit-versio

## [1.9.0] - 2024-03-05
### Korjattu
- Korjattu jalkojen itsestään liikkuminen joillakin avatareilla
- Yhtenäistetty WriteDefaults
- Lisätty ７ kyykkyasentoa ja ８ istuma-asentoa

## [1.8.0] - 2024-02-25
### Korjattu
- Korjattu latauksen epäonnistuminen ModularAvatar1.9.0:ssa ja uudemmissa
- ModualrAvatar1.9.0 tai uudempi vaaditaan nyt

## [1.7.0] - 2024-02-23
### Korjattu
- Lisätty kunkin asennon pään korkeuden raja-arvon muuttaminen
- Korjattu joidenkin avatarien asentojen tai jalkojen vääristyminen esimerkiksi hypätessä
- Vähennetty ExpressionParameter-kulutusta 54 bitistä 16bit-tasolle

## [1.6.0] - 2024-02-20
### Korjattu
- Korjattu istuma-asentoon siirtymisen estyminen VR-tilassa

## [1.5.0] - 2024-02-18
### Korjattu
- Työpöytätilassa istuma-asento on nyt mahdollinen myös C-näppäin painettuna

## [1.4.0] - 2024-02-17
### Korjattu
- Korjattu 添い寝-yhteensopivuuden toimimattomuus ilman 三点だいしゅき-yhteensopivuutta
- Korjattu jalkojen jähmettyminen hypätessä

## [1.3.0] - 2024-02-16
### Korjattu
- Korjattu poikkeuksellisen suuri VRCContactSender/Receiver-määrä

## [1.2.0] - 2024-02-16
### Korjattu
- Korjattu latauksen koontivirhe

## [1.1.0] - 2024-02-15
### Korjattu
- Korjattu usean Prefabin oletusarvot
- Korjattu 可愛い座り-yhteensopivuuden virheelliset asetukset

## [1.0.0] - 2024-02-14
### Julkaisu
