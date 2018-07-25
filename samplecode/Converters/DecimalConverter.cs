using System;
using System.Globalization;
using Xamarin.Forms;

namespace samplecode.Converters
{
    public class DecimalConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            decimal thedecimal = (decimal)value;
            return thedecimal.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value as string;

            if (string.IsNullOrEmpty(strValue))
                strValue = "";

            decimal resultdecimal;
            if (decimal.TryParse(strValue, out resultdecimal))
            {
                return resultdecimal;
            }
            return null;
        }

    }
}

