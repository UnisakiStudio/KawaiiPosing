# Kawaii Posing

Positurlåsverktøy for VRChat med søte sittende og liggende positurer, også med trepunktssporing og på skrivebordet. Inneholder 85 positurer: 15 stående, 20 i huk, 17 sittende, 16 i mageleie og 17 i ryggleie.

Denne README gjelder v3.2.0 under utvikling. Endelig utgivelsesdato er ikke fastsatt. Installert versjon vises øverst i Inspector.

- [Produktside på BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Endringslogg](CHANGELOG.md)

## Visningsspråk og dokumentasjon uten nett

Velg språk med «Language / 言語» øverst i Inspector. Ett valg styrer både Inspector og den genererte VRChat-menyen. Last opp avataren på nytt for å endre språket i spillet.

Uten valg brukes datamaskinens språk, eller engelsk hvis språket ikke støttes. Windows, macOS og Linux støttes. Siste valg lagres i EditorPrefs og brukes i andre prosjekter for samme OS-bruker på denne maskinen. Avatarens lagrede uttrykkelige valg beholdes. Det synkroniseres ikke til andre maskiner. Lisenslagringen endres ikke.

Velg README, endringslogg og brukerveiledning fra medfølgende [språkliste](../index.html). Inspector-knappene for brukerveiledning og endringer følger også språket. Originale bruksvilkår og referanseoversettelser leveres separat som før.

## Hovedfunksjoner

- Fotomodus: flytt avataren opptil 3m frem og juster retningen. Bare lokalt bruker 0 bit, mens visning av posisjon/retning for andre bruker 16 bit.
- Hodevisning ved foto: hindrer at eget avatarhode nær kameraet skjules i Fotomodus.
- Gulvhøyde: flytter hele kroppen med hodet 3m opp/ned. 50% er originalhøyde og standard, 0% er 3m ned og 100% er 3m opp. Bruk atskilt fra Fothøyde som flytter fotsiden med fast hodeposisjon.
- Snu deg: snu til begge sider med hodehelling i støttede liggende positurer.
- Pust: bevegelse i blant annet brystkassen med Ingen, Svak, Middels, Sterk, Rask eller Egendefinert per kategori.
- Deaktiver VRChats hvilebevegelse: demper standardbevegelsen og beholder verktøyets pust og andre egne bevegelser.
- Reduser positurforvrengning fra hoderotasjon: demper forvrengning ved frigitt nakke når hodet peker annerledes enn originalposituren.
- Funksjonsvalg: legg til ønskede spillmenyer og se ExpressionParameters-forbruk i Inspector.
- Søk, massetillegg og sortering: søk på tvers, importer flere klipp og velg målplassering.
- Enkel Scene-forhåndsvisning: se posituren direkte via Forhåndsvisning i listen.

- Automatisk justering av armer og ben (IK): tilpasser lemmenes plassering til kroppsbygning i støttede positurer. Kan slås på/av per positur, og resultatet kan lagres i justeringsanimasjon.

### Snu deg med medfølgende positurer

Ryggpositurene Bena ut, Avslappet og Ett kne opp har sidepositurer for snuing. De bygger på «横向き寝» (liggende på siden), Lur og Kattelur, henholdsvis.

Aktiver «Funksjoner > Menyfunksjoner > Snu deg» og last opp. Velg støttet positur og Snu deg i VRChat med nakkelåsen frigitt.

Legg til støtte selv under «Positurer > Detaljer > Aktiver Snu deg», og angi animasjon i «Sidepositur for Snu deg». Vanlig MotionTime kan ikke brukes i positurer med Snu deg.

### Tilpasning til kroppsbygning

Medfølgende automatisk lemjustering kan brukes, men alle positurer trenger ikke IK. «Aktiver automatisk justering av armer og ben» styrer helheten i animasjonsjusteringen, og «Aktiver IK for denne posituren» styrer enkeltposituren.

«Lagre IK i justeringer» skriver gjeldende automatisk resultat til ny justeringsanimasjon og slår av positurens IK for videre manuelt arbeid. Krever aktiv automatisk justering globalt og for posituren, med relevante IK-innstillinger.

Avataroppsett har også «Hindre bakoverbøyning av knær» og detaljen «Minste knebøyning (grader)».

## Installasjon

1. Last ned filene fra produktsiden i butikken der du kjøpte.
2. Importer «可愛いポーズツール.unitypackage» i Unity og registrer lisens og pakkekilde.
3. Legg til Kawaii Posing og Modular Avatar i prosjektet med VCC eller ALCOM. Felles Unisaki Posing System og NDMF installeres som avhengigheter.
4. Høyreklikk avataren i Hierarchy og velg «Unisaki Studio > Legg til Kawaii Posing».
5. Velg tilføyd «可愛いポーズ» i avataren og angi funksjoner/positurer i Inspector.
6. Last opp normalt.

Krever Unity 2022.3, VRChat Avatars SDK 3.10.4 eller nyere, Modular Avatar 1.x fra 1.15.1 og NDMF 1.x fra 1.14.0. Oppdater nødvendige pakker sammen i VCC eller ALCOM.

## Oppdatering fra eldre versjoner

Oppdater produktet og Unisaki Posing System sammen. Eksisterende verktøyinnstillinger beholdes. Kontroller funksjoner og ExpressionParameters-forbruk i Inspector, og trykk «Oppdater forhåndsbygget» før ny opplasting hvis det brukes.

Fra v3.1.0 bruker nye tillegg vanlig Prefab «可愛いポーズ». Slå av unødige funksjoner for minste oppsett med bare positurvalg på 8 bit. Mange positurer kan kreve flere valgbiter.

Eldre 8bit-Prefab beholdes under «Editor/Legacy» for eksisterende avatar- og forhåndsinnstillingsreferanser. Eksisterende Prefab trenger ikke slettes eller erstattes. 8bit vises ikke i Unitys meny for nye tillegg.

## Hvor innstillingene finnes

| Fane | Muligheter |
| --- | --- |
| Funksjoner | Spillmenyer, praktiske funksjoner, pust, ikoner og ExpressionParameters-forbruk |
| Positurer | Valg, detaljer, søk, massetillegg, sortering, forhåndsvisning og animasjonsjustering |
| Avataroppsett | Avatarkorrigering, knær, originale/egne bevegelser og forhåndsinnstillinger |

«Åpne innstillinger» viser detaljer under valget. Pust konfigureres under «Funksjoner > Praktiske funksjoner > Animer pusten».

«Bruk opprinnelige stå-, huk- og mageleiepositurer» importerer originalpositurer automatisk. Egne bevegelser angis separat i importinnstillinger per type, eksempelvis stående, huk (Crouching) og mageleie (Prone).

Forhåndsinnstillinger finnes nederst i Avataroppsett. «Bruk denne forhåndsinnstillingen» erstatter nåværende oppsett, så lagre egne justeringer før bytte.

### Forbruk per funksjon

- Pustebevegelse bruker 0 bit. Bare «Menyfunksjoner > Pust» for stopp/start i spillet bruker 1 bit til på/av-synkronisering.
- Fotomodus bruker 0 bit bare lokalt. «Praktiske funksjoner > Synkroniser Fotomodus» bruker 16 bit. «Behold hodet synlig i Fotomodus» bruker 0 bit.
- Fothøyde og Gulvhøyde bruker hver 8 bit. Gulvhøyde flytter opp/ned fra midten, og korrigeringen slutter nær 50%.
- Snu deg bruker 10 bit alene og deler 1 bit med Reduser positurforvrengning fra hoderotasjon, så begge bruker 10 bit totalt.
- Speilvend og Gester av bruker hver 1 bit.

Inspector-summen omfatter avatarens positurverktøy, ikke klær eller andre systemer. Felles innstillinger telles ikke dobbelt ved flere verktøy.

### Forhåndsvisning og positurredigering

Forhåndsvisning på hver positur viser den i Scene. Åpne Animasjonsjustering for å gjennomgå, finjustere og lagre.

Enkel forhåndsvisning kjører ikke MA- eller NDMF-bygg. Kontroller også klær og gulvkorrigering som innarbeides ved bygg i sluttresultatet før opplasting.

Søk etter navn med forstørrelsesglassfanen til venstre. Velg mål under «Detaljer > Rekkefølge» eller bruk opp/ned. Legg til flere animasjoner ved å dra til feltet eller bruke «Importer klipp valgt i Project».

«Oppdater positurminiatyrer» genererer bilder etter bekreftelse. «Generer positurikoner» gjør positurer lettere å kjenne i spillmenyen, men øker byggetid. Velg «Reduser ikonstørrelsen» for mindre størrelse. Android får ingen genererte positurikoner.

## Grunnleggende spillkontroller

- Velg positur per kategori i Expressions-menyen. I VR byttes stående, huk, sittende og liggende etter hodehøyde.
- I liggende byttes rygg/mage etter ansiktsretning. Med begge valgt kan hopp på stedet også bytte. Slå det av i Unity under «Funksjoner → Praktiske funksjoner → Bytt liggende positur ved å hoppe» (på som standard). Kategoriers høydeterskler justeres i innstillingsmenyen.
- På skrivebordet brukes C og Z. Øk liggehøydeterskelen i innstillinger hvis Z ikke gir liggende.
- Gester av bruker positurens håndform i stedet for kontrollerstyrte fingre.
- Fothøyde justerer fotsiden med fast hodeposisjon. Gulvhøyde flytter hele kroppen inkludert hodet. De står i denne rekkefølgen i innstillinger.
- Avstand i Fotomodus flytter frem og vender avataren mot deg. Roter med Retning og bruk Lås føtter ved behov. Avslutt foto nullstiller avstand/retning og frigir føttene.
- Pust virker med aktiv pustebevegelse. Styrken velges i Unity og på/av i spillet.

## Forhåndsbygg og advarsler

«Oppdater forhåndsbygget» gjenbruker genererte data for raskere avatarbygg. Vanlig bygg genererer også nødvendige data uten forhåndsbygg.

Endringer gir oppdateringsbehov under Kontroller innstillinger øverst i Inspector og med Hierarchy-merker. Innstillinger for advarselsvisning finnes i samme felt. Skjulte advarsler løser ikke problemer eller oppdaterer genererte data.

## Merknader om bruk

- Positurlås med helkroppssporing støttes ikke.
- Kroppsbygning, klær og avatarendringer kan kreve ekstra tilpasning.
- Spesielle Base-lag og andre positursystemer kan gi uventet samordning. Kontroller «Avataroppsett > Samordne sporingslåser med andre verktøy» ved låseproblemer.
- Fotomodus-bevegelse/rotasjon og Gulvhøyde korrigerer også standard-/egne bevegelser uten valgt positur. Kontroller synspunkt og erstattede standardbevegelser i selve VRChat-klienten.
- Deaktiver VRChats hvilebevegelse påvirker standard hvileanimasjon, ikke alle andre årsaker til svai.

## Veiledning og støtte

«Hjelp / Endringer» øverst i Inspector åpner veiledning, kontakt og endringslogg. Fellesfunksjoner beskrives også under «Packages > Unisaki Posing System > README» i Unitys Project.

- [Offisiell veiledning](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Kontakt](https://help.unisakistudio.jp/)

Ved feilrapportering: oppgi produkt-/Unisaki Posing System-versjoner, Unity/VRChat SDK/Modular Avatar/NDMF-versjoner, avatar, trinn for gjenskaping og Console-feil.

## Distribusjon av forhåndsinnstillinger

Dette gjelder data opprettet med animasjonsjustering.

Justeringsanimasjoner opprettet med funksjonen og forhåndsinnstillinger opprettet med disse tilordnet kan distribueres og selges fritt uten tillatelse fra Unisaki Studio. Del gjerne med egne avatarer eller som forhåndsinnstillinger for avatarer som ikke følger med verktøyet.

## Produkter med medfølgende samordning

※ Butikken har laget samordningsinnstillingene selvstendig. Vi har ikke innhentet tillatelse fra produktforfatterne siden vi vurderer at det ikke kreves. Kontakt butikken via melding om ønsket distribusjon eller stans av samordningsinnstillinger. Kjøp/nedlasting av samordnet produkt kreves. Ved innstillingsproblemer kontaktes vår butikk, ikke andre produkters forfattere.

«可愛い座りツール»
https://yunisaki.booth.pm/items/3611536

«添い寝ツール»
https://yunisaki.booth.pm/items/3670993

«少女モーション集vol.1» av ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

«VRC想定移動モーション（無料配布）» av カトのVRC道具屋
https://booth.pm/ja/items/1285101

«ごろ寝システムEX» av minminmart
https://minminmart.booth.pm/items/4233545

## Bruksvilkår

Verktøyet kan bare brukes av dem som godkjenner følgende vilkår laget med VN3-lisensen.

[Bruksvilkår (japansk)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Kildekode og ressurser er ikke åpen kildekode. Gyldig produktkjøp og godkjente bruksvilkår kreves.

[Bruksvilkår (engelsk)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
