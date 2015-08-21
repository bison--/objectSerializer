using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace serializer {
    public static class clsSerializer {
        public static string SerializeToString<T>(this T baseType) {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            serializer.Serialize(stream, baseType);
            stream.Position = 0;
            System.IO.StreamReader strReader = new System.IO.StreamReader(stream);

            return strReader.ReadToEnd();
        }

        public static T DeserializeFromString<T>(string data) {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            T theclass;

            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            System.IO.StreamWriter strWriter = new System.IO.StreamWriter(stream);
            strWriter.Write(data);
            strWriter.Flush();
            stream.Position = 0;
            
            theclass = (T)serializer.Deserialize(stream);

            return theclass;
   
        }
    }
}
