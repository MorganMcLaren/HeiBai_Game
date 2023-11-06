using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public AudioMixer SFXMixer;
    public AudioMixer musicMixer;
    
    //basic code to load from menu scene to game scene. In future this will load you into the level select screen directly.
    public void startGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //starter code for muting the SFX from menu screen
    public void muteGame(float SFX)
    {
        Debug.Log("SOUND");
        SFXMixer.SetFloat("SFXVolume", SFX);
    }

    //starter code for muting the music from menu screen
    public void muteMusic (float music)
    {
        Debug.Log("MUSIC");
        musicMixer.SetFloat("musicVolume", music);
    }

    //quits the game when the quit button is pressed
    public void quitGame()
    {
        Debug.Log("QUIT!");
        SceneManager.LoadScene("MainMenuScene");
    }//

    /*void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            //deactivate menu object and activate quit menu object
            Debug.Log("quit menu");
        }
    }*/
    
}
