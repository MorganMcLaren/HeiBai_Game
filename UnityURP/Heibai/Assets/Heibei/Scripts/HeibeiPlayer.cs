using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heibei
{
    public class HeibeiPlayer : MonoBehaviour
    {
        public Animator playerAnimator;
        
        void Start()
        {
            HeibeiGameManager.Instance.RefreshLevelObjectColours();
        }

        void Update()
        {
            //playerAnimator.SetFloat("Speed", Mathf.Abs(CharacterController.PlayerMoving));
        }
    }
}