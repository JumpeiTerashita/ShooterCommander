using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorInfo : MonoBehaviour {

    Vector3 CursorPos;

	// Use this for initialization
	void Start () {
        CursorPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        CursorPos = transform.position;
    }
}
