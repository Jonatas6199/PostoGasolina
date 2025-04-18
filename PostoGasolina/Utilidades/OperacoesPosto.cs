using PostoGasolina.Entidades;
using PostoGasolina.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Utilidades
{
    public static class OperacoesPosto
    {
        public static Compra RealizarCompra
            (CombustivelEnum combustivel, PurezaEnum pureza, PagamentosEnum formaPagamento, double litros, int parcelas= 0)
        {
            Compra compra = new Compra();
            switch (combustivel)
            {
                case CombustivelEnum.Etanol:
                    compra.Combustivel = new Etanol();
                    break;

                case CombustivelEnum.Gasolina:
                    compra.Combustivel = new Gasolina(pureza);
                    break;

                case CombustivelEnum.Diesel:
                    compra.Combustivel = new Diesel(pureza);
                    break;

            }
           
            compra.FormaPagamento = formaPagamento;
            compra.Parcelas = parcelas; 
            compra.Litros = litros;

            compra.ValorCompra = 
                Calculos.CalculaCombustivelPorFormaDePagamento
                (formaPagamento, litros, compra.Combustivel.PrecoLitro, parcelas);

            return compra;
        }
    }
}
