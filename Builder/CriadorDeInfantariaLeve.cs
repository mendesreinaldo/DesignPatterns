using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadeDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("resposta rapida aérea");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicoptero de ataque do exercito");
        }
    }
}
