using PostoGasolina.Enumeradores;
using PostoGasolina.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entidades
{
    public class Gasolina : Combustivel
    {
        public Gasolina(PurezaEnum pureza, string viscosidade) 
        {
            Pureza = pureza;
            Viscosidade = viscosidade;
        }
        public double CalculoPrecoGasolina(double litros) 
        {
            switch (Pureza)
            {
                case PurezaEnum.Alta:
                    PrecoLitro = 8.34;
                    break;
                case PurezaEnum.Media:
                    PrecoLitro = 6.92;
                    break;
                case PurezaEnum.Baixa:
                    PrecoLitro = 5.79;
                    break;
            }
            return Calculos.CalculaCombustivelBasico(litros, PrecoLitro);
        }

    }
}
