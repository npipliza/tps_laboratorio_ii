
namespace Serializacion
{
    interface IArchivos<T>
    {
        bool Guardar(string archivo, T datos);
        bool Leer(string archivo, out T datos);
    }
}
