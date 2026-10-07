using System.Windows;
using System.Windows.Controls;

namespace Wpf12_Calculator;

// Mini aplikácia: kalkulačka
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Pomocná metóda: prečíta číslo z TextBoxu
    double ReadNumber(TextBox box)
    {
        return double.Parse(box.Text);
    }

    void ShowResult(double result)
    {
        lblResult.Content = "Výsledok: " + result;
    }

    private void BtnAdd_Click(object sender, RoutedEventArgs e)
    {
        double a = ReadNumber(txtA);
        double b = ReadNumber(txtB);
        ShowResult(a + b);
    }

    private void BtnSubtract_Click(object sender, RoutedEventArgs e)
    {
        double a = ReadNumber(txtA);
        double b = ReadNumber(txtB);
        ShowResult(a - b);
    }

    private void BtnMultiply_Click(object sender, RoutedEventArgs e)
    {
        double a = ReadNumber(txtA);
        double b = ReadNumber(txtB);
        ShowResult(a * b);
    }

    private void BtnDivide_Click(object sender, RoutedEventArgs e)
    {
        double a = ReadNumber(txtA);
        double b = ReadNumber(txtB);
        ShowResult(a / b);
    }
}
