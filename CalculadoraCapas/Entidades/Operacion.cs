using System;

namespace CalculadoraCapas.Entidades

{
    public class Operacion{      
        public double Numero1 {get; protected set;}
        public double Numero2 {get; protected set;}

        public TipoOperacion TipoOperacion {get; protected set;   }

        public double Resultado {get; set; }

    }
}
    


