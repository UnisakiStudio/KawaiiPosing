# Kawaii Posing Tool — polska instrukcja użytkownika

Kawaii Posing zawiera 85 poz dla trybu pulpitu i trzypunktowego VR: 15 stojących, 20 kucających/na krześle, 17 siedzących na podłodze, 17 na plecach i 16 na brzuchu.

Ta instrukcja opisuje instalację, konfigurację awatara, sterowanie VRChat, edycję poz, aktualizacje i rozwiązywanie problemów. `START_HERE.html` w zakupionym ZIP prowadzi najkrótszą drogą do instalacji.

## Zanim zaczniesz

- Użyj projektu **awatara** VRChat w Unity 2022.3 utworzonego lub zarządzanego przez VRChat Creator Companion (VCC) albo ALCOM.
- Wymagane pakiety: VRChat Avatars SDK 3.10.4 lub nowszy; Modular Avatar 1.x w wersji co najmniej 1.15.1; NDMF 1.x w wersji co najmniej 1.14.0.
- Narzędzie jest przeznaczone do awatarów Humanoid w trybie pulpitu i trzypunktowym VR (gogle i dwa kontrolery). Blokada poz przy aktywnym pełnym śledzeniu ciała nie jest obsługiwana.
- Przed instalacją lub aktualizacją wykonaj kopię zapasową projektu. Najpierw usuń istniejące błędy kompilacji Unity.
- Instalator pobiera produkt i zależności z ich repozytoriów pakietów. Wymaga internetu. Modele awatarów, VRChat SDK, Modular Avatar i NDMF nie są dołączone do tego ZIP.

## 1. Zainstaluj licencję i produkt

1. Rozpakuj cały ZIP do zwykłego folderu poza projektem Unity.
2. Otwórz właściwy projekt awatara w Unity. Zaimportuj `Installer/KawaiiPosing_Installer.unitypackage` przez **Assets > Import Package > Custom Package** albo otwórz plik w Unity.
3. Przeczytaj komunikaty importu i instalacji. Potwierdzenie licencji wyjaśnia, jakie licencje zostaną zainstalowane. Język instalatora zmienisz przez **Język…** (lub **言語...**) w oknie potwierdzenia.
4. Potwierdź instalację licencji. Obejmuje ona także wspólny Unisaki Posing System używany przez produkt. Następnie instalator może zaoferować usunięcie własnych plików instalacyjnych. Takie porządkowanie nie usuwa zainstalowanej licencji.
5. Sprawdź potwierdzenie automatycznego instalatora pakietów. Wymienia dodawane pakiety i repozytoria oraz stare pliki lub foldery proponowane do usunięcia. Kontynuuj, jeśli są to zamierzone elementy.
6. Poczekaj na zakończenie importu i kompilacji Unity. Jeśli pakiety nie zainstalują się automatycznie, otwórz projekt w VCC lub ALCOM i dodaj **Kawaii Posing Tool** oraz **Modular Avatar**. Wspólny **Unisaki Posing System** i **NDMF** są zależnościami. `Optional-VCC-Links` zawiera oryginalne skróty repozytoriów produktu dla użytkowników VCC w Windows.
7. Jeśli anulowano potwierdzenie, zaimportuj instalator ponownie, gdy będziesz gotowy. Dopóki aktywator pozostaje, możesz też użyć polecenia instalacji licencji w **Tools > Unisaki Studio**. W starszych wersjach to podmenu nazywa się **ゆにさきスタジオ**.

### Co instaluje ten plik do pobrania

**Kawaii Posing Tool 3.2.0 z Unisaki Posing System 3.2.0.** Ta wersja jest w przygotowaniu i nie została wydana. Dodaje okna instalacji, Inspector i menu Unity, standardowe nazwy poz, menu gry oraz dokumentację offline w 30 językach. Data wydania nie została ustalona. Użyj selektora u góry Inspectora, aby zmienić język narzędzia. Po publikacji instalator pobierze te wersje i zgodne zależności z repozytoriów VPM. Lokalne przygotowanie wydania nie publikuje pakietów.

Kawaii Posing Tool zawiera bibliotekę poz, narzędzia konfiguracji i presety dopasowania awatarów. Instalator aktywuje dotychczasową lokalną licencję produktu i nie wymaga nowego pola klucza licencyjnego Gumroad. Nigdy nie publikuj plików instalatora ani danych licencji w otwartym zgłoszeniu wsparcia.

Preferencje języka są zapisywane przez Unity EditorPrefs dla bieżącego użytkownika systemu i współdzielone między projektami Unity na tym komputerze. Bez zapisanej preferencji instalator używa języka systemu, a dla nieobsługiwanych języków angielskiego. Licencje zachowują dotychczasowe przechowywanie: klucz rejestru bieżącego użytkownika `Software/UnisakiStudio` w Windows oraz pliki licencji użytkownika w macOS/Linux. Zmiana języka nie usuwa licencji.

## 2. Dodaj narzędzie do awatara

1. W **Hierarchy** wybierz awatara z **VRC Avatar Descriptor** lub jeden z jego obiektów potomnych. Użyj awatara umieszczonego w scenie, a nie zasobu Prefab z Project ani Prefab Mode.
2. Kliknij awatara prawym przyciskiem i wybierz **Unisaki Studio > Dodaj Kawaii Posing**. Jeśli zainstalowana wersja używa japońskiego menu, wybierz **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Narzędzie zostanie dodane wewnątrz awatara. Zapisana nazwa obiektu może pozostać **可愛いポーズ**, mimo przetłumaczonych etykiet.
4. Jeśli oferowany jest zgodny preset awatara, zastosuj go na początek. W przeciwnym razie otwórz **Konfigurację awatara** i wybierz preset albo samodzielnie dostosuj pozy.
5. Instalator może zaoferować budowanie wstępne. Jest opcjonalne: zwykłe budowanie awatara także tworzy wymagane dane. Ponowne używanie wyników skraca kolejne budowania.
6. Wybierz obiekt narzędzia, potrzebne pozy i funkcje, a następnie prześlij awatara normalnie przez VRChat SDK.

### Wybór języka i znajome etykiety

Ta wersja ma **Language / 言語** u góry Inspectora narzędzia. Jeden wybór obejmuje Inspector i generowane menu gry. Awatar zapisuje swój język, a ostatni wybór jest pamiętany dla innych narzędzi i projektów na tym komputerze. Aby zmienić język w VRChat, prześlij awatara ponownie.

Korzystaj z poniższej tabeli etykiet, wykonując starsze japońskie poradniki. Ta wersja ma wybór języka, zlokalizowany Inspector, standardowe nazwy poz i menu gry we wszystkich 30 językach.

| Polska etykieta | Japońska etykieta w starszych wersjach |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funkcje | 機能 |
| Pozy | ポーズ一覧 |
| Konfiguracja awatara | アバター調整 |
| Otwórz ustawienia | 設定を開く |
| Aktualizuj budowanie wstępne | プレビルドを更新 |
| Sprawdź ustawienia | 設定の確認 |
| Podgląd | プレビュー |
| Dostosowywanie animacji | アニメーション調整 |
| Odśwież | 再読込 |

Dołączony Inspector, okna edytora i instalacji, standardowe nazwy poz oraz generowane menu są przetłumaczone na wszystkie 30 wybieranych języków. README, historia zmian i instrukcja offline są dostarczane w każdym wybieranym języku. Nazwy awatarów, zapisane nazwy obiektów, własne nazwy poz, nazwy plików zasobów i wewnętrzne identyfikatory parametrów mogą zachować oryginalną pisownię.

[Skrócone przewodniki w 30 językach](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) zawierają opisy funkcji i tabele standardowych nazw poz. Są to krótkie materiały pomocnicze; pełna dokumentacja jest dostępna z indeksu języków.

## 3. Wybierz pozy i funkcje

Inspector ma trzy główne karty:

| Karta | Przeznaczenie |
| --- | --- |
| **Funkcje** | Sterowanie menu gry, opcjonalne zachowania, oddech, ikony i zużycie parametrów ekspresji. |
| **Pozy** | Włączone pozy, kategorie i wyszukiwanie, kolejność, dodawanie animacji, podgląd, szczegóły i dostosowywanie animacji. |
| **Konfiguracja awatara** | Korekcje awatara i kolan, import oryginalnych/własnych ruchów i presety. |

Włączaj tylko potrzebne elementy menu. Na przykład dodanie **Odbicia** pozwala przełączać je w VRChat, ale nie wymusza stałego odbicia każdej pozy.

Kawaii Posing zawiera presety awatarów i IK obsługiwanych poz. Trzy standardowe pozy na plecach mają już przypisane ruchy boczne: **Nogi w przód (足伸ばし)**, **Relaks (リラックス)** i **Jedno kolano w górę (膝立て)**. Użyj zgodnego presetu i sprawdź obracanie każdej pozy, jeśli te wpisy były edytowane lub zastępowane.

### Presety i dopasowanie

Presety są blisko dołu **Konfiguracji awatara**. Wyszukaj po nazwie awatara i zastosuj preset, aby zastąpić bieżące ustawienia poz. Zapisz lub skopiuj korekcje przed zmianą. Preset jest punktem wyjścia: proporcje ciała, ubrania i modyfikacje awatara mogą nadal wymagać ręcznego dopasowania.

Użyj **Dostosowywania animacji** danej pozy do podglądu i edycji położenia ciała oraz kończyn. Po zakończeniu zapisz animację korekcji w tym oknie. W obsługiwanych pozach automatyczną korekcję rąk i stóp (IK) można włączyć ogólnie i osobno. Wypalenie bieżącego IK tworzy animację korekcji i wyłącza IK tej pozy, umożliwiając ręczne dopracowanie. Oryginalny klip źródłowy pozostaje.

**Zapobiegaj wyginaniu kolan do tyłu** ma dodatkowe ustawienia, np. minimalny kąt zgięcia. Korekcje konkretnego awatara są dostępne tylko przy odpowiednich danych, a niektórych nie można łączyć z IK pozy.

### Oryginalne i własne ruchy

**Używaj oryginalnych poz stojących, kucających i na brzuchu** wykrywa ruchy z warstwy Base podczas generowania. **Własne ruchy** otwiera oddzielne ustawienia importu dla każdego typu. Wybierz jeden ruch na typ. Ręczne przypisanie ma pierwszeństwo przed automatycznym importem tego typu.

Automatyczny import dotyczy kopii budowania. Nie zapisuje wykrytych animacji do listy przypisań ręcznych w scenie ani nie zmienia oryginalnych Controllerów. Wyczyść ręczne nadpisanie typu, aby znów używać wykrywania automatycznego. Własne warstwy Base i inne systemy lokomocji mogą wymagać indywidualnych ustawień.

## 4. Używanie w VRChat

Otwórz menu **Expressions** awatara i wejdź do **Kawaii Posing**. Wybierz pozę dla każdej potrzebnej kategorii. Wybór pozy i wybór funkcji to odrębne działania.

- **Trzypunktowy VR:** podnoś lub opuszczaj głowę, aby przechodzić między staniem, kucaniem/krzesłem, siedzeniem na podłodze i leżeniem. Jeśli zmiana następuje za wcześnie lub za późno, dopasuj progi wysokości w menu ustawień narzędzia.
- **Tryb pulpitu:** **C** — kucanie, **Z** — leżenie. Jeśli po Z nadal siedzisz, podnieś próg wysokości leżenia w ustawieniach.
- **Plecy/brzuch:** kierunek twarzy wybiera leżenie na plecach lub brzuchu. Jeśli wybrano obie pozycje, skok w miejscu może je przełączać. Możesz to wyłączyć w Unity przez **Funkcje > Udogodnienia**. Nie zwiększa to kosztu synchronizowanych parametrów.
- **Blokady:** używaj blokad głowy, ramion i stóp w razie potrzeby. Wyłącz gesty, jeśli chcesz kształt dłoni z pozy zamiast gestów kontrolera.
- **Odbicie:** odwróć wybraną pozę, aby zwrócić się do znajomego lub dopasować kadr.

### Wysokość stóp i wysokość ziemi

**Wysokość stóp** reguluje stopy, zachowując pozycję głowy. Użyj, gdy stopy wiszą lub zapadają się, ale głowa jest już na właściwej wysokości.

**Wysokość ziemi** przesuwa całe ciało wraz z głową. Użyj dla sofy, łóżka i podwyższeń, także mebli bez collidera. W obecnym wyśrodkowanym regulatorze wspólnego systemu **50% to pierwotna wysokość**, 0% — o 3 m niżej, 100% — o 3 m wyżej. Powrót w okolice 50% kończy przesunięcie. Starsze wydania mogą działać inaczej. Sprawdź zainstalowaną wersję i aktualizuj wspólny system razem z produktem.

### Tryb zdjęć

Przed przesłaniem włącz pozycję **Tryb zdjęć** w Unity. W VRChat wybierz pozę, suwakiem **Odległość** przesuń awatara do 3 m do przodu, a **Kierunek** posłuży do obrotu. Blokada stóp podczas ustawiania kadru jest opcjonalna. **Zakończ zdjęcia** zeruje odległość i obrót oraz zwalnia blokadę stóp.

Tryb zdjęć jest domyślnie lokalny. Aby pokazywać pozycję i obrót innym, przed przesłaniem włącz w Unity **Synchronizuj tryb zdjęć**: kosztuje to 16 synchronizowanych bitów. **Pokazuj głowę w trybie zdjęć** wpływa na twój widok i nie zużywa synchronizowanych bitów.

### Oddech i obracanie

Oddech ustawia się dla każdej kategorii poz w **Funkcje > Udogodnienia > Animuj oddech**. Wybierz Brak, Słabe, Średnie, Silne, Szybkie lub własną animację. Sam ruch nie zużywa synchronizowanych bitów. Przełącznik oddechu w menu używa 1 bit.

Obracanie wymaga obsługiwanej pozy leżącej i pozycji menu **Obróć się**. Włącz obracanie dla pozy i w razie potrzeby przypisz jej animację boczną. W VRChat wybierz tę pozę, włącz obracanie i zwolnij blokadę głowy/szyi. Przechylenie głowy na bok steruje obrotem. Zwykłe sterowanie MotionTime jest niedostępne dla tej pozy przy obracaniu.

Trzy wymienione wyżej standardowe pozy na plecach mają ruchy boczne. Inne wymagają odpowiedniego ruchu i ustawienia pozy. Importowane lub własne presety mogą mieć inne przypisania.

## 5. Edycja, dodawanie i podgląd poz

Na karcie **Pozy** wybierz kategorię lub wyszukiwanie. Wyszukiwanie akceptuje oryginalne japońskie nazwy i dostępne tłumaczenia. Otwórz **Szczegóły** pozy, aby zmienić animację, ikonę, kolejność i opcje czasu.

Aby dodać kilka animacji, przeciągnij klipy do obszaru dodawania lub wybierz je w Project i użyj polecenia importu zaznaczonych klipów. Powtórne odwołania do tego samego klipu są usuwane. Zmieniaj docelową kolejność w Szczegółach albo przyciskami w górę i w dół.

**Podgląd** pokazuje pozę w Scene bez otwierania pełnego okna dostosowania. Uproszczony podgląd nie uruchamia Modular Avatar ani NDMF, więc ubrania, korekcję podłoża i inne funkcje etapu budowania sprawdzaj w ostatecznym awatarze po zbudowaniu.

Ikony tworzone z twojego awatara ułatwiają rozpoznawanie poz, ale ich generowanie zajmuje czas i może zwiększyć rozmiar danych awatara. Zmniejsz rozdzielczość ikon, aby oszczędzić miejsce. Android nie generuje ikon poz. W razie potrzeby odtwórz je po zmianie awatara lub ubrania.

## 6. Pamięć parametrów

Inspector pokazuje wkład narzędzi póz, a nie sumę całego awatara. Ubrania i inne systemy mogą zużywać dodatkową pamięć parametrów. Wspólne ustawienia kilku narzędzi nie są liczone podwójnie. Własne konfiguracje z wieloma dodatkowymi pozami mogą potrzebować więcej bitów wyboru.

| Funkcja | Dodatkowe synchronizowane bity |
| --- | ---: |
| Wybór poz, minimalna standardowa konfiguracja | 8 |
| Odbicie | 1 |
| Bez gestów | 1 |
| Ruch oddechu | 0 |
| Przełącznik oddechu w menu | 1 |
| Wysokość stóp | 8 |
| Wysokość ziemi | 8 |
| Tryb zdjęć, tylko lokalny | 0 |
| Synchronizuj tryb zdjęć | 16 |
| Pokazuj głowę w trybie zdjęć | 0 |
| Wyłącz standardowe kołysanie VRChat | 0 |
| Obróć się | 10 |

Obracanie dzieli 1 bit z korekcją pozy od kierunku szyi. Włączenie obu nadal zużywa razem 10 bitów dla tych dwóch funkcji. Wyświetlane zużycie zainstalowanej wersji jest praktycznym odniesieniem dla wybranej konfiguracji.

## 7. Aktualizacja i budowanie wstępne

1. Wykonaj kopię projektu i zapisz roboczą scenę.
2. W VCC lub ALCOM zaktualizuj **Kawaii Posing Tool** i wspólny **Unisaki Posing System** razem. Zachowaj też zgodne wersje SDK, Modular Avatar i NDMF.
3. Zaczekaj na kompilację. Wybierz już zainstalowane narzędzie i sprawdź pozy, ustawienia i zużycie parametrów.
4. Jeśli używasz budowania wstępnego, wybierz **Aktualizuj budowanie wstępne**, a potem prześlij awatara ponownie.

Istniejące ustawienia narzędzia pozostają zachowane. Dawne prefaby 8-bit są zachowane dla zgodności; istniejące odwołania nie wymagają usuwania lub zastępowania narzędzia. Nowe instalacje używają zwykłego prefabu, a zbędne funkcje można wyłączyć, aby zmniejszyć zużycie parametrów.

Ostrzeżenie o nieaktualnym budowaniu wstępnym oznacza zmianę ustawień po utworzeniu danych w pamięci podręcznej. Aktualizacja odtworzy te dane. Ukrycie ostrzeżenia nie aktualizuje wyniku ani nie rozwiązuje przyczyny. Zwykłe budowanie awatara tworzy wymagane dane nawet bez ręcznego budowania wstępnego za każdym razem.

## 8. Rozwiązywanie problemów

| Objaw | Co sprawdzić |
| --- | --- |
| Brak menu dodawania narzędzia | Sprawdź instalację produktu **i** Unisaki Posing System oraz napraw błędy kompilacji Unity Console. Sam instalator licencji nie jest biblioteką poz. |
| Instalacja anulowana lub pliki usunięte | Ponownie zaimportuj zakupiony instalator, gdy będziesz gotowy. Jeszcze raz przeczytaj potwierdzenia. |
| Brak licencji w innym projekcie | Zaimportuj zakupiony instalator na tym samym koncie systemu. Po zmianie komputera lub konta zainstaluj licencję także tam. Preferencje języka nie przenoszą się automatycznie między komputerami. |
| Brak poz w VRChat | Dodaj narzędzie do właściwego awatara sceny, włącz pozy, przejrzyj ostrzeżenia Inspectora i prześlij tego awatara. Sprawdź SDK i inne systemy ruchu. |
| Z nie przełącza do leżenia | Podnieś próg wysokości leżenia w ustawieniach narzędzia w grze. |
| Dłonie lub kolana nie pasują | Spróbuj zgodnego presetu awatara, potem obsługiwanego IK i/lub Dostosowywania animacji. Sprawdź deformację ubrania w ostatecznej kompilacji. |
| Obracanie nie działa | Użyj obsługiwanej pozy leżącej, włącz jej obracanie i pozycję menu oraz zwolnij blokadę głowy/szyi. Najpierw sprawdź jedną z trzech obsługiwanych standardowych poz. |
| Znajomi nie widzą ruchu zdjęć | Włącz **Synchronizuj tryb zdjęć** w Unity, sprawdź zużycie parametrów i prześlij ponownie. |
| Język zmienia się w Unity, lecz nie w VRChat | Prześlij awatara ponownie. Sprawdź jeden górny selektor języka Inspectora w wersji obsługującej lokalizację. |
| Błędy budowania zwykłego/wstępnego | Przeczytaj **pierwszy** istotny błąd Console. Wykonaj kopię sceny, zaktualizuj lub ponownie pobierz produkt i wspólny system przez VCC/ALCOM i skontaktuj się ze wsparciem, jeśli problem trwa. Zachowaj dopasowane obiekty i GeneratedResources, chyba że wsparcie poda konkretny krok naprawy. |

W zgłoszeniu wsparcia podaj wersje produktu i wspólnego systemu, Unity/SDK/Modular Avatar/NDMF, nazwę awatara, dokładne kroki odtworzenia i odpowiedni błąd Console. Usuń z publicznych wpisów prywatne pliki, zawartość instalatora, wartości licencji i dane konta.

- [Wsparcie](https://help.unisakistudio.jp/)
- [Ilustrowana instrukcja online (po japońsku)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Strona produktu Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licencje i autorzy

[Angielskie tłumaczenie pomocnicze umowy produktu](../../Terms.en.html) jest dostarczane obok oryginalnej umowy japońskiej.

Przeczytaj oryginalną umowę produktu i umowę wspólnego systemu obok README pakietu lub w folderze `Licenses` zakupionego ZIP. Dołączona angielska umowa Unisaki Posing System jest istniejącym tłumaczeniem pomocniczym systemu; japońska umowa produktu pozostaje dołączona oddzielnie. Instrukcja nie zmienia umów ani nie przyznaje dodatkowych praw. Pytania o używanie lub rozpowszechnianie danych produktu kieruj do wsparcia.

Instalator zawiera zmodyfikowany **VPMPackageAutoInstaller** autorstwa **anatawa12** oraz **SimpleJson** i **semver.net**. Ich informacje o prawach autorskich i teksty licencji MIT są w `ThirdPartyNotices.txt` zakupionego ZIP. Biblioteka poz i inne zasoby produktu mają własne licencje.
