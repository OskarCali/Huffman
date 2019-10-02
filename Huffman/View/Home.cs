using System;
using System.IO;
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
            lblFilename.Text = "";
            toolStripStLblCompact.Text = "";
            toolStripStLblText.Text = "";

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
            lblFilename.Text = "";

            splitContSide.Panel2Collapsed = true;
        }

        private void RadBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxSource.ReadOnly = true;
            richTxtBxSource.Text = "";

            btnFile.Enabled = true;

            splitContSide.Panel2Collapsed = true;
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
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFilename.Text = openFileDialog.FileName;

                richTxtBxSource.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void BtnCompact_Click(object sender, EventArgs e)
        {
            var text = richTxtBxSource.Text;
            var caracteres = Cantidad_de_Informacion.analizarTexto(text);
            var arbol = Huffman.crearNodos(caracteres);

            treeGraph.Nodes.Clear();

            treeGraph.BeginUpdate();
            foreach (var nodo in arbol) treeGraph.Nodes.Add(nodo.NodoId.ToString(), nodo.Nombre);
            treeGraph.EndUpdate();
            treeGraph.ExpandAll();

            Huffman.valorCompuesto(arbol);
            Huffman.palabraCodigo(arbol.inicial(caracteres), arbol.FindLast(x => true));

            treeGraph.BeginUpdate();
            treeGraph.Nodes.Clear();
            treeGraph.Nodes.AddRange(arbol.FindLast(x => true).arbolUI(arbol.inicial(caracteres)).ToArray());
            treeGraph.EndUpdate();
            treeGraph.ExpandAll();

            richTxtBxCompact.Text = Huffman.codigoHuffman(arbol.inicial(caracteres), text);
            richTxtBxResult.Text = Huffman.information(text, richTxtBxCompact.Text);

            toolStripStLblText.Text = text.Length + " caracteres analizados";
            toolStripStLblCompact.Text =
                Huffman.porcentaje(text.Length * 8, richTxtBxCompact.TextLength) + " compactado";

            splitContSide.Panel2Collapsed = false;

            btnShow.Text = "OCULTAR";
            btnShow.Enabled = true;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            splitContSide.Panel2Collapsed = !splitContSide.Panel2Collapsed;
            btnShow.Text = splitContSide.Panel2Collapsed ? "MOSTRAR" : "OCULTAR";
        }

        private void ToolStripStLblAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: Óskar Calí\n\nSeptiembre 2019", "ABOUT", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
    }
}