using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuginScript : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem highlightPs;

    void Start()
    {
      anim = GameObject.Find("hugin").GetComponent<Animator>();
      highlightPs = GameObject.Find("highlight").GetComponent<ParticleSystem>();
    }

    void OnMouseEnter()
    {
        GameObject.Find("highlight").transform.position = transform.position;
        highlightPs.startColor = new Color(0.5183524f, 0f, 0.6509434f, 0.5803922f);
        highlightPs.Play();
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && GameObject.Find("Story").GetComponent<StoryHandler>().storyExplained)
        {
            if (Vector3.Distance(GameObject.Find("odin").transform.position, transform.position) > 4)
            {
                GameObject.Find("Story").GetComponent<StoryHandler>().HuginInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
            else
            {
                GetComponent<AudioSource>().Play(0);
                anim.Play("flap");
                if (GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == null && GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == null)
                {
                    GameObject.Find("Story").GetComponent<StoryHandler>().HuginConversation();
                    GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
                }
                else
                {
                    GameObject.Find("Story").GetComponent<StoryHandler>().Combine();
                }
            }
        }
    }
    void OnMouseExit()
    {
      highlightPs.Stop();
      highlightPs.Clear();
    }

}
