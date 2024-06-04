using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace lab02
{
    interface ILoadFromXMLFile
    {
        List<Pracownik> LoadFromXMLFile(string filename);
    }
    interface ILoadFromTxtFile
    {
        List<Pracownik> LoadFromTxtFile(string filename);
    }

    internal class LoadState : ILoadFromTxtFile, ILoadFromXMLFile
    {
        public List<Pracownik> LoadFromXMLFile(string filename)
        {
            List<Pracownik> listaPracownikow = new List<Pracownik>();
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(List<Pracownik>));
                listaPracownikow = (List<Pracownik>)XML.Deserialize(stream);
            }
            return listaPracownikow;
        }

        public List<Pracownik> LoadFromTxtFile(string filename)
        {
            List<Pracownik> listaPracownikow=JsonSerializer.Deserialize<List<Pracownik>>(File.OpenRead(filename));
            return (listaPracownikow);
        }
    }
}
