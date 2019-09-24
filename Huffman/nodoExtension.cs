using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    static class nodoExtension
    {
        public static string codigo(this Nodo nodo, Nodo root)
        {
            string code = "";

            if (nodo.Padre != null)
            {
                code += nodo.Padre.codigo(root);
            }

            if (nodo != root)
            {
                code += nodo.Binario;
            }

            return code;
        }
    }
}
