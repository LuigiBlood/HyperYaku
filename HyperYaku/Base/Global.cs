using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperYaku.Class;

namespace HyperYaku.Base
{
    internal static partial class Global
    {
        //This is the outside stuff
        public static Project currentProject;

        public static void New()
        {
            currentProject = new Project();
            Manager.PAL.Init();
        }
    }
}
