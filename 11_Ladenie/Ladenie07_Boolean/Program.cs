// ===== Ladenie 07 – Booleovské výrazy a Watch =====
// Lekcia: AppsLab-012 Boolean
// Nový nástroj: Watch pre výrazy, hover, skrátené vyhodnocovanie
// Cieľ: Vyhodnocovať logické výrazy v okne Watch a vidieť, že pravá strana && sa nemusí vykonať.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti F5 s breakpointom na prvom riadku a krokuj F10 až po STOP 1.
//   2. Zapíš isWarm, isGoodWeather, needUmbrella a goOutside.
//   3. Do okna Watch pridaj tieto výrazy a zapíš výsledky: isSunny && isRaining, !isSunny || isWarm, !(isSunny && isWarm).
//   4. Na riadku STOP 2 (r1) stlač F11. Vstúpil si do metódy Expensive? Potom na riadku s r2 znova stlač F11.
//   5. Nastav breakpoint do metódy Expensive (STOP 3). Koľkokrát sa tam zastavíš?
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: isWarm = ____, isGoodWeather = ____, needUmbrella = ____, goOutside = ____, isSunny && isRaining = ____, !isSunny || isWarm = ____, !(isSunny && isWarm) = ____
//   STOP 2: isRaining = ____, isSunny = ____
//   STOP 3: name = ____
//
// Otázky:
//   Q1: Prečo sa metóda Expensive("B") nezavolá?
//   Q2: Koľkokrát sa zastavíš na STOP 3?
//   Q3: Aké hodnoty majú výrazy vo Watch?

bool isSunny = true;
bool isRaining = false;
int temperature = 22;

bool isWarm = temperature >= 20;
bool isGoodWeather = isSunny && isWarm;
bool needUmbrella = isRaining || !isSunny;
bool goOutside = isGoodWeather && !needUmbrella;
Console.WriteLine("goOutside: " + goOutside);          // STOP 1

bool r1 = isRaining && Expensive("B");                 // STOP 2
bool r2 = isSunny && Expensive("C");
Console.WriteLine("r1: " + r1 + ", r2: " + r2);

static bool Expensive(string name)
{
    Console.WriteLine("  Expensive " + name + " called");   // STOP 3
    return true;
}
