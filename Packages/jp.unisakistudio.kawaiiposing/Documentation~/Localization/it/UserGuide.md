# Kawaii Posing — Guida utente in italiano

Kawaii Posing offre 85 pose per desktop e VR a tre punti: 15 in piedi, 20 accovacciate o su sedia, 17 sedute a terra, 17 supine e 16 prone.

Questa guida descrive installazione, configurazione avatar, comandi VRChat, modifica delle pose, aggiornamenti e risoluzione dei problemi. Il ZIP acquistato contiene `START_HERE.html` per arrivare più rapidamente all’installazione.

## Prima di iniziare

- Usa un progetto **avatar** VRChat con Unity 2022.3, creato o gestito con VRChat Creator Companion (VCC) o ALCOM.
- Pacchetti richiesti: VRChat Avatars SDK 3.10.4 o successivo; Modular Avatar 1.x dalla versione 1.15.1; NDMF 1.x dalla versione 1.14.0.
- Lo strumento è per avatar Humanoid in desktop e VR a tre punti (visore e due controller). Il blocco delle pose con tracciamento completo del corpo attivo non è supportato.
- Fai un backup dei progetti esistenti prima di installare o aggiornare. Risolvi prima gli errori di compilazione Unity.
- L’installatore scarica prodotto e dipendenze dai repository. Serve una connessione Internet. Modelli avatar, VRChat SDK, Modular Avatar e NDMF non sono inclusi nel ZIP.

## 1. Installare licenza e prodotto

1. Estrai l’intero ZIP in una cartella normale fuori dal progetto Unity.
2. Apri il progetto avatar desiderato in Unity. Importa `Installer/KawaiiPosing_Installer.unitypackage` con **Assets > Import Package > Custom Package**, oppure apri il file con Unity.
3. Leggi le richieste d’importazione e installazione. La conferma della licenza spiega quali licenze verranno installate. Usa **Lingua…** (o **言語...**) in una conferma per cambiare lingua all’installatore.
4. Conferma l’installazione della licenza. Copre anche Unisaki Posing System usato da questo prodotto. L’installatore può poi proporre di rimuovere i propri file: la pulizia non rimuove la licenza installata.
5. Controlla la conferma dell’installatore automatico dei pacchetti. Elenca pacchetti e repository da aggiungere ed eventuali vecchi file o cartelle da eliminare. Continua se corrispondono alle operazioni volute.
6. Attendi la fine dell’importazione e compilazione. Se i pacchetti non vengono installati automaticamente, apri il progetto in VCC o ALCOM e aggiungi **Kawaii Posing** e **Modular Avatar**. **Unisaki Posing System** e **NDMF** sono dipendenze. `Optional-VCC-Links` contiene i collegamenti originali dei repository per VCC su Windows.
7. Se hai annullato una conferma, importa di nuovo l’installatore quando sei pronto. Finché l’attivatore è presente, puoi usare anche il comando d’installazione licenza in **Tools > Unisaki Studio**. Nelle vecchie build il sottomenu si chiama **ゆにさきスタジオ**.

### Cosa installa questo download

**Kawaii Posing 3.2.0 con Unisaki Posing System 3.2.0.** Questa versione è in sviluppo e non è stata pubblicata. Aggiunge dialoghi d’installazione, Inspector e menu Unity, nomi standard delle pose, menu nel gioco e documentazione offline in trenta lingue. La data di uscita non è stabilita. Cambia lingua con il selettore in alto nell’Inspector. Dopo la pubblicazione, l’installatore scaricherà queste versioni e le dipendenze compatibili dai repository VPM. La preparazione locale non pubblica i pacchetti.

Kawaii Posing include libreria delle pose, strumenti di configurazione e preset di regolazione avatar. L’installatore attiva la licenza locale esistente del prodotto e non richiede un nuovo campo per la chiave Gumroad. Non pubblicare mai file dell’installatore o dati di licenza in richieste d’assistenza pubbliche.

Le preferenze di lingua sono salvate in Unity EditorPrefs per l’utente attuale del sistema e condivise tra i progetti Unity di questo computer. Senza una preferenza salvata, l’installatore segue il sistema e usa l’inglese per lingue non supportate. Le licenze mantengono l’archiviazione esistente: chiave `Software/UnisakiStudio` dell’utente su Windows e file per utente su macOS/Linux. Cambiare lingua non rimuove licenze. Tutti gli strumenti di posa e gli avatar usano la stessa lingua. Cambiarla nell’Inspector di qualsiasi strumento aggiorna la preferenza comune; le scelte di lingua dei singoli avatar vengono ignorate. Il pulsante della lingua appare solo nella conferma iniziale di installazione se non è stata salvata una lingua. Le modifiche successive si effettuano nell’Inspector.

## 2. Aggiungere lo strumento a un avatar

1. Nella **Hierarchy**, seleziona l’avatar con **VRC Avatar Descriptor** o uno dei suoi figli. Usa un avatar nella scena, non l’asset Prefab nella finestra Project o la modalità Prefab.
2. Fai clic destro sull’avatar e scegli **Unisaki Studio > Aggiungi Kawaii Posing**. Se la build installata usa menu giapponesi, scegli **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Lo strumento viene aggiunto all’avatar. Il nome salvato dell’oggetto può restare **可愛いポーズ** anche con etichette tradotte.
4. Applica il preset avatar compatibile, se proposto, come punto di partenza. Altrimenti apri **Configurazione avatar** e scegli un preset o regola personalmente le pose.
5. L’installatore può proporre il precalcolo. È facoltativo: la normale build genera i dati necessari. Riutilizzalo per ridurre i tempi successivi.
6. Seleziona l’oggetto dello strumento, scegli pose e funzioni, quindi carica l’avatar normalmente con VRChat SDK.

### Scelta della lingua e corrispondenza delle etichette

Questa versione offre **Language / 言語** in cima all’Inspector. La scelta unica controlla Inspector e menu generato nel gioco. L’avatar salva la lingua e l’ultima scelta è ricordata per gli altri strumenti e progetti su questo computer. Ricarica l’avatar per cambiare la lingua vista in VRChat.

Usa la tabella seguente per seguire i vecchi tutorial giapponesi. Questa versione include selettore di lingua, Inspector localizzato, nomi standard tradotti e menu nel gioco per tutte le 30 lingue.

| Italiano | Etichetta giapponese nelle vecchie build |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funzioni | 機能 |
| Pose | ポーズ一覧 |
| Configurazione avatar | アバター調整 |
| Apri impostazioni | 設定を開く |
| Aggiorna precalcolo | プレビルドを更新 |
| Controlla impostazioni | 設定の確認 |
| Anteprima | プレビュー |
| Regolazione animazione | アニメーション調整 |
| Ricarica | 再読込 |

Inspector incluso, finestre d’editing e installazione, nomi standard e menu generati sono tradotti in tutte le 30 lingue selezionabili. README, cronologia e manuale offline sono forniti in ogni lingua. Nomi degli avatar, oggetti salvati, pose personalizzate, file degli asset e identificatori interni dei parametri possono mantenere la grafia originale.

I [riferimenti rapidi in 30 lingue](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) spiegano le funzioni e riportano le tabelle dei nomi standard. Sono riferimenti sintetici: usa l’indice delle lingue per la documentazione completa.

## 3. Scegliere pose e funzioni

L’Inspector ha tre schede principali:

| Scheda | Uso |
| --- | --- |
| **Funzioni** | Comandi nel gioco, comportamenti facoltativi, respiro, icone e consumo dei parametri di espressione. |
| **Pose** | Pose attive, categorie e ricerca, ordine, aggiunta animazioni, anteprima, dettagli e regolazione animazione. |
| **Configurazione avatar** | Correzioni specifiche e delle ginocchia, importazione di movimenti originali o personali e preset. |

Attiva soltanto i comandi che vuoi usare. Per esempio, aggiungere **Specchio** al menu consente di commutarlo in VRChat, senza obbligare tutte le pose a rimanere specchiate.

Kawaii Posing include preset avatar e IK per le pose compatibili. Tre pose supine standard hanno già movimenti laterali assegnati: **Gambe distese (足伸ばし)**, **Relax (リラックス)** e **Un ginocchio alzato (膝立て)**. Usa il preset corrispondente e controlla le impostazioni di Girarsi per ogni posa se hai modificato o sostituito queste voci.

### Preset e adattamento

I preset sono verso il fondo di **Configurazione avatar**. Cerca il nome dell’avatar e applica un preset per sostituire le impostazioni attuali. Salva o fai un backup delle regolazioni prima di cambiarlo. È un punto di partenza: proporzioni, abiti e modifiche possono ancora richiedere correzioni manuali.

Usa **Regolazione animazione** su una posa per visualizzare e modificare la posizione del corpo e degli arti. Salva l’animazione dalla finestra quando hai finito. Dove supportato, la regolazione automatica di mani e piedi (IK) è attivabile globalmente e per posa. Integrare il risultato IK attuale crea un’animazione di regolazione e disattiva l’IK della posa per consentire la rifinitura manuale; il clip originale viene mantenuto.

**Impedire la piegatura inversa delle ginocchia** offre altre impostazioni, fra cui l’angolo minimo. Le correzioni specifiche dell’avatar richiedono dati corrispondenti e alcune non sono combinabili con l’IK della posa.

### Movimenti originali e personali

**Usare le pose originali in piedi, accovacciate e prone** rileva i movimenti dal livello Base durante la generazione. **Usa i tuoi movimenti** apre impostazioni d’importazione separate per tipo. Scegli un movimento per tipo. Le assegnazioni manuali hanno priorità sull’importazione automatica del tipo corrispondente.

L’importazione automatica si applica alla copia della build. Non riscrive le animazioni rilevate nell’elenco manuale della scena né modifica i Controller originali. Cancella la sostituzione manuale di un tipo per riattivare il rilevamento automatico. Livelli Base personali e altri sistemi di locomozione possono richiedere regolazioni individuali.

## 4. Usare lo strumento in VRChat

Apri il menu **Expressions** dell’avatar ed entra in **Kawaii Posing**. Scegli una posa per ogni categoria desiderata. Selezionare una posa e selezionare una funzione sono operazioni separate.

- **VR a tre punti:** abbassa o alza la testa per passare tra in piedi, accovacciato o su sedia, seduto a terra e sdraiato. Regola le soglie di altezza nel menu se i cambi avvengono troppo presto o tardi.
- **Desktop:** usa **C** per accovacciarti e **Z** per sdraiarti. Se Z ti lascia seduto, aumenta la soglia per sdraiarsi nelle impostazioni.
- **Prono o supino:** la direzione del viso sceglie il lato. Se entrambi sono selezionati, un salto sul posto può alternarli. Puoi disattivarlo in **Funzioni > Funzioni pratiche** di Unity; non consuma parametri sincronizzati aggiuntivi.
- **Blocchi:** usa i blocchi di testa, braccia e piedi quando necessario. Disattiva i gesti per usare le mani della posa invece degli input dei controller.
- **Specchio:** inverti una posa per rivolgerti a un amico o adattare la composizione.

### Altezza piedi e Altezza suolo

**Altezza piedi** regola i piedi mantenendo ferma la testa. Usala quando i piedi fluttuano o affondano ma la testa è già all’altezza corretta.

**Altezza suolo** muove tutto il corpo, testa inclusa. Usala per divani, letti e superfici rialzate anche senza collider. Nel controllo centrato del sistema comune attuale, **50% è l’altezza originale**, 0% corrisponde a 3 m sotto e 100% a 3 m sopra. Torna vicino a 50% per terminare lo spostamento. Le vecchie versioni possono comportarsi diversamente: controlla la versione installata e aggiorna sistema comune e prodotto insieme.

### Modalità foto

Attiva la voce **Modalità foto** in Unity prima di caricare. In VRChat scegli una posa, usa **Distanza** per avanzare fino a 3 m e **Direzione** per ruotare l’avatar. Il blocco piedi è facoltativo durante la composizione. **Esci da foto** ripristina distanza e rotazione e sblocca i piedi.

La Modalità foto è locale inizialmente. Per mostrarne posizione e rotazione agli altri, attiva **Sincronizzare la Modalità foto** in Unity prima di caricare: costa 16 bit sincronizzati. **Tenere visibile la testa in Modalità foto** riguarda solo la tua vista e non richiede bit sincronizzati.

### Respiro e Girarsi

Configura il respiro per categoria in **Funzioni > Funzioni pratiche > Animare il respiro**. Scegli Nessuno, Debole, Medio, Forte, Rapido o un’animazione personale. Il movimento non costa bit sincronizzati; l’interruttore nel menu richiede 1 bit.

Girarsi richiede una posa sdraiata compatibile e la voce **Girarsi** nel menu. Attivalo per la posa e assegnale un’animazione laterale quando necessario. In VRChat scegli la posa, attiva Girarsi e sblocca testa o collo. L’inclinazione laterale della testa controlla la rotazione. Il normale MotionTime non è disponibile per quella posa mentre usi Girarsi.

Le tre pose supine standard elencate sopra comprendono movimenti laterali. Le altre richiedono un movimento e impostazioni adatti. I preset importati o personali possono avere assegnazioni diverse.

## 5. Modificare, aggiungere e visualizzare le pose

In **Pose**, scegli una categoria o la ricerca. La ricerca accetta nomi giapponesi originali e traduzioni disponibili. Apri i **Dettagli** per modificare animazione, icona, ordine e opzioni temporali.

Per aggiungere più animazioni, trascina i clip nella zona di aggiunta o selezionali in Project e usa il comando d’importazione dei clip selezionati. I riferimenti duplicati vengono rimossi. Cambia destinazione nei Dettagli o usa i pulsanti su e giù.

**Anteprima** mostra la posa nella Scene senza aprire la finestra completa. Non esegue Modular Avatar o NDMF: verifica la build finale per abiti, correzioni del pavimento e altre funzioni aggiunte in fase di build.

Le icone generate dall’avatar aiutano a riconoscere le pose, ma richiedono tempo e possono aumentarne i dati. Abbassa la risoluzione per risparmiare spazio. Le build Android non generano icone. Rigenerale dopo modifiche ad avatar o abiti, quando necessario.

## 6. Memoria dei parametri

L’Inspector mostra il contributo degli strumenti per pose, non il totale dell’avatar. Abiti e altri sistemi possono usare altra memoria. Le impostazioni comuni condivise non sono contate due volte. Molte pose extra in configurazioni personali possono richiedere più bit di selezione.

| Funzione | Bit sincronizzati aggiuntivi |
| --- | ---: |
| Selezione pose, configurazione standard minima | 8 |
| Specchio | 1 |
| Blocca gesti | 1 |
| Movimento del respiro | 0 |
| Interruttore respiro nel menu | 1 |
| Altezza piedi | 8 |
| Altezza suolo | 8 |
| Modalità foto solo locale | 0 |
| Sincronizzare la Modalità foto | 16 |
| Tenere visibile la testa in Modalità foto | 0 |
| Disattivare l'oscillazione da fermo di VRChat | 0 |
| Girarsi | 10 |

Girarsi condivide 1 bit con la correzione della postura per la direzione del collo: entrambe insieme richiedono ancora 10 bit totali. Il consumo mostrato nella versione installata è il riferimento pratico della configurazione selezionata.

## 7. Aggiornamento e precalcolo

1. Fai un backup del progetto e salva la scena di lavoro.
2. In VCC o ALCOM aggiorna insieme **Kawaii Posing** e **Unisaki Posing System**. Mantieni compatibili anche SDK, Modular Avatar e NDMF.
3. Attendi la compilazione, seleziona lo strumento esistente e controlla pose, impostazioni e consumo dei parametri.
4. Se usi il precalcolo, scegli **Aggiorna precalcolo** e ricarica l’avatar.

Le impostazioni esistenti sono conservate. I vecchi Prefab 8-bit restano per compatibilità; i riferimenti esistenti non richiedono eliminazione o sostituzione. Le nuove installazioni usano il Prefab normale, con funzioni inutili disattivabili per ridurre il consumo.

Un avviso di precalcolo superato indica che le impostazioni sono cambiate dopo la creazione dei dati in cache. Aggiornarlo rigenera i dati. Nascondere l’avviso non aggiorna il precalcolo né risolve il problema. Le build normali generano i dati necessari anche senza precalcolo manuale ogni volta.

## 8. Risoluzione dei problemi

| Sintomo | Controlli |
| --- | --- |
| Menu di aggiunta assente | Verifica che siano installati prodotto **e** Unisaki Posing System e risolvi gli errori di compilazione nella Console. Il solo installatore licenza non è la libreria delle pose. |
| Installatore annullato o file rimossi | Reimporta l’installatore acquistato quando sei pronto e rileggi le conferme. |
| Licenza apparentemente assente in un altro progetto | Importa l’installatore con lo stesso account del sistema. Su un nuovo computer o account installa anche lì la licenza. La lingua non si trasferisce automaticamente tra computer. |
| Nessuna posa in VRChat | Aggiungi lo strumento sotto l’avatar corretto nella scena, abilita le pose, controlla gli avvisi e carica quell’avatar. Verifica SDK e altri strumenti di locomozione. |
| Z non raggiunge la posizione sdraiata | Aumenta la soglia di altezza per sdraiarsi nelle impostazioni nel gioco. |
| Mani o ginocchia disallineate | Prova il preset adatto, poi IK supportata e/o Regolazione animazione. Verifica gli abiti nella build finale. |
| Girarsi non funziona | Usa una posa sdraiata compatibile, attiva la funzione nei dettagli e nel menu e sblocca testa o collo. Prova prima una delle tre pose standard compatibili. |
| Gli amici non vedono il movimento foto | Attiva **Sincronizzare la Modalità foto** in Unity, controlla i parametri e ricarica. |
| Lingua cambiata in Unity ma non in VRChat | Ricarica l’avatar. Nelle build localizzate verifica il selettore unico in cima all’Inspector. |
| Errori di build o precalcolo | Leggi il **primo** errore pertinente della Console. Salva un backup della scena, aggiorna o reinstalla prodotto e sistema comune con VCC/ALCOM e contatta l’assistenza se persiste. Conserva oggetti regolati e GeneratedResources salvo precise istruzioni di recupero dell’assistenza. |

Per l’assistenza indica versioni di prodotto e sistema comune, Unity/SDK/Modular Avatar/NDMF, nome avatar, passaggi esatti e l’errore pertinente della Console. Rimuovi dalle pubblicazioni file privati, contenuto dell’installatore, valori di licenza e dati dell’account.

- [Assistenza](https://help.unisakistudio.jp/)
- [Manuale illustrato online (giapponese)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Pagina del prodotto su Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licenze e crediti

Una [traduzione inglese di riferimento dell’accordo del prodotto](../../Terms.en.html) è fornita insieme all’originale giapponese.

Leggi gli accordi originali del prodotto e del sistema comune accanto al README, oppure nella cartella `Licenses` del ZIP acquistato. L’accordo inglese di Unisaki Posing System è una traduzione di riferimento esistente per quel sistema; quello giapponese del prodotto resta incluso separatamente. La guida non modifica gli accordi né concede diritti aggiuntivi. Per domande sull’uso o la ridistribuzione dei dati contatta l’assistenza.

L’installatore include una versione modificata di **VPMPackageAutoInstaller** di **anatawa12**, con **SimpleJson** e **semver.net**. Avvisi di copyright e licenze MIT sono in `ThirdPartyNotices.txt` nel ZIP acquistato. Libreria delle pose e altre risorse hanno le proprie licenze prodotto.
