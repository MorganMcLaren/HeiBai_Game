using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickups : MonoBehaviour
{

    public static int starsCollected = 0;
    public ParticleSystem poofW;
    public ParticleSystem poofB;


    public void OnTriggerEnter2D(Collider2D starcollision)
    {
        if (starcollision.gameObject.CompareTag("PlayerCollider"))
        {
            
            
            Debug.Log("Player picked up");



            GetStars();

            poofW.Play();
            poofB.Play();

            Destroy(gameObject);
            
            /*starsCollected++;
            
            Debug.Log("Stars Collected: " + starsCollected);*/

            //return (starsCollected);

        }

    

    }

    public void GetStars()
    {
        starsCollected++;

        Debug.Log("Stars Collected: " + starsCollected);
    }


}
