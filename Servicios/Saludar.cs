using Interfaces.Servicios;

namespace Servicios
{
    public class Saludar : ISaludar
    {
        public string CrearSaludo(string nombre)
        {
            return string.Format("Hola {0}", nombre);
        }
    }
}
