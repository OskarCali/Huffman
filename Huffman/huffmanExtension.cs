using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    /// <summary>
    /// Clase de metodos extendidos para Huffman (List&gt;Nodo&lt;)
    /// </summary>
    static class huffmanExtension
    {
        /// <summary>
        /// Metodo para obtener los nodos sin padre
        /// </summary>
        /// <param name="arbol">Arbol completo</param>
        /// <returns>Lista de nodos sin padre asignado</returns>
        public static List<Nodo> sinPadres(this List<Nodo> arbol)
        {
            List<Nodo> sinPadres = new List<Nodo>();
            foreach (var nodo in arbol)
            {
                if (nodo.Padre == null)
                {
                    sinPadres.Add(nodo);
                }
            }

            return sinPadres;
        }

        /// <summary>
        /// Metodo para eliminar un nodo de un arbol
        /// </summary>
        /// <param name="arbol">Arbol o Lista de Nodos</param>
        /// <param name="nodo">Nodo a eliminar del arbol o lista</param>
        /// <returns>Arbol o lista sin el nodo</returns>
        public static List<Nodo> quitarNodo(this List<Nodo> arbol, Nodo nodo)
        {
            arbol.Remove(nodo);
            return arbol;
        }

    }
}
