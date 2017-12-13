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
        [SerializeField]
        float Speed = 0.01f;
        Vector3 Vec;
        // Use this for initialization
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            // 設定した目的地にだんだん向く
            Vector3 TargetPos = GetComponent<DestinationHolder>().GetDestination();
            Quaternion targetRotation = Quaternion.LookRotation(TargetPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,Time.deltaTime);
            
            // 向いている方向に飛ぶ
            transform.Translate(new Vector3(0, 0, Speed));
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

