// ===== TRIEDY 01 – Prvá trieda =====
// Pojmy: trieda (plán), objekt (vec podľa plánu), vlastnosť (property), new, bodka
// Skús zmeniť:
//   1. Zmeň meno a vek psa.
//   2. Pridaj do triedy novú vlastnosť, napr. string Breed (plemeno), a vypíš ju.
//   3. Skús vytvoriť druhého psa. Čo sa stane s prvým?

Dog myDog = new Dog();
myDog.Name = "Rex";
myDog.Age = 3;

Console.WriteLine("Meno: " + myDog.Name);
Console.WriteLine("Vek: " + myDog.Age);

// Trieda je plán: určuje, aké vlastnosti bude mať každý pes.
// Píše sa POD príkazmi (v Program.cs idú najprv príkazy, až potom triedy).
public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
