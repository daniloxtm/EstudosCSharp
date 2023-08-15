using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");
            int idade = 20;
            int quantidadePessoas = 3;

            if (idade > 18)
            {
                Console.WriteLine("Voce tem mais que 18 anos!");
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Voce não tem 18 anos, mas pode entrar pois está acompanhado");
                }
                else 
                {
                    Console.WriteLine("Infelizmente voce não pode entrar");
                }    
                
            }
            Console.ReadLine();




        }
    }
}
