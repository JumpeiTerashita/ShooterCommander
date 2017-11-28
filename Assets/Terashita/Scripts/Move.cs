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

        // Update is called once per frame
        void Update()
        {
            transform.position = new Vector3(transform.position.x + speed * Input.GetAxisRaw("Horizontal"), transform.position.y + speed * Input.GetAxisRaw("Vertical2"), transform.position.z + speed * Input.GetAxisRaw("Vertical"));
        }
    }
}