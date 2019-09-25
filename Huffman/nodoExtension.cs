using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    /// <summary>
    /// Clase de metodos extendidos para un Nodo
    /// </summary>
    static class nodoExtension
    {
        /// <summary>
        /// Metodo para armar la palabra codigo de un nodo
        /// </summary>
        /// <param name="nodo">Nodo inicial para obtener palabra codigo</param>
        /// <param name="root">Nodo root o final para armar la palabra codigo</param>
        /// <returns>Palabra codigo</returns>
        public static string codigo(this Nodo nodo, Nodo root)
        {
            string code = "";

            if (nodo.Padre != null)
            {
                code += nodo.Padre.codigo(root);
            }

            if (nodo != root)
            {
                code += nodo.Binario;
            }

            return code;
        }
    }
}
