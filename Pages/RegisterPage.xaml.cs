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
    }
}