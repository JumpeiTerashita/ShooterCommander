using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KTB
{
    public class AutoPilot : MonoBehaviour
    {

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
                gami.PlayerMover.IsAutoPilot = true;
            }

        }
    }
}