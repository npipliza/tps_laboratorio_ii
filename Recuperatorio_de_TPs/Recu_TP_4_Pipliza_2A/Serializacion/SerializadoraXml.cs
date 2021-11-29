using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    public class SerializadoraXml<T> : IArchivos<T>
    {

        ////USO DE EXCEPCIONES, USO DE ARCHIVOS Y SERIALIZACIÓN, USO DE INTERFACES
        /// <summary>
        /// Guarda archivo en formato XML
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string ruta, T datos)
        {
            bool retorno = false;

            try
            {
                if (!string.IsNullOrWhiteSpace(ruta))
                {
                    XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

                    using (XmlTextWriter newTW = new XmlTextWriter(ruta, Encoding.UTF8))
                    {
                        nuevoXml.Serialize(newTW, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        /// <summary>
        /// Lee archivo en formato XML
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string ruta, out T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

                using (XmlTextReader newTR = new XmlTextReader(ruta))
                {
                    datos = (T)nuevoXml.Deserialize(newTR);
                    retorno = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error al querer Leer el archivo desde el archivo: {ruta}.");
            }
            return retorno;
        }
    }
}
