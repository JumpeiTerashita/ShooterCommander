using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Opening : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Popup.Open2ButtonPop("test", "test", "test", () => Debug.Log(1), () => Debug.Log(2));

        Popup.Open3ButtonPop("test", "test", "test", "test", () => Debug.Log(1), () => Debug.Log(2), () => Debug.Log(3));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
