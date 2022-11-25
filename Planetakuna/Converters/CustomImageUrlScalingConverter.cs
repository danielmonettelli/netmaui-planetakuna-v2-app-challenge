using System.Globalization;

namespace Planetakuna.Converters
{
    public class CustomImageUrlScalingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "https://raw.githubusercontent.com/danielmonettelli/MyResources/main/Planetakuna_Resources/" + value + ".png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
