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
                errorLabel.Text = "Wpisz has³o";
                return;
            }

            if (password != confirmPassword)
            {
                errorLabel.Text = "Has³a siê ró¿ni¹";
                return;
            }

            // Implementacja rejestracji
            Register(email, password);

            // Po udanej rejestracji, przejdŸ do sekcji logowania
            NavigateToLoginPage();
        }

        private void Register(string email, string password)
        {
            // Tutaj powinna byæ logika wys³ania ¿¹dania do serwera
            // w celu zarejestrowania u¿ytkownika. To jest miejsce,
            // gdzie normalnie odbywa³aby siê komunikacja z backendem.

            // Jeœli rejestrowanie zakoñczy siê sukcesem, mo¿esz
            // wyœwietliæ odpowiednie powiadomienie.
            DisplayAlert("Witamy na pok³adzie!", "Utworzy³eœ konto w naszym serwisie", "Ok");
        }

        private void NavigateToLoginPage()
        {
            // Przejœcie do sekcji logowania
            Navigation.PushAsync(new LoginPage());
        }
    }
}