using PostoGasolina.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entidades
{
    //Classe abstrata, é uma classe base que pode ser herdada
    public abstract class Combustivel
    {
        public double PrecoLitro { get; set; }
        public PurezaEnum Pureza { get; set; }
        public string Viscosidade { get; set; }
    }
}
