using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Opening : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Popup.Open2ButtonPop("シューターコマンダー", "シューティング", "レース",
            () => SceneManager.LoadScene("Terashita/Scenes/Shooting"), 
            () => SceneManager.LoadScene("raceScene"));
        Scoaler.initScore();
	}	
}