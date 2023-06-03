using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 47f;
    
    void Update ()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
