using System.Windows;
using System.Windows.Media.Imaging;

namespace Wpf05_Image;

// Image – obrázky
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Jedna metóda na zmenu obrázka – tlačidlá ju len volajú
    void ShowImage(string fileName)
    {
        imgMood.Source = new BitmapImage(new Uri("pack://application:,,,/Images/" + fileName));
    }

    private void BtnSmiley_Click(object sender, RoutedEventArgs e)
    {
        ShowImage("smiley.png");
    }

    private void BtnSad_Click(object sender, RoutedEventArgs e)
    {
        ShowImage("sad.png");
    }

    private void BtnSun_Click(object sender, RoutedEventArgs e)
    {
        ShowImage("sun.png");
    }

    private void BtnMoon_Click(object sender, RoutedEventArgs e)
    {
        ShowImage("moon.png");
    }
}
