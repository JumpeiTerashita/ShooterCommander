using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Opening : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Popup.Open2ButtonPop("test", "test", "test", () => Debug.Log(1), () => Debug.Log(2));

        Popup.Open3ButtonPop("シューターコマンダー", "テスト", "終了", "おわる",
            () => SceneManager.LoadScene("Terashita/Scenes/Shooting"), 
            () => Application.Quit(), 
            () => Application.Quit());
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
