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

            // ... (jak w poprzednim kodzie, ale skoncentrowane na rejestracji)

            Register(email, password);
        }

        private void Register(string email, string password)
        {
            // Implementacja rejestracji
            // ...

            DisplayAlert("Rejestracja udana", "", "Ok");
        }
    }
}