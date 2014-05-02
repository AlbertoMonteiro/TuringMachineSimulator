using System;
using System.Globalization;
using System.Windows.Data;

namespace TuringMachineWPF
{
    public class StringToStringArray : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Join(",", (string[])value ?? new[] { "" });
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var s = (string) value;
            return !string.IsNullOrWhiteSpace(s) ? s.Split(',') : null;
        }
    }
}