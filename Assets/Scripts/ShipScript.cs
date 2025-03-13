using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent shipNav;

    void Start()
    {
        shipNav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //shipNav.destination = new Vector3(2.28f, -0.45646f, -4.6001f); //destination in front of camera
        shipNav.destination = new Vector3(4.51f, -0.4466666f, -11.32f); //destination in behind camera
    }

    void Update()
    {
        if(!shipNav.hasPath)
        {
            GameObject.Find("ShipParent").transform.Find("skidbladnir").transform.Find("BowWave1").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("ShipParent").transform.Find("skidbladnir").transform.Find("BowWave2").GetComponent<ParticleSystem>().Stop();
        }
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Time.timeSinceLevelLoad > 65)
        {
            Application.Quit();
        }
    }
}
