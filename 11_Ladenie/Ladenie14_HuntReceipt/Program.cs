// ===== Ladenie 14 – Boss: bloček z pokladne =====
// Lekcia: AppsLab-009, 012, 013, 018 (všetko dokopy)
// Nový nástroj: kombinácia: F11, Call Stack, Watch, podmienky, operátory
// Cieľ: Program pokladne počíta zle. Nájdi 3 chyby v dvoch metódach. Tretia metóda je správna.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti bez ladenia (Ctrl+F5) a porovnaj výstup s očakávaným. Ktoré bločky sú zlé?
//   2. Breakpoint na prvé volanie PrintReceipt. F5 a F11 do metódy.
//   3. V PrintReceipt krokuj po jednom riadku a pri každej metóde (F11) zapíš parametre a vrátenú hodnotu (STOP 1–3).
//   4. Pomocou Call Stack zisti, ktorá metóda koho volá.
//   5. Najprv zisti, ktorý riadok je zlý, až potom ho oprav. Opravuj po jednej chybe a vždy znovu otestuj.
//
// Očakávaný výstup (po oprave):
//   Subtotal: 60
//   Discount: 15 %
//   Total: 51
//   Subtotal: 40
//   Discount: 0 %
//   Total: 40
//   Subtotal: 50
//   Discount: 10 %
//   Total: 45
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: price = ____, quantity = ____
//   STOP 2: subtotal = ____, hasCard = ____
//   STOP 3: amount = ____, percent = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

PrintReceipt(20, 3, true);
PrintReceipt(20, 2, false);
PrintReceipt(25, 2, false);

static void PrintReceipt(double price, int quantity, bool hasCard)
{
    double subtotal = CalculateSubtotal(price, quantity);
    double discount = GetDiscountPercent(subtotal, hasCard);
    double total = ApplyDiscount(subtotal, discount);

    Console.WriteLine("Subtotal: " + subtotal);
    Console.WriteLine("Discount: " + discount + " %");
    Console.WriteLine("Total: " + total);
}

static double CalculateSubtotal(double price, int quantity)
{
    return price + quantity;                           // STOP 1
}

static double GetDiscountPercent(double subtotal, bool hasCard)
{
    double discount = 0;

    if (subtotal > 50)                                 // STOP 2
    {
        discount = 10;
    }

    if (hasCard)
    {
        discount = 5;
    }

    return discount;
}

static double ApplyDiscount(double amount, double percent)
{
    return amount - amount * percent / 100;            // STOP 3
}
