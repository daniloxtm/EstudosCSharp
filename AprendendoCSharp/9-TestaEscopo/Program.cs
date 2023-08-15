using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_TestaEscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            int quantidadePessoas = 3;
            //bool acompanhado = true;
            bool acompanhado;

            if (quantidadePessoas >= 2)
            {
                /*bool*/ acompanhado = true;
            }
            else
            {
                /*bool*/ acompanhado = false;
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
