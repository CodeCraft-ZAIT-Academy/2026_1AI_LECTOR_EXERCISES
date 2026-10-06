// ===== Ladenie 09 – Hľadanie chyby: operátory =====
// Lekcia: AppsLab-009 Operators
// Nový nástroj: Watch, porovnanie očakávanej a skutočnej hodnoty
// Cieľ: Nájsť v troch výpočtoch dve chyby. Tretí výpočet je správny – nepokaz ho!
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti bez ladenia (Ctrl+F5) a porovnaj výstup s očakávaným.
//   2. Spusti s ladením (F5) a zastav sa na STOP 1, STOP 2, STOP 3. Zapíš hodnoty premenných.
//   3. Pre každý výpočet urob na papieri správny výsledok a porovnaj. Kde sa hodnoty rozchádzajú?
//   4. Oprav chyby a skontroluj výstup.
//
// Očakávaný výstup (po oprave):
//   Average: 2.3333333333333335
//   Percent: 75
//   Final price: 60
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: grade1 = ____, grade2 = ____, grade3 = ____, average = ____
//   STOP 2: points = ____, maxPoints = ____, percent = ____
//   STOP 3: price = ____, discount = ____, finalPrice = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

int grade1 = 1;
int grade2 = 2;
int grade3 = 4;
double average = grade1 + grade2 + grade3 / 3;
Console.WriteLine("Average: " + average);              // STOP 1

int points = 45;
int maxPoints = 60;
double percent = points / maxPoints * 100;
Console.WriteLine("Percent: " + percent);              // STOP 2

int price = 80;
int discount = 25;
double finalPrice = price - price * discount / 100;
Console.WriteLine("Final price: " + finalPrice);       // STOP 3
