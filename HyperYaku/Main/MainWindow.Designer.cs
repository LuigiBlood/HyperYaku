namespace HyperYaku
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePRJ = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPRJReplace = new System.Windows.Forms.Button();
            this.buttonPRJRemove = new System.Windows.Forms.Button();
            this.buttonPRJAdd = new System.Windows.Forms.Button();
            this.treeViewPRJ = new System.Windows.Forms.TreeView();
            this.tabPageBKM = new System.Windows.Forms.TabPage();
            this.treeViewBKM = new System.Windows.Forms.TreeView();
            this.tabPagePAL = new System.Windows.Forms.TabPage();
            this.vScrollBarPAL = new System.Windows.Forms.VScrollBar();
            this.buttonPALBookmark = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPALOffset = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPALCmp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPALFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPALFile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPAL = new System.Windows.Forms.PictureBox();
            this.tabPageCHR = new System.Windows.Forms.TabPage();
            this.tabPageMAP = new System.Windows.Forms.TabPage();
            this.tabPageARRC = new System.Windows.Forms.TabPage();
            this.tabPageARRP = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePRJ.SuspendLayout();
            this.tabPageBKM.SuspendLayout();
            this.tabPagePAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPALOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPAL)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.saveAsProjectToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newProjectToolStripMenuItem.Text = "New Project...";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project...";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // saveAsProjectToolStripMenuItem
            // 
            this.saveAsProjectToolStripMenuItem.Name = "saveAsProjectToolStripMenuItem";
            this.saveAsProjectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveAsProjectToolStripMenuItem.Text = "Save as Project...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePRJ);
            this.tabControl1.Controls.Add(this.tabPageBKM);
            this.tabControl1.Controls.Add(this.tabPagePAL);
            this.tabControl1.Controls.Add(this.tabPageCHR);
            this.tabControl1.Controls.Add(this.tabPageMAP);
            this.tabControl1.Controls.Add(this.tabPageARRC);
            this.tabControl1.Controls.Add(this.tabPageARRP);
            this.tabControl1.Location = new System.Drawing.Point(3, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 398);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPagePRJ
            // 
            this.tabPagePRJ.Controls.Add(this.label5);
            this.tabPagePRJ.Controls.Add(this.buttonPRJReplace);
            this.tabPagePRJ.Controls.Add(this.buttonPRJRemove);
            this.tabPagePRJ.Controls.Add(this.buttonPRJAdd);
            this.tabPagePRJ.Controls.Add(this.treeViewPRJ);
            this.tabPagePRJ.Location = new System.Drawing.Point(4, 22);
            this.tabPagePRJ.Name = "tabPagePRJ";
            this.tabPagePRJ.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePRJ.Size = new System.Drawing.Size(788, 372);
            this.tabPagePRJ.TabIndex = 0;
            this.tabPagePRJ.Text = "Project";
            this.tabPagePRJ.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "File List:";
            // 
            // buttonPRJReplace
            // 
            this.buttonPRJReplace.Location = new System.Drawing.Point(305, 114);
            this.buttonPRJReplace.Name = "buttonPRJReplace";
            this.buttonPRJReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonPRJReplace.TabIndex = 3;
            this.buttonPRJReplace.Text = "Replace File";
            this.buttonPRJReplace.UseVisualStyleBackColor = true;
            // 
            // buttonPRJRemove
            // 
            this.buttonPRJRemove.Location = new System.Drawing.Point(305, 73);
            this.buttonPRJRemove.Name = "buttonPRJRemove";
            this.buttonPRJRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonPRJRemove.TabIndex = 2;
            this.buttonPRJRemove.Text = "Remove File";
            this.buttonPRJRemove.UseVisualStyleBackColor = true;
            // 
            // buttonPRJAdd
            // 
            this.buttonPRJAdd.Location = new System.Drawing.Point(305, 32);
            this.buttonPRJAdd.Name = "buttonPRJAdd";
            this.buttonPRJAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonPRJAdd.TabIndex = 1;
            this.buttonPRJAdd.Text = "Add File(s)";
            this.buttonPRJAdd.UseVisualStyleBackColor = true;
            this.buttonPRJAdd.Click += new System.EventHandler(this.buttonPRJAdd_Click);
            // 
            // treeViewPRJ
            // 
            this.treeViewPRJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewPRJ.Location = new System.Drawing.Point(6, 26);
            this.treeViewPRJ.Name = "treeViewPRJ";
            this.treeViewPRJ.Size = new System.Drawing.Size(232, 340);
            this.treeViewPRJ.TabIndex = 0;
            // 
            // tabPageBKM
            // 
            this.tabPageBKM.Controls.Add(this.treeViewBKM);
            this.tabPageBKM.Location = new System.Drawing.Point(4, 22);
            this.tabPageBKM.Name = "tabPageBKM";
            this.tabPageBKM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBKM.Size = new System.Drawing.Size(788, 372);
            this.tabPageBKM.TabIndex = 1;
            this.tabPageBKM.Text = "Bookmarks";
            this.tabPageBKM.UseVisualStyleBackColor = true;
            // 
            // treeViewBKM
            // 
            this.treeViewBKM.Location = new System.Drawing.Point(5, 6);
            this.treeViewBKM.Name = "treeViewBKM";
            this.treeViewBKM.Size = new System.Drawing.Size(273, 360);
            this.treeViewBKM.TabIndex = 0;
            // 
            // tabPagePAL
            // 
            this.tabPagePAL.Controls.Add(this.vScrollBarPAL);
            this.tabPagePAL.Controls.Add(this.buttonPALBookmark);
            this.tabPagePAL.Controls.Add(this.label4);
            this.tabPagePAL.Controls.Add(this.numericUpDownPALOffset);
            this.tabPagePAL.Controls.Add(this.comboBoxPALCmp);
            this.tabPagePAL.Controls.Add(this.label3);
            this.tabPagePAL.Controls.Add(this.comboBoxPALFormat);
            this.tabPagePAL.Controls.Add(this.label2);
            this.tabPagePAL.Controls.Add(this.comboBoxPALFile);
            this.tabPagePAL.Controls.Add(this.label1);
            this.tabPagePAL.Controls.Add(this.pictureBoxPAL);
            this.tabPagePAL.Location = new System.Drawing.Point(4, 22);
            this.tabPagePAL.Name = "tabPagePAL";
            this.tabPagePAL.Size = new System.Drawing.Size(788, 372);
            this.tabPagePAL.TabIndex = 2;
            this.tabPagePAL.Text = "Palette";
            this.tabPagePAL.UseVisualStyleBackColor = true;
            // 
            // vScrollBarPAL
            // 
            this.vScrollBarPAL.Location = new System.Drawing.Point(282, 68);
            this.vScrollBarPAL.Name = "vScrollBarPAL";
            this.vScrollBarPAL.Size = new System.Drawing.Size(17, 256);
            this.vScrollBarPAL.TabIndex = 10;
            this.vScrollBarPAL.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarPAL_Scroll);
            // 
            // buttonPALBookmark
            // 
            this.buttonPALBookmark.Location = new System.Drawing.Point(308, 157);
            this.buttonPALBookmark.Name = "buttonPALBookmark";
            this.buttonPALBookmark.Size = new System.Drawing.Size(129, 23);
            this.buttonPALBookmark.TabIndex = 9;
            this.buttonPALBookmark.Text = "Add Bookmark";
            this.buttonPALBookmark.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Offset:";
            // 
            // numericUpDownPALOffset
            // 
            this.numericUpDownPALOffset.Hexadecimal = true;
            this.numericUpDownPALOffset.Location = new System.Drawing.Point(308, 29);
            this.numericUpDownPALOffset.Name = "numericUpDownPALOffset";
            this.numericUpDownPALOffset.Size = new System.Drawing.Size(129, 20);
            this.numericUpDownPALOffset.TabIndex = 7;
            this.numericUpDownPALOffset.ValueChanged += new System.EventHandler(this.numericUpDownPALOffset_ValueChanged);
            // 
            // comboBoxPALCmp
            // 
            this.comboBoxPALCmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPALCmp.FormattingEnabled = true;
            this.comboBoxPALCmp.Location = new System.Drawing.Point(308, 108);
            this.comboBoxPALCmp.Name = "comboBoxPALCmp";
            this.comboBoxPALCmp.Size = new System.Drawing.Size(129, 21);
            this.comboBoxPALCmp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compression:";
            // 
            // comboBoxPALFormat
            // 
            this.comboBoxPALFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPALFormat.FormattingEnabled = true;
            this.comboBoxPALFormat.Location = new System.Drawing.Point(308, 68);
            this.comboBoxPALFormat.Name = "comboBoxPALFormat";
            this.comboBoxPALFormat.Size = new System.Drawing.Size(129, 21);
            this.comboBoxPALFormat.TabIndex = 4;
            this.comboBoxPALFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxPALFormat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Format:";
            // 
            // comboBoxPALFile
            // 
            this.comboBoxPALFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPALFile.FormattingEnabled = true;
            this.comboBoxPALFile.Location = new System.Drawing.Point(26, 29);
            this.comboBoxPALFile.Name = "comboBoxPALFile";
            this.comboBoxPALFile.Size = new System.Drawing.Size(273, 21);
            this.comboBoxPALFile.TabIndex = 2;
            this.comboBoxPALFile.SelectedIndexChanged += new System.EventHandler(this.comboBoxPALFile_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // pictureBoxPAL
            // 
            this.pictureBoxPAL.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPAL.Location = new System.Drawing.Point(26, 68);
            this.pictureBoxPAL.Name = "pictureBoxPAL";
            this.pictureBoxPAL.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxPAL.TabIndex = 0;
            this.pictureBoxPAL.TabStop = false;
            // 
            // tabPageCHR
            // 
            this.tabPageCHR.Location = new System.Drawing.Point(4, 22);
            this.tabPageCHR.Name = "tabPageCHR";
            this.tabPageCHR.Size = new System.Drawing.Size(788, 372);
            this.tabPageCHR.TabIndex = 3;
            this.tabPageCHR.Text = "Tiles";
            this.tabPageCHR.UseVisualStyleBackColor = true;
            // 
            // tabPageMAP
            // 
            this.tabPageMAP.Location = new System.Drawing.Point(4, 22);
            this.tabPageMAP.Name = "tabPageMAP";
            this.tabPageMAP.Size = new System.Drawing.Size(788, 372);
            this.tabPageMAP.TabIndex = 4;
            this.tabPageMAP.Text = "Map";
            this.tabPageMAP.UseVisualStyleBackColor = true;
            // 
            // tabPageARRC
            // 
            this.tabPageARRC.Location = new System.Drawing.Point(4, 22);
            this.tabPageARRC.Name = "tabPageARRC";
            this.tabPageARRC.Size = new System.Drawing.Size(788, 372);
            this.tabPageARRC.TabIndex = 5;
            this.tabPageARRC.Text = "Tile Arrangement";
            this.tabPageARRC.UseVisualStyleBackColor = true;
            // 
            // tabPageARRP
            // 
            this.tabPageARRP.Location = new System.Drawing.Point(4, 22);
            this.tabPageARRP.Name = "tabPageARRP";
            this.tabPageARRP.Size = new System.Drawing.Size(788, 372);
            this.tabPageARRP.TabIndex = 6;
            this.tabPageARRP.Text = "Palette Arrangement";
            this.tabPageARRP.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "HyperYaku";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePRJ.ResumeLayout(false);
            this.tabPagePRJ.PerformLayout();
            this.tabPageBKM.ResumeLayout(false);
            this.tabPagePAL.ResumeLayout(false);
            this.tabPagePAL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPALOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPAL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePRJ;
        private System.Windows.Forms.TabPage tabPageBKM;
        private System.Windows.Forms.TabPage tabPagePAL;
        private System.Windows.Forms.TabPage tabPageCHR;
        private System.Windows.Forms.TabPage tabPageMAP;
        private System.Windows.Forms.TabPage tabPageARRC;
        private System.Windows.Forms.TreeView treeViewPRJ;
        private System.Windows.Forms.VScrollBar vScrollBarPAL;
        private System.Windows.Forms.Button buttonPALBookmark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPALOffset;
        private System.Windows.Forms.ComboBox comboBoxPALCmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPALFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPALFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPAL;
        private System.Windows.Forms.Button buttonPRJReplace;
        private System.Windows.Forms.Button buttonPRJRemove;
        private System.Windows.Forms.Button buttonPRJAdd;
        private System.Windows.Forms.TreeView treeViewBKM;
        private System.Windows.Forms.TabPage tabPageARRP;
        private System.Windows.Forms.Label label5;
    }
}

