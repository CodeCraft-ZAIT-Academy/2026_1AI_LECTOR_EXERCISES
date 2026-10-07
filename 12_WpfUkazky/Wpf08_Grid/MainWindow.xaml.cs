using System.Windows;

namespace Wpf08_Grid;

// Rozloženie: Grid
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnSend_Click(object sender, RoutedEventArgs e)
    {
        lblResult.Content = "Registrovaný: " + txtName.Text + " (" + txtEmail.Text + ")";
    }
}
