# Historia zmian

## [3.2.0] - Niewydane

### Dodano

- Wyświetlanie Inspectora, operacji edycji, okien instalacji, standardowych nazw poz i generowanego menu VRChat w 30 językach.
- Połączono wybór języka Inspectora i menu gry. Domyślnie używany jest język komputera, a ostatni wybór dotyczy także innych projektów tego samego użytkownika systemu.
- README, historia zmian i instrukcja offline otwierają się w wybranym języku.
- Przygotowano nazwy wszystkich 128 standardowych poz i opisy funkcji zgodnie z dotychczasową terminologią.

### Zgodność

- Zachowywane są istniejące ustawienia awatara, własne nazwy, odwołania do zasobów, identyfikatory parametrów i sposób przechowywania licencji.

## [3.1.2] - 2026-11-09

- Blokadę głowy można przełączać w „Ustawienia → Automatyczna blokada głowy na plecach” menu EX nawet po wyłączeniu wysokości stóp. Pozycja znikająca w dawnych wersjach wraca po zbudowaniu zaktualizowanego awatara.
- Dodano obsługę Unisaki Posing System 3.1.2. Naprawiono pozostawanie twarzy skierowanej w górę po wstaniu z brzucha przy ograniczaniu deformacji pozy od obrotu głowy.

Zaktualizuj Kawaii Posing Tool do 3.1.2 w ALCOM / VCC. Wymagany jest także Unisaki Posing System 3.1.2. Jeśli korzystano z budowania wstępnego, naciśnij Aktualizuj budowanie wstępne, zapisz scenę, a następnie ponownie zbuduj i prześlij awatara.

## [3.1.1] - 2026-11-08

- Włączone Wysokość ziemi i Obróć się są teraz widoczne w Ustawieniach menu EX VRChat także po wyłączeniu Odbicia.
- Po przestawieniu, usunięciu lub zmianie nazw poz w starej wersji zachowywane są właściwe obroty dla Nogi w przód, Relaks i Jedno kolano w górę. Działa to także po pełnym Unpack, jeśli można rozpoznać oryginalną pozę. Własne pozy, samodzielnie wyłączone obracanie i zastąpione ruchy boczne pozostają.
- Naprawiono chwilową pozycję na brzuchu podczas wybierania awatara w VRChat. Naprawiono też chwilowe leżenie na plecach przy skoku, gdy wybrano tylko brzuch. Przełączanie skokiem można wyłączyć przez „Funkcje → Udogodnienia → Zmieniaj pozycję leżącą skokiem”. Domyślnie jest włączone.
- Jeśli po aktualizacji odłączy się odwołanie do wspólnego Animator Controllera poz i da się je odtworzyć, pokazywane jest ostrzeżenie, a Controller powstaje ponownie z ustawień. Zachowywane są odwołania do Controllera wspólnego dla kilku awatarów.
- Menu dodawania narzędzia umieszcza teraz oficjalny Prefab nawet wtedy, gdy zapisano własny Prefab 可愛いポーズ (Kawaii Posing) o takiej samej nazwie.
- Jeśli podczas dodawania Sleep-together tool nie znaleziono wymaganego produktu integracji, wskazywany jest produkt do zainstalowania najpierw.

Zaktualizuj Kawaii Posing Tool i Unisaki Posing System do 3.1.1 w ALCOM / VCC. Jeśli korzystano z budowania wstępnego, wybierz 可愛いポーズ (Kawaii Posing) w scenie, naciśnij Aktualizuj budowanie wstępne i zapisz scenę. Ponownie zbuduj i prześlij awatara, aby zmiany były widoczne w VRChat.

## [3.1.0] - 2026-11-07

- W 53 z 85 dołączonych poz kończyny są automatycznie dopasowywane do budowy awatara za pomocą IK.
- Pozy na plecach Nogi w przód, Relaks i Jedno kolano w górę obsługują obracanie sterowane przechyleniem głowy.
- Tryb zdjęć pozwala zmieniać pozycję i kierunek awatara. Można wybrać synchronizację pozycji i kierunku oraz widoczność własnej głowy podczas zdjęć.
- Wysokość ziemi przesuwa całe ciało do 3m w górę lub w dół, uzupełniając wysokość stóp.
- Dodano oddech, wyłączanie standardowego kołysania w spoczynku i ograniczanie deformacji pozy od kierunku głowy.
- Używane funkcje i zużycie parametrów są widoczne w Inspectorze. Dodano wyszukiwanie poz, dodawanie zbiorcze, sortowanie i uproszczony podgląd w Scene.
- Przyspieszono zmiany między staniem, kucaniem i siedzeniem w trybie pulpitu.
- Poprawiono ostrzeżenia po zmianie ustawień budowania wstępnego, obciążenie przewijaniem Inspectora i długie zatrzymania przy porządkowaniu zasobów.
- Dodano obsługę Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Otwarta beta (2026-11-05)

- Rozpoczęto udostępnianie otwartej bety przez GitHub Releases i VPM. W 53 z 85 dołączonych poz kończyny są dopasowywane do budowy ciała przez IK.
- Dodano obsługę wspólnego pakietu 3.1.0-beta.2. Poprawiono pokazywanie zmian po budowaniu wstępnym, koszt przewijania Inspectora i zatrzymania podczas porządkowania zasobów.

## [3.1.0-beta.1] - Otwarta beta (2026-11-04)

- Dodano obsługę Unisaki Posing System 3.1.0-beta.1.
- Zwykłe przełączanie poz w trybie pulpitu używa jednego obliczenia. Działa przy zwykłym budowaniu i budowaniu wstępnym; VR i szczególne warunki zachowują dotychczasową ścieżkę.
- Wyniki budowania wstępnego z alpha.3 i starszych wersji są rozpoznawane jako wymagające aktualizacji.
- Punkt widzenia pozostaje zachowany przy zmianie wysokości ziemi podczas zdjęć, a po zakończeniu wraca do ostatniej wysokości ziemi.
- Uwzględniono poprawki automatycznego importu, dostosowania importowanych ruchów i zarządzania generowanymi Controllerami do alpha.3 włącznie.

## [3.1.0-alpha.2] - Zamknięta wersja testowa (2026-10-26)

### Poprawki i zmiany

- Zaktualizowano wspólny system poz do 3.1.0-alpha.2 z poprawkami debugowania.
- Rozszerzono wysokość ziemi do 3m w górę i w dół. 50% to pierwotna wysokość i wartość początkowa.
- Standardowe i własne ruchy bez wybranej pozy również objęto korekcją zdjęć i wysokości ziemi.
- Naprawiono problemy korekcji ręcznej, poz o tej samej nazwie, pozy początkowej, ustawień obracania starych presetów i inne.

## [3.1.0-alpha.1] - Przed publikacją

### Dodano

- Dodano automatyczną korekcję kończyn (IK) do budowy ciała.
- Dodano ogólny i indywidualny przełącznik IK oraz zapis wyniku do animacji korekcji.
- Pozy na plecach Nogi w przód, Relaks i Jedno kolano w górę obsługują obracanie przechyleniem głowy.
- Dodano ustawienia obracania dla każdej pozy i przypisanie animacji bocznej.
- Dodano tryb zdjęć do przesuwania do przodu i obracania.
- Dodano synchronizację trybu zdjęć: tylko lokalnie — 0 bit, synchronizacja — 16 bit.
- Dodano zachowanie widoczności własnej głowy w trybie zdjęć.
- Dodano Wysokość ziemi, podnoszącą całe ciało wraz z głową.
- Dodano ruch i siłę oddechu oraz przełącznik w grze.
- Dodano wyłączanie standardowego kołysania VRChat.
- Dodano ograniczanie deformacji pozy od kierunku głowy.
- Dodano zapobieganie wyginaniu kolan do tyłu i minimalny kąt zgięcia.
- Dodano przełączniki funkcji i widok zużycia ExpressionParameters.
- Dodano uproszczony podgląd w Scene, wyszukiwanie poz, dodawanie zbiorcze i wybór docelowej kolejności.
- Dodano historię zmian w Inspectorze.

### Zmieniono

- Inspector podzielono na 3 karty: Funkcje, Pozy i Konfiguracja awatara.
- Uporządkowano miejsca szczegółów oddechu, importu własnych ruchów i presetów.
- Ograniczono powielanie animacji tworzonych do regulacji wysokości stóp.
- Dodano potwierdzenie aktualizacji obrazów poz i zebrano ustawienia ostrzeżeń w Sprawdź ustawienia.
- Usunięto menu nowego dodawania wersji 8bit, zastępując je wyborem funkcji zwykłego Prefabu. Istniejące odwołania pozostają.
- Dodano obsługę Unisaki Posing System 3.1.0-alpha.1. Minimalną wersję VRChat Avatars SDK zmieniono na 3.10.4.

### Naprawiono

- Naprawiono przechodzenie wpisywanej nazwy do innej pozy oraz zamykanie szczegółów przy sortowaniu.
- Naprawiono nakładanie podglądów, przesunięcia rozmieszczenia i błędy niektórych awatarów.
- Naprawiono odświeżanie ostrzeżeń i stanu budowania wstępnego po zmianach ustawień oraz niektóre błędy budowania.

## [3.0.13] - 2026-09-22
- Zaktualizowano do PosingSystem 3.0.17 i naprawiono poziome przesunięcie poz po równomiernej zmianie skali całego awatara
- Dodano ustawienia ignorowania ostrzeżeń o automatycznym stąpaniu, braku budowania wstępnego i zmianie ustawień osobno lub razem
- Naprawiono import niewłaściwych pojedynczych animacji podczas ręcznego importowania ruchów lokomocji

## [3.0.12] - 2026-09-15
- Dodano preset awatara (ルリエ)

## [3.0.11] - 2026-09-09
- Dodano presety awatarów (メルヴィ, ミダリス)
- Naprawiono zastępowanie ruchów presetu うらら

## [3.0.10] - 2026-08-31
- Zaktualizowano do PosingSystem 3.0.11 i naprawiono błędy budowania wstępnego z najnowszym NDMF oraz wyjątek podczas wyświetlania błędów

## [3.0.9] - 2026-08-29
- Zaktualizowano do PosingSystem 3.0.10 i ograniczono koszt wczytywania presetów oraz oceny ikon Hierarchy
- Naprawiono błąd budowania wstępnego kilku systemów poz w jednym awatarze

## [3.0.8] - 2026-08-26
- Zaktualizowano do PosingSystem 3.0.9 i naprawiono nieprawidłowy Avatar podglądu po NDMF, powodujący błąd `Avatar is null` w Play

## [3.0.7] - 2026-08-18
- Zaktualizowano do PosingSystem 3.0.8 i naprawiono możliwe uszkodzenie danych poz przy ponownej korekcji wysokości

## [3.0.6] - 2026-08-12
- Dodano presety awatarów (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ)

## [3.0.5] - 2026-03-17
- Dodano presety awatarów (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール)

## [3.0.4] - 2026-01-31
- Dodano presety awatarów (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing)

## [3.0.3] - 2026-01-11
- Poprawiono funkcje instalacji i usuwania licencji

## [3.0.2] - 2026-01-04
- Naprawiono obsługę licencji w wersjach Mac i Linux

## [3.0.1] - 2025-12-28
- Dodano presety awatarów (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ)

## [3.0.0] - 2025-12-28
- Dodano budowanie wstępne
- Dodano dostosowywanie animacji
- Dodano presety
- Produkt można teraz dodać do projektu przez unitypackage
- Dodano presety awatarów (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ)

## [2.2.5] - 2025-05-08
- Rozwiązano problemy zgodności z niektórymi funkcjami awatara

## [2.2.4] - 2025-04-04
- Naprawiono brak zmiany poz z niektórymi awatarami i wersjami ModularAvatar

## [2.2.3] - 2025-03-13
- Naprawiono nieprawidłowe ruchy niektórych awatarów, np. skok 森羅
- Naprawiono czasami niewłaściwą wartość początkową Bez gestów

## [2.2.2] - 2025-03-06
- Naprawiono błąd w niektórych środowiskach

## [2.2.1] - 2025-02-05
- Naprawiono awarie Unity
- Dodano wersję do nazwy narzędzia w NDMF Console

## [2.2.0] - 2025-02-02
- Dodano opcję wyłączenia gestów i używania kształtu dłoni z animacji
- Dodano dane kształtu dłoni do wszystkich poz

## [2.1.6] - 2025-02-02
- Naprawiono psucie poz z niektórymi narzędziami
- Naprawiono błędy zależne od ustawień

## [2.1.5] - 2024-12-10
- Usunięto konflikty z niektórymi funkcjami awatara
- Dodano przycisk usuwania wersji Unitypackage
- Wydano wersję VCC 三点だいしゅきツール, więc usunięto Prefaby integracji

## [2.1.4] - 2024-12-08
- Naprawiono błąd zależny od awatara
- Naprawiono brak blokady stóp wskutek konfliktów funkcji lub awatara
- Naprawiono powrót pozy awatara do standardowej VRC w trybie pulpitu

## [2.1.3] - 2024-12-01
- Naprawiono brak zmian poz z awatarami lub funkcjami używającymi niewłaściwego typu VRMode
- Dodano wyświetlanie konfliktów różnych typów parametrów między funkcjami w NDMF-Console

## [2.1.2] - 2024-12-01
- Dodano wyjaśnienie w NDMF-Console, gdy błąd innego narzędzia powoduje błąd Unisaki Posing System przy budowaniu awatara
- Naprawiono błąd budowania niektórych awatarów
- Poprawiono działanie tuż po wczytaniu awatara
- Oryginalna obsługa ruchu awatara jest teraz usuwana, bo uniemożliwiała działanie niektórych awatarów

## [2.1.1] - 2024-11-20
- Naprawiono brak możliwości budowania

## [2.1.0] - 2024-11-20
- Rozwiązano zapadanie stóp i bioder w ziemię w trybie pulpitu, aby każda poza wyglądała poprawnie
- Dodano zmianę pozy niezależnie od wysokości głowy
- Dodano tryb bez generowania ikon do przesyłania awatarów Quest
- Dodano ostrzeżenia o niektórych problemach awatara
- Rozwiązano konflikty blokad z AFK, blokadą ramion innych narzędzi i podobnymi funkcjami
- Dodano automatyczną blokadę głowy na plecach
- Zmieniono ExpressionsMenu: wybór poz wydzielono do folderu, a blokady przeniesiono na górę

## [2.0.0] - 2024-11-14
### Naprawiono
- Zmieniono na pakiet VPM dla obsługi VCC
- Naprawiono zużycie 17bit przez wersję 8bit

## [1.15.0] - 2024-11-04
### Naprawiono
- Naprawiono błędy i usterki

## [1.14.0] - 2024-07-05
### Naprawiono
- Naprawiono problem z VRCFury

## [1.13.0] - 2024-04-11
### Naprawiono
- Dodano ustawienia integracji z ごろ寝システムEX

## [1.12.0] - 2024-03-31
### Naprawiono
- Naprawiono niedostępność narzędzia w niektórych stanach ExMenu
- Dodano odbicie do ustawień
- Poprawiono pozę kota
- Dodano ５ pozy leżące na boku

## [1.11.0] - 2024-03-12
### Naprawiono
- Naprawiono nieprawidłową pozę przy wysokiej pozycji głowy

## [1.10.0] - 2024-03-10
### Naprawiono
- Dodano obsługę stania i 15 poz
- Naprawiono samoczynne ruchy nóg u niektórych awatarów i w niektórych środowiskach
- Dodano wersję ExpressionParameters8bit

## [1.9.0] - 2024-03-05
### Naprawiono
- Naprawiono samoczynne ruchy nóg u niektórych awatarów
- Ujednolicono WriteDefaults
- Dodano ７ poz kucających i ８ siedzących

## [1.8.0] - 2024-02-25
### Naprawiono
- Naprawiono błąd przesyłania z ModularAvatar1.9.0 i nowszym
- ModualrAvatar1.9.0 lub nowszy jest teraz wymagany

## [1.7.0] - 2024-02-23
### Naprawiono
- Dodano zmianę progu wysokości głowy każdej pozy
- Naprawiono problemy poz i nóg niektórych awatarów np. podczas skoku
- Zużycie ExpressionParameter zmniejszono z 54 do 16bit

## [1.6.0] - 2024-02-20
### Naprawiono
- Naprawiono brak możliwości przyjęcia pozy siedzącej w VR

## [1.5.0] - 2024-02-18
### Naprawiono
- W trybie pulpitu można teraz siedzieć również przy wciśniętym C

## [1.4.0] - 2024-02-17
### Naprawiono
- Naprawiono niedostępność integracji 添い寝 bez integracji 三点だいしゅき
- Naprawiono zastyganie nóg przy skoku

## [1.3.0] - 2024-02-16
### Naprawiono
- Naprawiono nienormalnie dużą liczbę VRCContactSender/Receiver

## [1.2.0] - 2024-02-16
### Naprawiono
- Naprawiono błąd budowania podczas przesyłania

## [1.1.0] - 2024-02-15
### Naprawiono
- Naprawiono nieprawidłowe ustawienia domyślne przy kilku Prefabs
- Naprawiono błędną konfigurację integracji 可愛い座り

## [1.0.0] - 2024-02-14
### Wydanie
