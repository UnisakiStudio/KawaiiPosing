# Historie změn

## [3.2.0] - Nevydáno

### Přidáno

- Zobrazení Inspectoru, úprav, instalačních dialogů, standardních názvů póz a generované nabídky VRChat ve 30 jazycích.
- Sjednocen výběr jazyka Inspectoru a herní nabídky. Výchozí je jazyk počítače a poslední volba platí i pro další projekty stejného uživatele OS.
- README, historie změn a offline návod se otevírají ve vybraném jazyce.
- Připraveny názvy všech 128 standardních póz a popisy funkcí podle stávající terminologie.

### Kompatibilita

- Zachovávají se existující nastavení avatara, vlastní názvy, odkazy na prostředky, identifikátory parametrů a způsob ukládání licencí.

## [3.1.2] - 2026-11-09

- Zamykání hlavy lze přepínat v „Nastavení → Automaticky zamknout hlavu na zádech“ nabídky EX i při vypnuté výšce chodidel. Položka zmizelá ve starších verzích se vrátí po sestavení aktualizovaného avatara.
- Přidána podpora Unisaki Posing System 3.1.2. Opraveno přetrvávající natočení obličeje vzhůru po zvednutí z břicha při omezení deformace pózy podle otočení hlavy.

Aktualizujte Kawaii Posing Tool na 3.1.2 v ALCOM / VCC. Vyžaduje se také Unisaki Posing System 3.1.2. Pokud jste používali předgenerování, stiskněte Aktualizovat předgenerování, uložte scénu a avatara znovu sestavte a nahrajte.

## [3.1.1] - 2026-11-08

- Zapnuté Výška podlahy a Přetočit se jsou nyní v Nastavení nabídky EX ve VRChat viditelné i při vypnutém zrcadlení.
- Po seřazení, odstranění či přejmenování póz ve staré verzi se zachovávají správná přetočení pro Nohy vpřed, Uvolnění a Jedno koleno vzhůru. Platí to i po úplném Unpack, pokud lze původní pózu rozpoznat. Vlastní pózy, ručně vypnutá přetočení a nahrazené boční pohyby zůstávají.
- Opravena krátká póza na břiše při výběru avatara ve VRChat. Opraven i krátký leh na zádech při skoku, pokud je vybrán pouze leh na břiše. Přepínání skokem lze vypnout v „Funkce → Usnadnění → Měnit ležící pózy skokem“. Ve výchozím stavu je zapnuté.
- Pokud se po aktualizaci ztratí odkaz společného Animator Controlleru póz a lze jej obnovit, zobrazí se varování a Controller se vytvoří z nastavení. Zachovávají se i odkazy Controlleru sdíleného více avatary.
- Nabídka přidání nástroje nyní umístí oficiální Prefab i tehdy, když máte vlastní uložený Prefab 可愛いポーズ (Kawaii Posing) stejného názvu.
- Pokud při přidávání Sleep-together tool chybí potřebný produkt propojení, zobrazí se produkt, který je nutné nainstalovat nejprve.

Aktualizujte Kawaii Posing Tool a Unisaki Posing System na 3.1.1 v ALCOM / VCC. Pokud jste používali předgenerování, vyberte 可愛いポーズ (Kawaii Posing) ve scéně, stiskněte Aktualizovat předgenerování a uložte scénu. Pro promítnutí do VRChat avatara znovu sestavte a nahrajte.

## [3.1.0] - 2026-11-07

- U 53 z 85 přiložených póz se končetiny automaticky přizpůsobují proporcím avatara pomocí IK.
- Pózy na zádech Nohy vpřed, Uvolnění a Jedno koleno vzhůru podporují přetočení náklonem hlavy.
- Režim focení umožňuje upravit polohu a směr avatara. Lze zvolit synchronizaci polohy a směru i zobrazení vlastní hlavy při focení.
- Výška podlahy posouvá celé tělo až 3m nahoru či dolů a doplňuje výšku chodidel.
- Přidáno dýchání, vypnutí výchozího pohupování v klidu a omezení deformace pózy podle směru hlavy.
- Používané funkce a spotřeba parametrů jsou viditelné v Inspectoru. Přidáno hledání póz, hromadné přidání, řazení a lehký náhled v Scene.
- Zrychleno přepínání stoje, podřepu a sedu v režimu plochy.
- Zlepšena varování předgenerování po změně nastavení, zátěž posouvání Inspectoru a dlouhá zastavení při úklidu prostředků.
- Přidána podpora Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Otevřená beta (2026-11-05)

- Zahájeno šíření otevřené bety přes GitHub Releases a VPM. U 53 z 85 přiložených póz se končetiny přizpůsobují proporcím pomocí IK.
- Přidána podpora společného balíčku 3.1.0-beta.2. Zlepšeno zobrazení změn po předgenerování, zátěž posouvání Inspectoru a zastavení při úklidu prostředků.

## [3.1.0-beta.1] - Otevřená beta (2026-11-04)

- Přidána podpora Unisaki Posing System 3.1.0-beta.1.
- Běžné přepínání póz v režimu plochy převedeno na jedno vyhodnocení. Funguje při běžném sestavení i předgenerování, VR a zvláštní podmínky zachovávají dosavadní cestu.
- Předgenerování z alpha.3 a starších verzí se rozpoznává jako vyžadující aktualizaci.
- Při změně výšky podlahy během focení se zachovává pohled a po ukončení se obnoví poslední výška podlahy.
- Zahrnuta zlepšení automatického importu, úprav importovaných pohybů a správy vytvořených Controllerů až do alpha.3.

## [3.1.0-alpha.2] - Uzavřená testovací verze (2026-10-26)

### Opravy a změny

- Společný systém póz aktualizován na 3.1.0-alpha.2 včetně oprav ladění.
- Výška podlahy rozšířena na 3m nahoru a dolů. 50% je původní výška a počáteční hodnota.
- Výchozí a vlastní pohyby bez vybrané pózy zahrnuty do korekce focení a výšky podlahy.
- Opraveny problémy ruční korekce, stejnojmenných póz, počáteční pózy a přetočení starých předvoleb a další.

## [3.1.0-alpha.1] - Před zveřejněním

### Přidáno

- Přidána automatická korekce končetin (IK) podle tělesných proporcí.
- Přidán celkový i individuální přepínač IK a zápis výsledku do korekční animace.
- Pózy na zádech Nohy vpřed, Uvolnění a Jedno koleno vzhůru podporují přetočení náklonem hlavy.
- Přidáno nastavení přetočení jednotlivých póz a přiřazení boční animace.
- Přidán režim focení pro posun vpřed a otáčení.
- Přidána synchronizace režimu focení: pouze lokálně 0 bit, se synchronizací 16 bit.
- Přidáno ponechání vlastní hlavy viditelné v režimu focení.
- Přidána Výška podlahy, která zvedá celé tělo včetně hlavy.
- Přidán pohyb a intenzita dýchání i herní přepínač.
- Přidáno vypnutí výchozího pohupování VRChat.
- Přidáno omezení deformace pózy podle směru hlavy.
- Přidáno zabránění ohybu kolen dozadu a minimální úhel ohybu.
- Přidány přepínače funkcí a zobrazení spotřeby ExpressionParameters.
- Přidán lehký náhled v Scene, hledání póz, hromadné přidávání a volba cílového pořadí.
- Přidána historie změn v Inspectoru.

### Změněno

- Inspector rozdělen na 3 karty: Funkce, Pózy a Nastavení avatara.
- Uspořádáno umístění podrobností dýchání, importu vlastních pohybů a předvoleb.
- Omezeno opakování animací vytvářených pro výšku chodidel.
- Přidán potvrzovací dialog obnovy obrázků póz a nastavení varování soustředěno do Kontroly nastavení.
- Odstraněna nabídka nového přidání 8bit verze, nahrazena volbou funkcí běžného Prefabu. Existující odkazy zůstávají.
- Přidána podpora Unisaki Posing System 3.1.0-alpha.1. Minimální verze VRChat Avatars SDK změněna na 3.10.4.

### Opraveno

- Opraven přesun zadávaného názvu na jinou pózu a zavírání podrobností při řazení.
- Opraveno překrývání náhledů, odchylka umístění a chyby některých avatarů.
- Opraveno obnovování varování a stavu předgenerování po změně nastavení i některé chyby sestavení.

## [3.0.13] - 2026-09-22
- Aktualizováno na PosingSystem 3.0.17 a opraven vodorovný posun póz po rovnoměrné změně měřítka celého avatara
- Přidána nastavení ignorování varování automatického přešlapování, chybějícího předgenerování a změn nastavení jednotlivě či společně
- Opraven import nevhodných jednorázových animací při ručním importu pohybových animací

## [3.0.12] - 2026-09-15
- Přidána předvolba avatara (ルリエ)

## [3.0.11] - 2026-09-09
- Přidány předvolby avatarů (メルヴィ, ミダリス)
- Opraveno nahrazování pohybů předvolby うらら

## [3.0.10] - 2026-08-31
- Aktualizováno na PosingSystem 3.0.11 a opraveno selhání předgenerování s nejnovějším NDMF i výjimka při zobrazení chyb

## [3.0.9] - 2026-08-29
- Aktualizováno na PosingSystem 3.0.10 a snížena zátěž načítání předvoleb i vyhodnocování ikon Hierarchy
- Opravena chyba předgenerování více systémů póz na stejném avatarovi

## [3.0.8] - 2026-08-26
- Aktualizováno na PosingSystem 3.0.9 a opraven neplatný Avatar náhledu po NDMF způsobující chybu `Avatar is null` v Play

## [3.0.7] - 2026-08-18
- Aktualizováno na PosingSystem 3.0.8 a opraveno možné poškození dat póz při opakované korekci výšky

## [3.0.6] - 2026-08-12
- Přidány předvolby avatarů (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ)

## [3.0.5] - 2026-03-17
- Přidány předvolby avatarů (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール)

## [3.0.4] - 2026-01-31
- Přidány předvolby avatarů (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing)

## [3.0.3] - 2026-01-11
- Zlepšeny funkce instalace a odstranění licencí

## [3.0.2] - 2026-01-04
- Opravena práce s licencemi ve verzích Mac a Linux

## [3.0.1] - 2025-12-28
- Přidány předvolby avatarů (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ)

## [3.0.0] - 2025-12-28
- Přidáno předgenerování
- Přidána úprava animace
- Přidány předvolby
- Produkt lze nyní přidat do projektu pomocí unitypackage
- Přidány předvolby avatarů (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ)

## [2.2.5] - 2025-05-08
- Vyřešeny problémy kompatibility s některými funkcemi avatara

## [2.2.4] - 2025-04-04
- Opraveno nepřepínání póz u některých avatarů a verzí ModularAvatar

## [2.2.3] - 2025-03-13
- Opraveny nesprávné pohyby některých avatarů, například skok 森羅
- Opravena občasná nesprávná počáteční hodnota Gesta vyp.

## [2.2.2] - 2025-03-06
- Opravena chyba v některých prostředích

## [2.2.1] - 2025-02-05
- Opraven pád Unity
- K názvu nástroje v NDMF Console přidána verze

## [2.2.0] - 2025-02-02
- Přidána volba vypnout gesta a používat tvar rukou z animace
- Ke všem pózám přidána data tvaru rukou

## [2.1.6] - 2025-02-02
- Opraveno poškození póz s některými nástroji
- Opraveny chyby závislé na nastavení

## [2.1.5] - 2024-12-10
- Vyřešeny konflikty s některými funkcemi avatara
- Přidáno tlačítko pro odstranění verze Unitypackage
- Vydána verze VCC 三点だいしゅきツール, proto byly odstraněny integrační Prefaby

## [2.1.4] - 2024-12-08
- Opravena chyba závislá na avatarovi
- Opraveno nefunkční zamykání nohou kvůli konfliktům s funkcemi nebo avatarem
- Opraven návrat pózy avatara na výchozí VRC v režimu plochy

## [2.1.3] - 2024-12-01
- Opraveno nepřepínání póz s avatary nebo funkcemi používajícími nesprávný typ VRMode
- Přidáno zobrazení konfliktů různých typů parametrů mezi funkcemi v NDMF-Console

## [2.1.2] - 2024-12-01
- Do NDMF-Console přidáno vysvětlení chyby Unisaki Posing System při sestavení avatara s chybou jiného nástroje
- Opravena chyba sestavení některých avatarů
- Zlepšeno chování hned po načtení avatara
- Původní zpracování pohybu avatara se nyní odstraňuje, protože některým avatarům bránilo ve fungování

## [2.1.1] - 2024-11-20
- Opravena nemožnost sestavení

## [2.1.0] - 2024-11-20
- Vyřešeno zabořování nohou a boků do země v režimu plochy pro správné zobrazení všech póz
- Přidána změna pózy nezávislá na výšce hlavy
- Přidán režim bez generování ikon pro nahrávání avatarů Quest
- Přidána varování na některé problémy avatara
- Vyřešeny konflikty zámků s AFK, zamykáním paží jiných nástrojů a podobnými funkcemi
- Přidáno automatické zamykání hlavy na zádech
- Změněno ExpressionsMenu: výběr póz oddělen do složky a zámky přesunuty nahoru

## [2.0.0] - 2024-11-14
### Opraveno
- Převedeno na balíček VPM pro podporu VCC
- Opravena spotřeba 17bit u 8bit verze

## [1.15.0] - 2024-11-04
### Opraveno
- Opraveny chyby a problémy

## [1.14.0] - 2024-07-05
### Opraveno
- Opraven problém s VRCFury

## [1.13.0] - 2024-04-11
### Opraveno
- Přidáno nastavení propojení s ごろ寝システムEX

## [1.12.0] - 2024-03-31
### Opraveno
- Opravena nedostupnost nástroje v některých stavech ExMenu
- Do nastavení přidáno zrcadlení
- Opravena kočičí póza
- Přidáno ５ póz vleže na boku

## [1.11.0] - 2024-03-12
### Opraveno
- Opravena nesprávná póza při vysoké poloze hlavy

## [1.10.0] - 2024-03-10
### Opraveno
- Přidána funkce póz ve stoje a 15 póz
- Opraven samovolný pohyb nohou u některých avatarů a prostředí
- Přidána verze ExpressionParameters8bit

## [1.9.0] - 2024-03-05
### Opraveno
- Opraven samovolný pohyb nohou u některých avatarů
- Sjednoceno WriteDefaults
- Přidáno ７ póz v podřepu a ８ vsedě

## [1.8.0] - 2024-02-25
### Opraveno
- Opraveno selhání nahrávání s ModularAvatar1.9.0 a novějším
- Nyní je vyžadován ModualrAvatar1.9.0 nebo novější

## [1.7.0] - 2024-02-23
### Opraveno
- Přidána změna prahu výšky hlavy každé pózy
- Opraveny nesprávné pózy a nohy některých avatarů například při skoku
- Spotřeba ExpressionParameter snížena z 54 na 16bit

## [1.6.0] - 2024-02-20
### Opraveno
- Opravena nemožnost přejít do sedu ve VR

## [1.5.0] - 2024-02-18
### Opraveno
- V režimu plochy lze nyní sedět i při stisknutém C

## [1.4.0] - 2024-02-17
### Opraveno
- Opravena nedostupnost propojení 添い寝 bez propojení 三点だいしゅき
- Opraveno zatuhnutí nohou při skoku

## [1.3.0] - 2024-02-16
### Opraveno
- Opraven abnormálně velký počet VRCContactSender/Receiver

## [1.2.0] - 2024-02-16
### Opraveno
- Opravena chyba sestavení při nahrávání

## [1.1.0] - 2024-02-15
### Opraveno
- Opraveny nesprávné výchozí hodnoty při použití více Prefabs
- Opraveno chybné nastavení propojení 可愛い座り

## [1.0.0] - 2024-02-14
### Vydání
