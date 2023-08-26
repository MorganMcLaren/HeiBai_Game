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
            if(CharacterController.PlayerMovingX == true && CharacterController.PlayerSprinting == true)
            {
                playerAnimator.SetFloat("Speed", 2);
                playerAnimator.SetBool("IsSprinting", true);
            }
            else
            {
                playerAnimator.SetFloat("Speed", 0);
                playerAnimator.SetBool("IsSprinting", false);
            }
            
            if(CharacterController.PlayerMovingX == true)
            {
                playerAnimator.SetFloat("Speed", 1);
            }
            else
            {
                playerAnimator.SetFloat("Speed", 0);
            }

            if(CharacterController.PlayerMovingY)
            {
                playerAnimator.SetBool("IsJumping", true);
            }
            else
            {
                playerAnimator.SetBool("IsJumping", false);
            }
        }
    }
}