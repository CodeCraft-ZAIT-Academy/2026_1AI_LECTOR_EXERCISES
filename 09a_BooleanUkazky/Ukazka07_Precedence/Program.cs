// ===== 07 – Priorita operátorov a zátvorky =====
// Ukáž:       poradie vyhodnotenia: najprv !, potom &&, nakoniec ||.
//             Zátvorky poradie zmenia. Keď si nie si istý, daj zátvorky.
// Skús zmeniť: hodnoty a, b, c. Hádaj výsledky PRED spustením.

bool a = true;
bool b = false;
bool c = false;

Console.WriteLine("a || b && c    = " + (a || b && c));       // && ide skôr: a || (b && c)
Console.WriteLine("(a || b) && c  = " + ((a || b) && c));     // zátvorky zmenili poradie
Console.WriteLine("!a || b        = " + (!a || b));           // ! sa vyhodnotí ako prvé
Console.WriteLine("!(a || b)      = " + (!(a || b)));         // negácia celého výrazu
Console.WriteLine("a && !b        = " + (a && !b));
Console.WriteLine("!a && !b       = " + (!a && !b));
