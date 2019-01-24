using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONdata : MonoBehaviour {

    string filename = "save.json";
    string path;

	// Use this for initialization
	void Start () {
        path = Application.persistentDataPath + "/" + filename;
        Debug.Log(path);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
