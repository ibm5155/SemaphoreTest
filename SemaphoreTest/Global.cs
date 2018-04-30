using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemaphoreTest
{
    public static class Global
    {
        public static MySemaphore S =  new MySemaphore();
        public static Sensor V = new Sensor(6, Sentido.Vertical);
        public static Sensor H = new Sensor(-3, Sentido.Horizontal);
        public static TimeServer T = new TimeServer();
        public static int k = 6;
        public static Random random = new Random();
    }
}
