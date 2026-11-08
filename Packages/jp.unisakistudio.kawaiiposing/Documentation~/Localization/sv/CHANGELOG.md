# Ändringshistorik

## [3.2.0] - Ej utgiven

### Tillagt

- Inspector, redigeringsåtgärder, installationsdialoger, standardposnamn och genererade VRChat-menyer kan visas på 30 språk.
- Språkvalet för Inspector och spelmenyn är gemensamt. Datorns språk används först, och det senaste valet återanvänds i andra projekt för samma OS-användare.
- README, ändringshistorik och offlineanvisningar kan öppnas på valt språk.
- Visningsnamn för 128 standardposer och funktionsbeskrivningar har tagits fram med befintlig terminologi.

### Kompatibilitet

- Befintliga avatarinställningar, egna namn, assetreferenser, parameteridentifierare och licensens lagringssätt bevaras.

## [3.1.2] - 2026-11-09

- Huvudlås kan växlas i EX-menyns ”Inställningar → Automatiskt huvudlås i ryggläge” även med Fothöjd avstängt. Poster som försvann i äldre versioner återkommer efter uppdatering och bygge.
- Stöd för Unisaki Posing System 3.1.2. Åtgärdat att ansiktet fortsatte peka uppåt efter uppresning från magläge med ”Minska förvrängning från huvudrotation”.

Uppdatera Kawaii Posing till 3.1.2 i ALCOM / VCC. Unisaki Posing System 3.1.2 krävs också. Om du använde förberäkning: tryck på ”Uppdatera förberäkning”, spara scenen och bygg och ladda upp avataren igen.

## [3.1.1] - 2026-11-08

- Aktiverade Golvhöjd och Vänd dig visas under Inställningar i VRChats EX-meny även med Spegla avstängt.
- Korrekta vändningar för Ben utsträckta, Avslappnad och Ett knä upp bevaras efter omordning, borttagning eller namnbyte i äldre versioner, även efter fullständig Unpack om ursprunget kan identifieras. Egna poser, uttryckligen avstängd vändning och ersatta sidrörelser bevaras.
- Åtgärdat ett kort magläge vid avatarval i VRChat och ett kort ryggläge vid hopp med enbart magposer valda. Hoppväxling stängs av via ”Funktioner → Praktiska funktioner → Växla liggande poser genom att hoppa”; den är på som standard.
- Återställningsbara förlorade referenser till gemensam pose-Animator Controller ger en varning och återskapas från inställningarna. Delade referenser mellan avatarer bevaras.
- Verktygets tilläggsmeny placerar officiellt Prefab även om ett eget Prefab med samma namn ”可愛いポーズ” finns.
- Vid tillägg av 添い寝ツール visas vilken produkt som måste installeras först om den nödvändiga integrationsprodukten saknas.

Uppdatera både Kawaii Posing och Unisaki Posing System till 3.1.1 i ALCOM / VCC. Om du använde förberäkning: tryck på ”Uppdatera förberäkning” på scenobjektet ”可愛いポーズ” och spara scenen. Bygg och ladda upp avataren igen för att tillämpa ändringarna i VRChat.

## [3.1.0] - 2026-11-07

- 53 av 85 medföljande poser får automatisk lemanpassning med IK efter kroppsbyggnad.
- Ryggposerna Ben utsträckta, Avslappnad och Ett knä upp stöder Vänd dig genom huvudlutning.
- Position och riktning kan justeras i Fotoläge, med valfri synkronisering och visning av det egna huvudet.
- Golvhöjd flyttar hela kroppen 3m uppåt/nedåt, separat från Fothöjd.
- Tillagt andningsrörelser, avstängning av standardsvajning och minskad förvrängning från huvudrotation.
- Inspector visar aktiva funktioner och parameteranvändning. Sökning, massimport, omordning och enkel förhandsvisning i Scene stöds.
- Snabbare växling mellan stående, hukande och sittande i skrivbordsläge.
- Förbättrade förberäkningsvarningar efter ändringar, scrollbelastning i Inspector och långa stopp vid städning av genererade data.
- Stöd för Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Öppen beta (2026-11-05)

- Öppen beta via GitHub Releases och VPM. 53 av 85 poser får automatisk lemanpassning med IK efter kroppsbyggnad.
- Stöd för gemensamma paketet 3.1.0-beta.2. Förbättrad visning av ändringar efter förberäkning, scrollbelastning i Inspector och stopp vid städning av genererade data.

## [3.1.0-beta.1] - Öppen beta (2026-11-04)

- Stöd för Unisaki Posing System 3.1.0-beta.1.
- Normal poseväxling i skrivbordsläge använder en utvärdering i vanliga byggen och förberäkning. VR och särskilda villkor använder tidigare väg.
- Förberäkningar från alpha.3 eller äldre identifieras som uppdateringskrävande.
- Synvinkeln bevaras vid ändrad golvhöjd i Fotoläge och återgår till senaste golvhöjd när Fotoläge avslutas.
- Inkluderar förbättringar genom alpha.3 för automatisk import, justering av importerade rörelser och hantering av genererade Controllers.

## [3.1.0-alpha.2] - Slutet test (2026-10-26)

### Rättningar och ändringar

- Gemensamma posesystemet uppdaterat till 3.1.0-alpha.2 med felsökningsrättningar.
- Golvhöjd utökad till 3m uppåt/nedåt; 50% är ursprungshöjd och standardvärde.
- Fotoläge och golvhöjd korrigerar även vanliga och egna poser när ingen verktygspose är vald.
- Åtgärdat problem med manuell korrigering, likadana posnamn, startposer och äldre förinställningars vändningsinställningar.

## [3.1.0-alpha.1] - Före offentlig utgivning

### Tillagt

- Tillagt automatisk lemanpassning (IK) efter kroppsbyggnad.
- Tillagt IK på/av övergripande och per pose samt inbakning i justeringsanimation.
- Ryggposerna Ben utsträckta, Avslappnad och Ett knä upp stöder Vänd dig genom huvudlutning.
- Tillagt vändningsinställningar och val av sidanimation per pose.
- Tillagt Fotoläge för förflyttning framåt och rotation.
- Tillagt synkronisering av Fotoläge: endast lokalt 0 bit, synkroniserat 16 bit.
- Tillagt möjlighet att behålla det egna avatarhuvudet synligt i Fotoläge.
- Tillagt Golvhöjd som höjer hela kroppen inklusive huvudet.
- Tillagt andningsrörelse, styrka och på/av-meny i spelet.
- Tillagt avstängning av VRChats standardsvajning.
- Tillagt minskad förvrängning från huvudrotation.
- Tillagt skydd mot bakåtböjda knän och minsta böjvinkel.
- Tillagt på/av per funktion och ExpressionParameters-användning.
- Tillagt enkel förhandsvisning i Scene, possökning, massimport och målposition vid omordning.
- Tillagt ändringshistorik i Inspector.

### Ändrat

- Inspector indelad i Funktioner, Poser och Avatarinställningar.
- Omorganiserade andningsdetaljer, import av egna rörelser och förinställningar.
- Färre dubblerade animationer för fothöjd.
- Bekräftelsedialog för uppdatering av posebilder och samlade varningsinställningar under Kontrollera inställningar.
- Tilläggsmenyn för nya 8bit-versioner borttagen till förmån för funktionsval i vanliga Prefab; befintliga referenser bevaras.
- Stöd för Unisaki Posing System 3.1.0-alpha.1. Lägsta VRChat Avatars SDK-version ändrad till 3.10.4.

### Rättat

- Åtgärdat att posnamnsinmatning flyttades till en annan pose och att detaljer stängdes vid omordning.
- Åtgärdat överlappande förhandsvisningar, fel position och fel på vissa avatarer.
- Åtgärdat uppdatering av varningar/förberäkningsstatus efter inställningsändringar och vissa byggfel.

## [3.0.13] - 2026-09-22
- Uppdaterat till PosingSystem 3.0.17 och åtgärdat horisontell poseförskjutning vid jämn skalning av hela avataren.
- Tillagt individuellt eller gemensamt ignorerande av varningar för automatisk fotrörelse, utebliven förberäkning och ändrade inställningar.
- Åtgärdat import av olämpliga engångsanimationer vid manuell import av förflyttningsrörelser.

## [3.0.12] - 2026-09-15
- Tillagt avatarförinställning (ルリエ).

## [3.0.11] - 2026-09-09
- Tillagt avatarförinställningar (メルヴィ, ミダリス).
- Rättat rörelseersättning i förinställningen för うらら.

## [3.0.10] - 2026-08-31
- Uppdaterat till PosingSystem 3.0.11 och åtgärdat förberäkningsfel med senaste NDMF samt undantag vid felvisning.

## [3.0.9] - 2026-08-29
- Uppdaterat till PosingSystem 3.0.10 för mindre belastning vid förinställningsinläsning och Hierarchy-ikonbedömning.
- Åtgärdat förberäkningsfel med flera posesystem på samma avatar.

## [3.0.8] - 2026-08-26
- Uppdaterat till PosingSystem 3.0.9 och åtgärdat `Avatar is null` i Play när förhandsvisnings-Avatar blev ogiltig efter NDMF-bearbetning.

## [3.0.7] - 2026-08-18
- Uppdaterat till PosingSystem 3.0.8 och åtgärdat risk för ogiltiga posedata vid upprepad höjdkorrigering.

## [3.0.6] - 2026-08-12
- Tillagt avatarförinställningar (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Tillagt avatarförinställningar (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Tillagt avatarförinställningar (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Förbättrade funktioner för licensinstallation och borttagning.

## [3.0.2] - 2026-01-04
- Åtgärdat licenshantering för Mac och Linux.

## [3.0.1] - 2025-12-28
- Tillagt avatarförinställningar (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Tillagt förberäkning.
- Tillagt animationsjustering.
- Tillagt förinställningar.
- Projekt kan lägga till verktyget med unitypackage.
- Tillagt avatarförinställningar (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Löst kompatibilitetsproblem med vissa verktyg.

## [2.2.4] - 2025-04-04
- Åtgärdat utebliven poseväxling med vissa avatarer och ModularAvatar-versioner.

## [2.2.3] - 2025-03-13
- Åtgärdat felaktiga rörelser på vissa avatarer, exempelvis hopp med 森羅.
- Åtgärdat ibland felaktigt standardvärde för Gester av.

## [2.2.2] - 2025-03-06
- Åtgärdat fel i vissa miljöer.

## [2.2.1] - 2025-02-05
- Åtgärdat Unity-krascher.
- Version tillagd i verktygsnamnet i NDMF Console.

## [2.2.0] - 2025-02-02
- Tillagt Gester av för användning av animationens handform.
- Handformsdata tillagda i alla poser.

## [2.1.6] - 2025-02-02
- Åtgärdat förvrängda poser tillsammans med vissa verktyg.
- Åtgärdat inställningsberoende fel.

## [2.1.5] - 2024-12-10
- Löst konflikter med vissa verktyg.
- Tillagt knapp för att ta bort Unitypackage-versionen.
- Integrations-Prefabs för 三点だいしゅきツール borttagna eftersom en VCC-version nu finns.

## [2.1.4] - 2024-12-08
- Åtgärdat fel på vissa avatarer.
- Åtgärdat oanvändbart fotlås vid konflikter med verktyg eller avatarer.
- Åtgärdat att avatarens pose återgick till VRC-standard i skrivbordsläge.

## [2.1.3] - 2024-12-01
- Åtgärdat utebliven poseväxling tillsammans med avatarer eller verktyg som använder fel typ för VRMode.
- Tillagt visning i NDMF-Console när olika parametertyper orsakar verktygskonflikter.

## [2.1.2] - 2024-12-01
- Tillagt förklaring i NDMF-Console när andra verktygs fel gör att Unisaki Posing System misslyckas vid avatarbygge.
- Åtgärdat byggfel på vissa avatarer.
- Förbättrat beteende direkt efter avatarinläsning.
- Avatarens ursprungliga förflyttningshantering tas bort eftersom den kan stoppa funktionen på vissa avatarer.

## [2.1.1] - 2024-11-20
- Åtgärdat omöjliga byggen.

## [2.1.0] - 2024-11-20
- Löst fötter och höfter under marken i skrivbordsläge så att alla poser kan tas korrekt.
- Tillagt poseväxling oberoende av huvudhöjd.
- Tillagt läge utan ikongenerering för Quest-avataruppladdning.
- Tillagt flera varningar vid avatarproblem.
- Löst konflikter mellan lås och AFK eller andra verktygs armlås.
- Tillagt automatiskt nacklås i ryggläge.
- Ändrat ExpressionsMenu: poseval i separat mapp och låsfunktioner överst.

## [2.0.0] - 2024-11-14
### Rättat
- Paketerat som VPM-paket för VCC-stöd.
- Åtgärdat att 8bit-versionen använde 17bit.

## [1.15.0] - 2024-11-04
### Rättat
- Rättade fel och funktionsproblem.

## [1.14.0] - 2024-07-05
### Rättat
- Åtgärdat fel med VRCFury.

## [1.13.0] - 2024-04-11
### Rättat
- Tillagt integration med ”ごろ寝システムEX”.

## [1.12.0] - 2024-03-31
### Rättat
- Åtgärdat att vissa ExMenu-tillstånd gjorde verktyget oanvändbart.
- Spegling tillagd i inställningarna.
- Rättat kattposen.
- Tillagt 5 sidliggande poser.

## [1.11.0] - 2024-03-12
### Rättat
- Åtgärdat förvrängda poser med hög huvudposition.

## [1.10.0] - 2024-03-10
### Rättat
- Tillagt stående funktion med 15 poser.
- Åtgärdat automatiskt rörliga fötter på vissa avatarer och i vissa miljöer.
- Tillagt ExpressionParameters8bit-version.

## [1.9.0] - 2024-03-05
### Rättat
- Åtgärdat automatiskt rörliga fötter på vissa avatarer.
- Enhetliga WriteDefaults.
- Tillagt 7 hukande och 8 sittande poser.

## [1.8.0] - 2024-02-25
### Rättat
- Åtgärdat uppladdningsfel med ModularAvatar1.9.0 eller senare.
- ModualrAvatar1.9.0 eller senare krävs nu.

## [1.7.0] - 2024-02-23
### Rättat
- Tillagt ändring av huvudhöjdströskel för varje pose.
- Åtgärdat felaktiga poser eller fötter vid exempelvis hopp på vissa avatarer.
- Minskad ExpressionParameter-användning från 54 till 16bit.

## [1.6.0] - 2024-02-20
### Rättat
- Åtgärdat att sittande poser inte kunde användas i VR-läge.

## [1.5.0] - 2024-02-18
### Rättat
- Sittande poser kan tas även med C nedtryckt i skrivbordsläge.

## [1.4.0] - 2024-02-17
### Rättat
- Åtgärdat att 添い寝-integrationen krävde 三点だいしゅき-integrationen.
- Åtgärdat fastlåsta fötter vid hopp.

## [1.3.0] - 2024-02-16
### Rättat
- Åtgärdat onormalt många VRCContactSender/Receiver.

## [1.2.0] - 2024-02-16
### Rättat
- Åtgärdat byggfel vid uppladdning.

## [1.1.0] - 2024-02-15
### Rättat
- Åtgärdat felaktiga standardvärden med flera Prefabs.
- Rättat inställningar för 可愛い座り-integrationen.

## [1.0.0] - 2024-02-14
### Utgivning
