using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    /// <summary>
    /// Descripcion de la clase de Cantidad de Informacion
    /// </summary>
    class Cantidad_de_Informacion
    {
        /// <summary>
        /// Metodo analizarTexto de la clase Cantidad de Informacion
        /// </summary>
        /// <param name="text">Es el texto que se analizara para determinar la cantidad de informacion</param>
        /// <returns>Hashtable con la informacion analizada del texto</returns>
        public static Hashtable analizarTexto(string text)
        {
            // Numero de orden de ocurrencia del elemento en el texto
            int num = 1;
            Hashtable hashtable = new Hashtable();
            List<char> chars = new List<char>();

            foreach (var caracter in text)
            {
                // Obtiene los elementos que ya fueron analizados
                List<Element> elements = hashtable.Values.Cast<Element>().ToList();

                if (elements.Count != 0)
                {
                    if (!chars.Contains(caracter))
                    {
                        // Crea un nuevo elemento analizado y aumenta el orden aparicion en el texto
                        hashtable.Add(num, new Element() { Caracter = caracter, Ocurrencias = 1 });
                        chars.Add(caracter);
                        num += 1;
                    }
                    else
                    {
                        // Busca el elemento que ya fue analizada
                        Element element = elements.FirstOrDefault(x => x.Caracter == caracter);
                        foreach (DictionaryEntry entry in hashtable)
                        {
                            // Busca su elemento para actualizar el numero de ocurrencia dentro del texto
                            if (element == entry.Value)
                            {
                                // Actualiza el elemento analizado
                                hashtable[entry.Key] = element.actualizar();
                                break;
                            }
                        }
                    }
                }
                else
                {
                    // Crea el elemento del primer caracter (unica ejecucion)
                    hashtable.Add(num, new Element() { Caracter = caracter, Ocurrencias = 1 });
                    chars.Add(caracter);
                    num += 1;
                }
            }

            // Regresa el analisis del texto
            return hashtable;
        }
    }
}
