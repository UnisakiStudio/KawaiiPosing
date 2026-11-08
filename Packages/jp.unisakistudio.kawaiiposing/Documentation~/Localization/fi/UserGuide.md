# Kawaii Posing Tool — suomenkielinen käyttöohje

Kawaii Posing sisältää 85 asentoa työpöytätilaan ja kolmen pisteen VR-seurantaan: 15 seisoma-asentoa, 20 kyykky-/tuoli-istuntaa, 17 lattiaistuntaa, 17 selinmakuuasentoa ja 16 vatsamakuuasentoa.

Tämä ohje kattaa asennuksen, avatarin asetukset, VRChat-ohjaimet, asentojen muokkauksen, päivitykset ja vianmäärityksen. Ostetun ZIP-paketin `START_HERE.html` opastaa nopeimmin asennukseen.

## Ennen aloittamista

- Käytä Unity 2022.3:n VRChat-**avatar**projektia, joka on luotu tai jota hallitaan VRChat Creator Companionilla (VCC) tai ALCOMilla.
- Vaaditut paketit: VRChat Avatars SDK 3.10.4 tai uudempi; Modular Avatar 1.x, vähintään 1.15.1; ja NDMF 1.x, vähintään 1.14.0.
- Työkalu on tarkoitettu Humanoid-avatareille työpöytätilassa ja kolmen pisteen VR-seurannassa (lasit ja kaksi ohjainta). Asennon lukitusta aktiivisessa kokovartaloseurannassa ei tueta.
- Varmuuskopioi olemassa oleva projekti ennen asennusta tai päivitystä. Korjaa ensin Unityn nykyiset käännösvirheet.
- Asennusohjelma lataa tuotteen ja riippuvuudet pakettirepositorioista. Internet-yhteys tarvitaan. Avatarimallit, VRChat SDK, Modular Avatar ja NDMF eivät sisälly tähän ZIP-pakettiin.

## 1. Asenna lisenssi ja tuote

1. Pura koko ZIP tavalliseen kansioon Unity-projektin ulkopuolelle.
2. Avaa oikea avatarprojekti Unityssa. Tuo `Installer/KawaiiPosing_Installer.unitypackage` kohdasta **Assets > Import Package > Custom Package** tai avaa tiedosto Unitylla.
3. Lue tuonti- ja asennuskehotteet. Lisenssivahvistus kertoo asennettavat tuotelisenssit. Vaihda asennusohjelman kieltä vahvistusikkunan **Kieli…**-painikkeella (tai **言語...**).
4. Vahvista lisenssin asennus. Lisenssi kattaa myös tuotteen käyttämän yhteisen Unisaki Posing Systemin. Asennusohjelma voi tarjota omien asennustiedostojensa poistoa tämän jälkeen. Siivous ei poista asennettua tuotelisenssiä.
5. Tarkista automaattisen pakettiasennuksen vahvistus. Siinä luetellaan lisättävät paketit ja repositoriot sekä poistettaviksi ehdotetut vanhat tiedostot tai kansiot. Jatka, kun kohteet ovat tarkoittamiasi.
6. Odota Unityn tuonnin ja kääntämisen valmistumista. Jos pakettiasennus ei valmistu automaattisesti, avaa projekti VCC:ssä tai ALCOMissa ja lisää **Kawaii Posing Tool** ja **Modular Avatar**. Yhteinen **Unisaki Posing System** ja **NDMF** ovat riippuvuuksia. `Optional-VCC-Links` sisältää tuotteen alkuperäiset repositoriopikakuvakkeet Windowsin VCC-käyttäjille.
7. Jos peruit vahvistuksen, tuo asennusohjelma uudelleen sopivana ajankohtana. Voit käyttää myös sen lisenssin asennuskomentoa kohdasta **Tools > Unisaki Studio**, kun aktivointiskripti on yhä mukana. Vanhemmissa koonneissa alivalikon nimi on **ゆにさきスタジオ**.

### Tämän latauksen asentama sisältö

**Kawaii Posing Tool 3.2.0 ja Unisaki Posing System 3.2.0.** Tämä versio on kehitteillä eikä sitä ole julkaistu. Se lisää 30 kielen asennusikkunat, Unityn Inspectorin ja valikot, vakioasentojen nimet, pelivalikot sekä offline-ohjeet. Julkaisupäivää ei ole päätetty. Vaihda työkalun kieltä Inspectorin yläosan kielivalitsimesta. Julkaisun jälkeen asennusohjelma lataa nämä versiot ja niiden yhteensopivat riippuvuudet VPM-repositorioista. Paikallinen julkaisuvalmistelu ei julkaise paketteja.

Kawaii Posing Tool sisältää asentokirjaston, asetustyökalut ja avatarin säätöesiasetukset. Asennusohjelma aktivoi tuotteen nykyisen paikallisen lisenssin. Uutta Gumroad-lisenssiavaimen kenttää ei tarvita. Älä koskaan julkaise asennustiedostoja tai lisenssitietoja julkisessa tukipyynnössä.

Kieliasetukset tallennetaan Unity EditorPrefsiin nykyiselle käyttöjärjestelmäkäyttäjälle, ja ne ovat yhteisiä tämän tietokoneen Unity-projekteille. Ilman tallennettua valintaa asennusohjelma seuraa käyttöjärjestelmän kieltä. Jos kieltä ei tueta, käytetään englantia. Tuotelisenssien nykyinen tallennus säilyy: Windowsissa nykyisen käyttäjän `Software/UnisakiStudio`-rekisteriavain ja macOS/Linuxissa käyttäjäkohtaiset lisenssitiedostot. Kielen vaihtaminen ei poista lisenssiä.

## 2. Lisää työkalu avatariin

1. Valitse **Hierarchysta** avatar, jolla on **VRC Avatar Descriptor**, tai sen lapsiobjekti. Käytä kohtaukseen sijoitettua avataria, älä Project-ikkunan Prefab-resurssia tai Prefab Modea.
2. Napsauta avataria hiiren oikealla painikkeella ja valitse **Unisaki Studio > Lisää Kawaii Posing**. Jos asennettu koonti käyttää japaninkielisiä valikoita, valitse **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Työkalu lisätään avatarin sisälle. Sen tallennettu objektinimi voi olla edelleen **可愛いポーズ**, vaikka näyttötekstit on käännetty.
4. Jos sopivaa avatarin esiasetusta tarjotaan, käytä sitä alkusovitukseen. Muussa tapauksessa avaa **Avatarin asetukset** ja valitse esiasetus tai säädä asennot itse.
5. Asennus voi tarjota esikoontia. Se on vapaaehtoinen, sillä myös tavallinen avatarin koonti luo tarvittavan datan. Esikoonnin uudelleenkäyttö lyhentää myöhempien koontien kestoa.
6. Valitse työkalun objekti, haluamasi asennot ja toiminnot ja lataa avatar normaalisti VRChat SDK:lla.

### Kielivalinta ja tutut nimet

Tässä versiossa **Language / 言語** on työkalun Inspectorin yläosassa. Sama valinta koskee Inspectoria ja luotavaa pelivalikkoa. Avatar tallentaa valitun kielensä, ja viimeinen valinta muistetaan tämän tietokoneen muissa työkaluissa ja projekteissa. Lataa avatar uudelleen palveluun vaihtaaksesi VRChatissa näkyvän kielen.

Käytä alla olevaa nimitaulukkoa seuratessasi vanhoja japaninkielisiä ohjeita. Tämä versio sisältää kielivalitsimen, käännetyn Inspectorin, vakioasentojen nimet ja pelivalikot kaikille 30 kielelle.

| Suomenkielinen nimi | Japaninkielinen nimi vanhoissa koonneissa |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Toiminnot | 機能 |
| Asennot | ポーズ一覧 |
| Avatarin asetukset | アバター調整 |
| Avaa asetukset | 設定を開く |
| Päivitä esikoonti | プレビルドを更新 |
| Tarkista asetukset | 設定の確認 |
| Esikatselu | プレビュー |
| Animaatiosäätö | アニメーション調整 |
| Lataa uudelleen | 再読込 |

Mukana toimitettujen Inspectorin, muokkaus- ja asennusikkunoiden, vakioasentojen nimien sekä luotujen valikoiden käännökset kattavat kaikki 30 valittavaa kieltä. README, muutosloki ja offline-käyttöohje toimitetaan jokaiselle valittavalle kielelle. Avatarien nimet, tallennetut objektinimet, omat asentojen nimet, resurssien tiedostonimet ja sisäiset parametrien tunnisteet voivat säilyttää alkuperäisen kirjoitusasunsa.

[30 kielen pikaohjeet](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) sisältävät toimintojen kuvaukset ja vakioasentojen nimitaulukot. Ne ovat tiiviitä viitteitä. Avaa täydelliset ohjeet kielihakemistosta.

## 3. Valitse asennot ja toiminnot

Inspectorissa on kolme päävälilehteä:

| Välilehti | Käyttötarkoitus |
| --- | --- |
| **Toiminnot** | Pelivalikon ohjaimet, lisätoiminnot, hengitys, kuvakeasetukset ja expression-parametrien kulutus. |
| **Asennot** | Käytössä olevat asennot, luokat ja haku, järjestys, animaatioiden lisääminen, esikatselu, lisätiedot ja animaatiosäätö. |
| **Avatarin asetukset** | Avatarikohtainen korjaus, polvikorjaus, alkuperäisten ja omien liikkeiden tuonti sekä esiasetukset. |

Ota käyttöön vain tarvitsemasi valikko-ohjaimet. Esimerkiksi **Peilaa**-toiminnon lisääminen valikkoon antaa vaihtaa peilauksen VRChatissa. Se ei pakota kaikkia asentoja pysymään peilattuina.

Kawaii Posing sisältää avatarien esiasetukset ja tuettujen asentojen IK:n. Kolmelle vakioselinmakuuasennolle on jo määritetty sivuttaisliike: **Jalat ojossa (足伸ばし)**, **Rentona (リラックス)** ja **Yksi polvi ylös (膝立て)**. Käytä sopivaa esiasetusta ja tarkista kunkin asennon kääntymisasetus, jos olet muokannut tai korvannut näitä kohteita.

### Esiasetukset ja sovittaminen

Esiasetukset ovat **Avatarin asetukset** -välilehden lopussa. Hae avatarin nimellä ja korvaa nykyiset asentoasetukset käyttämällä esiasetusta. Tallenna tai varmuuskopioi säädöt ennen vaihtamista. Esiasetus on lähtökohta. Mittasuhteet, asut ja avatarin muutokset voivat edelleen edellyttää manuaalista säätöä.

Käytä asennon **Animaatiosäätöä** kehon ja raajojen sijainnin esikatseluun ja muokkaamiseen. Tallenna säätöanimaatio ikkunasta, kun olet valmis. Tuetuissa asennoissa käsien ja jalkojen automaattisen säädön (IK) voi kytkeä yleisesti ja asentokohtaisesti. Nykyisen IK-tuloksen tallentaminen säätöihin luo säätöanimaation ja poistaa asennon IK:n käytöstä käsin viimeistelyä varten. Alkuperäinen lähdeleike säilytetään.

**Estä polvien taittuminen taakse** tarjoaa lisäasetuksia, kuten polven vähimmäistaivutuskulman. Avatarikohtaiset korjaukset ovat käytettävissä vain vastaavan korjausdatan kanssa. Joitakin korjauksia ei voi käyttää yhdessä asennon IK:n kanssa.

### Alkuperäiset ja omat liikkeet

**Käytä alkuperäisiä seisoma-, kyykky- ja vatsa-asentoja** tunnistaa liikkeet avatarin Base-tasosta luonnin aikana. **Käytä omia liikkeitä** avaa erilliset tuontiasetukset kullekin liiketyypille. Valitse yksi liike tyyppiä kohden. Manuaalinen valinta ohittaa kyseisen tyypin automaattituonnin.

Automaattituonti kohdistuu koontikopioon. Tunnistettuja animaatioita ei kirjoiteta kohtauksen manuaalisten valintojen luetteloon, eikä alkuperäisiä Controllereita muokata. Tyhjennä tyypin manuaalinen korvaus, jos haluat automaattisen tunnistuksen käsittelevän sen jälleen. Omat Base-tasot ja muut liikkumisjärjestelmät voivat vaatia yksilöllisiä säätöjä.

## 4. Työkalun käyttö VRChatissa

Avaa avatarin **Expressions**-valikko ja siirry kohtaan **Kawaii Posing**. Valitse asento kullekin haluamallesi asentoluokalle. Asennon ja toiminnon valinta ovat eri asioita.

- **Kolmen pisteen VR:** laske tai nosta päätä siirtyäksesi seisomisen, kyykyn/tuoli-istunnan, lattiaistunnan ja makuuasentojen välillä. Säädä työkalun asetusvalikon korkeusrajoja, jos asento vaihtuu liian aikaisin tai myöhään.
- **Työpöytätila:** kyykisty **C**:llä ja mene makuulle **Z**:lla. Jos Z jättää istumaan, nosta makuuasennon korkeusrajaa asetusvalikossa.
- **Selin- ja vatsamakuu:** kasvojen suunta valitsee selin- tai vatsamakuun. Jos molemmat ovat valittuina, paikallaan hyppääminen voi vaihtaa niiden välillä. Voit poistaa hypyllä vaihtamisen käytöstä Unityn kohdasta **Toiminnot > Lisätoiminnot**. Se ei lisää synkronoitujen parametrien kulutusta.
- **Lukitukset:** käytä pään, käsien ja jalkojen lukituksia tarpeen mukaan. Poista eleet käytöstä, jos haluat asennon kädenmuodon ohjaimen eleen sijaan.
- **Peilaa:** käännä valittu asento peilikuvaksi esimerkiksi kaveria kohti tai sommitteluun sopivaksi.

### Jalkojen korkeus ja lattian korkeus

**Jalkojen kork.** säätää jalkoja pitäen pään paikallaan. Käytä sitä jalkojen leijuessa tai upotessa, kun pää on jo oikealla korkeudella.

**Lattian kork.** siirtää koko kehoa pää mukaan lukien. Käytä sitä sohvalla, sängyllä tai korokkeella, myös ilman collideria olevissa huonekaluissa. Yhteisen järjestelmän nykyisessä keskitetyssä säätimessä **50% on alkuperäinen korkeus**, 0% on 3 m alempana ja 100% on 3 m ylempänä. Paluu lähelle 50% lopettaa siirron. Vanhemmat julkaisut voivat toimia eri tavalla. Tarkista asennettu versio ja päivitä yhteinen järjestelmä tuotteen kanssa.

### Kuvatila

Ota **Kuvatila**-valikkokohde käyttöön Unityssa ennen latausta. Valitse VRChatissa asento, siirry **Etäisyys**-säätimellä enintään 3 m eteenpäin ja käännä avataria **Suunta**-säätimellä. Jalkojen lukitus on valinnainen kuvaa sommiteltaessa. **Lopeta kuvaus** palauttaa etäisyyden ja suunnan sekä vapauttaa jalkojen lukituksen.

Kuvatila on oletuksena paikallinen. Näyttääksesi sijainnin ja suunnan muille ota **Synkronoi Kuvatila** käyttöön Unityssa ennen latausta. Se kuluttaa 16 synkronoitua bittiä. **Pidä pää näkyvissä Kuvatilassa** vaikuttaa omaan näkymääsi eikä kuluta synkronoituja bittejä.

### Hengitys ja Käänny

Hengitys voidaan asettaa asentoluokittain kohdasta **Toiminnot > Lisätoiminnot > Animoi hengitys**. Valitse Ei mitään, Heikko, Keskivahva, Vahva, Nopea tai oma hengitysanimaatio. Pelkkä liike ei kuluta synkronoituja bittejä. Hengityksen valikkokytkin käyttää 1 bit.

Käänny-toiminto vaatii tuetun makuuasennon ja **Käänny**-valikkokohteen. Ota toiminto asennolle käyttöön ja määritä tarvittaessa sen sivuttaisanimaatio. Valitse asento VRChatissa, ota kääntyminen käyttöön ja vapauta pään/kaulan lukitus. Pään sivuttaiskallistus ohjaa kääntymistä. Tavallinen MotionTime-ohjaus ei ole käytettävissä kyseiselle asennolle Käänny-toimintoa käytettäessä.

Edellä mainituilla kolmella vakioselinmakuuasennolla on sivuttaisliikkeet. Muut asennot vaativat sopivan liikkeen ja asentoasetuksen. Tuotujen tai omien esiasetusten määritykset voivat poiketa.

## 5. Asentojen muokkaus, lisääminen ja esikatselu

Valitse **Asennot**-välilehdessä luokka tai hakuvälilehti. Haku hyväksyy alkuperäiset japaninkieliset nimet ja käytettävissä olevat käännökset. Avaa asennon **Lisätiedot** muokataksesi animaatiota, kuvaketta, järjestystä ja ajoitusasetuksia.

Lisää useita animaatioita vetämällä leikkeet lisäysalueelle tai valitsemalla ne Project-ikkunasta ja käyttämällä valittujen leikkeiden tuontikomentoa. Saman leikkeen päällekkäiset viittaukset poistetaan. Vaihda kohdejärjestys Lisätiedoissa tai käytä ylös- ja alas-ohjaimia.

**Esikatselu** näyttää asennon Scene-näkymässä avaamatta koko säätöikkunaa. Kevyt esikatselu ei suorita Modular Avataria tai NDMF:ää, joten tarkista asut, lattiakorjaus ja muut koontitoiminnot lopullisesta avatarin koonnista.

Avatarista luodut asentokuvakkeet helpottavat asentojen tunnistamista. Luonti kuitenkin vie aikaa ja voi lisätä avatarin datakokoa. Pienennä kuvaketarkkuutta säästääksesi tilaa. Android-koonnit eivät luo asentokuvakkeita. Luo kuvakkeet tarvittaessa uudelleen avatarin tai asun muuttamisen jälkeen.

## 6. Parametrimuisti

Inspector näyttää asentotyökalujen osuuden, ei koko avatarin yhteiskulutusta. Asut ja muut järjestelmät voivat kuluttaa lisäksi parametrimuistia. Usean asentotyökalun yhteisiä asetuksia ei lasketa kahdesti. Omat kokoonpanot, joissa on paljon lisäasentoja, voivat tarvita lisää asennonvalintabittejä.

| Toiminto | Synkronoitujen bittien lisäkulutus |
| --- | ---: |
| Asennon valinta, tavallinen vähimmäiskokoonpano | 8 |
| Peilaa | 1 |
| Eleet pois | 1 |
| Hengitysliike | 0 |
| Hengityksen valikkokytkin | 1 |
| Jalkojen kork. | 8 |
| Lattian kork. | 8 |
| Kuvatila, vain paikallinen | 0 |
| Synkronoi Kuvatila | 16 |
| Pidä pää näkyvissä Kuvatilassa | 0 |
| Poista VRChatin oletushuojunta | 0 |
| Käänny | 10 |

Käänny jakaa 1 bit pään suunnan aiheuttaman asentokorjauksen kanssa. Molempien käyttöönotto kuluttaa edelleen yhteensä 10 bittiä näille kahdelle toiminnolle. Asennetussa versiossasi näkyvä kulutus on käytännön viite valitsemallesi kokoonpanolle.

## 7. Päivittäminen ja esikoonti

1. Varmuuskopioi projekti ja tallenna työkohtaus.
2. Päivitä **Kawaii Posing Tool** ja yhteinen **Unisaki Posing System** yhdessä VCC:ssä tai ALCOMissa. Pidä myös vaaditut SDK-, Modular Avatar- ja NDMF-versiot yhteensopivina.
3. Odota kääntämisen valmistumista. Valitse jo asennettu työkalu ja tarkista asennot, asetukset ja parametrikulutus.
4. Jos käytät esikoontia, valitse **Päivitä esikoonti** ja lataa sitten avatar uudelleen.

Nykyiset työkalun asetukset säilyvät. Vanhat 8-bit-Prefabit säilytetään yhteensopivuuden vuoksi. Nykyiset viittaukset eivät edellytä työkalun poistamista tai korvaamista. Uudet asennukset käyttävät tavallista Prefabia. Tarpeettomia toimintoja voi poistaa käytöstä parametrikulutuksen vähentämiseksi.

Vanhentuneen esikoonnin varoitus tarkoittaa, että asetukset ovat muuttuneet välimuistissa olevan koontidatan luonnin jälkeen. Esikoonnin päivitys luo datan uudelleen. Varoituksen piilottaminen ei päivitä esikoontia eikä ratkaise sen syytä. Tavallinen avatarin koonti voi luoda tarvittavan datan ilman, että teet esikoonnin käsin joka kerta.

## 8. Vianmääritys

| Oire | Tarkistettavaa |
| --- | --- |
| Työkalun lisäysvalikko puuttuu | Tarkista, että tuote **ja** Unisaki Posing System on asennettu, ja korjaa Unity Consolen käännösvirheet. Pelkkä lisenssin asennusohjelma ei ole asentokirjasto. |
| Asennus peruttu tai tiedostot poistettu | Tuo ostettu asennusohjelma uudelleen sopivana ajankohtana. Lue vahvistukset uudelleen. |
| Lisenssi näyttää puuttuvan toisessa projektissa | Tuo ostettu asennusohjelma samalla käyttöjärjestelmätilillä. Jos vaihdoit tietokonetta tai tiliä, asenna lisenssi myös sinne. Kieliasetukset eivät siirry tietokoneiden välillä automaattisesti. |
| Asennot puuttuvat VRChatista | Lisää työkalu oikean kohtausavatarin alle, ota halutut asennot käyttöön, tarkista Inspectorin varoitukset ja lataa kyseinen avatar. Tarkista SDK ja muut liikkumistyökalut. |
| Z ei vaihda makuuasentoon | Nosta makuuasennon korkeusrajaa työkalun peliasetuksissa. |
| Kädet tai polvet eivät osu kohdalleen | Kokeile sopivaa avatarin esiasetusta ja käytä sitten tuettua IK:ta ja/tai Animaatiosäätöä. Tarkista asun muodonmuutos lopullisessa koonnissa. |
| Kääntyminen ei toimi | Käytä tuettua makuuasentoa, ota käyttöön asennon kääntymisasetus ja valikkokohde sekä vapauta pään/kaulan lukitus. Kokeile ensin yhtä kolmesta tuetusta vakioasennosta. |
| Kaverit eivät näe Kuvatilan liikettä | Ota **Synkronoi Kuvatila** käyttöön Unityssa, tarkista parametrikulutus ja lataa uudelleen. |
| Kieli vaihtuu Unityssa mutta ei VRChatissa | Lataa avatar uudelleen. Tarkista monikielisen koonnin yhteinen kielivalitsin Inspectorin yläosasta. |
| Koonnin tai esikoonnin virheet | Lue **ensimmäinen** asiaan liittyvä Console-virhe. Varmuuskopioi kohtaus, päivitä tai lataa tuote ja yhteinen järjestelmä uudelleen VCC:llä/ALCOMilla ja ota yhteyttä tukeen, jos ongelma jatkuu. Säilytä säädetyt objektit ja GeneratedResources, ellei tuki anna tarkkaa palautusohjetta. |

Liitä tukipyyntöön tuotteen ja yhteisen järjestelmän versiot, Unityn, SDK:n, Modular Avatarin ja NDMF:n versiot, avatarin nimi, tarkat toistamisvaiheet ja olennainen Console-virhe. Poista julkisista viesteistä yksityiset tiedostot, asennusohjelman sisältö, lisenssiarvot ja tilitiedot.

- [Tuki](https://help.unisakistudio.jp/)
- [Kuvallinen verkko-ohje (japaniksi)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Gumroad-tuotesivu](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Lisenssit ja kiitokset

[Tuotesopimuksen englanninkielinen viitteellinen käännös](../../Terms.en.html) toimitetaan alkuperäisen japaninkielisen sopimuksen rinnalla.

Lue alkuperäinen tuotesopimus ja yhteisen järjestelmän sopimus paketin READMEn vierestä tai ostetun ZIP-paketin `Licenses`-kansiosta. Toimitettu englanninkielinen Unisaki Posing Systemin sopimus on järjestelmän olemassa oleva viitteellinen käännös. Tuotteen japaninkielinen sopimus sisältyy edelleen erikseen. Käyttöohje ei muuta sopimuksia eikä myönnä lisäoikeuksia. Ota yhteyttä tukeen tuotetietojen käyttöä tai uudelleenjakelua koskevissa kysymyksissä.

Asennusohjelma sisältää **anatawa12**:n muokatun **VPMPackageAutoInstallerin** sekä **SimpleJsonin** ja **semver.netin**. Niiden tekijänoikeusilmoitukset ja MIT-lisenssitekstit ovat ostetun ZIP-paketin `ThirdPartyNotices.txt`-tiedostossa. Asentokirjastolla ja muilla tuoteresursseilla on omat tuotelisenssinsä.
