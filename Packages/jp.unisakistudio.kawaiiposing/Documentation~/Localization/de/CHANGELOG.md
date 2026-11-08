# Änderungsverlauf

## [3.2.0] - Unveröffentlicht

### Hinzugefügt

- Inspector, Bearbeitungsbefehle, Installationsdialoge, Standardposennamen und erzeugte VRChat-Menüs in 30 Sprachen verfügbar.
- Gemeinsame Sprachauswahl für Inspector und Spielmenü. Anfangs gilt die Computersprache, die letzte Auswahl wird für andere Projekte desselben Betriebssystembenutzers übernommen.
- README, Änderungsverlauf und Offline-Anleitung öffnen sich in der gewählten Sprache.
- Anzeigenamen der 128 Standardposen und Funktionsbeschreibungen mit der bestehenden Terminologie abgestimmt.

### Kompatibilität

- Vorhandene Avatareinstellungen, eigene Namen, Assetreferenzen, Parameterkennungen und Lizenzspeicherung bleiben erhalten.

## [3.1.2] - 2026-11-09

- Die Kopffixierung lässt sich unter „Einstellungen → Automatische Kopffixierung in Rückenlage“ im EX-Menü auch ohne Fußhöhe ändern. In alten Versionen verschwundene Einträge kehren nach Update und Build zurück.
- Unisaki Posing System 3.1.2 unterstützt. Behoben, dass mit aktiver Kopfdrehungskorrektur das Gesicht nach Aufstehen aus Bauchlage nach oben gerichtet blieb.

Aktualisiere Kawaii Posing in ALCOM / VCC auf 3.1.2. Unisaki Posing System 3.1.2 ist ebenfalls erforderlich. Bei genutzter Vorberechnung aktualisiere sie, speichere die Szene und erstelle und lade den Avatar erneut hoch.

## [3.1.1] - 2026-11-08

- Aktivierte Bodenhöhe und Umdrehen erscheinen auch ohne Spiegeln unter Einstellungen im VRChat-EX-Menü.
- Richtige Umdrehbewegungen für „Beine ausgestreckt“, „Entspannt“ und „Ein Knie hoch“ bleiben nach altem Sortieren, Löschen oder Umbenennen erhalten, auch nach vollständigem Unpack bei identifizierbarem Ursprung. Eigene Posen, ausdrücklich deaktiviertes Umdrehen und ersetzte Seitenbewegungen bleiben erhalten.
- Kurze Bauchlage bei Avatarauswahl und kurze Rückenlage beim Springen mit ausschließlich gewählter Bauchlage behoben. Der anfangs aktive Sprungwechsel ist unter „Funktionen → Komfortfunktionen → Liegepose durch Springen wechseln“ abschaltbar.
- Wiederherstellbare verlorene Referenzen gemeinsamer Animator Controller lösen eine Warnung und Wiederaufbau aus Einstellungen aus; avatarübergreifende Referenzen bleiben erhalten.
- Offizielles Prefab über das Hinzufügemenü auch bei eigenem gleichnamigem 「可愛いポーズ」-Prefab platzierbar.
- Beim Hinzufügen von 添い寝ツール wird bei fehlender Voraussetzung das zuerst zu installierende Produkt genannt.

Aktualisiere Kawaii Posing und Unisaki Posing System in ALCOM / VCC beide auf 3.1.1. Bei genutzter Vorberechnung aktualisiere sie am 「可愛いポーズ」-Objekt in der Szene und speichere diese. Für VRChat den Avatar erneut erstellen und hochladen.

## [3.1.0] - 2026-11-07

- Automatische IK-Anpassung an den Körperbau für 53 der 85 Posen.
- „Beine ausgestreckt“, „Entspannt“ und „Ein Knie hoch“ unterstützen Umdrehen durch Kopfneigung.
- Fotomodus mit Position/Drehung, wählbarer Synchronisierung und sichtbarem eigenen Kopf.
- Bodenhöhe bewegt den ganzen Körper 3m auf/ab, getrennt von Fußhöhe.
- Atmung, Unterdrückung des Standardleerlaufs und Halsrichtungsverformungskorrektur ergänzt.
- Funktions- und Parameteranzeige, Posensuche, Mehrfachimport, Sortieren und einfache Scene-Vorschau ergänzt.
- Desktop-Wechsel Stehen/Hocken/Sitzen beschleunigt.
- Vorberechnungswarnungen, Scrolllast und Bereinigungspausen verbessert.
- Unisaki Posing System 3.1.0 unterstützt.

## [3.1.0-beta.2] - Offene Beta (2026-11-05)

- Offene Beta über GitHub Releases und VPM gestartet. 53 der 85 Posen passen Gliedmaßen automatisch per IK an den Körperbau an.
- Gemeinsames Paket 3.1.0-beta.2 unterstützt. Änderungsanzeige nach Vorberechnung, Inspector-Scrollen und Bereinigungspausen verbessert.

## [3.1.0-beta.1] - Offene Beta (2026-11-04)

- Unisaki Posing System 3.1.0-beta.1 unterstützt.
- Normale Desktop-Haltungswechsel auf eine Auswertung für Build und Vorberechnung umgestellt; VR und Sonderfälle unverändert.
- Vorberechnungen alpha.3 und älter als aktualisierungsbedürftig erkannt.
- Blickposition bei Bodenhöhenänderung im Fotomodus erhalten und danach auf neueste Bodenhöhe zurückgekehrt.
- Verbesserungen bis alpha.3 zu automatischer Übernahme, importierten Bewegungsanpassungen und erzeugten Controllern übernommen.

## [3.1.0-alpha.2] - Geschlossener Test (2026-10-26)

### Korrekturen und Änderungen

- Gemeinsames Posensystem auf 3.1.0-alpha.2 aktualisiert und Debugkorrekturen übernommen.
- Bodenhöhe auf 3m auf/ab erweitert; 50% ist ursprüngliche und anfängliche Höhe.
- Foto- und Bodenhöhenkorrektur auch für nicht gewählte Standard-/Eigenhaltungen.
- Probleme manueller Korrekturen, gleichnamiger und anfänglicher Posen sowie alter Umdrehvoreinstellungen behoben.

## [3.1.0-alpha.1] - Vor Veröffentlichung

### Hinzugefügt

- Automatische Gliedmaßenanpassung (IK) an Körperbau ergänzt.
- Globale und posenweise IK-Aktivierung sowie Übernahme in Anpassungsanimationen ergänzt.
- Rückenlagen „Beine ausgestreckt“, „Entspannt“ und „Ein Knie hoch“ unterstützen Umdrehen durch Kopfneigung.
- Posenspezifische Umdreheinstellungen und Seitenanimation ergänzt.
- Fotomodus für Vorwärtsbewegung und Drehung ergänzt.
- Foto-Synchronisierung wählbar: 0 bit lokal, 16 bit synchronisiert.
- Eigener Kopf im Fotomodus sichtbar haltbar.
- Bodenhöhe zum Anheben des ganzen Körpers samt Kopf ergänzt.
- Atembewegung, Stärke und Schaltmenü ergänzt.
- Unterdrückung des normalen VRChat-Schwankens ergänzt.
- Halsrichtungsbedingte Verformungskorrektur ergänzt.
- Rückwärtsknickschutz und minimale Kniebeugung ergänzt.
- Aktivierung je Funktion und ExpressionParameters-Verbrauch ergänzt.
- Scene-Vorschau, Posensuche, Mehrfachimport und Zielreihenfolge ergänzt.
- Änderungsverlauf im Inspector ergänzt.

### Änderungen

- Inspector in 3 Register aufgeteilt: Funktionen, Posen, Avatareinrichtung.
- Atemdetails, eigene Bewegungsübernahme und Voreinstellungen neu angeordnet.
- Doppelte Animationen für Fußhöhe reduziert.
- Bestätigung für Posenbildaktualisierung ergänzt und Warnoptionen unter Einstellungen prüfen gesammelt.
- Neues 8bit-Hinzufügemenü entfernt, Funktionen über normales Prefab wählbar; Referenzen erhalten.
- Unisaki Posing System 3.1.0-alpha.1 unterstützt und minimales VRChat Avatars SDK auf 3.10.4 angehoben.

### Korrekturen

- Namenseingabe in andere Pose und geschlossene Details beim Sortieren behoben.
- Überlagerte Vorschauen, Positionsversatz und Fehler einzelner Avatare behoben.
- Warn-/Vorberechnungsstatus nach Änderung und einzelne Build-Fehler korrigiert.

## [3.0.13] - 2026-09-22
- Auf PosingSystem 3.0.17 aktualisiert; horizontalen Posenversatz bei gleichmäßiger Skalierung des ganzen Avatars behoben.
- Warnungen zu automatischen Schritten, fehlender Vorberechnung und Änderungen einzeln oder gemeinsam ignorierbar.
- Ungeeignete Einzelanimationen beim manuellen Fortbewegungsimport ausgeschlossen.

## [3.0.12] - 2026-09-15
- Avatarvoreinstellung ergänzt (ルリエ).

## [3.0.11] - 2026-09-09
- Avatarvoreinstellungen ergänzt (メルヴィ, ミダリス).
- Bewegungsersetzung der Voreinstellung うらら korrigiert.

## [3.0.10] - 2026-08-31
- Auf PosingSystem 3.0.11 aktualisiert; Vorberechnungsfehler mit neuestem NDMF und Ausnahmen der Fehleranzeige behoben.

## [3.0.9] - 2026-08-29
- Auf PosingSystem 3.0.10 aktualisiert; Voreinstellungsladen und Hierarchy-Iconprüfung entlastet.
- Vorberechnungsfehler mehrerer Posensysteme im selben Avatar behoben.

## [3.0.8] - 2026-08-26
- Auf PosingSystem 3.0.9 aktualisiert; durch NDMF ungültiger Vorschau-Avatar verursachte keinen Fehler `Avatar is null` beim Play mehr.

## [3.0.7] - 2026-08-18
- Auf PosingSystem 3.0.8 aktualisiert; mögliche ungültige Posendaten bei erneuter Höhenkorrektur behoben.

## [3.0.6] - 2026-08-12
- Avatarvoreinstellungen ergänzt (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Avatarvoreinstellungen ergänzt (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Avatarvoreinstellungen ergänzt (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Lizenzinstallation und -entfernung verbessert.

## [3.0.2] - 2026-01-04
- Lizenzverarbeitung unter Mac und Linux korrigiert.

## [3.0.1] - 2025-12-28
- Avatarvoreinstellungen ergänzt (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Vorberechnung ergänzt.
- Animationsanpassung ergänzt.
- Voreinstellungen ergänzt.
- Hinzufügen per unitypackage ermöglicht.
- Avatarvoreinstellungen ergänzt (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Kompatibilitätsprobleme mit bestimmten Systemen gelöst.

## [2.2.4] - 2025-04-04
- Nicht wechselnde Haltungen mit bestimmten Avataren und ModularAvatar-Versionen behoben.

## [2.2.3] - 2025-03-13
- Fehlerhafte Bewegungen einzelner Avatare, etwa beim Springen mit 森羅, behoben.
- Teilweise falschen Anfangswert von Gesten aus behoben.

## [2.2.2] - 2025-03-06
- Fehler in bestimmten Umgebungen behoben.

## [2.2.1] - 2025-02-05
- Unity-Absturz behoben.
- Version zum Werkzeugnamen in NDMF Console hinzugefügt.

## [2.2.0] - 2025-02-02
- Gesten aus zur Nutzung der animierten Handform ergänzt.
- Handformdaten für alle Posen ergänzt.

## [2.1.6] - 2025-02-02
- Beschädigte Posen zusammen mit bestimmten Werkzeugen behoben.
- Einstellungsabhängige Fehler behoben.

## [2.1.5] - 2024-12-10
- Konflikte mit bestimmten Systemen gelöst.
- Entfernen der Unitypackage-Version per Schaltfläche ergänzt.
- Integrations-Prefabs von 三点だいしゅきツール nach Veröffentlichung der VCC-Version entfernt.

## [2.1.4] - 2024-12-08
- Fehler bestimmter Avatare behoben.
- Durch Konflikte unbenutzbare Fußfixierung behoben.
- Ungewollte Rückkehr zu VRC-Standardhaltungen im Desktop behoben.

## [2.1.3] - 2024-12-01
- Ausbleibende Posenwechsel mit Avataren/Systemen, die VRMode mit falschem Typ verwenden, behoben.
- Anzeige von Konflikten verschiedener Parametertypen zwischen Systemen in NDMF-Console ergänzt.

## [2.1.2] - 2024-12-01
- Erklärung in NDMF-Console ergänzt, wenn Fehler anderer Werkzeuge beim Avatar-Build einen Fehler im Unisaki Posing System verursachen.
- Build-Fehler bestimmter Avatare behoben.
- Verhalten direkt nach Avatar-Laden verbessert.
- Ursprüngliche Avatar-Fortbewegungslogik entfernt, da sie bei manchen Avataren die Funktion verhinderte.

## [2.1.1] - 2024-11-20
- Fehler behoben, der Builds verhinderte.

## [2.1.0] - 2024-11-20
- Einsinkende Füße/Hüfte im Desktop behoben, alle Haltungen sauber möglich.
- Haltungswechsel unabhängig von Kopfhöhe ergänzt.
- Modus ohne Iconerzeugung für Quest-Upload ergänzt.
- Warnungen bei Avatarproblemen ergänzt.
- Fixierungskonflikte mit AFK und Armfixierungen anderer Werkzeuge gelöst.
- Automatische Halsfixierung in Rückenlage ergänzt.
- ExpressionsMenu geändert: Posenauswahl in separatem Ordner, Fixierungen auf oberster Ebene.

## [2.0.0] - 2024-11-14
### Korrekturen
- Als VPM-Paket für VCC bereitgestellt.
- 17bit-Verbrauch der 8bit-Version behoben.

## [1.15.0] - 2024-11-04
### Korrekturen
- Fehler und Probleme behoben.

## [1.14.0] - 2024-07-05
### Korrekturen
- Probleme mit VRCFury behoben.

## [1.13.0] - 2024-04-11
### Korrekturen
- Integration von ごろ寝システムEX ergänzt.

## [1.12.0] - 2024-03-31
### Korrekturen
- Nicht nutzbares Werkzeug bei bestimmten ExMenu-Zuständen behoben.
- Spiegeln in Einstellungen ergänzt.
- Katzenpose korrigiert.
- ５ Seitenliegeposen ergänzt.

## [1.11.0] - 2024-03-12
### Korrekturen
- Fehlerhafte Haltungen bei hohem Kopf behoben.

## [1.10.0] - 2024-03-10
### Korrekturen
- Stehfunktion mit 15 Posen ergänzt.
- Unbeabsichtigte Fußbewegungen bestimmter Avatare/Umgebungen behoben.
- ExpressionParameters8bit-Version ergänzt.

## [1.9.0] - 2024-03-05
### Korrekturen
- Unbeabsichtigte Fußbewegungen bestimmter Avatare behoben.
- WriteDefaults vereinheitlicht.
- ７ Hock- und ８ Sitzposen ergänzt.

## [1.8.0] - 2024-02-25
### Korrekturen
- Uploadfehler mit ModularAvatar1.9.0 und neuer behoben.
- ModualrAvatar1.9.0 oder neuer ist nun erforderlich.

## [1.7.0] - 2024-02-23
### Korrekturen
- Einstellbare Kopfhöhenschwellen je Haltung ergänzt.
- Fehlerhafte Posen oder Füße etwa beim Springen bestimmter Avatare behoben.
- ExpressionParameter-Verbrauch von 54 auf 16bit reduziert.

## [1.6.0] - 2024-02-20
### Korrekturen
- Nicht erreichbare Sitzhaltung im VR-Modus behoben.

## [1.5.0] - 2024-02-18
### Korrekturen
- Sitzposen im Desktop auch bei gedrückter C-Taste ermöglicht.

## [1.4.0] - 2024-02-17
### Korrekturen
- Nicht nutzbare 添い寝-Integration ohne 三点だいしゅき-Integration behoben.
- Blockierte Füße nach Sprüngen behoben.

## [1.3.0] - 2024-02-16
### Korrekturen
- Ungewöhnlich hohe Zahl eingerichteter VRCContactSender/Receiver korrigiert.

## [1.2.0] - 2024-02-16
### Korrekturen
- Build-Fehler beim Upload behoben.

## [1.1.0] - 2024-02-15
### Korrekturen
- Falsche Standardauswahl mit mehreren Prefabs behoben.
- Falsche 可愛い座り-Integration korrigiert.

## [1.0.0] - 2024-02-14
### Veröffentlichung
