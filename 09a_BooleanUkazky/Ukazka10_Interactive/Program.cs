// ===== 10 – Interaktívna ukážka: odpovede áno/nie =====
// Ukáž:       z odpovedí používateľa vytvoríme bool: odpoveď == "yes" je True alebo False.
//             Z troch bool hodnôt sa skladá výsledok. Ešte bez if.
// Skús:       rôzne kombinácie: yes/yes/no, yes/no/no, yes/yes/yes ...

Console.Write("Is it sunny? (yes/no): ");
bool isSunny = Console.ReadLine() == "yes";

Console.Write("Is it warm? (yes/no): ");
bool isWarm = Console.ReadLine() == "yes";

Console.Write("Do you have homework? (yes/no): ");
bool hasHomework = Console.ReadLine() == "yes";

bool goToBeach = isSunny && isWarm && !hasHomework;

Console.WriteLine();
Console.WriteLine("Go to the beach:     " + goToBeach);
Console.WriteLine("At least one nice:   " + (isSunny || isWarm));
Console.WriteLine("Stay at home:        " + !goToBeach);
