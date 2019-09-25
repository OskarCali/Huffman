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
        /// <summary>
        /// Creacion de los nodos base con los caracteres analizados
        /// </summary>
        /// <param name="caracteres">Tabla hash recuperada de la cantidad de informacion</param>
        /// <returns>Arbol ordenado por numero de ocurrencia y al mismo tiempo por aparicion del caracter</returns>
        public static List<Nodo> crearNodos(Hashtable caracteres)
        {
            List<Nodo> arbol = new List<Nodo>();

            foreach (DictionaryEntry entry in caracteres)
            {
                // Obtiene el elemento analizado para crear el nodo
                Element element = entry.Value as Element;
                arbol.Add(new Nodo((int)entry.Key, element.Caracter.ToString(), element.Ocurrencias));
            }

            // Ordena por aparicion y despues por valor
            return arbol.OrderBy(x => x.NodoId).OrderByDescending(x => x.Valor).ToList();
        }

        /// <summary>
        /// Creacion de padres con valor compuesto para definir el arbol
        /// </summary>
        /// <param name="arbol">Arbol inicial con solo nodos iniciales</param>
        public static void valorCompuesto(List<Nodo> arbol)
        {
            // Siempre que se tengan mas de 1 nodo sin padre
            while (arbol.sinPadres().Count > 1)
            {
                // Obtiene los nodos del arbol que no tienen padre asignado
                List<Nodo> sinPadres = arbol.sinPadres();
                Nodo der = null;
                Nodo izq = null;

                // Solamente cuando no queden 2 nodos sin padre
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

                    // De los nodos sin padre eliminamos al que ya fue seleccionado
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
                    // Evaluacion diferente para nodo root
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

                // Definicion del valor binario para el camino
                der.Binario = 0;
                izq.Binario = 1;

                // Creacion de nodo padre y asignacion de padre para los hijos seleccionados
                Nodo padre = new Nodo((arbol.Count + 1), der.Valor.ToString() + izq.Valor.ToString(), (der.Valor + izq.Valor), der, izq);
                arbol.FirstOrDefault(x => x == der).Padre = padre;
                arbol.FirstOrDefault(x => x == izq).Padre = padre;
                arbol.Add(padre);
            }
        }

        /// <summary>
        /// Condigo para crear la palabra codigo siguiendo el camino del valor compuesto
        /// </summary>
        /// <param name="iniciales">Nodos iniciales (caracteres analizados)</param>
        /// <param name="root">Nodo root o final inicio del arbol</param>
        public static void palabraCodigo(List<Nodo> iniciales, Nodo root)
        {
            foreach (var nodo in iniciales)
            {
                nodo.Codigo = nodo.codigo(root);
            }
        }

        /// <summary>
        /// Metodo para imprimir el codigo final de Huffman
        /// </summary>
        /// <param name="iniciales">Nodos iniciales que tienen su palabra codigo</param>
        /// <param name="texto">Texto que se compacta</param>
        /// <returns>Texto compactado (codigo)</returns>
        public static string codigoHuffman(List<Nodo> iniciales, string texto)
        {
            string codigo = "";

            foreach (var caracter in texto)
            {
                foreach (var nodo in iniciales)
                {
                    if (caracter.ToString() == nodo.Nombre)
                    {
                        codigo += nodo.Codigo;
                        break;
                    }
                }
            }

            return codigo;
        }
    }
}
