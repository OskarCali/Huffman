using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
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

        public Nodo(int id, string nombre, int valor)
        {
            NodoId = id;
            Nombre = nombre;
            Valor = valor;
        }

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
