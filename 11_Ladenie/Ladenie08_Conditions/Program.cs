// ===== Ladenie 08 – Podmienky: ktorou vetvou program ide =====
// Lekcia: AppsLab-013 Conditions
// Nový nástroj: sledovanie vetvenia, zmena premennej v Locals na zmenu cesty
// Cieľ: Vidieť, ktorá vetva podmienky sa vykoná, a zmeniť hodnotu tak, aby šiel program inou cestou.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Breakpoint na riadok STOP 1 (prvé if), spusti F5. Krokuj F10 a sleduj, kam skáče žltý riadok. Ktorú vetvu program vykoná?
//   2. Na riadku STOP 1 zmeň v Locals hodnotu age na 15 a pokračuj F10. Ktorá vetva sa vykoná teraz? Skús aj 5.
//   3. Na riadku STOP 2 zapíš age a category. Zapíš ich pri pôvodnej aj zmenenej hodnote.
//   4. Pri kalkulačke (STOP 3) krokuj F10 a sleduj, ktoré podmienky sa vyhodnotia ako nepravdivé, kým program nenájde správnu vetvu. Zapíš hodnotu result na STOP 4.
//   5. Na riadku STOP 3 zmeň operation na "/" a number2 na 0. Čo vypíše program?
//   6. Na riadku STOP 5 zmeň health na 30 a potom na 0 a sleduj, ktorá vetva sa vykoná.
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: age = ____
//   STOP 2: age = ____, category = ____
//   STOP 3: operation = ____, number1 = ____, number2 = ____
//   STOP 4: operation = ____, result = ____
//   STOP 5: health = ____
//
// Otázky:
//   Q1: Koľko podmienok sa vyhodnotí pri operation == "-"?
//   Q2: Čo vypíše kalkulačka pri 10 / 0?
//   Q3: Ktorá vetva sa vykoná pri health = 30 a pri health = 0?

int age = 20;
string category;

if (age >= 18)                                         // STOP 1
{
    category = "adult";
}
else if (age >= 13)
{
    category = "teenager";
}
else
{
    category = "kid";
}
Console.WriteLine("Category: " + category);            // STOP 2

string operation = "-";
double number1 = 10;
double number2 = 5;
double result = 0;

if (operation == "+")                                  // STOP 3
{
    result = number1 + number2;
}
else if (operation == "-")
{
    result = number1 - number2;
}
else if (operation == "*")
{
    result = number1 * number2;
}
else if (operation == "/")
{
    if (number2 != 0)
    {
        result = number1 / number2;
    }
    else
    {
        Console.WriteLine("Cannot divide by zero.");
    }
}
else
{
    Console.WriteLine("Invalid operation.");
}
Console.WriteLine("Result: " + result);                // STOP 4

int health = 80;

if (health <= 0)                                       // STOP 5
{
    Console.WriteLine("Game over.");
}
else if (health < 50)
{
    Console.WriteLine("You are weak.");
}
else
{
    Console.WriteLine("You feel strong.");
}
