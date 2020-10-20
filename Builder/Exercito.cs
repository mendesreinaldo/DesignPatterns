using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Exercito
    {
        public void ConstruirSoldados(CriadorDeSoldado criador)
        {
            criador.Arma();
            criador.Transporte();
            criador.Foco();
        }
    }
}
