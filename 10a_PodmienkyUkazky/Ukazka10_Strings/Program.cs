// ===== 10 – Porovnávanie textov =====
// Ukáž:       texty porovnávame cez == a != . Rozlišujú sa veľké a malé písmená!
// Skús zmeniť: input na "Secret123", "SECRET123", "secret123 " (s medzerou na konci).

string password = "Secret123";
string input = "secret123";

if (input == password)
{
    Console.WriteLine("Access granted.");
}
else
{
    Console.WriteLine("Access denied.");
}

// Ignorovanie veľkosti písmen: obe strany prevedieme na malé písmená
if (input.ToLower() == password.ToLower())
{
    Console.WriteLine("Access granted (ignoring case).");
}
else
{
    Console.WriteLine("Access denied (ignoring case).");
}

// Prázdny text
string name = "";

if (name == "")
{
    Console.WriteLine("Name is empty.");
}

if (name != "")
{
    Console.WriteLine("Name is: " + name);
}
