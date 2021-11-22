using System;
using System.Text;
using System.Text.Json;

namespace Serializacion
{
    //public class SerializadoraJson<T> : IArchivos<T>
    //{

    //    /// <summary>
    //    /// Guarda archivo en formato JSON
    //    /// </summary>
    //    /// <param name="ruta"></param>
    //    /// <param name="datos"></param>
    //    /// <returns></returns>
    //    public bool Guardar(string ruta, T datos)
    //    {
    //        bool retorno = false;

    //        try
    //        {
    //            if (!string.IsNullOrWhiteSpace(ruta))
    //            {
    //                JsonSerializer nuevoJson = new JsonSerializer(typeof(T));

    //                using (JsonSerializer newTW = new JsonSerializer(ruta, Encoding.UTF8))
    //                {
    //                    nuevoJson.Serialize(newTW, datos);
    //                    retorno = true;
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            throw e;
    //        }
    //        return retorno;
    //    }

    //    /// <summary>
    //    /// Lee archivo en formato JSON
    //    /// </summary>
    //    /// <param name="ruta"></param>
    //    /// <param name="datos"></param>
    //    /// <returns></returns>
    //    public bool Leer(string ruta, out T datos)
    //    {
    //        bool retorno = false;

    //        try
    //        {
    //            //JsonSerializer nuevoJson = new JsonSerializer(typeof(T));

    //            //using (JsonSerializer newTR = new JsonSerializer(ruta))
    //            //{
    //            //    datos = (T)nuevoJson.Deserialize(newTR);
    //            //    retorno = true;
    //            //}

    //        }
    //        catch (Exception e)
    //        {
    //            throw new Exception($"Error al querer Leer el archivo desde el archivo: {ruta}.");
    //        }
    //        return retorno;
    //    }
    //}
}