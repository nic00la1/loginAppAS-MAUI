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
                return ImageSource.FromFile("user.png");
            }
            else
            {
                return ImageSource.FromFile("password.png");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}