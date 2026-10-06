// ===== Ladenie 15 – Výnimka: delenie nulou =====
// Lekcia: AppsLab-009 Operators, AppsLab-018 Methods
// Nový nástroj: Exception Helper, Locals pri výnimke, Call Stack
// Cieľ: Nechať program spadnúť v debuggeri a zistiť, odkiaľ sa vzala nula.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Spusti F5 (bez breakpointu). Debugger sa na chybe sám zastaví. Prečítaj okno Exception Helper: typ výnimky a text.
//   2. Pozri do Locals: aká je hodnota total a count? Zapíš ich (STOP 1).
//   3. Bez ukončenia ladenia otvor Call Stack. Z ktorej metódy sa to volalo?
//   4. Ukonči ladenie (Shift+F5). Nastav breakpoint na riadok s CountStudents() a vstúp F11. Zapíš boys a girls (STOP 2).
//   5. Oprav metódu CountStudents tak, aby vracala 12 + 14 žiakov, a skontroluj výstup.
//
// Očakávaný výstup (po oprave):
//   Students: 26
//   Average: 3
// (desatinná bodka/čiarka vo výstupe závisí od nastavení Windows)
//
// Zapíš hodnoty na papier alebo sem:
//   STOP 1: total = ____, count = ____
//   STOP 2: boys = ____, girls = ____
//
// Chyba je na riadku č. ____ . Oprava: ______________________________

int total = 100;
int count = CountStudents();
Console.WriteLine("Students: " + count);
int average = total / count;                           // STOP 1
Console.WriteLine("Average: " + average);

static int CountStudents()
{
    int boys = 0;
    int girls = 0;
    return boys + girls;                               // STOP 2
}
