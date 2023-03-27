using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heibei
{
    public class HeibeiPlayer : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            HeibeiGameManager.Instance.RefreshLevelObjectColours();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}