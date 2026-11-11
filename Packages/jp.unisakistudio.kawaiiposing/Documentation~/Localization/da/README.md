# Kawaii Posing

Et positurlåsværktøj til VRChat med søde siddende og liggende positurer, også med 3-punktssporing eller på skrivebordet. Indeholder i alt 85 positurer: 15 stående, 20 i hug, 17 siddende, 16 på maven og 17 på ryggen.

Denne README gælder v3.2.0 under udvikling. Endelig udgivelsesdato er ikke fastsat. Installeret version vises øverst i Inspector.

- [Produktside på BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Ændringshistorik](CHANGELOG.md)

## Visningssprog og offlinedokumentation

Vælg visningssprog med ”Language / 言語” øverst i Inspector. Ét valg gælder både Inspector og den genererede VRChat-menu. Upload avataren igen for at ændre sproget i spillet.

Uden et valg bruges computerens sprog, eller engelsk hvis sproget ikke understøttes. Windows, macOS og Linux understøttes. Det seneste valg gemmes i EditorPrefs og bruges i andre projekter for samme OS-bruger på denne computer. Alle positurværktøjer og avatarer bruger samme sprog. En ændring i et hvilket som helst værktøjs Inspector opdaterer den fælles indstilling; sprogvalg for enkelte avatarer ignoreres. Valget synkroniseres ikke til andre computere. Licenslagringen ændres ikke. Sprogknappen vises kun ved den første installationsbekræftelse, hvis der ikke er gemt et sprog. Senere sprogændringer foretages i Inspector.

README, ændringshistorik og vejledning vælges fra den medfølgende [sprogliste](../index.html). Inspector-knapperne til vejledning og ændringshistorik følger også det valgte sprog. Originale brugsbetingelser og referenceoversættelser leveres fortsat separat.

## Vigtigste funktioner

- Fototilstand: flyt avataren op til 3m frem og justér retning. Kun lokalt bruger 0 bit; visning af position/retning for andre bruger 16 bit.
- Hovedvisning under foto: forhindrer, at eget avatarhoved tæt på kameraet skjules i Fototilstand.
- Gulvhøjde: flytter hele kroppen inklusive hovedet 3m op/ned. 50% er oprindelig højde og standard, 0% er 3m ned og 100% er 3m op. Brug separat fra Fodhøjde, der flytter fodsiden med fast hovedposition.
- Vend dig: vend til begge sider efter hovedhældning i understøttede liggende positurer.
- Vejrtrækning: bevægelse i blandt andet brystkassen med Ingen, Svag, Middel, Stærk, Hurtig eller Egen pr. kategori.
- Slå VRChats svajen i stilstand fra: dæmper standardsvajen og bevarer værktøjets vejrtrækning og andre egne bevægelser.
- Reducér forvrængning fra hovedrotation: reducerer forvrængning ved frigivet nakke, når hovedretningen afviger fra originalposituren.
- Funktionsvalg: tilføj kun ønskede spilmenuer og se ExpressionParameters-forbrug i Inspector.
- Søgning, massetilføjelse og rækkefølge: søg på tværs af kategorier, importér flere klip og vælg målplacering.
- Let Scene-forhåndsvisning: se posituren direkte via Forhåndsvisning i listen.

- Automatisk lemjustering (IK): tilpasser lemmer til avatarens kropsbygning i understøttede positurer. Kan slås til/fra pr. positur, og resultatet kan indarbejdes i justeringsanimation.

### Vend dig med de medfølgende positurer

Rygliggende Ben strakt ud, Afslappet og Ét knæ op har sidestillinger til vending. De bygger henholdsvis på ”横向き寝” (liggende på siden), Lur og Kattelur.

Aktivér ”Funktioner > Menufunktioner > Vend dig” og upload. Vælg den understøttede positur og Vend dig i VRChat med nakkelåsen frigivet.

Tilføj selv støtte via ”Positurer > Detaljer > Aktivér Vend dig”, og angiv animation i ”Sidepositur til vending”. Almindelig MotionTime kan ikke bruges for positurer med Vend dig.

### Tilpasning til kropsbygning

Den medfølgende automatiske lemjustering kan bruges, men alle positurer behøver ikke IK. ”Aktivér automatisk justering af lemmer” styrer helheden i animationsjusteringen; ”Aktivér IK til denne positur” styrer den enkelte.

”Indarbejd IK i justeringer” skriver det aktuelle automatiske resultat til en ny justeringsanimation og slår positurens IK fra, så du kan færdiggøre manuelt. Kræver automatisk justering globalt og for posituren samt relevante IK-indstillinger.

”Avataropsætning” har også ”Forhindr bagudbøjning af knæ” og detaljen ”Mindste knæbøjning (grader)”.

## Installation

1. Hent filer fra produktsiden i butikken, hvor du købte varen.
2. Importér ”可愛いポーズツール.unitypackage” i Unity og registrér licens og pakkekilde.
3. Tilføj Kawaii Posing og Modular Avatar til Unity-projektet i VCC eller ALCOM. Fælles Unisaki Posing System og NDMF installeres som afhængigheder.
4. Højreklik på avataren i Hierarchy og vælg ”Unisaki Studio > Tilføj Kawaii Posing”.
5. Vælg tilføjede ”可愛いポーズ” i avataren og konfigurér funktioner og positurer i Inspector.
6. Upload avataren normalt.

Kræver Unity 2022.3, VRChat Avatars SDK 3.10.4 eller nyere, Modular Avatar 1.x fra 1.15.1 og NDMF 1.x fra 1.14.0. Opdatér nødvendige pakker sammen i VCC eller ALCOM.

## Opdatering fra tidligere versioner

Opdatér produktet sammen med Unisaki Posing System. Eksisterende værktøjsindstillinger bevares. Kontrollér funktioner og ExpressionParameters-forbrug i Inspector, og tryk ”Opdatér forberegning” før ny upload, hvis den bruges.

Fra v3.1.0 bruger nye tilføjelser det almindelige Prefab ”可愛いポーズ”. Slå unødvendige punkter fra under Funktioner for minimumsopsætning med kun positurvalg på 8 bit. Mange positurer kan kræve ekstra valgbits.

Ældre 8bit-Prefab bevares under ”Editor/Legacy” for eksisterende avatar- og forudindstillingsreferencer. Du behøver ikke slette eller erstatte eksisterende Prefab. 8bit vises ikke i Unitys menu for nye tilføjelser.

## Hvor indstillingerne findes

| Fane | Muligheder |
| --- | --- |
| Funktioner | Spilmenuer, praktiske funktioner, vejrtrækning, ikoner og ExpressionParameters-forbrug |
| Positurer | Valg, detaljer, søgning, massetilføjelse, rækkefølge, forhåndsvisning og animationsjustering |
| Avataropsætning | Avatarspecifik korrektion, knæ, oprindelige/egne bevægelser og forudindstillinger |

”Åbn indstillinger” viser detaljer under punktet. Vejrtrækning konfigureres via ”Funktioner > Praktiske funktioner > Animér vejrtrækning”.

”Brug oprindelige stående, hug- og mavepositurer” importerer avatarens oprindelige positurer automatisk. Egne bevægelser angives separat via importindstillinger for hver type, eksempelvis stående, hug (Crouching) og maveliggende (Prone).

Forudindstillinger findes nederst i Avataropsætning. ”Anvend denne forudindstilling” erstatter aktuelle indstillinger, så gem egne justeringer før skift.

### Forbrug pr. funktion

- Vejrtrækningsbevægelse bruger 0 bit. Kun ”Menufunktioner > Vejrtrækning” til stop/genstart i spillet bruger 1 bit til til/fra-synkronisering.
- Fototilstand bruger 0 bit kun lokalt. ”Praktiske funktioner > Synkronisér Fototilstand” bruger 16 bit. ”Hold hovedet synligt i Fototilstand” bruger 0 bit.
- Fodhøjde og Gulvhøjde bruger hver 8 bit. Gulvhøjde flytter op/ned fra midten og afslutter korrektion tæt på 50%.
- Vend dig alene bruger 10 bit og deler 1 bit med Reducér forvrængning fra hovedrotation, så begge tilsammen også bruger 10 bit.
- Spejlvend og Gestus fra bruger hver 1 bit.

Inspector-totalen omfatter avatarens positurværktøjer, ikke tøj og andre værktøjer. Delte indstillinger tælles ikke dobbelt ved flere positurværktøjer.

### Forhåndsvisning og redigering af positurer

”Forhåndsvisning” på hver positur viser den i Scene. Åbn ”Animationsjustering” for at gennemse, finjustere og gemme.

Let forhåndsvisning kører ikke MA- eller NDMF-build. Kontrollér tøj og gulvkorrektioner, som indarbejdes ved build, i det endelige resultat før upload.

Søg efter navne med forstørrelsesglasfanen til venstre. Vælg mål under ”Detaljer > Rækkefølge” eller brug op/ned. Tilføj flere animationer ved træk til feltet eller ”Importér klip valgt i Project”.

”Opdatér positurminiaturer” genererer billeder efter bekræftelse. ”Generér positurikoner” gør positurer lettere at kende i spilmenuen, men øger byggetid. Vælg ”Reducér ikonstørrelse” for mindre størrelse. Der genereres ikke positurikoner til Android.

## Grundlæggende spilbetjening

- Vælg positurer pr. kategori i Expressions-menuen. I VR skifter stående, hug, siddende og liggende efter hovedhøjde.
- I liggende skifter ryg/mave efter ansigtsretning. Med begge valgt kan hop på stedet også skifte. Slå dette fra i Unity under ”Funktioner → Praktiske funktioner → Skift liggende positurer ved at hoppe” (aktivt som standard). Kategoriers højdegrænser justeres i indstillingsmenuen.
- På skrivebordet bruges C og Z. Hæv liggehøjdetærsklen i indstillinger, hvis Z ikke giver liggende.
- Gestus fra bruger positurens håndform i stedet for controllerens fingre.
- Fodhøjde justerer fodsiden med fast hovedposition. Gulvhøjde flytter hele kroppen inklusive hovedet op/ned. De står i den rækkefølge i indstillinger.
- Når Afstand i Fototilstand flytter fremad, vender avataren mod dig. Drej med Retning, og slå Lås fødder til efter behov. Afslut foto nulstiller afstand/retning og frigiver fodlåsen.
- Vejrtrækning kan bruges med aktiv bevægelse; styrken vælges i Unity, til/fra i spillet.

## Forberegning og advarsler

”Opdatér forberegning” genbruger genererede data til hurtigere avatarbuilds. Uden forberegning genereres nødvendige data også ved almindeligt build.

Efter ændringer vises opdateringsbehov under Kontrollér indstillinger øverst i Inspector og med Hierarchy-markeringer. Indstillinger for advarselsvisning findes i samme felt. Skjult visning løser ikke problemer eller opdaterer genererede data.

## Bemærkninger om brug

- Positurlås med fuldkropssporing understøttes ikke.
- Kropsbygning, tøj og avatarændringer kan kræve ekstra tilpasning.
- Særlige Base-lag eller andre positurværktøjer kan integrere uventet. Kontrollér ”Avataropsætning > Integrér sporingslåsninger med andre værktøjer” ved låseproblemer.
- Bevægelse/rotation i Fototilstand og Gulvhøjde korrigerer også standard-/egne bevægelser uden valgt positur. Kontrollér synspunkt og erstattede standardbevægelser i den faktiske VRChat-klient.
- Slå VRChats svajen i stilstand fra påvirker standardanimationen, ikke alle andre årsager til svajen.

## Vejledning og support

Åbn vejledning, kontakt og ændringshistorik via ”Hjælp / Ændringer” øverst i Inspector. Fælles funktioner beskrives også under ”Packages > Unisaki Posing System > README” i Unitys Project.

- [Officiel vejledning](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Kontakt](https://help.unisakistudio.jp/)

Ved fejlrapportering: oplys produkt- og Unisaki Posing System-versioner, Unity/VRChat SDK/Modular Avatar/NDMF-versioner, avatar, trin til genskabelse og Console-fejl.

## Distribution af forudindstillinger

Dette gælder data oprettet med animationsjustering.

Justeringsanimationsfiler oprettet med funktionen samt forudindstillinger oprettet med dem tildelt må frit distribueres og sælges uden tilladelse fra Unisaki Studio. Del dem gerne med egne avatarer eller som forudindstillinger for avatarer, der ikke følger med værktøjet.

## Produkter med medfølgende integration

※ Vores butik har selvstændigt oprettet integrationerne. Vi har ikke bedt produktforfatterne om tilladelse, da vi vurderer, at det ikke kræves. Kontakt butikken via besked om ønsker til distribution eller ophør af integrationer. Køb/download af den integrerede vare kræves. Kontakt vores butik ved problemer med indstillingerne, ikke de andre produkters forfattere.

”可愛い座りツール”
https://yunisaki.booth.pm/items/3611536

”添い寝ツール”
https://yunisaki.booth.pm/items/3670993

”少女モーション集vol.1” af ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

”VRC想定移動モーション（無料配布）” af カトのVRC道具屋
https://booth.pm/ja/items/1285101

”ごろ寝システムEX” af minminmart
https://minminmart.booth.pm/items/4233545

## Brugsbetingelser

Værktøjet må kun bruges ved accept af følgende brugsbetingelser oprettet med VN3-licensen.

[Brugsbetingelser (japansk)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Kildekode og ressourcer er ikke open source. Gyldigt produktkøb og accept af brugsbetingelser kræves.

[Brugsbetingelser (engelsk)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
