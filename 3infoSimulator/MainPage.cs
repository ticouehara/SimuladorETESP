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
        }
    }
}
