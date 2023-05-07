using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    //public GameObject winScreenZeroT;
    
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

        //winScreenZeroT = GameObject.Find("WinScreen(NoStar)");
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
        IsGamePaused = false;
        Time.timeScale = 1f;
        Debug.Log("RESMUED");
        
        /*if(winScreenZero.activeSelf == false || winScreenOne.activeSelf == false || winScreenTwo.activeSelf == false || winScreenThree.activeSelf == false )
        {
            SceneManager.LoadScene("MainMenuScene");
        }
        else
        {
            winScreenZero.SetActive(false);
            winScreenOne.SetActive(false);
            winScreenTwo.SetActive(false);
            winScreenThree.SetActive(false);
            SceneManager.LoadScene("MainMenuScene");
        }*/
    }

    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
        IsGamePaused = false;
        Time.timeScale = 1f;
        Debug.Log("RESMUED");
    }
}

