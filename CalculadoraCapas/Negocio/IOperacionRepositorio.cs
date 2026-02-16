using System;
using System.Collections.Generic;
using CalculadoraCapas.Entidades;


namespace CalculadoraCapas.Negocio
{
    public interface IOperacionesRepository
    {
        
        void Guardar(Operacion operacion);
        List<Operacion> ObtenerOperaciones();

    }
}