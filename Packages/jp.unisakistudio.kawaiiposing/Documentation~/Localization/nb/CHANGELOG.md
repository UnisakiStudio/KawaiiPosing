# Endringslogg

## [3.2.0] - Ikke utgitt

### Lagt til

- Inspector, redigering, installasjonsdialoger, standardpositurnavn og genererte VRChat-menyer kan vises på 30 språk.
- Felles språkvalg for Inspector og spillmeny. Maskinens språk brukes først, og siste valg gjenbrukes i andre prosjekter for samme OS-bruker.
- README, endringslogg og offlineveiledning kan åpnes på valgt språk.
- Visningsnavn for 128 standardpositurer og funksjonsbeskrivelser følger eksisterende terminologi.

### Kompatibilitet

- Eksisterende avatarinnstillinger, egne navn, assetreferanser, parameteridentifikatorer og lisenslagring beholdes.

## [3.1.2] - 2026-11-09

- Hodelås kan endres i EX-menyens «Innstillinger → Automatisk hodelås i ryggleie» selv med Fothøyde av. Valg som forsvant tidligere kommer tilbake ved bygg etter oppdatering.
- Støtte for Unisaki Posing System 3.1.2. Rettet vedvarende oppovervendt ansikt etter oppreisning fra mageleie med Reduser positurforvrengning fra hoderotasjon.

Oppdater Kawaii Posing til 3.1.2 i ALCOM / VCC. Unisaki Posing System 3.1.2 kreves også. Brukte du forhåndsbygg, trykker du Oppdater forhåndsbygget, lagrer scenen og bygger/laster opp på nytt.

## [3.1.1] - 2026-11-08

- Aktive Gulvhøyde og Snu deg vises i Innstillinger i VRChats EX-meny selv med Speilvend av.
- Riktig snuing for Bena ut, Avslappet og Ett kne opp beholdes etter eldre omordning, sletting og navneendring, også etter full Unpack hvis opphavet kan finnes. Egne positurer, uttrykkelig deaktivert snuing og erstattede sidebevegelser beholdes.
- Rettet kort mageleie ved avatarvalg og kort ryggleie ved hopp med bare magepositurer valgt. Hoppbytte deaktiveres under «Funksjoner → Praktiske funksjoner → Bytt liggende positur ved å hoppe» og er på som standard.
- Tapt gjenopprettbar felles positur-Animator Controller-referanse gir advarsel og gjenoppbygging fra innstillinger. Referanser delt av avatarer beholdes.
- Tilleggsmenyen plasserer offisielt Prefab selv om eget Prefab med samme navn «可愛いポーズ» finnes.
- Ved tillegg av 添い寝ツール angis nødvendig produkt som må installeres først hvis det mangler.

Oppdater både Kawaii Posing og Unisaki Posing System til 3.1.1 i ALCOM / VCC. Brukte du forhåndsbygg, trykker du Oppdater forhåndsbygget på sceneobjektet «可愛いポーズ» og lagrer. Bygg og last opp på nytt for å bruke i VRChat.

## [3.1.0] - 2026-11-07

- 53 av 85 positurer tilpasser lemmer automatisk med IK etter kroppsbygning.
- Ryggpositurene Bena ut, Avslappet og Ett kne opp støtter Snu deg med hodehelling.
- Fotomodus justerer posisjon/retning med valgfri synkronisering og synlig eget hode.
- Gulvhøyde flytter hele kroppen 3m opp/ned, atskilt fra Fothøyde.
- Lagt til pust, stopp av hvilebevegelse og redusert forvrengning fra hoderotasjon.
- Inspector viser funksjoner og parameterforbruk. Søk, massetillegg, sortering og Scene-forhåndsvisning støttes.
- Raskere stå-/huk-/sittebytte på skrivebordet.
- Bedre forhåndsbyggadvarsler, Inspector-rulling og lange oppryddingsstopp.
- Støtte for Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Åpen beta (2026-11-05)

- Åpen beta via GitHub Releases og VPM. 53 av 85 positurer tilpasser lemmer med IK etter kroppsbygning.
- Støtte for fellesspakke 3.1.0-beta.2 med bedre endringsvisning etter forhåndsbygg, Inspector-rulling og oppryddingsstopp.

## [3.1.0-beta.1] - Åpen beta (2026-11-04)

- Støtte for Unisaki Posing System 3.1.0-beta.1.
- Vanlig skrivebordsbytte bruker én evaluering i vanlige bygg og forhåndsbygg; VR og spesielle forhold beholder tidligere vei.
- Forhåndsbygg fra alpha.3 eller før krever oppdatering.
- Synspunkt beholdes ved gulvhøydeendring i Fotomodus, og siste gulvhøyde gjenopprettes etter avslutning.
- Inkluderer forbedringer gjennom alpha.3 for automatisk import, justering av importerte bevegelser og genererte Controllers.

## [3.1.0-alpha.2] - Lukket test (2026-10-26)

### Rettelser og endringer

- Felles positursystem oppdatert til 3.1.0-alpha.2 med feilrettinger.
- Gulvhøyde utvidet til 3m opp/ned, med 50% som originalhøyde og standard.
- Standard-/egne bevegelser uten valgt positur korrigeres også av Fotomodus og Gulvhøyde.
- Rettet manuell korrigering, like navn, startpositurer og eldre forhåndsinnstillingers innstillinger for snuing.

## [3.1.0-alpha.1] - Før offentlig utgivelse

### Lagt til

- Lagt til automatisk lemjustering (IK) etter kroppsbygning.
- Lagt til IK på/av globalt og per positur, og lagring i justeringsanimasjon.
- Ryggpositurene Bena ut, Avslappet og Ett kne opp støtter Snu deg med hodehelling.
- Lagt til innstillinger for snuing og sideanimasjon per positur.
- Lagt til Fotomodus med fremflytting og rotasjon.
- Fotomodus-synkronisering: bare lokalt 0 bit, synkronisert 16 bit.
- Lagt til valg om å beholde eget hode synlig i Fotomodus.
- Lagt til Gulvhøyde for å heve hele kroppen inkludert hodet.
- Lagt til pustebevegelse, styrke og på/av-meny i spillet.
- Lagt til stopp av VRChats hvilebevegelse.
- Lagt til redusert forvrengning fra hoderotasjon.
- Lagt til vern mot bakoverbøyde knær og minste bøyevinkel.
- Lagt til på/av per funksjon og ExpressionParameters-forbruk.
- Lagt til Scene-forhåndsvisning, søk, massetillegg og målplassering ved sortering.
- Lagt til endringslogg i Inspector.

### Endret

- Inspector delt i Funksjoner, Positurer og Avataroppsett.
- Pustedetaljer, import av egne bevegelser og forhåndsinnstillinger omorganisert.
- Færre dupliserte animasjoner for Fothøyde.
- Bekreftelse ved positurbildeoppdatering og advarselsvalg samlet i Kontroller innstillinger.
- Meny for nytt 8bit-tillegg avviklet til fordel for vanlig Prefab med funksjonsvalg; eksisterende referanser beholdes.
- Støtte for Unisaki Posing System 3.1.0-alpha.1. Minste VRChat Avatars SDK-versjon er 3.10.4.

### Rettet

- Rettet navneinput som flyttet til annen positur, og detaljer som lukket ved sortering.
- Rettet overlappende forhåndsvisning, feil plassering og feil på enkelte avatarer.
- Rettet oppdatering av advarsler/forhåndsbyggstatus etter endringer og enkelte byggfeil.

## [3.0.13] - 2026-09-22
- Oppdatert til PosingSystem 3.0.17 og rettet vannrett positurforskyvning ved jevn skalering av hele avataren.
- Lagt til individuell eller samlet ignorering av advarsler om automatisk tråkking, manglende forhåndsbygg og endrede innstillinger.
- Rettet import av uegnede engangsanimasjoner ved manuell import av forflytningsbevegelser.

## [3.0.12] - 2026-09-15
- Lagt til avatarforhåndsinnstilling (ルリエ).

## [3.0.11] - 2026-09-09
- Lagt til avatarforhåndsinnstillinger (メルヴィ, ミダリス).
- Rettet bevegelseserstatning i うらら-forhåndsinnstillingen.

## [3.0.10] - 2026-08-31
- Oppdatert til PosingSystem 3.0.11 og rettet forhåndsbyggfeil med siste NDMF og unntak ved feilvisning.

## [3.0.9] - 2026-08-29
- Oppdatert til PosingSystem 3.0.10 med lavere belastning ved forhåndsinnstillingslasting og Hierarchy-ikonvurdering.
- Rettet forhåndsbyggfeil med flere positursystemer på samme avatar.

## [3.0.8] - 2026-08-26
- Oppdatert til PosingSystem 3.0.9 og rettet `Avatar is null` i Play etter ugyldig forhåndsvisnings-Avatar fra NDMF-behandling.

## [3.0.7] - 2026-08-18
- Oppdatert til PosingSystem 3.0.8 og rettet fare for ugyldige positurdata ved gjentatt høydekorrigering.

## [3.0.6] - 2026-08-12
- Lagt til avatarforhåndsinnstillinger (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Lagt til avatarforhåndsinnstillinger (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Lagt til avatarforhåndsinnstillinger (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Bedre lisensinstallasjon og -sletting.

## [3.0.2] - 2026-01-04
- Rettet lisensbehandling på Mac og Linux.

## [3.0.1] - 2025-12-28
- Lagt til avatarforhåndsinnstillinger (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Lagt til forhåndsbygg.
- Lagt til animasjonsjustering.
- Lagt til forhåndsinnstillinger.
- Prosjektinstallasjon med unitypackage.
- Lagt til avatarforhåndsinnstillinger (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Løst kompatibilitetsproblemer med enkelte verktøy.

## [2.2.4] - 2025-04-04
- Rettet manglende positurbytte med enkelte avatarer og ModularAvatar-versjoner.

## [2.2.3] - 2025-03-13
- Rettet feil bevegelser på enkelte avatarer, for eksempel hopp med 森羅.
- Rettet iblant feil standardverdi for Gester av.

## [2.2.2] - 2025-03-06
- Rettet feil i enkelte miljøer.

## [2.2.1] - 2025-02-05
- Rettet Unity-krasj.
- Versjon lagt til i verktøynavnet i NDMF Console.

## [2.2.0] - 2025-02-02
- Lagt til Gester av for animasjonens håndform.
- Håndformsdata for alle positurer.

## [2.1.6] - 2025-02-02
- Rettet ødelagte positurer med enkelte andre verktøy.
- Rettet innstillingsavhengige feil.

## [2.1.5] - 2024-12-10
- Løst enkelte verktøykonflikter.
- Lagt til knapp for fjerning av Unitypackage-versjon.
- Samordnings-Prefabs for 三点だいしゅきツール fjernet siden VCC-versjonen ble utgitt.

## [2.1.4] - 2024-12-08
- Rettet feil på enkelte avatarer.
- Rettet ubrukelig fotlås ved verktøy-/avatarkonflikter.
- Rettet retur til VRC-standardpositur på skrivebordet.

## [2.1.3] - 2024-12-01
- Rettet manglende positurbytte med avatarer/verktøy som bruker feil VRMode-type.
- Lagt til visning i NDMF-Console av verktøykonflikter fra ulike parametertyper.

## [2.1.2] - 2024-12-01
- Lagt til NDMF-Console-forklaring når andre verktøys feil fører til Unisaki Posing System-feil under bygg.
- Rettet byggfeil på enkelte avatarer.
- Bedre oppførsel straks etter avatarlasting.
- Opprinnelig avatarforflytning fjernes fordi den kan hindre funksjon på enkelte avatarer.

## [2.1.1] - 2024-11-20
- Rettet manglende byggmulighet.

## [2.1.0] - 2024-11-20
- Løst føtter/hofter under bakken på skrivebordet, slik at alle positurer vises riktig.
- Lagt til positurbytte uavhengig av hodehøyde.
- Lagt til modus uten ikongenerering for Quest-opplasting.
- Lagt til advarsler om avatarproblemer.
- Løst låsekonflikter med AFK og andre verktøys armlås.
- Lagt til automatisk nakkelås i ryggleie.
- Endret ExpressionsMenu: positurvalg i egen mappe og låser øverst.

## [2.0.0] - 2024-11-14
### Rettet
- VPM-pakke for VCC-støtte.
- Rettet 8bit-versjon som brukte 17bit.

## [1.15.0] - 2024-11-04
### Rettet
- Rettet feil og funksjonsproblemer.

## [1.14.0] - 2024-07-05
### Rettet
- Rettet feil med VRCFury.

## [1.13.0] - 2024-04-11
### Rettet
- Lagt til samordning med «ごろ寝システムEX».

## [1.12.0] - 2024-03-31
### Rettet
- Rettet ubrukelig verktøy i enkelte ExMenu-tilstander.
- Speiling lagt til i innstillinger.
- Rettet kattepositur.
- Lagt til 5 sideliggende positurer.

## [1.11.0] - 2024-03-12
### Rettet
- Rettet forvrengte positurer ved høyt hode.

## [1.10.0] - 2024-03-10
### Rettet
- Lagt til ståfunksjon med 15 positurer.
- Rettet føtter som beveget seg selv på enkelte avatarer og i enkelte miljøer.
- Lagt til ExpressionParameters8bit-versjon.

## [1.9.0] - 2024-03-05
### Rettet
- Rettet føtter som beveget seg selv på enkelte avatarer.
- Ensartede WriteDefaults.
- Lagt til 7 huk- og 8 sittepositurer.

## [1.8.0] - 2024-02-25
### Rettet
- Rettet opplastingsfeil med ModularAvatar1.9.0 eller nyere.
- ModualrAvatar1.9.0 eller nyere kreves nå.

## [1.7.0] - 2024-02-23
### Rettet
- Lagt til endring av hodehøydeterskler per positur.
- Rettet gale positurer/føtter ved blant annet hopp på enkelte avatarer.
- ExpressionParameter-forbruk redusert fra 54 til 16bit.

## [1.6.0] - 2024-02-20
### Rettet
- Rettet manglende sittepositur i VR.

## [1.5.0] - 2024-02-18
### Rettet
- Sittepositur er mulig mens C holdes nede på skrivebordet.

## [1.4.0] - 2024-02-17
### Rettet
- Rettet 添い寝-samordning som krevde 三点だいしゅき-samordning.
- Rettet fastlåste føtter ved hopp.

## [1.3.0] - 2024-02-16
### Rettet
- Rettet unormalt mange VRCContactSender/Receiver.

## [1.2.0] - 2024-02-16
### Rettet
- Rettet byggfeil ved opplasting.

## [1.1.0] - 2024-02-15
### Rettet
- Rettet gale standardverdier med flere Prefabs.
- Rettet innstillinger for 可愛い座り-samordning.

## [1.0.0] - 2024-02-14
### Utgivelse
