// Úloha 31: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Obsah: 15
//   Obvod: 16

Rectangle r = new Rectangle { Width = 5, Height = 3 };
Console.WriteLine("Obsah: " + r.Area());
Console.WriteLine("Obvod: " + r.Perimeter());

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        return Width + Height;
    }

    public int Perimeter()
    {
        return 2 * Width + Height;
    }
}
