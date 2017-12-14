using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class WaveOutputter : MonoBehaviour
{
    private AudioSource audio;
    float[] waveData_ = new float[1024];

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        audio.GetOutputData(waveData_, 1);
    }
}