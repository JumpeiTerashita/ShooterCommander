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
        float PillarTopLimit = 5;

        [SerializeField]
        float PillarUnderLimit = -5;

        private float PillarLimit;

        [SerializeField]
        GameObject Pillar;

        private bool IsSideUnder;

        private GameObject Player;

        private void Awake()
        {
            Player = GameObject.Find("Player");
        }

        // Use this for initialization
        void Start()
        {
            PillarLimit = PillarUnderLimit;
            IsSideUnder = true;
        }


        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Attack_SideChange"))
            {
                if (IsSideUnder)
                {
                    IsSideUnder = false;
                    PillarLimit = PillarTopLimit;
                }
                else
                {
                    IsSideUnder = true;
                    PillarLimit = PillarUnderLimit;
                }
            }

            Vector3 PlayerPos = Player.transform.position;
            GameObject InstPillar = Instantiate(Pillar);
            InstPillar.transform.localScale = new Vector3(InstPillar.transform.localScale.x,PlayerPos.y - PillarLimit, InstPillar.transform.localScale.z);
            InstPillar.transform.position = new Vector3(PlayerPos.x, PlayerPos.y - (PlayerPos.y - PillarLimit) /2,PlayerPos.z);
            InstPillar.GetComponent<AutoDestroy>().SetDestroyLimit(EveryPillarLifeLimit);
        }
    }
}