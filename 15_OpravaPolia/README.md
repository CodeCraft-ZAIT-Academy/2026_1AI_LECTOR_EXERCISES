# Opravovanie chýb – Polia (26 úloh, AppsLab-015)

Každá úloha je samostatný projekt (`Polia01` … `Polia26`) s programom, ktorý obsahuje chybu. Na začiatku súboru `Program.cs` je komentár s **očakávaným výstupom** – tvojím cieľom je, aby program vypísal presne toto.

## Ako na to
1. Otvor `OpravaPolia.sln` vo Visual Studiu.
2. V *Solution Explorer* klikni pravým tlačidlom na projekt → **Set as Startup Project** (názov sa zvýrazní tučným písmom).
3. Spusti klávesom **F5** (alebo Ctrl+F5). Visual Studio zostaví **iba** tento projekt.
4. Ak vidíš chybu v *Error List*, prečítaj ju a oprav ju.
5. Ak program **spadne** (`IndexOutOfRangeException`), spusti ho s ladením (F5) – debugger sa zastaví na riadku, kde sa chyba stala. Pozri v okne *Locals* hodnotu indexu a dĺžku poľa.
6. Ak program beží, ale výstup nesedí s komentárom, hľadaj logickú chybu (pomôže debugger: F9, F10, rozbalenie poľa v Locals).
7. Keď výstup sedí, vyber ďalší projekt.

## Pozor
- **Nepoužívaj Build Solution (Ctrl+Shift+B)** – zostavil by všetkých 26 projektov a v Error List by boli chyby zo všetkých úloh. Používaj F5, alebo pravý klik na projekt → *Build*.
- Úlohy 1–11: program sa nespustí (chyba pri kompilácii). Úlohy 12–16: program spadne s výnimkou. Úlohy 17–26: program beží, ale vypisuje zlé hodnoty.
- Cykly ešte nepoznáme – všetky opravy sa týkajú vytvorenia poľa, indexov, `Length`, dvojrozmerných polí a reťazcov ako poľa znakov.
- Pripomienka: prvý prvok poľa má **index 0**, posledný má index **Length - 1**.
