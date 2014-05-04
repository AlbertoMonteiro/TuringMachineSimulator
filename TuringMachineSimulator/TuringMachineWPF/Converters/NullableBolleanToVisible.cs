using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TuringMachineWPF.Converters
{
    public class BooleanToVisible : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool?) value).HasValue ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibility = (Visibility) value;
            switch (visibility)
            {
                case Visibility.Visible:
                    return true;
                case Visibility.Hidden:
                    return false;
                case Visibility.Collapsed:
                    return null;
                default:
                    return null;
            }
        }
    }
}
