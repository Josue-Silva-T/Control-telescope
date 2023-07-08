using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using controlT.Properties;


namespace controlT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            buttonDerecha.Enabled = false;
            buttonIzquierda.Enabled = false;
            buttonComenzar.Enabled = false;
            buttonMinizar.Enabled = false;
            buttonMaximizar.Enabled = false;
            buttonPausar.Enabled = false;

            buttonDerechoV.Enabled = false;
            buttonIzquierdaV.Enabled = false;
            buttonComenzarV.Enabled = false;
            buttonPausarV.Enabled = false;

            buttonDerecha.ForeColor = Color.Black;
            buttonPausar.ForeColor = Color.Black;
            buttonIzquierda.ForeColor = Color.Black;
            buttonDerecha.BackColor = Color.White;
            buttonIzquierda.BackColor = Color.White;
            buttonCerrado.ForeColor = Color.Black;
            buttonCerrado.BackColor = Color.White;
            buttonPausar.BackColor = Color.White;
            buttonComenzar.ForeColor = Color.Black;
            buttonMinizar.ForeColor = Color.Black;
            buttonMaximizar.ForeColor = Color.Black;
            buttonComenzar.BackColor = Color.White;
            buttonMinizar.BackColor = Color.White;
            buttonMaximizar.BackColor = Color.White;

            buttonDerechoV.ForeColor = Color.Black;
            buttonIzquierdaV.ForeColor = Color.Black;
            buttonDerechoV.BackColor = Color.White;
            buttonIzquierdaV.BackColor = Color.White;
            buttonComenzarV.ForeColor = Color.Black;
            buttonComenzarV.BackColor = Color.White;
            buttonPausarV.BackColor = Color.White;
            buttonPausarV.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonAbierto.Enabled = true;
            buttonCerrado.Enabled = false;
            comboBoxSERIAL.Text = "9600";
            comboBoxCOM.Text = "COM1";
            string[] portList = SerialPort.GetPortNames();
            comboBoxCOM.Items.AddRange(portList);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String x = Convert.ToString(comboBoxCAM.Text);
            
            System.Diagnostics.Process.Start(x);
        }

        private void buttonAbierto_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxCOM.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBoxSERIAL.Text);
 
                serialPort1.Open();
                buttonAbierto.Enabled = false;
                buttonCerrado.Enabled = true;
                comboBoxCOM.Enabled = false;
                comboBoxSERIAL.Enabled = false;
                buttonDerecha.Enabled = true;
                buttonIzquierda.Enabled = true;
                buttonComenzar.Enabled = true;
                buttonMinizar.Enabled = true;
                buttonMaximizar.Enabled = true;
                buttonPausar.Enabled = true;

            buttonDerechoV.Enabled = true;
            buttonIzquierdaV.Enabled = true;
            buttonComenzarV.Enabled = true;
            buttonPausarV.Enabled = true;

            buttonCerrado.BackColor = Color.Black;
                buttonPausar.BackColor = Color.Black;
                buttonPausar.ForeColor = Color.White;
                buttonAbierto.BackColor = Color.White;
                buttonCerrado.ForeColor = Color.White;
                buttonAbierto.ForeColor = Color.Black;
                buttonDerecha.ForeColor = Color.White;
                buttonIzquierda.ForeColor = Color.White;
                buttonDerecha.BackColor = Color.Black;
                buttonIzquierda.BackColor = Color.Black;
                buttonComenzar.ForeColor = Color.White;
                buttonMinizar.ForeColor = Color.White;
                buttonMaximizar.ForeColor = Color.White;
                buttonComenzar.BackColor = Color.Black;
                buttonMinizar.BackColor = Color.Black;
                buttonMaximizar.BackColor = Color.Black;
            
        }

        private void buttonCerrado_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    buttonCerrado.Enabled = false;
                    buttonAbierto.Enabled = true;
                    comboBoxCOM.Enabled = true;
                    comboBoxSERIAL.Enabled = true;
                    buttonDerecha.Enabled = false;
                    buttonIzquierda.Enabled = false;
                    buttonPausar.Enabled = false;
                    buttonComenzar.Enabled = false;
                    buttonMinizar.Enabled = false;
                    buttonMaximizar.Enabled = false;

                    buttonCerrado.ForeColor = Color.Black;
                    buttonCerrado.BackColor = Color.White;
                    buttonAbierto.BackColor = Color.Black;
                    buttonAbierto.ForeColor = Color.White;
                    buttonDerecha.ForeColor = Color.Black;
                    buttonIzquierda.ForeColor = Color.Black;
                    buttonDerecha.BackColor = Color.White;
                    buttonIzquierda.BackColor = Color.White;
                    buttonComenzar.ForeColor = Color.Black;
                    buttonMinizar.ForeColor = Color.Black;
                    buttonMaximizar.ForeColor = Color.Black;
                    buttonComenzar.BackColor = Color.White;
                    buttonMinizar.BackColor = Color.White;
                    buttonMaximizar.BackColor = Color.White;
                    buttonPausar.BackColor = Color.White;
                    buttonPausar.ForeColor = Color.Black;

                    buttonDerechoV.ForeColor = Color.Black;
                    buttonIzquierdaV.ForeColor = Color.Black;
                    buttonDerechoV.BackColor = Color.White;
                    buttonIzquierdaV.BackColor = Color.White;
                    buttonComenzarV.ForeColor = Color.Black;
                    buttonComenzarV.BackColor = Color.White;
                    buttonPausarV.BackColor = Color.White;
                    buttonPausarV.ForeColor = Color.Black;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonDerecha_Click(object sender, EventArgs e)
        {
                buttonDerecha.Enabled = false;
                buttonIzquierda.Enabled = true;

            buttonDerecha.ForeColor = Color.Black;
            buttonDerecha.BackColor = Color.White;
            buttonIzquierda.ForeColor = Color.White;
            buttonIzquierda.BackColor = Color.Black;

            serialPort1.WriteLine("4");
        }

        private void buttonIzquierda_Click(object sender, EventArgs e)
        {
            buttonDerecha.Enabled = true;
            buttonIzquierda.Enabled = false;

            buttonIzquierda.ForeColor = Color.Black;
            buttonIzquierda.BackColor = Color.White;
            buttonDerecha.ForeColor = Color.White;
            buttonDerecha.BackColor = Color.Black;

            
        }
        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            buttonComenzar.Text = "Pausa";
            serialPort1.WriteLine("3");
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1"); //Se escribe en el puerto 1 es la indicacion de maximizar el enfoque
        }

        private void buttonMinizar_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("2");
        }

        private void buttonComenzar_Click_1(object sender, EventArgs e)
        {
            serialPort1.WriteLine("5");

            buttonPausar.Enabled = true;
            buttonComenzar.Enabled = false;

            buttonComenzar.ForeColor = Color.Black;
            buttonComenzar.BackColor = Color.White;
            buttonPausar.ForeColor = Color.White;
            buttonPausar.BackColor = Color.Black;
        }
        private void buttonPausar_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("6");

            buttonPausar.Enabled = false;
            buttonComenzar.Enabled = true;

            buttonComenzar.ForeColor = Color.White;
            buttonComenzar.BackColor = Color.Black;
            buttonPausar.ForeColor = Color.Black;
            buttonPausar.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
