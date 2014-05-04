using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace TuringMachineWPF.Converters
{
    public class BolleanToSolidBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var b = (bool?)value;
            return b.HasValue && b.Value ? new SolidColorBrush(Colors.LawnGreen) : new SolidColorBrush(Color.FromRgb(255, 61, 61));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
