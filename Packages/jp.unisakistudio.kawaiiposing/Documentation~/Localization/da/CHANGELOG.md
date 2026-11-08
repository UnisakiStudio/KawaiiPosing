# Ændringshistorik

## [3.2.0] - Ikke udgivet

### Tilføjet

- Inspector, redigeringshandlinger, installationsdialoger, standardpositurnavne og genererede VRChat-menuer kan vises på 30 sprog.
- Inspector og spilmenu bruger fælles sprogvalg. Først bruges computerens sprog, og seneste valg genbruges i andre projekter for samme OS-bruger.
- README, ændringshistorik og offlinevejledning kan åbnes på valgt sprog.
- Visningsnavne for 128 standardpositurer og funktionsbeskrivelser følger eksisterende terminologi.

### Kompatibilitet

- Eksisterende avatarindstillinger, egne navne, assetreferencer, parameteridentifikatorer og licenslagring bevares.

## [3.1.2] - 2026-11-09

- Hovedlås kan skiftes via EX-menuens ”Indstillinger → Automatisk hovedlås på ryggen”, selv med Fodhøjde fra. Punkter, som forsvandt i tidligere versioner, vender tilbage ved build efter opdatering.
- Understøtter Unisaki Posing System 3.1.2. Rettet vedvarende opadvendt ansigt efter oprejsning fra maveliggende med Reducér forvrængning fra hovedrotation.

Opdatér Kawaii Posing til 3.1.2 i ALCOM / VCC. Unisaki Posing System 3.1.2 kræves også. Ved brug af forberegning: tryk Opdatér forberegning, gem scenen og byg/upload avataren igen.

## [3.1.1] - 2026-11-08

- Aktive Gulvhøjde og Vend dig vises under Indstillinger i VRChats EX-menu, selv om Spejlvend er fra.
- Korrekte vendinger for Ben strakt ud, Afslappet og Ét knæ op bevares ved ældre omarrangering, sletning og omdøbning, også efter fuld Unpack hvis oprindelsen findes. Egne positurer, bevidst deaktiverede vendinger og erstattede sidebevægelser bevares.
- Rettet kort maveliggende ved avatarvalg og kort rygliggende ved hop med kun mavepositurer. Hoppeskift slås fra under ”Funktioner → Praktiske funktioner → Skift liggende positurer ved at hoppe” og er aktivt som standard.
- Mistet genoprettelig fælles positur-Animator Controller-reference giver advarsel og genskabes fra indstillinger. Referencer delt mellem avatarer bevares.
- Officielt Prefab kan tilføjes fra menuen trods eget Prefab med samme navn ”可愛いポーズ”.
- Ved tilføjelse af 添い寝ツール vises den nødvendige vare, der skal installeres først, hvis den mangler.

Opdatér både Kawaii Posing og Unisaki Posing System til 3.1.1 i ALCOM / VCC. Ved brug af forberegning trykkes Opdatér forberegning på scenens ”可愛いポーズ”, hvorefter scenen gemmes. Byg og upload igen for at anvende i VRChat.

## [3.1.0] - 2026-11-07

- 53 af 85 positurer får automatisk lemtilpasning med IK efter kropsbygning.
- Rygliggende Ben strakt ud, Afslappet og Ét knæ op understøtter Vend dig via hovedhældning.
- Fototilstand justerer position/retning med valgfri synkronisering og eget hoved synligt.
- Gulvhøjde flytter hele kroppen 3m op/ned, separat fra Fodhøjde.
- Tilføjet vejrtrækning, stop af standardsvajen og reduceret forvrængning fra hovedrotation.
- Inspector viser funktioner og parameterforbrug. Søgning, massetilføjelse, omarrangering og let Scene-forhåndsvisning understøttes.
- Hurtigere stående/hug/siddende-skift på skrivebordet.
- Forbedrede forberegningsadvarsler, Inspector-rulning og stop ved genereret oprydning.
- Understøtter Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Åben beta (2026-11-05)

- Åben beta på GitHub Releases og VPM. 53 af 85 positurer tilpasser lemmer med IK efter kropsbygning.
- Understøtter fællespakken 3.1.0-beta.2 med bedre ændringsvisning efter forberegning, Inspector-rulning og oprydningsstop.

## [3.1.0-beta.1] - Åben beta (2026-11-04)

- Understøtter Unisaki Posing System 3.1.0-beta.1.
- Normalt positurskift på skrivebordet bruger én evaluering ved almindelige builds og forberegning; VR og særlige forhold beholder tidligere vej.
- Forberegninger fra alpha.3 eller før skal opdateres.
- Synspunkt bevares ved gulvhøjdeændring i Fototilstand, og seneste gulvhøjde gendannes ved afslutning.
- Medtager forbedringer gennem alpha.3 af automatisk import, justering af importerede bevægelser og genererede Controllers.

## [3.1.0-alpha.2] - Lukket test (2026-10-26)

### Rettelser og ændringer

- Fælles posesystem opdateret til 3.1.0-alpha.2 med fejlrettelser.
- Gulvhøjde udvidet til 3m op/ned, 50% er oprindelig højde og standard.
- Standard-/egne bevægelser uden valgt positur korrigeres også af Fototilstand og Gulvhøjde.
- Rettet manuel korrektion, ens navne, startpositurer og ældre forudindstillingers Vend dig-indstillinger.

## [3.1.0-alpha.1] - Før offentlig udgivelse

### Tilføjet

- Tilføjet automatisk lemjustering (IK) efter kropsbygning.
- Tilføjet IK til/fra globalt og pr. positur samt indarbejdning i justeringsanimation.
- Rygliggende Ben strakt ud, Afslappet og Ét knæ op understøtter Vend dig via hovedhældning.
- Tilføjet vendeindstillinger og sideanimation pr. positur.
- Tilføjet Fototilstand med fremadflytning og rotation.
- Fototilstand-synkronisering: kun lokalt 0 bit, synkroniseret 16 bit.
- Tilføjet valg om at bevare eget hoved synligt i Fototilstand.
- Tilføjet Gulvhøjde, som hæver hele kroppen inklusive hovedet.
- Tilføjet vejrtrækningsbevægelse, styrke og til/fra-menu i spillet.
- Tilføjet stop af VRChats standardsvajen.
- Tilføjet reduceret forvrængning fra hovedrotation.
- Tilføjet beskyttelse mod bagudbøjede knæ og mindste bøjevinkel.
- Tilføjet til/fra pr. funktion og ExpressionParameters-forbrug.
- Tilføjet let Scene-forhåndsvisning, søgning, massetilføjelse og målplacering i rækkefølge.
- Tilføjet historikvisning i Inspector.

### Ændret

- Inspector opdelt i Funktioner, Positurer og Avataropsætning.
- Vejrtrækningsdetaljer, import af egne bevægelser og forudindstillinger omorganiseret.
- Færre dublerede Fodhøjde-animationer.
- Bekræftelse ved positurbilledopdatering og advarselsvalg samlet under Kontrollér indstillinger.
- Ny 8bit-tilføjelsesmenu afskaffet til fordel for almindeligt Prefab med funktionsvalg; eksisterende referencer bevares.
- Understøtter Unisaki Posing System 3.1.0-alpha.1. Mindste VRChat Avatars SDK-version er 3.10.4.

### Rettet

- Rettet navneinput, som flyttedes til anden positur, og detaljer, som lukkedes ved omarrangering.
- Rettet overlappende forhåndsvisninger, forkert placering og fejl på visse avatarer.
- Rettet opdatering af advarsler/forberegningsstatus efter ændringer samt visse buildfejl.

## [3.0.13] - 2026-09-22
- Opdateret til PosingSystem 3.0.17 og rettet vandret positurforskydning ved ensartet skalering af hele avataren.
- Tilføjet individuelt eller fælles ignorering af advarsler om automatisk skridten, manglende forberegning og ændrede indstillinger.
- Rettet import af uegnede engangsanimationer ved manuel import af bevægelsesanimationer.

## [3.0.12] - 2026-09-15
- Tilføjet avatarforudindstilling (ルリエ).

## [3.0.11] - 2026-09-09
- Tilføjet avatarforudindstillinger (メルヴィ, ミダリス).
- Rettet bevægelseserstatning i うらら-forudindstillingen.

## [3.0.10] - 2026-08-31
- Opdateret til PosingSystem 3.0.11 og rettet forberegningsfejl med nyeste NDMF samt undtagelser ved fejlvisning.

## [3.0.9] - 2026-08-29
- Opdateret til PosingSystem 3.0.10 med lavere belastning ved forudindstillinger og Hierarchy-ikonkontrol.
- Rettet forberegningsfejl med flere posesystemer på samme avatar.

## [3.0.8] - 2026-08-26
- Opdateret til PosingSystem 3.0.9 og rettet `Avatar is null` i Play efter ugyldig forhåndsvisnings-Avatar fra NDMF-behandling.

## [3.0.7] - 2026-08-18
- Opdateret til PosingSystem 3.0.8 og rettet risiko for ugyldige positurdata ved ny højdekorrigering.

## [3.0.6] - 2026-08-12
- Tilføjet avatarforudindstillinger (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Tilføjet avatarforudindstillinger (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Tilføjet avatarforudindstillinger (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Forbedret licensinstallation og -sletning.

## [3.0.2] - 2026-01-04
- Rettet licensbehandling på Mac og Linux.

## [3.0.1] - 2025-12-28
- Tilføjet avatarforudindstillinger (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Tilføjet forberegning.
- Tilføjet animationsjustering.
- Tilføjet forudindstillinger.
- Projektinstallation via unitypackage.
- Tilføjet avatarforudindstillinger (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Løst kompatibilitetsproblemer med visse værktøjer.

## [2.2.4] - 2025-04-04
- Rettet manglende positurskift med visse avatarer og ModularAvatar-versioner.

## [2.2.3] - 2025-03-13
- Rettet forkerte bevægelser på visse avatarer, eksempelvis hop med 森羅.
- Rettet lejlighedsvis forkert standardværdi for Gestus fra.

## [2.2.2] - 2025-03-06
- Rettet fejl i visse miljøer.

## [2.2.1] - 2025-02-05
- Rettet Unity-nedbrud.
- Version tilføjet til værktøjsnavn i NDMF Console.

## [2.2.0] - 2025-02-02
- Tilføjet Gestus fra for animationens håndform.
- Håndformsdata til alle positurer.

## [2.1.6] - 2025-02-02
- Rettet ødelagte positurer med visse andre værktøjer.
- Rettet indstillingsafhængige fejl.

## [2.1.5] - 2024-12-10
- Løst visse værktøjskonflikter.
- Tilføjet knap til fjernelse af Unitypackage-versionen.
- Integrations-Prefabs til 三点だいしゅきツール fjernet efter udgivelse af VCC-versionen.

## [2.1.4] - 2024-12-08
- Rettet fejl på visse avatarer.
- Rettet ubrugelig fodlås ved værktøjs-/avatarkonflikter.
- Rettet avatarpositur, som vendte tilbage til VRC-standard på skrivebordet.

## [2.1.3] - 2024-12-01
- Rettet manglende positurskift sammen med avatarer/værktøjer, der bruger forkert VRMode-type.
- Tilføjet NDMF-Console-visning af værktøjskonflikter på grund af forskellige parametertyper.

## [2.1.2] - 2024-12-01
- Tilføjet NDMF-Console-forklaring, når andre værktøjers fejl medfører Unisaki Posing System-fejl ved build.
- Rettet buildfejl på visse avatarer.
- Forbedret adfærd lige efter avatarindlæsning.
- Avatarens oprindelige bevægelsesbehandling fjernes, fordi den kan forhindre funktionen på visse avatarer.

## [2.1.1] - 2024-11-20
- Rettet manglende mulighed for build.

## [2.1.0] - 2024-11-20
- Løst fødder/hofter under jorden på skrivebordet, så alle positurer tages korrekt.
- Tilføjet positurskift uafhængigt af hovedhøjde.
- Tilføjet tilstand uden ikongenerering til Quest-upload.
- Tilføjet flere advarsler om avatarproblemer.
- Løst konflikter mellem låsninger og AFK eller andre værktøjers armlås.
- Tilføjet automatisk nakkelås på ryggen.
- Ændret ExpressionsMenu: positurvalg i egen mappe, låsninger flyttet øverst.

## [2.0.0] - 2024-11-14
### Rettet
- VPM-pakke til VCC-understøttelse.
- Rettet 8bit-versionens forbrug på 17bit.

## [1.15.0] - 2024-11-04
### Rettet
- Rettet fejl og funktionsproblemer.

## [1.14.0] - 2024-07-05
### Rettet
- Rettet fejl med VRCFury.

## [1.13.0] - 2024-04-11
### Rettet
- Tilføjet integration med ”ごろ寝システムEX”.

## [1.12.0] - 2024-03-31
### Rettet
- Rettet ubrugeligt værktøj i visse ExMenu-tilstande.
- Spejling tilføjet til indstillinger.
- Rettet kattepositur.
- Tilføjet 5 sideliggende positurer.

## [1.11.0] - 2024-03-12
### Rettet
- Rettet forvrængede positurer ved højt hoved.

## [1.10.0] - 2024-03-10
### Rettet
- Tilføjet stående funktion med 15 positurer.
- Rettet selvbevægende fødder på visse avatarer og i visse miljøer.
- Tilføjet ExpressionParameters8bit-version.

## [1.9.0] - 2024-03-05
### Rettet
- Rettet selvbevægende fødder på visse avatarer.
- Ensartede WriteDefaults.
- Tilføjet 7 hug- og 8 siddende positurer.

## [1.8.0] - 2024-02-25
### Rettet
- Rettet uploadfejl med ModularAvatar1.9.0 eller nyere.
- ModualrAvatar1.9.0 eller nyere kræves nu.

## [1.7.0] - 2024-02-23
### Rettet
- Tilføjet justering af hovedhøjdetærskler pr. positur.
- Rettet forkerte positurer/fødder ved eksempelvis hop på visse avatarer.
- ExpressionParameter-forbrug reduceret fra 54 til 16bit.

## [1.6.0] - 2024-02-20
### Rettet
- Rettet manglende siddestilling i VR.

## [1.5.0] - 2024-02-18
### Rettet
- Siddende positurer kan nu bruges med C holdt nede på skrivebordet.

## [1.4.0] - 2024-02-17
### Rettet
- Rettet 添い寝-integration, som krævede 三点だいしゅき-integration.
- Rettet fastlåste fødder ved hop.

## [1.3.0] - 2024-02-16
### Rettet
- Rettet unormalt mange VRCContactSender/Receiver.

## [1.2.0] - 2024-02-16
### Rettet
- Rettet buildfejl ved upload.

## [1.1.0] - 2024-02-15
### Rettet
- Rettet forkerte standarder med flere Prefabs.
- Rettet opsætning af 可愛い座り-integration.

## [1.0.0] - 2024-02-14
### Udgivelse
