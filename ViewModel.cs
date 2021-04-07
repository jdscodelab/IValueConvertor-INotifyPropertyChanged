using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValueConvertor_INotifyPropertyChanged
{
    class ViewModel: INotifyPropertyChanged
    {
        int value1;
        public int Value1
        {
            get
            {
                return value1;
            }
            set
            {
                value1 = value;
                //Since we have to update the value of 3rd Textbox on change of value 1 & value 2
                RaisePropertyChanged("Sum");
            }
        }

        int value2;
        public int Value2
        {
            get
            {
                return value2;
            }
            set
            {
                value2 = value;
                RaisePropertyChanged("Sum");
            }
        }

        int sum;
        public int Sum
        {
            get
            {
                return value1 + value2;
            }
            set
            {
                sum = value;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}