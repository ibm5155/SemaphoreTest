using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemaphoreTest
{
    public enum tempoestado
    {
        verde,
        vermelho
    }
    public class MySemaphore
    {
        int TempoAberto = 0;
        int TempoFechado = 0;

        int Timestamp = 0;
        tempoestado _estadoAtual = tempoestado.vermelho;

        int SetTimeRule(double x)
        {
            //return mode
            if(x <= 0.2)
            {
                TempoAberto = 20;
                TempoFechado = 100;
                return 1;
            }
            else if(x  <= 0.4)
            {
                TempoAberto = 40;
                TempoFechado = 80;
                return 2;
            }
            else if(x <= 0.6)
            {
                TempoAberto = 60;
                TempoFechado = 60;
                return 3;
            }
            else if (x <= 0.8)
            {
                TempoAberto = 80;
                TempoFechado = 40;
                return 4;
            }

            TempoAberto = 100;
            TempoFechado = 20;
            return 5;
        }
    }


}
