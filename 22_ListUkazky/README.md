# List<T> – učebné pomôcky (AppsLab-017)

Solution s funkčnými ukážkami na **výklad `List<T>`**: vytvorenie, `Add`, `Count`, index, `Remove`, `RemoveAt`, `Insert`, `Contains`, `IndexOf`, `Sort`, `Reverse`. Všetky projekty sa zostavia a bežia. Nie sú to úlohy na opravovanie – sú určené na premietanie a upravovanie naživo.

Lekcia List je **pred** metódami a triedami, preto v ukážkach nie sú žiadne vlastné metódy ani triedy. Využívajú sa len premenné, `if`, `switch`, polia, cykly a `Random`.

## Ako s tým pracovať
1. Otvor `ListUkazky.sln` vo Visual Studiu.
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5** (alebo Ctrl+F5).
3. V každom `Program.cs` je na začiatku komentár: pojmy a čo zmeniť naživo (*Skús zmeniť*). Pri výklade zmeň hodnotu, nechaj žiakov tipovať výsledok **pred** spustením a potom spusti.
4. Interaktívne ukážky: 14 (zber čísel, ukonči `0`) a 17 (menu s menami). Ukážka 18 (lotéria) dáva pri každom spustení iný výsledok. Ukážku 19 použi na ladenie.
5. Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

## Čo je pre žiakov nové
- Zápis `List<int>`: v lomených zátvorkách je typ prvkov. Zatiaľ stačí „zoznam čísel“. Čo je to `<T>` (generiká) je až AppsLab-027.
- Metódy sa volajú cez bodku (`numbers.Add(5)`). Zatiaľ ich berieme ako hotové príkazy. Metódy si žiaci napíšu sami až v AppsLab-018.
- `Count` (nie `Length`) a `ForEach(Console.WriteLine)` (zápis z lekcie, funguje ako akési „zavolaj toto pre každý prvok“; lambda je až AppsLab-025).

## Odporúčané poradie

| # | Projekt | Čo ukazuje | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Ukazka01_PrvyList` | Prvý List: vytvorenie, Add, Count | List je „pole, ktoré rastie“. Vytvoríme ho cez new, pridávame cez Add, počet zistíme cez Count (nie Length). |
| 2 | `Ukazka02_RoznyTyp` | List<T>: T je typ prvkov | T v zátvorkách určuje, čo v liste bude: int, string, double, bool… Do listu sa dá pridať len prvok správneho typu. |
| 3 | `Ukazka03_Inicializator` | Naplnenie listu hneď pri vytvorení | Namiesto viacerých Add môžeme prvky napísať do { } pri vytvorení. Pozor: zložené, nie okrúhle zátvorky. |
| 4 | `Ukazka04_Index` | Čítanie a zmena prvku cez index | Index funguje ako pri poli (od 0), len namiesto Length je Count. Posledný prvok je na indexe Count - 1. |
| 5 | `Ukazka05_PoleAList` | Pole vs. List | Pole má pevnú veľkosť (Length), List rastie (Count). Pole ↔ List sa dá prevádzať. Ak vopred nevieme počet prvkov, použijeme List. |
| 6 | `Ukazka06_Prechadzanie` | Prechádzanie listu | foreach, for aj ForEach(Console.WriteLine) (príklad z lekcie). foreach je jednoduchý, for vieme použiť, keď potrebujeme index. |
| 7 | `Ukazka07_Odstranenie` | Remove, RemoveAt, Clear | Remove(hodnota) vymaže PRVÝ výskyt hodnoty a vráti true/false. RemoveAt(index) vymaže prvok na pozícii. Clear vyprázdni zoznam. |
| 8 | `Ukazka08_OdstranenieVCykle` | Odstraňovanie počas prechádzania cyklom | Počas foreach sa zoznam meniť nesmie (InvalidOperationException). Pri for + RemoveAt ideme odzadu, inak preskočíme prvky. |
| 9 | `Ukazka09_Insert` | Insert: vloženie na pozíciu | Insert(index, hodnota) vloží prvok na pozíciu a ostatné posunie. Add vždy pridáva na koniec. |
| 10 | `Ukazka10_ContainsIndexOf` | Contains a IndexOf | Contains vráti true/false (je tam?), IndexOf vráti pozíciu alebo -1 (kde je?). Typické použitie v if. |
| 11 | `Ukazka11_Triedenie` | Sort a Reverse | Sort zoradí vzostupne, Reverse otočí poradie. Obe menia pôvodný zoznam. Zostupne = Sort + Reverse. Zoznam textov sa triedi podľa abecedy. |
| 12 | `Ukazka12_Statistika` | Súčet, priemer, minimum a maximum | Rovnaké algoritmy ako pri poliach, len s Count. Pozor na celočíselné delenie pri priemere. |
| 13 | `Ukazka13_Filter` | Nový list z existujúceho | List rastie, takže môžeme z jedného zoznamu vyberať prvky do druhého (filtrovanie) bez toho, aby sme vopred vedeli, koľko ich bude. |
| 14 | `Ukazka14_VstupDoListu` | Zber hodnôt od používateľa | Nevieme dopredu, koľko čísel používateľ zadá. S poľom by to bolo ťažké, s Listom stačí while a Add. |
| 15 | `Ukazka15_Fronta` | Fronta (FIFO) pomocou listu | Cvičenie z lekcie (Queue) bez tried: Enqueue = Add na koniec, Dequeue = prečítať prvý prvok a RemoveAt(0). Kto prišiel prvý, ten odíde prvý. |
| 16 | `Ukazka16_Zasobnik` | Zásobník (LIFO) pomocou listu | Opak fronty: odoberáme posledný prvok. Príklad zo života: tlačidlo „Späť“ v prehliadači. |
| 17 | `Ukazka17_MenoMenu` | Bonus z lekcie: zoznam mien s menu | Referenčné riešenie bonusového cvičenia z lekcie: menu so switch, while a List<string>. |
| 18 | `Ukazka18_Loteria` | Hra: Lotéria (6 z 49) | Náhodné unikátne čísla: Random + Contains + Sort. Výstup je pri každom spustení iný. |
| 19 | `Ukazka19_LadenieListu` | Ladenie: pozeranie listu v debuggeri | V okne Locals sa rozbalí list: Count, Capacity a prvky [0], [1]… Zmeny sa po každom kroku (F10) zafarbia na červeno. |

## Návrh ako rozdeliť hodinu
- **Základ (1–4):** vytvorenie, `Add`, `Count`, typy, inicializátor, index – 25 minút. Prirovnanie: pole = tabuľka s pevným počtom riadkov, List = zoznam, ktorý sa dá predlžovať a skracovať.
- **Pole vs. List (5, 6):** kedy ktorý – 10 minút.
- **Odstraňovanie a vkladanie (7–9):** `Remove` vs. `RemoveAt`, odstraňovanie v cykle (odzadu), `Insert` – 25 minút. Žiaci tu robia najviac chýb.
- **Hľadanie a triedenie (10, 11):** `Contains`, `IndexOf`, `Sort`, `Reverse` – 15 minút.
- **Algoritmy (12, 13):** súčet, priemer, min, max, filtrovanie, duplicity – 15 minút.
- **Zber od používateľa (14):** prečo List a nie pole – 10 minút.
- **Fronta a zásobník (15, 16):** cvičenie z lekcie (Queue) bez tried – 15 minút.
- **Bonusy (17, 18):** menu s menami (bonus z lekcie), lotéria – podľa času.
- **Ladenie (19):** list v debuggeri – 10 minút.

## Odpovede k ukážke 19 (ladenie)
| STOP | Stav listu po riadku | Count | Capacity |
|---|---|---|---|
| 1 (pred vykonaním riadku) | list ešte neexistuje (po F10: `4, 2, 9, 6`) | 4 | 4 |
| 2 (po Add) | `4, 2, 9, 6, 7` | 5 | 8 (zdvojnásobí sa) |
| 3 (po Insert(1, 20)) | `4, 20, 2, 9, 6, 7` (20 je na indexe 1, ostatné sa posunuli) | 6 | 8 |
| 4 (po RemoveAt(0)) | `20, 2, 9, 6, 7` | 5 | 8 |
| 5 (po Sort) | `2, 6, 7, 9, 20` | 5 | 8 |

- Po cykle: `sum = 44`.
- *Capacity* je interná veľkosť poľa, ktoré List skrýva. Keď sa zaplní, zdvojnásobí sa. Pre žiakov stačí poznámka „List je v skutočnosti pole, ktoré sa samo zväčšuje“.

## Poznámky
- Ukážky 15, 16 a 17 sú referenčné riešenia cvičení z lekcie – nezdieľajte ich so žiakmi skôr, než ich sami skúsia. Lekcia zadáva triedu `Queue`, ktorú testujú unit testy. Tu je rovnaká myšlienka bez tried.
- Ukážka 8 zámerne obsahuje zakomentovaný `foreach` s `Remove`. Pri jeho skúšaní ukážte `InvalidOperationException` v debuggeri.
- `ToArray()` (ukážka 5) a `IndexOf` (ukážka 10) nie sú v lekcii, ale dobre dopĺňajú výklad.

Nadväzuje: `OpravaList` (pokazené programy na opravovanie). Predchádzajúce: `CykleUkazky`. Nasleduje: AppsLab-018 Metódy.
