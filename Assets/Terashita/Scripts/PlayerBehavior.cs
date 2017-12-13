using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class PlayerBehavior : MonoBehaviour
    {
        

        [SerializeField]
        MeshRenderer PlayerMesh;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void Destroy()
        {
            PlayerMesh.enabled = false;
            this.GetComponent<CapsuleCollider>().enabled = false;
            //gameObject.SetActive(false);
        }

    }
}