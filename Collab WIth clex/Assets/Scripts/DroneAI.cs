using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAI : MonoBehaviour
{

    public Transform Player;
    public float MoveSpeed = 4;
    public float MaxDist = 10;
    public float MinDist = 1;
    private bool useGrivaty;
    bool isDead = false;
    private bool Kinematic = false;

    void Update()
    {
        if (isDead == false)
        {
            // Enemy will look at player
            transform.LookAt(Player);
            // Enemy will follow if distance is within these parameters(MinDist and MaxDist)
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                }
            }
        }
        else
        {
            isDead = true;
        }
    }
}
