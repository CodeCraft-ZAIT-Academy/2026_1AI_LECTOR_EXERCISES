// ===== 07 – Na poradí vetiev else if záleží =====
// Ukáž:       rovnaké podmienky v zlom poradí dajú zlý výsledok.
//             Prvá pravdivá vetva vyhráva, preto najprv najprísnejšia podmienka.
// Skús zmeniť: počet bodov (95, 60, 30). Pri ktorých hodnotách sa líši WrongOrder a RightOrder?

Console.WriteLine("95 points, wrong order: " + WrongOrder(95));
Console.WriteLine("95 points, right order: " + RightOrder(95));
Console.WriteLine("60 points, wrong order: " + WrongOrder(60));
Console.WriteLine("60 points, right order: " + RightOrder(60));
Console.WriteLine("30 points, wrong order: " + WrongOrder(30));
Console.WriteLine("30 points, right order: " + RightOrder(30));

static string WrongOrder(int points)
{
    if (points >= 50)
    {
        return "passed";            // 95 sa zastaví tu, "excellent" sa nikdy nedosiahne
    }
    else if (points >= 90)
    {
        return "excellent";
    }
    else
    {
        return "failed";
    }
}

static string RightOrder(int points)
{
    if (points >= 90)
    {
        return "excellent";
    }
    else if (points >= 50)
    {
        return "passed";
    }
    else
    {
        return "failed";
    }
}
