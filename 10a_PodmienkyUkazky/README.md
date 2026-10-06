# Podmienky – učebné pomôcky (AppsLab-013)

Solution s funkčnými ukážkami na **výklad** podmienok. Všetky projekty sa zostavia a bežia. Nie sú to úlohy na opravovanie – sú určené na premietanie a upravovanie naživo.

## Ako s tým pracovať
1. Otvor `PodmienkyUkazky.sln` vo Visual Studiu.
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5** (alebo Ctrl+F5).
3. V každom `Program.cs` je na začiatku komentár: čo ukázať a čo zmeniť naživo (*Skús zmeniť*). Pri výklade zmeň hodnotu, spusti znova a nechaj žiakov tipovať výsledok **pred** spustením.
4. Interaktívne ukážky (11, 12) si pýtajú vstup z klávesnice.
5. Ukážku 17 použi aj na ladenie (breakpoint F9, krokovanie F10).

Na rozdiel od solution s pokazenými programami tu Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

## Odporúčané poradie

| # | Projekt | Čo ukazuje | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Ukazka01_Comparisons` | Porovnávanie a typ bool | Každé porovnanie má odpoveď True alebo False. Zdôraznite rozdiel `=` (priradenie) a `==` (porovnanie). |
| 2 | `Ukazka02_If` | Podmienka if | Blok v `{ }` sa vykoná len keď je podmienka pravdivá. Riadky mimo bloku sa vykonajú vždy. |
| 3 | `Ukazka03_IfElse` | if a else | Presne jedna z dvoch vetiev sa vykoná. `else` nemá podmienku. |
| 4 | `Ukazka04_ElseIf` | else if – viac možností | Podmienky sa vyhodnocujú zhora nadol, vykoná sa prvá pravdivá a zvyšok sa preskočí. |
| 5 | `Ukazka05_Boundaries` | Hraničné hodnoty | Najčastejšia chyba: `>` namiesto `>=`. Vždy testujte hodnoty presne na hranici. |
| 6 | `Ukazka06_LogicalOperators` | Logické operátory && || ! | `&&` = obe pravdivé, `||` = aspoň jedna pravdivá, `!` = obráti hodnotu. Pravdivostná tabuľka. |
| 7 | `Ukazka07_ElseIfOrder` | Na poradí vetiev záleží | Rovnaké vetvy v zlom poradí dajú zlý výsledok. Najprv najprísnejšia podmienka. |
| 8 | `Ukazka08_Nested` | Vnorené podmienky | Podmienka vnútri podmienky vs. jedna zložená podmienka s `&&`. Vnorenie dá presnejšiu správu. |
| 9 | `Ukazka09_Modulo` | Zvyšok po delení a deliteľnosť | `%` vráti zvyšok. Párne číslo má zvyšok 0 po delení 2. FizzBuzz ukazuje poradie + `&&`. |
| 10 | `Ukazka10_Strings` | Porovnávanie textov | Texty sa porovnávajú cez `==`, ale rozlišujú sa veľké a malé písmená. `ToLower()` to rieši. |
| 11 | `Ukazka11_Calculator` | Kalkulačka (z lekcie, interaktívna) | Príklad z lekcie AppsLab-013 s načítaním vstupu. Vnorená podmienka pri delení. |
| 12 | `Ukazka12_TicketPrice` | Cena vstupenky (&& a ||, interaktívna) | Zložená podmienka s `||` a `&&`. Zátvorky určujú poradie vyhodnotenia. |
| 13 | `Ukazka13_GameRules` | Metódy vracajúce bool (GameRules) | Podmienka môže byť priamo návratová hodnota. Dlhá a krátka forma robia to isté. |
| 14 | `Ukazka14_Pitfalls` | Galéria pascí (správne riešenia + chybné varianty v komentároch) | Žiaci vidia správny kód a v komentári chybnú verziu s vysvetlením. Odkomentujte na ukážku chyby. |
| 15 | `Ukazka15_RockPaperScissors` | Kameň, nožnice, papier | Zložená podmienka s `||` a `&&` nad textami. Dobrý príklad na rozloženie problému. |
| 16 | `Ukazka16_TernaryBonus` | Bonus: trojmocný operátor a skrátená syntax | Mimo lekcie – iba pre rýchlejších žiakov. Skrátená syntax bez `{ }` sa neodporúča. |
| 17 | `Ukazka17_DebugWalkthrough` | Krokovanie v debuggeri (príbeh hry) | Prejdite program klávesom F10 a sledujte, ktorou vetvou program ide. Prepojenie s Debuggovaním. |

## Návrh ako rozdeliť hodinu
- **Úvod (ukážky 1–3):** bool, `if`, `else` – asi 15 minút.
- **Viac možností (4–7):** `else if`, hranice, `&&`/`||`/`!`, poradie vetiev – 20 minút.
- **Praktické príklady (8–12):** vnorenie, `%`, texty, kalkulačka, cena vstupenky – 20 minút.
- **Metódy a pasce (13–14):** `GameRules` z lekcie, galéria pascí – 10 minút.
- **Rozšírenia (15–17):** kameň-nožnice-papier, bonus, krokovanie – podľa času.

Súvisiace: `OpravaPodmienok` (24 pokazených programov na opravovanie) a `04_Podmienky.docx` (plán hodiny).
