namespace loginAppAS
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped_ForLogin(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("//Login");
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string email = emailEntry.Text;
            string password = passwordEntry.Text;
            string confirmPassword = confirmPasswordEntry.Text;

            if (string.IsNullOrEmpty(name))
            {
                errorLabel.Text = "Wpisz imiê";
                return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains('@'))
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
            bool registrationSuccess = await Register(email, password);

            if (registrationSuccess)
            {
                // Po udanej rejestracji, przejdŸ do strony logowania
                await Shell.Current.GoToAsync("//Login");
            }
            else
            {
                errorLabel.Text = "B³¹d rejestracji. Spróbuj ponownie.";
            }
        }

        private async Task<bool> Register(string email, string password)
        {
            // Tutaj powinna byæ logika wys³ania ¿¹dania do serwera
            // w celu zarejestrowania u¿ytkownika. To jest miejsce,
            // gdzie normalnie odbywa³aby siê komunikacja z backendem.

            // Oto przyk³ad symulacji, u¿ywaj¹c Task.Delay
            await Task.Delay(2000);

            // Symulacja sukcesu rejestracji
            bool success = SaveCredentialsToFile(email, password);

            return success;
        }

        private bool SaveCredentialsToFile(string email, string password)
        {
            try
            {
                // SprawdŸ, czy plik ju¿ istnieje
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "loginData.txt");

                if (!File.Exists(filePath))
                {
                    // Jeœli plik nie istnieje, utwórz nowy
                    File.Create(filePath).Dispose();
                }

                // Zapisz dane do pliku
                File.AppendAllText(filePath, $"{email},{password}{Environment.NewLine}");

                return true;
            }
            catch (Exception)
            {
                // Obs³u¿ ewentualne b³êdy
                return false;
            }
        }
    }
}