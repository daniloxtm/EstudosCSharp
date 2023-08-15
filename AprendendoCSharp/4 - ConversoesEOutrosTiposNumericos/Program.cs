using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 1279.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.1;
            double valor2 = 0.2;
            double total = valor1 + valor2;
            Console.WriteLine(total);
            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);
            
            Console.ReadLine();

        }
    }
}
