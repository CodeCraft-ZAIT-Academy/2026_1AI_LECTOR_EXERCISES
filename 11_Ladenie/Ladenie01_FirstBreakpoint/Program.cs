// ===== Ladenie 01 – Prvý breakpoint =====
// Lekcia: AppsLab-001 StartHere, AppsLab-002 Console.WriteLine
// Nový nástroj: breakpoint (F9), F5, žltý riadok, F10, F11, Shift+F11
// Cieľ: Naučiť sa zastaviť program, krokovať ho a zistiť, kedy sa čo vypíše.
//
// Spusti program s LADENÍM (F5), nie Ctrl+F5. Hodnoty zapisuj v okamihu, keď je riadok s označením
// STOP žltý (ešte sa nevykonal). Počet žltých riadkov, ktoré treba vyplniť, je v zozname nižšie.
//
// Úlohy:
//   1. Klikni na sivý okraj vľavo od prvého riadku s Console.WriteLine (alebo stlač F9). Objaví sa červený bod – breakpoint.
//   2. Spusti program s ladením: F5 (Debug -> Start Debugging). Program sa zastaví a riadok sa zvýrazní žltou.
//   3. Pozri do konzoly. Stlač F10 a sleduj, v ktorom okamihu sa text vypíše.
//   4. Krokuj F10 až po riadok STOP 2. Teraz stlač F11 (vstup do metódy). Kde si sa ocitol? Vráť sa klávesom Shift+F11.
//   5. Dokrokuj po riadok STOP 3 a spočítaj riadky v konzole.
//
// Otázky:
//   Q1: Je žltý riadok už vykonaný?
//   Q2: Čo spraví F10 a čo F11 na riadku s volaním metódy Hello()?
//   Q3: Čo robí Shift+F5?

Console.WriteLine("Hello World!");                      // STOP 1
string name = "Jan";
Console.WriteLine("Hello, " + name + "!");
Console.WriteLine(Hello());                            // STOP 2
Console.WriteLine("Line one\nLine two");
Console.WriteLine("He said: \"Hi\"");
Console.WriteLine("Done.");                            // STOP 3

static string Hello()
{
    return "Hello AppsLab!";
}
