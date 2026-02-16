using System;
using CalculadoraCapas.Entidades;
using CalculadoraCapas.Datos;
namespace CalculadoraCapas.Negocio
{
    public class HistorialService
    {
        private readonly IOperacionesRepository _repository;

        public HistorialService()
        {
            _repository = new OperacionesRepository(); 
        }

        public List<Operacion> ObtenerHistorial()
        {
            return _repository.ObtenerOperaciones();
        }
    }
}