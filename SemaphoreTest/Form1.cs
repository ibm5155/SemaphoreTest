using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaphoreTest
{
    public partial class Form1 : Form
    {

        #region Variaveis
        

                    private int _modoSemaforo;
        public int ModoSemaforo
        {
            get { return _modoSemaforo; }
            set
            {
                _modoSemaforo = value;
                textBox_Modo.Text = "Modo Semaforo: " + _modoSemaforo;
            }
        }

        private int _tempoSemaforo;
        public int TempoSemaforo
        {
            get { return _tempoSemaforo; }
            set {
                _tempoSemaforo = value;
                textBox_TempoSemaforo.Text = "Tempo Semaforo: " + _tempoSemaforo;
            }
        }

        private int _tempoSemnsorV;
        public int TempoSensorV
        {
            get { return _tempoSemnsorV; }
            set
            {
                _tempoSemnsorV = value;
                textBox_TempoV.Text = "Tempo Sensor V: " + _tempoSemnsorV;
            }
        }

        private int _tempoSensorH;
        public int TempoSensorH
        {
            get { return _tempoSensorH; }
            set
            {
                _tempoSensorH = value;
                textBox_TempoH.Text = "Tempo Sensor H: " + _tempoSensorH;
            }
        }

        private int _timestampT;
        public int TimestampT
        {
            get { return _timestampT; }
            set
            {
                _timestampT = value;
                textBox_TempoT.Text = "Tempo T: " + _timestampT;
            }
        }

        private int _quantidadeCarrosH;
        public int QuantidadeCarrosH
        {
            get { return _quantidadeCarrosH; }
            set
            {
                _quantidadeCarrosH = value;
                QuantidadeH.Text = _quantidadeCarrosH.ToString();
            }
        }

        private int _quantidadeCarrosV;
        public int QuantidadeCarrosV
        {
            get { return _quantidadeCarrosV; }
            set
            {
                _quantidadeCarrosV = value;
                QuantidadeV.Text = _quantidadeCarrosV.ToString();
            }
        }

        private int _timesync;
        public int Timesync
        {
            get { return _timesync; }
            set
            {
                if(value <= 0 || value >= 20)
                {
                    _timesync = 6;
                }
                else
                {
                    _timesync = value;
                }
                Global.S.SetSyncTime(_timesync);
                Global.H.SetSyncTime(_timesync);
                Global.V.SetSyncTime(_timesync);

                QuantidadeV.Text = _timesync.ToString();
            }
        }


        #endregion

        public Form1()
        {
            InitializeComponent();
            Global.T.Run();
            Global.H.RunTimer();
            Global.V.RunTimer();
            Global.S.RunTimer();
            Global.V.RunTimerDelay();
            Global.H.RunTimerDelay();
            Global.S.RunTimerDelay();
            Global.H.RunCom();
            Global.V.RunCom();
            Global.V.RunTraphicSimulator();
            Global.H.RunTraphicSimulator();
            Global.S.RunSyncTime();
            Global.H.RunSyncTime();
            Global.V.RunSyncTime();
            Global.S.Run();
            SniffAsync();
        }

        public async void SniffAsync()
        {
            while (true)
            {
                await Task.Delay(100);
                
                TempoSemaforo = Global.S.Timestamp;
                ModoSemaforo = Global.S.ModoSemaforo;
                TempoSensorH = Global.H.MyClock;
                TempoSensorV = Global.V.MyClock;
                TimestampT = Global.T.MyClock;
                QuantidadeCarrosH = Global.H.traphicAmount;
                QuantidadeCarrosV = Global.V.traphicAmount;
                if(Global.S._estadoAtual == tempoestado.verde)
                {
                    SemaphoreH.Image = Properties.Resources.verde;
                    SemaphoreV.Image = Properties.Resources.vermelho;
                }
                else
                {
                    SemaphoreV.Image = Properties.Resources.verde;
                    SemaphoreH.Image = Properties.Resources.vermelho;
                }
            }
        }

        private void textBox_timesync_TextChanged(object sender, EventArgs e)
        {
            Timesync = int.Parse(textBox_timesync.Text);
        }
    }
}
