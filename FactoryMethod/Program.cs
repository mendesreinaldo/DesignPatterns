using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Escolha seu Persongame: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);

            Console.WriteLine();
            Console.WriteLine("Você vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
