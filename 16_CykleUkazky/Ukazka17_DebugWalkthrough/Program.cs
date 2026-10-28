// ===== 17 – Cykly v debuggeri =====
// Ukáž:       ako sa mení premenná i a súčet po každom prechode cyklu. Podmienený breakpoint.
// Úlohy:      1) Nastav breakpoint na riadok sum += i * i; a spusti F5. Pri každom zastavení stlač F5
//                a sleduj v Locals hodnoty i a sum. Zapíš si ich do tabuľky.
//             2) Pravý klik na červený breakpoint -> Conditions -> zadaj  i == 3  .
//                Spusti znova: zastaví sa len raz. Aké sú i a sum v tej chvíli?
//             3) Nastav breakpoint na riadok Console.WriteLine("Hotovo"); a zisti hodnotu sum.
//             4) Pri zastavení na riadku sum += i * i; (i == 3) pridaj do Watch výrazy  i * i  a  sum + i * i  . Čo ukazujú?
//             5) Nastav breakpoint na riadok numbers[i] = numbers[i] + 100; a zisti pole numbers po cykle.

int sum = 0;
for (int i = 1; i <= 5; i++)
{
    sum += i * i;
}
Console.WriteLine("Súčet druhých mocnín 1 až 5: " + sum);
Console.WriteLine("Hotovo");

int[] numbers = { 1, 2, 3 };
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] + 100;
}
Console.WriteLine(string.Join(", ", numbers));
