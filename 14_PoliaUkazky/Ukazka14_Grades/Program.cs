// ===== 14 – Motivácia k cyklom: známky =====
// Ukáž:       s poľom sa dá počítať, ale bez cyklu musíme každý prvok napísať ručne.
//             Čo keby bolo známok 100? Presne na to sú cykly (ďalšia lekcia).
// Skús zmeniť: známky v poli; pridaj šiestu známku – čo všetko musíš v kóde zmeniť?

int[] grades = { 1, 2, 2, 4, 5 };

int sum = grades[0] + grades[1] + grades[2] + grades[3] + grades[4];
double average = (double)sum / grades.Length;
Console.WriteLine("Súčet:   " + sum);
Console.WriteLine("Priemer: " + average);

// Najlepšia známka (najmenšie číslo) – ručne
int best = grades[0];
if (grades[1] < best) { best = grades[1]; }
if (grades[2] < best) { best = grades[2]; }
if (grades[3] < best) { best = grades[3]; }
if (grades[4] < best) { best = grades[4]; }
Console.WriteLine("Najlepšia známka: " + best);
