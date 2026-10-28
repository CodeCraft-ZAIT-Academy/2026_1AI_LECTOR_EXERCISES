// ===== 07 – Cyklus do-while: kontrola vstupu =====
// Ukáž:       do { ... } while (podmienka);  – blok sa vykoná vždy aspoň RAZ, podmienka sa kontroluje až potom.
//             Ideálne na opakované pýtanie vstupu, kým nie je správny.
//             Pozor na bodkočiarku za while (...)!
// Skús:       zadaj vek 0, potom 200, potom 15.

// Príklad z lekcie: náhodné číslo, kým nie je menšie ako 0.5
Random random = new Random();
double randomNumber;
do
{
    randomNumber = random.NextDouble();
}
while (randomNumber >= 0.5);
Console.WriteLine("Náhodné číslo je menšie ako 0.5: " + (randomNumber < 0.5));

// Kontrola vstupu
int age;
do
{
    Console.Write("Zadaj vek (1 - 120): ");
    age = int.Parse(Console.ReadLine());
}
while (age < 1 || age > 120);

Console.WriteLine("Tvoj vek: " + age);
