using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject blackMenu;
    public GameObject whiteMenu;

    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Escape))
        {
            EscButton();
            pauseMenu.SetActive(true);
        }*/
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
        //Debug.Log("WHAT");
        Time.timeScale = 0f;
        /*OnClick()
        {
            if(variable that marks the game as being in "black mode" is ture)
                {
                    open black pausemenu
                }

                else
                {
                    open white pausemenu
                }
        }*/
    }

    public void ResumeButton()
    {
        Time.timeScale = 1f;
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