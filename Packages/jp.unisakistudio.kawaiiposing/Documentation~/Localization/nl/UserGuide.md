# Kawaii Posing — Nederlandse handleiding

Kawaii Posing biedt 85 poses voor desktop en driepunt-VR: 15 staand, 20 hurkend/op stoel, 17 zittend op de grond, 17 op de rug en 16 op de buik.

Deze gids beschrijft installeren, avatarinstellingen, VRChat-bediening, bewerken, updates en problemen. `START_HERE.html` in het gekochte ZIP leidt het snelst naar installatie.

## Voor je begint

- Gebruik een Unity 2022.3 VRChat-**avatarproject** via VRChat Creator Companion (VCC) of ALCOM.
- Nodig: VRChat Avatars SDK 3.10.4+, Modular Avatar 1.x vanaf 1.15.1 en NDMF 1.x vanaf 1.14.0.
- Voor Humanoid op desktop en VR met headset/twee controllers. Posevergrendeling met volledige lichaamstracking niet ondersteund.
- Maak een reservekopie voor installatie/updates en los eerst compilatiefouten op.
- De installer downloadt product/afhankelijkheden uit repositories, met internet. Avatarmodellen, VRChat SDK, Modular Avatar en NDMF zitten niet in het ZIP.

## 1. Licentie en product installeren

1. Pak het hele ZIP uit buiten je Unity-project.
2. Open het juiste project en importeer `Installer/KawaiiPosing_Installer.unitypackage` via **Assets > Import Package > Custom Package**, of open met Unity.
3. Lees import-/installatiebevestigingen. De licentiebevestiging noemt welke licenties komen. Gebruik **Taal…** of **言語...** om taal te wijzigen.
4. Bevestig de licentie, ook voor Unisaki Posing System. Opruimen van installerbestanden achteraf verwijdert de licentie niet.
5. Controleer automatische pakketinstallatie: pakketten/bronnen en voorgestelde oude bestanden/mappen. Ga door als dit klopt.
6. Wacht op import/compilatie. Voeg bij mislukte automatische installatie **Kawaii Posing** en **Modular Avatar** via VCC/ALCOM toe. **Unisaki Posing System** en **NDMF** zijn afhankelijkheden. `Optional-VCC-Links` bevat oorspronkelijke repositorysnelkoppelingen voor VCC op Windows.
7. Na annuleren importeer opnieuw wanneer je klaar bent. Met aanwezige activator kan ook de licentieopdracht onder **Tools > Unisaki Studio**; oudere builds noemen dat **ゆにさきスタジオ**.

### Wat deze download installeert

**Kawaii Posing 3.2.0 met Unisaki Posing System 3.2.0.** In ontwikkeling en niet uitgebracht. Dertig talen voor installatie, Unity-Inspector/menu’s, standaardnamen, spelmenu’s en offline documenten. Datum nog onbekend. Kies boven in de Inspector. Na publicatie downloadt de installer deze versies en passende afhankelijkheden uit VPM. Lokale voorbereiding publiceert niets.

Kawaii Posing bevat poses, instellingstools en avatarvoorinstellingen. De installer activeert de bestaande lokale licentie, zonder nieuw Gumroad-sleutelveld. Plaats nooit installer- of licentiedata openbaar in hulpvragen.

Taal staat in Unity EditorPrefs voor de systeemgebruiker, gedeeld tussen projecten op deze computer. Zonder voorkeur systeemtaal/Engels. Licenties blijven in `Software/UnisakiStudio` voor Windows of gebruikersbestanden op macOS/Linux. Taal wijzigen verwijdert niets. Alle posehulpmiddelen en avatars gebruiken dezelfde taal. Een wijziging in de Inspector van een hulpmiddel werkt de gedeelde voorkeur bij; taalkeuzes per avatar worden genegeerd. De taalknop verschijnt alleen bij de eerste installatiebevestiging als er nog geen taal is opgeslagen. Latere taalwijzigingen gebeuren in de Inspector.

## 2. Toevoegen aan een avatar

1. Kies avatar met **VRC Avatar Descriptor** of kind in **Hierarchy**. Een scèneobject, niet Project-Prefab of Prefab Mode.
2. Rechtsklik: **Unisaki Studio > Kawaii Posing toevoegen**. Bij Japanse menu’s: **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Opgeslagen naam kan **可愛いポーズ** blijven ondanks vertaalde labels.
4. Pas aangeboden passende voorinstelling toe of kies/werk zelf onder **Avatarinstellingen**.
5. Voorberekening is optioneel: normale build genereert ook data. Hergebruik versnelt latere builds.
6. Selecteer tool, poses en functies en upload met VRChat SDK.

### Taalkeuze en bekende labels

**Language / 言語** staat bovenaan. Eén keuze stuurt Inspector/menu en wordt in de avatar bewaard, met laatste keuze voor andere tools/projecten op deze computer. Upload opnieuw voor een andere taal in VRChat.

Gebruik de tabel bij oude Japanse tutorials. Deze versie heeft selector, Inspector, standaardnamen en spelmenu’s in alle 30 talen.

| Nederlands | Japans label in oudere builds |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Functies | 機能 |
| Poses | ポーズ一覧 |
| Avatarinstellingen | アバター調整 |
| Instellingen openen | 設定を開く |
| Voorberekening bijwerken | プレビルドを更新 |
| Instellingen controleren | 設定の確認 |
| Voorbeeld | プレビュー |
| Animatieaanpassing | アニメーション調整 |
| Opnieuw laden | 再読込 |

Inspector, bewerkings-/installatiedialogen, standaardnamen en menu’s zijn in 30 talen. README, geschiedenis en offline gids in elke taal. Avatarnamen, opgeslagen objecten, eigen poses, bestanden en interne ID’s kunnen origineel blijven.

De [korte referenties in 30 talen](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) bevatten functies en standaardnamen. Gebruik de talenindex voor volledige documentatie.

## 3. Poses en functies kiezen

De Inspector heeft drie hoofdtabbladen:

| Tabblad | Doel |
| --- | --- |
| **Functies** | Spelmenu’s, opties, ademhaling, pictogrammen en parameters. |
| **Poses** | Actieve poses, categorie/zoeken, volgorde, toevoegen, voorbeeld, details en animatieaanpassing. |
| **Avatarinstellingen** | Avatar-/kniecorrectie, oorspronkelijke/eigen import en voorinstellingen. |

Activeer alleen gewenste menu’s. **Spiegelen** toevoegen maakt het effect schakelbaar, niet permanent voor alle poses.

Kawaii Posing heeft voorinstellingen en ondersteunde IK. **Benen gestrekt (足伸ばし)**, **Ontspannen (リラックス)** en **Eén knie omhoog (膝立て)** hebben zijbewegingen. Gebruik een passende voorinstelling en controleer Omdraaien na bewerken/vervangen.

### Voorinstellingen en pasvorm

Voorinstellingen staan onderaan **Avatarinstellingen**. Zoek op avatarnaam en vervang de huidige poses met een voorinstelling. Sla aanpassingen eerst op. Het is een uitgangspunt; proporties, kleding en wijzigingen kunnen handcorrecties vragen.

**Animatieaanpassing** toont en bewerkt lichaam/ledematen. Sla vanuit het venster op na afloop. Ondersteunde IK is globaal en per pose schakelbaar. Vastleggen maakt een aanpassingsanimatie en zet pose-IK uit voor handmatig vervolg; de originele clip blijft.

**Achterwaartse kniebuiging voorkomen** heeft extra opties zoals minimumhoek. Avatarcorrecties vereisen passende data en sommige combineren niet met IK.

### Oorspronkelijke en eigen bewegingen

**Oorspronkelijke staande, hurkende en buikposes gebruiken** detecteert Base bij generatie. **Eigen bewegingen gebruiken** opent aparte import per type. Eén per type; handmatige toewijzing gaat voor.

Automatische import werkt op de buildkopie, zonder handmatige scènelijst of broncontrollers te wijzigen. Wis een handmatige override voor opnieuw detecteren. Eigen Base en andere locomotie kunnen speciale afstemming vragen.

## 4. Gebruiken in VRChat

Open **Expressions** en **Kawaii Posing**. Kies een pose per gewenste categorie. Posen en functies selecteren zijn aparte acties.

- **Driepunt-VR:** hoofd omhoog/omlaag voor staan, hurken/stoel, vloerzitten en liggen. Pas drempels aan bij te vroeg/laat wisselen.
- **Desktop:** **C** hurken, **Z** liggen; verhoog ligdrempel als je blijft zitten.
- **Rug/buik:** gezichtsrichting kiest, beide maakt sprongwissel mogelijk. Uit onder **Functies > Gemaksfuncties**, zonder extra gesynchroniseerde kosten.
- **Vergrendelen:** hoofd, armen, voeten naar behoefte. Gebaren uit gebruikt posehanden.
- **Spiegelen:** draai de pose om voor vrienden of compositie.

### Voethoogte en Vloerhoogte

**Voethoogte** past voeten aan met vast hoofd. Gebruik bij zwevende/ingezakte voeten terwijl de hoofdhoogte klopt.

**Vloerhoogte** beweegt alles, ook hoofd. Voor bank, bed of verhoging zonder collider. Gecentreerd is **50% oorspronkelijk**, 0% 3 m lager en 100% 3 m hoger. Terug nabij 50% stopt. Oude versies kunnen verschillen; werk kern en product samen bij.

### Fotomodus

Activeer **Fotomodus** in Unity voor upload. Kies in VRChat pose, **Afstand** tot 3 m vooruit en **Richting** voor draaien. Voetvergrendeling is optioneel tijdens positioneren. **Foto afsluiten** herstelt en ontgrendelt.

Fotomodus standaard lokaal. **Fotomodus synchroniseren** voor upload maakt positie/draai zichtbaar voor anderen, voor 16 bits. **Hoofd zichtbaar houden in Fotomodus** alleen eigen zicht zonder bits.

### Ademhaling en Omdraaien

Stel ademhaling per categorie in onder **Functies > Gemaksfuncties > Ademhaling animeren**. Geen, Zwak, Gemiddeld, Sterk, Snel of eigen animatie. Alleen beweging 0 bits; schakelmenu 1 bit.

Omdraaien vereist ondersteunde ligpose en **Omdraaien** in het menu. Activeer de poseoptie en wijs zijanimatie toe. Kies in VRChat de pose, zet Omdraaien aan en ontgrendel hoofd/nek. Zijwaartse hoofdhelling stuurt; normale MotionTime niet beschikbaar.

De drie genoemde rugposes bevatten zijbewegingen. Andere vereisen juiste animatie en opties. Eigen/geïmporteerde voorinstellingen kunnen andere toewijzingen hebben.

## 5. Poses bewerken, toevoegen en bekijken

Kies in **Poses** categorie/zoeken. Oorspronkelijke Japanse namen en vertalingen werken. Open **Details** voor animatie, pictogram, volgorde en tijd.

Sleep meerdere clips of selecteer in Project en importeer geselecteerde. Dubbele verwijzingen verdwijnen. Kies doelvolgorde in Details of gebruik omhoog/omlaag.

**Voorbeeld** toont in Scene zonder heel venster. Geen MA/NDMF; controleer kleding, grond en andere buildfuncties in de uiteindelijke avatar.

Avatarpictogrammen herkennen poses maar kosten tijd/data. Verlaag resolutie voor ruimte. Geen Android-pictogrammen. Vernieuw na avatar-/kledingwijzigingen.

## 6. Parametergeheugen

Inspector toont alleen posetools, niet de hele avatar. Kleding en andere systemen gebruiken meer. Gedeelde opties tellen niet dubbel. Veel extra poses kunnen meer selectiebits kosten.

| Functie | Extra gesynchroniseerde bits |
| --- | ---: |
| Minimale standaardposeselectie | 8 |
| Spiegelen | 1 |
| Gebaren uit | 1 |
| Ademhaling bewegen | 0 |
| Ademhalingmenu | 1 |
| Voethoogte | 8 |
| Vloerhoogte | 8 |
| Fotomodus lokaal | 0 |
| Fotomodus synchroniseren | 16 |
| Hoofd zichtbaar houden in Fotomodus | 0 |
| Standaardwiegen van VRChat uitschakelen | 0 |
| Omdraaien | 10 |

Omdraaien deelt 1 bit met de nekrichtingscorrectie: samen nog 10 bits. De weergave van jouw versie is de praktische referentie.

## 7. Bijwerken en voorberekenen

1. Maak een reservekopie en sla de scène op.
2. Werk **Kawaii Posing** en **Unisaki Posing System** samen bij met VCC/ALCOM, met passend SDK/Modular Avatar/NDMF.
3. Wacht op compilatie en controleer poses, opties en verbruik.
4. Gebruik **Voorberekening bijwerken** indien gebruikt en upload opnieuw.

Bestaande opties blijven. Oude 8-bit-Prefabs voor compatibiliteit zonder verwijderen/vervangen. Nieuwe normale Prefab kan overbodige functies uitschakelen voor minder parameters.

Een verouderde voorberekening meldt gewijzigde opties sinds cachegeneratie. Bijwerken vernieuwt. Verbergen doet dat niet en repareert de oorzaak niet. Normale builds maken data zonder iedere keer handmatig voorberekenen.

## 8. Problemen oplossen

| Probleem | Controle |
| --- | --- |
| Toevoegmenu ontbreekt | Product **en** Unisaki Posing System installeren en Console-compilatiefouten oplossen. Licentieinstaller alleen is geen bibliotheek. |
| Installer geannuleerd/bestanden weg | Importeer opnieuw en lees bevestigingen. |
| Licentie ontbreekt in ander project | Importeer met hetzelfde systeemaccount; op andere pc/account ook installeren. Taal verhuist niet automatisch. |
| Geen poses in VRChat | Onder juiste scèneavatar plaatsen, poses aan, meldingen controleren, die avatar uploaden. SDK/locomotie controleren. |
| Z laat niet liggen | Ligdrempel verhogen. |
| Handen/knieën passen niet | Voorinstelling, ondersteunde IK en/of Animatieaanpassing; kleding in eindbuild controleren. |
| Omdraaien werkt niet | Ondersteunde pose, poseoptie/menu aan, hoofd/nek los. Probeer eerst een van de drie standaardposes. |
| Vrienden zien fotobeweging niet | **Fotomodus synchroniseren**, verbruik controleren, opnieuw uploaden. |
| Taal alleen in Unity anders | Opnieuw uploaden; enige selector bovenaan controleren. |
| Build-/voorberekeningsfouten | **Eerste** relevante Console-fout lezen. Scène veiligstellen, product/kern met VCC/ALCOM vernieuwen en hulp vragen als het blijft. Aangepaste objecten en GeneratedResources bewaren tenzij expliciet hersteladvies. |

Geef de product-/systeemversies, Unity/SDK/Modular Avatar/NDMF-versies, avatarnaam, exacte stappen en de relevante Console-fout. Verwijder privébestanden, installerinhoud, licenties en accountdetails uit openbare hulpvragen.

- [Ondersteuning](https://help.unisakistudio.jp/)
- [Geïllustreerde online handleiding (Japans)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Gumroad-productpagina](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licenties en credits

Een [Engelse referentievertaling van de productvoorwaarden](../../Terms.en.html) zit bij het Japanse origineel.

Lees product- en kernvoorwaarden naast README of in `Licenses` van het ZIP. De Engelse kernvoorwaarden zijn een bestaande referentievertaling; Japanse productvoorwaarden blijven apart. Deze handleiding wijzigt de overeenkomsten niet en verleent geen extra rechten. Vraag ondersteuning bij gebruik/verspreiding van productdata.

Installer bevat aangepaste **VPMPackageAutoInstaller** van **anatawa12**, met **SimpleJson** en **semver.net**. Copyrightvermeldingen en MIT-licentieteksten staan in `ThirdPartyNotices.txt` in het gekochte ZIP. Bibliotheek en bronnen hebben eigen productlicenties.
