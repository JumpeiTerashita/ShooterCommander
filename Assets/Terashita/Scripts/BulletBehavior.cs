using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    /// <summary>
    /// 弾の持つ機能　今のところ
    /// 1.移動
    /// </summary>
    public class BulletBehavior : MonoBehaviour
    {
        public Vector3 Destination;

        [SerializeField]
        float speed = 0.1f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(speed*Destination);
        }
    }
}