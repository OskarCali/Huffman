using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    static class huffmanExtension
    {
        static List<Nodo> sinPadres(this List<Nodo> arbol)
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
    }
}
