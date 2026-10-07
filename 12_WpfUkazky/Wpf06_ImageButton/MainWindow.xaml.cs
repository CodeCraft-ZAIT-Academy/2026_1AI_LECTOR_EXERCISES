using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Wpf06_ImageButton;

// Obrázok ako tlačidlo
public partial class MainWindow : Window
{
    int apples = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    // Obe tlačidlá používajú rovnakú metódu
    private void BtnAddApple_Click(object sender, RoutedEventArgs e)
    {
        apples = apples + 1;
        lblApples.Content = "Jabĺk v košíku: " + apples;
    }

    private void ImgSmiley_Click(object sender, MouseButtonEventArgs e)
    {
        imgSmiley.Source = new BitmapImage(new Uri("pack://application:,,,/Images/sad.png"));
        lblSmiley.Content = "Au! Zabolelo to.";
    }
}
