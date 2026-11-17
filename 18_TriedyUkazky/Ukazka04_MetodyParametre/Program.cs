// ===== TRIEDY 04 – Metódy s parametrami a návratovou hodnotou =====
// Pojmy: parameter, return, metóda mení vlastnosti objektu
// Skús zmeniť:
//   1. Zmeň rozmery obdĺžnika a skús predpovedať Area() a Perimeter().
//   2. Zavolaj Scale(3) namiesto Scale(2).
//   3. Pridaj metódu IsBiggerThan(Rectangle other), ktorá porovná obsahy.

Rectangle r = new Rectangle();
r.Width = 5;
r.Height = 3;

Console.WriteLine("Obsah: " + r.Area());
Console.WriteLine("Obvod: " + r.Perimeter());

r.Scale(2);
Console.WriteLine("Po zvacseni: " + r.Width + " x " + r.Height);
Console.WriteLine("Je stvorec? " + r.IsSquare());

Rectangle s = new Rectangle();
s.Width = 4;
s.Height = 4;
Console.WriteLine("Je stvorec? " + s.IsSquare());

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }

    public int Perimeter()
    {
        return 2 * (Width + Height);
    }

    public void Scale(int factor)
    {
        Width = Width * factor;
        Height = Height * factor;
    }

    public bool IsSquare()
    {
        return Width == Height;
    }
}
