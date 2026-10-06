// ===== Ladenie 03 – Sledovanie premenných (Locals, Watch) =====
// Lekcia: AppsLab-004 Variables
// Nový nástroj: okno Locals, Autos, Watch, zmena hodnoty počas ladenia
// Cieľ: Sledovať, ako sa premenné deklarujú, inicializujú a menia. Zmeniť hodnotu priamo v debuggeri.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Otvor okná počas ladenia: Debug -> Windows -> Locals (aj Autos a Watch 1). Nastav breakpoint na prvý riadok a spusti F5.
//   2. Krokuj F10. Po každom kroku sleduj, ktoré hodnoty sa v Locals zmenili (zmenené sa zvýraznia červenou).
//   3. Na riadku STOP 1 zapíš hodnoty age a name.
//   4. Na riadku STOP 2 zapíš hodnoty age, name a greetings. Do okna Watch pridaj výraz age * 2 a zapíš jeho hodnotu.
//   5. Na riadku STOP 2 zmeň v okne Locals hodnotu age na 100 (dvojklik na hodnotu) a pokračuj klávesom F10. Čo vypíše konzola?
//   6. Na riadku STOP 3 zapíš greetings.
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: age = ____, name = ____
//   STOP 2: age = ____, name = ____, greetings = ____, age * 2 = ____
//   STOP 3: greetings = ____
//
// Otázky:
//   Q1: Kedy sa hodnota greetings zmení?
//   Q2: Čo vypíše riadok s Age po zmene v Locals?

int age = 14;
string name = "Peter";

age = 15;
name = "Jakub";                                        // STOP 1

string greetings = "Ahoj svet!";
Console.WriteLine(greetings);                          // STOP 2
Console.WriteLine("Age: " + age);

greetings = "Dovidenia svet!";
Console.WriteLine(greetings);                          // STOP 3
