using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace TuringMachineWPF.Converters
{
    public class StringToMachineStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var machineStates = (IList<MachineState>)value;
            return string.Join(",", machineStates.Select(s => s.Name));

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var states = (string)value;
            return states.Split(',').Select(s => new MachineState { Name = s }).ToList();
        }
    }
}
