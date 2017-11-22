using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed*Input.GetAxisRaw("Horizontal"),0,transform.position.z + speed*Input.GetAxisRaw("Vertical"));
    }
}
