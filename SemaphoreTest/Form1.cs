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

        private int _tempoSemaforo1;
        public int TempoSemaforo1
        {
            get { return _tempoSemaforo1; }
            set {
                _tempoSemaforo1 = value;
                textBox_Tempo1.Text = "Tempo Semaforo 1: " + _tempoSemaforo1;
            }
        }

        private int _tempoSemaforo2;
        public int TempoSemaforo2
        {
            get { return _tempoSemaforo2; }
            set
            {
                _tempoSemaforo2 = value;
                textBox_Tempo2.Text = "Tempo Semaforo 2: " + _tempoSemaforo2;
            }
        }

        private int _timestampSemaforo1;
        public int TimestampSemaforo1
        {
            get { return _timestampSemaforo1; }
            set
            {
                _timestampSemaforo1 = value;
                textBox_Timestamp1.Text = "Timestamp Semaforo 1: " + _timestampSemaforo1;
            }
        }

        private int _timestampSemaforo2;
        public int TimestampSemaforo2
        {
            get { return _timestampSemaforo2; }
            set
            {
                _timestampSemaforo2 = value;
                textBox_Timestamp2.Text = "Timestamp Semaforo 2: " + _timestampSemaforo2;
            }
        }

        private int _quantidadeCarros1;
        public int QuantidadeCarros1
        {
            get { return _quantidadeCarros1; }
            set
            {
                _quantidadeCarros1 = value;
                Quantidade1.Text = _quantidadeCarros1.ToString();
            }
        }

        private int _quantidadeCarros2;
        public int QuantidadeCarros2
        {
            get { return _quantidadeCarros2; }
            set
            {
                _quantidadeCarros2 = value;
                Quantidade2.Text = _quantidadeCarros2.ToString();
            }
        }


        #endregion

        public Form1()
        {
            InitializeComponent();
            TempoSemaforo1 = 1;
        }

    }
}
