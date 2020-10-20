using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_criando_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora calculadora = new Calculadora(10, 5);
            Console.WriteLine(calculadora.Divisao());
        }
    }
}
