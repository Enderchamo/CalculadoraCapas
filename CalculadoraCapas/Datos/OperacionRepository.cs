using System;
using CalculadoraCapas.Entidades;
using CalculadoraCapas.Negocio;


namespace CalculadoraCapas.Datos{
    

        public class OperacionesRepository : IOperacionesRepository
    {
        
        private readonly string _archivo= "historial.txt";

        public void Guardar(Operacion operacion)
        {
            
            string linea = $"{operacion.Numero1} {operacion.TipoOperacion} {operacion.Numero2} = {operacion.Resultado}";
            System.IO.File.AppendAllText(_archivo, linea + Environment.NewLine);    
        }

        // Obtener todas las operaciones (lista de objetos)
        public List<Operacion> ObtenerOperaciones()
        {
            var lista = new List<Operacion>();

            if (!File.Exists(_archivo)) 
                return lista;

            foreach (var linea in File.ReadAllLines(_archivo))
            {
                
                var partes = linea.Split(' '); 
                if (partes.Length >= 5)
                {
                    // Convertir números
                    if (double.TryParse(partes[0], out double num1) &&
                        double.TryParse(partes[2], out double num2) &&
                        double.TryParse(partes[4], out double resultado))
                    {
                        lista.Add(new Operacion
                        {
                            Numero1 = num1,
                            TipoOperacion = partes[1],
                            Numero2 = num2,
                            Resultado = resultado
                        });
                    }
                }
            }

            return lista;
        }
    }
}


    

