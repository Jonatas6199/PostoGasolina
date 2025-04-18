using PostoGasolina.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entidades
{
    //Classe abstrata, é uma classe base que pode ser herdada
    //E nao pode ser instanciada
    //Logo nao pode ser um objeto
    public abstract class Combustivel
    {
        public double PrecoLitro { get; set; }
        public PurezaEnum Pureza { get; set; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
