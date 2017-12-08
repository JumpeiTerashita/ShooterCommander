using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace gami
{

    public class PlayerMover : MonoBehaviour
    {
        [SerializeField]
        public float maxSpeed = 0.01f;
        [SerializeField]
        public float accel = 0.001f;
        private float speed = 0;
        void RotateAction()
        {
            float yStick = Input.GetAxis("Player_Pitch");
            float xStick = Input.GetAxis("Player_Roll");
            float trigger = Input.GetAxis("Player_Yaw");
            if (yStick != 0)
            {
               // yStick *= 2 - (speed / maxSpeed);
                this.transform.rotation *=
                    Quaternion.AngleAxis(-yStick, new Vector3(1, 0, 0));
            }
            if (xStick != 0)
            {
                this.transform.rotation *=
                    Quaternion.AngleAxis(-xStick, new Vector3(0, 0, 1));
            }
            if (trigger != 0)
            {
                this.transform.rotation *=
                    Quaternion.AngleAxis(-trigger, new Vector3(0, 1, 0));
            }
        }
        void AccelAction()
        {
            if (Input.GetButton("Player_Accel"))
            {
                if (speed >= maxSpeed) return;
                speed += accel;
            }
        }
        void BrakeAction()
        {
            if (Input.GetButton("Player_Brake"))
            {
                if (speed <= 0)
                {
                    speed = 0;
                    return;
                }
                speed *= 0.95f;
            }
        }
        void ControllerEvent()
        {
            AccelAction();
            BrakeAction();
            RotateAction();
        }
        void Update()
        {
            ControllerEvent();
            //float x = Mathf.Cos(Mathf.Deg2Rad * (this.transform.localEulerAngles.y + 270) * -1) * speed;
            //float y = Mathf.Sin(Mathf.Deg2Rad * this.transform.localEulerAngles.x * -1) * speed;
            //float z = Mathf.Sin(Mathf.Deg2Rad * (this.transform.localEulerAngles.y + 270) * -1) * speed;
            //this.transform.position += new Vector3(x, y, z);
            this.transform.Translate(new Vector3(0, 0, speed));
        }
    }

}