﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3infoSimulator
{
    class atributos
    {
        public static int raul;
        public static int erit;
        public static int tadeu;


        static int p1;

        public String maior()
        {
            int maiorint = erit;
            String maior = "erit";
            if (erit < raul)
            {
                maior = "raul";
                maiorint = raul;
            }
            if(maiorint<tadeu)
            {
                maior = "tadeu";
                maiorint = tadeu;
            }
            return maior;
        }
        public int getRaul()
        {
            return raul;
        }
        public int getErit()
        {
            return erit;
        }
        public int getTadeus()
        {
            return tadeu;
        }
        public void setRaul()
        {
            raul++;
        }

        public void setErit()
        {
            erit++;
        }

        public void setTadeu()
        {
            tadeu++;
        }



    }
}
