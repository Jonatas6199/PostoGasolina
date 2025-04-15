using PostoGasolina.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entidades
{
    public class Diesel : Combustivel
    {
        //DECLARACAO DA PROPRIEDADE
        public string Nome { get; set; }
        public double Valor { get; set; }

        //Obrigatório passar o nível de pureza no construtor
        //Ao criar um objeto do tipo Diesel
        public Diesel(PurezaEnum pureza)
        {
            //Atribuindo a propriedade pureza,
            // o valor passado no construtor
            Pureza = pureza;
        }
        public double CalculaValorDiesel(double litros)
        {
            if (Pureza == PurezaEnum.Alta)
                Valor = 7;
            else if (Pureza == PurezaEnum.Media)
                Valor = 6;
            else if (Pureza == PurezaEnum.Baixa)
                Valor = 5;

            return Math.Round(Valor * litros, 2);
        }

        //Construtor padrão que toda classe que pode
        // ser instancidada tem
        //A partir do momento que escrevo outro construtor
        //Caso eu queria manter o padrão eu preciso escrever ele
        //public Diesel() { }
    }
}
