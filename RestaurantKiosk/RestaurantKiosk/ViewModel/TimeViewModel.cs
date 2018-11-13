using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace RestaurantKiosk.ViewModel
{
    public class TimeViewModel
    {
        public Time Time { get; }
        private DispatcherTimer timer = new DispatcherTimer();

        public TimeViewModel()
        {
            InitMainTimer();
            Time = new Time();
        }

        private void InitMainTimer()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time.CurTime = DateTime.Now.ToString();
        }
    }
}
