using System;

namespace Entidades
{
    [Serializable]
    public class DepositoP : Mercaderia
    {
        private int tomos;
        public enum Formato
        {
            Bobina,
            Hojas,
        }
        /// <summary>
        /// Propiedad para el enumerado Formato de lectura y escritura
        /// </summary>
        public Formato eFormato
        {
            get; set;
        }
        /// <summary>
        /// Propiedad para el atributo tomos de lectura y escritura. En su setter verifica que no tenga un número negativo y lo settea en 1.
        /// </summary>
        public int Tomos
        {
            get
            {
                return this.tomos;
            }
            set
            {
                if (tomos <= 0)
                {
                    this.tomos = 1;
                }
            }
        }
        /// <summary>
        /// Constructor de defecto para la clase Publicacion
        /// </summary>
        public DepositoP()
        {

        }
        /// <summary>
        /// Constructor para la clase Publicación, llamará a su base en Mercadería
        /// </summary>
        /// <param name="tomos"></param>
        /// <param name="formato"></param>
        /// <param name="titulo"></param>
        /// <param name="edicion"></param>
        /// <param name="editor"></param>
        /// <param name="codigo"></param>
        /// <param name="kg"></param>
        public DepositoP(int tomos, Formato formato, string titulo, int edicion, string editor, string codigo, int kg) : base(titulo, edicion, editor, codigo, kg)
        {
            this.tomos = tomos;
            this.eFormato = formato;
        }
    }
}
