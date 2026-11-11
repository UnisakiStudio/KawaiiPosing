# Kawaii Posing Tool — Svensk användarhandbok

Kawaii Posing har 85 poser för skrivbordsläge och 3-punkts-VR: 15 stående, 20 hukande/på stol, 17 sittande på golvet, 17 liggande på rygg och 16 liggande på mage.

Handboken omfattar installation, avatarinställningar, VRChat-kontroller, posredigering, uppdatering och felsökning. Den köpta ZIP-filen innehåller `START_HERE.html` för snabbaste vägen till installation.

## Innan du börjar

- Använd ett Unity 2022.3-projekt för VRChat-**avatarer**, skapat eller hanterat med VRChat Creator Companion (VCC) eller ALCOM.
- Nödvändiga paket: VRChat Avatars SDK 3.10.4 eller senare; Modular Avatar 1.x från 1.15.1; NDMF 1.x från 1.14.0.
- Verktyget är avsett för Humanoid-avatarer i skrivbordsläge och 3-punkts-VR (headset och två kontroller). Poslåsning med aktiv helkroppsspårning stöds inte.
- Säkerhetskopiera befintliga projekt före installation eller uppdatering. Lös först alla Unity-kompileringsfel.
- Installationsprogrammet hämtar produkten och beroenden från paketförråden. Internetanslutning krävs. Avatarmodeller, VRChat SDK, Modular Avatar och NDMF ingår inte i ZIP-filen.

## 1. Installera licensen och produkten

1. Packa upp hela ZIP-filen till en vanlig mapp utanför Unity-projektet.
2. Öppna avsett avatarprojekt i Unity. Importera `Installer/KawaiiPosing_Installer.unitypackage` via **Assets > Import Package > Custom Package**, eller öppna filen med Unity.
3. Läs import- och installationsmeddelandena. Licensbekräftelsen beskriver vilka produktlicenser som installeras. Använd **Språk…** (eller **言語...**) i en bekräftelsedialog för att byta installationsspråk.
4. Bekräfta licensinstallationen. Licensen omfattar också gemensamma Unisaki Posing System som produkten använder. Installationsprogrammet kan erbjuda att ta bort sina egna installationsfiler efteråt; detta tar inte bort produktlicensen.
5. Granska bekräftelsen för automatisk paketinstallation. Där listas paket och förråd som läggs till samt eventuella äldre filer eller mappar som föreslås tas bort. Fortsätt om det är avsedda objekt.
6. Låt Unity slutföra import och kompilering. Om installationen inte avslutas automatiskt öppnar du projektet i VCC eller ALCOM och lägger till **Kawaii Posing Tool** och **Modular Avatar**. Gemensamma **Unisaki Posing System** och **NDMF** är beroenden. `Optional-VCC-Links` innehåller produktens ursprungliga förrådsgenvägar för VCC-användare på Windows.
7. Om en bekräftelse avbröts importerar du installationsprogrammet igen när du är redo. Dess licensinstallationskommando kan också användas under **Tools > Unisaki Studio** medan aktiveringsprogrammet finns kvar. I äldre versioner heter undermenyn **ゆにさきスタジオ**.

### Vad hämtningen installerar

**Kawaii Posing Tool 3.2.0 med Unisaki Posing System 3.2.0.** Versionen är under utveckling och ännu inte utgiven. Den tillför installationsdialoger, Unity Inspector och menyer, standardposnamn, spelmenyer och offlinedokumentation på trettio språk. Utgivningsdatum är inte bestämt. Byt verktygsspråk med väljaren högst upp i Inspector. Efter publicering hämtar installationsprogrammet dessa versioner och kompatibla beroenden från VPM-förråd. Lokal utgivningsförberedelse publicerar inte paketen.

Kawaii Posing Tool innehåller posebibliotek, konfigurationsverktyg och förinställningar för avatarjustering. Installationsprogrammet aktiverar produktens befintliga lokala licens; inget nytt Gumroad-licensnyckelfält behövs. Lägg aldrig installationsfiler eller licensdata i en offentlig supportfråga.

Språkval sparas i Unity EditorPrefs för aktuell OS-användare och delas mellan Unity-projekt på den här datorn. Utan sparat val följer installationen OS-språket; språk utan stöd använder engelska. Produktlicenser behåller befintlig lagring: aktuell användares registernyckel `Software/UnisakiStudio` i Windows och licensfiler per användare på macOS/Linux. Språkbyte tar inte bort en licens. Alla posverktyg och avatarer använder samma språk. En ändring i något verktygs Inspector uppdaterar den gemensamma inställningen; språkval för enskilda avatarer ignoreras. Språkknappen visas bara vid den första installationsbekräftelsen om inget språk har sparats. Senare språkändringar görs i Inspector.

## 2. Lägg till verktyget i en avatar

1. Markera avataren med **VRC Avatar Descriptor**, eller ett underobjekt, i **Hierarchy**. Använd en avatar i en scen, inte ett prefab-asset i Project eller Prefab Mode.
2. Högerklicka på avataren och välj **Unisaki Studio > Lägg till Kawaii Posing**. Om den installerade versionen har japanska menyer väljer du **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Verktyget läggs till inuti avataren. Det sparade objektnamnet kan fortfarande vara **可愛いポーズ** även när visningstexterna översätts.
4. Tillämpa en passande avatarförinställning om den erbjuds. Annars öppnar du **Avatarinställningar** och väljer en förinställning eller justerar poserna själv.
5. Installationen kan erbjuda förberäkning. Den är valfri; vanliga avatarbyggen genererar också nödvändiga data. Återanvänd förberäkning för kortare senare byggtider.
6. Välj verktygsobjektet, ange önskade poser och funktioner och ladda upp avataren som vanligt med VRChat SDK.

### Språkval och välbekanta etiketter

Versionen har **Language / 言語** högst upp i verktygets Inspector. Samma val styr Inspector och genererad spelmeny. Avataren sparar sitt språk, och senaste valet sparas för andra verktyg/projekt på datorn. Ladda upp avataren igen för att ändra språket i VRChat.

Använd etiketttabellen nedan när du följer äldre japanska handledningar. Versionen har språkval, lokaliserad Inspector, översatta standardposnamn och spelmenyer för alla 30 språk.

| Svenska | Japansk etikett i äldre versioner |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funktioner | 機能 |
| Poser | ポーズ一覧 |
| Avatarinställningar | アバター調整 |
| Öppna inställningar | 設定を開く |
| Uppdatera förberäkning | プレビルドを更新 |
| Kontrollera inställningar | 設定の確認 |
| Förhandsvisning | プレビュー |
| Animationsjustering | アニメーション調整 |
| Läs in igen | 再読込 |

Medföljande Inspector, redigerings-/installationsdialoger, standardposnamn och genererade menyer är översatta till alla 30 valbara språk. README, ändringshistorik och offlinehandbok finns på varje språk. Avatarnamn, sparade objektnamn, egna posnamn, assetfilnamn och interna parameteridentifierare kan behålla sin ursprungliga stavning.

[Snabbreferenser på 30 språk](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) beskriver funktioner och standardposnamn i tabeller. Detta är korta referenser; använd språkindexet för fullständig dokumentation.

## 3. Välj poser och funktioner

Inspector har tre huvudflikar:

| Flik | Användning |
| --- | --- |
| **Funktioner** | Spelkontroller, tillval, andning, ikoner och expression-parametrarnas användning. |
| **Poser** | Aktiva poser, kategorier/sökning, ordning, animationsimport, förhandsvisning, detaljer och animationsjustering. |
| **Avatarinställningar** | Avatarspecifik korrigering och knäkorrigering, import av ursprungliga/egna rörelser samt förinställningar. |

Aktivera endast de menykontroller du tänker använda. **Spegla** i menyn låter dig exempelvis växla spegling i VRChat; det tvingar inte alla poser att alltid vara speglade.

Kawaii Posing innehåller avatarförinställningar och IK för stödda poser. Tre standardryggposer har redan sidrörelser tilldelade: **Ben utsträckta (足伸ばし)**, **Avslappnad (リラックス)** och **Ett knä upp (膝立て)**. Använd rätt förinställning och kontrollera varje poses Vänd dig-inställning om du ändrat eller ersatt dessa poster.

### Förinställningar och passform

Förinställningarna finns nära slutet av **Avatarinställningar**. Sök på avatarnamn och tillämpa en förinställning för att ersätta aktuella poseinställningar. Spara eller säkerhetskopiera justeringar innan du byter. En förinställning är en utgångspunkt: kroppsproportioner, kläder och avatarändringar kan ändå kräva manuell korrigering.

Använd **Animationsjustering** för att förhandsvisa och ändra kroppens och lemmarnas placering. Spara justeringsanimationen i det fönstret när du är klar. Automatisk hand-/fotjustering (IK) kan aktiveras övergripande och per pose där den stöds. Inbakning av aktuellt IK-resultat skapar en justeringsanimation och stänger av IK för posen, så att du kan finjustera manuellt. Ursprungsklippet bevaras.

**Förhindra bakåtböjda knän** har detaljer såsom minsta knäböjvinkel. Avatarspecifika korrigeringar är endast tillgängliga när motsvarande data finns, och vissa kan inte kombineras med pose-IK.

### Ursprungliga och egna rörelser

**Använd ursprungliga stående, hukande och magposer** identifierar rörelser från avatarens Base-lager vid generering. **Använd egna rörelser** öppnar separata importinställningar per rörelsetyp. Välj en rörelse per typ. Manuella val prioriteras över automatisk import för respektive typ.

Automatisk import tillämpas på byggkopian. Den skriver inte tillbaka identifierade animationer till scenens manuella lista eller ändrar ursprungliga controllers. Rensa ett manuellt val för en typ om automatisk identifiering ska ta över igen. Egna Base-lager och andra förflyttningssystem kan kräva individuella justeringar.

## 4. Använd verktyget i VRChat

Öppna avatarens **Expressions**-meny och gå till **Kawaii Posing**. Välj en pose för varje kategori du vill använda. Poseval och funktionsval är separata åtgärder.

- **3-punkts-VR:** sänk eller höj huvudet för att växla mellan stående, hukande/på stol, golvsittande och liggande. Justera höjdtrösklar i verktygets inställningsmeny om växlingen sker för tidigt eller sent.
- **Skrivbord:** använd **C** för att huka och **Z** för att lägga dig. Höj tröskeln för liggande om Z lämnar dig sittande.
- **Mage/rygg:** ansiktsriktningen avgör läget. Om båda är valda kan hopp på stället växla mellan dem. Stäng vid behov av hoppväxling under Unitys **Funktioner > Praktiska funktioner**; inga extra synkroniserade parametrar används.
- **Lås:** använd huvud-, arm- och fotlås efter behov. Stäng av gester om posens handform ska ersätta kontrollerinmatningen.
- **Spegla:** vänd en pose mot en vän eller för att passa bildkompositionen.

### Fothöjd och golvhöjd

**Fothöjd** justerar fötterna med bibehållen huvudposition. Använd den om fötterna svävar eller sjunker medan huvudet redan har rätt höjd.

**Golvhöjd** flyttar hela kroppen inklusive huvudet. Använd den för soffor, sängar eller upphöjda ytor, även möbler utan collider. Med det gemensamma systemets nuvarande centrerade kontroll är **50% ursprungshöjden**, 0% är 3 m ned och 100% är 3 m upp. Återgå nära 50% för att avsluta förskjutningen. Äldre versioner kan ha andra kontroller; kontrollera installerad version och uppdatera det gemensamma systemet tillsammans med produkten.

### Fotoläge

Aktivera menyposten **Fotoläge** i Unity före uppladdning. Välj en pose i VRChat, flytta upp till 3 m framåt med **Avstånd** och rotera med **Riktning**. Fotlås är valfritt medan du komponerar bilden. **Avsluta foto** återställer avstånd/riktning och låser upp fötterna.

Fotoläge är lokalt som standard. Aktivera **Synkronisera Fotoläge** i Unity före uppladdning för att andra ska se position och rotation; detta använder 16 synkroniserade bitar. **Håll huvudet synligt i Fotoläge** påverkar din egen vy och använder inga synkroniserade bitar.

### Andning och Vänd dig

Andning ställs in per kategori under **Funktioner > Praktiska funktioner > Animera andning**. Välj Ingen, Svag, Medel, Stark, Snabb eller en egen andningsanimation. Rörelsen använder inga synkroniserade bitar. En andningsknapp i menyn använder 1 bit.

Vänd dig kräver en liggande pose som stöds och menyposten **Vänd dig**. Aktivera vändning för posen och ange sidanimation vid behov. Välj posen i VRChat, aktivera Vänd dig och lås upp huvud/nacke. Huvudets sidolutning styr sedan vändningen. Vanlig MotionTime-styrning är inte tillgänglig för posen medan Vänd dig används.

De tre standardryggposerna ovan har medföljande sidrörelser. Andra poser kräver en lämplig rörelse och poseinställning. Importerade eller egna förinställningar kan ha andra tilldelningar.

## 5. Redigera, lägg till och förhandsvisa poser

Välj kategori eller sökflik under **Poser**. Sökningen accepterar ursprungliga japanska namn och tillgängliga översättningar. Öppna **Detaljer** för att ändra animation, ikon, ordning och tidsinställningar.

Lägg till flera animationer genom att dra klipp till tilläggsfältet eller markera dem i Project och använda kommandot för import av valda klipp. Dubbla referenser till samma klipp tas bort. Ändra målposition i Detaljer eller använd uppåt-/nedåtknapparna.

**Förhandsvisning** visar en pose i Scene utan att öppna hela justeringsfönstret. Den kör inte Modular Avatar eller NDMF, så kontrollera kläder, golvkorrigering och andra byggfunktioner i det slutliga avatarbygget.

Poseikoner från avataren gör poser lättare att identifiera, men generering tar tid och kan öka avatarens datastorlek. Minska ikonupplösningen för att spara utrymme. Android-byggen genererar inte poseikoner. Skapa om ikoner efter ändrad avatar eller klädsel vid behov.

## 6. Parameterminne

Inspector visar poseverktygens bidrag, inte hela avatarens total. Kläder och andra system kan använda mer parameterminne. Gemensamma inställningar mellan flera poseverktyg dubbelräknas inte. Egna konfigurationer med många extra poser kan kräva fler posevalsbitar.

| Funktion | Extra synkroniserade bitar |
| --- | ---: |
| Poseval, minsta standardkonfiguration | 8 |
| Spegla | 1 |
| Gester av | 1 |
| Andningsrörelse | 0 |
| Andningsknapp i menyn | 1 |
| Fothöjd | 8 |
| Golvhöjd | 8 |
| Fotoläge, endast lokalt | 0 |
| Synkronisera Fotoläge | 16 |
| Håll huvudet synligt i Fotoläge | 0 |
| Stäng av VRChats stillastående svajning | 0 |
| Vänd dig | 10 |

Vänd dig delar 1 bit med korrigeringen för huvudriktning: båda tillsammans använder fortfarande 10 bitar. Användningsvisningen i din installerade version är praktisk referens för din valda konfiguration.

## 7. Uppdatering och förberäkning

1. Säkerhetskopiera projektet och spara arbetsscenen.
2. Uppdatera **Kawaii Posing Tool** och gemensamma **Unisaki Posing System** tillsammans i VCC eller ALCOM. Håll också SDK, Modular Avatar och NDMF kompatibla.
3. Vänta tills kompileringen är klar. Välj befintligt verktyg och granska poser, inställningar och parameteranvändning.
4. Om du använder förberäkning väljer du **Uppdatera förberäkning** och laddar sedan upp avataren igen.

Befintliga verktygsinställningar bevaras. Äldre 8-bit-prefab finns kvar för kompatibilitet; befintliga referenser kräver inte borttagning eller ersättning av verktyget. Nya installationer använder vanliga prefab och oanvända funktioner kan stängas av för lägre parameteranvändning.

En varning om gammal förberäkning betyder att inställningar ändrats sedan cachedata genererades. Uppdatering av förberäkningen genererar om dessa data. Att dölja en varning uppdaterar inte förberäkningen eller löser dess grundorsak. Vanliga avatarbyggen genererar nödvändiga data även om du inte förberäknar manuellt varje gång.

## 8. Felsökning

| Symptom | Kontrollera |
| --- | --- |
| Ingen meny för att lägga till verktyget | Kontrollera att produkten **och** Unisaki Posing System är installerade och lös kompileringsfel i Unity Console. Enbart licensinstallationen är inte posebiblioteket. |
| Installation avbruten eller filer borttagna | Importera den köpta installationen igen när du är redo. Läs bekräftelserna igen. |
| Licens verkar saknas i ett annat projekt | Importera den köpta installationen med samma OS-konto. Vid ny dator/konto installerar du licensen även där. Språkval överförs inte automatiskt mellan datorer. |
| Inga poser i VRChat | Lägg verktyget under rätt scenavatar, aktivera poser, granska Inspector-varningar och ladda upp den avataren. Kontrollera SDK och andra förflyttningsverktyg. |
| Z når inte liggande läge | Höj tröskeln för liggande i verktygets spelinställningar. |
| Händer eller knän passar inte | Prova rätt avatarförinställning, följt av stödd IK och/eller Animationsjustering. Kontrollera kläddeformation i slutbygget. |
| Vänd dig fungerar inte | Använd en stödd liggande pose, aktivera både posens vändningsinställning och menyposten och lås upp huvud/nacke. Prova först en av de tre standardposer som stöds. |
| Vänner ser inte fotoförflyttningen | Aktivera **Synkronisera Fotoläge** i Unity, kontrollera parameteranvändning och ladda upp igen. |
| Språk ändras i Unity men inte VRChat | Ladda upp avataren igen. Kontrollera den gemensamma språkväljaren högst upp i Inspector i versioner med språkstöd. |
| Bygg-/förberäkningsfel | Läs det **första** relevanta Console-felet. Säkerhetskopiera scenen, uppdatera/hämta produkten och gemensamma systemet via VCC/ALCOM och kontakta support om felet kvarstår. Behåll justerade objekt och GeneratedResources om supporten inte ger ett särskilt återställningssteg. |

Ange produkt-/systemversioner, Unity/SDK/Modular Avatar/NDMF-versioner, avatarnamn, exakta reproduktionssteg och relevant Console-fel vid support. Ta bort privata filer, installationsinnehåll, licensvärden och kontouppgifter från offentliga inlägg.

- [Support](https://help.unisakistudio.jp/)
- [Illustrerad onlinehandbok (japanska)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Produktsida på Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licenser och erkännanden

En [engelsk referensöversättning av produktavtalet](../../Terms.en.html) medföljer det japanska originalavtalet.

Läs produktens originalavtal och det gemensamma systemets avtal bredvid paketets README eller i mappen `Licenses` i köpta ZIP-filen. Det medföljande engelska avtalet för Unisaki Posing System är en befintlig referensöversättning för det systemet; produktens japanska avtal medföljer separat. Handboken ändrar inte avtalen eller ger ytterligare rättigheter. Kontakta support om användning eller vidarefördelning av produktdata.

Installationen innehåller en modifierad **VPMPackageAutoInstaller** av **anatawa12**, med **SimpleJson** och **semver.net**. Upphovsrättsmeddelanden och MIT-licenstexter finns i `ThirdPartyNotices.txt` i köpta ZIP-filen. Posebibliotek och andra produktresurser har egna produktlicenser.
