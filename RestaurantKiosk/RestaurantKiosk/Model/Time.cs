using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Model
{
    public class Time : INotifyPropertyChanged
    {
        private string curTime;
        public string CurTime
        {
            get
            {
                return curTime;
            }
            set
            {
                curTime = value;
                NotifyPropertyChanged(nameof(CurTime));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
