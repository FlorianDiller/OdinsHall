using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MirmirScript : MonoBehaviour
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
            if (GameObject.Find("odin").GetComponent<ObjectHandler>().itemCarried == GameObject.Find("skidbladnir") && GameObject.Find("Story").GetComponent<StoryHandler>().blewHorn && GameObject.Find("Story").GetComponent<StoryHandler>().readiedShip)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                GameObject.Find("Story").GetComponent<StoryHandler>().MirmirInformation();
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
