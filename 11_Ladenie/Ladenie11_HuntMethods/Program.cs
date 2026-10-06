// ===== Ladenie 11 – Hľadanie chyby: metódy =====
// Lekcia: AppsLab-018 Methods
// Nový nástroj: F11 do metódy, kontrola parametrov a návratovej hodnoty
// Cieľ: Pomocou F11 vstúpiť do každej metódy a zistiť, ktorá z nich počíta zle.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti bez ladenia (Ctrl+F5) a porovnaj s očakávaným výstupom. Ktorý riadok je zlý?
//   2. Nastav breakpoint na prvé volanie a pomocou F11 vstúp do každej metódy.
//   3. Pri každej metóde zapíš parametre a hodnotu, ktorú vráti (STOP 1, 2, 3 sú na riadkoch return).
//   4. Nájdi metódy, ktoré počítajú zle, a oprav ich. Jedna metóda je správna!
//
// Očakávaný výstup (po oprave):
//   10 - 3 = 7
//   Area: 20
//   Perimeter: 18
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: a = ____, b = ____
//   STOP 2: width = ____, height = ____
//   STOP 3: width = ____, height = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

Console.WriteLine("10 - 3 = " + Subtract(10, 3));
Console.WriteLine("Area: " + Area(4, 5));
Console.WriteLine("Perimeter: " + Perimeter(4, 5));

static int Subtract(int a, int b)
{
    return b - a;                                      // STOP 1
}

static int Area(int width, int height)
{
    int result = width + height;
    return result;                                     // STOP 2
}

static int Perimeter(int width, int height)
{
    return 2 * (width + height);                       // STOP 3
}
