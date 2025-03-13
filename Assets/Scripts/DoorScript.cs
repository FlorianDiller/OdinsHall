using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    private Quaternion endRotation = Quaternion.Euler(-90f, 0, 90f);
    private float lightIncrement = -0.05f;
    public float rotationIncrement = 75;

    void Start()
    {
        
    }

    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, endRotation, rotationIncrement*Time.deltaTime);
        if(Mathf.Abs(rotationIncrement) > 15)
        {
            rotationIncrement *= 0.99f;
        }
        if (GameObject.Find("doorLight").GetComponent<Light>().range < 3 || lightIncrement < 0)
        {
            GameObject.Find("doorLight").GetComponent<Light>().range += lightIncrement;
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(1);
        }
        
    }

    void OnMouseEnter()
    {
        endRotation = Quaternion.Euler(-90f, 60f, 90f);
        lightIncrement = 0.01f;
        rotationIncrement = 75f;
        GetComponent<AudioSource>().Play();
    }

    void OnMouseExit()
    {
        endRotation = Quaternion.Euler(-90f, 0f, 90f);
        lightIncrement = -0.03f;
        rotationIncrement = 75f;
        GetComponent<AudioSource>().Play();
    }
}
