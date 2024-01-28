using loginAppAS.Handlers;
using loginAppAS.Models;
using System.Globalization;
namespace loginAppAS;

public partial class WelcomePage : ContentPage
{
    private UserData userData;

    public WelcomePage(UserData userData)
    {
        InitializeComponent();
        this.userData = userData;

        // Wywo�aj metod� DisplayUserData() po zainicjowaniu obiektu userData
        DisplayUserData();
    }

    private void DisplayUserData()
    {
        // Sprawd�, czy userData nie jest null przed dost�pem do jego w�a�ciwo�ci
        if (userData != null)
        {
            emailLabel.Text = $"Email: {userData.Email}";

            // Ustaw �r�d�o obrazu za pomoc� konwertera
            userImage.Source = (ImageSource)new ThemeImageConverter().Convert(null, null, null, CultureInfo.CurrentCulture);
        }
    }

    private async void Wyloguj(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}