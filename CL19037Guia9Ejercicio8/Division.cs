using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Guia9Ejercicio8
{
    class Division
    {
        string pikachu;

        public string Pikachu
        {
            get
            {
                return pikachu;
            }

            set
            {
                pikachu = value;
            }
        }

        public string[] DividirFrase()
        {
            string[] divisor = null;

            divisor = pikachu.Split(' ');

            return divisor;
        }
    }
}
