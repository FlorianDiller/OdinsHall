using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class ObjectHandler : MonoBehaviour
{
    private Transform odinBack;
    private Transform odinHand;
    private Transform metarig;
    public GameObject itemCarried;

    void Start()
    {
        metarig = transform.Find("metarig").transform;
        odinBack = metarig.Find("spine").transform.Find("spine.001").transform.Find("spine.002").transform.Find("spine.003").transform;
        odinHand = odinBack.transform.Find("shoulder.R").transform.Find("upper_arm.R").transform.Find("forearm.R").transform.Find("hand.R").transform;
    }

    void Update()
    {

    }

    public void PickUpObject(GameObject item, Vector3 carryPosition, Quaternion carryRotation, float carryScale)
    {
        if (GameObject.Find("odin").GetComponent<Animator>().GetBool("walking") == false)
        {
            if (itemCarried == item)
            {
                PutDownObject();
            }
            else
            {
                if (itemCarried != null)
                {
                    PutDownObject();
                }
                GameObject.Find("odin").GetComponent<Animator>().SetBool("carrying", true);
                itemCarried = item;
                item.transform.parent = odinBack;
                item.transform.localPosition = carryPosition;
                item.transform.localRotation = carryRotation;
                item.transform.localScale = new Vector3(carryScale, carryScale, carryScale);
                odinHand.Find("spear").transform.parent = odinBack;
                odinBack.Find("spear").transform.localPosition = new Vector3(0, -0.00145f, -0.00228f);
                odinBack.Find("spear").transform.localRotation = Quaternion.Euler(-47.51f, 93.687f, -90.508f);
                if (GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem == itemCarried)
                {
                    GameObject.Find("eiwaz").GetComponent<EiwazScript>().eiwazItem = null;
                }

                if (GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem == itemCarried)
                {
                    GameObject.Find("hagalaz").GetComponent<HagalazScript>().hagalazItem = null;
                }
            }
        }
    }

    public void PutDownObject()
    {
        var item = itemCarried;
        item.transform.parent = null;
        GameObject.Find("odin").GetComponent<Animator>().SetBool("carrying", false);
        item.transform.SetPositionAndRotation(GameObject.Find("odin").transform.position, itemCarried.transform.rotation);
        odinBack.transform.Find("spear").transform.parent = odinHand;
        odinHand.transform.Find("spear").transform.localPosition = new Vector3(0, 0.001378992f, 0.001035179f);
        odinHand.transform.Find("spear").transform.localRotation = Quaternion.Euler(-9.582001f, -1.965f, -61.369f);
        itemCarried = null;
    }

    public void PlaceObject(Vector3 placePosition)
    {
        var item = itemCarried;
        item.transform.parent = null;
        GameObject.Find("odin").GetComponent<Animator>().SetBool("carrying", false);
        item.transform.localPosition = placePosition;
        odinBack.transform.Find("spear").transform.parent = odinHand;
        odinHand.transform.Find("spear").transform.localPosition = new Vector3(0, 0.001378992f, 0.001035179f);
        odinHand.transform.Find("spear").transform.localRotation = Quaternion.Euler(-9.582001f, -1.965f, -61.369f);
        itemCarried = null;
    }
}
