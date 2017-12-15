using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gami
{
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField]
        public AudioClip audio;

        float[] waveData_ = new float[1024];

        private AudioSource source;

        private void Start()
        {
            source = gameObject.GetComponent<AudioSource>();
            source.clip = audio;
            source.Play();
            source.loop = true;
        }

        private void Update()
        {

            source.GetOutputData(waveData_, 1);

            //Debug.Log(waveData_[0]);
        }

    }
}