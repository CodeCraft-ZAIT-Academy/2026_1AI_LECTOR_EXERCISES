// ===== LIST 14 – Zber hodnôt od používateľa =====
// Pojmy: while + ReadLine + Add, koniec zadávania hodnotou 0, spracovanie po zbere
// Skús zmeniť:
//   1. Ukonči zadávanie slovom "koniec" namiesto čísla 0.
//   2. Po zbere vypíš čísla zoradené.
//   3. Povedz, prečo sme tu nemohli použiť pole (koľko prvkov by sme zvolili?).

List<int> numbers = new List<int>();

Console.WriteLine("Zadavaj cisla, 0 = koniec:");
int number = int.Parse(Console.ReadLine());
while (number != 0)
{
    numbers.Add(number);
    number = int.Parse(Console.ReadLine());
}

if (numbers.Count == 0)
{
    Console.WriteLine("Nezadal si ziadne cislo");
}
else
{
    int sum = 0;
    foreach (int n in numbers)
    {
        sum = sum + n;
    }
    Console.WriteLine("Zadal si " + numbers.Count + " cisel: " + string.Join(", ", numbers));
    Console.WriteLine("Sucet: " + sum);
}
