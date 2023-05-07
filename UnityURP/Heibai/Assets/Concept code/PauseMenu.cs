using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }

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