using loginAppAS.Models;
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

            var appTheme = Application.Current.RequestedTheme;

            // Ustaw Ÿród³o obrazu w zale¿noœci od motywu
            string imageName = appTheme == AppTheme.Light ? "user_light.png" : "user_dark.png";
            userImage.Source = ImageSource.FromFile(imageName);

        }
    }

    private async void Wyloguj(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}