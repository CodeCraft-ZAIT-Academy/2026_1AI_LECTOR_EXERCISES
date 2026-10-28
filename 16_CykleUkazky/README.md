# Cykly (Loops) – učebné pomôcky (AppsLab-016)

Solution s funkčnými ukážkami na **výklad cyklov**: `while`, `for`, `foreach`, `do-while`, `break`, `continue`. Všetky projekty sa zostavia a bežia. Nie sú to úlohy na opravovanie – sú určené na premietanie a upravovanie naživo.

Ukážky využívajú to, čo žiaci poznajú: premenné, operátory (aj skrátený zápis `+=`, `/=`, `++`), metódy, `bool`, `if`, polia. Novinky, ktoré treba povedať: operátor `+=` a trojmocný `? :` (je v príklade z lekcie), `Random` (ukážky 7 a 15).

## Ako s tým pracovať
1. Otvor `CykleUkazky.sln` vo Visual Studiu.
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5** (alebo Ctrl+F5).
3. V každom `Program.cs` je na začiatku komentár: čo ukázať a čo zmeniť naživo (*Skús zmeniť*). Pri výklade zmeň hodnotu, nechaj žiakov tipovať výsledok **pred** spustením a potom spusti.
4. Interaktívne ukážky: 7 (kontrola vstupu), 13 (súčet do nuly), 15 (hra hádaj číslo). Ukážku 17 použi na ladenie (F9, F10, podmienený breakpoint).
5. Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

## Odporúčané poradie

| # | Projekt | Čo ukazuje | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Ukazka01_While` | Cyklus while | Podmienka sa kontroluje pred každým prechodom. Treba tri veci: začiatočná hodnota, podmienka, zmena premennej. |
| 2 | `Ukazka02_For` | Cyklus for | Tri časti v jednom riadku: inicializácia; podmienka; zmena. Vhodný, keď vieme, koľkokrát sa má opakovať. |
| 3 | `Ukazka03_Foreach` | Cyklus foreach | Prejde všetky prvky poľa bez indexu. Prvok sa nedá cez foreach meniť. Aj reťazec je pole znakov. |
| 4 | `Ukazka04_SumAndCount` | Súčet, priemer a počítanie v poli | Premenná sum, ktorá sa zväčšuje v cykle (akumulátor). Operátor +=. Počítanie prvkov s vlastnosťou. |
| 5 | `Ukazka05_FindInArray` | Hľadanie v poli: foreach a break | Ak hľadaný prvok nájdeme, nemá zmysel pokračovať. `break` cyklus ukončí. |
| 6 | `Ukazka06_WhileUnknown` | while, keď nevieme počet opakovaní | Delenie dvoma, počítanie cifier, Collatzova postupnosť: nevieme dopredu, koľko krokov bude. |
| 7 | `Ukazka07_DoWhile` | Cyklus do-while: kontrola vstupu | Blok sa vykoná vždy aspoň raz, podmienka sa kontroluje až potom. Ideálne na opakované pýtanie vstupu. |
| 8 | `Ukazka08_BreakContinue` | break a continue | break cyklus ukončí, continue preskočí zvyšok aktuálneho prechodu a pokračuje ďalším. |
| 9 | `Ukazka09_NestedLoops` | Odpočítavanie a vnorené cykly | Cyklus v cykle: trojuholník z hviezdičiek, násobilka. Prvý cyklus je riadok, druhý stĺpec. |
| 10 | `Ukazka10_ArraysAndLoops` | Polia a cykly spolu | Naplnenie poľa, obrátenie poradia, súčet párnych a nepárnych, zmena prvkov cez for (nie foreach). |
| 11 | `Ukazka11_WeatherStats` | Referenčné riešenie cvičenia: WeatherStats | Priemer, maximum a minimum teplôt. Maximum a minimum začíname prvým prvkom poľa, nie nulou. |
| 12 | `Ukazka12_BonusMath` | Bonusy z lekcie: faktoriál a ciferný súčet | Faktoriál rastie veľmi rýchlo – `int` pretečie už pri 13!. Ciferný súčet cez while a % 10. |
| 13 | `Ukazka13_SumUntilZero` | Bonus: súčet čísel, kým nezadáš 0 (interaktívna) | Zadávanie čísel v cykle. Dve riešenia: do-while a while (true) s break. |
| 14 | `Ukazka14_FizzBuzzLoop` | FizzBuzz a prvočísla | FizzBuzz z lekcie Metódy, teraz s cyklom. Prvočísla: vnorený cyklus a skorý return. |
| 15 | `Ukazka15_GuessNumber` | Hra: hádaj číslo (do-while + Random) | Počítač vymyslí číslo 1 – 100, hráč hádá. Cyklus sa opakuje, kým nie je číslo uhádnuté. Spája cykly, podmienky a Random. |
| 16 | `Ukazka16_LoopPitfalls` | Galéria pascí v cykloch | Zlé varianty sú zakomentované: o jedna vedľa, chýbajúce i++, bodkočiarka za for, <= Length, foreach a zmena prvku. |
| 17 | `Ukazka17_DebugWalkthrough` | Cykly v debuggeri | Sledovanie premennej `i` a `sum` po jednotlivých prechodoch. Podmienený breakpoint (`i == 3`) – prvý raz sa hodí. |

## Návrh ako rozdeliť hodinu
- **Základy (1–3):** `while`, `for`, `foreach` – 25 minút. Dôležité: sledovacia tabuľka pre `while`, tri časti `for`.
- **Cykly s poľami (4, 5, 10):** súčet, priemer, hľadanie, plnenie poľa – 20 minút.
- **Ako vybrať cyklus (6, 7):** keď nevieme počet opakovaní: `while` a `do-while` – 15 minút.
- **break a continue (8):** 10 minút.
- **Cvičenie z lekcie (11):** `WeatherStats` – referenčné riešenie pre učiteľa; žiaci si ho skúšajú sami v AppsLab repozitári.
- **Bonusy a hry (12–15):** faktoriál, ciferný súčet, súčet do nuly, FizzBuzz, hádaj číslo – podľa času.
- **Pasce a ladenie (16, 17):** off-by-one, nekonečný cyklus, `<= Length` – 15 minút.

## Odpovede k ukážke 17 (ladenie)
| i | sum po prechode |
|---|---|
| 1 | 1 |
| 2 | 5 |
| 3 | 14 |
| 4 | 30 |
| 5 | 55 |

- Podmienený breakpoint `i == 3`: zastaví sa raz, `i = 3` a `sum = 5` (hodnota **pred** vykonaním riadku; po riadku bude 14).
- Úloha 4: pri `i == 3` je `i * i = 9` a `sum + i * i = 14` (to je hodnota `sum` po vykonaní riadku). Po cykle je `sum = 55` (premenná `i` už neexistuje – je len v cykle `for`).
- Pole `numbers` po druhom cykle: `101, 102, 103`.

## Poznámky
- Ukážky 11, 12, 13 a časť 4, 5, 10 obsahujú riešenia cvičení a bonusov – nezdieľajte ich so žiakmi skôr, než ich sami skúsia.
- Ukážka 9 (vnorené cykly) a 14 (prvočísla) idú nad rámec lekcie – pre rýchlejších žiakov.
- Ukážka 16 obsahuje zakomentované nekonečné cykly. Pri ich skúšaní ukážte, ako program zastaviť: Shift+F5 (ladenie), Ctrl+C (konzola).
- Ukážky 15 a 7 používajú `Random` – lekcia sa na ňu odvoláva (`/lekcie/Random.md`).

Nadväzuje: `OpravaCykly` (pokazené programy na opravovanie). Predchádzajúce: `PoliaUkazky`.
