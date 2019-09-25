namespace Huffman
{
    partial class formHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBxHuffman = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCompact = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.radBtnFile = new System.Windows.Forms.RadioButton();
            this.radBtnText = new System.Windows.Forms.RadioButton();
            this.toolStripCont = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblCompact = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContSide = new System.Windows.Forms.SplitContainer();
            this.splitContInfo = new System.Windows.Forms.SplitContainer();
            this.richTxtBxSource = new System.Windows.Forms.RichTextBox();
            this.richTxtBxCompact = new System.Windows.Forms.RichTextBox();
            this.treeGraph = new System.Windows.Forms.TreeView();
            this.richTxtBxResult = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBxHuffman.SuspendLayout();
            this.toolStripCont.BottomToolStripPanel.SuspendLayout();
            this.toolStripCont.ContentPanel.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContSide)).BeginInit();
            this.splitContSide.Panel1.SuspendLayout();
            this.splitContSide.Panel2.SuspendLayout();
            this.splitContSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).BeginInit();
            this.splitContInfo.Panel1.SuspendLayout();
            this.splitContInfo.Panel2.SuspendLayout();
            this.splitContInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1202, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HUFFMAN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxHuffman
            // 
            this.grpBxHuffman.Controls.Add(this.btnShow);
            this.grpBxHuffman.Controls.Add(this.btnCompact);
            this.grpBxHuffman.Controls.Add(this.lblFile);
            this.grpBxHuffman.Controls.Add(this.btnFile);
            this.grpBxHuffman.Controls.Add(this.radBtnFile);
            this.grpBxHuffman.Controls.Add(this.radBtnText);
            this.grpBxHuffman.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxHuffman.Location = new System.Drawing.Point(0, 60);
            this.grpBxHuffman.Name = "grpBxHuffman";
            this.grpBxHuffman.Size = new System.Drawing.Size(1202, 90);
            this.grpBxHuffman.TabIndex = 1;
            this.grpBxHuffman.TabStop = false;
            this.grpBxHuffman.Text = "Huffman";
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(1021, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 40);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "MOSTRAR";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnCompact
            // 
            this.btnCompact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompact.Location = new System.Drawing.Point(808, 29);
            this.btnCompact.Name = "btnCompact";
            this.btnCompact.Size = new System.Drawing.Size(130, 40);
            this.btnCompact.TabIndex = 4;
            this.btnCompact.Text = "COMPACTAR";
            this.btnCompact.UseVisualStyleBackColor = true;
            this.btnCompact.Click += new System.EventHandler(this.BtnCompact_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(514, 39);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(108, 17);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "Nombre archivo";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(367, 29);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 40);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "ARCHIVO";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // radBtnFile
            // 
            this.radBtnFile.AutoSize = true;
            this.radBtnFile.Location = new System.Drawing.Point(131, 39);
            this.radBtnFile.Name = "radBtnFile";
            this.radBtnFile.Size = new System.Drawing.Size(76, 21);
            this.radBtnFile.TabIndex = 1;
            this.radBtnFile.TabStop = true;
            this.radBtnFile.Text = "Archivo";
            this.radBtnFile.UseVisualStyleBackColor = true;
            this.radBtnFile.CheckedChanged += new System.EventHandler(this.RadBtnFile_CheckedChanged);
            // 
            // radBtnText
            // 
            this.radBtnText.AutoSize = true;
            this.radBtnText.Location = new System.Drawing.Point(12, 39);
            this.radBtnText.Name = "radBtnText";
            this.radBtnText.Size = new System.Drawing.Size(64, 21);
            this.radBtnText.TabIndex = 0;
            this.radBtnText.TabStop = true;
            this.radBtnText.Text = "Texto";
            this.radBtnText.UseVisualStyleBackColor = true;
            this.radBtnText.CheckedChanged += new System.EventHandler(this.RadBtnText_CheckedChanged);
            // 
            // toolStripCont
            // 
            // 
            // toolStripCont.BottomToolStripPanel
            // 
            this.toolStripCont.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripCont.ContentPanel
            // 
            this.toolStripCont.ContentPanel.Controls.Add(this.splitContSide);
            this.toolStripCont.ContentPanel.Size = new System.Drawing.Size(1202, 512);
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCont.Location = new System.Drawing.Point(0, 150);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(1202, 563);
            this.toolStripCont.TabIndex = 2;
            this.toolStripCont.Text = "toolStripContainer1";
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblText,
            this.toolStripStatusLblCompact});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1202, 26);
            this.statusStrip.TabIndex = 1;
            // 
            // toolStripStatusLblText
            // 
            this.toolStripStatusLblText.Name = "toolStripStatusLblText";
            this.toolStripStatusLblText.Size = new System.Drawing.Size(1109, 20);
            this.toolStripStatusLblText.Spring = true;
            this.toolStripStatusLblText.Text = "Cantidad texto";
            this.toolStripStatusLblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLblCompact
            // 
            this.toolStripStatusLblCompact.Name = "toolStripStatusLblCompact";
            this.toolStripStatusLblCompact.Size = new System.Drawing.Size(78, 20);
            this.toolStripStatusLblCompact.Text = "Porcentaje";
            // 
            // splitContSide
            // 
            this.splitContSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContSide.Location = new System.Drawing.Point(0, 0);
            this.splitContSide.Name = "splitContSide";
            // 
            // splitContSide.Panel1
            // 
            this.splitContSide.Panel1.Controls.Add(this.splitContInfo);
            this.splitContSide.Panel1MinSize = 850;
            // 
            // splitContSide.Panel2
            // 
            this.splitContSide.Panel2.Controls.Add(this.treeGraph);
            this.splitContSide.Panel2.Controls.Add(this.richTxtBxResult);
            this.splitContSide.Panel2MinSize = 320;
            this.splitContSide.Size = new System.Drawing.Size(1202, 512);
            this.splitContSide.SplitterDistance = 850;
            this.splitContSide.SplitterWidth = 5;
            this.splitContSide.TabIndex = 0;
            // 
            // splitContInfo
            // 
            this.splitContInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContInfo.Name = "splitContInfo";
            this.splitContInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContInfo.Panel1
            // 
            this.splitContInfo.Panel1.Controls.Add(this.richTxtBxSource);
            this.splitContInfo.Panel1MinSize = 250;
            // 
            // splitContInfo.Panel2
            // 
            this.splitContInfo.Panel2.Controls.Add(this.richTxtBxCompact);
            this.splitContInfo.Panel2MinSize = 250;
            this.splitContInfo.Size = new System.Drawing.Size(850, 512);
            this.splitContInfo.SplitterDistance = 250;
            this.splitContInfo.TabIndex = 0;
            // 
            // richTxtBxSource
            // 
            this.richTxtBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxSource.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxSource.Name = "richTxtBxSource";
            this.richTxtBxSource.Size = new System.Drawing.Size(850, 250);
            this.richTxtBxSource.TabIndex = 0;
            this.richTxtBxSource.Text = "";
            this.richTxtBxSource.TextChanged += new System.EventHandler(this.RichTxtBxSource_TextChanged);
            // 
            // richTxtBxCompact
            // 
            this.richTxtBxCompact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxCompact.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxCompact.Name = "richTxtBxCompact";
            this.richTxtBxCompact.ReadOnly = true;
            this.richTxtBxCompact.Size = new System.Drawing.Size(850, 258);
            this.richTxtBxCompact.TabIndex = 0;
            this.richTxtBxCompact.Text = "";
            // 
            // treeGraph
            // 
            this.treeGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGraph.Location = new System.Drawing.Point(0, 0);
            this.treeGraph.Name = "treeGraph";
            this.treeGraph.Size = new System.Drawing.Size(347, 329);
            this.treeGraph.TabIndex = 1;
            // 
            // richTxtBxResult
            // 
            this.richTxtBxResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTxtBxResult.Location = new System.Drawing.Point(0, 329);
            this.richTxtBxResult.Name = "richTxtBxResult";
            this.richTxtBxResult.ReadOnly = true;
            this.richTxtBxResult.Size = new System.Drawing.Size(347, 183);
            this.richTxtBxResult.TabIndex = 0;
            this.richTxtBxResult.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.txt";
            this.openFileDialog.Filter = "Archivo (.txt)|*.txt";
            this.openFileDialog.Title = "Huffman";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 713);
            this.Controls.Add(this.toolStripCont);
            this.Controls.Add(this.grpBxHuffman);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(1220, 760);
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.grpBxHuffman.ResumeLayout(false);
            this.grpBxHuffman.PerformLayout();
            this.toolStripCont.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripCont.BottomToolStripPanel.PerformLayout();
            this.toolStripCont.ContentPanel.ResumeLayout(false);
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContSide.Panel1.ResumeLayout(false);
            this.splitContSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContSide)).EndInit();
            this.splitContSide.ResumeLayout(false);
            this.splitContInfo.Panel1.ResumeLayout(false);
            this.splitContInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).EndInit();
            this.splitContInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBxHuffman;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCompact;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.RadioButton radBtnFile;
        private System.Windows.Forms.RadioButton radBtnText;
        private System.Windows.Forms.ToolStripContainer toolStripCont;
        private System.Windows.Forms.SplitContainer splitContSide;
        private System.Windows.Forms.SplitContainer splitContInfo;
        private System.Windows.Forms.RichTextBox richTxtBxSource;
        private System.Windows.Forms.RichTextBox richTxtBxCompact;
        private System.Windows.Forms.TreeView treeGraph;
        private System.Windows.Forms.RichTextBox richTxtBxResult;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblCompact;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

