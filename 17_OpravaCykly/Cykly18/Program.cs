// Úloha 18: Oprav program tak, aby fungoval správne.
// Pozor: program sa môže zaseknúť (nekonečný cyklus). Zastav ho: Shift+F5 (ladenie) alebo Ctrl+C (konzola).
// Očakávaný výstup:
//   21

// Nájdi prvé číslo väčšie ako 20, ktoré je deliteľné 7.
int n = 20;
int result = 0;
bool found = false;
while (!found)
{
    n++;
    if (n % 7 == 0)
    {
        result = n;
    }
}
Console.WriteLine(result);
