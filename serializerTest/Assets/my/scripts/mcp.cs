using UnityEngine;
using System.Collections;

public class mcp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));
        foreach (object obj in objects) {
            GameObject go = (GameObject)obj;
            //Debug.Log(g.name);
            serializer.gameObjectSimulator gSim = serializer.clsHelper.gameObjectToSimulator(go);
            if (gSim != null) {
                string xml = serializer.clsSerializer.SerializeToString<serializer.gameObjectSimulator>(gSim);
                Debug.Log(xml);
            }
        }
	}
}
