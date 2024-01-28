using System.Globalization;

namespace loginAppAS.Handlers
{
    public class ThemeImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                // Obsługa przypadku, gdy value jest null
                return ImageSource.FromFile("error.png"); // Podaj ścieżkę do domyślnego obrazu
            }

            // Sprawdź aktualny motyw aplikacji
            var appTheme = Application.Current.RequestedTheme;

            // Zwróć odpowiednie źródło obrazu w zależności od motywu
            if (appTheme == AppTheme.Light)
            {
                return ImageSource.FromFile(GetLightThemeImage(value.ToString()));
            }
            else
            {
                return ImageSource.FromFile(GetDarkThemeImage(value.ToString()));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private string GetLightThemeImage(string value)
        {
            // Logika do pobrania odpowiedniego obrazu dla motywu jasnego
            // Dodaj odpowiednie warunki dla innych obrazów

            return $"{value}_light.png"; // Zwróć ścieżkę do obrazu dla motywu jasnego
        }

        private string GetDarkThemeImage(string value)
        {
            // Logika do pobrania odpowiedniego obrazu dla motywu ciemnego
            // Dodaj odpowiednie warunki dla innych obrazów

            return $"{value}_dark.png"; // Zwróć ścieżkę do obrazu dla motywu ciemnego
        }
    }
}
