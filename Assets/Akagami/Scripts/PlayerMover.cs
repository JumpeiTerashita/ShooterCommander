using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    [SerializeField]
    public float speed = 0.01f;
    
    void RotateAction()
    {
        float yStick = Input.GetAxis("Player_Pitch");
        float xStick = Input.GetAxis("Player_Yaw");
        if (yStick != 0)
        {
            this.transform.eulerAngles = new Vector3(
                this.transform.localEulerAngles.x - yStick,
                this.transform.eulerAngles.y,
                this.transform.localEulerAngles.z);
        }
        if(xStick != 0)
        {
            this.transform.eulerAngles = new Vector3(
                this.transform.localEulerAngles.x,
                this.transform.eulerAngles.y + xStick,
                this.transform.localEulerAngles.z);
        }
    }

    void ControllerEvent()
    {
        RotateAction();
    }
	// Update is called once per frame
	void Update () {
        ControllerEvent();
        float x = this.transform.localEulerAngles.z * speed;
        float y = this.transform.localEulerAngles.x * speed;
        float z = this.transform.localEulerAngles.y * speed;
        this.GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}
