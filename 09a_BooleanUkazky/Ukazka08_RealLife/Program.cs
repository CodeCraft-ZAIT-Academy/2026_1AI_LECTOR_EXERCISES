// ===== 08 – Bool v praktických príkladoch =====
// Ukáž:       porovnávanie + logické operátory = zložené výroky o reálnych veciach.
//             Ešte bez if – výsledky len ukladáme a vypisujeme.
// Skús zmeniť: age, hasTicket, hasParentConsent, money, year, number.

int age = 16;
bool hasTicket = true;
bool hasParentConsent = true;
double money = 8.5;

bool isTeenager = age >= 13 && age <= 17;
bool canEnterCinema = hasTicket && (age >= 18 || hasParentConsent);
bool canBuyPopcorn = money >= 5.0;

Console.WriteLine("isTeenager:     " + isTeenager);
Console.WriteLine("canEnterCinema: " + canEnterCinema);
Console.WriteLine("canBuyPopcorn:  " + canBuyPopcorn);
Console.WriteLine("both:           " + (canEnterCinema && canBuyPopcorn));

// Číslo v intervale a párnosť
Console.WriteLine();
int number = 15;
bool isInRange = number >= 10 && number <= 20;
bool isEven = number % 2 == 0;
Console.WriteLine(number + " is in range 10-20: " + isInRange);
Console.WriteLine(number + " is even: " + isEven);

// Prestupný rok
Console.WriteLine();
Console.WriteLine("2024: " + IsLeapYear(2024));
Console.WriteLine("2023: " + IsLeapYear(2023));
Console.WriteLine("1900: " + IsLeapYear(1900));
Console.WriteLine("2000: " + IsLeapYear(2000));

static bool IsLeapYear(int year)
{
    return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}
