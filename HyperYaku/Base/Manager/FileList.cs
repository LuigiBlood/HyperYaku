using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperYaku.Base;

namespace HyperYaku.Base.Manager
{
    internal static class FileList
    {
        public static void AddDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files|*.*";
            openFileDialog.Title = "Add File(s) to Project...";
            openFileDialog.Multiselect = true;
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    Global.currentProject.FileAdd(file);
                }
            }
        }
    }
}
