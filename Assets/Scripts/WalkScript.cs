using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WalkScript : MonoBehaviour
{

    private Animator odinAnim;
    private UnityEngine.AI.NavMeshAgent odinNav;
    private bool odinWalking = false;

    void Start()
    {
        odinAnim = GetComponent<Animator>();
        odinNav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject.Find("hugin").transform.Find("raven").GetComponent<AudioSource>().Play(0);
        GameObject.Find("hugin").GetComponent<Animator>().Play("flap");
        GameObject.Find("Story").GetComponent<StoryHandler>().HuginConversation();
    }

    void Update()
    {
        if (GameObject.Find("Story").GetComponent<StoryHandler>().storyExplained == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Input.GetMouseButtonDown(1))
            {
                GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>().enabled = false;
                GameObject.Find("Canvas").transform.Find("Panel").GetComponent<Image>().enabled = false;
                GameObject.Find("Canvas").transform.Find("Image").GetComponent<Image>().enabled = false;
                GameObject.Find("Canvas").transform.Find("ImageRight").GetComponent<Image>().enabled = false;
                if (Physics.Raycast(ray, out hit, 100))
                {
                    odinNav.destination = hit.point;
                }
            }

            if (odinNav.remainingDistance <= odinNav.stoppingDistance)
            {
                odinWalking = false;
                GetComponent<AudioSource>().Stop();
            }
            else
            {
                odinWalking = true;
                if (!GetComponent<AudioSource>().isPlaying)
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            odinAnim.SetBool("walking", odinWalking);
        }
        else
        {
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                GameObject.Find("hugin").transform.Find("raven").GetComponent<AudioSource>().Play(0);
                GameObject.Find("hugin").GetComponent<Animator>().Play("flap");
                GameObject.Find("Story").GetComponent<StoryHandler>().HuginConversation();
            }
        }
    }
}
