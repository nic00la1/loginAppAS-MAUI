namespace loginAppAS
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped_For_Register(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Register");
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                errorLabel.Text = "Podaj poprawny adres e-mail";
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                errorLabel.Text = "Wpisz has�o";
                return;
            }

            // Implementacja logowania
            bool loginSuccess = await Login(email, password);

            if (loginSuccess)
            {
                // Po udanym zalogowaniu, mo�esz dodatkowo przekierowa� u�ytkownika
                // do strony powitalnej, itp.
                _ = Navigation.PushAsync(new WelcomePage());
            }
            else
            {
                errorLabel.Text = "B��d logowania. Spr�buj ponownie.";
            }
        }

        private async Task<bool> Login(string email, string password)
        {
            // Tutaj powinna by� logika wys�ania ��dania do serwera
            // w celu autoryzacji u�ytkownika. To jest miejsce,
            // gdzie normalnie odbywa�aby si� komunikacja z backendem.

            // Oto przyk�ad symulacji, u�ywaj�c Task.Delay
            await Task.Delay(2000);

            // Symulacja sukcesu logowania
            return true;
        }
    }
}