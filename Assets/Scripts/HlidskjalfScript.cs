using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HlidskjalfScript : MonoBehaviour
{
    public ParticleSystem highlightPs;
    private float odinDistance;
    public Animator odinAnim;
    private int satDown;

    void Start()
    {
      highlightPs = GameObject.Find("highlight").GetComponent<ParticleSystem>();
      odinAnim = GameObject.Find("odin").GetComponent<Animator>();
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
            if (GameObject.Find("odin").GetComponent<ObjectHandler>().itemCarried == null)
            {
                if (Vector3.Distance(GameObject.Find("hlidskjalf").transform.position, GameObject.Find("odin").transform.position) < 3)
                {
                    GameObject.Find("odin").GetComponent<UnityEngine.AI.NavMeshAgent>().ResetPath();
                    odinAnim.Play("seated");
                    GameObject.Find("hlidskjalf").GetComponent<UnityEngine.AI.NavMeshObstacle>().enabled = false;
                    GameObject.Find("odin").transform.position = new Vector3(0, 0, 16);
                    GameObject.Find("odin").transform.rotation = Quaternion.Euler(0, 180, 0);
                    if (satDown == 0)
                    {
                        GameObject.Find("skullPs1").GetComponent<ParticleSystem>().Play();
                        GameObject.Find("mirmirHead").GetComponent<AudioSource>().Play();
                    }
                    switch (satDown)
                    {
                        case (0):
                            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("Hmm.... there is no wind on the sea. If I could just change that.");
                            GameObject.Find("Story").GetComponent<StoryHandler>().checkedPath = true;
                            GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
                            break;
                        case (1):
                            GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("...Or build a Storm into my ship.");
                            GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
                            break;
                    }
                    satDown++;
                }
                else
                {
                    GameObject.Find("Story").GetComponent<StoryHandler>().HlidskjalfInformation();
                    GameObject.Find("Story").GetComponent<StoryHandler>().ShowPic(transform.GetComponent<PicReturn>().ReturnPic());
                }
            }
            else
            {
                GameObject.Find("Canvas").GetComponent<TextScript>().TextChange("I should put this down first.");
            }
        }
    }


    void OnMouseExit()
    {
      highlightPs.Stop();
      highlightPs.Clear();
    }
}
