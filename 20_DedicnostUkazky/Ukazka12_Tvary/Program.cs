// ===== DEDIČNOSŤ 12 – Tvary =====
// Pojmy: spoločné vlastnosti v základnej triede, vlastné metódy v odvodených
// Skús zmeniť:
//   1. Zmeň rozmery a predpovedz obsah.
//   2. Pridaj triedu Square : Shape s vlastnosťou Side a metódou Area().
//   3. Skús zavolať Area() na premennej typu Shape. Prečo to nejde? (Odpoveď: polymorfizmus.)

Rectangle rect = new Rectangle { Name = "Obdlznik", Color = "modry", Width = 5, Height = 3 };
Triangle tri = new Triangle { Name = "Trojuholnik", Color = "zeleny", BaseSide = 6, Height = 4 };

rect.Print();
Console.WriteLine("Obsah: " + rect.Area());

tri.Print();
Console.WriteLine("Obsah: " + tri.Area());

public class Shape
{
    public string Name { get; set; }
    public string Color { get; set; }

    public void Print()
    {
        Console.WriteLine(Name + " (" + Color + ")");
    }
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }
}

public class Triangle : Shape
{
    public int BaseSide { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        return BaseSide * Height / 2;
    }
}
