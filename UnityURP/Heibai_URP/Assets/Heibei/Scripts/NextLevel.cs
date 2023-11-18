using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public GameObject winScreenZero;
    public GameObject winScreenOne;
    public GameObject winScreenTwo;
    public GameObject winScreenThree;

    public int stars = 0;

    public static bool IsLevelBeaten = false;

    void Start()
    {
        stars = 0;
        
    }

    void OnTriggerEnter2D(Collider2D portalcollision)
    {
        //Debug.Log("PORTAL");
        
        if (portalcollision.gameObject.CompareTag("PlayerCollider"))
        {


            stars = StarPickups.starsCollected;
            

            Debug.Log("Total: " + stars);

            if (stars <= 0)
            {
                winScreenZero.SetActive(true);
                IsLevelBeaten = true;
                Time.timeScale = 0f;
                //Debug.Log("PAUSED");

            }

            else if (stars == 1)
            {
                winScreenOne.SetActive(true);
                IsLevelBeaten = true;
                Time.timeScale = 0f;
                //Debug.Log("PAUSED");
            }

            else if (stars == 2)
            {
                winScreenTwo.SetActive(true);
                IsLevelBeaten = true;
                Time.timeScale = 0f;
                //Debug.Log("PAUSED");
            }

            else if (stars >= 3)
            {
                winScreenThree.SetActive(true);
                IsLevelBeaten = true;
                Time.timeScale = 0f;
                //Debug.Log("PAUSED")


            }


            StarPickups.starsCollected = 0;
        }


    }

    public void NextLevelButton()
    {
        if(IsLevelBeaten == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            StarPickups.starsCollected = 0;
            IsLevelBeaten = false;
            Time.timeScale = 1f;
            Debug.Log("RESMUED");
        }
    }


    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenuScene");
        StarPickups.starsCollected = 0;
        IsLevelBeaten = false;
        Time.timeScale = 1f;
        Debug.Log("RESMUED");
    }

    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
        StarPickups.starsCollected = 0;
        IsLevelBeaten = false;
        Time.timeScale = 1f;
        Debug.Log("RESMUED");
    }

    void Update()
    {
        if (IsLevelBeaten == true)
        {
            Debug.Log("BEATEN");
            if (Input.GetKeyDown(KeyCode.F)) {NextLevelButton();}
            if (Input.GetKeyDown(KeyCode.M)) {HomeButton();}
            if (Input.GetKeyDown(KeyCode.L)) {LevelSelectButton();}
        }
    }
}

