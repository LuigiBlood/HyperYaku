using NLua;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperYaku.Class
{
    internal class LuaState
    {
        private Lua state;
        private string type;
        private string[] files;

        private uint size;

        public LuaState(string type)
        {
            this.type = type;
            files = DoScriptList();
            InitLuaState();
        }

        private void InitLuaState()
        {
            this.state = new Lua();

            //Sandbox
            this.state.DoString("import = function() end");
        }

        private string[] DoScriptList()
        {
            List<string> list = new List<string>();

            string LuaDir = ".\\Lua\\" + type;

            if (Directory.Exists(LuaDir))
            {
                string[] LuaFiles = Directory.GetFiles(LuaDir);
                foreach (string LuaFile in LuaFiles)
                {
                    if (Path.GetExtension(LuaFile) == ".lua")
                        list.Add(LuaFile);
                }
            }

            return list.ToArray();
        }

        public string[] GetScriptList()
        {
            return files;
        }

        public void PrepFile(int index)
        {
            InitLuaState();
            state.DoFile(files[index]);

            LuaFunction sizeFunc = state.GetFunction("size");
            var test = sizeFunc.Call();
            size = Convert.ToUInt32(test[0]);
        }

        public uint Size()
        {
            return size;
        }

        public byte[] Unpack(byte[] data)
        {
            LuaFunction func = state.GetFunction("unpack");
            LuaTable ret = (LuaTable)func.Call(data).First();

            List<byte> bytes = new List<byte>();
            foreach (var byteInfo in ret.Values)
            {
                bytes.Add(Convert.ToByte(byteInfo));
            }

            return bytes.ToArray();
        }

        public byte[] Repack(byte[] data)
        {
            LuaFunction func = state.GetFunction("repack");
            LuaTable ret = (LuaTable)func.Call(data).First();

            List<byte> bytes = new List<byte>();
            foreach (var byteInfo in ret.Values)
            {
                bytes.Add(Convert.ToByte(byteInfo));
            }

            return bytes.ToArray();
        }
    }
}
