using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuninScript : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem highlightPs;
    public bool memoryAccess = false;

    void Start()
    {
      anim = GameObject.Find("munin").GetComponent<Animator>();
      highlightPs = GameObject.Find("highlight").GetComponent<ParticleSystem>();
    }

    void OnMouseEnter()
    {
        GameObject.Find("highlight").transform.position = transform.position;
        highlightPs.startColor = new Color(0.3725491f, 1f, 0.455642f, 0.5803922f);
        highlightPs.Play();
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && GameObject.Find("Story").GetComponent<StoryHandler>().storyExplained)
        {
            if (Vector3.Distance(GameObject.Find("odin").transform.position, transform.position) > 5)
            {
                GameObject.Find("Story").GetComponent<StoryHandler>().MuninInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
            else
            {
                GetComponent<AudioSource>().Play(0);
                anim.Play("flap");
                GameObject.Find("Story").GetComponent<StoryHandler>().MuninConversation();
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
      if(Vector3.Distance(GameObject.Find("munin").transform.position, GameObject.Find("odin").transform.position) < 5)
      {
        memoryAccess = true;
      }
      else
      {
        memoryAccess = false;
      }
    }
}
