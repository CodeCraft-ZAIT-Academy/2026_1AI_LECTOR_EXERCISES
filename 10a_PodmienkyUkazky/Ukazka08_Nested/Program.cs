// ===== 08 – Vnorené podmienky =====
// Ukáž:       podmienka vnútri podmienky. Porovnaj s jednou zloženou podmienkou cez &&.
// Skús zmeniť: username na "admin"/"guest", password na "1234"/"abcd".
//             Pozri, ktorá verzia vie povedať, ČO presne je zle.

string username = "admin";
string password = "abcd";

// Verzia 1: vnorené podmienky – vieme povedať, čo je zle
if (username == "admin")
{
    if (password == "1234")
    {
        Console.WriteLine("Welcome, admin!");
    }
    else
    {
        Console.WriteLine("Wrong password.");
    }
}
else
{
    Console.WriteLine("Unknown user.");
}

// Verzia 2: jedna zložená podmienka – kratšia, ale nevieme, čo je zle
if (username == "admin" && password == "1234")
{
    Console.WriteLine("Welcome, admin!");
}
else
{
    Console.WriteLine("Login failed.");
}
