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

            // ... (jak w poprzednim kodzie, ale skoncentrowane na logowaniu)

            Login(email, password);
        }

        private void Login(string email, string password)
        {
            // Implementacja logowania
            // ...

            DisplayAlert("Login udany", "", "Ok");
            Navigation.PushAsync(new WelcomePage());
        }
    }
}