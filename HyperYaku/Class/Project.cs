using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace HyperYaku.Class
{
    internal class Project
    {
        struct Bookmark
        {
            public string Filename;
            public string Format;
            public uint Offset;
            public uint Size;
            public string LuaFmt;
            public string LuaCmp;
        }

        struct Arrangement
        {
            public string Bookmark;
            public int Offset;
            public uint VOffset;
            public uint VSize;
        }

        List<string> files;
        Dictionary<string, Dictionary<string, Bookmark>> bookmarks;
        Dictionary<string, Dictionary<string, List<Arrangement>>> arrangements;

        public Project()
        {
            files = new List<string>();
            bookmarks = new Dictionary<string, Dictionary<string, Bookmark>>();
            arrangements = new Dictionary<string, Dictionary<string, List<Arrangement>>>();

            bookmarks.Add("PAL", new Dictionary<string, Bookmark>());
            bookmarks.Add("CHR", new Dictionary<string, Bookmark>());
            bookmarks.Add("MAP", new Dictionary<string, Bookmark>());

            arrangements.Add("PAL", new Dictionary<string, List<Arrangement>>());
            arrangements.Add("CHR", new Dictionary<string, List<Arrangement>>());
        }

        public void Load(XmlDocument xml)
        {

        }

        public void Save(out XmlDocument xml)
        {
            xml = new XmlDocument();
            XmlElement rootElement = xml.CreateElement("project");
            rootElement.SetAttribute("software", "hyperyaku");
            rootElement.SetAttribute("version", "1");

            //Files
            XmlElement filesElement = xml.CreateElement("files");
            foreach (string file in files)
            {
                XmlElement fileInfo = xml.CreateElement("file");
                fileInfo.SetAttribute("name", file);
                filesElement.AppendChild(fileInfo);
            }
            rootElement.AppendChild(filesElement);

            //Bookmarks
            XmlElement bookmarkElement = xml.CreateElement("bookmark");
            foreach (string category in bookmarks.Keys)
            {
                XmlElement categoryElement = xml.CreateElement("category");
                categoryElement.SetAttribute("name", category);
                foreach (string item in bookmarks[category].Keys)
                {
                    XmlElement itemElement = xml.CreateElement("item");
                    itemElement.SetAttribute("name", item);
                    itemElement.SetAttribute("file", bookmarks[category][item].Filename);
                    itemElement.SetAttribute("offset", bookmarks[category][item].Offset.ToString());
                    itemElement.SetAttribute("size", bookmarks[category][item].Size.ToString());
                    itemElement.SetAttribute("luaformat", bookmarks[category][item].LuaFmt);
                    itemElement.SetAttribute("luacompression", bookmarks[category][item].LuaCmp);
                    categoryElement.AppendChild(itemElement);
                }
                bookmarkElement.AppendChild(categoryElement);
            }
            rootElement.AppendChild(bookmarkElement);

            //Arrangements
            XmlElement arrangementElement = xml.CreateElement("arrangement");
            foreach (string category in arrangements.Keys)
            {
                XmlElement categoryElement = xml.CreateElement("category");
                categoryElement.SetAttribute("name", category);
                foreach (string item in arrangements[category].Keys)
                {
                    XmlElement itemElement = xml.CreateElement("item");
                    itemElement.SetAttribute("name", item);
                    foreach (Arrangement link in arrangements[category][item])
                    {
                        XmlElement linkElement = xml.CreateElement("link");
                        linkElement.SetAttribute("bookmark", link.Bookmark);
                        linkElement.SetAttribute("offset", link.Offset.ToString());
                        linkElement.SetAttribute("virtualoffset", link.VOffset.ToString());
                        linkElement.SetAttribute("virtualsize", link.VSize.ToString());
                        itemElement.AppendChild(linkElement);
                    }
                    categoryElement.AppendChild(itemElement);
                }
                arrangementElement.AppendChild(categoryElement);
            }
            rootElement.AppendChild(arrangementElement);

            xml.AppendChild(rootElement);
        }

        public void FileAdd(string file)
        {
            if (!files.Exists(x => x.Equals(file)))
            {
                files.Add(file);
            }
        }

        public List<string> FileList()
        {
            return files;
        }
    }
}
