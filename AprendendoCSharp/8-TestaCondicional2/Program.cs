using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_TestaCondicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais 2");

            int idade = 16;
            int quantidadePessoas = 3;
            //bool acompanhado = true;
            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 || quantidadePessoas >=2)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente voce não pode entrar");
            }
            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente voce não pode entrar");
            }
            Console.ReadLine();
        }
    }
}
