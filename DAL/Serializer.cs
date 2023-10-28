using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    internal class Serializer<T>
    {
        private string fileName;
        public string FileName
        {
            set
            {
                fileName = value;
            }
        }
        internal Serializer(string fName)
        {
            FileName = fName + ".xml";
        }
        internal void Serialize(List<T> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlOut =
                new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(xmlOut, list);
            }
        }

        internal List<T> Deserialize()
        {
            List<T> listan;

            if (File.Exists(fileName))  // Check if the file exists
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream xmlIn = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    listan = (List<T>)xmlSerializer.Deserialize(xmlIn);
                }
            }
            else
            {
                listan = new List<T>();  // Provide a default value (an empty list)
            }

            return listan;
        }

    }
}
