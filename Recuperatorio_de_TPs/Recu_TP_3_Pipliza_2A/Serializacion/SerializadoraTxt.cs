using System;
using System.IO;

namespace Serializacion
{
    public class SerializadoraTxt<T> : IArchivos<string>
    {
        public bool Guardar(string pathArchivo, string datos)
        {
            bool agrega = false;
            try
            {
                if (pathArchivo != null)
                {
                    using (StreamWriter writer = new StreamWriter(pathArchivo))
                    {
                        writer.WriteLine(datos);
                        writer.WriteLine("-----------------------------------------------------------------------------------");
                        agrega = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return agrega;
        }

        public bool Leer(string pathArchivo, out string datos)
        {
            bool agrega = false;
            datos = default;

            if (File.Exists(pathArchivo) && (!(string.IsNullOrWhiteSpace(pathArchivo))))
            {
                using (StreamReader reader = new StreamReader(pathArchivo))
                {
                    datos = reader.ReadToEnd();
                    agrega = true;
                }
            }
            else
            {
                throw new FileNotFoundException("El archivo especificado no se pudo encontrar");
            }
            return agrega;
        }
    }
}




