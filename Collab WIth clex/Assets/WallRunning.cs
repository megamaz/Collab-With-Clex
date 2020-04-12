using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRunning : MonoBehaviour
{

    public float targetDistance;

    void Update()
    {
        RaycastHit theHit;
        {
            if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out theHit))
            {
                targetDistance = theHit.distance;
            }
        }
    }
}
