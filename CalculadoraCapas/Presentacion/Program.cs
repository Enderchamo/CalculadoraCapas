using System;
using CalculadoraCapas.Negocio;
using CalculadoraCapas.Entidades;

namespace CalculadoraCapas.Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Bienvenido a la calculadora ----");

            // Pedir números con validación
            Console.WriteLine("Ingrese el primer número:");
            double num1 = ValidadorDeDobles.ValidarDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = ValidadorDeDobles.ValidarDouble(Console.ReadLine());

            // Menú de operaciones
            Console.WriteLine("Seleccione la operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            string opcion = Console.ReadLine();
            TipoOperacion tipo;

            switch (opcion)
            {
                case "1":
                    tipo = TipoOperacion.Suma;
                    break;
                case "2":
                    tipo = TipoOperacion.Resta;
                    break;
                case "3":
                    tipo = TipoOperacion.Multiplicacion;
                    break;
                case "4":
                    tipo = TipoOperacion.Division;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Se realizará una suma por defecto.");
                    tipo = TipoOperacion.Suma;
                    break;
            }

            // Ejecutar operación y guardar en TXT
            var servicio = new OperacionesService();
            double resultado = servicio.EjecutarOperacion(num1, num2, tipo);

            Console.WriteLine($"El resultado de la operación es: {resultado}");

            // Preguntar si quiere ver historial
            Console.WriteLine("Desea ver el historial de operaciones? (s/n)");
            string verHistorial = Console.ReadLine()?.ToLower();

            if (verHistorial == "s")
            {
                var historialService = new HistorialService();
                var operaciones = historialService.ObtenerHistorial();

                Console.WriteLine("---- Historial de operaciones ----");
                foreach (var op in operaciones)
                {
                    Console.WriteLine($"{op.Numero1} {op.TipoOperacion} {op.Numero2} = {op.Resultado}");
                }
            }

            Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
        }
    }
}

