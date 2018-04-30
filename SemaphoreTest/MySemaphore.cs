using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int _synctimeSec = 60;

        public int TempoAberto = 0;
        public int TempoFechado = 0;

        public int Timestamp = 0;
        public tempoestado _estadoAtual = tempoestado.vermelho;

        public int _taxaTrafegoV = 0;
        public int _taxaTrafegoH = 0;

        public int ModoSemaforo = 0;

        public async void Run()
        {
            int cnt = 0;
            int temposemaforo = 0;
            ModoSemaforo = SetTimeRule(_taxaTrafegoH / (_taxaTrafegoH + _taxaTrafegoV));
            while (true)
            {
                do
                {
                    await Task.Delay(1);
                    cnt++;
                    if(cnt % 100 == 0)
                    {
                        temposemaforo++;
                    }
                    if(_estadoAtual == tempoestado.verde && temposemaforo > TempoAberto)
                    {
                        _estadoAtual = tempoestado.vermelho;
                        temposemaforo = 0;
                        Debug.WriteLine("semaforo horizontal está fechando");
                    }
                    else if (_estadoAtual == tempoestado.vermelho && temposemaforo > TempoFechado)
                    {
                        _estadoAtual = tempoestado.verde;
                        temposemaforo = 0;
                        Debug.WriteLine("semaforo horizontal está abrindo");
                    }
                } while (cnt < 60000);

                ModoSemaforo = SetTimeRule(_taxaTrafegoH / (_taxaTrafegoH + _taxaTrafegoV));
                //S atualiza o modo de operação a cada 6 minutos, em tempos múltiplos de 6 minutos (0, 6, 12, 18, ...).
            }

        }

        public async void RunTimer()
        {
            while (true)
            {
                await Task.Delay(1000);
                Timestamp++;
                //incrementa o contador de tempo a cada segundo
            }
        }

        public async void RunSyncTime()
        {
            int cnt;
            while (true)
            {
                cnt = 0;
                do
                {
                    await Task.Delay(1);
                    cnt++;
                } while (cnt / 100 < _synctimeSec);
                AjustTime();
            }            
        }

        public int SetTimeRule(double x)
        {
            //S tem 5 modos de operação, conforme definido na tabela abaixo
            //return mode
            if (x <= 0.2)
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

        public void SetTaxaTrafegoHorizontal(int taxaTrafego)
        {
            _taxaTrafegoH = taxaTrafego;        }

        public void SetTaxaTrafegoVertical(int taxaTrafego)
        {
            _taxaTrafegoV = taxaTrafego;
        }


        private async void AjustTime()
        {
            int t0 = Timestamp;
            int tserver = await Global.T.GetTime();
            int i = 1500;//timeserver process delay
            int t1 = Timestamp;
            int d = (int)((float)(t1 - t0 - i / 1000.0) / 2);
            Timestamp    = tserver + d;
            Debug.WriteLine("Ajustado tempo do semaforo, era " + t1 + " agora é " + Timestamp);
        }

        public void SetSyncTime(int synctime)
        {
            _synctimeSec = synctime * 60;
            Debug.WriteLine("Ajustando o tempo de sincronização para" + _synctimeSec + " segundos");
        }


        public async void RunTimerDelay()
        {
            while (true)
            {
                await Task.Delay(1000 /*1 seg*/ * 60);
                //>  O relógio de H atrasa 3 segundos a cada minuto real. 
                Timestamp += 3;
                Debug.WriteLine("alterando o relogio do semaforo em 3 segundos");
            }
        }

    }


}
