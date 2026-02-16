using CalculadoraCapas.Entidades;
using CalculadoraCapas.Datos;

namespace CalculadoraCapas.Negocio
{
    public class OperacionesService
    {
        private readonly OperacionesRepository _repo;

        public OperacionesService()
        {
            _repo = new OperacionesRepository(); // Negocio sabe de Datos
        }

        public double EjecutarOperacion(double num1, double num2, TipoOperacion tipo)
        {
            // Crear la operación usando Factory
            var operacion = FactoryOperaciones.CrearOperacion(tipo);
            double resultado = operacion.Operar(num1, num2);

            // Guardar en repositorio
            var entidad = new Operacion
            {
                Numero1 = num1,
                Numero2 = num2,
                TipoOperacion = tipo.ToString(),
                Resultado = resultado
            };

            _repo.Guardar(entidad);

            return resultado;
        }
    }
}