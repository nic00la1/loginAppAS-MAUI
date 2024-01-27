namespace loginAppAS
{
    public partial class RegisterPage : ContentPage
    {

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;
            string confirmPassword = confirmPasswordEntry.Text;

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                errorLabel.Text = "Podaj poprawny adres e-mail";
                return;
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                errorLabel.Text = "Wpisz has�o";
                return;
            }

            if (password != confirmPassword)
            {
                errorLabel.Text = "Has�a si� r�ni�";
                return;
            }

            // Implementacja rejestracji
            Register(email, password);

            // Po udanej rejestracji, przejd� do sekcji logowania
            NavigateToLoginPage();
        }

        private void Register(string email, string password)
        {
            // Tutaj powinna by� logika wys�ania ��dania do serwera
            // w celu zarejestrowania u�ytkownika. To jest miejsce,
            // gdzie normalnie odbywa�aby si� komunikacja z backendem.

            // Je�li rejestrowanie zako�czy si� sukcesem, mo�esz
            // wy�wietli� odpowiednie powiadomienie.
            DisplayAlert("Witamy na pok�adzie!", "Utworzy�e� konto w naszym serwisie", "Ok");
        }

        private void NavigateToLoginPage()
        {
            // Przej�cie do sekcji logowania
            Navigation.PushAsync(new LoginPage());
        }
    }
}