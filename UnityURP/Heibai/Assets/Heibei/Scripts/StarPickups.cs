using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickups : MonoBehaviour
{

    public int starsCollected = 0; 

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            Debug.Log("Player picked up");

            Destroy(collision.gameObject);

            starsCollected++;
            Debug.Log("Stars Collected: " + starsCollected);

        }



    }



}
