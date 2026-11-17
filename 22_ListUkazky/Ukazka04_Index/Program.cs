// ===== LIST 04 – Index =====
// Pojmy: numbers[0], zmena prvku, posledný prvok Count - 1, ArgumentOutOfRangeException
// Skús zmeniť:
//   1. Vypíš tretí prvok zoznamu.
//   2. Odkomentuj riadok s numbers[numbers.Count]. Pozri chybu v debuggeri.
//   3. Zmeň prvý prvok na 100 a vypíš zoznam.

List<int> numbers = new List<int> { 5, 10, 15, 20 };

Console.WriteLine("Prvy: " + numbers[0]);
Console.WriteLine("Posledny: " + numbers[numbers.Count - 1]);

numbers[1] = 99;                       // zmena prvku
Console.WriteLine("Po zmene: " + string.Join(", ", numbers));

// Console.WriteLine(numbers[numbers.Count]);     // ArgumentOutOfRangeException: posledný index je Count - 1

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine("Index " + i + ": " + numbers[i]);
}
