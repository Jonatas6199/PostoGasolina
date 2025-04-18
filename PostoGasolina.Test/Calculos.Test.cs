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
        [Fact(Skip = "N/A")]
        public void TestarPrecoGasolina_True_Fact()
        {
            double litros = 20;
            Gasolina gasolina = new Gasolina(PurezaEnum.Alta);
            double resultado = gasolina.CalculoPrecoGasolina(litros);
            Assert.Equal(140, resultado);
        }

        [Fact(Skip = "N/A")]
        public void TestarPrecoEtanol_True_Fact()
        {
            double litros = 20;
            Etanol etanol = new Etanol();
            double resultado =
                Calculos.CalculaCombustivelBasico(litros, etanol.PrecoLitro);

            Assert.Equal(80, resultado);
        }

        [Fact(Skip = "N/A")]
        public void TestarPrecoDiesel_True_Fact()
        {
            double litros = 20;
            Diesel diesel = new Diesel(PurezaEnum.Alta);
            double resultado =
                Calculos.CalculaCombustivelBasico(litros, diesel.PrecoLitro);

            Assert.Equal(160, resultado);
        }

        [Fact]
        public void TestarGasolinaCreditoAVista_True_Fact()
        {
            double litros = 20;
            Gasolina gasolina = new Gasolina(PurezaEnum.Alta);
            double resultado = 
                Calculos.CalculaCombustivelPorFormaDePagamento
                (PagamentosEnum.CreditoAVista,litros, gasolina.PrecoLitro);

            Assert.Equal(175.14, resultado);
        }

        [Fact]
        public void TestarGasolinaCreditoParcelado_True_Fact()
        {
            double litros = 20;
            Gasolina gasolina = new Gasolina(PurezaEnum.Alta);
            double resultado =
                Calculos.CalculaCombustivelPorFormaDePagamento
                (PagamentosEnum.CreditoParcelado, litros, gasolina.PrecoLitro,5);

            Assert.Equal(256.64, resultado);
        }

        [Fact]
        public void TestarGasolinaCreditoParceladoExcecao_Fact()
        {
            double litros = 20;
            Gasolina gasolina = new Gasolina(PurezaEnum.Alta);
            Assert.Throws<Exception>(()=>
            Calculos.CalculaCombustivelPorFormaDePagamento
                (PagamentosEnum.CreditoParcelado, litros, gasolina.PrecoLitro, 14));
        }
    }
}
