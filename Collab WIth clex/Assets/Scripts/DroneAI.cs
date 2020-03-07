using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAI : MonoBehaviour
{

    public Transform Player;
    public float MoveSpeed = 100;
	public float Range = 100;
    public float MaxDist = 10;
    public float MinDist = 5;
	public float Drift = 5;
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
        if (Vector3.Distance(transform.position, Player.position) <= Range)
            {

				//If all fails transform.position += transform.forward * MoveSpeed * Time.deltaTime

				transform.position += (transform.forward * Time.deltaTime * ((MoveSpeed * ((Vector3.Distance(transform.position, Player.position)) - MinDist) / (Mathf.Abs((Vector3.Distance(transform.position, Player.position)) - MinDist) + (1 / Drift))) + (MoveSpeed * ((Vector3.Distance(transform.position, Player.position)) - MaxDist) / (Mathf.Abs((Vector3.Distance(transform.position, Player.position)) - MaxDist) + (1 / Drift)))) / 2);
				//transform.position += transform.forward * Time.deltaTime * MoveSpeed;

			}
        }
        else
        {
            isDead = true;
        }
		//Debug.Log((((MoveSpeed * ((Vector3.Distance(transform.position, Player.position)) - MinDist) / (Mathf.Abs((Vector3.Distance(transform.position, Player.position)) - MinDist) + (1 / Drift))) + (MoveSpeed * ((Vector3.Distance(transform.position, Player.position)) - MaxDist) / (Mathf.Abs((Vector3.Distance(transform.position, Player.position)) - MaxDist) + (1 / Drift)))) / 2));
		//Debug.Log(Vector3.Distance(transform.position, Player.position));
		Debug.Log(transform.position += (transform.forward * Time.deltaTime * ((MoveSpeed * ((Vector3.Distance(transform.position, Player.position)) - MinDist) / (Mathf.Abs((Vector3.Distance(transform.position, Player.position)) - MinDist) + (1 / Drift))) + (MoveSpeed * ((Vector3.Distance(transform.position, Player.position)) - MaxDist) / (Mathf.Abs((Vector3.Distance(transform.position, Player.position)) - MaxDist) + (1 / Drift)))) / 2));
	}
}
