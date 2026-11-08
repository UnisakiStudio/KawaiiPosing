# Kawaii Posing

VRChat-posetool voor schattige zit-/ligposes met 3-puntstracking of desktop. 85 poses: 15 staand, 20 hurkend, 17 zittend, 16 op de buik en 17 op de rug.

Deze README is voor v3.2.0 in ontwikkeling; de officiële datum staat niet vast. De geïnstalleerde versie staat boven in de Inspector.

- [BOOTH-productpagina](https://yunisaki.booth.pm/items/5479202)
- [Wijzigingsgeschiedenis](CHANGELOG.md)

## Weergavetaal en offline documentatie

Kies de taal bij Language / 言語 boven in de Inspector. Eén keuze geldt voor de Inspector en de gegenereerde VRChat-menu’s. Upload de avatar opnieuw om de taal in het spel te veranderen.

Zonder expliciete keuze wordt de computertaal gebruikt; niet-ondersteunde talen gebruiken Engels. Windows, macOS en Linux worden ondersteund. De laatste keuze wordt in EditorPrefs bewaard voor andere projecten van dezelfde systeemgebruiker op deze computer. Een expliciete keuze in een bestaande avatar blijft behouden. Er is geen synchronisatie met andere computers. Licenties blijven op dezelfde manier opgeslagen.

Kies de taal van README, wijzigingen en handleiding in de meegeleverde [talenlijst](../index.html). De handleiding en wijzigingen in de Inspector volgen die keuze. Originele voorwaarden en referentievertalingen blijven afzonderlijk beschikbaar.

## Belangrijkste functies

- Fotomodus: tot 3m vooruit en draaien; 0 bit lokaal, 16 bit voor anderen zichtbaar.
- Hoofd zichtbaar tijdens foto’s: voorkomt alleen in Fotomodus een onzichtbaar nabij hoofd.
- Vloerhoogte: heel lichaam/hoofd 3m omhoog/omlaag, 50% oorspronkelijk/begin, 0% 3m lager, 100% 3m hoger. Los van Voethoogte met vast hoofd.
- Omdraaien door hoofdhelling in ondersteunde ligposes.
- Ademhaling: borst e.d. met Geen/Zwak/Gemiddeld/Sterk/Snel/Aangepast per categorie.
- Standaardwiegen uitschakelen met behoud van toolademhaling/eigen beweging.
- Vervorming door hoofdrotatie verminderen na nekontgrendeling.
- Alleen gewenste menu’s, verbruik zichtbaar in Inspector.
- Zoeken, meerdere clips en doelvolgorde.
- Scene-voorbeeld direct vanuit de lijst.

- Automatische ledemaat-IK past ondersteunde poses aan de bouw aan, per pose schakelbaar en vast te leggen als aanpassingsanimatie.

### Omdraaien met meegeleverde poses

Benen gestrekt, Ontspannen en Eén knie omhoog hebben zijbewegingen op basis van respectievelijk 横向き寝 (zijligging), Dutje en Kattendutje voor Omdraaien.

Activeer Functies > Menufuncties > Omdraaien, upload en kies pose/functie in VRChat. Ontgrendel de nek.

Zelf instellen: Poses > Details > Omdraaien inschakelen en Zijpose voor omdraaien toewijzen. Gewone MotionTime vervalt voor die pose.

### Aanpassen aan lichaamsbouw

Automatische aanpassing is meegeleverd, maar niet elke pose heeft IK nodig. Globaal schakel je Automatische ledemaataanpassing inschakelen, individueel IK voor deze pose inschakelen.

IK in aanpassingen vastleggen maakt een nieuwe animatie van het resultaat en zet IK uit voor handmatige afwerking. Globale en pose-aanpassing moeten actief zijn met toepasbare regels.

Avatarinstellingen bevat ook Achterwaartse kniebuiging voorkomen en de details Minimale kniebuiging (graden).

## Installatie

1. Download de bestanden uit je winkel.
2. Importeer 可愛いポーズツール.unitypackage en registreer licentie/pakketbron.
3. Voeg Kawaii Posing en Modular Avatar toe met VCC/ALCOM; Unisaki Posing System en NDMF zijn afhankelijkheden.
4. Rechtsklik de avatar in Hierarchy: Unisaki Studio > Kawaii Posing toevoegen.
5. Selecteer Kawaii Posing in de avatar en stel functies/poses in.
6. Upload normaal.

Vereist: Unity 2022.3, VRChat Avatars SDK 3.10.4+, Modular Avatar 1.x vanaf 1.15.1 en NDMF 1.x vanaf 1.14.0. Werk benodigde pakketten samen bij met VCC/ALCOM.

## Bijwerken vanaf oudere versies

Werk product en Unisaki Posing System samen bij. Bestaande opties blijven behouden. Controleer functies/ExpressionParameters en vernieuw gebruikte voorberekening voor opnieuw uploaden.

Vanaf v3.1.0 gebruiken nieuwe tools de normale 「可愛いポーズ」-Prefab. Zonder onnodige functies kost minimumselectie 8 bit; veel poses kunnen meer selectiebits vragen.

Oude 8bit-Prefabs blijven in Editor/Legacy voor bestaande avatar-/voorinstellingsverwijzingen. Niet verwijderen of vervangen. Nieuwe toevoeging toont geen 8bit.

## Waar instellen

| Tabblad | Gebruik |
| --- | --- |
| Functies | Menu’s, gemak, ademhaling, pictogrammen en parameters |
| Poses | Selectie, details, zoeken, meer clips, volgorde, voorbeeld en animatieaanpassing |
| Avatarinstellingen | Avatar-/kniecorrectie, originele/eigen beweging en voorinstellingen |

Open de instellingen voor details onder de optie. Ademhaling staat bij Functies > Gemaksfuncties > Ademhaling animeren.

Oorspronkelijke staande, hurkende en buikposes gebruiken importeert automatisch. Eigen bewegingen wijs je apart per type toe, zoals staan, hurken (Crouching), buikligging (Prone).

Voorinstellingen staan onderaan Avatarinstellingen. Deze voorinstelling toepassen vervangt de huidige poses; sla aanpassingen eerst op.

### Verbruik per functie

- Ademhaling alleen 0 bit; schakelmenu 1 bit.
- Fotomodus lokaal 0 bit, synchroniseren 16 bit, eigen hoofd zichtbaar 0 bit.
- Voet-/Vloerhoogte ieder 8 bit. Buiten midden beweegt de vloerhoogte, nabij 50% eindigt het.
- Omdraaien 10 bit met 1 bit gedeeld met hoofdcorrectie; samen nog 10 bit.
- Spiegelen/Gebaren uit ieder 1 bit.

Inspector-totaal is voor posetools, zonder kleding/andere systemen. Gemeenschappelijke opties tellen niet dubbel.

### Voorbeeld en bewerking

Voorbeeld toont de pose in Scene. Open Animatieaanpassing voor nauwkeurige bewerking met zicht op het resultaat en sla op.

Het lichte voorbeeld voert MA/NDMF niet uit. Bekijk ook de uiteindelijke build voor kleding en grondcorrectie voor upload.

De loep zoekt namen. Orden in Details > Volgorde of omhoog/omlaag. Sleep meerdere clips of importeer geselecteerde uit Project.

Poseminiaturen bijwerken vraagt bevestiging. Posepictogrammen helpen kiezen, maar kosten buildtijd. Verlaag pictogramformaat om ruimte te besparen. Geen pictogrammen op Android.

## Basisbediening in het spel

- Kies categorieposes in Expressions. Hoofdhoogte wisselt staan/hurken/zitten/liggen in VR.
- Gezichtsrichting kiest rug/buik; beide gekozen maakt sprongwissel mogelijk. Uit onder Functies → Gemaksfuncties → Liggende poses wisselen door springen (standaard aan). Drempels regelen wisselhoogtes.
- Desktop C/Z; verhoog ligdrempel als Z niet laat liggen.
- Gebaren uit gebruikt posehanden in plaats van controllers.
- Voethoogte houdt hoofd vast; Vloerhoogte beweegt alles. In die volgorde in het menu.
- Afstand in Fotomodus beweegt en richt naar je; Richting draait. Zet Voeten vast indien nodig; Foto afsluiten herstelt en ontgrendelt.
- Ademhaling vereist actieve beweging, sterkte in Unity en schakelaar in het spel.

## Voorberekening en waarschuwingen

Voorberekening bijwerken hergebruikt data voor snellere builds. Normale builds maken het nodige ook zonder voorberekening.

Instellingen controleren en Hierarchy-markeringen melden vernieuwing na wijzigingen. Waarschuwingsweergave zit in hetzelfde vak. Verbergen repareert of vernieuwt niet.

## Gebruiksnotities

- Geen vergrendeling met volledige lichaamstracking.
- Bouw, kleding en wijzigingen kunnen meer aanpassing vragen.
- Speciale Base en andere systemen kunnen conflicteren; controleer Avatarinstellingen > Trackingvergrendelingen met andere gereedschappen integreren.
- Fotomodus/vloer corrigeren ook normale/eigen beweging zonder pose. Controleer blik en vervangingen in VRChat.
- Standaardwiegen uitschakelen betreft alleen standaardrust, niet iedere oorzaak.

## Handleiding en ondersteuning

Hulp / Wijzigingen bovenaan opent handleiding, hulp en geschiedenis. Gedeelde functies staan ook in Packages > Unisaki Posing System > README in Project.

- [Officiële handleiding](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Ondersteuning](https://help.unisakistudio.jp/)

Geef product/systeem, Unity, SDK, Modular Avatar, NDMF, avatar, stappen en Console-fout bij meldingen.

## Voorinstellingen verspreiden

Informatie over data uit animatieaanpassing.

Je mag gemaakte aanpassingsanimatiebestanden en daarmee ingestelde voorinstellingen
vrij verspreiden en verkopen zonder toestemming van Unisaki Studio.
Deel ze bijvoorbeeld bij eigen avatars of voor avatars buiten het pakket.

## Producten met integratie-instellingen

Onze winkel maakte deze instellingen zelfstandig. We vroegen geen toestemming, omdat we die niet nodig achtten.
Vraag verspreiding of stopzetting via winkelberichten.
De integratie vereist aankoop/download van het betreffende product.
Neem bij problemen contact op met onze winkel, niet de andere auteurs.

“可愛い座りツール”
https://yunisaki.booth.pm/items/3611536

“添い寝ツール”
https://yunisaki.booth.pm/items/3670993

“少女モーション集vol.1” van ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

“VRC想定移動モーション（無料配布）” van カトのVRC道具屋
https://booth.pm/ja/items/1285101

“ごろ寝システムEX” van minminmart
https://minminmart.booth.pm/items/4233545

## Gebruiksvoorwaarden

Alleen wie de volgende met VN3 opgestelde voorwaarden accepteert mag dit gebruiken.

[Voorwaarden (Japans)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Broncode en bronnen zijn niet open source. Rechtmatige aankoop en acceptatie zijn nodig.

[Voorwaarden (Engels)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
