using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemaphoreTest
{
    public enum Sentido
    {
        Horizontal,
        Vertical
    }

    public class Sensor
    {
        public int MyClock = 0;
        public int ClockAddTime;
        public int traphicAmount = 0;
        Sentido _sentido;
        private int _synctimeSec = 60;
        public Sensor(int IncreaseTimePerMinute, Sentido sentido)
        {
            ClockAddTime = IncreaseTimePerMinute;
            _sentido = sentido;
        }

        public async void RunTimerDelay()
        {
            while (true)
            {
                await Task.Delay(60000);
                //> Esquerdo = Sensor V
                // O relógio de V adianta 6 segundos a cada minuto real. 
                //O relógio de H atrasa 3 segundos a cada minuto real. 
                //Tempo de atraso\adiantamento definido na criação
                MyClock += ClockAddTime;
                Debug.WriteLine("alterando o relogio em " + ClockAddTime + " segundos" );
            }
        }

        public async void RunCom()
        {
            //envia dados de tráfego para o semaforo
            traphicAmount = Global.random.Next(1, 100);
            if (_sentido == Sentido.Horizontal)
            {
                Global.S.SetTaxaTrafegoHorizontal(traphicAmount);
            }
            else
            {
                Global.S.SetTaxaTrafegoVertical(traphicAmount);
            }
            Debug.WriteLine("enviando dados de tráfego");
            while (true)
            {
                await Task.Delay(Global.random.Next(5000, 50000));
                if(_sentido == Sentido.Horizontal)
                {
                    Global.S.SetTaxaTrafegoHorizontal(traphicAmount);
                }
                else
                {
                    Global.S.SetTaxaTrafegoVertical(traphicAmount);
                }
                Debug.WriteLine("enviando dados de tráfego");

            }
        }


        public async void RunTimer()
        {
            while (true)
            {
                await Task.Delay(1000);
                MyClock ++;
                //incrementa o contador de tempo a cada segundo
            }
        }

        public async void RunTraphicSimulator()
        {            
            while (true)
            {
                await Task.Delay(1);
                if((MyClock % 360) - 60 == 0)
                {
                    traphicAmount = Global.random.Next(1, 100);
                    Debug.WriteLine("Medição de tráfego alterada");
                }
                // H e V informam as suas taxas de tráfego p e q, respectivamente, a cada 6 minutos, 
                // em tempos múltiplos de 6 minutos menos 1 minuto (5, 11, 17, ...). 
            }
        }

        public async void RunSyncTime()
        {
            int cnt = 0;
            while (true)
            {
                cnt = 0;
                do
                {
                    await Task.Delay(1);
                    cnt++;
                } while (cnt / 100 < _synctimeSec);
                Debug.WriteLine("Sincronizando o tempo com o time server");
                AjustTime();
            }
        }


        private async void AjustTime()
        {
            int t0 = MyClock;
            int tserver = await Global.T.GetTime();
            int i = 1500;//timeserver process delay
            int t1 = MyClock;
            int d = (int)((float)(t1 - t0 - i/1000) / 2);
            MyClock = tserver + d;
            Debug.WriteLine("Ajustado tempo do sensor , era " + t1 + " agora é " + MyClock);
        }

        public void SetSyncTime(int synctime)
        {
            _synctimeSec = synctime * 60;
            Debug.WriteLine("Ajustando o tempo de sincronização para" + _synctimeSec + " segundos");
        }
    }
}
