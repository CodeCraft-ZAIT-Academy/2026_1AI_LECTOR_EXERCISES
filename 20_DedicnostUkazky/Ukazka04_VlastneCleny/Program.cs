// ===== DEDIČNOSŤ 04 – Odvodená trieda používa zdedené členy =====
// Pojmy: zdedené vlastnosti v metódach odvodenej triedy, vlastné vlastnosti navyše
// Skús zmeniť:
//   1. Pridaj do Person vlastnosť Age a vypíš ju v Introduce().
//   2. Pridaj triedu Janitor : Person s metódou Clean().
//   3. Zavolaj Introduce() na učiteľovi aj na študentovi. Funguje na oboch?

Student anna = new Student { Name = "Anna", School = "Gymnazium" };
Teacher peter = new Teacher { Name = "Peter", Subject = "Informatika" };

anna.Introduce();
anna.Study();

peter.Introduce();
peter.Teach();

public class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine("Ahoj, som " + Name);
    }
}

public class Student : Person
{
    public string School { get; set; }

    public void Study()
    {
        // Name je zdedené z Person, použijeme ho rovnako ako vlastnú vlastnosť
        Console.WriteLine(Name + " sa uci na skole: " + School);
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public void Teach()
    {
        Console.WriteLine(Name + " uci predmet: " + Subject);
    }
}
