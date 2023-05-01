using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heibei
{
    public class CharacterController : MonoBehaviour
    {
        Rigidbody2D _rb2d;
        Collider2D _collider;
        bool _onGround = false;
        Vector2 _currentMoveInput;
        bool _currentJumpInput;
        //private bool m_FacingRight = true; //check to see if player is facing right

        public float moveSpeed = 3.0f;
        public float jumpForce = 5.0f;
        public Collider2D groundChecker;
        public ContactFilter2D contactFilter;



        void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
            _collider = GetComponent<Collider2D>();
        }
        // Start is called before the first frame update
        void Start()
        {
            _currentJumpInput = false;
            _currentMoveInput = Vector2.zero;
        }

        // Update is called once per frame
        void Update()
        {
            CheckGround();
            GetInput();
            if (_currentJumpInput)
                Jump();
            Move();
        }

        void GetInput()
        {
            _currentMoveInput.x = Input.GetAxis("Horizontal");
            //don't bother setting y, we aren;t using it.
            _currentJumpInput = Input.GetButton("Jump");
        }

        void CheckGround()
        {
            Collider2D[] results = new Collider2D[2];
            if (Physics2D.OverlapCollider(groundChecker, contactFilter, results) > 0)
            {
                _onGround = true;
                _rb2d.velocity = new Vector2(_rb2d.velocity.x, 0); //reset vertical velocity to 0

                // You can debug print the colliding objects with this code
                /*
                for (int i = 0; i < results.Length; i++)
                {
                    if (results[i] != null)
                    {
                        Debug.Log(results[i].gameObject.name);
                    }
                }
                */
            }
            else
            {
                _onGround = false;
            }
        }

        void Jump()
        {
            if (_onGround)
            {
                _onGround = false;
                _rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        void Move()
        {
            /*/ If the input is moving the player right and the player is facing left...
		    if (moveSpeed > 0 && !m_FacingRight)
		    {
		    	// ... flip the player.
		    	Flip();
		    }
		    // Otherwise if the input is moving the player left and the player is facing right...
		    else if (moveSpeed < 0 && m_FacingRight)
		    {
			    // ... flip the player.
			    Flip();
		    }*/
            
            transform.position += (Vector3)(Vector2.right * _currentMoveInput.x * moveSpeed * Time.deltaTime);
        }

        /*private void Flip()
	    {
		    // Switch the way the player is labelled as facing.
		    m_FacingRight = !m_FacingRight;

		    // Multiply the player's x local scale by -1.
		    Vector3 theScale = transform.localScale;
		    theScale.x *= -1;
		    transform.localScale = theScale;
	    }*/

    }
}