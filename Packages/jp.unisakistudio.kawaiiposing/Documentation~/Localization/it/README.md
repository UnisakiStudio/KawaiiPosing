# Kawaii Posing

Strumento per bloccare le pose in VRChat, con graziose posizioni sedute e sdraiate utilizzabili con tracciamento a 3 punti o in desktop. Include 85 pose: 15 in piedi, 20 accovacciate, 17 sedute, 16 prone e 17 supine.

Questo README riguarda la versione v3.2.0 in sviluppo. La data di uscita ufficiale non è stabilita. La versione installata compare in alto nell’Inspector.

- [Pagina del prodotto su BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Cronologia delle modifiche](CHANGELOG.md)

## Lingua dell’interfaccia e documentazione offline

Scegli la lingua in «Language / 言語», in cima all’Inspector. Una sola scelta si applica sia all’Inspector sia ai menu VRChat generati. Carica nuovamente l’avatar per cambiare la lingua nel gioco.

Senza una scelta esplicita viene usata la lingua del computer; se non è supportata, viene usato l’inglese. Sono supportati Windows, macOS e Linux. L’ultima scelta è salvata in EditorPrefs e riutilizzata negli altri progetti dello stesso utente del sistema su questo computer. Una scelta esplicita già salvata nell’avatar viene conservata. Non viene sincronizzata con altri computer. Il sistema di archiviazione della licenza rimane invariato.

Scegli la lingua di README, cronologia e guida dall’[elenco delle lingue](../index.html) incluso. Anche i collegamenti alla guida e alle novità nell’Inspector seguono la lingua scelta. Le condizioni d’uso originali e le traduzioni di riferimento restano disponibili separatamente.

## Funzioni principali

- Modalità foto: sposta l’avatar fino a 3m in avanti e cambia la direzione. 0 bit solo nella tua vista, 16 bit per mostrare posizione e direzione agli altri.
- Testa visibile nelle foto: impedisce che la testa del tuo avatar vicino scompaia, solo durante la Modalità foto.
- Altezza suolo: muove tutto il corpo, testa inclusa, di 3m sopra o sotto. 50% è altezza originale e iniziale, 0% corrisponde a 3m sotto e 100% a 3m sopra. È distinta da «Altezza piedi», che sposta il lato dei piedi mantenendo ferma la testa.
- Girarsi: nelle pose sdraiate compatibili puoi ruotare a destra o a sinistra inclinando la testa.
- Respiro: anima il petto e altre parti del corpo. Scegli Nessuno, Debole, Medio, Forte, Rapido o Personalizzato per categoria.
- Disattivare l'oscillazione da fermo di VRChat: riduce il movimento standard conservando respiro dello strumento e altri movimenti personalizzati.
- Ridurre le deformazioni dovute alla rotazione della testa: limita la deformazione quando il collo sbloccato ha una direzione diversa dalla posa originale.
- Scelta delle funzioni: aggiungi solo i menu desiderati e verifica il consumo di ExpressionParameters nell’Inspector.
- Ricerca, aggiunta in gruppo e riordino delle pose: ricerca tra categorie, importazione di più clip e scelta della destinazione nell’ordine.
- Anteprima semplice nella Scene: controlla subito la posa con «Anteprima» nell’elenco.

- Regolazione automatica degli arti (IK): adatta le posizioni alla corporatura nelle pose compatibili. Puoi attivarla per posa e integrare il risultato in un’animazione di regolazione.

### Girarsi con le pose incluse

Le pose supine «Gambe distese», «Relax» e «Un ginocchio alzato» hanno movimenti laterali già assegnati. I rispettivi movimenti per girarsi si basano sulla posa «横向き寝» (sdraiata sul fianco), «Pisolino» e «Pisolino da gatto».

Attiva «Funzioni > Funzioni del menu > Girarsi» e carica l’avatar; in VRChat scegli una posa compatibile e «Girarsi». Lascia il collo sbloccato.

Per impostarlo personalmente, attiva «Pose > Dettagli > Abilita Girarsi» e assegna un’animazione a «Posa laterale per girarsi». Le pose che usano Girarsi non possono usare il normale MotionTime.

### Adattare le pose alla corporatura

Puoi usare la regolazione automatica inclusa, ma non tutte le pose richiedono IK. «Abilita regolazione automatica degli arti» nella finestra di regolazione agisce globalmente; «Abilita IK per questa posa» agisce individualmente.

«Integra IK nelle regolazioni» salva il risultato automatico attuale in una nuova animazione di regolazione e disattiva l’IK della posa. Puoi poi rifinirla a mano. È disponibile quando regolazione globale e della posa sono attive ed esistono impostazioni IK applicabili.

In «Configurazione avatar» ci sono anche «Impedire la piegatura inversa delle ginocchia» e il dettaglio «Flessione minima del ginocchio (gradi)».

## Installazione

1. Scarica i file dalla pagina del prodotto nel negozio dove lo hai acquistato.
2. Importa «可愛いポーズツール.unitypackage» in Unity e registra licenza e repository dei pacchetti.
3. In VCC o ALCOM aggiungi Kawaii Posing e Modular Avatar al progetto Unity desiderato. Unisaki Posing System e NDMF vengono installati come dipendenze.
4. Nella Hierarchy fai clic destro sull’avatar e scegli «Unisaki Studio > Aggiungi Kawaii Posing».
5. Seleziona Kawaii Posing aggiunto nell’avatar e imposta funzioni e pose nell’Inspector.
6. Carica l’avatar normalmente.

Requisiti: Unity 2022.3, VRChat Avatars SDK 3.10.4 o successivo, Modular Avatar 1.x dalla versione 1.15.1 e NDMF 1.x dalla versione 1.14.0. Aggiorna insieme i pacchetti necessari con VCC o ALCOM.

## Aggiornare da una versione precedente

Aggiorna insieme il prodotto e Unisaki Posing System. Le impostazioni degli strumenti già presenti vengono conservate. Controlla funzioni e consumo di ExpressionParameters nell’Inspector; se usavi il precalcolo, premi «Aggiorna precalcolo» prima di ricaricare l’avatar.

Da v3.1.0 i nuovi inserimenti usano soltanto il Prefab normale 「可愛いポーズ」. Disattivando le opzioni inutili in «Funzioni», la configurazione minima con sola selezione delle pose richiede 8 bit. Molte pose possono richiedere bit di selezione aggiuntivi.

I vecchi Prefab 8bit restano in «Editor/Legacy» per conservare i riferimenti di avatar e preset esistenti. Non occorre eliminarli o sostituirli. Il menu per i nuovi inserimenti non mostra la versione 8bit.

## Dove configurare le opzioni

| Scheda | Possibilità |
| --- | --- |
| Funzioni | Menu nel gioco, funzioni pratiche, respiro, icone e consumo di ExpressionParameters |
| Pose | Scelta delle pose, dettagli, ricerca, aggiunta in gruppo, ordine, anteprima e regolazione animazione |
| Configurazione avatar | Correzioni dell’avatar e delle ginocchia, importazione di pose originali o movimenti personali e cambio preset |

Il comando per aprire le impostazioni mostra i dettagli sotto la voce. Il respiro si configura in «Funzioni > Funzioni pratiche > Animare il respiro».

«Usare le pose originali in piedi, accovacciate e prone» importa automaticamente le pose dell’avatar. Per movimenti personali, apri separatamente le impostazioni d’importazione e assegna ciascun tipo, come in piedi, accovacciato (Crouching) o prono (Prone).

I preset si trovano in fondo a «Configurazione avatar». «Applica questo preset» sostituisce le impostazioni attuali delle pose: salva le regolazioni prima di cambiarlo.

### Consumo per funzione

- Il movimento del respiro richiede 0 bit. Soltanto «Funzioni del menu > Respiro», per fermarlo e riprenderlo nel gioco, richiede 1 bit di sincronizzazione.
- La Modalità foto richiede 0 bit solo locale. «Funzioni pratiche > Sincronizzare la Modalità foto» usa 16 bit. «Tenere visibile la testa in Modalità foto» usa 0 bit.
- «Altezza piedi» e «Altezza suolo» usano 8 bit ciascuna. Spostando Altezza suolo dal centro l’avatar sale o scende; tornando vicino a 50% termina la correzione.
- «Girarsi» usa 10 bit da solo. Condivide 1 bit con «Ridurre le deformazioni dovute alla rotazione della testa», quindi entrambe insieme usano ancora 10 bit.
- «Specchio» e «Blocca gesti» usano 1 bit ciascuna.

Il totale dell’Inspector riguarda gli strumenti per pose sull’avatar, senza includere abiti e altri sistemi. Le impostazioni comuni non vengono contate due volte usando più strumenti.

### Anteprima e modifica delle pose

«Anteprima» su ogni voce di «Pose» mostra la posa nella Scene. Per correzioni dettagliate apri «Regolazione animazione», modifica con l’anteprima e salva.

L’anteprima semplice non esegue la build MA o NDMF. Controlla anche il risultato della build prima del caricamento per abiti integrati e correzioni del pavimento applicate in quella fase.

La lente a sinistra cerca le pose per nome. Riordinale scegliendo la destinazione in «Dettagli > Ordine» o con i pulsanti su e giù. Aggiungi più animazioni trascinandole nella zona di aggiunta o con «Importa clip selezionati in Project».

«Aggiorna miniature delle pose» genera le immagini dopo una conferma. «Generare le icone delle pose» aiuta a riconoscerle nei menu del gioco, ma la generazione allunga la build. Seleziona «Ridurre le dimensioni delle icone» per risparmiare spazio. Android non genera icone delle pose.

## Comandi di base nel gioco

- Scegli le pose di ogni categoria dal menu Expressions. In VR l’altezza della testa determina il passaggio tra in piedi, accovacciato, seduto e sdraiato.
- Da sdraiati, la direzione del viso alterna supino e prono. Con entrambe le pose selezionate puoi anche saltare sul posto. Disattiva il cambio con salto in «Funzioni → Funzioni pratiche → Cambiare posa sdraiata saltando» di Unity se necessario (attivo inizialmente). Le soglie nelle impostazioni regolano l’altezza del cambio categoria.
- In desktop usa C e Z per cambiare postura. Se Z non ti fa sdraiare, aumenta la soglia di altezza per sdraiarsi nelle impostazioni.
- «Blocca gesti» usa le mani della posa invece della forma delle dita dei controller.
- «Altezza piedi» regola il lato dei piedi mantenendo la testa ferma. «Altezza suolo» muove verticalmente tutto il corpo, testa inclusa. Compaiono in questo ordine nelle impostazioni.
- Avanzando con «Modalità foto > Distanza», l’avatar si rivolge verso di te. Ruotalo con «Direzione» e attiva «Blocca piedi» quando vuoi. «Esci da foto» ripristina distanza e direzione e sblocca i piedi.
- «Respiro» è disponibile con il movimento del respiro attivo. L’intensità si imposta in Unity; nel gioco puoi attivarlo o disattivarlo.

## Precalcolo e avvisi

«Aggiorna precalcolo» riutilizza i dati generati per velocizzare la build dell’avatar. Senza precalcolo, la normale build genera comunque i dati necessari.

Dopo una modifica, «Controlla impostazioni» in alto nell’Inspector e i simboli della Hierarchy segnalano gli aggiornamenti necessari. «Impostazioni di visualizzazione avvisi» si trova in «Controlla impostazioni». Nascondere gli avvisi non risolve i problemi né aggiorna i dati generati.

## Note d’uso

- Il blocco delle pose durante il tracciamento completo del corpo non è supportato.
- Corporatura, abiti e modifiche possono richiedere altre regolazioni.
- Livelli Base particolari o altri sistemi di postura possono non integrarsi come previsto. Se i blocchi non funzionano, controlla anche «Configurazione avatar > Integrare i blocchi del tracciamento con altri strumenti».
- Movimento e rotazione della Modalità foto e altezza del suolo correggono anche i movimenti standard o personali senza posa selezionata. Verifica nel client VRChat la vista e i movimenti dopo le sostituzioni standard.
- «Disattivare l'oscillazione da fermo di VRChat» riguarda l’attesa standard, non ogni possibile causa di oscillazione.

## Guida e assistenza

Apri guida, assistenza e cronologia da «Aiuto / Novità» in alto nell’Inspector. La spiegazione delle funzioni comuni è anche in «Packages > Unisaki Posing System > README» nella finestra Project di Unity.

- [Manuale ufficiale](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Assistenza](https://help.unisakistudio.jp/)

Per segnalare un problema, indica le versioni del prodotto e di Unisaki Posing System, quelle di Unity, VRChat SDK, Modular Avatar e NDMF, l’avatar usato, i passaggi per riprodurlo e gli errori della Console.

## Distribuire preset

Informazioni sui dati creati con la funzione di regolazione animazione.

Puoi distribuire e vendere liberamente i file di animazione di regolazione creati con questa funzione,
e i preset creati con quei file assegnati, senza chiedere il permesso a Unisaki Studio.
Condividili, per esempio insieme ai tuoi avatar o come preset per avatar non inclusi nello strumento.

## Prodotti con impostazioni d’integrazione incluse

Le impostazioni d’integrazione sono create autonomamente dal nostro negozio. Non abbiamo chiesto il permesso agli autori dei prodotti interessati, ritenendo che non fosse necessario.
Per richiederne la distribuzione o l’interruzione della distribuzione, contattaci tramite i messaggi del negozio.
L’integrazione richiede l’acquisto e il download del prodotto corrispondente.
Per problemi con queste impostazioni, contatta il nostro negozio e non gli autori degli altri prodotti.

«可愛い座りツール»
https://yunisaki.booth.pm/items/3611536

«添い寝ツール»
https://yunisaki.booth.pm/items/3670993

«少女モーション集vol.1», di ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

«VRC想定移動モーション（無料配布）», di カトのVRC道具屋
https://booth.pm/ja/items/1285101

«ごろ寝システムEX», di minminmart
https://minminmart.booth.pm/items/4233545

## Condizioni d’uso

Questo strumento può essere usato soltanto da chi accetta le seguenti condizioni, redatte con la licenza VN3.

[Condizioni d’uso (giapponese)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Il codice sorgente e le risorse di questo repository non sono open source. Sono necessari acquisto regolare del prodotto e accettazione delle condizioni d’uso.

[Condizioni d’uso (inglese)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
