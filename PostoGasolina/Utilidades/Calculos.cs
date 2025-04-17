using PostoGasolina.Entidades;
using PostoGasolina.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Utilidades
{
    public static class Calculos
    {
        public static double CalculaCombustivelBasico
            (double litragem, double preco)
        {
            double calculo = litragem * preco;
            return Math.Round(calculo, 2);
        }

        public static double CalculaCombustivelPorFormaDePagamento
            (PagamentosEnum formaDePagamento, double litros, double precoLitro, int parcelas = 0)
        {
            double taxa = 1;//100% mantém o valor original
            switch (formaDePagamento)
            {
                case PagamentosEnum.CreditoAVista:
                    taxa = 1.05;
                    break;
                case PagamentosEnum.CreditoParcelado:
                    if (parcelas == 1)
                        taxa = 1.05;
                    else
                        taxa = CalculaTaxaParcelas(parcelas);
                    break;
                case PagamentosEnum.Debito:
                    taxa = 1.03;
                    break;
                case PagamentosEnum.Pix:
                    taxa = 1;
                    break;
                case PagamentosEnum.TED:
                    taxa = 1.01;
                    break;
                case PagamentosEnum.DOC:
                    taxa = 1.02;
                    break;
                case PagamentosEnum.Especie:
                    taxa = 1;
                    break;
            }

            double precoTaxado = CalculaTaxa(taxa, precoLitro);

            return Math.Round(precoTaxado * litros, 2);
        }
        private static double CalculaTaxa(double taxa, double preco)
        {
            return taxa * preco;
        }

        private static double CalculaTaxaParcelas(int parcelas)
        {
            double taxaPorParcela = 1;
            if (parcelas >= 2 && parcelas <= 12)
            {
                for (int i = 0; i < parcelas; i++)
                {
                    taxaPorParcela *= 1.09;
                }
            }
            else
            {
                //Caso a parcela seja menor que 2 ou maior que 12 vai estourar uma exceção
                throw new Exception("Número de parcelas inválido!");
            }

            return taxaPorParcela;
        }

    }
}
