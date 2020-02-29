using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public bool isOn;

    public Light lightControl;
    /*

    bool = true / false
    int = 1, 2, 3
    float = 0.1, 3.5, 30.4
    string = "Hello World"


    */
    // Update is called once per frame
    void Update()
    {
        // Light Toggle
        if(Input.GetKeyDown(KeyCode.F) && isOn){
            isOn = false;
        }
        else if(Input.GetKeyDown(KeyCode.F) && !isOn){
            isOn = true;
        }


        // Update on / off
        lightControl.enabled = isOn;
        
    }
}
