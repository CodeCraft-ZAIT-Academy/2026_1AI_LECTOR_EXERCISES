// ===== 11 – Kalkulačka (príklad z lekcie, interaktívna) =====
// Ukáž:       reťaz else if podľa textu a vnorená podmienka pri delení.
// Skús:       5 / 0, 10 / -5, 6 * 7, a neplatnú operáciu (napr. %).

Console.Write("First number: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Operation (+ - * /): ");
string operation = Console.ReadLine();
Console.Write("Second number: ");
double number2 = double.Parse(Console.ReadLine());

if (operation == "+")
{
    Console.WriteLine(number1 + number2);
}
else if (operation == "-")
{
    Console.WriteLine(number1 - number2);
}
else if (operation == "*")
{
    Console.WriteLine(number1 * number2);
}
else if (operation == "/")
{
    // Skontrolujeme, či je deliteľ nulový
    if (number2 != 0)
    {
        Console.WriteLine(number1 / number2);
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
