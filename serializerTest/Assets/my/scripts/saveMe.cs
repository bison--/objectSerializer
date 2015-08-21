using UnityEngine;
using System.Collections;

public class saveMe : MonoBehaviour {
    public string[] scriptNames;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool scriptAllowed(string scriptName) {
        Debug.Log(scriptName);
        foreach (string sName in scriptNames) {
            // contains COULD be dangerous!
            if (sName == scriptName || scriptName.Contains(sName)) {
                return true;
            }
        }
        return false;
    }
}
