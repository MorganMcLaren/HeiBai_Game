using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject winScreen;

    void Start()
    {
        //winScreen.SetActive(false);
    }
    
    

    public void OnTriggerEnter2D()
    {

        //stars = GetComponent.StarPickups.GetStars;

        //Debug.Log("Total: " + stars);


        winScreen.SetActive(true);
        



        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

