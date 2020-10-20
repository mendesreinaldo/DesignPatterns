using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CriadorForcaEspeciais : CriadorDeSoldado
    {
        public CriadorForcaEspeciais()
        {
            _soldado = new SoldadoDeForcasEspeciais();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("AR-15");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Combate em solo");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de operações especiais");
        }
    }
}
