using System.Windows;
using System.Windows.Controls;

namespace Wpf10_Events;

// Udalosti: Click, TextChanged, MouseEnter, Loaded, sender
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Udalosť Loaded: okno sa práve načítalo
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        lblStatus.Content = "Okno sa načítalo (udalosť Loaded).";
    }

    // Udalosť TextChanged: vyvolá sa po každej zmene textu
    private void TxtInput_TextChanged(object sender, TextChangedEventArgs e)
    {
        lblLength.Content = "Počet znakov: " + txtInput.Text.Length;
    }

    private void BtnHover_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        btnHover.Content = "Mám ťa!";
    }

    private void BtnHover_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        btnHover.Content = "Nabehni na mňa myšou";
    }

    // Jedna metóda pre tri tlačidlá: sender je to, na ktoré sa kliklo
    private void AnyButton_Click(object sender, RoutedEventArgs e)
    {
        Button clicked = (Button)sender;
        lblSender.Content = "Klikol si na: " + clicked.Content;
    }
}
