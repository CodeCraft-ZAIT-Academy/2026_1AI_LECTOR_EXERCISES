// ===== Ladenie 16 – Výnimka: zlý formát čísla =====
// Lekcia: AppsLab-004 Variables, AppsLab-005 DataTypes
// Nový nástroj: čítanie správy výnimky, kontrola textu pred prevodom
// Cieľ: Zistiť, prečo int.Parse spadne, a nájsť text, ktorý ho spôsobil.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti F5. Prečítaj Exception Helper: typ výnimky a správu (message).
//   2. V Locals zapíš hodnotu ageText (STOP 1). Pozri na ňu v okne Text Visualizer (lupa vedľa hodnoty).
//   3. Zisti, odkiaľ sa text vzal: zastav ladenie, nastav breakpoint v ReadAge a vstúp F11. Zapíš text (STOP 2).
//   4. Oprav chybu tak, aby program vypísal vek o rok väčší.
//
// Očakávaný výstup (po oprave):
//   Text: 15
//   Next year: 16
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: ageText = ____
//   STOP 2: text = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

string ageText = ReadAge();
Console.WriteLine("Text: " + ageText);
int age = int.Parse(ageText);                          // STOP 1
Console.WriteLine("Next year: " + (age + 1));

static string ReadAge()
{
    string text = "15 years";
    return text;                                       // STOP 2
}
