using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace CRUD_personas_UWP_UI.Converters
{
    public class ConverterFecha : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, String language)
        {
            DateTime fechaLarga = (DateTime)value;
            String fecha = fechaLarga.ToShortDateString();
            return fecha;
        }
        public object ConvertBack(object value, Type targetType, object parameter, String language)
        {
            
            DateTime fechaLarga = DateTime.Parse(value.ToString());
            return fechaLarga;
        }
    }
}
