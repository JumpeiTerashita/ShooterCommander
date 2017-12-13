using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    enum AI_PATTERN
    {
        STOP,
        CHASE,
        HITAWAY
    }


    /// <summary>
    /// 敵機のスクリプト
    /// </summary>
    public class EnemyBehavior : MonoBehaviour
    {
        GameObject Player;

        [SerializeField]
        AI_PATTERN BehaviorPattern = AI_PATTERN.STOP;

        [SerializeField]
        float Speed = 0.01f;
        // Use this for initialization
        void Start()
        {
            Player = GameObject.Find("Player");
        }


        // Update is called once per frame
        void Update()
        {
            switch (BehaviorPattern)
            {
                case AI_PATTERN.CHASE:
                    Chase();
                    break;

                case AI_PATTERN.HITAWAY:
                    HitAway();
                    break;

                case AI_PATTERN.STOP:
                default:
                    break;
            }


            
        }


        void Chase()
        {
            // プレイヤーの位置を目的地に設定
            GetComponent<DestinationHolder>().SetDestination(Player.transform.position);

            // 設定した目的地にだんだん向く
            Vector3 TargetPos = GetComponent<DestinationHolder>().GetDestination();
            Quaternion targetRotation = Quaternion.LookRotation(TargetPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

            // 向いている方向に飛ぶ
            transform.Translate(new Vector3(0, 0, Speed));
            return;
        }

        void HitAway()
        {
            // プレイヤーの反対の位置を目的地に設定
            GetComponent<DestinationHolder>().SetDestination(transform.position-Player.transform.position);

            // 設定した目的地にだんだん向く
            Vector3 TargetPos = GetComponent<DestinationHolder>().GetDestination();
            Quaternion targetRotation = Quaternion.LookRotation(TargetPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation, Time.deltaTime);

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

