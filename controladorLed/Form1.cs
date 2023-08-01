using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Incluindo bibliotecas
using System.IO;
using System.IO.Ports;

namespace controladorLed
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();

            //Configurando entrada serial do computador
            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;
        
            //Definindo cor dos botões 
            ligaLed1.BackColor = Color.White;
            desligaLed1.BackColor = Color.White;

            ligaLed2.BackColor = Color.White;
            desligaLed2.BackColor = Color.White;
        }

        //Configurando botão para ligar o primeiro led
        private void ligaLed1_Click(object sender, EventArgs e)
        {
            //Abrindo porta serial
            serialPort1.Open();

            //Verifica se a porta está aberta
            if (serialPort1.IsOpen)
            {
                //envia valor à serial
                serialPort1.WriteLine("1");
                //altera a imagem para luz acesa
                imgLed1.ImageLocation = "https://i.pinimg.com/originals/37/d7/f6/37d7f69cdec95fc4aaab9155beb5c826.jpg";
            }

            //fecha porta serial
            serialPort1.Close();

            //muda cor dos botões
            ligaLed1.BackColor = Color.Gray;
            desligaLed1.BackColor = Color.White;
        }
        private void desligaLed1_Click(object sender, EventArgs e)
        {
            //Abrindo porta serial
            serialPort1.Open();
            //Verifica se a porta está aberta
            if (serialPort1.IsOpen)
            {
                //envia valor à serial
                serialPort1.WriteLine("0");
                //altera a imagem para luz apagada
                imgLed1.ImageLocation = "https://i2.wp.com/www.maissantos.com.br/wp-content/uploads/2017/03/lamp.jpg?resize=200%2C133&ssl=1";
             }

            //Fecha Porta Serial
            serialPort1.Close();

            //Altera cor dos botões
            ligaLed1.BackColor = Color.White;
            desligaLed1.BackColor = Color.Gray;
        }

        //Configurando botão para ligar e desligar o segundo led
        private void ligaLed2_Click_1(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("b");
                imgLed2.ImageLocation = "https://i.pinimg.com/originals/37/d7/f6/37d7f69cdec95fc4aaab9155beb5c826.jpg";
            }
            serialPort1.Close();
            ligaLed2.BackColor = Color.Gray;
            desligaLed2.BackColor = Color.White;
        }

        private void desligaLed2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("a");
                imgLed2.ImageLocation = "https://i2.wp.com/www.maissantos.com.br/wp-content/uploads/2017/03/lamp.jpg?resize=200%2C133&ssl=1";
            }
            serialPort1.Close();
            ligaLed2.BackColor = Color.White;
            desligaLed2.BackColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
