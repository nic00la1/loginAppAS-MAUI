namespace loginAppAS
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

            // Pobierz aktualny motyw i ustaw odpowiednie obrazy
            UpdateThemeImages();
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

        private void UpdateThemeImages()
        {
            var appTheme = Application.Current.RequestedTheme;

            // Ustaw Ÿród³o obrazu w zale¿noœci od motywu
            string nameImageName = appTheme == AppTheme.Light ? "user_light.png" : "user_dark.png";
            nameImage.Source = ImageSource.FromFile(nameImageName);

            string emailImageName = appTheme == AppTheme.Light ? "email_light.png" : "email_dark.png";
            emailImage.Source = ImageSource.FromFile(emailImageName);

            string passwordImageName = appTheme == AppTheme.Light ? "password_light.png" : "password_dark.png";
            passwordImage.Source = ImageSource.FromFile(passwordImageName);

            string confirmPasswordImageName = appTheme == AppTheme.Light ? "password_light.png" : "password_dark.png";
            confirmPasswordImage.Source = ImageSource.FromFile(confirmPasswordImageName);
        }
    }
}