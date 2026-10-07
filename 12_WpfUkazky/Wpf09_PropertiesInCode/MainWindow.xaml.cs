using System.Windows;
using System.Windows.Media;

namespace Wpf09_PropertiesInCode;

// Vlastnosti prvkov v C# kóde
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnBigger_Click(object sender, RoutedEventArgs e)
    {
        lblDemo.FontSize = lblDemo.FontSize * 1.25;
    }

    private void BtnSmaller_Click(object sender, RoutedEventArgs e)
    {
        lblDemo.FontSize = lblDemo.FontSize / 1.25;
    }

    private void BtnRed_Click(object sender, RoutedEventArgs e)
    {
        lblDemo.Foreground = Brushes.Red;
    }

    private void BtnBlue_Click(object sender, RoutedEventArgs e)
    {
        lblDemo.Foreground = Brushes.Blue;
    }

    private void BtnHide_Click(object sender, RoutedEventArgs e)
    {
        lblDemo.Visibility = Visibility.Hidden;
    }

    private void BtnShow_Click(object sender, RoutedEventArgs e)
    {
        lblDemo.Visibility = Visibility.Visible;
    }

    private void BtnWider_Click(object sender, RoutedEventArgs e)
    {
        txtDemo.Width = txtDemo.Width + 30;
    }

    private void BtnDisable_Click(object sender, RoutedEventArgs e)
    {
        btnDisable.IsEnabled = false;
    }

    private void BtnEnable_Click(object sender, RoutedEventArgs e)
    {
        btnDisable.IsEnabled = true;
    }
}
