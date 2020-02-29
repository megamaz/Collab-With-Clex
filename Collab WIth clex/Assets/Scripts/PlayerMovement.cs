using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public CharacterController controller;
    
    public float speed = 12f;

    Vector3 velocity;
    public float gravity = -9.81f;
    public float JumpHeight = 3f;

    public Transform groundCheck;
    public float distance;
    public LayerMask groundmask;
    public float grounddistance = 0.04f;
    bool isgruonded; //I realized i made a typo in this variable too late. Oops.

    // Update is called once per frame
    void Update()
    {
        
        /*
        Movement script
        I again still don't know what I'm doing
        
        megamaz
        */
        isgruonded = Physics.CheckSphere(groundCheck.position, grounddistance, groundmask);

        if (isgruonded && velocity.y < 0){
            velocity.y = -2f;
            Debug.Log("Reset!");
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && isgruonded ){
            velocity.y = Mathf.Sqrt(JumpHeight * -2 * gravity);
        }
    }
}
