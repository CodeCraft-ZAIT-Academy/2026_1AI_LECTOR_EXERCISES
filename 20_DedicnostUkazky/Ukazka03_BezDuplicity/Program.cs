// ===== DEDIČNOSŤ 03 – Dedičnosť odstraňuje duplicity =====
// Pojmy: znovupoužitie kódu, jedna zmena = platí pre všetkých potomkov
// Skús zmeniť:
//   1. Zmeň text v Animal.Eat(). Zmenilo sa to u psa aj u mačky?
//   2. Pridaj tretie zviera (Bird) s vlastnou metódou Fly().
//   3. Predstav si, že Name, Age a Eat() by si musel písať zvlášť v Dog, Cat a Bird. Koľko riadkov navyše?

Dog rex = new Dog { Name = "Rex", Age = 3 };
Cat micka = new Cat { Name = "Micka", Age = 2 };

rex.Eat();
rex.Bark();

micka.Eat();
micka.Meow();

// Spoločné vlastnosti a metódy sú len v Animal
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " papa");
    }
}

// Odvodené triedy majú len to, čo je pre ne špecifické
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + ": Haf haf!");
    }
}

public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine(Name + ": Mnau!");
    }
}
