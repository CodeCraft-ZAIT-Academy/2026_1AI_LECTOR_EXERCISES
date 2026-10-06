# Boolean – učebné pomôcky (AppsLab-012)

Solution s funkčnými ukážkami na **výklad** typu `bool` a logických operátorov. Všetky projekty sa zostavia a bežia. Nie sú to úlohy na opravovanie – sú určené na premietanie a upravovanie naživo.

**Dôležité:** lekcia Boolean je pred lekciou Podmienky, preto ukážky **nepoužívajú `if`** – hodnoty sa iba ukladajú do premenných a vypisujú.

## Ako s tým pracovať
1. Otvor `BooleanUkazky.sln` vo Visual Studiu.
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5** (alebo Ctrl+F5).
3. V každom `Program.cs` je na začiatku komentár: čo ukázať a čo zmeniť naživo (*Skús zmeniť*). Pri výklade zmeň hodnotu, nechaj žiakov tipovať výsledok **pred** spustením a potom spusti.
4. Ukážka 10 je interaktívna (pýta si odpovede yes/no). Ukážku 11 použi na ladenie (F9, F10).
5. Na rozdiel od solution s pokazenými programami tu Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

## Odporúčané poradie

| # | Projekt | Čo ukazuje | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Ukazka01_Declaration` | Deklarácia a inicializácia bool | Dve hodnoty: `true` a `false`. V kóde malými písmenami, vo výpise `True` / `False`. |
| 2 | `Ukazka02_Comparison` | Porovnávacie operátory vytvárajú bool | Porovnanie je otázka a odpoveď je bool. Výsledok možno uložiť do premennej. |
| 3 | `Ukazka03_And` | Operátor AND (&&) | Obe strany musia byť pravdivé. Analógia: pláž len keď svieti slnko A ZÁROVEŇ je teplo. |
| 4 | `Ukazka04_Or` | Operátor OR (||) | Stačí jedna pravdivá strana. Analógia: dáždnik, ak prší ALEBO je zlé počasie. |
| 5 | `Ukazka05_Not` | Operátor NOT (!) | Obráti hodnotu. Dvojitá negácia vráti pôvodnú hodnotu. |
| 6 | `Ukazka06_TruthTables` | Pravdivostné tabuľky | Všetky kombinácie na jednom mieste. Dobrý podklad na tabuľu. |
| 7 | `Ukazka07_Precedence` | Priorita operátorov a zátvorky | `!` je prvé, potom `&&`, potom `||`. Zátvorky menia poradie a zlepšujú čitateľnosť. |
| 8 | `Ukazka08_RealLife` | Bool v praktických príkladoch | Kombinácia porovnávania a logických operátorov: vstup do kina, rok, interval. |
| 9 | `Ukazka09_BooleanLogicMethods` | Referenčné riešenie cvičenia: And, Or, Not | Metódy z cvičenia AppsLab-012. Metóda vráti hodnotu logického výrazu. |
| 10 | `Ukazka10_Interactive` | Interaktívna ukážka: odpovede áno/nie | Žiaci odpovedajú áno/nie a vidia, ako sa z odpovedí skladá výsledok. |
| 11 | `Ukazka11_DebugWalkthrough` | Krokovanie booleovských výrazov v debuggeri | Krokujte F10 a v okne Locals sledujte, ako sa z jednoduchých hodnôt skladajú zložitejšie. |
| 12 | `Ukazka12_BonusEquality` | Bonus 1: rovnosť dvoch boolov | `a == b` funguje aj pre bool. Výsledok je true, ak sú obe hodnoty rovnaké. |
| 13 | `Ukazka13_BonusAtLeastTwo` | Bonus 2: aspoň dve z troch | Skladanie viacerých boolov. Osem kombinácií sa dá vypísať a skontrolovať. |
| 14 | `Ukazka14_BonusXor` | Bonus 3: XOR | Práve jedna strana je true. Tri rôzne zápisy, rovnaký výsledok. |
| 15 | `Ukazka15_BonusDeMorgan` | Bonus: De Morganove zákony | Negácia výrazu sa dá prepísať. Overíme ich tabuľkou všetkých kombinácií. |
| 16 | `Ukazka16_BonusTextTruth` | Bonus 4: pravda v texte | Metóda `Contains` vracia bool. Pozor: slovo „nepravda“ obsahuje aj slovo „pravda“. |
| 17 | `Ukazka17_BonusShortCircuit` | Bonus: skrátené vyhodnocovanie && a || | Pravá strana sa nevyhodnotí, ak je výsledok jasný z ľavej. Operátory `&` a `|` vyhodnotia vždy obe. |

## Návrh ako rozdeliť hodinu
- **Úvod (ukážky 1–2):** čo je `bool`, porovnávacie operátory – 10 minút.
- **Logické operátory (3–6):** AND, OR, NOT, pravdivostné tabuľky – 15 minút.
- **Skladanie výrazov (7–8):** priorita a zátvorky, praktické príklady – 15 minút.
- **Cvičenie z lekcie (9):** metódy `And`, `Or`, `Not` – referenčné riešenie pre učiteľa, žiaci si ho skúšajú sami v AppsLab repozitári.
- **Prepojenie (10–11):** interaktívna ukážka a debugger – podľa času.
- **Bonusy (12–17):** bonusové cvičenia z lekcie, De Morganove zákony a skrátené vyhodnocovanie – pre rýchlejších žiakov.

Ukážky 9 a 12–16 sú riešenia cvičení a bonusov z lekcie – nezdieľajte ich so žiakmi skôr, než ich sami skúsia.
Nadväzuje: `PodmienkyUkazky` (ukážky na podmienky `if`/`else`).
