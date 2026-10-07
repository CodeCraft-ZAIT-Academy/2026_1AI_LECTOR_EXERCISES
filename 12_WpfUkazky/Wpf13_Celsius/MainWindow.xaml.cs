using System.Windows;

namespace Wpf13_Celsius;

// Mini aplikácia: prevodník teploty
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnToFahrenheit_Click(object sender, RoutedEventArgs e)
    {
        double celsius = double.Parse(txtCelsius.Text);
        double fahrenheit = celsius * 9 / 5 + 32;
        txtFahrenheit.Text = fahrenheit.ToString();
        lblInfo.Content = celsius + " °C = " + fahrenheit + " °F";
    }

    private void BtnToCelsius_Click(object sender, RoutedEventArgs e)
    {
        double fahrenheit = double.Parse(txtFahrenheit.Text);
        double celsius = (fahrenheit - 32) * 5 / 9;
        txtCelsius.Text = celsius.ToString();
        lblInfo.Content = fahrenheit + " °F = " + celsius + " °C";
    }
}
