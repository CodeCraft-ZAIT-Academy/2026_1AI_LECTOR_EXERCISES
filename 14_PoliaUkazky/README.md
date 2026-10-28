# Polia (Arrays) – učebné pomôcky (AppsLab-015)

Solution s funkčnými ukážkami na **výklad polí**. Všetky projekty sa zostavia a bežia (okrem upozornení v poznámkach nižšie). Nie sú to úlohy na opravovanie – sú určené na premietanie a upravovanie naživo.

**Dôležité:** podľa osnovy sú polia **pred cyklami** (AppsLab-016). Preto ukážky **nepoužívajú cykly**. Celé pole sa vypisuje pomocou `string.Join(", ", pole)`. Výnimkou je ukážka 16 (bonusy z lekcie), ktorá cykly `for` potrebuje a je označená.

## Ako s tým pracovať
1. Otvor `PoliaUkazky.sln` vo Visual Studiu.
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5** (alebo Ctrl+F5).
3. V každom `Program.cs` je na začiatku komentár: čo ukázať a čo zmeniť naživo (*Skús zmeniť*). Pri výklade zmeň hodnotu, nechaj žiakov tipovať výsledok **pred** spustením a potom spusti.
4. Ukážka 7 je interaktívna (pýta si index). Ukážku 15 použi na ladenie (F9, F10, rozbalenie poľa v Locals).
5. Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

## Odporúčané poradie

| # | Projekt | Čo ukazuje | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Ukazka01_Creating` | Vytvorenie poľa a predvolené hodnoty | `new int[5]` vytvorí 5 prvkov. Predvolené hodnoty: 0, false, null. Celé pole sa vypíše cez `string.Join`, nie cez `Console.WriteLine(pole)`. |
| 2 | `Ukazka02_Indexes` | Index: prvý prvok má index 0 | Najčastejšia chyba začiatočníkov: číslovanie od 0. Posledný index je Length - 1. |
| 3 | `Ukazka03_Initialization` | Inicializácia poľa hneď pri vytvorení | Tri zápisy, rovnaký výsledok. Veľkosť určí kompilátor z počtu hodnôt. |
| 4 | `Ukazka04_Length` | Dĺžka poľa a posledný prvok | Length je počet prvkov. Posledný prvok je numbers[numbers.Length - 1]. Pole môže byť aj prázdne. |
| 5 | `Ukazka05_OtherTypes` | Polia rôznych typov | Pole môže obsahovať ľubovoľný typ, ale všetky prvky majú rovnaký typ. |
| 6 | `Ukazka06_Modify` | Zmena prvkov poľa a výmena | Prvky sa dajú čítať aj prepisovať. Výmena dvoch prvkov potrebuje pomocnú premennú. |
| 7 | `Ukazka07_IndexVariable` | Index z premennej (interaktívna) | Index môže byť premenná alebo výraz. Zadanie hodnoty mimo poľa spôsobí výnimku (na ďalšiu ukážku). |
| 8 | `Ukazka08_ArrayProcessor` | Referenčné riešenie cvičenia: ArrayProcessor | Metódy z cvičenia AppsLab-015. Pole sa posiela do metódy ako parameter. Pre prázdne pole vracajú 0. |
| 9 | `Ukazka09_OutOfRange` | Pozor na pretečenie: IndexOutOfRangeException | Platné indexy sú 0 až Length - 1. Index mimo poľa spôsobí výnimku. Ochrana: skontrolovať index podmienkou. |
| 10 | `Ukazka10_TwoDimensional` | Dvojrozmerné polia (matica) | int[,]: dva indexy [riadok, stĺpec]. Dvojrozmerné pole je tabuľka. Príklad: piškvorky. |
| 11 | `Ukazka11_StringAsArray` | Reťazec ako pole znakov | K znakom reťazca pristupujeme indexom. Reťazec sa nedá meniť po znakoch; pole znakov (char[]) áno. |
| 12 | `Ukazka12_ReferenceCopy` | Bonus: pole je odkaz (kópia poľa) | Nad rámec lekcie, ale veľmi dôležité: `int[] b = a;` nevytvorí kópiu. Obe premenné ukazujú na to isté pole. |
| 13 | `Ukazka13_ArrayMethods` | Užitočné metódy triedy Array | Array.IndexOf, Sort, Reverse, Copy, Clear. Pracujú s celým poľom bez cyklov. |
| 14 | `Ukazka14_Grades` | Motivácia k cyklom: známky | Súčet, priemer a minimum z 5 hodnôt ručne cez indexy. Čo keby ich bolo 100? → cykly (AppsLab-016). |
| 15 | `Ukazka15_DebugWalkthrough` | Polia v debuggeri | Rozbaľte pole v Locals, pozrite prvky `[0]`, `[1]`…, Watch pre `numbers[1]` a `numbers.Length`. |
| 16 | `Ukazka16_BonusLoops` | Bonusy z lekcie (vyžadujú cykly) | Riešenia bonusových cvičení. Používajú cykly `for` (AppsLab-016) – pre rýchlejších žiakov alebo po cykloch. |

## Návrh ako rozdeliť hodinu
- **Úvod (1–4):** vytvorenie poľa, index od 0, inicializácia, `Length` – 20 minút.
- **Typy a zmeny (5–7):** polia rôznych typov, zmena prvkov a výmena, index z premennej – 15 minút.
- **Cvičenie z lekcie (8):** `ArrayProcessor` – referenčné riešenie pre učiteľa; žiaci si ho skúšajú sami v AppsLab repozitári – 15 minút.
- **Pozor na pretečenie (9):** `IndexOutOfRangeException` a ochrana podmienkou – 10 minút.
- **Rozšírenia (10–11):** dvojrozmerné polia, reťazec ako pole znakov – 15 minút.
- **Bonusy (12–16):** pole je odkaz (kópia), metódy triedy `Array`, motivácia k cyklom, debugger, bonusy z lekcie – podľa času.

## Poznámky
- Ukážky 8, 16 a časť 9 obsahujú riešenia cvičení – nezdieľajte ich so žiakmi skôr, než ich sami skúsia.
- Ukážka 12 (pole je odkaz) je mimo lekcie, ale je to najčastejšie nepochopená vlastnosť polí.
- Ukážka 9 obsahuje zakomentovaný riadok, ktorý spôsobí výnimku – odkomentujte ho pri výklade a spustite s F5, aby žiaci videli, ako debugger zastaví program.
- Cykly sa v ukážkach vedome nepoužívajú; ukážka 14 ukazuje, prečo ich budeme potrebovať.

Nadväzuje: `OpravaPolia` (pokazené programy na opravovanie).
