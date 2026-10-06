// ===== 16 – BONUS: trojmocný operátor ?: a skrátená syntax =====
// Mimo lekcie – pre rýchlejších žiakov.
// Ukáž:       podmienka ? hodnota_ak_pravda : hodnota_ak_nepravda

int age = 20;

string text = age >= 18 ? "adult" : "not an adult";
Console.WriteLine(text);

Console.WriteLine(age >= 18 ? "You can enter." : "Sorry, too young.");

// Skrátená syntax bez { } – funguje, ale NEODPORÚČA SA (chyby pri úpravách kódu)
if (age >= 18)
    Console.WriteLine("Short syntax: adult.");
else
    Console.WriteLine("Short syntax: not an adult.");
