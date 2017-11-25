using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Opening : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Popup.Open2ButtonPop("シューターコマンダー", "テスト", "終了",
            () => SceneManager.LoadScene("Terashita/Scenes/Shooting"), 
            () => Application.Quit());
        
	}
	
}
