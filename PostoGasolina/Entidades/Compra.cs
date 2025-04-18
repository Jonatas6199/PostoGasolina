using PostoGasolina.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entidades
{
    public class Compra
    {
        public Combustivel Combustivel { get; set; }
        public double ValorCompra { get; set; }
        public PagamentosEnum FormaPagamento { get; set; }
        public double Litros {  get; set; }
        public int Parcelas { get; set; } = 0;
    }
}
