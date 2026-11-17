// ===== TRIEDY 12 – Objekt ako vlastnosť iného objektu =====
// Pojmy: trieda ako typ vlastnosti, vnorený objekt, vnorený objekt je tiež null, kým ho nevytvoríme
// Skús zmeniť:
//   1. Zmeň mesto Anny.
//   2. Zakomentuj riadok anna.Home = new Address ... Čo sa stane?
//   3. Pridaj do Address vlastnosť ZipCode.

Person anna = new Person { Name = "Anna" };
anna.Home = new Address { City = "Zilina", Street = "Hlavna 5" };
Console.WriteLine(anna.Name + " byva v meste " + anna.Home.City + ", " + anna.Home.Street);

// Person.Work má predvolený objekt, preto ho netreba vytvárať
anna.Work.City = "Bratislava";
Console.WriteLine(anna.Name + " pracuje v meste " + anna.Work.City);

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public Address Home { get; set; }                       // bez new je null
    public Address Work { get; set; } = new Address();      // predvolený objekt
}
