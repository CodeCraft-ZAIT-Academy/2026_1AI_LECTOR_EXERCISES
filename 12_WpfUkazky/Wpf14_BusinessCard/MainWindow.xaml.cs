using System.Windows;

namespace Wpf14_BusinessCard;

// Mini aplikácia: vizitka
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Metóda poskladá text vizitky a vráti ho
    string BuildCard(string firstName, string lastName, int age, string city)
    {
        return firstName + " " + lastName + "\n" + "Vek: " + age + "\n" + "Mesto: " + city;
    }

    private void BtnCreate_Click(object sender, RoutedEventArgs e)
    {
        int age = int.Parse(txtAge.Text);
        txtCard.Text = BuildCard(txtFirstName.Text, txtLastName.Text, age, txtCity.Text);
    }
}
