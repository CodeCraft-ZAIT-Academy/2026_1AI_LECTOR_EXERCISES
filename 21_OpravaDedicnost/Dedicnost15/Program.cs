// Úloha 15: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   cervene
//   cierne

Vehicle[] garage = new Vehicle[2];
garage[0].Color = "cervene";
garage[1].Color = "cierne";

foreach (Vehicle v in garage)
{
    Console.WriteLine(v.Color);
}

public class Vehicle
{
    public string Color { get; set; }
}

public class Car : Vehicle
{
}
