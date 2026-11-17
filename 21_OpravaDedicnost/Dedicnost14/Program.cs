// Úloha 14: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Vozidiel: 2

List<Car> garage = new List<Car>();
garage.Add(new Car { Color = "cervene" });
garage.Add(new Motorcycle { Color = "cierne" });
Console.WriteLine("Vozidiel: " + garage.Count);

public class Vehicle
{
    public string Color { get; set; }
}

public class Car : Vehicle
{
}

public class Motorcycle : Vehicle
{
}
