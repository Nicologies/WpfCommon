﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Nicologies.WpfCommon.Converter
{
    [ValueConversion(typeof(Visibility), typeof(bool))]
    public class IsVisableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Visibility) value == Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
