using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public bool reset; // Simply reset the level instead of having to put build ID

    public int SceneID; 

    void OnTriggerEnter(){ // Detects if player ran into <object>
    if (reset){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    else{
        SceneManager.LoadScene(SceneID);
    }
    }
}
