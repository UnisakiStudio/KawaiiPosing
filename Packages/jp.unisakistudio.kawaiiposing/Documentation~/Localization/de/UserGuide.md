# Kawaii Posing — Deutsche Bedienungsanleitung

Kawaii Posing bietet 85 Posen für Desktop und Dreipunkt-VR: 15 Steh-, 20 Hock-/Stuhl-, 17 Bodensitz-, 17 Rücken- und 16 Bauchlagen.

Diese Anleitung beschreibt Installation, Avatareinrichtung, VRChat-Steuerung, Posenbearbeitung, Updates und Fehlerbehebung. Im gekauften ZIP führt `START_HERE.html` am schnellsten zur Installation.

## Vor dem Start

- Verwende ein Unity 2022.3 VRChat-**Avatarprojekt**, erstellt oder verwaltet mit VRChat Creator Companion (VCC) oder ALCOM.
- Erforderlich: VRChat Avatars SDK ab 3.10.4, Modular Avatar 1.x ab 1.15.1 und NDMF 1.x ab 1.14.0.
- Für Humanoid-Avatare im Desktop und Dreipunkt-VR (Headset und zwei Controller). Posenfixierung bei aktivem Ganzkörper-Tracking wird nicht unterstützt.
- Sichere vorhandene Projekte vor Installation oder Aktualisierung. Behebe zuerst Unity-Kompilierfehler.
- Der Installer lädt Produkt und Abhängigkeiten aus Paketquellen; Internetzugang ist erforderlich. Avatarmodelle, VRChat SDK, Modular Avatar und NDMF liegen diesem ZIP nicht bei.

## 1. Lizenz und Produkt installieren

1. Entpacke das ganze ZIP in einen normalen Ordner außerhalb deines Unity-Projekts.
2. Öffne das gewünschte Avatarprojekt in Unity. Importiere `Installer/KawaiiPosing_Installer.unitypackage` über **Assets > Import Package > Custom Package** oder öffne die Datei mit Unity.
3. Lies Import- und Installationshinweise. Die Lizenzbestätigung nennt die zu installierenden Lizenzen. Über **Sprache…** oder **言語...** im Dialog änderst du die Installersprache.
4. Bestätige die Lizenzinstallation. Sie umfasst auch das gemeinsame Unisaki Posing System. Danach kann der Installer das Entfernen seiner eigenen Einrichtungsdateien anbieten; das löscht nicht die installierte Lizenz.
5. Prüfe die Bestätigung der automatischen Paketinstallation: Pakete, Quellen und vorgeschlagene alte Dateien/Ordner zum Entfernen sind aufgelistet. Fahre fort, wenn dies beabsichtigt ist.
6. Warte auf Import und Kompilierung. Erfolgt die Installation nicht automatisch, öffne das Projekt in VCC oder ALCOM und füge **Kawaii Posing** und **Modular Avatar** hinzu. **Unisaki Posing System** und **NDMF** sind Abhängigkeiten. `Optional-VCC-Links` enthält die ursprünglichen Quellenverknüpfungen für Windows-VCC-Nutzer.
7. Nach abgebrochener Bestätigung importiere den Installer erneut, sobald du bereit bist. Solange der Aktivator vorhanden ist, kannst du dessen Lizenzbefehl unter **Tools > Unisaki Studio** verwenden. In älteren Builds heißt das Untermenü **ゆにさきスタジオ**.

### Was dieser Download installiert

**Kawaii Posing 3.2.0 mit Unisaki Posing System 3.2.0.** Diese Version ist in Entwicklung und noch nicht veröffentlicht. Sie ergänzt Installationsdialoge, Unity-Inspector und -Menüs, Standardposennamen, Spielmenüs und Offline-Dokumentation in dreißig Sprachen. Ein Termin steht noch nicht fest. Die Sprache wird oben im Inspector gewählt. Nach Veröffentlichung lädt der Installer diese Versionen und passende Abhängigkeiten aus VPM-Quellen. Lokale Release-Vorbereitung veröffentlicht keine Pakete.

Kawaii Posing enthält Posenbibliothek, Einstellungswerkzeuge und Avataranpassungsvoreinstellungen. Der Installer aktiviert die bestehende lokale Produktlizenz; es gibt kein neues Feld für Gumroad-Lizenzschlüssel. Veröffentliche niemals Installerdateien oder Lizenzdaten in öffentlichen Supportanfragen.

Sprachpräferenzen werden für den aktuellen Betriebssystembenutzer in Unity EditorPrefs gespeichert und zwischen Projekten dieses Computers geteilt. Ohne Auswahl folgt der Installer der Systemsprache; nicht unterstützte Sprachen verwenden Englisch. Produktlizenzen behalten ihre Speicherung im benutzerbezogenen Registry-Schlüssel `Software/UnisakiStudio` unter Windows beziehungsweise in Lizenzdateien unter macOS/Linux. Ein Sprachwechsel löscht keine Lizenz. Alle Posenwerkzeuge und Avatare verwenden dieselbe Sprache. Eine Änderung im Inspector eines beliebigen Werkzeugs aktualisiert die gemeinsame Einstellung; avatarbezogene Sprachauswahlen werden ignoriert. Die Sprachschaltfläche erscheint nur bei der ersten Installationsbestätigung, wenn noch keine Sprache gespeichert ist. Spätere Sprachänderungen erfolgen im Inspector.

## 2. Werkzeug einem Avatar hinzufügen

1. Wähle in der **Hierarchy** den Avatar mit **VRC Avatar Descriptor** oder ein Kindobjekt. Verwende einen Szenenavatar, nicht das Prefabasset im Project-Fenster oder den Prefab-Modus.
2. Rechtsklicke den Avatar und wähle **Unisaki Studio > Kawaii Posing hinzufügen**. Bei japanischen Menüs heißt dies **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Das Werkzeug wird im Avatar eingefügt. Der gespeicherte Objektname kann **可愛いポーズ** bleiben, obwohl die Anzeige übersetzt ist.
4. Wende bei Angebot eine passende Avatarvoreinstellung an. Sonst öffne **Avatareinrichtung** und wähle eine Voreinstellung oder passe selbst an.
5. Eine angebotene Vorberechnung ist optional; normale Builds erzeugen ebenfalls die Daten. Wiederverwendung verkürzt spätere Builds.
6. Wähle das Werkzeugobjekt, Posen und Funktionen und lade den Avatar normal über VRChat SDK hoch.

### Sprachauswahl und bekannte Beschriftungen

Diese Version bietet **Language / 言語** oben im Inspector. Die eine Auswahl steuert Inspector und erzeugtes Spielmenü. Der Avatar speichert sie; der letzte Wert gilt auch für andere Werkzeuge/Projekte dieses Computers. Für eine andere Sprache in VRChat lade den Avatar erneut hoch.

Die folgende Tabelle hilft bei älteren japanischen Anleitungen. Diese Version bietet Sprachauswahl, lokalisierten Inspector, übersetzte Standardposennamen und Spielmenüs in allen 30 Sprachen.

| Deutsch | Japanische Beschriftung älterer Builds |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funktionen | 機能 |
| Posen | ポーズ一覧 |
| Avatareinrichtung | アバター調整 |
| Einstellungen öffnen | 設定を開く |
| Vorberechnung aktualisieren | プレビルドを更新 |
| Einstellungen prüfen | 設定の確認 |
| Vorschau | プレビュー |
| Animationsanpassung | アニメーション調整 |
| Neu laden | 再読込 |

Inspector, Bearbeitungs-/Installationsdialoge, Standardposennamen und erzeugte Menüs sind für alle 30 Sprachen übersetzt. README, Änderungsverlauf und Offline-Anleitung stehen je Sprache bereit. Avatarnamen, gespeicherte Objektnamen, eigene Posennamen, Assetdateinamen und interne Parameterkennungen dürfen ihre ursprüngliche Schreibweise behalten.

Die [Kurzreferenzen in 30 Sprachen](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) erklären Funktionen und enthalten Standardposentabellen. Sie sind kompakte Nachschlagewerke; vollständige Dokumentation findest du über die Sprachübersicht.

## 3. Posen und Funktionen wählen

Der Inspector hat drei Hauptregister:

| Register | Zweck |
| --- | --- |
| **Funktionen** | Spielmenüs, optionale Abläufe, Atmung, Icons und Expression-Parameterverbrauch. |
| **Posen** | Aktive Posen, Kategorien/Suche, Reihenfolge, Animationsimport, Vorschau, Details und Animationsanpassung. |
| **Avatareinrichtung** | Avatar-/Kniekorrekturen, ursprüngliche/eigene Bewegungsübernahme und Voreinstellungen. |

Aktiviere nur benötigte Menüfunktionen. **Spiegeln** als Menüeintrag macht den Effekt in VRChat schaltbar; es zwingt nicht alle Posen dauerhaft in die gespiegelte Darstellung.

Kawaii Posing enthält Avatarvoreinstellungen und IK für unterstützte Posen. Drei Standardrückenlagen besitzen bereits Seitenbewegungen: **Beine ausgestreckt (足伸ばし)**, **Entspannt (リラックス)** und **Ein Knie hoch (膝立て)**. Verwende die passende Voreinstellung und prüfe die Einstellung für Umdrehen jeder bearbeiteten oder ersetzten Pose.

### Voreinstellungen und Anpassung

Voreinstellungen stehen unten unter **Avatareinrichtung**. Suche nach Avatarnamen und wende eine an, um aktuelle Poseneinstellungen zu ersetzen. Speichere oder sichere Anpassungen vorher. Voreinstellungen sind ein Ausgangspunkt; Proportionen, Kleidung und Änderungen können weitere Handkorrekturen erfordern.

Mit **Animationsanpassung** kannst du Körper und Gliedmaßen einer Pose ansehen und verändern. Speichere am Ende die Anpassungsanimation im Fenster. Unterstützte automatische Hand-/Fußanpassung (IK) ist global und je Pose schaltbar. Übernimmst du das aktuelle IK-Ergebnis, entsteht eine Anpassungsanimation und die IK der Pose wird zur manuellen Verfeinerung deaktiviert. Der Quellclip bleibt erhalten.

**Rückwärtsknicken der Knie verhindern** bietet weitere Optionen wie die minimale Kniebeugung. Avatarspezifische Korrekturen benötigen passende Daten; manche lassen sich nicht mit Posen-IK kombinieren.

### Ursprüngliche und eigene Bewegungen

**Ursprüngliche Steh-, Hock- und Bauchlage verwenden** erkennt beim Erzeugen Bewegungen aus Base. **Eigene Bewegungen verwenden** öffnet getrennte Importoptionen je Art. Wähle eine Bewegung je Art; manuelle Zuweisungen haben gegenüber der Automatik Vorrang.

Die Automatik arbeitet auf der Build-Kopie. Sie schreibt keine erkannten Animationen in manuelle Szeneneinstellungen und verändert keine Originalcontroller. Hebe eine manuelle Zuweisung auf, um diese Art wieder automatisch erkennen zu lassen. Eigene Base-Layer und andere Fortbewegungssysteme können individuelle Anpassungen brauchen.

## 4. In VRChat verwenden

Öffne **Expressions** deines Avatars und dann **Kawaii Posing**. Wähle eine Pose je gewünschter Haltungskategorie. Posen- und Funktionsauswahl sind getrennte Vorgänge.

- **Dreipunkt-VR:** senke oder hebe den Kopf für Stehen, Hocken/Stuhlsitzen, Bodensitzen und Liegen. Bei zu frühem/spätem Wechsel passe die Höhenschwellen im Menü an.
- **Desktop:** **C** zum Hocken und **Z** zum Liegen. Bleibst du mit Z sitzen, erhöhe die Liegehöhenschwelle.
- **Rücken-/Bauchlage:** Die Gesichtsrichtung bestimmt die Lage. Bei beiden gewählten Lagen kann Springen auf der Stelle wechseln. Deaktiviere dies bei Bedarf unter **Funktionen > Komfortfunktionen** in Unity; zusätzliche synchronisierte Bits benötigt es nicht.
- **Fixierungen:** Kopf, Arme und Füße nach Bedarf fixieren. Gesten deaktivieren verwendet die Posenhandform statt Controllereingabe.
- **Spiegeln:** Kehre eine Pose um, um einem Freund gegenüberzustehen oder die Bildkomposition anzupassen.

### Fußhöhe und Bodenhöhe

**Fußhöhe** passt die Füße bei gleichbleibender Kopfposition an. Verwende sie bei schwebenden oder eingesunkenen Füßen, wenn der Kopf bereits richtig liegt.

**Bodenhöhe** bewegt den ganzen Körper einschließlich Kopf. Nutze sie für Sofa, Bett oder erhöhte Flächen, auch ohne Collider. Beim aktuellen zentrierten Regler gilt **50% als ursprüngliche Höhe**, 0% liegt 3 m darunter und 100% 3 m darüber. Kehre nahe 50% zurück, um den Versatz zu beenden. Ältere Versionen können anders arbeiten; prüfe die installierte Version und aktualisiere gemeinsames System und Produkt zusammen.

### Fotomodus

Aktiviere das Menü **Fotomodus** in Unity vor dem Upload. Wähle in VRChat eine Pose, bewege mit **Abstand** bis 3 m vorwärts und drehe mit **Richtung**. Die Fußfixierung ist beim Einrichten optional. **Foto beenden** setzt Abstand/Drehung zurück und löst die Füße.

Fotomodus ist anfangs nur lokal. Damit andere Position und Drehung sehen, aktiviere vor dem Upload **Fotomodus synchronisieren**; das benötigt 16 synchronisierte Bits. **Kopf im Fotomodus sichtbar halten** betrifft nur deine Ansicht und kostet keine synchronisierten Bits.

### Atmung und Umdrehen

Atmung ist je Kategorie unter **Funktionen > Komfortfunktionen > Atmung animieren** einstellbar: Keine, Schwach, Mittel, Stark, Schnell oder eigene Animation. Die Bewegung kostet keine synchronisierten Bits; ein Menüschalter benötigt 1 bit.

Umdrehen benötigt eine unterstützte Liegepose und den Menüeintrag **Umdrehen**. Aktiviere es für die Pose und weise bei Bedarf eine Seitenanimation zu. Wähle sie in VRChat, aktiviere Umdrehen und löse Kopf-/Halsfixierung. Seitliche Kopfneigung steuert die Bewegung. Normales MotionTime ist für diese Pose währenddessen nicht verfügbar.

Die drei genannten Standardrückenlagen enthalten Seitenbewegungen. Andere Posen benötigen passende Animationen und Einstellungen. Importierte oder eigene Voreinstellungen können abweichende Zuweisungen besitzen.

## 5. Posen bearbeiten, hinzufügen und ansehen

Wähle unter **Posen** eine Kategorie oder das Suchregister. Suche erkennt ursprüngliche japanische Namen und vorhandene Übersetzungen. Unter **Details** änderst du Animation, Icon, Reihenfolge und Zeitoptionen.

Ziehe mehrere Clips in den Hinzufügebereich oder wähle sie in Project und nutze den Importbefehl für ausgewählte Clips. Doppelte Verweise auf denselben Clip werden entfernt. Ändere die Zielreihenfolge in Details oder mit den Auf-/Ab-Schaltern.

**Vorschau** zeigt die Pose in der Scene ohne vollständiges Anpassungsfenster. Sie führt weder Modular Avatar noch NDMF aus; prüfe deshalb endgültige Kleidung, Bodenkorrektur und andere Build-Funktionen nach dem Avatar-Build.

Aus dem Avatar erzeugte Posen-Icons helfen beim Erkennen, kosten aber Zeit und möglicherweise Speicher. Senke die Auflösung zum Sparen. Android-Builds erzeugen keine Posen-Icons. Erzeuge sie bei Bedarf nach Avatar-/Kleidungsänderungen neu.

## 6. Parameterspeicher

Der Inspector zeigt nur den Anteil der Posenwerkzeuge, nicht den Gesamtverbrauch des Avatars. Kleidung und andere Systeme können mehr Speicher brauchen. Gemeinsame Optionen mehrerer Werkzeuge zählen nicht doppelt. Viele zusätzliche eigene Posen können weitere Auswahlbits benötigen.

| Funktion | Zusätzliche synchronisierte Bits |
| --- | ---: |
| Posenauswahl, minimale Standardkonfiguration | 8 |
| Spiegeln | 1 |
| Gesten aus | 1 |
| Atembewegung | 0 |
| Atmungsmenüschalter | 1 |
| Fußhöhe | 8 |
| Bodenhöhe | 8 |
| Fotomodus nur lokal | 0 |
| Fotomodus synchronisieren | 16 |
| Kopf im Fotomodus sichtbar halten | 0 |
| VRChat-Schwanken im Stand deaktivieren | 0 |
| Umdrehen | 10 |

Umdrehen teilt 1 bit mit der Korrektur halsrichtungsbedingter Verformungen. Beide zusammen benötigen daher weiterhin 10 bit. Der Verbrauch deiner installierten Version ist der praktische Bezug für die gewählte Konfiguration.

## 7. Aktualisierung und Vorberechnung

1. Sichere das Projekt und speichere die Arbeitsszene.
2. Aktualisiere **Kawaii Posing** und **Unisaki Posing System** gemeinsam in VCC oder ALCOM. Achte auch auf passende SDK-, Modular Avatar- und NDMF-Versionen.
3. Warte auf die Kompilierung, wähle das installierte Werkzeug und prüfe Posen, Einstellungen und Verbrauch.
4. Bei verwendeter Vorberechnung wähle **Vorberechnung aktualisieren** und lade erneut hoch.

Bestehende Werkzeugeinstellungen bleiben erhalten. Alte 8-bit-Prefabs bleiben kompatibel; vorhandene Referenzen erfordern kein Löschen oder Ersetzen. Neue Installationen verwenden das normale Prefab; nicht benötigte Funktionen lassen sich zum Sparen von Parametern abschalten.

Eine Warnung zu veralteter Vorberechnung bedeutet geänderte Einstellungen seit Erzeugung der Cache-Daten. Aktualisieren erzeugt diese Daten neu. Ausblenden erneuert nichts und behebt die Ursache nicht. Normale Builds können nötige Daten auch ohne jedes Mal manuell ausgeführte Vorberechnung erzeugen.

## 8. Fehlerbehebung

| Symptom | Prüfen |
| --- | --- |
| Kein Hinzufügemenü | Produkt **und** Unisaki Posing System müssen installiert und Unity-Kompilierfehler behoben sein. Der Lizenzinstaller allein ist nicht die Posenbibliothek. |
| Installer abgebrochen/Dateien entfernt | Importiere den gekauften Installer erneut, sobald du bereit bist, und lies die Bestätigungen. |
| Lizenz fehlt scheinbar in anderem Projekt | Importiere mit demselben Betriebssystemkonto. Bei neuem PC/Konto installiere dort ebenfalls die Lizenz. Sprachpräferenzen wechseln nicht automatisch zwischen PCs. |
| Keine Posen in VRChat | Werkzeug unter dem richtigen Szenenavatar hinzufügen, Posen aktivieren, Warnungen prüfen und diesen Avatar hochladen. SDK und andere Fortbewegungswerkzeuge prüfen. |
| Z erreicht keine Liegehaltung | Liegehöhenschwelle im Spiel erhöhen. |
| Hände/Knie passen nicht | Passende Voreinstellung testen, dann unterstützte IK und/oder Animationsanpassung. Kleidung im endgültigen Build prüfen. |
| Umdrehen funktioniert nicht | Unterstützte Liegepose wählen, Posenoption und Menü aktivieren, Kopf/Hals lösen. Zunächst eine der drei unterstützten Standardposen testen. |
| Freunde sehen Fotobewegung nicht | **Fotomodus synchronisieren** in Unity aktivieren, Verbrauch prüfen und erneut hochladen. |
| Sprache nur in Unity geändert | Avatar erneut hochladen und in mehrsprachigen Builds den einzigen Sprachwähler oben prüfen. |
| Build-/Vorberechnungsfehler | **Ersten** relevanten Console-Fehler lesen. Szene sichern, Produkt und System mit VCC/ALCOM aktualisieren oder erneut beziehen und bei Fortbestehen Support kontaktieren. Angepasste Objekte und GeneratedResources behalten, außer Support nennt einen konkreten Wiederherstellungsschritt. |

Für Support nenne Produkt-/Systemversion, Unity/SDK/Modular Avatar/NDMF, Avatarname, genaue Schritte und den relevanten Console-Fehler. Entferne private Dateien, Installerinhalte, Lizenzwerte und Kontodaten aus öffentlichen Beiträgen.

- [Support](https://help.unisakistudio.jp/)
- [Bebilderte Online-Anleitung (Japanisch)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Gumroad-Produktseite](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Lizenzen und Danksagungen

Eine [englische Referenzübersetzung der Produktbedingungen](../../Terms.en.html) liegt neben dem japanischen Original bei.

Lies Originalbedingungen von Produkt und gemeinsamem System neben der Paket-README oder im Ordner `Licenses` des gekauften ZIPs. Die englischen Unisaki Posing System-Bedingungen sind eine bestehende Referenzübersetzung dieses Systems; japanische Produktbedingungen liegen separat bei. Diese Anleitung ändert keine Vereinbarungen und erteilt keine zusätzlichen Rechte. Fragen zu Nutzung oder Weitergabe von Produktdaten bitte an Support richten.

Der Installer enthält ein angepasstes **VPMPackageAutoInstaller** von **anatawa12**, mit **SimpleJson** und **semver.net**. Copyrightvermerke und MIT-Lizenztexte stehen in `ThirdPartyNotices.txt` im gekauften ZIP. Posenbibliothek und andere Produktressourcen haben eigene Produktlizenzen.
