using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace gami
{
#if WINDOWS_UWP
    using Windows.Gaming.Input;
#endif


    public class PlayerMover : MonoBehaviour
    {
#if WINDOWS_UWP
        public Gamepad controller;
#endif
        [SerializeField]
        public float maxSpeed = 0.01f;
        [SerializeField]
        public float accel = 0.001f;
        private float speed = 0;

        // 自動操縦フラグ by KTB
        // オンなら操縦できないように
        static public bool IsAutoPilot;

        private void Start()
        {
#if WINDOWS_UWP
            // GamePadを探して追加
            // controller = Gamepad.Gamepads.First();
            Gamepad.GamepadAdded += Gamepad_GamepadAdded;
#endif
            IsAutoPilot = false;
        }

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
            if (!IsAutoPilot)
            {
                ControllerEvent();
                // 今現在向いている方向に進む
                this.transform.Translate(new Vector3(0, 0, speed));
            }
        }

        // AutoPilot時の速度取得 by KTB
        public float GetMaxSpeed()
        {
            return maxSpeed;
        }

        // AutoPilot終了時の速度変更 by KTB
        public void SetSpeed(float _speed)
        {
            speed = _speed;
        }

#if WINDOWS_UWP
        // ゲームパッド追加時のイベント処理
        private void Gamepad_GamepadAdded(object sender, Gamepad e)
        {
            controller = e;
        }
#endif
    }

}