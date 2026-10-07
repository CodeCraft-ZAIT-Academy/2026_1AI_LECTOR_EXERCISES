# Základy WPF – učebné pomôcky a príklady

Solution s 16 ukážkami na výklad **základov WPF**: Button, Label, TextBlock, TextBox, Image (aj ako tlačidlo), rozloženie (StackPanel, Grid), vlastnosti, udalosti a mini aplikácie (počítadlo, kalkulačka, prevodník, vizitka, Kasa).

Všetky programy používajú len to, čo žiaci poznajú: premenné, operátory, metódy a `Console`-štýl uvažovania. **Nepoužívajú `if`** (podmienky prídu neskôr).

## Ako s tým pracovať
1. Otvor `WpfUkazky.sln` vo Visual Studiu (workload **.NET desktop development**, Windows).
2. Pravý klik na projekt v *Solution Explorer* → **Set as Startup Project**, spusti **F5**.
3. V `MainWindow.xaml` je na začiatku komentár s pojmom a nápadmi *Skús zmeniť*. Zmeň hodnotu vo XAML a pozoruj designer, potom spusti.
4. Build Solution (Ctrl+Shift+B) funguje – všetky projekty sa zostavia.

**Obrázky:** sú v priečinku `Images` v projektoch, ktoré ich používajú (súbory PNG, Build Action = Resource, v `.csproj` je `<Resource Include="Images\**\*.png" />`). Do vlastného projektu ich pridáš: pravý klik na projekt → *Add → New Folder* (Images) → *Add → Existing Item*.

**Mená prvkov:** `btn…` tlačidlo, `lbl…` Label, `txt…` TextBox/TextBlock, `img…` Image. Prvok musí mať `x:Name`, ak sa naň odvolávame z C#.

## Zoznam ukážok

| # | Projekt | Pojem | Poznámka k výkladu |
|---|---|---|---|
| 1 | `Wpf01_FirstWindow` | Window, XAML vs. C# code-behind | Dva súbory: `MainWindow.xaml` je vzhľad (XAML), `MainWindow.xaml.cs` je správanie (C#). Zmeňte hodnoty v XAML a pozorujte designer. |
| 2 | `Wpf02_Label` | Label (Content), TextBlock (Text), vlastnosti písma a farby | Label má vlastnosť `Content`, TextBlock vlastnosť `Text`. TextBlock vie zalamovať dlhý text (`TextWrapping`), Label nie. Skúste zúžiť okno. |
| 3 | `Wpf03_Button` | Button, x:Name, Click, premenná v triede | Prvá interakcia: klik → metóda. Zdôraznite `x:Name` (meno prvku) a to, že premenná `clicks` je mimo metódy, aby sa hodnota zachovala medzi kliknutiami. |
| 4 | `Wpf04_TextBox` | TextBox (Text), MaxLength, IsReadOnly, viacriadkový TextBox, Focus() | Hodnotu z TextBoxu čítame vlastnosťou `Text`. Ukážte aj viacriadkové pole (`AcceptsReturn`, `TextWrapping`), pole len na čítanie a obmedzenie dĺžky (`MaxLength`). |
| 5 | `Wpf05_Image` | Image (Source, Stretch), zmena obrázka v kóde | Obrázky sú súčasťou projektu (priečinok `Images`, Build Action = Resource). `Stretch` určuje, ako sa obrázok prispôsobí rámčeku. Zmenu obrázka v kóde robíme novým `BitmapImage`. |
| 6 | `Wpf06_ImageButton` | Button s obsahom (Image + TextBlock), klikateľný Image (MouseLeftButtonUp) | Tlačidlo môže mať vo vnútri aj iné prvky. Image samotný nie je tlačidlo, ale vie reagovať na myš (udalosť `MouseLeftButtonUp`). Toto je „dobrovoľná“ časť zo základov WPF. |
| 7 | `Wpf07_StackPanel` | StackPanel (Vertical/Horizontal), Margin, Padding, HorizontalAlignment | StackPanel skladá prvky pod seba alebo vedľa seba. `Margin` je vonkajšia medzera, `Padding` vnútorná. Kontrastne ukážte na farebnom Borderi. |
| 8 | `Wpf08_Grid` | Grid (riadky a stĺpce), Grid.Row, Grid.Column, Grid.ColumnSpan, Auto a * | Grid je tabuľka. `Auto` = podľa obsahu, `*` = zvyšné miesto. Prvok umiestnime cez `Grid.Row` a `Grid.Column`, preklenúť viac stĺpcov vie `Grid.ColumnSpan`. |
| 9 | `Wpf09_PropertiesInCode` | zmena FontSize, Foreground, Visibility, IsEnabled, Width z kódu | Všetko, čo nastavíme vo XAML (vlastnosti), vieme meniť aj z C# kódu. Prvok musí mať `x:Name`. Použité sú operátory z lekcie (×, ÷, +). |
| 10 | `Wpf10_Events` | iné udalosti než Click, parameter sender | Prvky majú veľa udalostí. Ukážte, že metódu pre udalosť vie vytvoriť Visual Studio (Properties → Events, dvojklik). `sender` je prvok, ktorý udalosť vyvolal. |
| 11 | `Wpf11_Counter` | viac tlačidiel, spoločná metóda, premenná v triede | Prvá „hotová“ aplikácia. Opakovanie: premenná mimo metód, metóda `ShowCount()` zdieľaná všetkými tlačidlami (využitie metód z AppsLab-018). |
| 12 | `Wpf12_Calculator` | TextBox → číslo (double.Parse), operátory, metódy s parametrom | Kombinácia TextBoxu, tlačidiel a operátorov z lekcie 009. Ak žiak zadá text namiesto čísla alebo nechá pole prázdne, aplikácia spadne s `FormatException` – dobrá príležitosť na Opravovanie chýb a ladenie. |
| 13 | `Wpf13_Celsius` | vzorce, dva smery prevodu, Grid | Použitie vzorcov a priority operátorov. Dobrý príklad na kontrolu výsledku: 100 °C = 212 °F, 0 °C = 32 °F, −40 sa rovná v oboch. |
| 14 | `Wpf14_BusinessCard` | viac TextBoxov, metóda s parametrami a návratovou hodnotou, \n v texte | Metóda `BuildCard` skladá text z viacerých parametrov a vracia ho (return). Opakovanie lekcie Metódy. `\n` v texte je nový riadok. |
| 15 | `Wpf15_Cashier` | všetko dokopy: Button + Image, Label, TextBlock, metóda AddItem, decimal | Finálny projekt zo základov WPF (podľa osnovy KASA: 5 tlačidiel s položkami a bloček). Obrázky na tlačidlách sú dobrovoľná časť. Všetky tlačidlá volajú jednu metódu `AddItem`. |
| 16 | `Wpf16_CashierStarter` | samostatná práca: doplniť dve tlačidlá a tlačidlo Nový zákazník | Kostra kasy pre žiakov. Metóda `AddItem` a tlačidlá Rožok, Kečup a Párok sú hotové. Treba doplniť Cola, Čaj a Nový zákazník (komentáre `TODO`). |

## Odporúčané rozloženie hodiny (orientačne 90 min)
- **Úvod (1–3):** okno, XAML vs. C#, Label, Button a Click – 20 minút.
- **Zadávanie a obrázky (4–6):** TextBox, Image, obrázok ako tlačidlo (dobrovoľné) – 20 minút.
- **Rozloženie a vlastnosti (7–10):** StackPanel, Grid, vlastnosti v kóde, udalosti – 15 minút.
- **Mini aplikácie (11–14):** počítadlo, kalkulačka, prevodník, vizitka – podľa času.
- **Projekt Kasa (15, 16):** 15 je hotová kasa s obrázkami (ukážka), 16 je kostra s `TODO` pre žiakov.

## Nápady na samostatnú prácu
V každom `MainWindow.xaml` je v komentári 4 odporúčané zmeny. Najlepšie ich zadávať ako „vyskúšaj a povedz, čo sa stalo“.

## Čo treba vedieť
- **Kalkulačka (12), prevodník (13) a vizitka (14)** spadnú s `FormatException`, ak žiak zadá text namiesto čísla alebo pole nechá prázdne. Je to zámer: dá sa použiť v lekcii Opravovanie chýb a Debuggovanie (projekt `Ladenie` pre WPF zatiaľ nemá samostatné cvičenie).
- Desatinné čísla sa píšu podľa nastavení Windows (na slovenskom Windows s čiarkou: `2,5`).
- Ak sa obrázok nezobrazí a aplikácia spadne pri štarte, skontroluj názov súboru v `Source` a či je v projekte (Build Action = Resource).
- Premenné (`clicks`, `count`, `total`) sú v triede nad metódami, aby sa ich hodnota zachovala medzi kliknutiami. Triedy žiaci ešte nepoznajú – vysvetlite ako „obal od Visual Studia, my píšeme len premenné a metódy vnútri“.
