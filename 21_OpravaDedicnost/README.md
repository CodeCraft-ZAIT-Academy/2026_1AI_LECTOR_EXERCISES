# Opravovanie chýb – Dedičnosť (23 úloh, AppsLab-020)

Každá úloha je samostatný projekt (`Dedicnost01` … `Dedicnost23`) s programom, ktorý obsahuje chybu. Na začiatku súboru `Program.cs` je komentár s **očakávaným výstupom** – tvojím cieľom je, aby program vypísal presne toto.

## Ako na to
1. Otvor `OpravaDedicnost.sln` vo Visual Studiu.
2. V *Solution Explorer* klikni pravým tlačidlom na projekt → **Set as Startup Project** (názov sa zvýrazní tučným písmom).
3. Spusti klávesom **F5** (alebo Ctrl+F5). Visual Studio zostaví **iba** tento projekt.
4. Ak vidíš chybu v *Error List*, prečítaj ju a oprav ju.
5. Ak program **spadne** (`NullReferenceException`, `InvalidCastException`), spusti ho s ladením (F5) – debugger sa zastaví na riadku, kde sa chyba stala. V okne *Locals* rozbaľ objekty a pozri, ktorý je `null`.
6. Ak program beží, ale výstup nesedí s komentárom, hľadaj logickú chybu. Pomôže debugger: breakpoint, F10 (krok), F11 (vstup do metódy objektu), okno *Locals* a *Watch*.
7. Keď výstup sedí, vyber ďalší projekt.

## Pozor
- **Nepoužívaj Build Solution (Ctrl+Shift+B)** – zostavil by všetkých 23 projektov a v Error List by boli chyby zo všetkých úloh. Používaj F5, alebo pravý klik na projekt → *Build*.
- Úlohy 1–14: program sa nespustí (chyba pri kompilácii). Úlohy 15–17: program spadne s výnimkou. Úlohy 18–23: program beží, ale vypisuje zlé hodnoty.
- Pripomienka: `class Dog : Animal` znamená „Dog JE Animal“. Odvodená trieda dostane všetky vlastnosti a metódy základnej, ale **konštruktory sa nededia** (volá sa `: base(...)`). Dedí sa len z jednej triedy. Premenná základného typu vidí len členy základnej triedy.
