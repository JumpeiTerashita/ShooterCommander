using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    float speed = 0.005f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed*Input.GetAxisRaw("Horizontal"), transform.position.y + speed * Input.GetAxisRaw("Vertical2"), transform.position.z + speed*Input.GetAxisRaw("Vertical"));
    }
}
