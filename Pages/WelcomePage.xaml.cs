using loginAppAS.Models;
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

            var appTheme = Application.Current.RequestedTheme;

            // Ustaw �r�d�o obrazu w zale�no�ci od motywu
            string imageName = appTheme == AppTheme.Light ? "user_light.png" : "user_dark.png";
            userImage.Source = ImageSource.FromFile(imageName);

        }
    }

    private async void Wyloguj(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}