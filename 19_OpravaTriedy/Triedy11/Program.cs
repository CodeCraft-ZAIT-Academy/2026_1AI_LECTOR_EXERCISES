// Úloha 11: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Obsah: 15

Rectangle r = new Rectangle();
r.Width = 5;
r.Height = 3;
Console.WriteLine("Obsah: " + r.Area());

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        int result = Width * Height;
    }
}
