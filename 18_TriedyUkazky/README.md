# Triedy (OOP, úvod) – učebné pomôcky (AppsLab-020)

Solution s funkčnými ukážkami na **výklad tried a objektov**. Z lekcie OOP preberáme **iba triedy**: vlastnosti, metódy, konštruktor, objekty, referencie. **Nie** zapuzdrenie (`private`), dedičnosť, polymorfizmus ani abstrakciu – tie sú samostatné témy. Nie sú to úlohy na opravovanie – sú určené na premietanie a upravovanie naživo.

Ukážky využívajú to, čo žiaci poznajú: premenné, operátory, `if`, polia, cykly, `List`, metódy (aj preťaženie).

## Ako s tým pracovať
1. Otvor `TriedyUkazky.sln` vo Visual Studiu.
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5** (alebo Ctrl+F5).
3. V každom `Program.cs` je na začiatku komentár: pojmy a čo zmeniť naživo (*Skús zmeniť*). Pri výklade zmeň hodnotu, nechaj žiakov tipovať výsledok **pred** spustením a potom spusti.
4. Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

## Čo je pre žiakov nové
- Kľúčové slovo `class` a `public` (podľa lekcie: „`public` – trieda je prístupná odkiaľkoľvek“; zatiaľ píšeme `public` všade, o `private` je až zapuzdrenie).
- Vlastnosť `{ get; set; }` – zatiaľ ju berieme ako „premenná patriaca objektu“.
- `new` a kľúčové slovo `null`.
- Triedy sa v `Program.cs` píšu **pod príkazmi**. Keby ich napísali nad príkazy, kompilátor ohlási chybu CS8803.

## Odporúčané poradie

| # | Projekt | Čo ukazuje | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Ukazka01_PrvaTrieda` | Trieda, objekt, vlastnosti, new | Trieda = plán (formulár), objekt = vyplnený formulár. `new` vytvorí objekt. Trieda sa píše POD príkazmi. |
| 2 | `Ukazka02_DvaObjekty` | Viac objektov z jednej triedy | Každý objekt má vlastné hodnoty. Zmena jedného neovplyvní druhý. Nenastavená vlastnosť má predvolenú hodnotu (null, 0). |
| 3 | `Ukazka03_Metody` | Metódy v triede | Metóda patrí objektu a vidí jeho vlastnosti (Name, Age). Vždy pracuje s tým objektom, na ktorom ju voláme. |
| 4 | `Ukazka04_MetodyParametre` | Metódy s parametrami a návratovou hodnotou | Rovnako ako pri bežných metódach (AppsLab-018): parametre dnu, return von. Navyše metóda vidí vlastnosti objektu. |
| 5 | `Ukazka05_Konstruktor` | Konštruktor | Konštruktor = špeciálna metóda, ktorá sa zavolá pri `new`. Má meno ako trieda a nemá návratový typ. Môže ich byť viac (preťaženie, AppsLab-019). |
| 6 | `Ukazka06_Inicializator` | Predvolené hodnoty a inicializátor objektu | Vlastnosť môže mať predvolenú hodnotu (`= 100`). Inicializátor `new X { A = 1 }` nastaví vlastnosti naraz, bez konštruktora. |
| 7 | `Ukazka07_PoleObjektov` | Pole objektov | Pole objektov sa najprv vytvorí prázdne (samé null). Každý prvok treba samostatne vytvoriť cez new. Potom for / foreach ako pri číslach. |
| 8 | `Ukazka08_ListObjektov` | List objektov | List<Product> sa používa ako List<int>: Add, Count, foreach, Remove. Prvky sú objekty, takže cez bodku sa dostaneme k ich vlastnostiam. |
| 9 | `Ukazka09_ObjektAkoParameter` | Objekt ako parameter a návratová hodnota | Metóda môže dostať objekt a zmeniť ho (zmena je viditeľná aj vonku), alebo objekt vytvoriť a vrátiť. |
| 10 | `Ukazka10_Referencie` | Premenná drží odkaz na objekt | Dôležité: `Dog b = a;` nevytvorí nového psa, len druhý odkaz na toho istého. `==` porovnáva odkazy, nie obsah. |
| 11 | `Ukazka11_NullReference` | null a NullReferenceException | Premenná bez objektu je null. Cez null sa nedá pristupovať k vlastnostiam. Najčastejšia chyba pri práci s objektmi. |
| 12 | `Ukazka12_ObjektVObjekte` | Objekt ako vlastnosť iného objektu | Vlastnosť môže byť iná trieda (Person má Address). Vnorený objekt treba tiež vytvoriť cez new, inak je null. |
| 13 | `Ukazka13_HrdinaAPriesera` | Dve triedy spolu | Objekt jednej triedy dostane iný objekt v parametri a upraví ho. Základ pre RPG simulátor z lekcie. |
| 14 | `Ukazka14_SamostatnySubor` | Trieda v samostatnom súbore | V praxi má každá trieda vlastný súbor (Book.cs). Ukáž: pravý klik na projekt → Add → Class. Nič iné sa nemení. |
| 15 | `Ukazka15_Banka` | Bankový účet: dáta a metódy spolu | Dáta (Balance) a správanie (Deposit, Withdraw) sú pokope. Ale Balance sa dá prepísať aj priamo – tým motivujeme zapuzdrenie (ďalšia téma). |
| 16 | `Ukazka16_RpgBitka` | RPG bitka (úloha z lekcie) | Referenčné riešenie úlohy z lekcie: Character, Enemy, Battle. Bez dedičnosti, preto sú Character a Enemy podobné (duplicitný kód). Pri dedičnosti sa to zjednotí. |
| 17 | `Ukazka17_LadenieObjektov` | Ladenie: pozeranie objektov v debuggeri | Debugger s objektmi: v okne Locals / Autos rozbaliť objekt šípkou, F11 vstúpi do metódy objektu, Watch `students[1].Grade`. |

## Návrh ako rozdeliť hodinu
- **Základ (1–3):** trieda, objekt, vlastnosti, metódy – 30 minút. Prirovnanie: trieda = formulár, objekt = vyplnený formulár.
- **Metódy a konštruktor (4–6):** parametre, return, konštruktor, inicializátor – 20 minút.
- **Objekty v kolekciách (7, 8):** pole a `List` objektov – 15 minút.
- **Odkazy a null (9–11):** najdôležitejšia časť – 20 minút. Žiaci sa tu najčastejšie mýlia.
- **Skladanie tried (12–14):** vnorený objekt, spolupráca tried, samostatný súbor – 20 minút.
- **Zhrnutie (15, 16):** bankový účet (motivácia pre zapuzdrenie) a RPG bitka z lekcie – podľa času.
- **Ladenie (17):** objekty v debuggeri – 10 minút.

## Odpovede k ukážke 17 (ladenie)
- STOP 1: `students[1]` je Boris, `Grade = 3` (pred zlepšením).
- STOP 2: po F11 si v metóde `Improve()`. V okne *Locals* je `this` (objekt Borisa: `Name = "Boris"`, `Grade = 3`). `Grade` sa po riadku zmení na 2.
- STOP 3: `sum = 5` (1 + 2 + 2). Watch `students[1].Grade` ukazuje 2.

## Poznámky
- Ukážka 16 (RPG bitka) je referenčné riešenie úlohy z lekcie – nezdieľajte ju so žiakmi skôr, než ju sami skúsia.
- Ukážka 15 zámerne ukazuje, že `Balance` sa dá zmeniť priamo. Je to príprava na tému zapuzdrenie.
- Ukážka 14 má v projekte druhý súbor `Book.cs`.
- Konštruktory a preťaženie (5) nadväzujú na AppsLab-019.

Nadväzuje: `OpravaTriedy` (pokazené programy na opravovanie). Predchádzajúce: `CykleUkazky`.
