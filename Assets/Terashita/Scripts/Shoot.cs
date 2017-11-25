using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    public class Shoot : MonoBehaviour
    {
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
                InstBullet.transform.position = Player.transform.position;
            
                //  プレイヤーの向いている方向に飛ぶ
                InstBullet.GetComponent<BulletBehavior>().Destination = Player.transform.forward;
            }
            
        }
    }
}