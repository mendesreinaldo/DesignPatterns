using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercito = new Exercito();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            //Criando soldado de força especial
            criadorDeSoldado = new CriadorForcaEspeciais();
            exercito.ConstruirSoldados(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as caracteristicas: {0},{1} e {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            //Criando soldado de infantaria leve
            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldados(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as caracteristicas: {0},{1} e {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

        }
    }
}
