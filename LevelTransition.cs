using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement; //added the scene manager, 20F20646 Faisal Al Shaer

public class LevelTransition : MonoBehaviour
{
    
    public string nextLevel; //The name of the next scene to load will be added here

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevel); //loads the next scene
        }
    }

}
