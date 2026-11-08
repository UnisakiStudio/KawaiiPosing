# Kawaii Posing

Posenwerkzeug für VRChat mit niedlichen Sitz- und Liegehaltungen für Dreipunkt-Tracking und Desktop. Enthalten sind 85 Posen: 15 Steh-, 20 Hock-, 17 Sitz-, 16 Bauch- und 17 Rückenlagen.

Diese README betrifft die in Entwicklung befindliche v3.2.0. Ein Veröffentlichungstermin steht noch nicht fest. Die installierte Version steht oben im Inspector.

- [Produktseite auf BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Änderungsverlauf](CHANGELOG.md)

## Anzeigesprache und Offline-Dokumentation

Wähle die Anzeigesprache oben im Inspector unter „Language / 言語“. Die Auswahl gilt zugleich für den Inspector und die erzeugten VRChat-Menüs. Lade den Avatar erneut hoch, um die Sprache im Spiel zu ändern.

Ohne ausdrückliche Auswahl wird die Computersprache verwendet; nicht unterstützte Sprachen verwenden Englisch. Windows, macOS und Linux werden unterstützt. Die letzte Auswahl wird in EditorPrefs gespeichert und für andere Projekte desselben Betriebssystembenutzers auf diesem Computer wiederverwendet. Eine bereits ausdrücklich im Avatar gespeicherte Auswahl bleibt erhalten. Andere Computer werden nicht synchronisiert. Die Lizenzspeicherung bleibt unverändert.

README, Änderungsverlauf und Anleitung sind über die mitgelieferte [Sprachübersicht](../index.html) erreichbar. Auch die Verweise auf Anleitung und Änderungen im Inspector folgen der Auswahl. Die ursprünglichen Nutzungsbedingungen und ihre Referenzübersetzungen bleiben separat verfügbar.

## Hauptfunktionen

- Fotomodus: Avatar bis 3m vorwärts bewegen und drehen. 0 bit nur in eigener Ansicht, 16 bit für die Anzeige von Position und Richtung bei anderen.
- Kopf beim Fotografieren sichtbar: verhindert nur im Fotomodus das Ausblenden des eigenen nahen Avatarkopfes.
- Bodenhöhe: bewegt den ganzen Körper einschließlich Kopf 3m auf oder ab. 50% ist ursprüngliche und anfängliche Höhe, 0% 3m darunter, 100% 3m darüber. Getrennt von Fußhöhe, die die Fußseite bei fester Kopfposition verändert.
- Umdrehen: in unterstützten Liegeposen durch Kopfneigung nach links oder rechts rollen.
- Atmung: Brust und weitere Teile animieren; je Kategorie Keine, Schwach, Mittel, Stark, Schnell oder Benutzerdefiniert wählen.
- VRChat-Schwanken im Stand deaktivieren: normale Leerlaufbewegung unterdrücken, während Werkzeugatmung und eigene Bewegungen erhalten bleiben.
- Verformungen durch Kopfdrehung verringern: nach dem Lösen der Halsfixierung Verformungen durch eine vom Original abweichende Halsrichtung verringern.
- Funktionsauswahl: nur gewünschte Spielmenüs ergänzen und ExpressionParameters-Verbrauch prüfen.
- Suche, Mehrfachimport und Sortieren der Posen: kategorienübergreifend suchen, mehrere Clips übernehmen und Zielreihenfolge wählen.
- Einfache Scene-Vorschau: Posen direkt über „Vorschau“ in der Liste ansehen.

- Automatische Gliedmaßenanpassung (IK): passt unterstützte Posen an den Avatarbau an. Pro Pose schaltbar, Ergebnisse in Anpassungsanimation übernehmbar.

### Mit enthaltenen Posen umdrehen

Die Rückenlagen „Beine ausgestreckt“, „Entspannt“ und „Ein Knie hoch“ besitzen bereits Seitenbewegungen. Ihre Bewegungen zum Umdrehen basieren auf der Seitenliegepose „横向き寝“, „Nickerchen“ beziehungsweise „Katzennickerchen“.

Aktiviere „Funktionen > Menüfunktionen > Umdrehen“ und lade hoch. Wähle in VRChat eine unterstützte Pose und „Umdrehen“. Löse die Halsfixierung.

Für eigene Konfiguration aktiviere „Posen > Details > Umdrehen aktivieren“ und weise „Seitliche Umdrehpose“ eine Animation zu. Normales MotionTime steht für diese Pose dann nicht zur Verfügung.

### Anpassung an den Körperbau

Die mitgelieferte automatische Anpassung ist nutzbar, aber nicht jede Pose benötigt IK. „Automatische Gliedmaßenanpassung aktivieren“ im Anpassungsfenster gilt insgesamt, „IK für diese Pose aktivieren“ nur einzeln.

„IK in Anpassungen übernehmen“ schreibt das aktuelle automatische Ergebnis in eine neue Anpassungsanimation und deaktiviert die IK der Pose. Danach kannst du manuell verfeinern. Globale und posenspezifische Automatik müssen aktiv und anwendbare IK-Einstellungen vorhanden sein.

„Avatareinrichtung“ enthält außerdem „Rückwärtsknicken der Knie verhindern“ und in den Details „Minimale Kniebeugung (Grad)“.

## Installation

1. Lade die Dateien von der Produktseite deines Shops herunter.
2. Importiere „可愛いポーズツール.unitypackage“ in Unity und registriere Lizenz sowie Paketquelle.
3. Füge in VCC oder ALCOM Kawaii Posing und Modular Avatar zum gewünschten Projekt hinzu. Unisaki Posing System und NDMF werden als Abhängigkeiten installiert.
4. Klicke in der Hierarchy mit rechts auf den Avatar und wähle „Unisaki Studio > Kawaii Posing hinzufügen“.
5. Wähle Kawaii Posing im Avatar aus und stelle Funktionen und Posen im Inspector ein.
6. Lade den Avatar normal hoch.

Benötigt werden Unity 2022.3, VRChat Avatars SDK ab 3.10.4, Modular Avatar 1.x ab 1.15.1 und NDMF 1.x ab 1.14.0. Aktualisiere erforderliche Pakete gemeinsam mit VCC oder ALCOM.

## Aktualisierung älterer Versionen

Aktualisiere Produkt und Unisaki Posing System zusammen. Einstellungen bereits platzierter Werkzeuge bleiben erhalten. Prüfe Funktionen und Parameterverbrauch im Inspector; bei genutzter Vorberechnung klicke vor dem erneuten Upload auf „Vorberechnung aktualisieren“.

Seit v3.1.0 verwenden neue Installationen das normale 「可愛いポーズ」-Prefab. Mit unnötigen Funktionen deaktiviert benötigt die minimale Posenauswahl 8 bit. Viele Posen können zusätzliche Auswahlbits erfordern.

Alte 8bit-Prefabs bleiben unter „Editor/Legacy“, damit Referenzen bestehender Avatare und Voreinstellungen erhalten bleiben. Lösche oder ersetze bestehende Prefabs nicht. Das neue Hinzufügen bietet keine 8bit-Version an.

## Wo du Einstellungen findest

| Register | Möglichkeiten |
| --- | --- |
| Funktionen | Spielmenüs, Komfortfunktionen, Atmung, Icons und ExpressionParameters-Verbrauch |
| Posen | Auswahl, Details, Suche, Mehrfachimport, Reihenfolge, Vorschau und Animationsanpassung |
| Avatareinrichtung | Avatar- und Kniekorrekturen, ursprüngliche/eigene Bewegungen übernehmen und Voreinstellung wechseln |

Der Einstellungslink öffnet Details unter dem jeweiligen Eintrag. Atmung findest du unter „Funktionen > Komfortfunktionen > Atmung animieren“.

„Ursprüngliche Steh-, Hock- und Bauchlage verwenden“ übernimmt bestehende Avatarhaltungen automatisch. Eigene Bewegungen weist du separat in den Importoptionen je Art zu, etwa Stehen, Hocken (Crouching) oder Bauchlage (Prone).

Voreinstellungen stehen ganz unten unter „Avatareinrichtung“. „Diese Voreinstellung anwenden“ ersetzt die aktuelle Poseneinrichtung; speichere bestehende Anpassungen vorher.

### Verbrauch je Funktion

- Atembewegung benötigt 0 bit. Nur „Menüfunktionen > Atmung“ zum Anhalten/Fortsetzen im Spiel benötigt 1 bit für die Synchronisierung.
- Fotomodus benötigt 0 bit nur lokal; „Komfortfunktionen > Fotomodus synchronisieren“ benötigt 16 bit. „Kopf im Fotomodus sichtbar halten“ benötigt 0 bit.
- Fußhöhe und Bodenhöhe benötigen je 8 bit. Bodenhöhe außerhalb der Mitte bewegt den Avatar auf/ab; nahe 50% endet die Korrektur.
- Umdrehen benötigt allein 10 bit. Es teilt 1 bit mit „Verformungen durch Kopfdrehung verringern“, daher benötigen beide zusammen ebenfalls 10 bit.
- Spiegeln und Gesten aus benötigen je 1 bit.

Der Inspector-Gesamtwert umfasst die Posenwerkzeuge im Avatar, nicht Kleidung oder andere Systeme. Gemeinsam verwendete Einstellungen mehrerer Werkzeuge werden nicht doppelt gezählt.

### Vorschau und Posenbearbeitung

„Vorschau“ bei einer Pose zeigt sie in der Scene. Für genaue Änderungen öffne „Animationsanpassung“, korrigiere mit Vorschau und speichere.

Die einfache Vorschau führt MA oder NDMF nicht aus. Prüfe daher vor dem Upload auch das Build-Ergebnis für dort eingefügte Kleidung und Bodenkorrekturen.

Das Lupenregister links sucht Posennamen. Sortiere über „Details > Reihenfolge“ oder Auf-/Ab-Schaltflächen. Mehrere Animationen lassen sich hineinziehen oder über „In Project gewählte Clips übernehmen“ hinzufügen.

„Posenvorschaubilder aktualisieren“ erzeugt Bilder nach einer Bestätigung. „Posen-Icons erzeugen“ erleichtert die Auswahl im Spiel, verlängert aber die Build-Dauer. Nutze „Icongröße verringern“ zum Sparen von Speicher. Android erzeugt keine Posen-Icons.

## Grundlegende Bedienung im Spiel

- Wähle im Expressions-Menü Posen je Kategorie. In VR bestimmt die Kopfhöhe den Wechsel zwischen Stehen, Hocken, Sitzen und Liegen.
- Im Liegen entscheidet die Blickrichtung zwischen Rücken und Bauch. Sind beide Posen gewählt, ist auch Springen auf der Stelle möglich. Unter „Funktionen → Komfortfunktionen → Liegepose durch Springen wechseln“ ist dies abschaltbar (anfangs aktiv). Die Schwellenwerte im Einstellungsmenü bestimmen die Wechselhöhen.
- Im Desktop wechselst du mit C und Z. Wenn Z keine Liegehaltung erreicht, erhöhe den Liegehöhenschwellenwert.
- „Gesten aus“ verwendet die Hände der Pose statt der Controller-Fingerhaltung.
- Fußhöhe verändert die Fußseite bei fester Kopfposition; Bodenhöhe bewegt den ganzen Körper samt Kopf. Sie stehen in dieser Reihenfolge im Menü.
- Bewege im Fotomodus den Abstand vorwärts, damit der Avatar zu dir blickt. Drehe ihn mit „Richtung“ und aktiviere „Füße fixieren“ zum gewünschten Zeitpunkt. „Foto beenden“ setzt Abstand/Richtung zurück und löst die Füße.
- Atmung ist bei aktiver Atembewegung verfügbar. Die Stärke stellst du in Unity ein, im Spiel schaltest du sie ein oder aus.

## Vorberechnung und Warnungen

„Vorberechnung aktualisieren“ nutzt erzeugte Daten erneut, um Avatar-Builds zu beschleunigen. Ohne Vorberechnung erzeugt der normale Build alle erforderlichen Daten.

Nach Einstellungsänderungen melden „Einstellungen prüfen“ oben und Hierarchy-Markierungen nötige Aktualisierungen. Die Warnanzeige-Einstellungen liegen im Prüfbereich. Ausblenden behebt keine Probleme und erneuert keine Daten.

## Nutzungshinweise

- Posenfixierung mit Ganzkörper-Tracking wird nicht unterstützt.
- Körperbau, Kleidung und Avataränderungen können weitere Anpassungen erfordern.
- Besondere Base-Layer oder andere Haltungssysteme können sich unerwartet verhalten. Bei Fixierungsproblemen prüfe „Avatareinrichtung > Tracking-Fixierungen mit anderen Werkzeugen integrieren“.
- Fotomodus und Bodenhöhe korrigieren auch normale/eigene Bewegungen ohne gewählte Pose. Prüfe Blickposition und Verhalten ersetzter Standardbewegungen im VRChat-Client.
- „VRChat-Schwanken im Stand deaktivieren“ betrifft Standardleerlauf, nicht sämtliche anderen Bewegungsursachen.

## Anleitung und Support

Über „Hilfe / Änderungen“ oben im Inspector öffnest du Anleitung, Support und Verlauf. Gemeinsame Funktionen sind auch unter „Packages > Unisaki Posing System > README“ im Unity-Project-Fenster erklärt.

- [Offizielle Anleitung](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Support](https://help.unisakistudio.jp/)

Gib bei Fehlermeldungen die Versionen des Produkts und Unisaki Posing System, Unity, VRChat SDK, Modular Avatar und NDMF, den Avatar, Reproduktionsschritte und die Console-Fehler an.

## Voreinstellungen weitergeben

Hinweise zu mit der Animationsanpassung erstellten Daten.

Du darfst mit dieser Funktion erstellte Anpassungsanimationen sowie damit eingerichtete Voreinstellungen
ohne Erlaubnis von Unisaki Studio frei weitergeben und verkaufen.
Teile sie gerne etwa mit eigenen Avataren oder als Voreinstellungen für nicht mitgelieferte Avatare.

## Produkte mit mitgelieferter Integration

Die Integrationseinstellungen wurden allein von unserem Shop erstellt. Wir haben keine Erlaubnis der jeweiligen Produktautoren eingeholt, da wir sie hierfür nicht für erforderlich halten.
Wünsche zur Verteilung oder zur Einstellung der Verteilung bitte per Shop-Nachricht senden.
Für die Integration musst du das jeweilige Produkt kaufen und herunterladen.
Bei Problemen mit den Einstellungen kontaktiere unseren Shop, nicht die anderen Produktautoren.

„可愛い座りツール“
https://yunisaki.booth.pm/items/3611536

„添い寝ツール“
https://yunisaki.booth.pm/items/3670993

„少女モーション集vol.1“ von ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

„VRC想定移動モーション（無料配布）“ von カトのVRC道具屋
https://booth.pm/ja/items/1285101

„ごろ寝システムEX“ von minminmart
https://minminmart.booth.pm/items/4233545

## Nutzungsbedingungen

Dieses Werkzeug darf nur nutzen, wer den folgenden mit der VN3-Lizenz erstellten Bedingungen zustimmt.

[Nutzungsbedingungen (Japanisch)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Quellcode und Ressourcen dieses Repositorys sind nicht Open Source. Regulärer Produktkauf und Zustimmung zu den Nutzungsbedingungen sind erforderlich.

[Nutzungsbedingungen (Englisch)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
