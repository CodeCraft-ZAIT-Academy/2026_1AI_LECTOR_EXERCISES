// ===== Ladenie 10 – Hľadanie chyby: premenné =====
// Lekcia: AppsLab-004 Variables
// Nový nástroj: sledovanie, kedy sa hodnota premennej prepíše
// Cieľ: Nájsť, kde sa stratila pôvodná hodnota (výmena) a kde sa použila zlá premenná.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti bez ladenia (Ctrl+F5) a porovnaj s očakávaným výstupom.
//   2. Spusti s ladením (F5) a krokuj od prvého riadku. Pri každom kroku sleduj apples a pears v Locals.
//   3. Zapíš hodnoty na STOP 1 (pred výmenou) a na STOP 2 (po výmene).
//   4. Nájdi riadok, po ktorom sa pôvodná hodnota apples stratí. Potom skontroluj fullName na STOP 3.
//   5. Oprav obe chyby.
//
// Očakávaný výstup (po oprave):
//   apples: 8, pears: 5
//   Full name: Jan Novak
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: apples = ____, pears = ____
//   STOP 2: apples = ____, pears = ____
//   STOP 3: firstName = ____, lastName = ____, fullName = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

int apples = 5;
int pears = 8;
apples = pears;                                        // STOP 1
pears = apples;
Console.WriteLine("apples: " + apples + ", pears: " + pears);   // STOP 2

string firstName = "Jan";
string lastName = "Novak";
string fullName = firstName + " " + firstName;
Console.WriteLine("Full name: " + fullName);           // STOP 3
