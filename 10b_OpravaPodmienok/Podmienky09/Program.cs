// Úloha 9: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   adult

int age = 20;
string category;

if (age >= 18)
{
    category = "adult";
}
else if (age >= 13)
{
    category = "teenager";
}
else if (age >= 0)
{
    category = "kid";
}

Console.WriteLine(category);
