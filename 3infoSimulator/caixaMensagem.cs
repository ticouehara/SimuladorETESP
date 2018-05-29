using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3infoSimulator
{
    public partial class caixaMensagem : Form
    {
        atributos a = new atributos();
        static int numero;
        public caixaMensagem()
        {

        }


        public caixaMensagem(String message, string botao1,string botao2, string botao3, string botao4, int pergunta, int botoes)
        {
            InitializeComponent();
            this.ControlBox = false;
            if (botoes == 2)
            {
                button3.Visible = false;
                button4.Visible = false;
            }
            if (botoes == 3)
            {
                button4.Visible = false;
            }
                label2.Text = message;
                button1.Text = botao1;
                button2.Text = botao2;
                button3.Text = botao3;
                button4.Text = botao4;
                numero = pergunta;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numero == 1)
            {
                a.setTadeu();
            }
            if (numero == 2)
            {
                a.setErit();
                a.setTadeu();
            }
            if (numero == 3)
            {
                a.setRaul();
            }
            if (numero == 4)
            {
                
            }
            if (numero == 5)
            {
                a.setTadeu();
                a.setRaul();
                a.setErit();
                MainPage main = new MainPage();
                main.Show();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numero == 1)
            {
                a.setErit();
            }
            if (numero == 2)
            {

            }
            if (numero == 3)
            {
                a.setTadeu();
            }
            if (numero == 4)
            {
                a.setRaul();
            }
            if (numero == 5)
            {
                MainPage main = new MainPage();
                main.Show();
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numero == 1)
            {
                a.setRaul();
            }
            if (numero == 2)
            {

            }
            if (numero == 3)
            {
                a.setErit();
            }
            if (numero == 4)
            {
                a.setRaul();
            }
            if (numero == 5)
            {
                MainPage main = new MainPage();
                main.Show();
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numero == 5)
            {
                MainPage main = new MainPage();
                main.Show();
            }
            this.Close();
        }
    }
}
