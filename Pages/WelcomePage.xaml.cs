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
        // Tutaj mo¿esz ustawiæ etykiety (Labels) na swojej stronie, aby wyœwietliæ dane u¿ytkownika.
        // Przyk³ad ustawienia etykiety z imieniem u¿ytkownika:
        nameLabel.Text = $"Imiê: {userData.Name}";

        // Przyk³ad ustawienia etykiety z adresem e-mail u¿ytkownika:
        emailLabel.Text = $"Email: {userData.Email}";
    }
}