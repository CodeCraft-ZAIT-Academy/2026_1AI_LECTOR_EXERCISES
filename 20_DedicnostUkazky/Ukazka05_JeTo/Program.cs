// ===== DEDIČNOSŤ 05 – Vzťah „je to“ (is-a) =====
// Pojmy: Car je Vehicle, premenná základného typu drží odvodený objekt, spoločná kolekcia
// Skús zmeniť:
//   1. Pridaj do garáže ešte jedno auto.
//   2. Odkomentuj riadok s NumberOfDoors. Prečo to nejde, hoci objekt je Car?
//   3. Skús do List<Vehicle> pridať objekt typu Dog (potrebuješ novú triedu). Prejde to?

Vehicle first = new Car { Color = "cervene", Weight = 1300, NumberOfDoors = 5 };
Console.WriteLine("Prva premenna: " + first.Color);
// Console.WriteLine(first.NumberOfDoors);   // chyba: Vehicle nevie o dveriach

List<Vehicle> garage = new List<Vehicle>();
garage.Add(new Car { Color = "modre", Weight = 1100, NumberOfDoors = 3 });
garage.Add(new Motorcycle { Color = "cierne", Weight = 200, HasSidecar = false });
garage.Add(first);

double totalWeight = 0;
foreach (Vehicle vehicle in garage)
{
    Console.WriteLine(vehicle.Color + " " + vehicle.Weight + " kg");
    totalWeight = totalWeight + vehicle.Weight;
}
Console.WriteLine("Celkova hmotnost: " + totalWeight + " kg");

public class Vehicle
{
    public string Color { get; set; }
    public double Weight { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
}
