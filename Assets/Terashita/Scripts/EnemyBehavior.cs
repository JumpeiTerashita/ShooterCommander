using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    /// <summary>
    /// 敵機のスクリプト
    /// </summary>
    public class EnemyBehavior : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// 破壊されたとき
        /// </summary>
        void Destroy()
        {
            Debug.Log("Destroy -- Enemy");
            Destroy(gameObject);
        }
    }
}

