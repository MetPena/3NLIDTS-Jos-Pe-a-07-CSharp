
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Librería de comunicación serial

namespace _3NLIDTS_JoséPeña_07._0
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }

        public Form1()
        {
            InitializeComponent();

            // Configuración de comunicación serial con Arduino
            ArduinoPort = new SerialPort();
            ArduinoPort.PortName = "COM9"; // Verificar el puerto COM del equipo
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            // Manejadores de eventos
            this.FormClosing += CerrandoForm1;
            this.BtnEncender.Click += btnEncender_Click;
            this.BtnApagar.Click += btnApagar_Click;
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
    }
}

