# Ladenie (debuggovanie) – cvičenia

V týchto projektoch sa naučíš **ladiť programy**: zastaviť ich, krokovať riadok po riadku a pozerať sa, aké hodnoty majú premenné. Každý projekt je samostatný program (`Ladenie01` … `Ladenie16`) a v prvých riadkoch `Program.cs` nájdeš zadanie.

## Ako na to
1. Otvor `Ladenie.sln` vo Visual Studiu.
2. V *Solution Explorer* klikni pravým tlačidlom na projekt → **Set as Startup Project**.
3. Prečítaj si komentár na začiatku `Program.cs` (úlohy a miesta, kde sa treba zastaviť).
4. Spusti program **s ladením: F5** (nie Ctrl+F5 – pri ňom sa breakpointy ignorujú).
5. Hodnoty zapisuj na riadku označenom `// STOP n`. Riadok je pritom **žltý**, čo znamená, že sa ešte nevykonal.

## Najdôležitejšie klávesy
| Kláves | Čo robí |
|---|---|
| **F9** | pridá / odstráni breakpoint na riadku |
| **F5** | spustí s ladením / pokračuje po zastavení |
| **F10** | Step Over – vykoná riadok celý |
| **F11** | Step Into – vstúpi do volanej metódy |
| **Shift+F11** | Step Out – dokončí metódu a vráti sa o úroveň vyššie |
| **Shift+F5** | ukončí ladenie |
| **Ctrl+F5** | spustí bez ladenia |

## Okná, ktoré budeš potrebovať
Všetky sú v menu **Debug → Windows** (a zobrazia sa len počas ladenia):
- **Locals** – premenné aktuálnej metódy a ich hodnoty (červená = práve sa zmenila),
- **Autos** – to, čo sa používa na aktuálnom a predošlom riadku (nájdeš tam aj *Return value* po Step Out),
- **Watch 1** – vlastné výrazy, ktoré chceš sledovať (napr. `a + b`, `age >= 18`),
- **Call Stack** – ktorá metóda koho zavolala,
- **Immediate** – napíš výraz (napr. `a / b`) a stlač Enter.

**Tip:** hodnotu premennej uvidíš aj tak, že myšou nabehneš na jej meno v kóde. Hodnotu v Locals môžeš dvojklikom aj prepísať.

## Časté problémy
- Breakpoint sa nezastaví → spustil si Ctrl+F5, alebo je zvolená konfigurácia *Release* (má byť **Debug**).
- Konzola sa na konci programu hneď zavrie → daj breakpoint na posledný riadok, aby si videl výstup.
- Okná Locals/Watch sa nezobrazujú → otvor ich cez Debug → Windows počas ladenia.
- Pri F5 sa spustil iný projekt → skontroluj **Set as Startup Project**.
- Desatinné čísla sa vypíšu s čiarkou alebo bodkou podľa nastavení Windows.

## Obsah

### Časť A – Základy debuggera podľa lekcií

| # | Projekt | Lekcia | Čo sa naučíš |
|---|---|---|---|
| 1 | `Ladenie01_FirstBreakpoint` | AppsLab-001 StartHere, AppsLab-002 Console.WriteLine | breakpoint (F9), F5, žltý riadok, F10, F11, Shift+F11 |
| 2 | `Ladenie02_Comments` | AppsLab-003 Comments | žltý riadok preskakuje komentáre, počet krokov |
| 3 | `Ladenie03_Variables` | AppsLab-004 Variables | okno Locals, Autos, Watch, zmena hodnoty počas ladenia |
| 4 | `Ladenie04_DataTypes` | AppsLab-005 DataTypes | stĺpec Type v Locals, pretečenie int, presnosť double/float/decimal |
| 5 | `Ladenie05_Operators` | AppsLab-009 Operators | Watch, Immediate window, porovnanie predpovede s hodnotou |
| 6 | `Ladenie06_Methods` | AppsLab-018 Methods | Step Into/Over/Out, Call Stack, parametre a návratové hodnoty |
| 7 | `Ladenie07_Boolean` | AppsLab-012 Boolean | Watch pre výrazy, hover, skrátené vyhodnocovanie |
| 8 | `Ladenie08_Conditions` | AppsLab-013 Conditions | sledovanie vetvenia, zmena premennej v Locals na zmenu cesty |

### Časť B – Hľadanie chýb pomocou debuggera

| # | Projekt | Lekcia | Čo sa naučíš |
|---|---|---|---|
| 9 | `Ladenie09_HuntOperators` | AppsLab-009 Operators | Watch, porovnanie očakávanej a skutočnej hodnoty |
| 10 | `Ladenie10_HuntVariables` | AppsLab-004 Variables | sledovanie, kedy sa hodnota premennej prepíše |
| 11 | `Ladenie11_HuntMethods` | AppsLab-018 Methods | F11 do metódy, kontrola parametrov a návratovej hodnoty |
| 12 | `Ladenie12_HuntBoolean` | AppsLab-012 Boolean | Watch pre časti výrazu, priorita && a || |
| 13 | `Ladenie13_HuntConditions` | AppsLab-013 Conditions | sledovanie vetvenia, poradie else if, hraničné hodnoty |
| 14 | `Ladenie14_HuntReceipt` | AppsLab-009, 012, 013, 018 (všetko dokopy) | kombinácia: F11, Call Stack, Watch, podmienky, operátory |

### Časť C – Výnimky v debuggeri

| # | Projekt | Lekcia | Čo sa naučíš |
|---|---|---|---|
| 15 | `Ladenie15_ExceptionDivideByZero` | AppsLab-009 Operators, AppsLab-018 Methods | Exception Helper, Locals pri výnimke, Call Stack |
| 16 | `Ladenie16_ExceptionFormat` | AppsLab-004 Variables, AppsLab-005 DataTypes | čítanie správy výnimky, kontrola textu pred prevodom |

