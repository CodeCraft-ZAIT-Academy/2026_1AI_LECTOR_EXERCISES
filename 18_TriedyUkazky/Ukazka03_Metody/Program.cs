// ===== TRIEDY 03 – Metódy v triede =====
// Pojmy: metóda v triede, volanie cez bodku, metóda vidí vlastnosti svojho objektu
// Skús zmeniť:
//   1. Pridaj metódu Eat(), ktorá vypíše "<meno> papa".
//   2. Zavolaj Birthday() na jednom psovi. Zmenil sa vek aj druhému?
//   3. Zmeň Describe() tak, aby vrátila aj slovo "pes".

Dog rex = new Dog();
rex.Name = "Rex";
rex.Age = 3;

Dog max = new Dog();
max.Name = "Max";
max.Age = 1;

rex.Speak();
rex.Birthday();
rex.Birthday();
Console.WriteLine(rex.Describe());

max.Speak();
Console.WriteLine(max.Describe());

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Speak()
    {
        Console.WriteLine(Name + ": Haf haf!");
    }

    public void Birthday()
    {
        Age = Age + 1;
        Console.WriteLine(Name + " ma narodeniny, teraz ma " + Age + " rokov");
    }

    public string Describe()
    {
        return Name + " (" + Age + ")";
    }
}
