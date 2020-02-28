using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{

    public Transform point1;
    public Transform point2;

    public LineRenderer laserLine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        laserLine.SetPosition(0, point1.position);
        laserLine.SetPosition(1, point2.position);
    }
}
