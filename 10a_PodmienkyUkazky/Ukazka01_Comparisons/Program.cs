// ===== 01 – Porovnávanie a typ bool =====
// Ukáž:       porovnanie je otázka, odpoveď je True alebo False (typ bool).
// Skús zmeniť: hodnoty a a b, hraničný prípad a >= 5.

int a = 5;
int b = 3;

Console.WriteLine("a > b:  " + (a > b));
Console.WriteLine("a < b:  " + (a < b));
Console.WriteLine("a >= 5: " + (a >= 5));
Console.WriteLine("a <= 4: " + (a <= 4));
Console.WriteLine("a == b: " + (a == b));
Console.WriteLine("a != b: " + (a != b));

// Výsledok porovnania môžeme uložiť do premennej typu bool
bool isAdult = 20 >= 18;
Console.WriteLine("isAdult: " + isAdult);
