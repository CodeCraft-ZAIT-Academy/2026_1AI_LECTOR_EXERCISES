// ===== LIST 02 – List rôznych typov =====
// Pojmy: generický typ <T>, List<string>, List<double>, List<bool>
// Skús zmeniť:
//   1. Skús do List<string> pridať číslo (names.Add(5)). Čo hlási kompilátor?
//   2. Vytvor List<char> s tromi písmenami.
//   3. Pridaj do listu cien ďalšiu cenu.

List<string> names = new List<string>();
names.Add("Anna");
names.Add("Boris");
names.Add("Cyril");

List<double> prices = new List<double>();
prices.Add(1.5);
prices.Add(2.25);
prices.Add(0.99);

List<bool> answers = new List<bool>();
answers.Add(true);
answers.Add(false);
answers.Add(true);

Console.WriteLine("Mena: " + string.Join(", ", names));
Console.WriteLine("Ceny: " + string.Join(" | ", prices));
Console.WriteLine("Odpovede: " + string.Join(", ", answers));
