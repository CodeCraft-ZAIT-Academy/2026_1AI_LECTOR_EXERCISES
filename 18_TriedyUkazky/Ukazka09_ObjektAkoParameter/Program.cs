// ===== TRIEDY 09 – Objekt ako parameter a návratová hodnota =====
// Pojmy: objekt v parametri, metóda mení objekt, metóda vracia nový objekt
// Skús zmeniť:
//   1. Zavolaj Birthday(rex) ešte raz.
//   2. Napíš metódu MakeOlder(Dog dog, int years), ktorá pridá viac rokov naraz.
//   3. Vytvor ďalšieho šteniatko cez CreatePuppy a vypíš ho.

Dog rex = new Dog { Name = "Rex", Age = 3 };
PrintDog(rex);

Birthday(rex);
PrintDog(rex);

Dog puppy = CreatePuppy("Bruno");
PrintDog(puppy);

static void PrintDog(Dog dog)
{
    Console.WriteLine(dog.Name + " (" + dog.Age + ")");
}

// Metóda dostala ten istý objekt, preto zmena platí aj mimo metódy
static void Birthday(Dog dog)
{
    dog.Age = dog.Age + 1;
}

// Metóda môže objekt aj vytvoriť a vrátiť
static Dog CreatePuppy(string name)
{
    Dog dog = new Dog();
    dog.Name = name;
    dog.Age = 0;
    return dog;
}

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
