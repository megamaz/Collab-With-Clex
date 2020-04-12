using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRunning : MonoBehaviour
{

    public float targetDistance;
    public GameObject player;
    public float minDist = 5f;

    void Update()
    {
        RaycastHit theHit;
        {
            if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out theHit))
            {
                targetDistance = theHit.distance;

                if (targetDistance < minDist)
                {
                    wallRun();
                }
            }
        }
    }

    void wallRun()
    {
        Debug.Log("wall Hit");
    }
}
