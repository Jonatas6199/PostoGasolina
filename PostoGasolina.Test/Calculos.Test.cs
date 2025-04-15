using PostoGasolina.Entidades;
using PostoGasolina.Enumeradores;
using PostoGasolina.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Test
{
    public class TestarCalculosTeste
    {
        [Fact(Skip ="")]
        public void TestarPrecoGasolina_True_Fact()
        {
            double litros = 20;
            Gasolina gasolina = new Gasolina(Enumeradores.PurezaEnum.Alta, "40W");
            double resultado = gasolina.CalculoPrecoGasolina(litros);
            Assert.Equal(140, resultado);
        }

        [Fact(Skip = "")]
        public void TestarPrecoEtanol_True_Fact()
        {
            double litros = 20;
            Etanol etanol = new Etanol();
            double resultado =
                Calculos.CalculaCombustivelBasico(litros, etanol.PrecoLitro);

            Assert.Equal(80, resultado);
        }

        [Fact(Skip = "")]
        public void TestarPrecoDiesel_True_Fact()
        {
            double litros = 20;
            Diesel diesel = new Diesel(PurezaEnum.Alta);
            Console.WriteLine(diesel.Viscosidade);
            double resultado =
                Calculos.CalculaCombustivelBasico(litros, diesel.PrecoLitro);

            Assert.Equal(160, resultado);
        }
    }
}
