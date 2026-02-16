using System; 
using CalculadoraCapas.Entidades; 


namespace CalculadoraCapas.Negocio { 
    public class FactoryOperaciones {
         public static IOperaciones CrearOperacion(TipoOperacion tipo)
         
            { return tipo switch

                { TipoOperacion.Suma => new Suma(), 
                TipoOperacion.Resta => new Resta(), 
                TipoOperacion.Multiplicacion => new Multiplicacion(), 
                TipoOperacion.Division => new Division(),
                _ => throw new ArgumentException("Tipo de operación no válido.") 
                }; 
                
        } 
        
    } 
}