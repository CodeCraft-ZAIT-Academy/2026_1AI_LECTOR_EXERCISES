// ===== 02 – Porovnávacie operátory vytvárajú bool =====
// Ukáž:       každé porovnanie je otázka a odpoveď je True alebo False.
//             Výsledok môžeme uložiť do premennej typu bool.
// Skús zmeniť: hodnoty a, b. Hádaj výsledok PRED spustením.

int a = 5;
int b = 3;

bool isALarger = a > b;   // príklad z lekcie
Console.WriteLine("a > b  -> " + isALarger);

Console.WriteLine("a < b  -> " + (a < b));
Console.WriteLine("a >= 5 -> " + (a >= 5));
Console.WriteLine("a <= 4 -> " + (a <= 4));
Console.WriteLine("a == b -> " + (a == b));
Console.WriteLine("a != b -> " + (a != b));

// Porovnávať môžeme aj iné typy
double price = 9.99;
Console.WriteLine("price < 10 -> " + (price < 10));

string name = "Anna";
Console.WriteLine("name == \"Anna\" -> " + (name == "Anna"));
Console.WriteLine("name == \"anna\" -> " + (name == "anna"));   // veľkosť písmen záleží!

char letter = 'x';
Console.WriteLine("letter == 'x' -> " + (letter == 'x'));

// Pozor: = je priradenie, == je porovnanie
