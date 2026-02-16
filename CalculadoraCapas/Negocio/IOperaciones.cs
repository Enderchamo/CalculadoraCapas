using System;

namespace CalculadoraCapas.Negocio
{
    
    public interface IOperaciones
    {      
                public double Operar(double a, double b);
    }


    public class Suma : IOperaciones
    {
        public double Operar(double a, double b)
        {
            return a + b;
        }
    }

    public class Resta : IOperaciones
    {
        public double Operar(double a, double b)
        {
            return a - b;
        }
    }

    public class Multiplicacion : IOperaciones
    {
        public double Operar(double a, double b)
        {
            return a * b;
        }
    }

    public class Division : IOperaciones
    {
        public double Operar(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }


}
