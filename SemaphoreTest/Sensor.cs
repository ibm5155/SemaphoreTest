using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemaphoreTest
{
    public class Sensor
    {
        int MyClock = 0;
        int ClockAddTime;
        int traphicAmount = 0;

        public Sensor(int IncreaseTimePerMinute)
        {
            ClockAddTime = IncreaseTimePerMinute;
        }

        public async void RunTimerDelay()
        {
            while (true)
            {
                await Task.Delay(60000);
                MyClock += ClockAddTime;
            }
        }

        public async void RunTimer()
        {
            while (true)
            {
                await Task.Delay(1000);
                MyClock ++;
            }
        }

        public async void RunTraphicSimulator()
        {
            Random r = new Random();
            while (true)
            {
                await Task.Delay(1);
                if(MyClock % 360 == 0)
                {
                    traphicAmount = r.Next(1, 100);
                }
            }
        }

    }
}
