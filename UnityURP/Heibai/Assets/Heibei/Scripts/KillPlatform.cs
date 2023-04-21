using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlatform : MonoBehaviour
{
    


    void OnTriggerEnter2D()
    {
        Debug.Log("PLayer colided");
        Scene s = SceneManager.GetActiveScene();
        SceneManager.LoadScene(s.name);
    }





}
