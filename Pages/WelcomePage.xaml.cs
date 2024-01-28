using loginAppAS.Models;
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
    }

    private async void Wyloguj(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}