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
    
    //basic code to load from menu scene to game scene
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

    //quits the game to menu when the quit button is pressed
    public void quitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }//

    public void levelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    
}
