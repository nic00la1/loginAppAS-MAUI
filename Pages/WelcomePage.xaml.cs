using loginAppAS.Handlers;
using loginAppAS.Models;
using System.Globalization;
namespace loginAppAS;

public partial class WelcomePage : ContentPage
{
    UserData userData;

    public WelcomePage(UserData userData)
    {
        InitializeComponent();
        this.userData = userData;
        DisplayUserData();

    }

    private void DisplayUserData()
    {
        emailLabel.Text = $"Email: {userData.Email}";

        // Ustaw �r�d�o obrazu za pomoc� konwertera
        userImage.Source = (ImageSource)new ThemeImageConverter().Convert(null, null, null, CultureInfo.CurrentCulture);
    }

    private async void Wyloguj(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }

}