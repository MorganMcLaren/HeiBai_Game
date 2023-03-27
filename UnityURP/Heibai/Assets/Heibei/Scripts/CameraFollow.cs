using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heibei
{
    public class CameraFollow : MonoBehaviour
    {
        Camera cam;
        float _initialZ;
        public Transform target;
        public float followSpeed = 0.5f;

        // Start is called before the first frame update
        void Start()
        {
            cam = Camera.main;
            _initialZ = cam.transform.position.z;
        }

        // Update is called once per frame
        void Update()
        {
            cam.transform.position = Vector2.Lerp(cam.transform.position, target.position, followSpeed);
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, _initialZ);
        }
    }
}