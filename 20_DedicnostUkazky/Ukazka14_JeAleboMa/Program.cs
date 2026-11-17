// ===== DEDIČNOSŤ 14 – „je to“ alebo „má“? =====
// Pojmy: dedičnosť = „je to“, vlastnosť s objektom = „má“
// Skús zmeniť:
//   1. Pridaj do Engine vlastnosť Fuel (palivo).
//   2. Zamysli sa: má sa dať napísať class Car : Engine? Prečo je to zlý nápad?
//   3. Vymysli ďalšie páry: Pes/Zviera, Dom/Strecha, Učiteľ/Osoba, Telefón/Batéria. Kde dedíme a kde ide o vlastnosť?

Car car = new Car { Color = "cervene" };
car.Engine = new Engine { Power = 110 };

// Car JE Vehicle (dedí z Vehicle): má Color a Drive()
// Car MÁ Engine (vlastnosť): má Power cez car.Engine.Power
Console.WriteLine("Auto " + car.Color + " ma motor s vykonom " + car.Engine.Power + " kW");
car.Drive();

public class Vehicle
{
    public string Color { get; set; }

    public void Drive()
    {
        Console.WriteLine("Jazdi...");
    }
}

public class Engine
{
    public int Power { get; set; }
}

public class Car : Vehicle
{
    public Engine Engine { get; set; }
}
