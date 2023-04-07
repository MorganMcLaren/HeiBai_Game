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
    
    public void startGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void muteGame(float SFX)
    {
        Debug.Log("SOUND");
        SFXMixer.SetFloat("SFXVolume", SFX);
    }

    public void muteMusic (float music)
    {
        Debug.Log("MUSIC");
        musicMixer.SetFloat("musicVolume", music);
    }

    public void quitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }//
}
