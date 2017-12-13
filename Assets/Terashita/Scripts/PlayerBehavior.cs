using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    public class PlayerBehavior : MonoBehaviour
    {
        static Vector3 PlayerPos;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            PlayerPos = transform.position;
        }

        void Destroy()
        {
            Destroy(gameObject);
        }

    }
}