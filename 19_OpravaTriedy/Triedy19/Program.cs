// Úloha 19: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Pomer stran: 2

Rectangle r = new Rectangle();
r.Width = 10;
Console.WriteLine("Pomer stran: " + r.Ratio());

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Ratio()
    {
        return Width / Height;
    }
}
