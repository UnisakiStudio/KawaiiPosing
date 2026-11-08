# Kawaii Posing Tool — Norsk brukerveiledning

Kawaii Posing har 85 positurer for skrivebord og trepunkts-VR: 15 stående, 20 i huk/på stol, 17 sittende på gulvet, 17 i ryggleie og 16 i mageleie.

Veiledningen dekker installasjon, avataroppsett, VRChat-betjening, positurredigering, oppdatering og feilsøking. Kjøpt ZIP inneholder `START_HERE.html` for raskeste vei til installasjon.

## Før du begynner

- Bruk et Unity 2022.3-prosjekt for VRChat-**avatarer**, opprettet eller administrert med VRChat Creator Companion (VCC) eller ALCOM.
- Krever VRChat Avatars SDK 3.10.4 eller nyere; Modular Avatar 1.x fra 1.15.1; NDMF 1.x fra 1.14.0.
- Verktøyet er for Humanoid-avatarer på skrivebord og i trepunkts-VR (hodesett og to kontrollere). Positurlås med aktiv helkroppssporing støttes ikke.
- Sikkerhetskopier eksisterende prosjekt før installasjon eller oppdatering. Løs alle kompileringsfeil i Unity først.
- Installasjonen laster ned produkt og avhengigheter fra pakkerepositorier. Internett kreves. Avatarmodeller, VRChat SDK, Modular Avatar og NDMF er ikke inkludert i ZIP-filen.

## 1. Installer lisens og produkt

1. Pakk ut hele ZIP-filen i en vanlig mappe utenfor Unity-prosjektet.
2. Åpne ønsket avatarprosjekt i Unity. Importer `Installer/KawaiiPosing_Installer.unitypackage` med **Assets > Import Package > Custom Package**, eller åpne filen med Unity.
3. Les import- og installasjonsmeldinger. Lisensbekreftelsen forklarer hvilke produktlisenser som installeres. Bruk **Språk…** (eller **言語...**) i en bekreftelse for å endre installasjonsspråk.
4. Bekreft lisensinstallasjon. Lisensen dekker også felles Unisaki Posing System som produktet bruker. Installasjonen kan tilby å slette egne oppsettfiler etterpå; dette fjerner ikke produktlisensen.
5. Gjennomgå bekreftelsen for automatisk pakkeinstallasjon. Den viser pakker/repositorier som legges til og eldre filer/mapper som foreslås fjernet. Fortsett hvis dette er de ønskede elementene.
6. La Unity fullføre import og kompilering. Hvis installasjonen ikke fullføres automatisk, åpner du prosjektet i VCC eller ALCOM og legger til **Kawaii Posing Tool** og **Modular Avatar**. Felles **Unisaki Posing System** og **NDMF** er avhengigheter. `Optional-VCC-Links` inneholder produktets opprinnelige repositoriesnarveier for Windows-VCC-brukere.
7. Ved avbrutt bekreftelse importerer du på nytt når du er klar. Lisenskommandoen i **Tools > Unisaki Studio** kan også brukes mens aktivatoren finnes. I eldre versjoner heter undermenyen **ゆにさきスタジオ**.

### Hva denne nedlastingen installerer

**Kawaii Posing Tool 3.2.0 med Unisaki Posing System 3.2.0.** Versjonen er under utvikling og ikke utgitt. Den legger til installasjonsdialoger, Unity Inspector og menyer, standardnavn, spillmenyer og offlinedokumentasjon på tretti språk. Utgivelsesdato er ikke fastsatt. Bruk språkvelgeren øverst i Inspector. Etter publisering laster installasjonen ned disse versjonene og kompatible avhengigheter fra VPM-repositorier. Lokal klargjøring publiserer ikke pakkene.

Kawaii Posing Tool inkluderer positurbibliotek, oppsettverktøy og avatarjusteringsforhåndsinnstillinger. Installasjonen aktiverer eksisterende lokal produktlisens, uten nytt Gumroad-lisensnøkkelfelt. Del aldri installasjonsfiler eller lisensdata i offentlig støtteforespørsel.

Språkvalg lagres i Unity EditorPrefs for gjeldende OS-bruker og deles mellom prosjekter på maskinen. Uten lagret valg følger installasjonen OS-språket, med engelsk for språk uten støtte. Lisenser beholder lagringen: brukerens registernøkkel `Software/UnisakiStudio` i Windows og lisensfiler per bruker på macOS/Linux. Språkbytte fjerner ikke lisensen.

## 2. Legg til verktøyet i en avatar

1. Velg avataren med **VRC Avatar Descriptor**, eller et underobjekt, i **Hierarchy**. Bruk en sceneavatar, ikke prefab-asset i Project eller Prefab Mode.
2. Høyreklikk og velg **Unisaki Studio > Legg til Kawaii Posing**. Med japanske menyer velger du **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Verktøyet legges inn i avataren. Lagret objektnavn kan fortsatt være **可愛いポーズ** selv med oversatte visningstekster.
4. Bruk passende avatarforhåndsinnstilling hvis tilbudt. Ellers åpner du **Avataroppsett** og velger en forhåndsinnstilling eller justerer selv.
5. Installasjonen kan tilby forhåndsbygging. Det er valgfritt; vanlig avatarbygg genererer også data. Gjenbruk for kortere senere byggetid.
6. Velg verktøyobjektet, angi positurer/funksjoner og last opp normalt med VRChat SDK.

### Språkvalg og kjente etiketter

Versjonen har **Language / 言語** øverst i Inspector. Ett valg styrer Inspector og generert spillmeny. Avataren lagrer språket, og siste valg huskes til andre verktøy/prosjekter på maskinen. Last opp igjen for nytt språk i VRChat.

Bruk etiketttabellen når du følger eldre japanske veiledninger. Versjonen har språkvalg, lokalisert Inspector, standardnavn og spillmenyer for alle 30 språk.

| Norsk | Japansk etikett i eldre versjoner |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funksjoner | 機能 |
| Positurer | ポーズ一覧 |
| Avataroppsett | アバター調整 |
| Åpne innstillinger | 設定を開く |
| Oppdater forhåndsbygget | プレビルドを更新 |
| Kontroller innstillinger | 設定の確認 |
| Forhåndsvisning | プレビュー |
| Animasjonsjustering | アニメーション調整 |
| Last inn på nytt | 再読込 |

Inspector, redigerings-/installasjonsdialoger, standardnavn og genererte menyer er oversatt for alle 30 språk. README, endringslogg og offlineveiledning finnes på hvert språk. Avatarnavn, lagrede objektnavn, egne navn, assetfilnavn og interne parameteridentifikatorer kan beholde original stavemåte.

[Hurtigreferanser på 30 språk](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) forklarer funksjoner og standardnavn i tabeller. Dette er korte referanser; bruk språkindeksen til full dokumentasjon.

## 3. Velg positurer og funksjoner

Inspector har tre hovedfaner:

| Fane | Bruk |
| --- | --- |
| **Funksjoner** | Spillmenyer, tilvalg, pust, ikoner og expression-parameterforbruk. |
| **Positurer** | Aktive positurer, kategorier/søk, sortering, animasjonstillegg, forhåndsvisning, detaljer og animasjonsjustering. |
| **Avataroppsett** | Avatar-/knekorrigering, import av originale/egne bevegelser og forhåndsinnstillinger. |

Aktiver bare menyvalg du vil bruke. **Speilvend** i menyen lar deg for eksempel bytte speiling i VRChat; det tvinger ikke alle positurer til å være speilvendt.

Kawaii Posing har avatarforhåndsinnstillinger og IK for støttede positurer. Tre standardryggpositurer har sidebevegelser: **Bena ut (足伸ばし)**, **Avslappet (リラックス)** og **Ett kne opp (膝立て)**. Bruk passende forhåndsinnstilling og kontroller hver positurs Snu deg-valg hvis du har endret eller erstattet dem.

### Forhåndsinnstillinger og tilpasning

Forhåndsinnstillinger finnes nær bunnen av **Avataroppsett**. Søk på avatarnavn og bruk for å erstatte oppsettet. Lagre/sikkerhetskopier før bytte. En forhåndsinnstilling er et utgangspunkt: kroppsproporsjoner, klær og endringer kan fortsatt kreve manuell korrigering.

Bruk **Animasjonsjustering** til å forhåndsvise og endre kropp/lemmer. Lagre justeringsanimasjonen i vinduet når ferdig. Automatisk hånd-/fotjustering (IK) kan aktiveres globalt og per positur der støttet. Lagring av IK-resultatet oppretter justeringsanimasjon og slår av IK for manuell viderejustering; originalklippet beholdes.

**Hindre bakoverbøyning av knær** har detaljer som minste knevinkel. Avatarkorrigering krever tilsvarende data, og noen korrigeringer kan ikke kombineres med positur-IK.

### Originale og egne bevegelser

**Bruk opprinnelige stå-, huk- og mageleiepositurer** finner Base-bevegelser under generering. **Bruk egne bevegelser** åpner egne importvalg per type. Velg én bevegelse per type. Manuelle valg prioriteres over automatisk import.

Automatisk import gjelder byggkopien. Den skriver ikke registrerte animasjoner til scenens manuelle liste eller endrer originalcontrollers. Fjern manuelt valg for typen hvis automatisk registrering skal overta igjen. Egne Base-lag og andre forflytningssystemer kan kreve individuell justering.

## 4. Bruk verktøyet i VRChat

Åpne avatarens **Expressions**-meny og velg **Kawaii Posing**. Velg en positur for hver ønsket kategori. Positurvalg og funksjonsvalg er separate handlinger.

- **Trepunkts-VR:** senk eller hev hodet for å bytte mellom stående, huk/stol, gulvsittende og liggende. Juster høydeterskler i innstillinger ved for tidlige/sene bytter.
- **Skrivebord:** bruk **C** til huk og **Z** til å ligge. Øk liggehøydeterskelen hvis Z lar deg sitte.
- **Mage/rygg:** ansiktsretningen bestemmer leie. Med begge valgt kan hopp på stedet bytte. Deaktiver under Unitys **Funksjoner > Praktiske funksjoner** ved behov; ingen ekstra synkroniserte parametre brukes.
- **Låser:** bruk hode-, arm- og fotlås ved behov. Slå av gester for positurens håndform i stedet for kontrollerinput.
- **Speilvend:** vend mot en venn eller tilpass komposisjonen.

### Fothøyde og gulvhøyde

**Fothøyde** justerer føttene med hodet på samme sted. Bruk når føttene svever eller synker mens hodet allerede har riktig høyde.

**Gulvhøyde** flytter hele kroppen inkludert hodet. Bruk på sofa, seng eller forhøyede flater, også møbler uten collider. I fellessystemets sentrerte kontroll er **50% originalhøyden**, 0% er 3 m ned og 100% er 3 m opp. Gå tilbake nær 50% for å avslutte forskyvningen. Eldre versjoner kan ha annen betjening; kontroller versjonen og oppdater fellessystem sammen med produkt.

### Fotomodus

Aktiver **Fotomodus** i Unity før opplasting. Velg en positur i VRChat, flytt opptil 3 m frem med **Avstand** og roter med **Retning**. Fotlås er valgfri under plassering. **Avslutt foto** nullstiller avstand/rotasjon og frigir fotlåsen.

Fotomodus er lokal som standard. Aktiver **Synkroniser Fotomodus** i Unity før opplasting for å vise posisjon/rotasjon til andre; dette bruker 16 synkroniserte bit. **Behold hodet synlig i Fotomodus** påvirker egen visning uten synkroniserte bit.

### Pust og Snu deg

Pust settes per kategori under **Funksjoner > Praktiske funksjoner > Animer pusten**. Velg Ingen, Svak, Middels, Sterk, Rask eller egen animasjon. Bevegelsen bruker ingen synkroniserte bit; en menybryter bruker 1 bit.

Snu deg krever støttet liggende positur og menyvalget **Snu deg**. Aktiver snuing på posituren og angi sideanimasjon ved behov. Velg posituren i VRChat, aktiver Snu deg og frigi hode-/nakkelås. Hodets sidehelling styrer snuingen. Vanlig MotionTime er utilgjengelig mens Snu deg brukes på posituren.

De tre standardryggpositurene ovenfor har sidebevegelser. Andre krever egnet bevegelse og oppsett. Importerte/egne forhåndsinnstillinger kan ha andre tildelinger.

## 5. Rediger, legg til og forhåndsvis positurer

Velg kategori eller søkefane under **Positurer**. Søk støtter originalnavn på japansk og tilgjengelige oversettelser. Åpne **Detaljer** for animasjon, ikon, rekkefølge og tidsvalg.

Legg til flere animasjoner ved å dra klipp til feltet, eller velg dem i Project og bruk importkommandoen. Dupliserte referanser til samme klipp fjernes. Endre målrekkefølge i Detaljer eller bruk opp/ned.

**Forhåndsvisning** viser en positur i Scene uten hele justeringsvinduet. Den kjører ikke Modular Avatar eller NDMF, så kontroller klær, gulvkorrigering og andre byggfunksjoner i sluttbygget.

Positurikoner fra avataren gjør gjenkjenning lettere, men tar tid og kan øke datastørrelsen. Senk oppløsningen for å spare plass. Android-bygg genererer ikke positurikoner. Generer på nytt etter avatar-/klesendringer ved behov.

## 6. Parameterminne

Inspector viser positurverktøyenes bidrag, ikke hele avataren. Klær og andre systemer kan bruke mer minne. Felles innstillinger mellom flere verktøy telles ikke dobbelt. Mange ekstra positurer kan kreve flere valgbiter.

| Funksjon | Ekstra synkroniserte bit |
| --- | ---: |
| Positurvalg, minste standardoppsett | 8 |
| Speilvend | 1 |
| Gester av | 1 |
| Pustebevegelse | 0 |
| Pustebryter i menyen | 1 |
| Fothøyde | 8 |
| Gulvhøyde | 8 |
| Fotomodus, bare lokalt | 0 |
| Synkroniser Fotomodus | 16 |
| Behold hodet synlig i Fotomodus | 0 |
| Deaktiver VRChats hvilebevegelse | 0 |
| Snu deg | 10 |

Snu deg deler 1 bit med hoderetningskorrigeringen; begge bruker fortsatt 10 bit totalt. Forbruksvisningen i installert versjon er den praktiske referansen for ditt oppsett.

## 7. Oppdatering og forhåndsbygg

1. Sikkerhetskopier prosjektet og lagre arbeidsscenen.
2. Oppdater **Kawaii Posing Tool** og felles **Unisaki Posing System** sammen i VCC eller ALCOM. Hold også SDK, Modular Avatar og NDMF kompatible.
3. Vent på kompilering. Velg eksisterende verktøy og kontroller positurer, innstillinger og forbruk.
4. Bruker du forhåndsbygg, velger du **Oppdater forhåndsbygget** og laster opp avataren igjen.

Eksisterende innstillinger beholdes. Eldre 8-bit-prefab finnes for kompatibilitet; referanser krever ikke sletting/erstatning av verktøyet. Nye installasjoner bruker vanlig prefab, og unødvendige funksjoner kan slås av for lavere forbruk.

En advarsel om gammelt forhåndsbygg betyr endrede innstillinger siden cachedata ble generert. Oppdatering genererer dataene på nytt. Skjult advarsel oppdaterer ikke forhåndsbygg eller løser årsaken. Vanlige bygg genererer nødvendige data selv uten manuell forhåndsbygging hver gang.

## 8. Feilsøking

| Symptom | Kontroller |
| --- | --- |
| Ingen tilleggsmeny | Kontroller produktet **og** Unisaki Posing System og løs Unity Console-kompileringsfeil. Bare lisensinstallasjon er ikke positurbiblioteket. |
| Installasjon avbrutt eller filer fjernet | Importer kjøpt installasjon igjen når du er klar. Les bekreftelsene igjen. |
| Lisens mangler i annet prosjekt | Importer kjøpt installasjon med samme OS-konto. Ved ny maskin/konto installerer du lisensen der også. Språkvalg overføres ikke automatisk mellom maskiner. |
| Ingen positurer i VRChat | Legg til under riktig sceneavatar, aktiver positurer, les Inspector-advarsler og last opp denne avataren. Kontroller SDK og andre forflytningsverktøy. |
| Z når ikke liggende | Øk liggehøydeterskelen i spillinnstillingene. |
| Hender/knær passer ikke | Prøv passende avatarforhåndsinnstilling og støttet IK og/eller Animasjonsjustering. Kontroller klesdeformasjon i sluttbygget. |
| Snu deg virker ikke | Bruk støttet liggende positur, aktiver positurens innstillinger for snuing og menyvalget og frigi hode/nakke. Prøv først en av de tre støttede standardpositurene. |
| Venner ser ikke fotobevegelse | Aktiver **Synkroniser Fotomodus** i Unity, kontroller forbruk og last opp igjen. |
| Språk endres i Unity, ikke VRChat | Last opp igjen. Kontroller felles språkvelger øverst i Inspector i lokaliserte versjoner. |
| Bygg-/forhåndsbyggfeil | Les **første** relevante Console-feil. Sikkerhetskopier scenen, oppdater/hent produkt og system via VCC/ALCOM og kontakt støtte ved vedvarende feil. Behold justerte objekter og GeneratedResources med mindre støtte gir et konkret gjenopprettingstrinn. |

Oppgi produkt-/systemversjoner, Unity/SDK/Modular Avatar/NDMF-versjoner, avatarnavn, nøyaktige trinn og relevant Console-feil til støtte. Fjern private filer, installasjonsinnhold, lisensverdier og kontodetaljer fra offentlige innlegg.

- [Støtte](https://help.unisakistudio.jp/)
- [Illustrert nettveiledning (japansk)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Gumroad-produktside](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Lisenser og kreditering

En [engelsk referanseoversettelse av produktavtalen](../../Terms.en.html) følger med den japanske originalavtalen.

Les original produktavtale og fellessystemavtale ved pakkens README eller i `Licenses` i kjøpt ZIP. Den engelske Unisaki Posing System-avtalen er en eksisterende referanseoversettelse; produktets japanske avtale medfølger separat. Veiledningen endrer ikke avtaler eller gir ekstra rettigheter. Kontakt støtte om bruk eller videredistribusjon av data.

Installasjonen inkluderer endret **VPMPackageAutoInstaller** av **anatawa12**, med **SimpleJson** og **semver.net**. Opphavsrettsmerknader og MIT-lisenstekster finnes i `ThirdPartyNotices.txt` i kjøpt ZIP. Positurbibliotek og andre produktressurser har egne produktlisenser.
