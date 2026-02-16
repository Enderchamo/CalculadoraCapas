using System;

namespace CalculadoraCapas.Presentacion
{
    

    public static class ValidadorDeDobles
    {
        public static double ValidarDouble(string input)
        {
            double inputvalidado;
            while (!double.TryParse(input, out inputvalidado))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido:");
                input = Console.ReadLine();
            }
            return inputvalidado;
        }
    }
}