using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace serializer {
    public class gameObjectSimulator {
        public Vector3 position;
        public Quaternion rotation;
        public Vector3 scale;
        public List<object> subScripts = new List<object>();
    }

    public static class clsHelper {
        public static gameObjectSimulator gameObjectToSimulator(GameObject go) {
            saveMe savME = go.GetComponent<saveMe>() ;
            if (savME != null) {
                gameObjectSimulator goS = new gameObjectSimulator();
                goS.position = go.transform.position;
                goS.rotation = go.transform.rotation;
                goS.scale = go.transform.localScale;

                foreach (var component in go.GetComponents<Component>()) {
                    if (savME.scriptAllowed(component.ToString())) {
                        goS.subScripts.Add(component);
                    }
                }

                return goS;
            }

            return null;
        }

        public static T[] Redim<T>(T[] arr, bool preserved) {
            int arrLength = arr.Length;
            T[] arrRedimed = new T[arrLength + 1];
            if (preserved) {
                for (int i = 0; i < arrLength; i++) {
                    arrRedimed[i] = arr[i];
                }
            }
            return arrRedimed;
        }
    }

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
