// ===== 14 – Galéria pascí =====
// Ukáž:       správny kód je aktívny, chybná verzia je v komentári.
//             Odkomentuj chybný riadok (a správny zakomentuj), spusti a pozri, čo sa stane.

int age = 15;

// --- Pasca 1: = namiesto == -----------------------------------------------
// ZLE:  if (age = 15)          -> chyba pri kompilácii (priradenie nie je porovnanie)
if (age == 15)
{
    Console.WriteLine("1) You are 15.");
}

// --- Pasca 2: bodkočiarka za podmienkou -----------------------------------
// ZLE:  if (age >= 18);        -> podmienka riadi prázdny príkaz, blok { } sa vykoná VŽDY
if (age >= 18)
{
    Console.WriteLine("2) You are an adult.");
}

// --- Pasca 3: chýbajúce zložené zátvorky ----------------------------------
// ZLE:  if (age >= 18)
//           Console.WriteLine("3) You are an adult.");
//           Console.WriteLine("3) You can vote.");    <- toto už NEPATRÍ k if
if (age >= 18)
{
    Console.WriteLine("3) You are an adult.");
    Console.WriteLine("3) You can vote.");
}

// --- Pasca 4: interval ako v matematike -----------------------------------
// ZLE:  if (13 <= age < 18)    -> chyba pri kompilácii
if (13 <= age && age < 18)
{
    Console.WriteLine("4) You are a teenager.");
}

// --- Pasca 5: text v apostrofoch -------------------------------------------
string operation = "+";
// ZLE:  if (operation == '+')  -> chyba (text je v "", apostrofy sú pre jeden znak)
if (operation == "+")
{
    Console.WriteLine("5) Plus.");
}
