using HyperYaku.Base;
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

namespace HyperYaku
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Global.New();
        }

        private void updateTreeViewPRJ()
        {
            bool isNodeSelected = (treeViewPRJ.SelectedNode != null);
            string selected = "";
            if (isNodeSelected)
                selected = treeViewPRJ.SelectedNode.Text;

            //Redo the entire list
            treeViewPRJ.Nodes.Clear();
            foreach (string file in Global.currentProject.FileList())
            {
                int index = treeViewPRJ.Nodes.Add(new TreeNode(Path.GetFileName(file)));
                if (isNodeSelected && selected.Equals(Path.GetFileName(file)))
                {
                    //Keep selection
                    treeViewPRJ.SelectedNode = treeViewPRJ.Nodes[index];
                }
            }

            treeViewPRJ.Focus();
        }

        private void updateComboBoxPALFile()
        {
            //Redo the entire list
            comboBoxPALFile.Items.Clear();
            foreach (string file in Global.currentProject.FileList())
            {
                int index = comboBoxPALFile.Items.Add(Path.GetFileName(file));
            }
        }

        private void updateComboBoxPALFormat()
        {
            //Redo the entire list
            comboBoxPALFormat.Items.Clear();
            foreach (string file in Base.Manager.PAL.lua.GetScriptList())
            {
                int index = comboBoxPALFormat.Items.Add(Path.GetFileName(file));
            }
        }

        private void renderPAL()
        {
            if (comboBoxPALFile.SelectedItem == null) return;
            if (numericUpDownPALOffset.Value < 0) return;
            if (comboBoxPALFormat.SelectedItem == null) return;

            pictureBoxPAL.Image = Base.Manager.PAL.Render((uint)numericUpDownPALOffset.Value);
        }

        private void buttonPRJAdd_Click(object sender, EventArgs e)
        {
            Base.Manager.FileList.AddDialog();
            updateTreeViewPRJ();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabPages.IndexOfKey("tabPagePAL"))
            {
                updateComboBoxPALFile();
                updateComboBoxPALFormat();

                renderPAL();
            }
        }

        private void comboBoxPALFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPALFile.SelectedItem == null) return;
            Base.Manager.PAL.FileLoad(comboBoxPALFile.SelectedIndex);
            numericUpDownPALOffset.Value = 0;
            numericUpDownPALOffset.Maximum = Base.Manager.PAL.FileSize()-1;
            vScrollBarPAL.Maximum = (int)Base.Manager.PAL.FileSize()-1;

            renderPAL();
        }

        private void comboBoxPALFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPALFormat.SelectedItem == null) return;
            Base.Manager.PAL.lua.PrepFile(comboBoxPALFormat.SelectedIndex);
            vScrollBarPAL.LargeChange = (int)Base.Manager.PAL.lua.Size() * 16;

            renderPAL();
        }

        private void numericUpDownPALOffset_ValueChanged(object sender, EventArgs e)
        {
            vScrollBarPAL.Value = (int)numericUpDownPALOffset.Value;
            renderPAL();
        }

        private void vScrollBarPAL_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownPALOffset.Value = vScrollBarPAL.Value;
        }
    }
}
