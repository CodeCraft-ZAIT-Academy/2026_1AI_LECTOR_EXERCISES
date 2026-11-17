// ===== LIST 17 – Zoznam mien s menu (bonus z lekcie AppsLab-017) =====
// Pojmy: while + switch + List<string>, Add, Remove, Contains, foreach
// Skús zmeniť:
//   1. Pridaj možnosť 5 – Zoradiť mená.
//   2. Pri pridávaní nepovoľ duplicitu (použi Contains).
//   3. Pri výpise očísluj mená (1. Anna, 2. Boris...).

List<string> names = new List<string>();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("1 - Pridat meno");
    Console.WriteLine("2 - Odstranit meno");
    Console.WriteLine("3 - Skontrolovat pritomnost mena");
    Console.WriteLine("4 - Vypisat vsetky mena");
    Console.WriteLine("0 - Ukoncit program");
    Console.Write("Vyber: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
        {
            Console.Write("Meno: ");
            string name = Console.ReadLine();
            names.Add(name);
            Console.WriteLine("Pridane");
            break;
        }
        case "2":
        {
            Console.Write("Meno: ");
            string name = Console.ReadLine();
            if (names.Remove(name))
            {
                Console.WriteLine("Odstranene");
            }
            else
            {
                Console.WriteLine("Take meno v zozname nie je");
            }
            break;
        }
        case "3":
        {
            Console.Write("Meno: ");
            string name = Console.ReadLine();
            if (names.Contains(name))
            {
                Console.WriteLine(name + " je v zozname");
            }
            else
            {
                Console.WriteLine(name + " v zozname nie je");
            }
            break;
        }
        case "4":
        {
            if (names.Count == 0)
            {
                Console.WriteLine("Zoznam je prazdny");
            }
            else
            {
                foreach (string name in names)
                {
                    Console.WriteLine("- " + name);
                }
            }
            break;
        }
        case "0":
            running = false;
            break;
        default:
            Console.WriteLine("Neplatna volba");
            break;
    }
}

Console.WriteLine("Koniec");
