# Kawaii Posing

Ett poslåsverktyg för VRChat som ger söta sittande och liggande poser även med 3-punktsspårning eller i skrivbordsläge. Innehåller totalt 85 poser: 15 stående, 20 hukande, 17 sittande, 16 liggande på mage och 17 liggande på rygg.

Denna README gäller v3.2.0 under utveckling. Datum för slutlig utgivning är inte bestämt. Installerad version visas högst upp i Inspector.

- [Produktsida på BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Ändringshistorik](CHANGELOG.md)

## Visningsspråk och offlinedokumentation

Välj språk under Language / 言語 överst i Inspector. Samma val styr Inspector och genererade VRChat-menyer. Ladda upp avataren igen för att ändra språk i spelet.

Utan uttryckligt val används datorns språk, annars engelska om språket saknas. Windows, macOS och Linux stöds. Senaste val sparas i EditorPrefs för andra projekt med samma systemanvändare på denna dator. Alla posverktyg och avatarer använder samma språk. En ändring i något verktygs Inspector uppdaterar den gemensamma inställningen; språkval för enskilda avatarer ignoreras. Ingen synkronisering till andra datorer. Licenslagring ändras inte. Språkknappen visas bara vid den första installationsbekräftelsen om inget språk har sparats. Senare språkändringar görs i Inspector.

Välj språk för README, historik och handbok i medföljande [språklista](../index.html). Inspectors handbok och ändringar följer också valet. Originalvillkor och referensöversättningar finns fortsatt separat.

## Huvudfunktioner

- Fotoläge: flytta avataren upp till 3m framåt och justera riktningen. Endast lokalt använder 0 bit; att visa position och riktning för andra använder 16 bit.
- Visa huvudet under fotografering: förhindrar att ditt eget avatarhuvud nära kameran döljs under Fotoläge.
- Golvhöjd: flyttar hela kroppen inklusive huvudet 3m uppåt/nedåt. 50% är ursprungshöjd och standardvärde, 0% är 3m ned och 100% är 3m upp. Använd separat från Fothöjd, som flyttar fötternas sida med bibehållen huvudposition.
- Vänd dig: vänd åt båda håll genom huvudlutning i stödda liggande poser.
- Andning: ger bland annat bröstkorgen andningsrörelser. Välj Ingen, Svag, Medel, Stark, Snabb eller Egen per posekategori.
- Stäng av VRChats stillastående svajning: dämpar standardsvajningen och behåller poseverktygets andning och andra egna rörelser.
- Minska förvrängning från huvudrotation: minskar förvrängning när nacken låses upp och huvudriktningen skiljer sig från ursprungsposens.
- Funktionsval: lägg endast till önskade spelmenyer och se ExpressionParameters-användning i Inspector.
- Sökning, massimport och omordning: sök över kategorier, importera flera klipp och ange målordning.
- Enkel förhandsvisning i Scene: se posen direkt via ”Förhandsvisning” i poslistan.

- Automatisk justering av lemmar (IK): anpassar lemmarnas positioner till avatarens kroppsbyggnad i stödda poser. Kan slås på/av per pose, och resultatet kan bakas in i en justeringsanimation.

### Vänd dig med medföljande poser

Ryggposerna ”Ben utsträckta”, ”Avslappnad” och ”Ett knä upp” har sidoposer för vändning. De bygger på ”横向き寝” (liggande på sidan), ”Tupplur” respektive ”Kattlur”.

Aktivera ”Funktioner > Menyfunktioner > Vänd dig” och ladda upp. Välj sedan en pose som stöds och ”Vänd dig” i VRChat. Använd med upplåst nacke.

För att lägga till stöd själv aktiverar du ”Poser > Detaljer > Aktivera Vänd dig” och anger en animation i ”Sidopose för vändning”. Vanlig MotionTime kan inte användas för poser med Vänd dig.

### Anpassning efter kroppsbyggnad

Medföljande automatisk lemanpassning kan användas, men alla poser behöver inte IK. ”Aktivera automatisk justering av lemmar” i animationsjusteringen styr helheten och ”Aktivera IK för den här posen” enskilda poser.

”Baka in IK i justeringar” skriver det aktuella automatiska resultatet till en ny justeringsanimation och stänger av IK för posen, så att du kan fortsätta manuellt. Kräver att automatisk justering är aktiv övergripande och för posen samt att tillämpliga IK-inställningar finns.

Under ”Avatarinställningar” finns även ”Förhindra bakåtböjda knän” och detaljinställningen ”Minsta knäböjning (grader)”.

## Installation

1. Hämta filerna från produktsidan i butiken där du köpte verktyget.
2. Importera medföljande ”可愛いポーズツール.unitypackage” i Unity och registrera licensen och paketkällan.
3. Lägg till Kawaii Posing och Modular Avatar i Unity-projektet med VCC eller ALCOM. Gemensamma Unisaki Posing System och NDMF installeras också som beroenden.
4. Högerklicka på avataren i Hierarchy och välj ”Unisaki Studio > Lägg till Kawaii Posing”.
5. Välj tillagda ”可愛いポーズ” i avataren och ange önskade funktioner och poser i Inspector.
6. Ladda upp avataren som vanligt.

Kräver Unity 2022.3, VRChat Avatars SDK 3.10.4 eller senare, Modular Avatar 1.x från 1.15.1 och NDMF 1.x från 1.14.0. Uppdatera nödvändiga paket tillsammans i VCC eller ALCOM.

## Uppdatering från tidigare versioner

Uppdatera produkten och Unisaki Posing System tillsammans. Inställningar i redan placerade verktyg bevaras. Kontrollera aktiva funktioner och ExpressionParameters-användning i Inspector. Om du använde förberäkning trycker du på ”Uppdatera förberäkning” före ny uppladdning.

Sedan v3.1.0 använder alla nya tillägg vanliga Prefab ”可愛いポーズ”. Stäng av onödiga alternativ under ”Funktioner” för en minsta konfiguration med enbart poseval på 8 bit. Många poser kan kräva ytterligare valbitar.

Äldre 8bit-Prefab finns kvar under ”Editor/Legacy” för befintliga avatar- och förinställningsreferenser. Befintliga Prefab behöver inte raderas eller ersättas. 8bit-versionen visas inte i Unitys meny för nya tillägg.

## Var inställningarna finns

| Flik | Funktioner |
| --- | --- |
| Funktioner | Spelmenyer, praktiska funktioner, andningsinställningar, ikoner och ExpressionParameters-användning |
| Poser | Poseval, detaljer, sökning, massimport, ordning, förhandsvisning och animationsjustering |
| Avatarinställningar | Avatarspecifik korrigering, knäkorrigering, import av ursprungliga/egna rörelser och byte av förinställning |

”Öppna inställningar” öppnar detaljer under det aktuella alternativet. Andning ställs in via ”Funktioner > Praktiska funktioner > Animera andning”.

”Använd ursprungliga stående, hukande och magposer” importerar avatarens ursprungliga poser automatiskt. Egna rörelser anges separat via importinställningarna för varje typ, såsom stående, hukande (Crouching) och magläge (Prone).

Förinställningarna finns längst ned i ”Avatarinställningar”. ”Tillämpa den här förinställningen” ersätter aktuella poseinställningar, så spara egna justeringar innan du byter.

### Användning per funktion

- Andningsrörelse använder 0 bit. Endast ”Menyfunktioner > Andning”, som pausar/återupptar i spelet, använder 1 bit för på/av-synkronisering.
- Fotoläge använder 0 bit om det bara syns lokalt. ”Praktiska funktioner > Synkronisera Fotoläge” använder 16 bit. ”Håll huvudet synligt i Fotoläge” använder 0 bit.
- Fothöjd och Golvhöjd använder 8 bit vardera. Golvhöjd flyttar uppåt/nedåt från mitten, och korrigeringen avslutas nära 50%.
- Vänd dig använder 10 bit ensamt. Det delar 1 bit med ”Minska förvrängning från huvudrotation”, så båda tillsammans använder också 10 bit.
- Spegla och Gester av använder 1 bit vardera.

Summan i Inspector omfattar de installerade poseverktygen på avataren, inte kläder eller andra verktyg. Gemensamma inställningar dubbelräknas inte när flera poseverktyg används.

### Förhandsvisning och posredigering

”Förhandsvisning” på varje pose under ”Poser” visar posen i Scene. För finjustering öppnar du ”Animationsjustering”, granskar posen och sparar ändringarna.

Enkel förhandsvisning kör inte MA:s eller NDMF:s byggprocess. Kontrollera även kläder och golvkorrigeringar som läggs till vid bygge i byggresultatet före uppladdning.

Sök posnamn med förstoringsglasfliken till vänster. Välj målposition under ”Detaljer > Ordning” eller använd uppåt-/nedåtknappar. Lägg till flera animationer genom att dra dem till tilläggsfältet eller använda ”Importera klipp valda i Project”.

”Uppdatera poseminiatyrer” genererar bilder efter en bekräftelsedialog. ”Generera poseikoner” gör poser lättare att känna igen i spelmenyn men förlänger byggtiden. Välj ”Minska ikonstorlek” för att minska storleken. Poseikoner genereras inte för Android.

## Grundkontroller i spelet

- Välj poser i varje kategori från Expressions-menyn. I VR växlar stående, hukande, sittande och liggande efter huvudhöjden.
- I liggande läge växlar rygg/mage efter ansiktsriktning. Om poser för båda lägen är valda kan du även växla genom att hoppa på stället. Detta kan stängas av i Unity under ”Funktioner → Praktiska funktioner → Växla liggande poser genom att hoppa” (på som standard). Kategoriernas höjdgränser justeras i inställningsmenyn.
- På skrivbordet växlar C och Z pose. Höj tröskeln för liggande i inställningsmenyn om Z inte ger liggande läge.
- ”Gester av” använder posens handform i stället för fingrarnas kontrollerstyrda form.
- ”Fothöjd” justerar fötternas sida med bibehållen huvudposition. ”Golvhöjd” flyttar hela kroppen inklusive huvudet uppåt/nedåt. De står i den ordningen i inställningsmenyn.
- När ”Avstånd” i ”Fotoläge” flyttar avataren framåt vänder den sig mot dig. Rotera med ”Riktning” och aktivera ”Lås fötter” när det behövs. ”Avsluta foto” återställer avstånd/riktning och låser upp fötterna.
- ”Andning” är tillgängligt när andningsrörelsen är aktiverad. Styrkan anges i Unity; i spelet växlar du på/av.

## Förberäkning och varningar

”Uppdatera förberäkning” återanvänder genererade data för snabbare avatarbyggen. Även utan förberäkning genereras nödvändiga data under ett vanligt bygge.

Efter ändringar visas uppdateringsbehov under ”Kontrollera inställningar” högst upp i Inspector och med markeringar i Hierarchy. ”Inställningar för varningsvisning” finns i samma ruta. Att dölja varningar löser inte inställningsproblem och uppdaterar inte genererade data.

## Att tänka på vid användning

- Poslåsning med helkroppsspårning stöds inte.
- Kroppsform, kläder och avatarändringar kan kräva extra justering.
- Särskilda Base-lager och andra poseverktyg kan ge oväntad integration. Kontrollera även ”Avatarinställningar > Integrera spårningslås med andra verktyg” om låsningen inte fungerar.
- Förflyttning/rotation i Fotoläge och Golvhöjd korrigerar även standardrörelser och egna rörelser när ingen pose är vald. Kontrollera synvinkel och ersatta standardrörelser i den faktiska VRChat-klienten.
- ”Stäng av VRChats stillastående svajning” påverkar standardsvajningen; den stoppar inte all svajning från andra orsaker.

## Anvisningar och support

Via ”Hjälp / Ändringar” högst upp i Inspector öppnar du anvisningar, support och ändringshistorik. Detaljer om gemensamma funktioner finns även under ”Packages > Unisaki Posing System > README” i Unitys Project.

- [Officiell handbok](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Kontakta oss](https://help.unisakistudio.jp/)

Vid felrapportering: ange produktens och Unisaki Posing Systems versioner, versionerna av Unity, VRChat SDK, Modular Avatar och NDMF, använd avatar, steg för att återskapa felet och Console-fel.

## Distribution av förinställningar

Detta gäller data som skapas med animationsjusteringsfunktionen.

Justeringsanimationsfiler som skapas med funktionen och förinställningar skapade med dessa tilldelade får distribueras och säljas fritt utan tillstånd från Unisaki Studio. Dela gärna exempelvis med egna avatarer eller förinställningar för avatarer som inte ingår i verktyget.

## Produkter med medföljande integration

※ Integrationsinställningarna har skapats självständigt av vår butik. Vi har inte begärt författarnas tillstånd eftersom vi bedömer att det inte behövs. Kontakta butiken via meddelande för önskemål om distribution eller upphörande av distribution av integrationsinställningar. Du måste köpa/ladda ned den integrerade produkten. Vid problem med inställningarna, kontakta vår butik och inte den andra produktens författare.

”可愛い座りツール”
https://yunisaki.booth.pm/items/3611536

”添い寝ツール”
https://yunisaki.booth.pm/items/3670993

”少女モーション集vol.1” av ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

”VRC想定移動モーション（無料配布）” av カトのVRC道具屋
https://booth.pm/ja/items/1285101

”ごろ寝システムEX” av minminmart
https://minminmart.booth.pm/items/4233545

## Användarvillkor

Verktyget får endast användas om du godkänner följande användarvillkor skapade med VN3-licensen.

[Användarvillkor (japanska)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Källkoden och resurserna i detta repository är inte öppen källkod. Ett giltigt köp och godkännande av användarvillkoren krävs.

[Användarvillkor (engelska)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
