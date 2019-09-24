using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class Huffman
    {
        List<Nodo> crearNodos(Hashtable caracteres)
        {
            List<Nodo> arbol = new List<Nodo>();

            foreach (DictionaryEntry entry in caracteres)
            {
                Element element = entry.Value as Element;
                arbol.Add(new Nodo((int)entry.Key, element.Caracter.ToString(), element.Ocurrencias));
            }

            return arbol.OrderBy(x => x.NodoId).OrderByDescending(x => x.Valor).ToList();
        }
    }
}
