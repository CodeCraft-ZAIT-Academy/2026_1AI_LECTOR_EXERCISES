// ===== DEDIČNOSŤ 13 – Dedičnosť v samostatných súboroch =====
// Pojmy: jeden súbor = jedna trieda, Dog.cs dedí z Animal.cs
// Skús zmeniť:
//   1. Otvor Dog.cs. Všimni si, že tam nie je žiadne using ani odkaz na Animal.cs, a funguje to.
//   2. Pridaj do projektu novú triedu Bird.cs (pravý klik na projekt → Add → Class) a nechaj ju dediť z Animal.
//   3. Zmeň v Animal.cs text v Eat(). Prejaví sa to u psa aj u mačky?

Dog rex = new Dog { Name = "Rex", Age = 3 };
Cat micka = new Cat { Name = "Micka", Age = 2 };

rex.Eat();
rex.Bark();
micka.Eat();
micka.Meow();
