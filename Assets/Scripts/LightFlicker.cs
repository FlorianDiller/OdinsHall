using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light flickeringLight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float lickerIntensity = Random.Range(8f,10f);// use float values to get smoothing intensity variation

        flickeringLight.intensity = lickerIntensity;

    }
}
