// Úloha 21: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   green
//   orange
//   red

Console.WriteLine(NextColor("red"));
Console.WriteLine(NextColor("green"));
Console.WriteLine(NextColor("orange"));

static string NextColor(string color)
{
    if (color == "red")
    {
        color = "green";
    }
    if (color == "green")
    {
        color = "orange";
    }
    if (color == "orange")
    {
        color = "red";
    }
    return color;
}
