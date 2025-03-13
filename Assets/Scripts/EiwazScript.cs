using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EiwazScript : MonoBehaviour
{
    public ParticleSystem highlightPs;
    public GameObject eiwazItem = null;

    void Start()
    {
        highlightPs = GameObject.Find("highlight").GetComponent<ParticleSystem>();
    }

    void OnMouseEnter()
    {
        GameObject.Find("highlight").transform.position = transform.position;
        highlightPs.startColor = new Color(0.5183524f, 0f, 0.6509434f, 0.5803922f);
        if (eiwazItem == null)
        {
            highlightPs.Play();
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && GameObject.Find("Story").GetComponent<StoryHandler>().storyExplained)
        {
            if (Vector3.Distance(GameObject.Find("odin").transform.position, transform.position) < 4 && GameObject.Find("odin").GetComponent<Animator>().GetBool("carrying") && eiwazItem == null)
            {
                eiwazItem = GameObject.Find("odin").GetComponent<ObjectHandler>().itemCarried;
                GameObject.Find("odin").GetComponent<ObjectHandler>().PlaceObject(transform.position);
            }
            else
            {
                GameObject.Find("Story").GetComponent<StoryHandler>().EiwazInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
        }
    }
    void OnMouseExit()
    {
        highlightPs.Stop();
        highlightPs.Clear();
    }

}
