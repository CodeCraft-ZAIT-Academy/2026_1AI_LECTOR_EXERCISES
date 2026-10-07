using System.Windows;

namespace Wpf15_Cashier;

// Mini projekt: Kasa s obrázkami
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
        AddItem("Cola", 1.50m);
    }

    private void BtnTea_Click(object sender, RoutedEventArgs e)
    {
        AddItem("Čaj", 1.00m);
    }

    private void BtnNew_Click(object sender, RoutedEventArgs e)
    {
        total = 0m;
        itemCount = 0;
        txtReceipt.Text = "";
        lblTotal.Content = "Spolu: 0,00 €";
    }
}
