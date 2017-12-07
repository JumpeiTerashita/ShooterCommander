using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace gami
{
    public class SceneTerrainGeneration : MonoBehaviour
    {
        [SerializeField]
        GameObject field;
        // Use this for initialization
        void Start()
        {
            DontDestroyOnLoad(field);
        }

        void Update()
        {

            if (Input.GetKey(KeyCode.Joystick1Button0))
            {
                SceneManager.LoadScene("Opening");
            }
        }
    }
}
