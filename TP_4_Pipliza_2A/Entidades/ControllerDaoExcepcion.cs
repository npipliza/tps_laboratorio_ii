using System;

namespace Entidades
{
    public class ControllerDaoExcepcion : Exception
    {
        public ControllerDaoExcepcion(string mensaje) : base(mensaje)
        {

        }
    }
}
