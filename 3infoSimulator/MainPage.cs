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
    public partial class MainPage : Form
    {
        atributos a = new atributos();
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (a.maior().Equals("erit"))
            {
                picFoto.Image = Properties.Resources.erit;
                lblNome.Text = "erit";
            }
            else if (a.maior().Equals("tadeu"))
            {
                picFoto.Image = Properties.Resources.tadeu;
                lblNome.Text = "tadeu";
            }
            else if (a.maior().Equals("raul"))
            {
                picFoto.Image = Properties.Resources.raul;
                lblNome.Text = "raul";
            }
            prgBarCagar.Value = prgBarCagar.Maximum;
            prgBarEnergia.Value = prgBarCagar.Maximum;
            prgBarFelicidade.Value = prgBarCagar.Maximum;
            prgBarFome.Value = prgBarCagar.Maximum;
            prgBarSede.Value = prgBarCagar.Maximum;
            lblDia.Text = "1";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgBarCagar.Increment(-1);
            prgBarEnergia.Increment(-1);
            prgBarFelicidade.Increment(-1);
            prgBarFome.Increment(-1);
            prgBarSede.Increment(-1);

            if(prgBarCagar.Value==0 || prgBarEnergia.Value==0 || prgBarFelicidade.Value==0 || prgBarFome.Value==0 || prgBarSede.Value == 0)
            {
                MessageBox.Show("voce perdeu seu lixoooo!!!!");
                Form1 form = new Form1();
                form.Show();
                this.Close();
            }
        }
    }
}
