// Úloha 24: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   jacket
//   sweater
//   sweater
//   t-shirt

// Pod 0 °C bunda, od 0 do 15 °C vrátane sveter, nad 15 °C tričko.
Console.WriteLine(GetClothes(-5));
Console.WriteLine(GetClothes(0));
Console.WriteLine(GetClothes(15));
Console.WriteLine(GetClothes(20));

static string GetClothes(int temperature)
{
    if (temperature < 0)
    {
        return "jacket";
    }
    else if (temperature > 0 && temperature < 15)
    {
        return "sweater";
    }
    else
    {
        return "t-shirt";
    }
}
