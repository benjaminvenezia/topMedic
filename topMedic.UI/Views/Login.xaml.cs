using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;


namespace topMedic.UI.Views;

public partial class Login : Page
{
    public Login()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        string email = EmailTb.Text;
        string password = PasswordPb.Password;

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        MessageBox.Show($"Email: {email}\nMot de passe: {password}", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        NavigationService.Navigate(new Subscribe());
    }
}
