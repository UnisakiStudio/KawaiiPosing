# Kawaii Posing Tool

Narzędzie blokowania póz dla VRChat, umożliwiające korzystanie z uroczych pozycji siedzących i leżących także przy śledzeniu 3 punktów i w trybie pulpitu. Zawiera 85 poz: 15 stojących, 20 kucających, 17 siedzących, 16 na brzuchu i 17 na plecach.

Ten README dotyczy tworzonej wersji v3.2.0. Data oficjalnego wydania nie została ustalona. Zainstalowana wersja jest widoczna u góry Inspectora.

- [Strona produktu w BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Historia zmian](CHANGELOG.md)

## Język interfejsu i dokumentacja offline

Wybierz język w polu „Language / 言語” u góry Inspectora. Jeden wybór obejmuje Inspector i generowane menu VRChat. Aby zmienić język w grze, prześlij awatara ponownie.

Jeżeli nie wybrano języka, używany jest język komputera, a dla nieobsługiwanego języka — angielski. Obsługiwane są Windows, macOS i Linux. Ostatni wybór jest zapisywany w EditorPrefs i używany także w innych projektach tego samego użytkownika systemu na tym komputerze. Jawny wybór zapisany w awatarze zostaje zachowany. Nie jest synchronizowany z innymi komputerami. Sposób przechowywania licencji nie zmienia się.

README, historię zmian i instrukcję można wybrać z dołączonej [listy języków](../index.html). Przyciski instrukcji i historii zmian w Inspectorze również uwzględniają wybrany język. Oryginalne warunki użytkowania i tłumaczenia pomocnicze nadal są dostarczane osobno.

## Główne funkcje

- Tryb zdjęć: przesuń awatara do 3m do przodu i dopasuj kierunek. Tylko na własnym ekranie zużywa 0 bit, a pokazywanie pozycji i kierunku innym — 16 bit.
- Widoczność głowy podczas zdjęć: zapobiega ukrywaniu głowy własnego awatara z bliska tylko w trybie zdjęć.
- Wysokość ziemi: przesuwa całe ciało wraz z głową o 3m w górę lub w dół. 50% jest pierwotną wysokością i wartością początkową, 0% — o 3m niżej, 100% — o 3m wyżej. Uzupełnia Wysokość stóp, która reguluje stronę nóg, zachowując położenie głowy.
- Obróć się: obracanie w lewo i w prawo według przechylenia głowy w obsługiwanych pozycjach leżących.
- Oddech: dodaje ruch oddechu, np. klatki piersiowej. Dla każdej kategorii można wybrać Brak, Słabe, Średnie, Silne, Szybkie lub Własne.
- Wyłącz kołysanie w spoczynku VRChat: ogranicza standardowe kołysanie, zachowując oddech narzędzia i inne własne ruchy.
- Ogranicz deformację pozy przy obrocie głowy: zmniejsza deformację po zwolnieniu blokady, gdy kierunek głowy różni się od oryginalnej pozy.
- Wybór funkcji: dodawaj tylko potrzebne menu gry i sprawdzaj zużycie ExpressionParameters w Inspectorze.
- Wyszukiwanie, dodawanie zbiorcze i sortowanie poz: wyszukiwanie między kategoriami, wczytywanie wielu klipów i wybór miejsca w kolejności.
- Uproszczony podgląd w Scene: sprawdzaj pozę na miejscu przez Podgląd na liście poz.

- Automatyczna korekcja kończyn (IK): dopasowuje położenie rąk i nóg obsługiwanych poz do budowy awatara. Można ją przełączać dla każdej pozy i zapisywać wynik w animacji korekcji.

### Obracanie dołączonych poz

Dla poz na plecach Nogi w przód, Relaks i Jedno kolano w górę przypisano boczne pozy obracania. Podstawą są odpowiednio pozy „Sen na boku”, „Drzemka” i „Kocia drzemka”.

Włącz „Funkcje > Funkcje menu > Obróć się”, prześlij awatara, a w VRChat wybierz zgodną pozę i Obróć się. Zwolnij blokadę głowy przed użyciem.

Dla własnej konfiguracji włącz „Pozy > Szczegóły > Włącz obracanie” i przypisz animację w polu Boczna poza obracania. Zwykłe ustawienie MotionTime jest niedostępne w pozach korzystających z obracania.

### Dopasowanie do budowy ciała

Można użyć dołączonej automatycznej korekcji kończyn, ale nie każda poza wymaga IK. Włącz automatyczną korekcję kończyn w oknie dostosowania animacji przełącza całą funkcję, a Włącz IK tej pozy — pojedynczą pozę.

Wypal IK do korekcji zapisuje bieżący wynik automatyczny w nowej animacji korekcji i wyłącza IK docelowej pozy. Następnie można dopracować ją ręcznie. Funkcja jest dostępna, gdy korekcja ogólna i danej pozy są aktywne i istnieją odpowiednie ustawienia IK.

W Konfiguracji awatara są również Zapobiegaj wyginaniu kolan do tyłu oraz Minimalne zgięcie kolana (stopnie) w Szczegółach.

## Instalacja

1. Pobierz pliki ze strony produktu w sklepie, w którym go kupiono.
2. Zaimportuj dołączony „可愛いポーズツール.unitypackage” do Unity i zarejestruj licencję oraz źródło pakietów.
3. Przez VCC lub ALCOM dodaj Kawaii Posing Tool i Modular Avatar do używanego projektu Unity. Wspólny Unisaki Posing System i NDMF instalują się jako zależności.
4. Kliknij docelowego awatara prawym przyciskiem w Hierarchy i wybierz „Unisaki Studio > Dodaj Kawaii Posing”.
5. Wybierz 可愛いポーズ (Kawaii Posing) dodane do awatara i ustaw potrzebne funkcje i pozy w Inspectorze.
6. Prześlij awatara w zwykły sposób.

Wymagane są Unity 2022.3, VRChat Avatars SDK 3.10.4 lub nowszy, Modular Avatar 1.x w wersji co najmniej 1.15.1 i NDMF 1.x w wersji co najmniej 1.14.0. Zaktualizuj potrzebne pakiety razem w VCC lub ALCOM.

## Aktualizacja ze starszej wersji

Zaktualizuj ten produkt i Unisaki Posing System razem. Ustawienia już umieszczonych narzędzi zostają zachowane. Sprawdź funkcje i zużycie ExpressionParameters w Inspectorze. Jeśli korzystano z budowania wstępnego, naciśnij Aktualizuj budowanie wstępne przed ponownym przesłaniem.

Od v3.1.0 nowe dodawanie korzysta ze zwykłego Prefabu 可愛いポーズ (Kawaii Posing). Wyłącz niepotrzebne funkcje, aby uzyskać minimalną konfigurację tylko z wyborem póz za 8 bit. Duża liczba poz może wymagać dodatkowych bitów wyboru.

Stary Prefab 8bit pozostaje w Editor/Legacy, aby zachować odwołania istniejących awatarów i presetów. Nie trzeba usuwać ani zastępować istniejącego Prefabu. Wersja 8bit nie jest pokazywana w menu nowego dodawania Unity.

## Gdzie zmieniać ustawienia

| Karta | Możliwości |
| --- | --- |
| Funkcje | Dodawanie menu gry, udogodnienia, ustawienia oddechu oraz sprawdzanie ikon i zużycia ExpressionParameters |
| Pozy | Wybór używanych poz, szczegóły, wyszukiwanie, dodawanie zbiorcze, kolejność, podgląd i dostosowywanie animacji |
| Konfiguracja awatara | Korekcja awatara i kolan, import oryginalnych poz i własnych ruchów, zmiana presetów |

Otwórz ustawienia rozwija szczegółowe pola pod danym punktem. Oddech ustawia się w „Funkcje > Udogodnienia > Animuj oddech”.

Używaj oryginalnych poz stojących, kucających i na brzuchu automatycznie importuje istniejące pozy awatara. Własne ruchy przypisuje się w osobnych ustawieniach importu dla każdego typu: stanie, kucanie (Crouching), leżenie na brzuchu (Prone) i innych.

Presety znajdują się na dole Konfiguracji awatara. Zastosuj ten preset zastępuje bieżące ustawienia poz, więc wcześniej zapisz wykonane korekcje.

### Zużycie poszczególnych funkcji

- Ruch oddechu zużywa 0 bit. Tylko przełącznik zatrzymywania i wznawiania „Funkcje menu > Oddech” używa 1 bit synchronizacji.
- Tryb zdjęć tylko na własnym ekranie to 0 bit. „Udogodnienia > Synchronizuj tryb zdjęć” używa 16 bit. Pokazuj głowę w trybie zdjęć to 0 bit.
- Wysokość stóp i Wysokość ziemi zużywają po 8 bit. Odsunięcie wysokości ziemi od środka przesuwa ciało w górę lub w dół, a powrót w okolice 50% kończy korekcję.
- Obracanie osobno zużywa 10 bit. Dzieli 1 bit z ograniczeniem deformacji przy obrocie głowy, więc obie funkcje razem nadal zużywają 10 bit.
- Odbicie i Bez gestów zużywają po 1 bit.

Suma w Inspectorze dotyczy narzędzi póz zainstalowanych na awatarze. Nie obejmuje ubrań ani innych funkcji. Wspólne ustawienia kilku narzędzi nie są liczone ponownie.

### Podgląd i edycja poz

Podgląd przy każdej pozie na karcie Pozy pokazuje ją w Scene. Aby poprawić szczegóły, otwórz Dostosowywanie animacji, zmień pozę z podglądem i zapisz.

Uproszczony podgląd nie wykonuje budowania MA ani NDMF. Ubrania i korekcje położenia podłoża dodawane podczas budowania sprawdź także w wyniku budowania przed przesłaniem.

Karta z lupą po lewej wyszukuje nazwy poz. Docelowe miejsce można wybrać w „Szczegóły > Kolejność” lub użyć przycisków w górę i w dół. Kilka animacji dodaje się przeciąganiem do obszaru dodawania albo poleceniem importu klipów wybranych w Project.

Odśwież miniatury poz generuje obrazy po potwierdzeniu. Generuj ikony poz ułatwia rozpoznawanie pozycji w menu gry, ale tworzenie obrazów wydłuża budowanie. Aby ograniczyć rozmiar, wybierz Zmniejsz rozmiar ikon. Android nie generuje ikon poz.

## Podstawowe sterowanie w grze

- Wybierz pozy każdej kategorii w menu Expressions. W VR przejścia między staniem, kucaniem, siedzeniem i leżeniem zależą od wysokości głowy.
- W leżeniu kierunek twarzy przełącza plecy i brzuch. Jeśli wybrano obie pozy, można je zmieniać także skokiem w miejscu. Wyłączysz to w Unity przez „Funkcje → Udogodnienia → Zmieniaj pozycję leżącą skokiem” (domyślnie włączone). Wysokość zmiany kategorii ustawia się progami w menu ustawień.
- W trybie pulpitu przełączaj pozycję klawiszami C i Z. Jeśli Z nie włącza leżenia, podnieś próg wysokości leżenia w ustawieniach.
- Bez gestów używa kształtu dłoni przypisanego do pozy zamiast gestu palców kontrolera.
- Wysokość stóp reguluje stronę nóg, zachowując położenie głowy. Wysokość ziemi przesuwa całe ciało wraz z głową pionowo. W menu ustawień występują w tej kolejności.
- Ruch do przodu regulatorem Odległość w trybie zdjęć zwraca awatara do ciebie. Kierunek obraca go, a Blokuj stopy można włączyć w odpowiednim momencie. Zakończ zdjęcia zeruje odległość i kierunek oraz zwalnia stopy.
- Oddech działa, gdy jego ruch jest włączony. Siła jest ustawiana w Unity, a w grze zmienia się włączenie.

## Budowanie wstępne i ostrzeżenia

Aktualizuj budowanie wstępne przyspiesza budowanie awatara przez ponowne użycie wygenerowanych danych. Bez budowania wstępnego potrzebne dane powstają podczas zwykłego budowania.

Po zmianie ustawień Sprawdź ustawienia u góry Inspectora oraz znacznik Hierarchy informują o aktualizacji. Wyświetlanie ostrzeżeń znajduje się w ramce Sprawdź ustawienia. Ukrycie widoku nie rozwiązuje problemów konfiguracji ani nie aktualizuje wygenerowanych danych.

## Uwagi dotyczące używania

- Blokada poz podczas pełnego śledzenia ciała nie jest obsługiwana.
- Budowa ciała, ubrania i modyfikacje awatara mogą wymagać dodatkowej korekcji.
- Szczególne warstwy Base i inne mechanizmy zmiany poz nie zawsze łączą się zgodnie z oczekiwaniami. Gdy blokada nie działa, sprawdź „Konfiguracja awatara > Połącz blokady śledzenia z innymi narzędziami”.
- Ruch i obrót trybu zdjęć oraz wysokość ziemi korygują też standardowe i własne ruchy bez wybranej pozy. Sprawdź punkt widzenia i zachowanie zastąpionych standardowych ruchów w samym VRChat.
- Wyłącz kołysanie w spoczynku VRChat dotyczy standardowego ruchu spoczynkowego. Nie zatrzymuje wszelkiego kołysania wynikającego z innych przyczyn.

## Instrukcja i wsparcie

Górny panel pomocy i historii zmian w Inspectorze otwiera instrukcję, kontakt i historię zmian. Szczegóły wspólnych funkcji są również w Project Unity pod „Packages > Unisaki Posing System > README”.

- [Oficjalna instrukcja](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Kontakt ze wsparciem](https://help.unisakistudio.jp/)

Zgłaszając błąd, podaj wersje tego produktu i Unisaki Posing System, Unity, VRChat SDK, Modular Avatar i NDMF, używany awatar, kroki odtworzenia i treść błędu Console.

## Udostępnianie presetów

Poniższe informacje dotyczą danych utworzonych za pomocą dostosowywania animacji.

Pliki animacji korekcji utworzone tą funkcją oraz presety skonfigurowane z nimi można swobodnie rozpowszechniać i sprzedawać bez uzyskania zgody Unisaki Studio. Zachęcamy do udostępniania, np. razem z własnymi awatarami lub jako presetów awatarów niedołączonych do narzędzia.

## Produkty z dołączonymi ustawieniami integracji

Uwaga: nasz sklep samodzielnie tworzy ustawienia integracji. Uważamy, że zgoda autorów odpowiednich produktów nie jest potrzebna, i o nią nie prosiliśmy. Prośby o udostępnienie lub zakończenie udostępniania tych ustawień prosimy kierować przez wiadomości sklepu. Użycie integracji wymaga zakupu lub pobrania odpowiednich produktów. Problemy z ustawieniami należy zgłaszać naszemu sklepowi, a nie autorom tych produktów.

„可愛い座りツール”
https://yunisaki.booth.pm/items/3611536

„添い寝ツール”
https://yunisaki.booth.pm/items/3670993

„少女モーション集vol.1”, autor: ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

„VRC想定移動モーション（無料配布）”, autor: カトのVRC道具屋
https://booth.pm/ja/items/1285101

„ごろ寝システムEX”, autor: minminmart
https://minminmart.booth.pm/items/4233545

## Warunki użytkowania

Z narzędzia mogą korzystać wyłącznie osoby, które zaakceptowały poniższe warunki użytkowania przygotowane na podstawie licencji VN3.

[Warunki użytkowania (po japońsku)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Kod źródłowy i zasoby tego repozytorium nie są otwartym oprogramowaniem. Wymagane są legalny zakup produktu i przyjęcie warunków użytkowania.

[Warunki użytkowania (po angielsku)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
