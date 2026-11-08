# Cronologia delle modifiche

## [3.2.0] - Non pubblicata

### Aggiunte

- Inspector, comandi di modifica, finestre d’installazione, nomi delle pose standard e menu VRChat generati disponibili in 30 lingue.
- Scelta della lingua unificata per Inspector e menu nel gioco. Inizialmente viene usata la lingua del computer; l’ultima scelta è riutilizzata negli altri progetti dello stesso utente del sistema.
- Apertura di README, cronologia e guida offline nella lingua scelta.
- Preparati i nomi visualizzati delle 128 pose standard e le descrizioni di tutte le funzioni, mantenendo la terminologia esistente.

### Compatibilità

- Conservati impostazioni esistenti dell’avatar, nomi personalizzati, riferimenti agli asset, identificatori dei parametri e archiviazione della licenza.

## [3.1.2] - 2026-11-09

- Il blocco della testa è modificabile in «Impostazioni → Blocco automatico della testa da supini» nel menu EX anche con «Altezza piedi» disattivato. Gli avatar che avevano perso la voce nelle versioni precedenti la recuperano dopo aggiornamento e nuova build.
- Compatibilità con Unisaki Posing System 3.1.2. Corretto il viso rimasto verso l’alto dopo essersi alzati da proni con «Ridurre le deformazioni dovute alla rotazione della testa» attivo.

In ALCOM / VCC aggiorna Kawaii Posing a 3.1.2. Serve anche Unisaki Posing System 3.1.2. Se usavi il precalcolo, premi «Aggiorna precalcolo», salva la scena e ricrea e ricarica l’avatar.

## [3.1.1] - 2026-11-08

- «Altezza suolo» e «Girarsi», se attivi, compaiono in «Impostazioni» del menu EX di VRChat anche con «Specchio» disattivato.
- Conservati i corretti rotolamenti per «Gambe distese», «Relax» e «Un ginocchio alzato» dopo riordino, eliminazione o rinomina nelle vecchie versioni. Funziona anche dopo Unpack completo se la posa originale resta identificabile. Conservati pose personali, rotolamenti disattivati esplicitamente e movimenti laterali sostituiti.
- Corretto il breve passaggio alla posa prona selezionando l’avatar in VRChat e quello alla supina saltando con sole pose prone selezionate. Il cambio con salto si disattiva in «Funzioni → Funzioni pratiche → Cambiare posa sdraiata saltando» ed è attivo inizialmente.
- Se viene perso il riferimento all’Animator Controller comune e può essere recuperato, un avviso lo segnala e il Controller viene ricreato dalle impostazioni. Conservati i riferimenti condivisi da più avatar.
- Il menu di aggiunta inserisce il Prefab ufficiale anche se hai salvato un altro Prefab con lo stesso nome 「可愛いポーズ」.
- Aggiungendo 添い寝ツール senza il prodotto necessario all’integrazione, viene indicato cosa installare prima.

In ALCOM / VCC aggiorna Kawaii Posing e Unisaki Posing System entrambi a 3.1.1. Se usavi il precalcolo, premi «Aggiorna precalcolo» su 「可愛いポーズ」 nella scena e salvala. Ricrea e ricarica l’avatar per applicare le modifiche in VRChat.

## [3.1.0] - 2026-11-07

- Regolazione IK automatica degli arti secondo la corporatura in 53 delle 85 pose incluse.
- «Gambe distese», «Relax» e «Un ginocchio alzato» supine compatibili con Girarsi inclinando la testa.
- Posizione e direzione dell’avatar regolabili in Modalità foto, con sincronizzazione e visibilità della testa opzionali.
- «Altezza suolo» muove tutto il corpo fino a 3m sopra o sotto, separatamente da «Altezza piedi».
- Aggiunti respiro, disattivazione dell’oscillazione standard e riduzione delle deformazioni dovute alla direzione del collo.
- Funzioni e consumo dei parametri visibili nell’Inspector, con ricerca, aggiunta in gruppo, riordino e anteprima semplice delle pose nella Scene.
- Cambi di postura desktop in piedi, accovacciato e seduto accelerati.
- Migliorati avvisi di precalcolo dopo modifiche, scorrimento dell’Inspector e lunghe pause della pulizia dei dati generati.
- Compatibilità con Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Beta aperta (2026-11-05)

- Avviata la beta aperta su GitHub Releases e VPM. Regolazione IK automatica secondo la corporatura in 53 delle 85 pose incluse.
- Compatibilità con il pacchetto comune 3.1.0-beta.2. Migliorati segnalazione delle modifiche dopo precalcolo, scorrimento dell’Inspector e blocchi durante la pulizia dei dati generati.

## [3.1.0-beta.1] - Beta aperta (2026-11-04)

- Compatibilità con Unisaki Posing System 3.1.0-beta.1.
- Cambio postura ordinario desktop passato a una sola valutazione per build normali e precalcolo; VR e casi particolari conservano il percorso precedente.
- Precalcoli alpha.3 e precedenti riconosciuti come da aggiornare.
- Vista mantenuta modificando l’altezza del suolo nelle foto, con ritorno all’ultima altezza alla fine.
- Incluse le migliorie fino ad alpha.3 per importazione automatica, regolazione dei movimenti importati e gestione dei Controller generati.

## [3.1.0-alpha.2] - Test chiuso (2026-10-26)

### Correzioni e modifiche

- Sistema comune aggiornato a 3.1.0-alpha.2 con le correzioni di debug.
- Altezza suolo estesa a 3m sopra e sotto; 50% è altezza originale e iniziale.
- Correzioni foto e altezza suolo applicate anche ai movimenti standard e personali senza posa selezionata.
- Corretti problemi di regolazioni manuali, pose omonime, posa iniziale e impostazioni di Girarsi dei vecchi preset.

## [3.1.0-alpha.1] - Prima della pubblicazione

### Aggiunte

- Aggiunta regolazione automatica degli arti (IK) secondo la corporatura.
- Aggiunte attivazione globale o per posa e integrazione IK nelle animazioni di regolazione.
- «Gambe distese», «Relax» e «Un ginocchio alzato» supine compatibili con Girarsi inclinando la testa.
- Aggiunte impostazioni di Girarsi per posa e scelta dell’animazione laterale.
- Aggiunta Modalità foto con movimento in avanti e rotazione.
- Aggiunta sincronizzazione foto opzionale: 0 bit solo locale, 16 bit sincronizzati.
- Aggiunta l’opzione per mantenere visibile la propria testa nelle foto.
- Aggiunta «Altezza suolo» per alzare tutto il corpo, testa inclusa.
- Aggiunti movimento e intensità del respiro e menu di attivazione nel gioco.
- Aggiunta disattivazione dell’oscillazione standard VRChat.
- Aggiunta riduzione delle deformazioni dovute alla diversa direzione del collo.
- Aggiunte prevenzione della piegatura inversa delle ginocchia e flessione minima.
- Aggiunti attivazione per funzione e consumo di ExpressionParameters.
- Aggiunti anteprima semplice nella Scene, ricerca, aggiunta in gruppo e destinazione nell’ordine delle pose.
- Aggiunta la cronologia nell’Inspector.

### Modifiche

- Inspector organizzato in 3 schede: «Funzioni», «Pose» e «Configurazione avatar».
- Riordinate le posizioni dei dettagli del respiro, dell’importazione personale e dei preset.
- Ridotti i duplicati di animazioni generati per Altezza piedi.
- Aggiunta conferma all’aggiornamento delle immagini e raccolte le preferenze degli avvisi in «Controlla impostazioni».
- Eliminato il menu per nuovi Prefab 8bit in favore delle opzioni del Prefab normale, conservando i riferimenti esistenti.
- Compatibilità con Unisaki Posing System 3.1.0-alpha.1 e versione minima di VRChat Avatars SDK portata a 3.10.4.

### Correzioni

- Corretti la modifica del nome trasferita a un’altra posa e i dettagli che si chiudevano riordinando.
- Corretti anteprime sovrapposte, posizioni di inserimento errate ed errori con alcuni avatar.
- Corretti aggiornamento di avvisi e stato del precalcolo dopo modifiche e alcuni errori di build.

## [3.0.13] - 2026-09-22
- Aggiornato a PosingSystem 3.0.17, correggendo scostamenti orizzontali delle pose dopo una variazione uniforme della scala dell’avatar intero.
- Aggiunta la possibilità di ignorare separatamente o insieme gli avvisi di passi automatici, precalcolo mancante e impostazioni modificate.
- Corretta l’importazione di animazioni singole inadatte durante l’importazione manuale di movimenti di spostamento.

## [3.0.12] - 2026-09-15
- Aggiunto un preset avatar (ルリエ).

## [3.0.11] - 2026-09-09
- Aggiunti preset avatar (メルヴィ, ミダリス).
- Corretta la sostituzione dei movimenti del preset うらら.

## [3.0.10] - 2026-08-31
- Aggiornato a PosingSystem 3.0.11 per correggere il precalcolo con la nuova versione NDMF e le eccezioni nella visualizzazione degli errori.

## [3.0.9] - 2026-08-29
- Aggiornato a PosingSystem 3.0.10 per ridurre il carico del caricamento preset e delle icone Hierarchy.
- Corretti errori di precalcolo con più sistemi di pose nello stesso avatar.

## [3.0.8] - 2026-08-26
- Aggiornato a PosingSystem 3.0.9, correggendo l’Avatar di anteprima invalidato dopo NDMF che causava `Avatar is null` in Play.

## [3.0.7] - 2026-08-18
- Aggiornato a PosingSystem 3.0.8 per correggere il rischio di dati di posa non validi durante una nuova correzione di altezza.

## [3.0.6] - 2026-08-12
- Aggiunti preset avatar (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Aggiunti preset avatar (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Aggiunti preset avatar (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Migliorate installazione e rimozione delle licenze.

## [3.0.2] - 2026-01-04
- Corretto il trattamento delle licenze su Mac e Linux.

## [3.0.1] - 2025-12-28
- Aggiunti preset avatar (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Aggiunto il precalcolo.
- Aggiunta regolazione animazione.
- Aggiunti preset.
- Aggiunta al progetto tramite unitypackage.
- Aggiunti preset avatar (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Risolti problemi di compatibilità con alcuni sistemi.

## [2.2.4] - 2025-04-04
- Corretto il blocco del cambio posa con alcuni avatar e versioni di ModularAvatar.

## [2.2.3] - 2025-03-13
- Corretti movimenti anomali di alcuni avatar, come il salto di 森羅.
- Corretti valori iniziali talvolta errati di Blocca gesti.

## [2.2.2] - 2025-03-06
- Corretti errori in alcuni ambienti.

## [2.2.1] - 2025-02-05
- Corretto un crash di Unity.
- Versione aggiunta al nome dello strumento in NDMF Console.

## [2.2.0] - 2025-02-02
- Aggiunto Blocca gesti per usare le mani dell’animazione.
- Aggiunti dati delle mani a tutte le pose.

## [2.1.6] - 2025-02-02
- Corrette pose deformate con alcuni altri strumenti.
- Corretti errori dipendenti dalle impostazioni.

## [2.1.5] - 2024-12-10
- Risolti conflitti con alcuni sistemi.
- Aggiunto un pulsante per eliminare la versione Unitypackage.
- Rimossi i Prefabs d’integrazione di 三点だいしゅきツール dopo la pubblicazione della versione VCC.

## [2.1.4] - 2024-12-08
- Corretti errori su alcuni avatar.
- Corretto il blocco piedi inutilizzabile per conflitti con sistemi o avatar.
- Corrette le pose che tornavano a quelle standard VRC in desktop.

## [2.1.3] - 2024-12-01
- Corretto il mancato cambio posa con avatar o sistemi che usano VRMode con un tipo errato.
- Aggiunta la segnalazione in NDMF-Console dei conflitti tra sistemi causati da tipi di parametri diversi.

## [2.1.2] - 2024-12-01
- Aggiunta una spiegazione in NDMF-Console quando errori di altri strumenti causano errori di Unisaki Posing System durante la build dell’avatar.
- Corretti errori di build su alcuni avatar.
- Migliorato il comportamento subito dopo il caricamento dell’avatar.
- Eliminata l’elaborazione originale dello spostamento dell’avatar, che impediva il funzionamento su alcuni avatar.

## [2.1.1] - 2024-11-20
- Corretto un problema che impediva la build.

## [2.1.0] - 2024-11-20
- Risolti piedi e bacino sotto il terreno in desktop per ottenere pose corrette.
- Aggiunto cambio posa indipendente dall’altezza della testa.
- Aggiunta modalità senza icone per avatar Quest.
- Aggiunti avvisi per problemi dell’avatar.
- Risolti conflitti con AFK e blocchi braccia di altri strumenti.
- Aggiunto blocco automatico del collo da supini.
- ExpressionsMenu riorganizzato: selezione pose in cartella separata e blocchi al livello principale.

## [2.0.0] - 2024-11-14
### Correzioni
- Convertito in pacchetto VPM per supportare VCC.
- Corretta la versione 8bit che consumava 17bit.

## [1.15.0] - 2024-11-04
### Correzioni
- Corretti errori e problemi.

## [1.14.0] - 2024-07-05
### Correzioni
- Corretti problemi con VRCFury.

## [1.13.0] - 2024-04-11
### Correzioni
- Aggiunte impostazioni d’integrazione con ごろ寝システムEX.

## [1.12.0] - 2024-03-31
### Correzioni
- Corretto lo strumento inutilizzabile in alcuni stati di ExMenu.
- Aggiunta la funzione specchio alle impostazioni.
- Corretta la posa del gatto.
- Aggiunte ５ pose sdraiate sul fianco.

## [1.11.0] - 2024-03-12
### Correzioni
- Corrette pose errate quando la testa è alta.

## [1.10.0] - 2024-03-10
### Correzioni
- Aggiunte le pose in piedi con 15 varianti.
- Corretti piedi che si muovevano da soli con alcuni avatar e ambienti.
- Aggiunta la versione ExpressionParameters8bit.

## [1.9.0] - 2024-03-05
### Correzioni
- Corretti piedi che si muovevano da soli su alcuni avatar.
- WriteDefaults uniformati.
- Aggiunte ７ pose accovacciate e ８ sedute.

## [1.8.0] - 2024-02-25
### Correzioni
- Corretto il mancato caricamento con ModularAvatar1.9.0 o successivo.
- Ora è richiesto ModualrAvatar1.9.0 o successivo.

## [1.7.0] - 2024-02-23
### Correzioni
- Aggiunta la modifica delle soglie di altezza della testa per ogni postura.
- Corrette pose e piedi anomali su alcuni avatar, per esempio durante i salti.
- Bit ExpressionParameter ridotti da 54 a 16bit.

## [1.6.0] - 2024-02-20
### Correzioni
- Corretta l’impossibilità di assumere pose sedute in VR.

## [1.5.0] - 2024-02-18
### Correzioni
- In desktop le pose sedute sono disponibili anche mantenendo premuto C.

## [1.4.0] - 2024-02-17
### Correzioni
- Corretta l’integrazione 添い寝 inutilizzabile senza quella 三点だいしゅき.
- Corretti i piedi bloccati dopo un salto.

## [1.3.0] - 2024-02-16
### Correzioni
- Corretto il numero anomalo di VRCContactSender/Receiver configurati.

## [1.2.0] - 2024-02-16
### Correzioni
- Corretto un errore di build durante il caricamento.

## [1.1.0] - 2024-02-15
### Correzioni
- Corretti valori predefiniti errati con più Prefabs.
- Corrette le impostazioni d’integrazione 可愛い座り.

## [1.0.0] - 2024-02-14
### Pubblicazione
