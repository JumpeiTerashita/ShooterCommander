using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    [SerializeField]
    public float speed = 0.01f;
    
    void RotateAction()
    {
        if (Input.GetAxis("Player_Pitch") != 0)
        {
            Debug.Log(1);
            this.transform.Rotate(
                0,0,0
                );
        }
    }

    void ControllerEvent()
    {
        RotateAction();
    }
	// Update is called once per frame
	void Update () {
        ControllerEvent();
        float x = this.transform.localEulerAngles.x * speed;
        float y = this.transform.localEulerAngles.y * speed;
        float z = this.transform.localEulerAngles.z * speed;
        this.GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}
