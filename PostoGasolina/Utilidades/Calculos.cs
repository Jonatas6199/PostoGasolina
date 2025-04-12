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
        public static double CalculaCombustivelBasico(double litragem, double preco)
        {
            double calculo = litragem * preco;
            return Math.Round(calculo, 2);
        }
    }
}
