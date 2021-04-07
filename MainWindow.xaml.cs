using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IValueConvertor_INotifyPropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }





    //So in short IValueConverter acts like a middlemen and translates a value between the source and the destination for us... like we translated our string to bool 
    public class TextToBoolConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //here value is our value which we get write in textbox terms of yes or No...
            if (value is string)
                if (!string.IsNullOrEmpty(value.ToString()))
                    return true;
                else
                    return false;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //and if checkbox is checked or uncheck we got to update our textbox by writing Yes or No
            //here value is our value which we get from checkbox when checked or unchecked in terms of True & False...
            if (value is bool)
                if ((bool)value == true)
                return "Yes";
            else
                return "No";
            return "No";
        }
    }
}