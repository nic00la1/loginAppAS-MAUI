using System.Globalization;

namespace loginAppAS.Handlers
{
    class ThemeImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Sprawdź aktualny motyw aplikacji
            var appTheme = Application.Current.RequestedTheme;

            // Zwróć odpowiednie źródło obrazu w zależności od motywu
            if (appTheme == AppTheme.Light)
            {
                return ImageSource.FromFile(GetLightThemeImage(value));
            }
            else
            {
                return ImageSource.FromFile(GetDarkThemeImage(value));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private string GetLightThemeImage(object value)
        {
            // Logika do pobrania odpowiedniego obrazu dla motywu jasnego
            // Możesz użyć wartości value do określenia, który obraz jest potrzebny
            // Na przykład, jeśli value to "user", możesz zwrócić "user_light.png"
            // Jeśli value to "password", możesz zwrócić "password_light.png"
            // Dodaj odpowiednie warunki dla innych obrazów

            return "user_light.png"; // Zwróć ścieżkę do obrazu dla motywu jasnego
        }

        private string GetDarkThemeImage(object value)
        {
            // Logika do pobrania odpowiedniego obrazu dla motywu ciemnego
            // Możesz użyć wartości value do określenia, który obraz jest potrzebny
            // Na przykład, jeśli value to "user", możesz zwrócić "user_dark.png"
            // Jeśli value to "password", możesz zwrócić "password_dark.png"
            // Dodaj odpowiednie warunki dla innych obrazów

            return "user_dark.png"; // Zwróć ścieżkę do obrazu dla motywu ciemnego
        }
    }
}