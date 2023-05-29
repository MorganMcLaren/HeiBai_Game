using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlatform : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D playercollision)
    {
        
        
            Debug.Log("Player colided");


        
        
            Scene s = SceneManager.GetActiveScene();
            SceneManager.LoadScene(s.name);

            StarPickups.starsCollected = 0;
        
        
    }
}
