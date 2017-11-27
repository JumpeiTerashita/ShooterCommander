using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class PopupButtonSelect : MonoBehaviour {
    int select;
    float inputVertical;
    float beforeVertical;
    [SerializeField]
    int maxCount = 1;
    [SerializeField]
    float pointerPosX = -0.5f;
    [SerializeField]
    Image selectPointObj;
    [SerializeField]
    Button button1;
    [SerializeField]
    Button button2;
    [SerializeField]
    Button button3;

	// Use this for initialization
	void Start () {
        select = 0;
        selectPointObj = Instantiate(selectPointObj);
        selectPointObj.transform.position = new Vector3(pointerPosX, 0, this.transform.position.z);
        selectPointObj.transform.parent = this.transform;
	}

	// Update is called once per frame
	void Update () {
        inputVertical = Input.GetAxis("Select_Vertical");
        // 入力があり、Stickを倒しっぱなしでなかったら
        if ((inputVertical != beforeVertical) &&
           ( Mathf.Sqrt(inputVertical * inputVertical) >= 1))
        {
            // 選択を変更
            ChangeSelect(inputVertical);
        }
        if (Input.GetButtonDown("Select_Button_A"))
        {
            CauseAction();
        }
        // 現在の選択に変化を与える
        SelectButton();
        beforeVertical = inputVertical;
	}
    // 選択シーン切り替え関数
    void ChangeSelect(float _inputVertical)
    {
        // Stick入力が上なら
        if (_inputVertical <= 0)
        {
            select -= 1;
        }
        else
        {
            select += 1;
        }
        // シーンの数を超えてしまったら戻す
        if(select > maxCount)
        {
            select = 0;
        }
        if(select < 0)
        {
            select = maxCount;
        }
    }
    // セレクトの数によって起こすアクションを分岐
    void CauseAction()
    {
        // スクリプトのオンクリックを取る
        if(select == 0)
        {
            this.GetComponent<Popup>().Onclick1();
        }
        else if(select == 1)
        {
            this.GetComponent<Popup>().Onclick2();
        }
        else if(select == 2)
        {
            this.GetComponent<Popup>().Onclick3();
        }
    }

    // 選択しているボタンに変化を与えたい
    void SelectButton()
    {
        float yPos = 0;
        if(select == 0)
        {
            yPos = button1.transform.position.y;
        }
        else if(select == 1)
        {
            yPos = button2.transform.position.y;
        }
        else if(select == 3)
        {
            yPos = button3.transform.position.y;
        }
        selectPointObj.transform.position = new Vector3(pointerPosX, yPos, this.transform.position.z);
    }
}
