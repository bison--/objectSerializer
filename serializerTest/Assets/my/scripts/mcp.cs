using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mcp : MonoBehaviour {
    List<string> serializedObjects = new List<string>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void doSave() {
        serializedObjects.Clear();
        object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));
        foreach (object obj in objects) {
            GameObject go = (GameObject)obj;
            //Debug.Log(g.name);
            serializer.gameObjectSimulator gSim = serializer.clsHelper.gameObjectToSimulator(go);
            if (gSim != null) {
                string xml = serializer.clsSerializer.SerializeToString<serializer.gameObjectSimulator>(gSim);
                serializedObjects.Add(xml);
                Debug.Log(xml);
            }
        }
    }

    public void doLoad() {

        foreach (string xml in serializedObjects) {
            serializer.clsHelper.simulatorToGameObject(serializer.clsSerializer.DeserializeFromString<serializer.gameObjectSimulator>(xml));
        }
    }
}
