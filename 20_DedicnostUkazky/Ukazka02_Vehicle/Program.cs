// ===== DEDIČNOSŤ 02 – Vehicle, Car, Motorcycle (príklad z lekcie) =====
// Pojmy: spoločný kód v základnej triede, odvodené triedy pridávajú vlastné vlastnosti
// Skús zmeniť:
//   1. Pridaj triedu Truck : Vehicle s vlastnosťou Load (náklad v kg).
//   2. Pridaj do Vehicle vlastnosť Brand. Majú ju Car aj Motorcycle?
//   3. Skús na motorke zistiť NumberOfDoors. Prečo to nejde?

Car car = new Car();
car.Color = "cervene";
car.Weight = 1300;
car.NumberOfDoors = 5;

Motorcycle moto = new Motorcycle();
moto.Color = "cierne";
moto.Weight = 200;
moto.HasSidecar = true;

Console.WriteLine("Auto: " + car.Color + ", " + car.Weight + " kg, dveri: " + car.NumberOfDoors);
car.Drive();

Console.WriteLine("Motorka: " + moto.Color + ", " + moto.Weight + " kg, sidecar: " + moto.HasSidecar);
moto.Drive();

public class Vehicle
{
    public string Color { get; set; }
    public double Weight { get; set; }

    public void Drive()
    {
        Console.WriteLine("Jazdi...");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
}
