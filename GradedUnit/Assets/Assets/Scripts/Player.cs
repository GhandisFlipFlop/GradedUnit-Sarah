using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allows us to use scene management
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed = 10;
    public float jumpSpeed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string jumpButton = "jump";

    public Animator playerAnimator;
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);

        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        // Make direction vector length 1
        direction = direction.normalized;

        // Calculate the velocity
        Vector2 velocity = direction * speed;
        velocity.y = physicsBody.velocity.y;

        // Give the velocity to the rigid body
        physicsBody.velocity = velocity;


        // Tell the animator our speed
        playerAnimator.SetFloat("walkspeed", Mathf.Abs(velocity.x));

        // Flip our sprite if we're moving backwards.
        if (velocity.x < 0)
        {
            playerSprite.flipX = true;

        }

        else
        {
            playerSprite.flipX = false;
        }

        // Jumping

        //Detect if we are touching the ground
        // Get the LayerMask using the name of the layer

        LayerMask groundLayerMask = LayerMask.GetMask("Ground");

        //Ask the player's collider if we are touching the mask

        bool touchingGround = playerCollider.IsTouchingLayers(groundLayerMask);
        

        bool jumpButtonPressed = Input.GetButtonDown(jumpButton);
        if (jumpButtonPressed == true && touchingGround == true)
        {
            // We have pressed jump, so we should set our upward velocity to jumpSpeed
            velocity.y = jumpSpeed;

            // Give the velocity to rigidbody
            physicsBody.velocity = velocity;


        }



    }

    //Function for being able to murder player in brutal fashion
    public void Kill()
    {
        // reset current level to restart from beginning
        // ask unity what the current level is
        Scene currentLevel = SceneManager.GetActiveScene();

        // Tell unity to load current level again
        // pass the build index of our level
        SceneManager.LoadScene(currentLevel.buildIndex);
    }

}
