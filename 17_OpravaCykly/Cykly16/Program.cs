// Úloha 16: Oprav program tak, aby fungoval správne.
// Pozor: program sa môže zaseknúť (nekonečný cyklus). Zastav ho: Shift+F5 (ladenie) alebo Ctrl+C (konzola).
// Očakávaný výstup:
//   10

// Súčet čísel 0 až 4.
int i = 0;
int sum = 0;
while (i < 5)
{
    sum += i;
}
Console.WriteLine(sum);
