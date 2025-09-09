
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace topMedic.UI.Views;

public partial class Subscribe : Page
{
    public Subscribe()
    {
        InitializeComponent();
    }


    private void SubscribeButton_Click(object sender, RoutedEventArgs e)
    {

        string email = Email.Text;
        string firstname = Firstname.Text;
        string lastname = Lastname.Text;
        string password = Password.Password;
        string passwordVerification = PasswordVerification.Password;

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        MessageBox.Show($"Email: {email}\nMot de passe: {password}", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        NavigationService.Navigate(new Login());
    }
}
