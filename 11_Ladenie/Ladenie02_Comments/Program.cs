// ===== Ladenie 02 – Komentáre a debugger =====
// Lekcia: AppsLab-003 Comments
// Nový nástroj: žltý riadok preskakuje komentáre, počet krokov
// Cieľ: Uvedomiť si, že komentáre sa nevykonávajú a debugger ich preskočí.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Nastav breakpoint na prvý príkaz (int a = 10;) a spusti F5.
//   2. Krokuj F10 a sleduj, ktoré riadky žltá čiara preskočí. Spočítaj, koľkokrát stlačíš F10, kým program skončí.
//   3. Zapíš si hodnotu a na riadku STOP 1.
//   4. Odkomentuj riadok // a = 1000; (Ctrl+K, Ctrl+U) a spusti ladenie znova. Ako sa zmenila hodnota a na STOP 1?
//   5. Zakomentuj späť (Ctrl+K, Ctrl+C).
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: a = ____
//
// Otázky:
//   Q1: Koľko príkazov sa vykoná (koľkokrát treba F10 od prvého príkazu do konca)?
//   Q2: Zastaví sa debugger na riadku s komentárom?
//   Q3: Aká bude hodnota a na STOP 1 po odkomentovaní riadku a = 1000?

// This is a single-line comment
int a = 10;
/* This is a
   multi-line comment */

// a = 1000;
a = a + 5;
Console.WriteLine(a);                                  // STOP 1

/* a = 0;
   Console.WriteLine("hidden"); */
Console.WriteLine("End");
