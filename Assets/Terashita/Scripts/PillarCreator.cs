using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KTB
{
    public class PillarCreator : MonoBehaviour
    {
        [SerializeField]
        float EveryPillarLifeLimit = 1.0f;

        [SerializeField]
        float PillarUnderLimit = -5;

        [SerializeField]
        GameObject Pillar;

        private GameObject Player;

        private void Awake()
        {
            Player = GameObject.Find("Player");
        }

        // Use this for initialization
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {
            Vector3 PlayerPos = Player.transform.position;
            GameObject InstPillar = Instantiate(Pillar);
            InstPillar.transform.localScale = new Vector3(InstPillar.transform.localScale.x,PlayerPos.y - PillarUnderLimit, InstPillar.transform.localScale.z);
            InstPillar.transform.position = new Vector3(PlayerPos.x, PlayerPos.y - (PlayerPos.y - PillarUnderLimit)/2,PlayerPos.z);
            InstPillar.GetComponent<AutoDestroy>().SetDestroyLimit(EveryPillarLifeLimit);
        }
    }
}