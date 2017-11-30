using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    /// <summary>
    /// キー入力を受け取って移動する　自機用
    /// </summary>
    public class Move : MonoBehaviour
    {
        [SerializeField]
        float speed = 0.005f;

        float LeftStick_Horizontal,LeftStick_Vertical,RightStick_Vertical;

        // Update is called once per frame
        void Update()
        {
            LeftStick_Horizontal = Input.GetAxisRaw("Horizontal");
            LeftStick_Vertical = Input.GetAxisRaw("Vertical");
            RightStick_Vertical = Input.GetAxisRaw("Vertical2");
            transform.position = new Vector3(transform.position.x + speed * LeftStick_Horizontal, transform.position.y + speed * RightStick_Vertical, transform.position.z + speed * LeftStick_Vertical);
        }
    }
}