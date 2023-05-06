using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heibei
{
    public class HeibeiPlayer : MonoBehaviour
    {
        void Start()
        {
            HeibeiGameManager.Instance.RefreshLevelObjectColours();
        }
    }
}