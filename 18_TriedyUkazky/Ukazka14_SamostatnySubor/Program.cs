// ===== TRIEDY 14 – Trieda v samostatnom súbore =====
// Pojmy: súbor Book.cs, jeden súbor = jedna trieda, Program.cs ostáva krátky
// Skús zmeniť:
//   1. Otvor Book.cs (Solution Explorer) a pridaj vlastnosť Year.
//   2. Pridaj do projektu novú triedu: pravý klik na projekt → Add → Class → Author.cs.
//   3. Skús triedu Book presunúť späť pod príkazy v Program.cs. Funguje to rovnako?

Book b1 = new Book { Title = "Hobit", Author = "Tolkien", Pages = 310 };
Book b2 = new Book { Title = "Maly princ", Author = "Saint-Exupery", Pages = 96 };

Console.WriteLine(b1.Describe());
Console.WriteLine(b2.Describe());
Console.WriteLine("Dlhsia je: " + (b1.Pages > b2.Pages ? b1.Title : b2.Title));
