// ===== 03 – Inicializácia poľa hneď pri vytvorení =====
// Ukáž:       tri zápisy, ktoré dajú rovnaký výsledok. Veľkosť poľa určí kompilátor z počtu hodnôt.
// Skús zmeniť: pridaj ďalšie hodnoty a pozri, ako sa zmení Length.

int[] a = new int[5] { 10, 20, 30, 40, 50 };   // veľkosť aj hodnoty
int[] b = new int[] { 10, 20, 30, 40, 50 };    // veľkosť sa dopočíta
int[] c = { 10, 20, 30, 40, 50 };              // najstručnejší zápis (z lekcie)

Console.WriteLine("a: " + string.Join(", ", a) + "   Length = " + a.Length);
Console.WriteLine("b: " + string.Join(", ", b) + "   Length = " + b.Length);
Console.WriteLine("c: " + string.Join(", ", c) + "   Length = " + c.Length);

// Bonus: kompilátor vie určiť typ prvkov sám
var d = new[] { 1.5, 2.5, 3.5 };
Console.WriteLine("d: " + string.Join(", ", d));
