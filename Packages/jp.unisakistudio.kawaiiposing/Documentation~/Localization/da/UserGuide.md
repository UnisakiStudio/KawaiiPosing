# Kawaii Posing Tool — Dansk brugervejledning

Kawaii Posing har 85 positurer til skrivebord og 3-punkts-VR: 15 stående, 20 i hug/på stol, 17 siddende på gulvet, 17 på ryggen og 16 på maven.

Vejledningen dækker installation, avataropsætning, VRChat-betjening, positurredigering, opdatering og fejlfinding. Den købte ZIP indeholder `START_HERE.html` til hurtig installation.

## Før du begynder

- Brug et Unity 2022.3-projekt til VRChat-**avatarer**, oprettet eller administreret med VRChat Creator Companion (VCC) eller ALCOM.
- Kræver VRChat Avatars SDK 3.10.4 eller nyere; Modular Avatar 1.x fra 1.15.1; NDMF 1.x fra 1.14.0.
- Værktøjet er til Humanoid-avatarer på skrivebord og i 3-punkts-VR (headset og to controllere). Positurlåsning med aktiv fuldkropssporing understøttes ikke.
- Sikkerhedskopiér eksisterende projekter før installation eller opdatering. Løs alle Unity-kompileringsfejl først.
- Installationen henter produkt og afhængigheder fra pakkearkiver. Internet kræves. Avatarmodeller, VRChat SDK, Modular Avatar og NDMF følger ikke med ZIP-filen.

## 1. Installér licens og produkt

1. Pak hele ZIP-filen ud i en almindelig mappe uden for Unity-projektet.
2. Åbn det ønskede avatarprojekt i Unity. Importér `Installer/KawaiiPosing_Installer.unitypackage` via **Assets > Import Package > Custom Package**, eller åbn filen med Unity.
3. Læs import- og installationsmeddelelser. Licensbekræftelsen forklarer, hvilke produktlicenser der installeres. Brug **Sprog…** (eller **言語...**) i en bekræftelsesdialog for at skifte installationssprog.
4. Bekræft licensinstallation. Licensen omfatter også det fælles Unisaki Posing System, som produktet bruger. Installationen kan bagefter tilbyde at fjerne egne installationsfiler; dette fjerner ikke produktlicensen.
5. Gennemse automatisk pakkeinstallations bekræftelse med pakker/arkiver, der tilføjes, og ældre filer/mapper, der foreslås fjernet. Fortsæt, hvis det er de ønskede elementer.
6. Lad Unity færdiggøre import og kompilering. Afsluttes installationen ikke automatisk, skal du åbne projektet i VCC eller ALCOM og tilføje **Kawaii Posing Tool** og **Modular Avatar**. Fælles **Unisaki Posing System** og **NDMF** er afhængigheder. `Optional-VCC-Links` indeholder produktets oprindelige arkivgenveje til Windows-VCC-brugere.
7. Blev en bekræftelse annulleret, skal du importere igen, når du er klar. Licensinstallationskommandoen under **Tools > Unisaki Studio** kan også bruges, mens aktivatoren findes. Ældre versioner kalder undermenuen **ゆにさきスタジオ**.

### Hvad denne download installerer

**Kawaii Posing Tool 3.2.0 med Unisaki Posing System 3.2.0.** Versionen er under udvikling og endnu ikke udgivet. Den tilføjer installationsdialoger, Unity Inspector og menuer, standardnavne, spilmenuer og offlinedokumentation på tredive sprog. Udgivelsesdato er ikke fastsat. Brug sprogvalget øverst i Inspector til at skifte værktøjssprog. Efter offentliggørelse henter installationen disse versioner og kompatible afhængigheder fra VPM-arkiver. Lokal udgivelsesforberedelse offentliggør ikke pakkerne.

Kawaii Posing Tool indeholder positurbibliotek, konfigurationsværktøjer og avatarjusteringsforudindstillinger. Installationen aktiverer produktets eksisterende lokale licens og kræver intet nyt Gumroad-licensnøglefelt. Del aldrig installationsfiler eller licensdata i offentlige supporthenvendelser.

Sprogvalg gemmes i Unity EditorPrefs for den aktuelle OS-bruger og deles mellem projekter på computeren. Uden gemt valg følger installationen OS-sproget med engelsk ved manglende støtte. Licenser bevarer lagringen: brugerens `Software/UnisakiStudio`-registreringsnøgle i Windows og brugerlicensfiler på macOS/Linux. Sprogskift fjerner ikke en licens. Alle positurværktøjer og avatarer bruger samme sprog. En ændring i et hvilket som helst værktøjs Inspector opdaterer den fælles indstilling; sprogvalg for enkelte avatarer ignoreres. Sprogknappen vises kun ved den første installationsbekræftelse, hvis der ikke er gemt et sprog. Senere sprogændringer foretages i Inspector.

## 2. Tilføj værktøjet til en avatar

1. Vælg avataren med **VRC Avatar Descriptor**, eller et underobjekt, i **Hierarchy**. Brug en sceneavatar, ikke et prefab-asset i Project eller Prefab Mode.
2. Højreklik og vælg **Unisaki Studio > Tilføj Kawaii Posing**. Med japanske menuer vælges **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Værktøjet tilføjes i avataren. Det gemte objektnavn kan fortsat være **可愛いポーズ**, selv med oversatte visningstekster.
4. Anvend passende avatarforudindstilling, hvis tilbudt. Ellers åbner du **Avataropsætning** og vælger en forudindstilling eller justerer selv.
5. Installationen kan tilbyde forberegning. Det er valgfrit; normalt avatarbuild genererer også data. Genbrug forberegninger for kortere senere byggetid.
6. Vælg værktøjsobjektet, konfigurér positurer/funktioner og upload normalt med VRChat SDK.

### Sprogvalg og kendte etiketter

Versionen har **Language / 言語** øverst i Inspector. Ét valg styrer Inspector og genereret spilmenu. Avataren gemmer sit sprog, og seneste valg huskes til andre værktøjer/projekter på computeren. Upload igen for at skifte VRChat-sprog.

Brug etikettabellen ved ældre japanske instruktioner. Versionen indeholder sprogvalg, lokaliseret Inspector, standardnavne og spilmenuer på alle 30 sprog.

| Dansk | Japansk etiket i ældre versioner |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funktioner | 機能 |
| Positurer | ポーズ一覧 |
| Avataropsætning | アバター調整 |
| Åbn indstillinger | 設定を開く |
| Opdatér forberegning | プレビルドを更新 |
| Kontrollér indstillinger | 設定の確認 |
| Forhåndsvisning | プレビュー |
| Animationsjustering | アニメーション調整 |
| Genindlæs | 再読込 |

Medfølgende Inspector, redigerings-/installationsdialoger, standardnavne og genererede menuer er oversat til alle 30 valgbare sprog. README, historik og offlinevejledning findes på hvert sprog. Avatarnavne, gemte objektnavne, egne navne, assetfilnavne og interne parameteridentifikatorer kan beholde original stavning.

[Hurtigreferencer på 30 sprog](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) forklarer funktioner og standardnavne i tabeller. Det er korte referencer; brug sprogindekset til fuld dokumentation.

## 3. Vælg positurer og funktioner

Inspector har tre hovedfaner:

| Fane | Anvendelse |
| --- | --- |
| **Funktioner** | Spilmenuer, tilvalg, vejrtrækning, ikoner og expression-parameterforbrug. |
| **Positurer** | Aktive positurer, kategorier/søgning, rækkefølge, animationstilføjelse, forhåndsvisning, detaljer og animationsjustering. |
| **Avataropsætning** | Avatarspecifik korrektion og knæ, import af oprindelige/egne bevægelser og forudindstillinger. |

Aktivér kun de menufunktioner, du vil bruge. **Spejlvend** i menuen gør det for eksempel muligt at skifte spejling i VRChat; det tvinger ikke alle positurer til at forblive spejlede.

Kawaii Posing har avatarforudindstillinger og IK til understøttede positurer. Tre standardrygpositurer har allerede sidebevægelser: **Ben strakt ud (足伸ばし)**, **Afslappet (リラックス)** og **Ét knæ op (膝立て)**. Brug passende forudindstilling og kontrollér Vend dig pr. positur efter ændring eller erstatning af disse poster.

### Forudindstillinger og pasform

Forudindstillinger findes nær bunden af **Avataropsætning**. Søg efter avatarnavn og anvend for at erstatte aktuelle indstillinger. Gem/sikkerhedskopiér justeringer før skift. En forudindstilling er udgangspunkt: proportioner, tøj og ændringer kan stadig kræve manuel korrektion.

Brug **Animationsjustering** til forhåndsvisning og redigering af krop/lemmer. Gem animationen i vinduet, når du er færdig. Automatisk hånd-/fodjustering (IK) kan aktiveres globalt og pr. positur, hvor støttet. Indarbejdning af IK-resultatet opretter justeringsanimation og slår positurens IK fra til manuel finjustering; originalklippet bevares.

**Forhindr bagudbøjning af knæ** har detaljer som mindste knævinkel. Avatarspecifik korrektion kræver tilsvarende data, og nogle korrektioner kan ikke kombineres med positur-IK.

### Oprindelige og egne bevægelser

**Brug oprindelige stående, hug- og mavepositurer** registrerer avatarens Base-bevægelser ved generering. **Brug egne bevægelser** åbner separate importindstillinger pr. type. Vælg én bevægelse pr. type. Manuelle valg har prioritet over automatisk import.

Automatisk import gælder buildkopien. Den skriver ikke registrerede animationer tilbage til scenens manuelle liste og ændrer ikke originale controllers. Ryd manuelt valg for typen, hvis automatisk registrering skal overtage igen. Egne Base-lag og andre bevægelsessystemer kan kræve individuel justering.

## 4. Brug værktøjet i VRChat

Åbn avatarens **Expressions**-menu og vælg **Kawaii Posing**. Vælg en positur pr. kategori, du vil bruge. Positurvalg og funktionsvalg er separate handlinger.

- **3-punkts-VR:** sænk/hæv hovedet for at skifte mellem stående, hug/stol, gulvsiddende og liggende. Justér højdegrænser i værktøjets indstillinger ved for tidlige/sene skift.
- **Skrivebord:** brug **C** til hug og **Z** til at ligge. Hæv liggehøjdetærsklen, hvis Z efterlader dig siddende.
- **Mave/ryg:** ansigtsretning bestemmer liggeformen. Med begge valgt kan hop på stedet skifte. Slå det fra i Unity under **Funktioner > Praktiske funktioner**, hvis ønsket; ingen ekstra synkroniserede parametre bruges.
- **Låsninger:** brug hoved-, arm- og fodlås efter behov. Slå gestus fra for positurens håndform i stedet for controllerinput.
- **Spejlvend:** vend en positur mod en ven eller tilpas billedkompositionen.

### Fodhøjde og gulvhøjde

**Fodhøjde** justerer fødder med hovedet på samme sted. Brug den, når fødder svæver eller synker, mens hovedet allerede er i korrekt højde.

**Gulvhøjde** flytter hele kroppen inklusive hovedet. Brug til sofa, seng eller forhøjede flader, også møbler uden collider. I fællessystemets nuværende centrerede kontrol er **50% oprindelig højde**, 0% er 3 m ned og 100% er 3 m op. Vend tilbage nær 50% for at afslutte forskydning. Ældre versioner kan have anden betjening; kontrollér installeret version og opdatér fællessystemet sammen med produktet.

### Fototilstand

Aktivér menupunktet **Fototilstand** i Unity før upload. Vælg en positur i VRChat, flyt op til 3 m frem med **Afstand** og drej med **Retning**. Fodlås er valgfri under opstilling. **Afslut foto** nulstiller afstand/rotation og frigiver fodlås.

Fototilstand er lokal som standard. Aktivér **Synkronisér Fototilstand** i Unity før upload for at vise position/rotation for andre; det bruger 16 synkroniserede bit. **Hold hovedet synligt i Fototilstand** påvirker egen visning uden synkroniserede bit.

### Vejrtrækning og Vend dig

Vejrtrækning konfigureres pr. kategori under **Funktioner > Praktiske funktioner > Animér vejrtrækning**. Vælg Ingen, Svag, Middel, Stærk, Hurtig eller egen animation. Bevægelsen bruger ingen synkroniserede bit; en menuknap bruger 1 bit.

Vend dig kræver understøttet liggende positur og menupunktet **Vend dig**. Aktivér vending på posituren og angiv sideanimation efter behov. Vælg posituren i VRChat, aktivér Vend dig og frigiv hoved-/nakkelås. Hovedets sidehældning styrer vendingen. Normal MotionTime er utilgængelig for posituren, mens Vend dig bruges.

De tre standardrygpositurer ovenfor har sidebevægelser. Andre kræver passende bevægelse og opsætning. Importerede/egne forudindstillinger kan have andre tildelinger.

## 5. Redigér, tilføj og forhåndsvis positurer

Vælg kategori eller søgefane under **Positurer**. Søgning accepterer originale japanske navne og tilgængelige oversættelser. Åbn **Detaljer** for animation, ikon, rækkefølge og tidsindstillinger.

Tilføj flere animationer ved at trække klip til tilføjelsesfeltet eller vælge dem i Project og bruge import af valgte klip. Dublerede referencer til samme klip fjernes. Ændr målplacering i Detaljer eller brug op/ned.

**Forhåndsvisning** viser en positur i Scene uden det fulde justeringsvindue. Den kører ikke Modular Avatar eller NDMF, så kontrollér tøj, gulvkorrektion og andre buildfunktioner i det endelige avatarbuild.

Ikoner genereret fra avataren gør positurer lette at kende, men tager tid og kan øge datastørrelsen. Sænk opløsningen for at spare plads. Android-builds genererer ikke positurikoner. Generér igen efter avatar-/tøjændringer efter behov.

## 6. Parameterhukommelse

Inspector viser positurværktøjernes bidrag, ikke hele avataren. Tøj og andre systemer kan bruge yderligere hukommelse. Delte indstillinger mellem værktøjer tælles ikke dobbelt. Mange ekstra positurer kan kræve flere valgbits.

| Funktion | Ekstra synkroniserede bit |
| --- | ---: |
| Positurvalg, mindste standardopsætning | 8 |
| Spejlvend | 1 |
| Gestus fra | 1 |
| Vejrtrækningsbevægelse | 0 |
| Vejrtrækningsknap | 1 |
| Fodhøjde | 8 |
| Gulvhøjde | 8 |
| Fototilstand, kun lokalt | 0 |
| Synkronisér Fototilstand | 16 |
| Hold hovedet synligt i Fototilstand | 0 |
| Slå VRChats svajen i stilstand fra | 0 |
| Vend dig | 10 |

Vend dig deler 1 bit med hovedretningskorrektionen; begge funktioner bruger stadig 10 bit tilsammen. Den installerede versions forbrugsvisning er den praktiske reference for opsætningen.

## 7. Opdatering og forberegning

1. Sikkerhedskopiér projektet og gem arbejdsscenen.
2. Opdatér **Kawaii Posing Tool** og fælles **Unisaki Posing System** sammen i VCC eller ALCOM. Hold også SDK, Modular Avatar og NDMF kompatible.
3. Vent på kompilering. Vælg eksisterende værktøj og kontrollér positurer, indstillinger og parameterforbrug.
4. Bruger du forberegninger, vælges **Opdatér forberegning**, og avataren uploades igen.

Eksisterende indstillinger bevares. Ældre 8-bit-prefab bevares til kompatibilitet; eksisterende referencer kræver ikke sletning/erstatning af værktøjet. Nye installationer bruger almindeligt prefab, og unødige funktioner kan slås fra for lavere forbrug.

Advarsel om gammel forberegning betyder ændrede indstillinger siden generering af cachedata. Opdatering genererer disse igen. At skjule advarslen opdaterer ikke forberegningen eller løser årsagen. Normale builds genererer nødvendige data, selv uden manuel forberegning hver gang.

## 8. Fejlfinding

| Symptom | Kontrollér |
| --- | --- |
| Ingen tilføjelsesmenu | Kontrollér produkt **og** Unisaki Posing System og løs Unity Console-kompileringsfejl. Licensinstallationen alene er ikke positurbiblioteket. |
| Installation annulleret eller filer fjernet | Importér den købte installation igen, når klar, og læs bekræftelser. |
| Licens mangler i andet projekt | Importér den købte installation med samme OS-konto. Ved ny computer/konto installeres licensen også der. Sprogvalg overføres ikke automatisk mellem computere. |
| Ingen positurer i VRChat | Tilføj under korrekt sceneavatar, aktivér positurer, læs Inspector-advarsler og upload avataren. Kontrollér SDK og andre bevægelsesværktøjer. |
| Z når ikke liggende | Hæv liggehøjdetærsklen i spilindstillingerne. |
| Hænder/knæ passer ikke | Prøv passende avatarforudindstilling og understøttet IK og/eller Animationsjustering. Kontrollér tøj i slutbuild. |
| Vend dig virker ikke | Brug understøttet liggende positur, aktivér både positurens vendevalg og menupunkt og frigiv hoved/nakke. Prøv først en af de tre understøttede standardpositurer. |
| Venner ser ikke fotobevægelse | Aktivér **Synkronisér Fototilstand** i Unity, kontrollér forbrug og upload igen. |
| Sprog skifter i Unity, ikke VRChat | Upload igen. Kontrollér fælles sprogvalg øverst i Inspector i lokaliserede versioner. |
| Build-/forberegningsfejl | Læs **første** relevante Console-fejl. Sikkerhedskopiér scenen, opdatér/genhent produkt og system via VCC/ALCOM, og kontakt support ved fortsat fejl. Bevar justerede objekter og GeneratedResources, medmindre support giver konkret gendannelsestrin. |

Oplys produkt-/systemversioner, Unity/SDK/Modular Avatar/NDMF-versioner, avatarnavn, præcise reproduktionstrin og Console-fejl til support. Fjern private filer, installationsindhold, licensværdier og kontooplysninger fra offentlige indlæg.

- [Support](https://help.unisakistudio.jp/)
- [Illustreret onlinevejledning (japansk)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Gumroad-produktside](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licenser og kreditering

En [engelsk referenceoversættelse af produktaftalen](../../Terms.en.html) følger med den japanske originalaftale.

Læs original produktaftale og fællessystemaftale ved pakkens README eller i `Licenses` i købt ZIP. Den engelske Unisaki Posing System-aftale er en eksisterende referenceoversættelse; produktets japanske aftale medfølger separat. Vejledningen ændrer ikke aftaler eller giver flere rettigheder. Kontakt support om brug eller videredistribution af data.

Installationen indeholder en ændret **VPMPackageAutoInstaller** af **anatawa12**, med **SimpleJson** og **semver.net**. Ophavsretsnotitser og MIT-licenstekster findes i `ThirdPartyNotices.txt` i købt ZIP. Positurbibliotek og andre produktressourcer har egne produktlicenser.
