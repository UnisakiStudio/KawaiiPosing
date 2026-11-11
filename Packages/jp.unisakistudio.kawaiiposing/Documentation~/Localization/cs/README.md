# Kawaii Posing Tool

Nástroj pro zamykání póz ve VRChat, který umožňuje roztomilé sedící a ležící pózy i se sledováním 3 bodů a v režimu plochy. Obsahuje celkem 85 póz: 15 ve stoje, 20 v podřepu, 17 vsedě, 16 na břiše a 17 na zádech.

Tento README je určen pro vyvíjenou verzi v3.2.0. Datum oficiálního vydání zatím nebylo stanoveno. Nainstalovaná verze se zobrazuje nahoře v Inspectoru.

- [Stránka produktu na BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Historie změn](CHANGELOG.md)

## Jazyk rozhraní a offline dokumentace

Vyberte jazyk v poli „Language / 言語“ nahoře v Inspectoru. Jedna volba řídí Inspector i vytvářenou nabídku VRChat. Pro změnu jazyka ve hře avatara znovu nahrajte.

Pokud jazyk není vybrán, použije se jazyk počítače; nepodporované jazyky přejdou na angličtinu. Podporovány jsou Windows, macOS a Linux. Poslední volba se ukládá do EditorPrefs a používá se i v dalších projektech stejného uživatele OS na tomto počítači. Všechny nástroje pro pózování a avataři používají stejný jazyk. Změna v Inspectoru kteréhokoli nástroje aktualizuje společné nastavení; volby jazyka jednotlivých avatarů se ignorují. Mezi počítači se nesynchronizuje. Způsob ukládání licencí se nemění. Tlačítko jazyka se zobrazí pouze při prvním potvrzení instalace, pokud ještě není uložen žádný jazyk. Pozdější změny jazyka se provádějí v Inspectoru.

README, historii změn a návod lze vybrat v přiloženém [seznamu jazyků](../index.html). Návod a historie změn v Inspectoru také používají vybraný jazyk. Původní podmínky použití a referenční překlady jsou nadále dodávány samostatně.

## Hlavní funkce

- Režim focení: posune avatara až 3m dopředu a upraví směr. Jen na vlastní obrazovce spotřebuje 0 bit, zobrazení polohy a směru ostatním 16 bit.
- Zobrazení hlavy při focení: zabrání skrytí hlavy vlastního avatara zblízka pouze během režimu focení.
- Výška podlahy: posune celé tělo včetně hlavy o 3m nahoru či dolů. 50% je původní výška a počáteční hodnota, 0% o 3m níže a 100% o 3m výše. Doplňuje Výšku chodidel, která upravuje stranu nohou při zachování polohy hlavy.
- Přetočit se: v podporovaných ležících pózách přetáčí tělo doleva a doprava podle náklonu hlavy.
- Dýchání: přidává pohyb například hrudníku. Pro jednotlivé kategorie lze vybrat Žádné, Slabé, Střední, Silné, Rychlé nebo Vlastní.
- Vypnout pohupování VRChat v klidu: omezuje výchozí pohupování a zachovává dýchání nástroje i další vlastní pohyby.
- Omezit deformaci pózy při otočení hlavy: omezuje deformaci po odemknutí hlavy, pokud její směr neodpovídá původní póze.
- Volba funkcí: přidává jen potřebné herní nabídky a ukazuje spotřebu ExpressionParameters v Inspectoru.
- Hledání, hromadné přidání a řazení póz: hledání napříč kategoriemi, načtení více klipů a určení cílového pořadí.
- Lehký náhled v Scene: kontrola pózy přímo ze seznamu pomocí Náhledu.

- Automatická korekce končetin (IK): přizpůsobuje polohu rukou a nohou podporovaných póz proporcím avatara. Lze ji přepínat pro jednotlivé pózy a výsledek uložit do korekční animace.

### Přetáčení přiložených póz

Pózy na zádech Nohy vpřed, Uvolnění a Jedno koleno vzhůru mají přiřazené boční pózy pro přetočení. Základem jsou postupně pózy „Spánek na boku“, „Dřímání“ a „Kočičí spánek“.

Zapněte „Funkce > Funkce nabídky > Přetočit se“, nahrajte avatara a ve VRChat vyberte podporovanou pózu a Přetočit se. Hlavu před použitím odemkněte.

Pro vlastní nastavení zapněte „Pózy > Podrobnosti > Zapnout přetočení“ a přiřaďte animaci do Boční pózy přetočení. U póz s přetočením není běžné nastavení MotionTime dostupné.

### Přizpůsobení proporcím

Přiloženou automatickou korekci končetin lze použít, ale ne všechny pózy potřebují IK. Zapnout automatickou korekci končetin v okně Úprava animace přepíná celou funkci, Zapnout IK této pózy jednotlivou pózu.

Zapéct IK do korekcí zapíše aktuální automatický výsledek do nové korekční animace a vypne IK cílové pózy. Poté lze výsledek dokončit ručně. Funkce je dostupná při zapnuté celkové i individuální korekci a použitelném nastavení IK.

V Nastavení avatara jsou také Zabránit ohybu kolen dozadu a Minimální ohyb kolena (stupně) v podrobnostech.

## Instalace

1. Stáhněte soubory ze stránky produktu v obchodě, kde jste nakoupili.
2. Importujte přiložený „可愛いポーズツール.unitypackage“ do Unity a zaregistrujte licenci i zdroj balíčků.
3. Přes VCC nebo ALCOM přidejte Kawaii Posing Tool a Modular Avatar do požadovaného projektu Unity. Společný Unisaki Posing System a NDMF se nainstalují jako závislosti.
4. Klikněte pravým tlačítkem na cílového avatara v Hierarchy a zvolte „Unisaki Studio > Přidat Kawaii Posing“.
5. Vyberte 可愛いポーズ (Kawaii Posing) přidaný do avatara a nastavte v Inspectoru požadované funkce a pózy.
6. Nahrajte avatara běžným způsobem.

Požadováno je Unity 2022.3, VRChat Avatars SDK 3.10.4 nebo novější, Modular Avatar 1.x od 1.15.1 a NDMF 1.x od 1.14.0. Aktualizujte potřebné balíčky společně přes VCC nebo ALCOM.

## Aktualizace ze starší verze

Aktualizujte tento produkt a Unisaki Posing System společně. Nastavení již umístěných nástrojů se zachová. Zkontrolujte funkce a spotřebu ExpressionParameters v Inspectoru. Pokud jste používali předgenerování, před novým nahráním stiskněte Aktualizovat předgenerování.

Od v3.1.0 používají nová přidání běžný Prefab 可愛いポーズ (Kawaii Posing). Vypnutím nepotřebných funkcí získáte minimální konfiguraci jen s výběrem póz za 8 bit. Velký počet póz může vyžadovat další bity pro výběr.

Starý 8bit Prefab zůstává v Editor/Legacy pro zachování odkazů existujících avatarů a předvoleb. Není nutné jej mazat ani nahrazovat. V nabídce nového přidání Unity se 8bit verze nezobrazuje.

## Umístění nastavení

| Karta | Možnosti |
| --- | --- |
| Funkce | Přidání herních nabídek, usnadnění, dýchání a kontrola ikon i spotřeby ExpressionParameters |
| Pózy | Výběr používaných póz, podrobnosti, hledání, hromadné přidání, pořadí, náhled a úprava animace |
| Nastavení avatara | Korekce avatara a kolen, import původních póz a vlastních pohybů, změna předvoleb |

Otevřít nastavení rozbalí podrobné možnosti pod příslušnou položkou. Dýchání se nastavuje přes „Funkce > Usnadnění > Animovat dýchání“.

Použít původní pózy ve stoje, v přikrčení a na břiše automaticky importuje existující pózy avatara. Vlastní pohyby se přiřazují samostatně přes nastavení importu pro každý typ, například stoj, přikrčení (Crouching) a leh na břiše (Prone).

Předvolby jsou dole v Nastavení avatara. Použít tuto předvolbu nahrazuje aktuální nastavení póz, proto před změnou uložte hotové úpravy.

### Spotřeba jednotlivých funkcí

- Pohyb dýchání používá 0 bit. Jen herní přepínač zastavení a spuštění „Funkce nabídky > Dýchání“ používá 1 bit pro synchronizaci.
- Režim focení pouze na vlastní obrazovce používá 0 bit. „Usnadnění > Synchronizovat režim focení“ používá 16 bit. Ponechat hlavu viditelnou v režimu focení používá 0 bit.
- Výška chodidel i Výška podlahy používají každá 8 bit. Odchýlení výšky podlahy od středu posune tělo nahoru či dolů a návrat přibližně k 50% ukončí korekci.
- Přetočení samostatně používá 10 bit. Sdílí 1 bit s omezením deformace při otočení hlavy, proto obě funkce dohromady používají 10 bit.
- Zrcadlit a Gesta vyp. používají každá 1 bit.

Součet v Inspectoru se týká nástrojů pro pózy instalovaných na avatarovi. Nezahrnuje oblečení ani jiné funkce. Společná nastavení více nástrojů se nepočítají opakovaně.

### Náhled a úprava póz

Náhled u každé pózy na kartě Pózy ji zobrazí v Scene. Pro jemné změny otevřete Úpravu animace, upravte pózu s náhledem a uložte.

Lehký náhled neprovádí sestavení MA ani NDMF. Oblečení a korekci polohy podlahy přidávané během sestavení ověřte i v sestaveném výsledku před nahráním.

Karta s lupou vlevo hledá názvy póz. Cílové místo vyberete v „Podrobnosti > Pořadí“ nebo tlačítky nahoru a dolů. Více animací přidáte přetažením do přidávací oblasti nebo příkazem pro import klipů vybraných v Project.

Aktualizovat obrázky póz generuje obrázky po potvrzení. Generovat ikony póz usnadňuje rozlišení v herní nabídce, ale vytváření obrázků prodlužuje sestavení. Pro snížení velikosti zvolte Zmenšit velikost ikon. Pro Android se ikony póz negenerují.

## Základní ovládání ve hře

- V nabídce Expressions vyberte pózy jednotlivých kategorií. Ve VR se stoj, podřep, sed a leh přepínají podle výšky hlavy.
- Vleže směr obličeje přepíná záda a břicho. Pokud jsou vybrány obě pózy, lze je přepínat i skokem na místě. To vypnete v Unity přes „Funkce → Usnadnění → Měnit ležící pózy skokem“ (ve výchozím stavu zapnuté). Výšku přepínání kategorií upravují prahy v nastavení.
- V režimu plochy přepínejte klávesami C a Z. Pokud Z nepřepne do lehu, zvyšte práh výšky pro leh v nastavení.
- Gesta vyp. používá tvar rukou z pózy místo gest prstů ovladače.
- Výška chodidel upravuje stranu nohou při zachování hlavy. Výška podlahy posouvá celé tělo včetně hlavy svisle. V nastavení jsou v tomto pořadí.
- Posun dopředu pomocí Vzdálenosti v režimu focení obrátí avatara k vám. Směr jej otáčí a Zamknout nohy zapněte ve vhodnou chvíli. Ukončit focení obnoví vzdálenost i směr a odemkne nohy.
- Dýchání je dostupné, pokud je pohyb dýchání zapnutý. Intenzita se nastavuje v Unity a ve hře se přepíná zapnutí.

## Předgenerování a varování

Aktualizovat předgenerování urychluje sestavení avatara znovupoužitím vytvořených dat. Bez předgenerování potřebná data vzniknou při běžném sestavení.

Po změně nastavení upozorňují na aktualizaci Kontrola nastavení nahoře v Inspectoru a značka Hierarchy. Zobrazení varování je uvnitř rámečku Kontrola nastavení. Skrytí zobrazení neřeší problém konfigurace ani neobnovuje vytvořená data.

## Poznámky k používání

- Zamykání póz při celotělovém sledování není podporováno.
- Proporce, oblečení a úpravy avatara mohou vyžadovat další doladění.
- Zvláštní vrstvy Base a jiné systémy změny póz se nemusejí spojit podle očekávání. Pokud zámky nefungují, ověřte „Nastavení avatara > Propojit zámky sledování s dalšími nástroji“.
- Pohyb a otáčení režimu focení i výška podlahy korigují také výchozí a vlastní pohyby bez vybrané pózy. Ověřte pohled a chování po nahrazení výchozích pohybů přímo ve VRChat.
- Vypnout pohupování VRChat v klidu se týká výchozího klidového pohybu. Nezastavuje veškeré pohupování z jiných příčin.

## Návod a podpora

Horní panel nápovědy a historie změn v Inspectoru otevírá návod, kontakt a historii změn. Podrobné vysvětlení společných funkcí najdete také v Project Unity pod „Packages > Unisaki Posing System > README“.

- [Oficiální návod](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Kontaktovat podporu](https://help.unisakistudio.jp/)

Při hlášení chyby uveďte verze tohoto produktu a Unisaki Posing System, Unity, VRChat SDK, Modular Avatar a NDMF, použitého avatara, kroky k reprodukci a text chyby Console.

## Sdílení předvoleb

Následující informace se týkají dat vytvořených funkcí úpravy animace.

Korekční animační soubory vytvořené touto funkcí a předvolby nastavené s nimi můžete volně šířit a prodávat bez povolení Unisaki Studio. Sdílejte je například s vlastními avatary nebo jako předvolby avatarů, které nejsou přiložené k nástroji.

## Produkty s přiloženým nastavením propojení

Poznámka: nastavení propojení vytváří náš obchod z vlastní iniciativy. Povolení autorů příslušných produktů nepovažujeme za potřebné a nevyžádali jsme je. Žádosti o distribuci nebo ukončení distribuce těchto nastavení posílejte zprávami obchodu. Použití propojení vyžaduje zakoupení nebo stažení příslušného produktu. Při problému s nastavením kontaktujte náš obchod, nikoli autory těchto produktů.

„可愛い座りツール“
https://yunisaki.booth.pm/items/3611536

„添い寝ツール“
https://yunisaki.booth.pm/items/3670993

„少女モーション集vol.1“, autor ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

„VRC想定移動モーション（無料配布）“, autor カトのVRC道具屋
https://booth.pm/ja/items/1285101

„ごろ寝システムEX“, autor minminmart
https://minminmart.booth.pm/items/4233545

## Podmínky použití

Nástroj mohou používat pouze osoby, které souhlasí s následujícími podmínkami vytvořenými podle licence VN3.

[Podmínky použití (japonsky)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Zdrojový kód a prostředky tohoto repozitáře nejsou open source. Vyžaduje se řádné zakoupení produktu a souhlas s podmínkami použití.

[Podmínky použití (anglicky)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
