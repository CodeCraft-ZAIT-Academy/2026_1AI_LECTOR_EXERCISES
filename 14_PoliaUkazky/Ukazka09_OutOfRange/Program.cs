// ===== 09 – Pozor na pretečenie: IndexOutOfRangeException =====
// Ukáž:       platné indexy sú 0 až Length - 1. Index mimo poľa spadne s výnimkou.
//             Ochrana: najprv skontrolovať index podmienkou.
// Skús:       1) odkomentuj riadok s numbers[3] = 40; a spusti s ladením (F5) – debugger sa zastaví na chybe.
//             2) zmeň index v premennej index na 0, 2, 3, -1 a pozri, čo vypíše ochranená verzia.

int[] numbers = { 10, 20, 30 };
Console.WriteLine("Length = " + numbers.Length + ", platné indexy: 0 až " + (numbers.Length - 1));

// numbers[3] = 40;    // IndexOutOfRangeException: index 3 je mimo poľa (platné sú 0, 1, 2)

int index = 3;
if (index >= 0 && index < numbers.Length)
{
    Console.WriteLine("numbers[" + index + "] = " + numbers[index]);
}
else
{
    Console.WriteLine("Index " + index + " je mimo poľa.");
}

// Ochrana do metódy: vráti hodnotu alebo náhradnú hodnotu
Console.WriteLine("SafeGet(numbers, 1, -1)  = " + SafeGet(numbers, 1, -1));
Console.WriteLine("SafeGet(numbers, 3, -1)  = " + SafeGet(numbers, 3, -1));
Console.WriteLine("SafeGet(numbers, -2, -1) = " + SafeGet(numbers, -2, -1));

static int SafeGet(int[] array, int position, int fallback)
{
    if (position < 0 || position >= array.Length)
    {
        return fallback;
    }

    return array[position];
}
