// ===== 09 – Zvyšok po delení (%) a deliteľnosť =====
// Ukáž:       % vráti zvyšok. Párne číslo má zvyšok 0 po delení dvomi.
//             FizzBuzz: kombinácia && a poradia vetiev (najprv najprísnejšia podmienka!).
// Skús zmeniť: number na 7, 10, 0.

int number = 15;

Console.WriteLine(number + " % 2 = " + (number % 2));

if (number % 2 == 0)
{
    Console.WriteLine(number + " is even.");
}
else
{
    Console.WriteLine(number + " is odd.");
}

Console.WriteLine();
Console.WriteLine("3:  " + FizzBuzz(3));
Console.WriteLine("5:  " + FizzBuzz(5));
Console.WriteLine("7:  " + FizzBuzz(7));
Console.WriteLine("9:  " + FizzBuzz(9));
Console.WriteLine("10: " + FizzBuzz(10));
Console.WriteLine("15: " + FizzBuzz(15));

static string FizzBuzz(int n)
{
    if (n % 3 == 0 && n % 5 == 0)
    {
        return "FizzBuzz";
    }
    else if (n % 3 == 0)
    {
        return "Fizz";
    }
    else if (n % 5 == 0)
    {
        return "Buzz";
    }
    else
    {
        return n.ToString();
    }
}
