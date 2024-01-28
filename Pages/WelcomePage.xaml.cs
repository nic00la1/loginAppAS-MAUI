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

        // Wywo³aj metodê DisplayUserData() po zainicjowaniu obiektu userData
        DisplayUserData();
    }

    private void DisplayUserData()
    {
        // SprawdŸ, czy userData nie jest null przed dostêpem do jego w³aœciwoœci
        if (userData != null)
        {
            emailLabel.Text = $"Email: {userData.Email}";

            // Ustaw Ÿród³o obrazu za pomoc¹ konwertera
            userImage.Source = (ImageSource)new ThemeImageConverter().Convert(null, null, null, CultureInfo.CurrentCulture);
        }
    }

    private async void Wyloguj(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}