using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject winScreen;
    public static bool IsGamePaused = false;

    void Start()
    {
        //winScreen.SetActive(false);
    }
    
    

    void OnTriggerEnter2D(Collider2D portalcollision)
    {
        Debug.Log("PORTAL");


        if (portalcollision.gameObject.CompareTag("GroundChecker"))
        {
            //stars = GetComponent.StarPickups.GetStars;

            //Debug.Log("Total: " + stars);


            winScreen.SetActive(true);
            IsGamePaused = true;
            Time.timeScale = 0f;
            Debug.Log("PAUSED");

        }


        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NextLevelButton()
    {
        if(IsGamePaused == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            IsGamePaused = false;
            Time.timeScale = 1f;
            Debug.Log("RESMUED");
        }

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //GameObject.SetActive(false);
    }


    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenuScene");
        //GameObject.SetActive(false);
    }

    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
        //GameObject.SetActive(false);
    }
}

