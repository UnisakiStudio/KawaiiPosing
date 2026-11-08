# Kawaii Posing Tool — česká uživatelská příručka

Kawaii Posing obsahuje 85 póz pro režim plochy a tříbodové VR: 15 ve stoje, 20 v přikrčení/na židli, 17 vsedě na podlaze, 17 na zádech a 16 na břiše.

Tato příručka popisuje instalaci, nastavení avatara, ovládání VRChat, úpravy póz, aktualizace a řešení problémů. `START_HERE.html` v zakoupeném ZIP nabízí nejrychlejší cestu k instalaci.

## Než začnete

- Použijte projekt **avatara** VRChat v Unity 2022.3 vytvořený nebo spravovaný přes VRChat Creator Companion (VCC) či ALCOM.
- Požadované balíčky: VRChat Avatars SDK 3.10.4 nebo novější; Modular Avatar 1.x od verze 1.15.1; NDMF 1.x od verze 1.14.0.
- Nástroj je určen pro avatary Humanoid v režimu plochy a tříbodovém VR (headset a dva ovladače). Zamykání póz při aktivním celotělovém sledování není podporováno.
- Před instalací nebo aktualizací zálohujte existující projekt. Nejprve vyřešte chyby kompilace Unity.
- Instalátor stahuje produkt a závislosti z jejich repozitářů balíčků. Je nutné připojení k internetu. Modely avatarů, VRChat SDK, Modular Avatar ani NDMF nejsou v tomto ZIP obsaženy.

## 1. Instalace licence a produktu

1. Rozbalte celý ZIP do běžné složky mimo projekt Unity.
2. Otevřete cílový projekt avatara v Unity. Importujte `Installer/KawaiiPosing_Installer.unitypackage` přes **Assets > Import Package > Custom Package** nebo soubor otevřete v Unity.
3. Přečtěte si výzvy importu a instalace. Potvrzení licence uvádí, které licence produktů se nainstalují. Jazyk instalátoru změníte přes **Jazyk…** (nebo **言語...**) v potvrzovacím dialogu.
4. Potvrďte instalaci licence. Licence zahrnuje i společný Unisaki Posing System používaný produktem. Instalátor pak může nabídnout odstranění vlastních instalačních souborů. Tento úklid neodstraní nainstalovanou licenci.
5. Zkontrolujte potvrzení automatického instalátoru balíčků. Uvádí přidávané balíčky a repozitáře i staré soubory či složky navržené k odstranění. Pokračujte, pokud jde o zamýšlené položky.
6. Počkejte na dokončení importu a kompilace Unity. Pokud se balíčky nenainstalují automaticky, otevřete projekt ve VCC nebo ALCOM a přidejte **Kawaii Posing Tool** a **Modular Avatar**. Společný **Unisaki Posing System** a **NDMF** jsou závislosti. `Optional-VCC-Links` obsahuje původní zástupce repozitářů produktu pro uživatele VCC ve Windows.
7. Pokud jste potvrzení zrušili, importujte instalátor znovu, až budete připraveni. Dokud je aktivátor přítomen, lze použít i jeho příkaz instalace licence v **Tools > Unisaki Studio**. Ve starších sestaveních se toto podmenu jmenuje **ゆにさきスタジオ**.

### Co tento soubor instaluje

**Kawaii Posing Tool 3.2.0 s Unisaki Posing System 3.2.0.** Tato verze se vyvíjí a dosud nebyla vydána. Přidává instalační dialogy, Inspector a nabídky Unity, standardní názvy póz, herní nabídky a offline dokumentaci ve 30 jazycích. Datum vydání nebylo stanoveno. Jazyk nástroje změníte volbou nahoře v Inspectoru. Po zveřejnění instalátor stáhne tyto verze a kompatibilní závislosti z repozitářů VPM. Místní příprava vydání balíčky nezveřejňuje.

Kawaii Posing Tool zahrnuje knihovnu póz, nástroje nastavení a předvolby přizpůsobení avatarů. Instalátor aktivuje dosavadní místní licenci produktu; nevyžaduje nové pole pro licenční klíč Gumroad. Nikdy nezveřejňujte instalační soubory ani licenční data ve veřejném požadavku na podporu.

Jazykové preference se ukládají přes Unity EditorPrefs pro aktuálního uživatele OS a sdílejí se mezi projekty Unity na tomto počítači. Bez uložené preference instalátor následuje jazyk OS, nepodporované jazyky používají angličtinu. Licence si zachovávají dosavadní ukládání: klíč registru aktuálního uživatele `Software/UnisakiStudio` ve Windows a uživatelské licenční soubory v macOS/Linux. Změna jazyka licenci neodstraní.

## 2. Přidání nástroje k avatarovi

1. V **Hierarchy** vyberte avatara s **VRC Avatar Descriptor** nebo jeho potomka. Použijte avatara umístěného ve scéně, nikoli prostředek Prefab v Project nebo Prefab Mode.
2. Klikněte na avatara pravým tlačítkem a zvolte **Unisaki Studio > Přidat Kawaii Posing**. Pokud instalovaná verze používá japonské nabídky, zvolte **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Nástroj se přidá dovnitř avatara. Uložený název objektu může zůstat **可愛いポーズ**, i když se zobrazované popisky překládají.
4. Pokud je nabídnuta odpovídající předvolba avatara, použijte ji jako počáteční přizpůsobení. Jinak otevřete **Nastavení avatara** a vyberte předvolbu nebo pózy upravte sami.
5. Instalátor může nabídnout předgenerování. Je volitelné; potřebná data vzniknou i při běžném sestavení. Opakované použití předgenerování zkracuje další sestavení.
6. Vyberte objekt nástroje, požadované pózy a funkce a nahrajte avatara běžně přes VRChat SDK.

### Výběr jazyka a známé popisky

Tato verze má **Language / 言語** nahoře v Inspectoru nástroje. Jedna volba řídí Inspector i generovanou herní nabídku. Avatar si ukládá vybraný jazyk a poslední volba se pamatuje pro další nástroje a projekty tohoto počítače. Pro změnu jazyka ve VRChat avatara znovu nahrajte.

Při práci podle starších japonských návodů použijte níže uvedenou tabulku popisků. Tato verze obsahuje volbu jazyka, lokalizovaný Inspector, přeložené standardní názvy póz a herní nabídky pro všech 30 jazyků.

| Český popisek | Japonský popisek ve starších verzích |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funkce | 機能 |
| Pózy | ポーズ一覧 |
| Nastavení avatara | アバター調整 |
| Otevřít nastavení | 設定を開く |
| Aktualizovat předgenerování | プレビルドを更新 |
| Kontrola nastavení | 設定の確認 |
| Náhled | プレビュー |
| Úprava animace | アニメーション調整 |
| Obnovit | 再読込 |

Přiložený Inspector, dialogy úprav a instalace, standardní názvy póz i vytvářené nabídky jsou přeložené do všech 30 volitelných jazyků. README, historie změn a offline návod jsou poskytovány v každém volitelném jazyce. Jména avatarů, uložené názvy objektů, vlastní názvy póz, názvy souborů prostředků a vnitřní identifikátory parametrů mohou zachovat původní zápis.

[Stručné příručky ve 30 jazycích](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) obsahují popisy funkcí a tabulky názvů standardních póz. Jde o krátké referenční materiály; úplnou dokumentaci otevřete přes seznam jazyků.

## 3. Výběr póz a funkcí

Inspector má tři hlavní karty:

| Karta | Použití |
| --- | --- |
| **Funkce** | Ovladače herní nabídky, volitelné chování, dýchání, ikony a spotřeba expression parametrů. |
| **Pózy** | Zapnuté pózy, kategorie a hledání, pořadí, přidání animací, náhled, podrobnosti a úprava animace. |
| **Nastavení avatara** | Korekce avatara a kolen, import původních/vlastních pohybů a předvolby. |

Zapínejte jen ovladače nabídky, které chcete používat. Například přidání **Zrcadlit** umožní přepínat zrcadlení ve VRChat, ale nenutí všechny pózy zůstat zrcadlené.

Kawaii Posing obsahuje předvolby avatarů a IK podporovaných póz. Tři standardní pózy na zádech mají již přiřazené boční pohyby: **Nohy vpřed (足伸ばし)**, **Uvolnění (リラックス)** a **Jedno koleno vzhůru (膝立て)**. Použijte odpovídající předvolbu a zkontrolujte přetočení jednotlivých póz, pokud jste položky upravili nebo nahradili.

### Předvolby a přizpůsobení

Předvolby jsou blízko konce **Nastavení avatara**. Vyhledejte podle jména avatara a použijte předvolbu k nahrazení aktuálních nastavení póz. Před změnou uložte nebo zálohujte úpravy. Předvolba je výchozí bod: proporce, oblečení a úpravy avatara mohou stále vyžadovat ruční korekce.

Použijte **Úpravu animace** u pózy pro náhled a úpravu polohy těla a končetin. Po dokončení uložte korekční animaci z tohoto okna. U podporovaných póz lze automatickou korekci rukou a nohou (IK) zapnout celkově i samostatně. Zapečení aktuálního výsledku vytvoří korekční animaci a vypne IK této pózy pro ruční doladění. Původní zdrojový klip zůstává.

**Zabránit ohybu kolen dozadu** má další nastavení, například minimální úhel ohybu. Korekce konkrétního avatara jsou dostupné jen s odpovídajícími daty a některé nelze kombinovat s IK pózy.

### Původní a vlastní pohyby

**Použít původní pózy ve stoje, v přikrčení a na břiše** zjišťuje pohyby z vrstvy Base avatara během generování. **Vlastní pohyby** otevře samostatné nastavení importu pro každý typ. Vyberte jeden pohyb na typ. Ruční přiřazení má přednost před automatickým importem tohoto typu.

Automatický import se používá na kopii pro sestavení. Nezapisuje nalezené animace zpět do ručního seznamu ve scéně ani neupravuje původní Controllery. Vymažte ruční přepsání typu, pokud chcete znovu použít automatické zjištění. Vlastní vrstvy Base a jiné systémy pohybu mohou vyžadovat individuální úpravy.

## 4. Používání ve VRChat

Otevřete nabídku **Expressions** avatara a vstupte do **Kawaii Posing**. Vyberte pózu pro každou požadovanou kategorii. Výběr pózy a zapnutí funkce jsou samostatné činnosti.

- **Tříbodové VR:** zvedejte a snižujte hlavu pro přepnutí mezi stojem, přikrčením/židlí, sedem na podlaze a lehem. Pokud se póza mění příliš brzy nebo pozdě, upravte výškové prahy v nastavení nástroje.
- **Režim plochy:** **C** pro přikrčení a **Z** pro leh. Pokud vás Z nechá sedět, zvyšte práh výšky pro leh v nastavení.
- **Záda/břicho:** směr obličeje vybírá leh na břiše nebo zádech. Pokud jsou vybrány oba, lze přepínat skokem na místě. Podle potřeby to vypněte v Unity přes **Funkce > Usnadnění**. Nezvyšuje to spotřebu synchronizovaných parametrů.
- **Zámky:** podle potřeby zamykejte hlavu, paže a nohy. Vypněte gesta, chcete-li tvar rukou z pózy místo vstupu ovladače.
- **Zrcadlit:** zrcadlete vybranou pózu pro natočení k příteli nebo vhodnou kompozici.

### Výška chodidel a výška podlahy

**Výška chodidel** upravuje chodidla při zachování polohy hlavy. Použijte ji, pokud nohy levitují nebo se zabořují, ale hlava je již ve správné výšce.

**Výška podlahy** posouvá celé tělo včetně hlavy. Použijte ji pro pohovku, postel nebo vyvýšený povrch, i u nábytku bez collideru. V aktuálním centrovaném ovladači společného systému je **50% původní výška**, 0% o 3 m níže a 100% o 3 m výše. Návrat přibližně k 50% ukončí posun. Starší verze mohou fungovat jinak. Ověřte nainstalovanou verzi a aktualizujte společný systém spolu s produktem.

### Režim focení

Před nahráním zapněte položku nabídky **Režim focení** v Unity. Ve VRChat vyberte pózu, pomocí **Vzdálenosti** posuňte avatara až 3 m vpřed a pomocí **Směru** jej otočte. Zamknutí nohou při přípravě záběru je volitelné. **Ukončit focení** obnoví vzdálenost i otočení a odemkne nohy.

Režim focení je ve výchozím stavu místní. Chcete-li polohu a otočení ukázat ostatním, zapněte v Unity před nahráním **Synchronizovat režim focení**; spotřebuje to 16 synchronizovaných bitů. **Ponechat hlavu viditelnou v režimu focení** ovlivňuje váš pohled a nepoužívá synchronizované bity.

### Dýchání a přetočení

Dýchání lze nastavit pro každou kategorii v **Funkce > Usnadnění > Animovat dýchání**. Zvolte Žádné, Slabé, Střední, Silné, Rychlé nebo vlastní animaci. Samotný pohyb nespotřebovává synchronizované bity. Přepínač dýchání v nabídce používá 1 bit.

Přetočení vyžaduje podporovanou ležící pózu a položku nabídky **Přetočit se**. Zapněte přetočení pro pózu a podle potřeby přiřaďte boční animaci. Ve VRChat vyberte tuto pózu, zapněte přetočení a odemkněte hlavu/krk. Náklon hlavy do stran pak řídí přetočení. Běžné ovládání MotionTime není pro tuto pózu během přetočení dostupné.

Tři standardní pózy na zádech uvedené výše obsahují boční pohyby. Ostatní pózy potřebují vhodný pohyb a nastavení. Importované nebo vlastní předvolby mohou mít odlišná přiřazení.

## 5. Úpravy, přidávání a náhled póz

Na kartě **Pózy** vyberte kategorii nebo hledání. Hledání přijímá původní japonské názvy i dostupné překlady. Otevřete **Podrobnosti** pózy pro úpravu animace, ikony, pořadí a časování.

Více animací přidáte přetažením klipů do přidávací oblasti nebo jejich výběrem v Project a příkazem pro import vybraných klipů. Duplicitní odkazy na stejný klip se odstraní. Cílové pořadí změňte v Podrobnostech nebo ovladači nahoru/dolů.

**Náhled** zobrazí pózu v Scene bez otevření celého okna úprav. Tento lehký náhled nespouští Modular Avatar ani NDMF, proto oblečení, korekci podlahy a další funkce při sestavení ověřte v konečném sestavení avatara.

Ikony generované z vašeho avatara pomáhají rozpoznat pózy, ale jejich tvorba trvá a může zvětšit data avatara. Snižte rozlišení ikon pro úsporu místa. Sestavení Android ikony póz nevytvářejí. Po změně avatara či oblečení je podle potřeby vytvořte znovu.

## 6. Paměť parametrů

Inspector ukazuje příspěvek nástrojů pro pózy, nikoli součet celého avatara. Oblečení a další systémy mohou využívat další paměť parametrů. Společná nastavení sdílená nástroji se nepočítají dvakrát. Vlastní konfigurace s mnoha dodatečnými pózami mohou potřebovat více bitů pro výběr.

| Funkce | Dodatečné synchronizované bity |
| --- | ---: |
| Výběr póz, minimální standardní konfigurace | 8 |
| Zrcadlit | 1 |
| Gesta vyp. | 1 |
| Pohyb dýchání | 0 |
| Přepínač dýchání v nabídce | 1 |
| Výška chodidel | 8 |
| Výška podlahy | 8 |
| Režim focení, pouze místní | 0 |
| Synchronizovat režim focení | 16 |
| Ponechat hlavu viditelnou při focení | 0 |
| Vypnout výchozí pohupování VRChat | 0 |
| Přetočit se | 10 |

Přetočení sdílí 1 bit s korekcí pózy podle směru krku. Zapnutí obou tedy stále používá celkem 10 bitů pro tyto dvě funkce. Zobrazená spotřeba ve vaší verzi je praktickým vodítkem pro zvolenou konfiguraci.

## 7. Aktualizace a předgenerování

1. Zálohujte projekt a uložte pracovní scénu.
2. Ve VCC nebo ALCOM aktualizujte **Kawaii Posing Tool** a společný **Unisaki Posing System** společně. Zachovejte také kompatibilní verze SDK, Modular Avatar a NDMF.
3. Počkejte na dokončení kompilace. Vyberte již instalovaný nástroj a zkontrolujte jeho pózy, nastavení a spotřebu parametrů.
4. Pokud používáte předgenerování, zvolte **Aktualizovat předgenerování** a avatara znovu nahrajte.

Existující nastavení nástroje se zachovává. Staré 8-bit prefaby zůstávají kvůli kompatibilitě; existující odkazy nevyžadují odstranění ani náhradu nástroje. Nové instalace používají běžný prefab a nepoužívané funkce lze vypnout pro snížení spotřeby parametrů.

Varování zastaralého předgenerování znamená, že se nastavení změnilo od vytvoření uložených dat. Aktualizace předgenerování data vytvoří znovu. Skrytí varování předgenerování neobnoví ani nevyřeší jeho příčinu. Běžné sestavení avatara může vytvořit potřebná data i bez ručního předgenerování pokaždé.

## 8. Řešení problémů

| Příznak | Co zkontrolovat |
| --- | --- |
| Chybí nabídka přidání nástroje | Ověřte instalaci produktu **i** Unisaki Posing System a vyřešte chyby kompilace Unity Console. Samotný instalátor licence není knihovna póz. |
| Instalace zrušena nebo soubory odstraněny | Až budete připraveni, znovu importujte zakoupený instalátor a přečtěte potvrzení. |
| Licence chybí v jiném projektu | Importujte zakoupený instalátor pod stejným účtem OS. Po změně počítače či účtu nainstalujte licenci i tam. Jazykové preference se mezi počítači nepřenášejí automaticky. |
| Ve VRChat nejsou pózy | Přidejte nástroj pod správného avatara ve scéně, zapněte požadované pózy, zkontrolujte varování Inspectoru a nahrajte tohoto avatara. Ověřte SDK a další pohybové nástroje. |
| Z nepřepne do lehu | Zvyšte práh výšky pro leh v herním nastavení nástroje. |
| Ruce nebo kolena nesedí | Vyzkoušejte odpovídající předvolbu avatara a pak podporované IK nebo Úpravu animace. Ověřte deformaci oblečení v konečném sestavení. |
| Přetočení nefunguje | Použijte podporovanou ležící pózu, zapněte její přetočení i položku nabídky a odemkněte hlavu/krk. Nejdřív vyzkoušejte jednu ze tří podporovaných standardních póz. |
| Přátelé nevidí pohyb při focení | Zapněte **Synchronizovat režim focení** v Unity, zkontrolujte spotřebu parametrů a znovu nahrajte avatara. |
| Jazyk se mění v Unity, ale ne ve VRChat | Nahrajte avatara znovu. Ověřte jedinou volbu jazyka nahoře v Inspectoru verze s lokalizací. |
| Chyby sestavení nebo předgenerování | Přečtěte **první** související chybu Console. Zálohujte scénu, aktualizujte nebo znovu stáhněte produkt a společný systém přes VCC/ALCOM a kontaktujte podporu, pokud problém trvá. Zachovejte upravené objekty a GeneratedResources, pokud podpora nedá konkrétní pokyn k obnově. |

Pro podporu uveďte verze produktu a společného systému, Unity/SDK/Modular Avatar/NDMF, jméno avatara, přesné kroky k reprodukci a příslušnou chybu Console. Z veřejných příspěvků odstraňte soukromé soubory, obsah instalátoru, licenční hodnoty a údaje účtu.

- [Podpora](https://help.unisakistudio.jp/)
- [Ilustrovaný online návod (japonsky)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Stránka produktu Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licence a autoři

[Anglický referenční překlad smlouvy produktu](../../Terms.en.html) je dodáván spolu s původní japonskou smlouvou.

Přečtěte původní smlouvu produktu a smlouvu společného systému vedle README balíčku nebo ve složce `Licenses` zakoupeného ZIP. Dodaná anglická smlouva Unisaki Posing System je existující referenční překlad pro tento systém; japonská smlouva produktu je nadále přiložena zvlášť. Návod smlouvy nemění ani neuděluje další práva. S dotazy na používání nebo další šíření dat produktu kontaktujte podporu.

Instalátor obsahuje upravený **VPMPackageAutoInstaller** od **anatawa12** spolu se **SimpleJson** a **semver.net**. Jejich copyrightová oznámení a texty licencí MIT jsou v `ThirdPartyNotices.txt` zakoupeného ZIP. Knihovna póz a další prostředky mají vlastní produktové licence.
