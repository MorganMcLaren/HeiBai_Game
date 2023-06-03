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
        SceneManager.LoadScene("Level_1");
    }

    public void TwoButton()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void ThreeButton()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void FourButton()
    {
        SceneManager.LoadScene("Level_4");
    }

    public void FiveButton()
    {
        SceneManager.LoadScene("Level_5");
    }

    public void SixButton()
    {
        SceneManager.LoadScene("Level_6");
    }

    public void SevenButton()
    {
        SceneManager.LoadScene("Level_7");
    }

    public void EightButton()
    {
        SceneManager.LoadScene("Level_8");
    }

    public void NineButton()
    {
        SceneManager.LoadScene("Level_9");
    }

    public void TenButton()
    {
        SceneManager.LoadScene("Level_10");
    }
}
