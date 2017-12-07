using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR.WSA.Input;
using UnityEngine.UI;
namespace gami
{
    public class SceneTerrainGeneration : MonoBehaviour
    {
        [SerializeField]
        GameObject field;
        [SerializeField]
        Material fieldMaterial;
        // Use this for initialization
        void Start()
        {
            DontDestroyOnLoad(field);
        }

        void Update()
        {

            if (Input.GetKey(KeyCode.Joystick1Button0))
            {
                field.GetComponent<HoloToolkit.Unity.SpatialMapping.SpatialMappingManager>().SurfaceMaterial = fieldMaterial;
                SceneManager.LoadScene("Opening");
            }
        }
    }
}
