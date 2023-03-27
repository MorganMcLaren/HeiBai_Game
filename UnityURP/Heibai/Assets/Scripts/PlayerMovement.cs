using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float moveSpeed = 8f;
    public float jumpForce = 16f;
    private float moveHorizontal;
    private float moveVertical;

    private bool isJumping = false;
    public bool isFaceingRight = true;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {

        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        
            rb2d.velocity = new Vector2(moveHorizontal * moveSpeed, moveVertical * jumpForce);

        if(Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpForce));
        }
    }
}
