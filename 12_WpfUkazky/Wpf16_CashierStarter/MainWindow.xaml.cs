using System.Windows;

namespace Wpf16_CashierStarter;

// Úloha: dokonči kasu
public partial class MainWindow : Window
{
    decimal total = 0m;
    int itemCount = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    // Jedna spoločná metóda pre všetky tlačidlá s tovarom
    void AddItem(string name, decimal price)
    {
        total = total + price;
        itemCount++;
        txtReceipt.Text += name.PadRight(14) + price.ToString("0.00") + " €\n";
        lblTotal.Content = "Spolu: " + total.ToString("0.00") + " €  (" + itemCount + " ks)";
    }

    private void BtnRoll_Click(object sender, RoutedEventArgs e)
    {
        AddItem("Rožok", 0.30m);
    }

    private void BtnKetchup_Click(object sender, RoutedEventArgs e)
    {
        AddItem("Kečup", 0.80m);
    }

    private void BtnHotdog_Click(object sender, RoutedEventArgs e)
    {
        AddItem("Párok", 1.20m);
    }

    private void BtnCola_Click(object sender, RoutedEventArgs e)
    {
        // TODO: zavolaj AddItem pre Colu (cena 1.50m)
    }

    private void BtnTea_Click(object sender, RoutedEventArgs e)
    {
        // TODO: zavolaj AddItem pre Čaj (cena 1.00m)
    }

    private void BtnNew_Click(object sender, RoutedEventArgs e)
    {
        // TODO: vynuluj total a itemCount, vymaž bloček (txtReceipt.Text)
        // a nastav lblTotal.Content späť na "Spolu: 0,00 €"
    }
}
