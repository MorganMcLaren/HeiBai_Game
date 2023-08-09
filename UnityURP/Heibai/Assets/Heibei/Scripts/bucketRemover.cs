using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketRemover : MonoBehaviour
{

    public GameObject bucketToRemove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCollider"))
        {
            Debug.Log("test");
            Destroy(bucketToRemove);
        }
    }





}
