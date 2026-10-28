// ===== 01 – Vytvorenie poľa a predvolené hodnoty =====
// Ukáž:       pole = viac hodnôt rovnakého typu v jednej premennej. new int[5] vytvorí 5 prvkov.
//             Nové pole obsahuje predvolené hodnoty: 0 pre čísla, false pre bool, null pre text.
//             Celé pole sa vypisuje pomocou string.Join (cykly ešte nepoznáme).
// Skús zmeniť: veľkosť poľa (new int[3], new int[10]) a sleduj výpis.

int[] numbers = new int[5];
Console.WriteLine("int[5]:    " + string.Join(", ", numbers));

double[] prices = new double[3];
Console.WriteLine("double[3]: " + string.Join(", ", prices));

bool[] flags = new bool[4];
Console.WriteLine("bool[4]:   " + string.Join(", ", flags));

string[] names = new string[2];
Console.WriteLine("string[2]: " + string.Join(", ", names) + "   (null sa vypíše ako prázdny text)");
Console.WriteLine("names[0] == null: " + (names[0] == null));

// Pozor: samotné pole sa takto nevypíše, vypíše sa len jeho typ!
Console.WriteLine(numbers);
