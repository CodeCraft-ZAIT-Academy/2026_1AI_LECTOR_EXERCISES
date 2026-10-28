// ===== 05 – Polia rôznych typov =====
// Ukáž:       pole môže byť z ľubovoľného typu (string, double, char, bool), ale všetky prvky majú ROVNAKÝ typ.
// Skús zmeniť: pridaj ďalšie meno, cenu alebo písmeno.

string[] names = { "Peter", "Paul", "Mary" };    // príklad z lekcie
Console.WriteLine(names[0]);                     // Peter
Console.WriteLine(names[1]);                     // Paul
Console.WriteLine(names[2]);                     // Mary

double[] prices = { 0.30, 0.80, 1.20, 1.50 };
Console.WriteLine("Prvá cena: " + prices[0] + ", posledná cena: " + prices[prices.Length - 1]);

char[] letters = { 'A', 'B', 'C' };
Console.WriteLine("Písmená: " + string.Join("", letters));

bool[] answers = { true, false, true };
Console.WriteLine("Druhá odpoveď: " + answers[1]);

// Nejde zmiešať typy:  int[] mixed = { 1, "dva", 3 };   // chyba pri kompilácii
