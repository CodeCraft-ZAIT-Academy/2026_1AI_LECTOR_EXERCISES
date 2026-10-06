// Úloha 19: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   2
//   -2
//   Cannot divide by zero.

Divide(10, 5);
Divide(10, -5);
Divide(10, 0);

static void Divide(double number1, double number2)
{
    if (number2 > 0)
    {
        Console.WriteLine(number1 / number2);
    }
    else
    {
        Console.WriteLine("Cannot divide by zero.");
    }
}
