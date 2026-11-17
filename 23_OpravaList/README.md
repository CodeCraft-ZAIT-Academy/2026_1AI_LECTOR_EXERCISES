# Opravovanie chýb – List<T> (34 úloh, AppsLab-017)

Každá úloha je samostatný projekt (`List01` … `List34`) s programom, ktorý obsahuje chybu. Na začiatku súboru `Program.cs` je komentár s **očakávaným výstupom** – tvojím cieľom je, aby program vypísal presne toto.

## Ako na to
1. Otvor `OpravaList.sln` vo Visual Studiu.
2. V *Solution Explorer* klikni pravým tlačidlom na projekt → **Set as Startup Project** (názov sa zvýrazní tučným písmom).
3. Spusti klávesom **F5** (alebo Ctrl+F5). Visual Studio zostaví **iba** tento projekt.
4. Ak vidíš chybu v *Error List*, prečítaj ju a oprav ju.
5. Ak program **spadne** (`ArgumentOutOfRangeException`, `InvalidOperationException`, `DivideByZeroException`), spusti ho s ladením (F5) – debugger sa zastaví na riadku, kde sa chyba stala. V okne *Locals* rozbaľ zoznam a pozri jeho `Count` a prvky `[0]`, `[1]`…
6. Ak program beží, ale výstup nesedí s komentárom, hľadaj logickú chybu. Pomôže debugger: breakpoint, F10 (krok), F11 (vstup do metódy objektu), okno *Locals* a *Watch*.
7. Keď výstup sedí, vyber ďalší projekt.

## Pozor
- **Nepoužívaj Build Solution (Ctrl+Shift+B)** – zostavil by všetkých 34 projektov a v Error List by boli chyby zo všetkých úloh. Používaj F5, alebo pravý klik na projekt → *Build*.
- Úlohy 1–14: program sa nespustí (chyba pri kompilácii). Úlohy 15–22: program spadne s výnimkou. Úlohy 23–34: program beží, ale vypisuje zlé hodnoty.
- Pripomienka: `List<int> numbers = new List<int>();`, prvky pridáva `Add`, počet je `Count` (nie `Length`), posledný index je `Count - 1`. `Remove(hodnota)` odstráni hodnotu, `RemoveAt(index)` pozíciu. `Sort()` a `Reverse()` menia pôvodný zoznam. Počas `foreach` sa zoznam meniť nesmie.
