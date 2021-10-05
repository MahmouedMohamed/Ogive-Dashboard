using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dashboard.MVVM.Models
{
    class Achievement : INotifyPropertyChanged
    {
        private int number1;
        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
                OnPropertyChanged("Number1");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
