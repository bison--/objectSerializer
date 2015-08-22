using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System;

[Serializable, XmlType("someInfoSample")]
public class someInfoSample : MonoBehaviour {
    public int id = 7;
    public int HP = 100;
    public string myName = "Dave";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity);
	}
}
