// ===== TRIEDY 15 – Bankový účet =====
// Pojmy: dáta a správanie pokope, kontrola v metóde, problém: vlastnosť sa dá zmeniť aj mimo metód
// Skús zmeniť:
//   1. Skús vybrať viac peňazí, než je na účte.
//   2. Zavolaj Deposit(-50). Čo sa stane? Dá sa to ošetriť?
//   3. Prečo je riadok account.Balance = -5000 problém? (Odpoveď príde s témou zapuzdrenie.)

BankAccount account = new BankAccount { Owner = "Anna" };

account.Deposit(100);
account.Withdraw(30);
Console.WriteLine(account.Owner + " ma na ucte " + account.Balance + " EUR");

account.Withdraw(500);
Console.WriteLine("Po neuspesnom vybere: " + account.Balance + " EUR");

// Problém: nič nám nebráni zmeniť zostatok priamo, obídeme kontrolu v metóde
account.Balance = -5000;
Console.WriteLine("Po priamom prepisani: " + account.Balance + " EUR");

public class BankAccount
{
    public string Owner { get; set; }
    public int Balance { get; set; }

    public void Deposit(int amount)
    {
        Balance = Balance + amount;
    }

    public void Withdraw(int amount)
    {
        if (amount <= Balance)
        {
            Balance = Balance - amount;
        }
        else
        {
            Console.WriteLine("Nedostatok penazi!");
        }
    }
}
