using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemaphoreTest
{
    public class TimeServer
    {
        public int MyClock = 0;//seconds

        public async void Run()
        {
            while (true)
            {
                await Task.Delay(1000);
                MyClock++;
            }
        }

        public async Task<int> GetTime()
        {
            await Task.Delay(1500);
            return MyClock;
        }
    }
}
