using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleScript : MonoBehaviour
{
    public ParticleSystem ps;
    public ParticleSystem highlightPs;

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
                GameObject.Find("Story").GetComponent<StoryHandler>().AppleInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
            else
            {
                if (GameObject.Find("mjölnir").GetComponent<MjölnirScript>().inGerisMouth)
                {
                    GameObject.Find("odin").GetComponent<ObjectHandler>().PickUpObject(transform.gameObject, new Vector3(0, -0.00463f, 0.00667f), Quaternion.Euler(-90, 180, -90), 0.2f);
                }
                else
                {
                    GameObject.Find("mjölnir").GetComponent<AudioSource>().Play(0);
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
