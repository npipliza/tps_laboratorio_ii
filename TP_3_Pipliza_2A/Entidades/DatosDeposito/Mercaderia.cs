using System;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(DepositoP))]

    public abstract class Mercaderia
    {
        private string titulo;
        private int edicion;
        private string editor;
        private string codigo;
        private int kg;

        /// <summary>
        ///  Propiedad para el atributo edicion de lectura y escritura
        /// </summary>
        public int Edicion
        {
            get
            {
                return this.edicion;
            }
            set
            {
                this.edicion = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo titulo de lectura y escritura
        /// </summary>
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo editor de lectura y escritura
        /// </summary>
        public string Editor
        {
            get
            {
                return this.editor;
            }
            set
            {
                this.editor = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo código de lectura y escritura
        /// </summary>
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo kg de lectura y escritura
        /// </summary>
        public int Cantidad
        {
            get
            {
                return this.kg;
            }
            set
            {
                if (value < 0)
                    this.kg = 0;
                else
                    this.kg = value;
            }
        }
        /// <summary>
        ///  Constructor de mercadería, establecerá los valores pasados por parámetro.
        /// </summary>
        /// <param name="kg"></param>
        /// <param name="edicion"></param>
        /// <param name="editor"></param>
        /// <param name="codigo"></param>
        public Mercaderia(string titulo, int edicion, string editor, string codigo, int kg)
        {
            this.titulo = titulo;
            this.edicion = edicion;
            this.editor = editor;
            this.codigo = codigo;
            this.kg = kg;
        }
        /// <summary>
        /// Constructor de defecto para la clase Mercadería
        /// </summary>
        public Mercaderia()
        {
        }
    }
}