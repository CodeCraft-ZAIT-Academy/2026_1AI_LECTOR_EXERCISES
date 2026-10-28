// ===== 07 – Index z premennej (interaktívna) =====
// Ukáž:       index nemusí byť číslo napísané v kóde – môže to byť premenná alebo výraz.
//             Skús zadať 0 až 4. Potom skús 5 alebo -1: program spadne s IndexOutOfRangeException
//             (o tom je nasledujúca ukážka).

int[] numbers = { 10, 20, 30, 40, 50 };

Console.Write("Zadaj index (0 - 4): ");
int position = int.Parse(Console.ReadLine());

Console.WriteLine("numbers[" + position + "] = " + numbers[position]);
Console.WriteLine("Dvojnásobok vybraného prvku: " + numbers[position] * 2);

// Index môže byť aj výraz
Console.WriteLine("Posledný prvok: " + numbers[numbers.Length - 1]);
