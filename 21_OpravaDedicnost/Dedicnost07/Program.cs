// Úloha 7: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   cierne, sidecar: True

Motorcycle moto = new Motorcycle();
moto.Color = "cierne";
moto.NumberOfDoors = 2;
Console.WriteLine(moto.Color + ", dveri: " + moto.NumberOfDoors);

public class Vehicle
{
    public string Color { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
}
