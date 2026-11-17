// ===== LIST 16 – Zásobník (LIFO) =====
// Pojmy: LIFO (last in, first out), posledný prvok = Count - 1
// Skús zmeniť:
//   1. Navštív ďalšiu stránku a vráť sa dvakrát späť.
//   2. Čo sa stane, ak ideme späť, keď je história prázdna? Ošetri to cez if.
//   3. Porovnaj s frontou: čo sa líši pri odoberaní (index 0 vs. Count - 1)?

List<string> history = new List<string>();

history.Add("google.com");
history.Add("skola.sk");
history.Add("youtube.com");
Console.WriteLine("Historia: " + string.Join(" > ", history));

// Späť: odober poslednú stránku
int lastIndex = history.Count - 1;
Console.WriteLine("Zatvaram: " + history[lastIndex]);
history.RemoveAt(lastIndex);

Console.WriteLine("Aktualna stranka: " + history[history.Count - 1]);
Console.WriteLine("Historia: " + string.Join(" > ", history));
