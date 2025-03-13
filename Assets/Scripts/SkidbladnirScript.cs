using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkidbladnirScript : MonoBehaviour
{
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
                GameObject.Find("Story").GetComponent<StoryHandler>().SkidbladnirInformation();
                GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
            }
            else
            {
                if (GameObject.Find("odin").GetComponent<Animator>().GetBool("walking") == false)
                {
                    GameObject.Find("odin").GetComponent<ObjectHandler>().PickUpObject(transform.gameObject, new Vector3(0, -0.00181f, 0.00667f), Quaternion.Euler(-90, 180, -90), 0.13f);

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
