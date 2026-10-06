// ===== Ladenie 13 – Hľadanie chyby: podmienky =====
// Lekcia: AppsLab-013 Conditions
// Nový nástroj: sledovanie vetvenia, poradie else if, hraničné hodnoty
// Cieľ: Zistiť, ktorou vetvou program ide, a prečo je to zlá vetva.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti bez ladenia (Ctrl+F5) a porovnaj s očakávaným výstupom.
//   2. Nastav breakpoint na prvé volanie Grade a pomocou F11 krokuj. Sleduj, ktorá podmienka sa vyhodnotí ako prvá pravdivá. Zapíš points na STOP 1.
//   3. Rovnako vyšetri Describe(18) a Describe(13). Zapíš age na STOP 2.
//   4. Oprav obe metódy. Otestuj aj hraničné hodnoty (90, 75, 50, 13, 18).
//
// Očakávaný výstup (po oprave):
//   A
//   B
//   F
//   adult
//   teenager
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: points = ____
//   STOP 2: age = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

Console.WriteLine(Grade(95));
Console.WriteLine(Grade(80));
Console.WriteLine(Grade(30));
Console.WriteLine(Describe(18));
Console.WriteLine(Describe(13));

static string Grade(int points)
{
    if (points >= 50)                                  // STOP 1
    {
        return "C";
    }
    else if (points >= 75)
    {
        return "B";
    }
    else if (points >= 90)
    {
        return "A";
    }
    else
    {
        return "F";
    }
}

static string Describe(int age)
{
    if (age > 18)                                      // STOP 2
    {
        return "adult";
    }
    else if (age >= 13)
    {
        return "teenager";
    }
    else
    {
        return "kid";
    }
}
