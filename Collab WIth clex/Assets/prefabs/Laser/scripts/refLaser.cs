using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refLaser : MonoBehaviour
{

    public int maxBounces = 5;
    public float maxStepDistance = 100.0f;

    public LineRenderer lineR;

    // Start is called before the first frame update
    void Start()
    {
        lineR.positionCount = maxBounces;
    }

    // Update is called once per frame
    void Update()
    {
        lineR.SetPosition(0, transform.position);
        DrawRay(this.transform.position + this.transform.forward, this.transform.forward, maxBounces - 1);
    }

    public void DrawRay(Vector3 position, Vector3 direction, int refRemaining)
    {
        if (refRemaining == 0) return;


        Ray ray = new Ray(position, direction);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxStepDistance))
        {
            if (hit.collider.tag == "Mirror")
            {
                direction = Vector3.Reflect(direction, hit.normal);
                position = hit.point;
            }
            else
            {
                position = hit.point;
                for(int i = maxBounces - refRemaining; i < maxBounces; i++)
                {
                    lineR.SetPosition(i, position);
                }
                return;
            }
        }
        else
        {
            position += direction * maxStepDistance;
        }

        lineR.SetPosition(maxBounces - refRemaining, position);


        DrawRay(position, direction, refRemaining - 1);
    }
}
