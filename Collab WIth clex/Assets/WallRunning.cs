using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRunning : MonoBehaviour
{

    public float targetDistance;
    public GameObject player;
    public float minDist = 3f;

    void Update()
    {
        RaycastHit hit;
        {
            if (Physics.Raycast (transform.position, transform.right, out hit) || Physics.Raycast(transform.position, -transform.right, out hit))
            {
                targetDistance = hit.distance;

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
