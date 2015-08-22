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
        public string objectName;
        public string objectType;
        public List<object> subScripts = new List<object>();
    }

    public static class clsHelper {
        //define a list
        public static List<GameObject> allPrefabs = new List<GameObject>();
        public static bool loadAllPrefabs() {
            if (allPrefabs.Count > 0) {
                return false;
            }
            //Important note: place your prefabs folder(or levels or whatever) 
            //in a folder called "Resources" like this "Assets/Resources/Prefabs"
            UnityEngine.Object[] subListObjects = Resources.LoadAll("Prefabs", typeof(GameObject));
            foreach (GameObject subListObject in subListObjects) {
                GameObject lo = (GameObject)subListObject;
                allPrefabs.Add(lo);
            }
            return true;
        }

        public static GameObject simulatorToGameObject(gameObjectSimulator goS) {
            loadAllPrefabs();
            foreach (GameObject prefab in allPrefabs) {
                //if (prefab.name == goS.objectName) {
                //(Clone)

                // contains MIGHT be dangerous... AGAIN!?
                if (goS.objectName.Contains(prefab.name )) {
                    //Instantiate(global::UnityEngine.Object) - C:\Users\Gamer\Dropbox\Source\c#\objectSerializer\serializerTest\Library\UnityAssemblies\UnityEngine.dll
                    return (GameObject)UnityEngine.Object.Instantiate(prefab, goS.position, goS.rotation);
                }
            }
            return null;
        }

        public static gameObjectSimulator gameObjectToSimulator(GameObject go) {
            saveMe savME = go.GetComponent<saveMe>() ;
            if (savME != null) {
                gameObjectSimulator goS = new gameObjectSimulator();
                goS.position = go.transform.position;
                goS.rotation = go.transform.rotation;
                goS.scale = go.transform.localScale;
                goS.objectName = go.name;
                goS.objectType = go.GetType().ToString();
                // get scipts attached to the object... lolnope :*(
                /*foreach (var component in go.GetComponents<Component>()) {
                    if (savME.scriptAllowed(component.ToString())) {
                        goS.subScripts.Add(component);
                    }
                }*/

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
