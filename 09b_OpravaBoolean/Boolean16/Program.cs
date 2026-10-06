// Úloha 16: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   False
//   True
//   True

// Dospelý je ten, kto má aspoň 18 rokov.
Console.WriteLine(IsAdult(17));
Console.WriteLine(IsAdult(18));
Console.WriteLine(IsAdult(19));

static bool IsAdult(int age)
{
    return age > 18;
}
