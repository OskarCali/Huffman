using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    /// <summary>
    /// Definicion de la clase Element para la Cantidad de Informacion
    /// </summary>
    class Element
    {
        // Representa el caracter del analisis de la Cantidad de Informacion
        public char Caracter { get; set; }
        // Representa el numero de ocurrencias que tiene el caracter.
        public int Ocurrencias { get; set; }
    }
}
