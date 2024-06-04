using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace lab02
{
    interface ISaveToXMLFile
    {
        void SaveToXMLFile(List<Pracownik> listaPracownikow, string filename);
    }
    interface ISaveToTxtFile
    {
        void SaveToTxtFile(List<Pracownik> listaPracownikow, string filename);
    }

    internal class SaveState : ISaveToXMLFile, ISaveToTxtFile
    {
        public void SaveToXMLFile(List<Pracownik> listaPracownikow, string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Pracownik>));
                XML.Serialize(stream, listaPracownikow);
            }
            
        }

        public void SaveToTxtFile(List<Pracownik> listaPracownikow, string filename)
        {

            File.WriteAllText(filename, JsonSerializer.Serialize(listaPracownikow));

        }
    }
}
