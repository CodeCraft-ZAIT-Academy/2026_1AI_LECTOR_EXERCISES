// ===== Ladenie 12 – Hľadanie chyby: logické výrazy =====
// Lekcia: AppsLab-012 Boolean
// Nový nástroj: Watch pre časti výrazu, priorita && a ||
// Cieľ: Nájsť dve logické chyby v zložených výrazoch a overiť ich v okne Watch.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti bez ladenia (Ctrl+F5) a porovnaj s očakávaným výstupom.
//   2. Spusti F5, zastav sa na STOP 1 a do Watch pridaj časti výrazu: age >= 18, hasTicket && !isBanned, age >= 18 || hasTicket && !isBanned.
//   3. Pozri sa, ktorá časť dáva inú hodnotu, než by mala. Zapíš hodnoty.
//   4. Rovnako vyšetri výraz goToBeach (STOP 2). Oprav obe chyby.
//
// Očakávaný výstup (po oprave):
//   Can enter: False
//   Go to beach: False
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: age >= 18 = ____, hasTicket && !isBanned = ____, age >= 18 || hasTicket && !isBanned = ____, canEnter = ____
//   STOP 2: isSunny && isWarm = ____, isSunny && isWarm || hasHomework = ____, goToBeach = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

int age = 20;
bool hasTicket = false;
bool isBanned = false;

bool canEnter = age >= 18 || hasTicket && !isBanned;
Console.WriteLine("Can enter: " + canEnter);           // STOP 1

bool isSunny = true;
bool isWarm = true;
bool hasHomework = true;

bool goToBeach = isSunny && isWarm || hasHomework;
Console.WriteLine("Go to beach: " + goToBeach);        // STOP 2
