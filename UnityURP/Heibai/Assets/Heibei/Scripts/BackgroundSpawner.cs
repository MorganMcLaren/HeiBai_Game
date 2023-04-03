using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    public GameObject whiteBackground;
    public GameObject blackBackground;
    public float delay = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MakeObject", delay); //call the MakeObject function after "delay" seconds
    }

    void MakeObject()
    {
        Instantiate(whiteBackground); //instantiate the object here (Morgan - "I Added postion called so where spawner is placed will be location of player spawn")
        Instantiate(blackBackground);
    }
}
