using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlatform : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player colided");


        if (collision.gameObject.CompareTag("PlayerCollider") || collision.gameObject.CompareTag("GroundChecker"))
        {
            Scene s = SceneManager.GetActiveScene();
            SceneManager.LoadScene(s.name);

        }
    }





}
