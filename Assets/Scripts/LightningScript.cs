using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class LightningScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //print();
        if (GetComponent<ParticleSystem>().particleCount > 0 && !GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
