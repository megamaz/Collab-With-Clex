using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAI : MonoBehaviour
{

    public Transform Player;
    public float MoveSpeed = 2;
    public float MaxDist = 40;
    public float MinDist = 15;
    public float Damping = 1f;
    private bool useGrivaty;
    bool isDead = false;
    private bool Kinematic = false;

    void Update()
    {
        if (isDead == false)
        {
            // Enemy will look at player but at a slower rate (controlled with the damping variable)
            var rotation = Quaternion.LookRotation(Player.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
        
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
