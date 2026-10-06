# Opravovanie chýb – Boolean (24 úloh, AppsLab-012)

Každá úloha je samostatný projekt (`Boolean01` … `Boolean24`) s programom, ktorý obsahuje chybu. Na začiatku súboru `Program.cs` je komentár s **očakávaným výstupom** – tvojím cieľom je, aby program vypísal presne toto.

## Ako na to
1. Otvor `OpravaBoolean.sln` vo Visual Studiu.
2. V *Solution Explorer* klikni pravým tlačidlom na projekt → **Set as Startup Project** (názov sa zvýrazní tučným písmom).
3. Spusti klávesom **F5** (alebo Ctrl+F5). Visual Studio zostaví **iba** tento projekt.
4. Ak vidíš chybu v *Error List*, prečítaj ju a oprav ju. Ak program beží, ale výstup nesedí s komentárom, hľadaj logickú chybu (pomôže debugger: F9, F10, okno Locals).
5. Keď výstup sedí, vyber ďalší projekt.

## Pozor
- **Nepoužívaj Build Solution (Ctrl+Shift+B)** – zostavil by všetkých 24 projektov a v Error List by boli chyby zo všetkých úloh. Používaj F5, alebo pravý klik na projekt → *Build*.
- Úlohy 1–12: program sa nespustí (chyba pri kompilácii). Úlohy 13–24: program beží, ale vypisuje zlé hodnoty.
- Podmienky (`if`) ešte nepoznáme – všetky opravy sa týkajú typu `bool`, porovnávania a logických operátorov `&&`, `||`, `!`.
