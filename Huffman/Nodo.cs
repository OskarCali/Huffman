using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    /// <summary>
    /// Definicion de clase Nodo
    /// </summary>
    class Nodo
    {
        public int NodoId { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public int Binario { get; set; }
        public string Codigo { get; set; }

        public Nodo Padre { get; set; }
        public Nodo Derecho { get; set; }
        public Nodo Izquierdo { get; set; }

        /// <summary>
        /// Constructor de nodo (inicial)
        /// </summary>
        /// <param name="id">Id de nodo</param>
        /// <param name="nombre">Nombre del nodo (caracter)</param>
        /// <param name="valor">Valor de nodo (ocurrencia)</param>
        public Nodo(int id, string nombre, int valor)
        {
            NodoId = id;
            Nombre = nombre;
            Valor = valor;
        }

        /// <summary>
        /// Constructor de nodo (padre)
        /// </summary>
        /// <param name="nodoId">Id de nodo</param>
        /// <param name="nombre">Nombre del nodo (compuesto por hijos)</param>
        /// <param name="valor">Valor de nodo (compuesto por hijos)</param>
        /// <param name="derecho">Nodo hijo derecho</param>
        /// <param name="izquierdo">Nodo hijo izquierdo</param>
        public Nodo(int nodoId, string nombre, int valor, Nodo derecho, Nodo izquierdo)
        {
            NodoId = nodoId;
            Nombre = nombre;
            Valor = valor;
            Derecho = derecho;
            Izquierdo = izquierdo;
        }
    }
}
