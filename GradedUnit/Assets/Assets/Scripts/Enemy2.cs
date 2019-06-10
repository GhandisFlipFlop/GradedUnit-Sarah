using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    

    private bool dirRight = true;
    public float speed = 0.6f;
    public float leftedge = 16f;
    public float rightedge = 22f;
    public SpriteRenderer enemySprite;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            enemySprite.flipX = true;
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            enemySprite.flipX = false;
        }

        if (transform.position.x >= rightedge)
        {
            dirRight = false;
        }

        if (transform.position.x <= leftedge)
        {
            dirRight = true;
        }
    }
}
