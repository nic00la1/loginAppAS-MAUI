﻿namespace loginAppAS
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;
            string confirmPassword = confirmPasswordEntry.Text;

            if (string.IsNullOrEmpty(email))
            {
                // Wyświetl komunikat o konieczności wpisania adresu e-mail
                errorLabel.Text = "Wpisz adres e-mail";
                return;
            }

            if (!email.Contains("@"))
            {
                // Wyświetl komunikat o błędzie dla nieprawidłowego adresu e-mail
                errorLabel.Text = "Nieprawidłowy adres e-mail";
                return;
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                // Wyświetl komunikat o konieczności wpisania hasła
                errorLabel.Text = "Wpisz hasło";
                return;
            }

            if (password != confirmPassword)
            {
                // Wyświetl komunikat o błędzie dla nieprawidłowego hasła
                errorLabel.Text = "Hasła się różnią";
                return;
            }

            // Continue with login logic
            // ...

            // Wyświetl komunikat powitalny
            welcomeLabel.Text = $"Witaj {email}";

            // Wyczyść label z błędem "Wpisz hasło"
            errorLabel.Text = "";
        }
    }

}