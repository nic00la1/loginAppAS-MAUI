using loginAppAS.Models;
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

            if (string.IsNullOrEmpty(email) || !email.Contains('@'))
            {
                errorLabel.Text = "Podaj poprawny adres e-mail";
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                errorLabel.Text = "Wpisz has³o";
                return;
            }

            // Zadeklaruj i zainicjuj userData w ramach metody
            var userData = ReadUserDataFromFile(email, password);

            // Implementacja logowania
            bool loginSuccess = await Login(email, password);

            if (loginSuccess)
            {
                // Po udanym zalogowaniu, mo¿esz dodatkowo przekierowaæ u¿ytkownika
                // do strony powitalnej, itp.
                _ = Navigation.PushAsync(new WelcomePage(userData));
            }
            else
            {
                errorLabel.Text = "Nie ma takiego konta!";
            }
        }

        private async Task<bool> Login(string email, string password)
        {
            // Tutaj powinna byæ logika wys³ania ¿¹dania do serwera
            // w celu autoryzacji u¿ytkownika. To jest miejsce,
            // gdzie normalnie odbywa³aby siê komunikacja z backendem.

            // Oto przyk³ad symulacji, u¿ywaj¹c Task.Delay
            await Task.Delay(2000);

            // Symulacja odczytu danych z pliku loginData.txt
            var userData = ReadUserDataFromFile(email, password);

            // Sprawdzenie, czy u¿ytkownik istnieje i czy has³o jest poprawne
            if (userData != null && userData.Password == password)
            {
                return true;
            }

            return false;
        }

        private UserData ReadUserDataFromFile(string email, string password)
        {
            try
            {
                // Scie¿ka do pliku
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "loginData.txt");

                // Odczyt danych z pliku
                var lines = File.ReadAllLines(filePath);

                // Szukanie u¿ytkownika o zadanym adresie e-mail
                var userData = lines
                    .Select(line => line.Split(','))
                    .Where(data => data.Length == 2 && data[0] == email)
                    .Select(data => new UserData
                    {
                        Email = data[0],
                        Password = data[1]
                    })
                    .FirstOrDefault();

                return userData;
            }
            catch (Exception)
            {
                // Obs³u¿ ewentualne b³êdy
                return null;
            }
        }
    }
}