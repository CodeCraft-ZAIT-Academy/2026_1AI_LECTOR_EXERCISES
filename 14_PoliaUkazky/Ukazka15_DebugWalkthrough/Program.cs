// ===== 15 – Polia v debuggeri =====
// Ukáž:       v okne Locals sa dá pole rozbaliť a vidno všetky prvky [0], [1], [2]...
// Úlohy:      1) Nastav breakpoint na prvý riadok a spusti F5 (nie Ctrl+F5).
//             2) Krokuj F10 a rozbaľ numbers v okne Locals. Ako sa menia prvky po každom riadku?
//             3) Do okna Watch pridaj: numbers[1], numbers.Length, numbers[numbers.Length - 1].
//             4) Na riadku STOP 1 zmeň v Locals hodnotu numbers[2] na 100 a pokračuj.
//             5) Pri volaní GetLastElement stlač F11. Čo vidíš v parametri array?

int[] numbers = { 10, 20, 30, 40, 50 };
numbers[1] = 25;
int temp = numbers[0];
numbers[0] = numbers[4];
numbers[4] = temp;
Console.WriteLine("Pole: " + string.Join(", ", numbers));        // STOP 1

int last = GetLastElement(numbers);
Console.WriteLine("Posledný prvok: " + last);

static int GetLastElement(int[] array)
{
    return array[array.Length - 1];
}
