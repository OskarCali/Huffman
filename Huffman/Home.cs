using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huffman
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            splitContSide.Panel2Collapsed = true;

            radBtnText.Checked = true;
            btnCompact.Enabled = false;
            btnShow.Enabled = false;
        }

        private void RadBtnText_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxSource.ReadOnly = false;
            richTxtBxSource.Text = "";

            btnFile.Enabled = false;
            lblFile.Text = "";
        }

        private void RadBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxSource.ReadOnly = true;
            richTxtBxSource.Text = "";

            btnFile.Enabled = true;
        }

        private void RichTxtBxSource_TextChanged(object sender, EventArgs e)
        {
            if (!richTxtBxSource.Text.Equals(""))
            {
                btnCompact.Enabled = true;
                return;
            }

            btnCompact.Enabled = false;
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            // TODO: Abrir archivo y mostrar texto
        }

        private void BtnCompact_Click(object sender, EventArgs e)
        {
            string text = richTxtBxSource.Text;

            Hashtable caracteres = Cantidad_de_Informacion.analizarTexto(text);
            List<Nodo> arbol = Huffman.crearNodos(caracteres);

            treeGraph.BeginUpdate();
            foreach (var nodo in arbol)
            {
                treeGraph.Nodes.Add(nodo.NodoId.ToString(), nodo.Nombre);
            }
            treeGraph.EndUpdate();
            treeGraph.ExpandAll();

            Huffman.valorCompuesto(arbol);
            Huffman.palabraCodigo(arbol.inicial(caracteres), arbol.FindLast(x => true));

            treeGraph.BeginUpdate();
            treeGraph.Nodes.Clear();
            treeGraph.Nodes.AddRange(arbol.FindLast(x => true).arbolUI(arbol.inicial(caracteres)).ToArray());
            treeGraph.EndUpdate();
            treeGraph.ExpandAll();
            //Huffman.palabraCodigo(arbol.inicial(caracteres));
            //huffman(text);
            btnShow.Enabled = true;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            splitContSide.Panel2Collapsed = !splitContSide.Panel2Collapsed;
            btnShow.Text = splitContSide.Panel2Collapsed ? "MOSTRAR" : "OCULTAR";
        }
    }
}
