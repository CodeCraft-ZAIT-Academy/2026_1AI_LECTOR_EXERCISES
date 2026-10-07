using System.Windows;

namespace Wpf03_Button;

// Tlačidlo a udalosť Click
public partial class MainWindow : Window
{
    int clicks = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnClick_Click(object sender, RoutedEventArgs e)
    {
        clicks = clicks + 1;
        lblMessage.Content = "Počet kliknutí: " + clicks;
    }

    private void BtnReset_Click(object sender, RoutedEventArgs e)
    {
        clicks = 0;
        lblMessage.Content = "Zatiaľ si nekliol.";
    }
}
