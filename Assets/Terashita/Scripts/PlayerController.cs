using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;

public class PlayerController : MonoBehaviour {

    AeroplaneController controller;


    private void Awake()
    {
        controller = GetComponent<AeroplaneController>();
    }

    void FixedUpdate()
    {
        var yow = Input.GetAxis("Horizontal2");
        var pitch = Input.GetAxis("Vertical");
        var roll = Input.GetAxis("Horizontal");

        // ロール, ピッチ, ヨー, スロットル, エアブレーキ
        controller.Move(roll, pitch, yow, 1, false);
    }
}
