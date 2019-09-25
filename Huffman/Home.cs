using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            openFileDialog.ShowDialog(this);

            if (openFileDialog.CheckFileExists)
            {
                lblFile.Text = openFileDialog.FileName;

                richTxtBxSource.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void BtnCompact_Click(object sender, EventArgs e)
        {
            // TODO: Realizar Huffman
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            splitContSide.Panel2Collapsed = !splitContSide.Panel2Collapsed;
        }
    }
}
