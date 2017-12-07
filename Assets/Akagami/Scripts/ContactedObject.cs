using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactedObject : MonoBehaviour {
    [SerializeField]
    gami.Timer timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "checkPoint")
        {
            if (timer.InLimitTime())
            {
                gami.Scoaler.plusScore(1);
                return;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(1);
    }

}
