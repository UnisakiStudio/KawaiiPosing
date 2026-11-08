# Kawaii Posing Tool

VRChatin asentojen lukitustyökalu, jolla voit käyttää söpöjä istuma- ja makuuasentoja myös 3 pisteen seurannassa ja työpöytätilassa. Mukana on yhteensä 85 asentoa: 15 seisoma-asentoa, 20 kyykkyasentoa, 17 istuma-asentoa, 16 vatsamakuuasentoa ja 17 selinmakuuasentoa.

Tämä README koskee kehitteillä olevaa versiota v3.2.0. Virallista julkaisupäivää ei ole päätetty. Asennetun version näet Inspectorin yläosasta.

- [BOOTH-tuotesivu](https://yunisaki.booth.pm/items/5479202)
- [Muutosloki](CHANGELOG.md)

## Näyttökieli ja offline-ohjeet

Valitse näyttökieli Inspectorin yläosasta kohdasta ”Language / 言語”. Sama valinta koskee Inspectoria ja luotavaa VRChat-valikkoa. Lataa avatar uudelleen palveluun, jotta pelissä näkyvä kieli vaihtuu.

Jos kieltä ei ole valittu, käytetään tietokoneen kieltä tai englantia, jos kieltä ei tueta. Windows, macOS ja Linux ovat tuettuja. Viimeksi valittu kieli tallennetaan EditorPrefsiin, ja sitä käytetään myös tämän tietokoneen saman käyttöjärjestelmäkäyttäjän muissa projekteissa. Avatariin erikseen tallennettu kielivalinta säilyy. Valintaa ei synkronoida muihin tietokoneisiin. Lisenssin tallennustapa ei muutu.

README-tiedoston, muutoslokin ja käyttöohjeen voit valita mukana toimitetusta [kieliluettelosta](../index.html). Myös Inspectorin käyttöohje ja muutosloki noudattavat valittua kieltä. Alkuperäiset käyttöehdot ja viitteelliset käännökset toimitetaan edelleen erikseen.

## Tärkeimmät toiminnot

- Kuvatila: siirrä avataria enintään 3m eteenpäin ja säädä sen suuntaa. Vain omalla näytöllä käyttö kuluttaa 0 bit. Sijainnin ja suunnan näyttäminen muille kuluttaa 16 bit.
- Pään näyttäminen kuvauksessa: estä lähellä olevan oman avatarisi pään piilottaminen vain Kuvatilan ajaksi.
- Lattian kork.: siirrä koko kehoa pää mukaan lukien 3m ylös tai alas. 50% on alkuperäinen korkeus ja oletusarvo, 0% on 3m alempana ja 100% on 3m ylempänä. Tämä täydentää Jalkojen kork. -toimintoa, joka liikuttaa jalkojen puolta pään pysyessä paikallaan.
- Käänny: käänny tuetuissa makuuasennoissa vasemmalle ja oikealle pään kallistuksen mukaan.
- Hengitys: lisää hengitysliikettä esimerkiksi rintaan. Valitse asentoluokittain Ei mitään, Heikko, Keskivahva, Vahva, Nopea tai Oma.
- Poista VRChatin oletushuojunta: vähennä oletusarvoista joutokäyntihuojuntaa säilyttäen työkalun hengityksen ja muut omat liikkeet.
- Vähennä pään kierrosta aiheutuvaa asennon vääristymää: vähennä alkuperäisestä asennosta poikkeavan pään suunnan aiheuttamaa vääristymää pään lukituksen vapautuessa.
- Toimintojen valinta: lisää vain tarvittavat pelivalikot ja tarkista ExpressionParameters-kulutus Inspectorista.
- Asentoluettelon haku, joukkolisäys ja järjestäminen: hae kaikista luokista, tuo useita leikkeitä ja määritä järjestyksen siirtokohta.
- Kevyt esikatselu Scenessä: tarkista asento suoraan asentoluettelon Esikatselu-toiminnolla.

- Raajojen automaattinen säätö (IK): mukauta tuettujen asentojen raajojen sijainti avatarin mittasuhteisiin. Voit kytkeä toiminnon asentokohtaisesti ja tallentaa tuloksen säätöanimaatioon.

### Kääntyminen mukana toimitetuissa asennoissa

Selinmakuuasennoille ”Jalat ojossa”, ”Rentona” ja ”Yksi polvi ylös” on määritetty kääntymisen sivuasennot. Ne perustuvat vastaavasti asentoihin ”Kyljellään”, ”Torkut” ja ”Kissantorkut”.

Ota ”Toiminnot > Valikkotoiminnot > Käänny” käyttöön ja lataa avatar palveluun. Valitse VRChatissa tuettu asento ja Käänny-toiminto. Vapauta pään lukitus ennen käyttöä.

Jos määrität tuen itse, ota ”Asennot > Lisätiedot > Ota Käänny käyttöön” käyttöön ja lisää animaatio kohtaan ”Käänny-toiminnon sivuasento”. Tavallinen MotionTime-asetus ei ole käytettävissä Käänny-toimintoa käyttävissä asennoissa.

### Sovittaminen avatarin mittasuhteisiin

Mukana tulevaa raajojen automaattisäätöä voi käyttää, mutta kaikki asennot eivät tarvitse IK:ta. Animaatiosäätöikkunan ”Ota raajojen automaattinen säätö käyttöön” kytkee toiminnon yleisesti ja ”Ota IK käyttöön tälle asennolle” kytkee sen asentokohtaisesti.

”Tallenna IK säätöihin” kirjoittaa senhetkisen automaattisäätötuloksen uuteen säätöanimaatioon ja poistaa kyseisen asennon IK:n käytöstä. Voit viimeistellä tuloksen tämän jälkeen käsin. Toiminto on käytettävissä, kun yleinen ja asentokohtainen automaattisäätö ovat käytössä ja sopivat IK-asetukset löytyvät.

Avatarin asetuksissa ovat myös ”Estä polvien taittuminen taakse” ja sen lisätietojen ”Polven vähimmäistaivutus (asteina)”.

## Asennus

1. Lataa tiedostot ostamasi kaupan tuotesivulta.
2. Tuo mukana oleva ”可愛いポーズツール.unitypackage” Unityyn ja rekisteröi lisenssi sekä pakettien jakelulähde.
3. Lisää Kawaii Posing Tool ja Modular Avatar Unity-projektiin VCC:llä tai ALCOMilla. Yhteinen Unisaki Posing System ja NDMF asennetaan riippuvuuksina.
4. Napsauta kohdeavataria Hierarchyssa hiiren oikealla painikkeella ja valitse ”Unisaki Studio > Lisää Kawaii Posing”.
5. Valitse avatariin lisätty ”可愛いポーズ (Kawaii Posing)” ja määritä haluamasi toiminnot ja asennot Inspectorissa.
6. Lataa avatar palveluun tavalliseen tapaan.

Vaatimukset ovat Unity 2022.3, VRChat Avatars SDK 3.10.4 tai uudempi, Modular Avatar 1.x vähintään 1.15.1 ja NDMF 1.x vähintään 1.14.0. Päivitä tarvittavat paketit yhdessä VCC:llä tai ALCOMilla.

## Päivittäminen vanhemmasta versiosta

Päivitä tämä tuote ja Unisaki Posing System yhdessä. Kohtaukseen sijoitettujen työkalujen asetukset säilyvät. Tarkista käytössä olevat toiminnot ja ExpressionParameters-kulutus Inspectorista. Jos käytit esikoontia, paina ”Päivitä esikoonti” ennen uudelleenlatausta.

Versiosta v3.1.0 lähtien uusi asennus käyttää aina tavallista 可愛いポーズ (Kawaii Posing) -Prefabia. Poista tarpeettomat toiminnot käytöstä Toiminnot-välilehdessä, jolloin pelkän asennonvalinnan vähimmäiskulutus on 8 bit. Suuri asentomäärä voi vaatia lisää bittejä asennon valintaan.

Vanha 8bit-Prefab säilytetään Editor/Legacy-kansiossa olemassa olevien avatarien ja esiasetusten viittausten säilyttämiseksi. Nykyisiä Prefabeja ei tarvitse poistaa tai korvata. 8bit-versiota ei näytetä Unityn uuden asennuksen valikossa.

## Asetusten sijainti

| Välilehti | Toiminnot |
| --- | --- |
| Toiminnot | Pelivalikoiden lisääminen, lisätoiminnot, hengitysasetukset sekä kuvakkeiden ja ExpressionParameters-kulutuksen tarkistus |
| Asennot | Käytettävien asentojen valinta, lisätiedot, haku, joukkolisäys, järjestäminen, esikatselu ja animaatiosäätö |
| Avatarin asetukset | Avatarikohtainen korjaus, polvikorjaus, alkuperäisten asentojen ja omien liikkeiden tuonti sekä esiasetusten vaihto |

Avaa asetukset näyttää tarkat asetukset kyseisen kohdan alapuolella. Hengitystä säädetään kohdasta ”Toiminnot > Lisätoiminnot > Animoi hengitys”.

”Käytä alkuperäisiä seisoma-, kyykky- ja vatsa-asentoja” tuo avatarin olemassa olevat asennot automaattisesti. Jos käytät omia liikkeitä, avaa erilliset tuontiasetukset ja määritä ne tyypeittäin, esimerkiksi seisominen, kyykky (Crouching) ja vatsamakuu (Prone).

Esiasetukset löytyvät Avatarin asetukset -välilehden lopusta. ”Käytä tätä esiasetusta” korvaa nykyiset asentoasetukset, joten tallenna tekemäsi säädöt ennen vaihtamista.

### Toimintokohtainen muistinkulutus

- Hengitysliike kuluttaa 0 bit. Vain jos käytät pelin pysäytys- ja jatkokytkintä ”Valikkotoiminnot > Hengitys”, kytkimen synkronointi kuluttaa 1 bit.
- Kuvatila kuluttaa 0 bit vain omalla näytöllä. ”Lisätoiminnot > Synkronoi Kuvatila” kuluttaa 16 bit. ”Pidä pää näkyvissä Kuvatilassa” kuluttaa 0 bit.
- ”Jalkojen kork.” ja ”Lattian kork.” kuluttavat kumpikin 8 bit. Lattian korkeuden siirtäminen keskeltä liikuttaa kehoa ylös tai alas. Paluu lähelle 50% lopettaa korjauksen.
- ”Käänny” kuluttaa yksin 10 bit. Se jakaa 1 bit pään kierrosta aiheutuvan asennon vääristymän vähentämisen kanssa, joten molempien yhteiskulutus on 10 bit.
- ”Peilaa” ja ”Eleet pois” kuluttavat kumpikin 1 bit.

Inspectorin yhteismäärä koskee avatariin asennettuja asentotyökaluja. Asujen tai muiden toimintojen kulutus ei sisälly siihen. Usean asentotyökalun yhteisiä asetuksia ei lasketa kahdesti.

### Esikatselu ja asentojen muokkaus

Voit näyttää asennon Scenessä Asennot-välilehden asentokohtaisella Esikatselu-toiminnolla. Jos haluat muokata sitä tarkemmin, avaa Animaatiosäätö, tarkista ja säädä asentoa sekä tallenna.

Kevyt esikatselu ei suorita MA:n tai NDMF:n koontikäsittelyä. Tarkista myös koontitulos ennen latausta, sillä asu ja lattian sijainnin korjaus voivat tulla mukaan vasta koonnissa.

Vasemman reunan suurennuslasivälilehdessä voit hakea asentoa nimellä. Voit järjestää asentoja Lisätiedot-kohdan Järjestys-valikolla tai ylös- ja alas-painikkeilla. Lisää useita animaatioita vetämällä ne lisäyskenttään tai tuomalla Projectissa valitut leikkeet.

”Päivitä asentojen pikkukuvat” luo kuvat vahvistusikkunan jälkeen. ”Luo asentokuvakkeet” helpottaa asentojen tunnistamista pelivalikossa, mutta kuvien luonti pidentää koontiaikaa. Valitse ”Pienennä kuvakkeita” vähentääksesi kokoa. Androidille asentokuvakkeita ei luoda.

## Pelin perusohjaimet

- Valitse asento kullekin luokalle Expressions-valikosta. VR:ssä seisoma-, kyykky-, istuma- ja makuuasentojen välillä vaihdetaan pään korkeuden mukaan.
- Makuuasennossa kasvojen suunta vaihtaa selin- ja vatsamakuun välillä. Jos molemmille on valittu asento, myös paikallaan hyppääminen vaihtaa niiden välillä. Hypyllä vaihtamisen voi poistaa Unityssa kohdasta ”Toiminnot → Lisätoiminnot → Vaihda makuuasentoa hyppäämällä” (oletuksena käytössä). Luokkien vaihtumiskorkeutta säädetään asetusvalikon raja-arvoilla.
- Työpöytätilassa vaihda asentoa C- ja Z-näppäimillä. Jos Z ei vaihda makuuasentoon, nosta makuuasennon korkeusrajaa asetusvalikossa.
- ”Eleet pois” käyttää asennon määrittämää kädenmuotoa ohjaimen sormieleen sijaan.
- ”Jalkojen kork.” säätää jalkojen puolta pitäen pään paikallaan. ”Lattian kork.” siirtää koko kehoa pää mukaan lukien pystysuunnassa. Ne ovat tässä järjestyksessä asetusvalikossa.
- Kun siirryt Kuvatilan Etäisyys-säätimellä eteenpäin, avatar kääntyy sinua kohti. Kierrä Suunta-säätimellä ja ota ”Lukitse jalat” käyttöön sopivalla hetkellä. ”Lopeta kuvaus” palauttaa etäisyyden ja suunnan sekä vapauttaa jalkojen lukituksen.
- Hengitys on käytettävissä, kun hengitysliike on käytössä. Voimakkuus asetetaan Unityssa. Pelissä vaihdetaan toiminnon kytkintä.

## Esikoonti ja varoitukset

”Päivitä esikoonti” nopeuttaa avatarin koontia käyttämällä luotua dataa uudelleen. Myös ilman esikoontia tavallinen koonti luo tarvittavan datan.

Asetusmuutosten jälkeen Inspectorin yläosan ”Tarkista asetukset” ja Hierarchyn merkki ilmoittavat päivitystarpeesta. ”Varoitusten näyttöasetukset” on Tarkista asetukset -kehyksessä. Näytön piilottaminen ei ratkaise asetusongelmia eikä päivitä luotua dataa.

## Huomioita käytöstä

- Asennon lukitusta kokovartaloseurannassa ei tueta.
- Mittasuhteet, asu ja avatarin muutokset voivat edellyttää lisäsäätöjä.
- Erityiset Base-tasot tai muut asentoa muuttavat toiminnot eivät välttämättä yhdisty odotetusti. Jos lukitus ei toimi, tarkista myös ”Avatarin asetukset > Yhdistä seurantalukitukset muihin työkaluihin”.
- Kuvatilan liike, kierto ja lattian korkeus korjaavat myös oletus- ja omia liikkeitä silloin, kun asentoa ei ole valittu. Tarkista näkymän sekä oletusliikkeiden korvaamisen jälkeinen toiminta käytännössä VRChatissa.
- ”Poista VRChatin oletushuojunta” koskee oletusarvoista joutokäyntiliikettä. Se ei pysäytä kaikista muista syistä syntyvää huojuntaa.

## Käyttöohjeet ja tuki

Inspectorin yläosan ohje- ja muutoslokkipaneelista voit avata käyttöohjeet, tuen ja muutoslokin. Yhteisten toimintojen tarkemmat ohjeet ovat myös Unityn Project-näkymässä kohdassa ”Packages > Unisaki Posing System > README”.

- [Virallinen käyttöohje](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Ota yhteyttä](https://help.unisakistudio.jp/)

Liitä virheilmoitukseen tämän tuotteen ja Unisaki Posing Systemin versiot, Unityn, VRChat SDK:n, Modular Avatarin ja NDMF:n versiot, käytetty avatar, toistamisohjeet sekä Consolen virheteksti.

## Esiasetusten jakaminen

Seuraava koskee animaatiosäätötoiminnolla luotua dataa.

Tällä toiminnolla luotuja säätöanimaatiotiedostoja sekä niitä käyttäviä esiasetuksia voi jakaa ja myydä vapaasti pyytämättä lupaa Unisaki Studiolta. Voit esimerkiksi jakaa niitä omien avatariesi mukana tai tehdä esiasetuksia avatareille, joita ei toimiteta työkalun mukana.

## Tuotteet, joiden yhteensopivuusasetukset sisältyvät

Huomaa: kauppamme on tehnyt yhteensopivuusasetukset omasta aloitteestaan. Emme ole pyytäneet tuotteiden tekijöiden lupaa, koska katsomme, ettei sitä tarvita. Jos haluat asetuksia jaettavaksi tai niiden jakelun lopetettavaksi, ota yhteyttä kaupan viesteillä. Yhteensopivuusasetusten käyttö edellyttää kyseisten tuotteiden ostamista tai lataamista. Asetusten ongelmista tulee ottaa yhteyttä kauppaamme, ei kyseisten tuotteiden tekijöihin.

”可愛い座りツール”
https://yunisaki.booth.pm/items/3611536

”添い寝ツール”
https://yunisaki.booth.pm/items/3670993

”少女モーション集vol.1”, tekijä ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

”VRC想定移動モーション（無料配布）”, tekijä カトのVRC道具屋
https://booth.pm/ja/items/1285101

”ごろ寝システムEX”, tekijä minminmart
https://minminmart.booth.pm/items/4233545

## Käyttöehdot

Työkalua voivat käyttää vain seuraavat VN3-lisenssillä laaditut käyttöehdot hyväksyvät henkilöt.

[Käyttöehdot (japaniksi)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Tämän repositorion lähdekoodi ja resurssit eivät ole avointa lähdekoodia. Tuotteen laillinen ostaminen ja käyttöehtojen hyväksyminen ovat välttämättömiä.

[Käyttöehdot (englanniksi)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
