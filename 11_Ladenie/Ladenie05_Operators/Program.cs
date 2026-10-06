// ===== Ladenie 05 – Operátory: predpovedz a over =====
// Lekcia: AppsLab-009 Operators
// Nový nástroj: Watch, Immediate window, porovnanie predpovede s hodnotou
// Cieľ: Najprv si tipni výsledok operácie, potom ho over v debuggeri. Vyskúšaj Immediate window.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Skôr než spustíš ladenie, zapíš na papier svoje tipy: sum, difference, product, intDivision, division, remainder, mixed, withParentheses.
//   2. Spusti F5 a zastav sa na riadku STOP 2 (koniec výpočtov). Porovnaj hodnoty v Locals so svojimi tipmi.
//   3. Otvor okno Debug -> Windows -> Immediate. Zadaj (a po každom stlač Enter): a / b, (double)a / b, a % b, 10 % 4, a > b && b > 0. Zapíš výsledky.
//   4. Zastav sa aj na riadku STOP 1 (skôr v programe) a zapíš hodnoty sum, difference, product. Ostatné premenné ešte neexistujú.
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: sum = ____, difference = ____, product = ____
//   STOP 2: sum = ____, difference = ____, product = ____, intDivision = ____, division = ____, remainder = ____, mixed = ____, withParentheses = ____, equality = ____, greater = ____
//
// Otázky:
//   Q1: Prečo je intDivision = 1 a division = 1.6666...?
//   Q2: Prečo je mixed 14 a withParentheses 20?
//   Q3: Čo vypíšu výrazy v Immediate?

int a = 5;
int b = 3;

int sum = a + b;
int difference = a - b;
int product = a * b;
int intDivision = a / b;                               // STOP 1
double division = (double)a / b;
int remainder = a % b;

int mixed = 2 + 3 * 4;
int withParentheses = (2 + 3) * 4;

bool equality = a == b;
bool greater = a > b;
Console.WriteLine("End of calculations");              // STOP 2
