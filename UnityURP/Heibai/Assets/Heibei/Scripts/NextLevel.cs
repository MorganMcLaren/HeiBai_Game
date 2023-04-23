using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    

    public void OnTriggerEnter2D()
    {

        //stars = GetComponent.StarPickups.GetStars;

        //Debug.Log("Total: " + stars);

        



        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

