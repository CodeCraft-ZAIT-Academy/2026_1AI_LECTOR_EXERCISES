# Opravovanie chýb – Cykly (32 úloh, AppsLab-016)

Každá úloha je samostatný projekt (`Cykly01` … `Cykly32`) s programom, ktorý obsahuje chybu. Na začiatku súboru `Program.cs` je komentár s **očakávaným výstupom** – tvojím cieľom je, aby program vypísal presne toto.

## Ako na to
1. Otvor `OpravaCykly.sln` vo Visual Studiu.
2. V *Solution Explorer* klikni pravým tlačidlom na projekt → **Set as Startup Project** (názov sa zvýrazní tučným písmom).
3. Spusti klávesom **F5** (alebo Ctrl+F5). Visual Studio zostaví **iba** tento projekt.
4. Ak vidíš chybu v *Error List*, prečítaj ju a oprav ju.
5. Ak program **spadne** (`IndexOutOfRangeException`, `DivideByZeroException`), spusti ho s ladením (F5) – debugger sa zastaví na riadku, kde sa chyba stala. Pozri hodnotu `i` a dĺžku poľa v okne *Locals*.
6. Ak sa program **zasekne** (nič sa nevypíše a nekončí), je to nekonečný cyklus. Zastav ho (**Shift+F5** pri ladení, **Ctrl+C** v konzole) a spusti znova s ladením: krokuj F10 a sleduj, či sa premenná v podmienke mení.
7. Ak program beží, ale výstup nesedí s komentárom, hľadaj logickú chybu. Pomôže debugger: breakpoint v cykle, F5/F10, okno *Locals*, prípadne **podmienený breakpoint** (pravý klik na breakpoint → Conditions, napr. `i == 3`).
8. Keď výstup sedí, vyber ďalší projekt.

## Pozor
- **Nepoužívaj Build Solution (Ctrl+Shift+B)** – zostavil by všetkých 32 projektov a v Error List by boli chyby zo všetkých úloh. Používaj F5, alebo pravý klik na projekt → *Build*.
- Úlohy 1–11: program sa nespustí (chyba pri kompilácii). Úlohy 12–15: program spadne s výnimkou. Úlohy 16–18: program sa zasekne (nekonečný cyklus). Úlohy 19–32: program beží, ale vypisuje zlé hodnoty.
- Pripomienka: `for (inicializácia; podmienka; zmena)`. Cyklus končí, keď podmienka prestane platiť. Posledný index poľa je `Length - 1`.
