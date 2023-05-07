using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void OneButton()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void TwoButton()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void ThreeButton()
    {
        SceneManager.LoadScene("LevelThree");
    }

    public void FourButton()
    {
        SceneManager.LoadScene("LevelFour");
    }

    public void FiveButton()
    {
        SceneManager.LoadScene("LevelFive");
    }

    public void SixButton()
    {
        SceneManager.LoadScene("LevelSix");
    }

    public void SevenButton()
    {
        SceneManager.LoadScene("LevelSeven");
    }

    public void EightButton()
    {
        SceneManager.LoadScene("LevelEight");
    }

    public void NineButton()
    {
        SceneManager.LoadScene("LevelNine");
    }

    public void TenButton()
    {
        SceneManager.LoadScene("LevelTen");
    }
}
