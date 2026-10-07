using System.Windows;

namespace Wpf11_Counter;

// Mini aplikácia: počítadlo
public partial class MainWindow : Window
{
    int count = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    void ShowCount()
    {
        lblCount.Content = count;
    }

    private void BtnMinus_Click(object sender, RoutedEventArgs e)
    {
        count = count - 1;
        ShowCount();
    }

    private void BtnPlus_Click(object sender, RoutedEventArgs e)
    {
        count = count + 1;
        ShowCount();
    }

    private void BtnPlusTen_Click(object sender, RoutedEventArgs e)
    {
        count = count + 10;
        ShowCount();
    }

    private void BtnReset_Click(object sender, RoutedEventArgs e)
    {
        count = 0;
        ShowCount();
    }
}
