using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MjölnirScript : MonoBehaviour
{
    public ParticleSystem highlightPs;
    private float odinDistance;
    public bool inGerisMouth = true;

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
                GameObject.Find("Story").GetComponent<StoryHandler>().MjölnirInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
            else
            {
                if (inGerisMouth == true)
                {
                    if (GameObject.Find("odin").GetComponent<ObjectHandler>().itemCarried != GameObject.Find("apple"))
                    {
                        GetComponent<AudioSource>().Play(0);
                    }
                    else
                    {
                        inGerisMouth = false;
                        GameObject.Find("odin").GetComponent<ObjectHandler>().PlaceObject(new Vector3(3.611f, 1.123f, 4.6f));
                        GameObject.Find("odin").GetComponent<ObjectHandler>().PickUpObject(transform.gameObject, new Vector3(-0.0006699901f, -0.001798867f, 0.006710548f), Quaternion.Euler(-90, 180, 90), 0.06f);
                    }
                }
                else
                {
                    GameObject.Find("odin").GetComponent<ObjectHandler>().PickUpObject(transform.gameObject, new Vector3(-0.0006699901f, -0.001798867f, 0.006710548f), Quaternion.Euler(-90, 180, 90), 0.06f);
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
