using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    static class huffmanExtension
    {
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
        public static List<Nodo> quitarNodo(this List<Nodo> arbol, Nodo der)
        {
            arbol.Remove(der);
            return arbol;
        }

    }
}
