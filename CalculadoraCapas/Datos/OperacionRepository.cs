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

        public List<Operacion> ObtenerOperaciones()
        {
            
            var lista = new List<Operacion>();
            if(!File.Exists(_archivo)) return lista;


            return lista;

        }


    }

}