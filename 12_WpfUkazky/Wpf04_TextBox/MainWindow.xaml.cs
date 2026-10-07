using System.Windows;

namespace Wpf04_TextBox;

// TextBox – zadávanie textu
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnGreet_Click(object sender, RoutedEventArgs e)
    {
        string name = txtName.Text;
        lblGreeting.Content = "Ahoj, " + name + "!";
    }

    private void BtnClear_Click(object sender, RoutedEventArgs e)
    {
        txtName.Text = "";
        lblGreeting.Content = "";
        txtName.Focus();
    }
}
