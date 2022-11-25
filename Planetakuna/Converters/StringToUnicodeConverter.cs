using System.Globalization;
using System.Text.RegularExpressions;

namespace Planetakuna.Converters
{
    public class StringToUnicodeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value.ToString().Replace("+", @"\");

            string unicode = Regex.Unescape(str);

            return unicode;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
