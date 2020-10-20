using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_criando_variaveis
{
    class Calculadora
    {

        private int a;
        private int b;

        public Calculadora(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Soma()
        {
            return this.a + this.b;
        }

        public int Subtracao()
        {
            return this.a - this.b;
        }

        public int Multiplicacao()
        {
            return this.a * this.b;
        }

        public int Divisao()
        {
            return this.a / this.b;
        }
        
    }
}
