using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Heibei;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject blackMenu;
    public GameObject whiteMenu;
    public GameObject escButton;

    public HeibeiColour colourToSet;


    void Start()
    {
        Hide();
    }

    void Hide()
    {
        blackMenu.SetActive(false);
        whiteMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "MainMenuScene" ||
                SceneManager.GetActiveScene().name == "EndingScene" ||
                SceneManager.GetActiveScene().name == "OpeningScene")
            {
                return;
            }
            EscButton();
            //pauseMenu.SetActive(true);
        }
    }

    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
        Time.timeScale = 1f;
    }

    public void HomeButtonPause()
    {
        SceneManager.LoadScene("MainMenuScene");

    }

    public void EscButton()
    {   
        Time.timeScale = 0f;
        Debug.Log("Pause menu colour: " + colourToSet);

        if (colourToSet == HeibeiColour.BLACK)
        {
            blackMenu.SetActive(true);
        }
        else if(colourToSet == HeibeiColour.WHITE)
        {
            whiteMenu.SetActive(true);
        }
    }

    public void SetColour(HeibeiColour colour)
    {
        colourToSet = colour;
        Debug.Log("Pause menu colour: " + colourToSet);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1f;
        //The resume button uses unity events to hide the pause menu
    }

    public void SkipCutsceneOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SkipCutSceneTwo()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}