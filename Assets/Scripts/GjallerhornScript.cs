using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GjallerhornScript : MonoBehaviour
{
    public ParticleSystem highlightPs;
    public Vector3 carryPosition;
    public Quaternion carryRotation;
    public float carryScale;

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
            if (Vector3.Distance(GameObject.Find("odin").transform.position, transform.position) > 4)
            {
                GameObject.Find("Story").GetComponent<StoryHandler>().GjallarhornInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
            else
            {
                if (GameObject.Find("odin").GetComponent<Animator>().GetBool("walking") == false)
                {
                    GameObject.Find("odin").GetComponent<ObjectHandler>().PickUpObject(transform.gameObject, new Vector3(-0.00037f, -0.004f, 0.00658f), Quaternion.Euler(180, 0, -3.075012f), 0.43793f);
                    if (GameObject.Find("Story").GetComponent<StoryHandler>().repairedHorn == true && GameObject.Find("Story").GetComponent<StoryHandler>().blewHorn == false)
                    {
                        GameObject.Find("gjallerhorn").GetComponent<AudioSource>().Play(0);
                        GameObject.Find("skullPs3").GetComponent<ParticleSystem>().Play();
                        GameObject.Find("mirmirHead").GetComponent<AudioSource>().Play();
                        GameObject.Find("Story").GetComponent<StoryHandler>().blewHorn = true;
                    }
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
