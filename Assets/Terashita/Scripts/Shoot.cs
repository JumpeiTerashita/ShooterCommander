using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    /// <summary>
    /// 自機の射撃機能 ... Playerにアタッチ
    /// </summary>
    public class Shoot : MonoBehaviour
    {
        //  弾を自機からどんくらい前に出すか
        //  0.25fくらいがちょうどよい
        [SerializeField]
        float BulletInstLength = 0.25f;

        [SerializeField]
        GameObject Bullet;

        GameObject Player;
        // Use this for initialization
        void Start()
        {
            Player = this.gameObject;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire2"))
            {
                //Debug.Log("Fire");
                GameObject InstBullet = Instantiate(Bullet);
                InstBullet.transform.position = Player.transform.position + Player.transform.forward * BulletInstLength;

               
                
                //  プレイヤーの向いている方向に飛ぶ
                InstBullet.GetComponent<BulletBehavior>().Destination = Player.transform.forward;
            }
            
        }
    }
}