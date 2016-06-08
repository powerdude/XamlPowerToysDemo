namespace XamlPowerToysDemo.Converters {
    using System;
    using System.Globalization;
    using Xamarin.Forms;
    using XamlPowerToysDemo.Model.Books;

    public class FormatEnumConverter : IValueConverter {

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            return ((Format)value).ToString();
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            // the null check is required.  when the data template selector is being changed dynamically,
            //   this method gets called with the value set to null.
            return value == null ? null : Enum.Parse(typeof(Format), value.ToString());
        }

    }
}
