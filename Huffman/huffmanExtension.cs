using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Huffman
{
    /// <summary>
    ///     Clase de metodos extendidos para Huffman (List&gt;Nodo&lt;)
    /// </summary>
    internal static class huffmanExtension
    {
        /// <summary>
        ///     Metodo para obtener los nodos sin padre
        /// </summary>
        /// <param name="arbol">Arbol completo</param>
        /// <returns>Lista de nodos sin padre asignado</returns>
        public static List<Nodo> sinPadres(this List<Nodo> arbol)
        {
            var sinPadres = new List<Nodo>();
            foreach (var nodo in arbol)
                if (nodo.Padre == null)
                    sinPadres.Add(nodo);

            return sinPadres;
        }

        /// <summary>
        ///     Metodo para eliminar un nodo de un arbol
        /// </summary>
        /// <param name="arbol">Arbol o Lista de Nodos</param>
        /// <param name="nodo">Nodo a eliminar del arbol o lista</param>
        /// <returns>Arbol o lista sin el nodo</returns>
        public static List<Nodo> quitarNodo(this List<Nodo> arbol, Nodo nodo)
        {
            arbol.Remove(nodo);
            return arbol;
        }

        /// <summary>
        ///     Metodo para obtener los nodos iniciales o analizados
        /// </summary>
        /// <param name="arbol">Arbol completo despues de aplicar valor compuesto</param>
        /// <param name="caracteres">Hashtable con caracteres analizados</param>
        /// <returns>Lista de nodos iniciales o analizados</returns>
        public static List<Nodo> inicial(this List<Nodo> arbol, Hashtable caracteres)
        {
            var iniciales = new List<Nodo>();
            var elements = caracteres.Values.Cast<Element>().ToList();
            var nombreCaracter = new List<string>();

            foreach (var element in elements) nombreCaracter.Add(element.Caracter.ToString());

            foreach (var nodo in arbol)
                if (nombreCaracter.Contains(nodo.Nombre))
                    iniciales.Add(nodo);

            return iniciales;
        }
    }
}