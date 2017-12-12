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
            // Stick、Triggerに入力があれば値を保持
            float yStick = Input.GetAxis("Player_Pitch");
            float xStick = Input.GetAxis("Player_Roll");
            float trigger = Input.GetAxis("Player_Yaw");
            // YawPitchRollの入力によって
            // 現在の姿勢から値を変更していく
            if (yStick != 0)
            {
                // 後々調節
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
                // スピードの最大値を決めるか、
                // スピードをマイフレーム減速させるかは未定

                // 該当する入力があればスピードを加算
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
        // 各アクションをコントローラーイベントに保持
        void ControllerEvent()
        {
            AccelAction();
            BrakeAction();
            RotateAction();
        }
        void Update()
        {
            ControllerEvent();
            // 今現在向いている方向に進む
            this.transform.Translate(new Vector3(0, 0, speed));
        }
    }

}