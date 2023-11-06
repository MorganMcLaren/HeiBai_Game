using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public string levelToLoad;
    public GameObject skipButton;
    public GameObject levelSelectButton;
    private float timer = 47f;
    private float timer2 = 55f;
    
    void Update ()
    {
        Cutscene();
        Cutscene2();
    }

    public void Cutscene()
    {
        if (levelToLoad == "Level_1")
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Application.LoadLevel(levelToLoad);
            }
        }
        
    }

    public void Cutscene2()
    {
        if (levelToLoad == "Level_2")
        {
            timer2 -= Time.deltaTime;
            if (timer2 <= 0)
            {
            skipButton.SetActive(false);
            levelSelectButton.SetActive(true);
            }
        }
        
    }
}
