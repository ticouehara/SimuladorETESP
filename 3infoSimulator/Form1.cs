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
    public partial class Form1 : Form
    {
        atributos h = new atributos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vc è burro?");
            h.setErit();
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            caixaMensagem form = new caixaMensagem("no seu tempo livre,oq voce fas???????", "programo e ouvo musica eletronica xd", "erit", "jogo liga das legemdas", "nenhuma das anteriores :'(", 1, 4);
            form.ShowDialog();
            caixaMensagem form2 = new caixaMensagem("voce vai frquentemente a escola?????????????????", "sim", "nao", "mais ou menos xd", "quando eu nao cabulo sim kkk", 2, 2);
            form2.ShowDialog();
            caixaMensagem form3 = new caixaMensagem("o que vossa senhoria perpreta em seus ensinamentos?????????????????????????????????", "perguntas desnecessarias pra chamar atenção jjjjjjj", "nada", "durmo zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", "se voce descobrir esse botao voce é hacker mano o.O", 3, 3);
            form3.ShowDialog();
            caixaMensagem form4 = new caixaMensagem("voce tem amigos?????????????????", "sim", "nao :((((((((((((((", "se voce descobrir esse botao voce é hacker mano o.O", "se voce descobrir esse botao voce é hacker mano o.O", 4, 2);
            form4.ShowDialog();
            caixaMensagem form5 = new caixaMensagem("voce normalmente é soado por seus amigos?????????????????", "sim infelismente", "nao", "se voce descobrir esse botao voce é hacker mano o.O", "se voce descobrir esse botao voce é hacker mano o.O", 5, 2);
            form5.ShowDialog();           
        }
    }
}
