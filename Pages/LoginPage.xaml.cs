namespace loginAppAS
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
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
                errorLabel.Text = "Wpisz has³o";
                return;
            }

            // Implementacja logowania
            Login(email, password);
        }

        private void Login(string email, string password)
        {
            // Tutaj powinna byæ logika wys³ania ¿¹dania do serwera
            // w celu autoryzacji u¿ytkownika. To jest miejsce,
            // gdzie normalnie odbywa³aby siê komunikacja z backendem.

            // Jeœli logowanie zakoñczy siê sukcesem, mo¿esz
            // wyœwietliæ odpowiednie powiadomienie i przenieœæ
            // u¿ytkownika do strony powitalnej.
            DisplayAlert("Logowanie udane", "", "Ok");
            Navigation.PushAsync(new WelcomePage());
        }
    }
}