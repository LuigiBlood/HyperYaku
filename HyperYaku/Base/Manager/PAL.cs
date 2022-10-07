using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using HyperYaku.Class;

namespace HyperYaku.Base.Manager
{
    internal static class PAL
    {
        static string loadedFile;
        static byte[] loadedData;
        public static LuaState lua;

        static public void Init()
        {
            loadedFile = null;
            loadedData = null;
            lua = new LuaState("PAL");
        }

        static public void FileLoad(int index)
        {
            string fileToLoad = Global.currentProject.FileList()[index];
            if (loadedFile == fileToLoad)
                return;

            byte[] load = File.ReadAllBytes(fileToLoad);
            loadedData = load;
            loadedFile = fileToLoad;
        }

        static public uint FileSize()
        {
            if (loadedData == null) return 0;
            return (uint)loadedData.Length;
        }

        static public Color[] Unpack(uint offset)
        {
            Color[] colors = new Color[256];
            for (int i = 0; i < colors.Length; i++)
                colors[i] = Color.Black;

            uint unitSize = lua.Size();

            for (uint i = 0; i < colors.Length; i++)
            {
                uint address = offset + (i * unitSize);
                if ((address + unitSize) < loadedData.Length)
                {
                    byte[] bytes = new byte[unitSize];
                    for (int j = 0; j < unitSize; j++) bytes[j] = loadedData[address + j];
                    byte[] colorInfo = lua.Unpack(bytes);
                    colors[i] = Color.FromArgb(colorInfo[3], colorInfo[0], colorInfo[1], colorInfo[2]);
                }
            }

            return colors;
        }

        static public Bitmap Render(uint offset)
        {
            Bitmap bitmap = new Bitmap(16, 16);
            Color[] colors = Unpack(offset);

            for (int i = 0; i < colors.Length; i++)
            {
                int x = i % 16;
                int y = i / 16;
                bitmap.SetPixel(x, y, colors[i]);
            }

            Bitmap scaledUp = new Bitmap(256, 256);
            using (Graphics g = Graphics.FromImage(scaledUp))
            {
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(bitmap, 0, 0, 256, 256);
            }

            return scaledUp;
        }
    }
}
