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

        void valorCompuesto(List<Nodo> arbol)
        {
            while (arbol.sinPadres().Count > 1)
            {
                List<Nodo> sinPadres = arbol.sinPadres();
                Nodo der = null;
                Nodo izq = null;

                if (sinPadres.Count != 2)
                {
                    der = sinPadres.FindLast(x => true);

                    for (int i = (sinPadres.Count - 1); i >= 0; i--)
                    {
                        if (sinPadres[i].Valor < der.Valor)
                        {
                            der = sinPadres[i];
                        }
                    }

                    List<Nodo> sinSeleccionar = arbol.sinPadres().quitarNodo(der);
                    izq = sinSeleccionar.FindLast(x => true);

                    for (int i = (sinSeleccionar.Count - 1); i >= 0; i--)
                    {
                        if (sinSeleccionar[i].Valor < izq.Valor)
                        {
                            izq = sinSeleccionar[i];
                        }
                    }
                }
                else
                {
                    if (sinPadres[0].Valor > sinPadres[1].Valor)
                    {
                        izq = sinPadres[0];
                        der = sinPadres[1];
                    }
                    else
                    {
                        izq = sinPadres[1];
                        der = sinPadres[0];
                    }
                }

                der.Binario = 0;
                izq.Binario = 1;

                Nodo padre = new Nodo((arbol.Count + 1), der.Valor.ToString() + izq.Valor.ToString(), (der.Valor + izq.Valor), der, izq);
                arbol.FirstOrDefault(x => x == der).Padre = padre;
                arbol.FirstOrDefault(x => x == izq).Padre = padre;
                arbol.Add(padre);
            }
        }
        void palabraCodigo(List<Nodo> iniciales, Nodo root)
        {
            foreach (var nodo in iniciales)
            {
                nodo.Codigo = nodo.codigo(root);
            }
        }
    }
}
