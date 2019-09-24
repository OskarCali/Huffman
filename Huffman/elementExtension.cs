using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    /// <summary>
    /// Definicion de clase elementExtension para extensiones de la clase ELement
    /// </summary>
    static class elementExtension
    {
        /// <summary>
        /// Metodo actualizar para aumentar el numero de ocurrencias de un elemento
        /// </summary>
        /// <param name="element">Elemento que se actualizara</param>
        /// <returns>Elemento actualizado en concurrencias</returns>
        public static Element actualizar(this Element element)
        {
            element.Ocurrencias += 1;
            return element;
        }
    }
}
