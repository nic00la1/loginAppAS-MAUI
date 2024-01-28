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
        // Tutaj mo�esz ustawi� etykiety (Labels) na swojej stronie, aby wy�wietli� dane u�ytkownika.
        // Przyk�ad ustawienia etykiety z imieniem u�ytkownika:
        nameLabel.Text = $"Imi�: {userData.Name}";

        // Przyk�ad ustawienia etykiety z adresem e-mail u�ytkownika:
        emailLabel.Text = $"Email: {userData.Email}";
    }
}