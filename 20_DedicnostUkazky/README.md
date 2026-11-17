# Dedičnosť (OOP) – učebné pomôcky (AppsLab-020)

Solution s funkčnými ukážkami na **výklad dedičnosti**. Z lekcie OOP preberáme **iba dedičnosť**: `class Dog : Animal`, zdedené členy, `base(...)`, vzťah „je to“. **Nie** zapuzdrenie (`private`, `protected`), polymorfizmus (`virtual`, `override`) ani abstrakciu (`abstract`, rozhrania) – tie sú samostatné témy. Nie sú to úlohy na opravovanie – sú určené na premietanie a upravovanie naživo.

Predpoklad: žiaci už poznajú triedy (`TriedyUkazky`): vlastnosti, metódy, konštruktor, `new`, `List` objektov.

## Ako s tým pracovať
1. Otvor `DedicnostUkazky.sln` vo Visual Studiu.
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5** (alebo Ctrl+F5).
3. V každom `Program.cs` je na začiatku komentár: pojmy a čo zmeniť naživo (*Skús zmeniť*). Pri výklade zmeň hodnotu, nechaj žiakov tipovať výsledok **pred** spustením a potom spusti.
4. Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

## Čo je pre žiakov nové
- Zápis `: Animal` za názvom triedy. Čítame „Dog **je** Animal“.
- Zdedené členy: odvodená trieda ich má, hoci ich nenapísala.
- `: base(...)` pri konštruktore: základná trieda potrebuje svoje parametre.
- Premenná základného typu drží aj odvodený objekt (`Vehicle v = new Car()`), ale cez ňu vidíme len spoločné členy. Pre tento rozdiel sa potom zíde polymorfizmus.
- Dedí sa len z **jednej** triedy (nie `class Dog : Mammal, Animal`).

## Odporúčané poradie

| # | Projekt | Čo ukazuje | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Ukazka01_PrvaDedicnost` | Prvá dedičnosť: trieda : Základná | Dog dedí z Animal. Zapisujeme `: Animal`. Dog automaticky dostane Name, Age aj Eat(), a pridá si vlastné Bark(). |
| 2 | `Ukazka02_Vehicle` | Príklad z lekcie: Vehicle, Car, Motorcycle | Presne príklad z lekcie. Spoločné veci (Color, Weight, Drive) sú v základnej triede, odlišné (dvere, sidecar) v odvodených. |
| 3 | `Ukazka03_BezDuplicity` | Dedičnosť odstraňuje duplicity | Bez dedičnosti by sme Name, Age a Eat() písali v každej triede zvlášť. Dedičnosť = napíšeme raz, používame všade. |
| 4 | `Ukazka04_VlastneCleny` | Odvodená trieda používa zdedené členy | Metóda odvodenej triedy vidí zdedené vlastnosti (Name), akoby boli jej vlastné. Student a Teacher pridávajú vlastné údaje. |
| 5 | `Ukazka05_JeTo` | Vzťah „je to“: premenná základného typu | Car JE Vehicle, preto ho môžeme uložiť do premennej typu Vehicle a do List<Vehicle>. Cez Vehicle ale vidíme len spoločné členy. |
| 6 | `Ukazka06_ViacUrovni` | Reťaz dedičnosti: starý rodič, rodič, dieťa | Dedičnosť sa dá reťaziť: Animal → Mammal → Dog. Pes má všetko z oboch predkov. Dedí sa len z jednej triedy naraz. |
| 7 | `Ukazka07_KonstruktorBase` | Konštruktor a base(...) | Konštruktory sa nededia. Odvodený konštruktor musí zavolať základný cez `: base(...)` a poslať mu parametre. |
| 8 | `Ukazka08_PoradieKonstruktorov` | Poradie volania konštruktorov | Pri new Dog() sa najprv vykoná konštruktor predka (Animal), potom Mammal, nakoniec Dog. Staviame zo základov nahor. |
| 9 | `Ukazka09_RpgPostavy` | RPG: Character, Wizard, Orc | Vylepšenie RPG z lekcie. Spoločné veci (Name, Health, Attack, Heal) sú v Character. Wizard a Orc pridávajú vlastné (mana, kúzlo, zúrivosť). |
| 10 | `Ukazka10_RpgBitka` | RPG bitka s dedičnosťou | Battle nepozná Wizard ani Orc, pracuje s Character. Jedna metóda Fight stačí pre všetky druhy postáv. |
| 11 | `Ukazka11_PoleZamestnancov` | Pole a List objektov rôznych odvodených tried | Pole Employee[] môže držať Manager aj Developer. Cez Employee vidíme spoločné vlastnosti (Name, Salary), takže ich vieme spočítať cyklom. |
| 12 | `Ukazka12_Tvary` | Každá odvodená trieda má vlastné metódy | Rectangle a Triangle majú vlastné Area(). Spoločné Color a Name sú v Shape. (Volanie Area() cez Shape by potrebovalo polymorfizmus – nabudúce.) |
| 13 | `Ukazka13_SamostatneSubory` | Dedičnosť v samostatných súboroch | Každá trieda vo vlastnom súbore (Animal.cs, Dog.cs, Cat.cs). Dedenie funguje rovnako, Program.cs ostáva krátky. |
| 14 | `Ukazka14_JeAleboMa` | Dedičnosť alebo vlastnosť? „je to“ vs. „má“ | Dedíme, keď platí „X JE Y“ (auto je vozidlo). Keď platí „X MÁ Y“ (auto má motor), použijeme vlastnosť s objektom. |
| 15 | `Ukazka15_Skola` | Zhrnutie: škola (Person, Student, Teacher) | Spojenie všetkého: základná trieda, dve odvodené, konštruktory s base, List základného typu aj odvodených. |
| 16 | `Ukazka16_LadenieDedicnosti` | Ladenie: pozeranie dedených členov v debuggeri | V Locals sa pri objekte odvodenej triedy zobrazí uzol „base“ so zdedenými členmi. F11 vstúpi do konštruktora Dog a potom do Animal. |

## Návrh ako rozdeliť hodinu
- **Základ (1–3):** `: Animal`, zdedené členy, prečo to šetrí kód – 25 minút. Prirovnanie: dieťa zdedí farbu očí po rodičoch, ale má aj vlastné vlastnosti.
- **Vlastné a zdedené členy (4–6):** čo dostane odvodená trieda, čo si pridá, reťaz dedičnosti – 20 minút.
- **Konštruktory (7, 8):** `base(...)`, poradie volania – 20 minút. Žiaci tu robia najviac chýb.
- **RPG (9, 10):** návrat k úlohe z lekcie: Wizard a Orc namiesto Character a Enemy – 20 minút.
- **Kolekcie a vzťahy (11–15):** pole rôznych potomkov, tvary, samostatné súbory, „je to“ vs. „má“, škola – podľa času.
- **Ladenie (16):** dedené členy v debuggeri – 10 minút.

## Odpovede k ukážke 16 (ladenie)
- STOP 1: F11 vstúpi najprv do konštruktora `Dog`. Na riadku `: base(name)` potom skočí do konštruktora `Animal` a po jeho dokončení sa vráti do `Dog`. V *Call Stack* je `Dog..ctor` pod `Animal..ctor`.
- STOP 2: v okne *Locals* je pri `rex` uzol **Base (Animal)** so zdedenou vlastnosťou `Name = "Rex"`. `Breed = "Labrador"` je priamo pod `rex`.
- STOP 3: `this` je objekt `rex` (typ `Dog`). `Name` pochádza z `Animal`, `Breed` z `Dog`. Metóda ich používa rovnako.

## Poznámky
- Ukážka 10 (RPG bitka) je referenčné riešenie – nezdieľajte ju so žiakmi skôr, než ju sami skúsia.
- Ukážka 9 a 10 posielajú `Wizard` a `Orc` do parametra typu `Character`. Ide o prirodzený dôsledok „je to“. Dôvod stačí povedať jednou vetou, podrobne to bude pri polymorfizme.
- Ukážka 12 (Tvary) zámerne nemá `Area()` v `Shape`. Volanie `Area()` cez `Shape` by vyžadovalo `virtual`/`override` (polymorfizmus).
- Ukážka 13 má v projekte tri súbory: `Animal.cs`, `Dog.cs`, `Cat.cs`.

Nadväzuje: `OpravaDedicnost` (pokazené programy na opravovanie). Predchádzajúce: `TriedyUkazky`.
