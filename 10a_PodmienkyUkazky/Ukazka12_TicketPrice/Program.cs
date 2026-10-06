// ===== 12 – Cena vstupenky (&& a ||, interaktívna) =====
// Ukáž:       zložená podmienka. Pozor na zátvorky – určujú poradie vyhodnotenia.
// Skús:       vek 4, 12, 20 (študent áno/nie), 70.
// Pravidlá:   do 6 rokov zadarmo; do 18 rokov alebo študent do 26 rokov = 4 EUR;
//             65 a viac = 3 EUR; inak 7 EUR.

Console.Write("Age: ");
int age = int.Parse(Console.ReadLine());
Console.Write("Are you a student? (yes/no): ");
string answer = Console.ReadLine();

bool isStudent = answer == "yes";
double price;

if (age < 6)
{
    price = 0;
}
else if (age < 18 || (isStudent && age < 26))
{
    price = 4;
}
else if (age >= 65)
{
    price = 3;
}
else
{
    price = 7;
}

Console.WriteLine("Ticket price: " + price + " EUR");
