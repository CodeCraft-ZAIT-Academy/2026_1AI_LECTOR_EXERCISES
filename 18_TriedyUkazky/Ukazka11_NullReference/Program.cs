// ===== TRIEDY 11 – null a NullReferenceException =====
// Pojmy: null (žiadny objekt), kontrola != null, NullReferenceException
// Skús zmeniť:
//   1. Odkomentuj riadok s Console.WriteLine(dog.Name) pred vytvorením objektu. Pozri chybu v debuggeri.
//   2. Odkomentuj riadok s dogs[0].Name. Prečo padne?
//   3. Oprav obe chyby (new Dog()).

Dog dog = null;
Console.WriteLine("dog je null? " + (dog == null));
// Console.WriteLine(dog.Name);            // NullReferenceException!

if (dog != null)
{
    Console.WriteLine(dog.Name);
}
else
{
    Console.WriteLine("Pes este neexistuje");
}

dog = new Dog { Name = "Rex" };
if (dog != null)
{
    Console.WriteLine("Pes existuje: " + dog.Name);
}

Dog[] dogs = new Dog[2];
Console.WriteLine("dogs[0] je null? " + (dogs[0] == null));
// dogs[0].Name = "Max";                   // NullReferenceException!

dogs[0] = new Dog();
dogs[0].Name = "Max";
Console.WriteLine("dogs[0] po new: " + dogs[0].Name);

public class Dog
{
    public string Name { get; set; }
}
