using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GeriScript : MonoBehaviour
{
    public ParticleSystem highlightPs;
    private float odinDistance;

    void Start()
    {
        highlightPs = GameObject.Find("highlight").GetComponent<ParticleSystem>();
    }

    void OnMouseEnter()
    {
        GameObject.Find("highlight").transform.position = transform.position;
        highlightPs.startColor = new Color(0.3726415f, 0.8539677f, 1f, 0.5803922f);
        highlightPs.Play();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && GameObject.Find("Story").GetComponent<StoryHandler>().storyExplained)
        {
            if (Vector3.Distance(GameObject.Find("odin").transform.position, transform.position) < 3)
            {
                GetComponent<AudioSource>().Play(0);
            }
            else
            {
                GameObject.Find("Story").GetComponent<StoryHandler>().GeriInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
            
        }
    }

    void OnMouseExit()
    {
        highlightPs.Stop();
        highlightPs.Clear();
    }

    void Update()
    {
        if (GetComponent<AudioSource>().time > 2)
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
