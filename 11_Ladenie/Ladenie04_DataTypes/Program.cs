// ===== Ladenie 04 – Dátové typy v debuggeri =====
// Lekcia: AppsLab-005 DataTypes
// Nový nástroj: stĺpec Type v Locals, pretečenie int, presnosť double/float/decimal
// Cieľ: Zistiť typy premenných (aj pri var) a vidieť, ako sa správa pretečenie a presnosť čísel.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti ladenie (F5), zastav sa na riadku STOP 1 a otvor okno Locals. Pozri sa na stĺpec Type.
//   2. Zapíš typy premenných a, b, c, d, e, f (všetky vznikli cez var). Čo by sa stalo, keby si skúsil neskôr do a priradiť text?
//   3. Zapíš si hodnotu maxInt na riadku STOP 2. Pozor: pred ním sa vykonal riadok maxInt = maxInt + 1;
//   4. Na riadku STOP 3 zapíš hodnoty sumD, sumF a sumM. Prečo sa líšia?
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: a.GetType().Name = ____, b.GetType().Name = ____, c.GetType().Name = ____, d.GetType().Name = ____, e.GetType().Name = ____, f.GetType().Name = ____, count = ____, bigNumber = ____, smallNumber = ____, pi = ____, price = ____, money = ____, letter = ____, text = ____, isOk = ____
//   STOP 2: maxInt = ____
//   STOP 3: sumD = ____, sumF = ____, sumM = ____
//
// Otázky:
//   Q1: Aké typy majú a, b, c, d, e, f?
//   Q2: Prečo má maxInt záporné číslo?
//   Q3: Ktorý typ je najpresnejší pri peniazoch?

int count = 42;
long bigNumber = 3000000000;
byte smallNumber = 200;
double pi = 3.14159;
float price = 9.99f;
decimal money = 19.99m;
char letter = 'A';
string text = "C# rocks";
bool isOk = true;

var a = 10;
var b = 10.5;
var c = "ten";
var d = 'x';
var e = 5.5f;
var f = 7.5m;
Console.WriteLine("Types are in the Locals window");   // STOP 1

int maxInt = int.MaxValue;
maxInt = maxInt + 1;
double sumD = 0.1 + 0.2;                               // STOP 2
decimal sumM = 0.1m + 0.2m;
float sumF = 0.1f + 0.2f;
Console.WriteLine("Compare precision");                // STOP 3
