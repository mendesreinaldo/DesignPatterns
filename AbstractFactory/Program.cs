using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaBase fabrica;
            Console.WriteLine("Escolha um dos personagens: 1-Protss | 2-Zergs | 3-Terranos");

            switch (Console.ReadLine())
            {
                case "1":
                    fabrica = new FabricaBaseProtoss();
                    break;

                case "2":
                    fabrica = new FabricaBaseZerg();
                    break;

                case "3":
                    fabrica = new FabricaBaseTerran();
                    break;
            }

            Console.ReadLine();
        }
    }
}
