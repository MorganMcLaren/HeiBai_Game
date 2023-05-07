using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject winScreenZero;
    public GameObject winScreenOne;
    public GameObject winScreenTwo;
    public GameObject winScreenThree;

    public int stars = 0;

    public static bool IsGamePaused = false;

    void Start()
    {
        stars = 0;
    }
    
    

    void OnTriggerEnter2D(Collider2D portalcollision)
    {
        Debug.Log("PORTAL");


        if (portalcollision.gameObject.CompareTag("GroundChecker"))
        {
            

            stars = StarPickups.starsCollected;

            Debug.Log("Total: " + stars);

            if(stars <= 0)
            {
                winScreenZero.SetActive(true);
                IsGamePaused = true;
                Time.timeScale = 0f;
                Debug.Log("PAUSED");

            }

            else if(stars == 1)
            {
                    winScreenOne.SetActive(true);
                    IsGamePaused = true;
                    Time.timeScale = 0f;
                    Debug.Log("PAUSED");
            }

            else if(stars == 2)
            {
                    winScreenTwo.SetActive(true);
                    IsGamePaused = true;
                    Time.timeScale = 0f;
                    Debug.Log("PAUSED");
            }

            else if(stars >= 3)
            {
                    winScreenThree.SetActive(true);
                    IsGamePaused = true;
                    Time.timeScale = 0f;
                    Debug.Log("PAUSED");
            }
            




            /*winScreen.SetActive(true);
            IsGamePaused = true;
            Time.timeScale = 0f;
            Debug.Log("PAUSED");*/

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

