using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 
public class TimeManager : MonoBehaviour {
    [SerializeField]
    public float limitTime = 60;
    private float timeCount = 0;
    private void Start()
    {
        timeCount = 0;
    }
    private void Update()
    {
        timeCount += Time.deltaTime;

    }

    // 制限時間内であればtrueをかえす
    public bool InLimitTime()
    {
        if (timeCount >= limitTime)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    // 現在の残り時間を返す
    public float GetTime()
    {
        return limitTime - timeCount;
    }
}
