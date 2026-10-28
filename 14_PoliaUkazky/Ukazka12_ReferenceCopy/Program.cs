// ===== 12 – BONUS: pole je odkaz, nie hodnota (kópia poľa) =====
// Mimo lekcie – pre rýchlejších žiakov, ale veľmi dôležité.
// Ukáž:       int[] b = a; NEVYTVORÍ kópiu. Obe premenné ukazujú na to isté pole.
//             Skutočná kópia: Clone() alebo Array.Copy().
// Skús:       Spusti s ladením (F5) a sleduj v Locals, že alias aj original menia spolu.

int[] original = { 1, 2, 3 };

int[] alias = original;          // NIE kópia
alias[0] = 99;
Console.WriteLine("original: " + string.Join(", ", original));    // 99, 2, 3 !
Console.WriteLine("alias:    " + string.Join(", ", alias));

int[] source = { 1, 2, 3 };
int[] copy = (int[])source.Clone();     // skutočná kópia
copy[0] = 99;
Console.WriteLine("source: " + string.Join(", ", source));        // 1, 2, 3
Console.WriteLine("copy:   " + string.Join(", ", copy));          // 99, 2, 3

int[] copy2 = new int[3];
Array.Copy(source, copy2, 3);           // druhá možnosť
copy2[1] = 77;
Console.WriteLine("copy2:  " + string.Join(", ", copy2));

// Pole poslané do metódy sa tiež NEKOPÍRUJE – metóda môže pôvodné pole zmeniť
int[] prices = { 10, 20, 30 };
DoubleAll(prices);
Console.WriteLine("prices po DoubleAll: " + string.Join(", ", prices));   // 20, 40, 60

static void DoubleAll(int[] array)
{
    array[0] = array[0] * 2;
    array[1] = array[1] * 2;
    array[2] = array[2] * 2;
}
