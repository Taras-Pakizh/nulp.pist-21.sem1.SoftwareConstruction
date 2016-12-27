using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace PortableOrganizer.UI.Converter
{
    public class ImagePathConverter : IValueConverter
    {
        Dictionary<TaskStatus, BitmapImage> cache = new Dictionary<TaskStatus, BitmapImage>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (TaskStatus)value;
            if (!cache.ContainsKey(status))
            {
                var uri = new Uri(string.Format(@"../Images/{1}/{0}.png", status, parameter), UriKind.Relative);
                cache.Add(status, new BitmapImage(uri));
            }
            return cache[status];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
