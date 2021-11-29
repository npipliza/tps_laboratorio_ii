using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serializacion
{
    public class SerializadoraJson<T> : IArchivos<T>
    {

        /// <summary>
        /// Guarda archivo en formato JSON
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string ruta, T datos)
        {
            bool retorno = false;

            try
            {
                if (datos is null)
                {
                    throw new Exception("objeto nulo");
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize( datos, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);
            }
            catch (Exception ex)
            {
                throw new SerializationException(ex.Message);
            }
            return retorno;
        }

        /// <summary>
        /// Lee archivo en formato JSON
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string ruta, out T datos)
        {
           datos = default;
            bool retorno = false;

            try
            {
                string objetoJson = File.ReadAllText(ruta);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                //retorno = objetoDeserealizado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}