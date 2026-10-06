// ===== Ladenie 06 – Metódy: F10, F11, Shift+F11 a Call Stack =====
// Lekcia: AppsLab-018 Methods
// Nový nástroj: Step Into/Over/Out, Call Stack, parametre a návratové hodnoty
// Cieľ: Vstúpiť do metódy, vidieť jej parametre a návratovú hodnotu, pozrieť Call Stack pri vnorených volaniach.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Breakpoint na prvý riadok, F5. Na riadku STOP 1 stlač F11 – vstúp do metódy Add. Zapíš hodnoty parametrov a, b na riadku STOP 3.
//   2. Stlač Shift+F11 (Step Out). Pozri v okne Autos, aká hodnota sa vrátila (Return value).
//   3. Pokračuj F10. Pri volaní Greet stlač F11 a zapíš hodnotu name na riadku STOP 4.
//   4. Na riadku s volaním Multiply(Add(2, 3), 4) použi F11: najprv sa vykoná Add. Zastavil si sa na STOP 3 druhýkrát? S akými hodnotami?
//   5. Pokračuj do metódy Multiply a zapíš x, y na STOP 5.
//   6. Na riadku STOP 7 (volanie Average) stlač F11. V metóde Sum (STOP 6) otvor okno Call Stack (Debug -> Windows -> Call Stack). Zapíš poradie metód.
//   7. Zapíš hodnoty sum a result na riadku STOP 2.
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 2: sum = ____, result = ____
//   STOP 3: a = ____, b = ____
//   STOP 4: name = ____
//   STOP 5: x = ____, y = ____
//   STOP 6: a = ____, b = ____, c = ____
//   STOP 7: sum = ____
//
// Otázky:
//   Q1: Koľkokrát sa zastavíš na STOP 3 (v metóde Add)?
//   Q2: Aký je Call Stack v metóde Sum?
//   Q3: Čo sa stane, ak na riadku s volaním Multiply použiješ F10 a vnútri metódy nie je breakpoint?

int sum = Add(3, 4);                                   // STOP 1
Console.WriteLine("Sum: " + sum);
Greet("Peter");
int result = Multiply(Add(2, 3), 4);
Console.WriteLine("Result: " + result);                // STOP 2
double average = Average(2, 4, 9);                     // STOP 7
Console.WriteLine("Average: " + average);

static int Add(int a, int b)
{
    int total = a + b;                                 // STOP 3
    return total;
}

static void Greet(string name)
{
    Console.WriteLine($"Ahoj, {name}!");               // STOP 4
}

static int Multiply(int x, int y)
{
    int product = x * y;                               // STOP 5
    return product;
}

static double Average(int a, int b, int c)
{
    int total = Sum(a, b, c);
    return (double)total / 3;
}

static int Sum(int a, int b, int c)
{
    return a + b + c;                                  // STOP 6
}
