using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heibei
{
    public class ObjectSpawner : MonoBehaviour
    {
        public GameObject objectToSpawn;
        public float delay = 0;
        // Start is called before the first frame update
        void Start()
        {
            Invoke("MakeObject", delay); //call the MakeObject function after "delay" seconds
        }

        void MakeObject()
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation); //instantiate the object here (Morgan - "I Added postion called so where spawner is placed will be location of player spawn")
        }
    }
}