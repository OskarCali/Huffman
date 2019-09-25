using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huffman
{
    /// <summary>
    /// Clase de metodos extendidos para un Nodo
    /// </summary>
    static class nodoExtension
    {
        /// <summary>
        /// Metodo para armar la palabra codigo de un nodo
        /// </summary>
        /// <param name="nodo">Nodo inicial para obtener palabra codigo</param>
        /// <param name="root">Nodo root o final para armar la palabra codigo</param>
        /// <returns>Palabra codigo</returns>
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

        /// <summary>
        /// Metodo para crear arbol para la UI
        /// </summary>
        /// <param name="nodo">Nodo root o donde se inicia a aconstruir el arbol</param>
        /// <param name="iniciales">Lista de nodos iniciales</param>
        /// <returns>Lista de nodos para el arbol visual de la UI</returns>
        public static List<TreeNode> arbolUI(this Nodo nodo, List<Nodo> iniciales)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            List<TreeNode> childs = new List<TreeNode>();
            TreeNode treeNode;

            // Creacion del nodo segun su tipo
            if (iniciales.Contains(nodo))
            {
                treeNode = new TreeNode(nodo.Nombre + " - " + nodo.Codigo);
            }
            else
            {
                treeNode = new TreeNode(nodo.Nombre);
            }

            // Verificar si tiene camino a la izquierda
            if (nodo.Izquierdo != null)
            {
                childs = nodo.Izquierdo.arbolUI(iniciales);
                treeNode.Nodes.AddRange(childs.ToArray());
            }

            // Verificar si tiene camino a la derecha
            if (nodo.Derecho != null)
            {
                childs = nodo.Derecho.arbolUI(iniciales);
                treeNode.Nodes.AddRange(childs.ToArray());
            }

            treeNodes.Add(treeNode);

            return treeNodes;
        }

    }
}
