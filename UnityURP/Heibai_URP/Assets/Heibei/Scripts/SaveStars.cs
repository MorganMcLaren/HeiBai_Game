using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveStars : MonoBehaviour
{

    
    int starsLS;
    int starsLS1;

    public GameObject level1Stars;

    



    // Start is called before the first frame update
    void Start()
    {
        starsLS = StarPickups.starsCollected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    /*public int starCheck()
    {
        if (starsLS >= 3)
        {
            levelSave();

        }
    }


    public int levelSave()
    {

        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Level_1")
        {
            starsLS = starsLS1;

           if (starsLS1 == 3)
            {
                level1Stars.SetActive(true);
            }

            starsLS = 0;
        }
        else if (sceneName == "Level_2")
        {
            // Do something...
        }





    }*/


    
}