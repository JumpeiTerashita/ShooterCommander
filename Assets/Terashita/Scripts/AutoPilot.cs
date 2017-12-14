using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KTB
{
    public class AutoPilot : MonoBehaviour
    {
        [SerializeField]
        float ArriveLength = 0.25f;

        [SerializeField]
        float SpeedMagnitude = 4.0f;


        float Distance;

        Vector3 CursorPos;

        // Use this for initialization
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            
            //  TODO 自動操縦ボタンのInputSetting
            //  とりあえずBボタン
            if (Input.GetButtonDown("Fire2")&&!gami.PlayerMover.IsAutoPilot)
            {
                Debug.Log("AutoPilot enabled");
                gami.PlayerMover.IsAutoPilot = true;

                CursorPos = CursorInfo.GetCursorPos();
                GetComponent<DestinationHolder>().SetDestination(CursorPos);
                transform.LookAt(CursorPos);
              
            }

            if (gami.PlayerMover.IsAutoPilot)
            {
                FlyToDestination(SpeedMagnitude);
                float DistanceTwice = (CursorPos - transform.position).sqrMagnitude;

                if (DistanceTwice <= (ArriveLength*ArriveLength))
                {
                    Debug.Log("AutoPilot disabled");
                    gami.PlayerMover.IsAutoPilot = false;
                    GetComponent<gami.PlayerMover>().SetSpeed(0.005f);

                    
                    
                    transform.LookAt(new Vector3(0,0,10));
                }
            }

        }

        void FlyToDestination(float _speedMagnitude = 1.0f, float _turnMagnitude = 1.0f)
        {
            // 設定した目的地にだんだん向く
            Vector3 TargetPos = GetComponent<DestinationHolder>().GetDestination();
            Quaternion targetRotation = Quaternion.LookRotation(TargetPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * _turnMagnitude);

            float Speed = GetComponent<gami.PlayerMover>().GetMaxSpeed();

            // 向いている方向に飛ぶ
            transform.Translate(new Vector3(0, 0, Speed * _speedMagnitude));
            return;
        }
    }
}