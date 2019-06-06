using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public Score scoreObject;
    public int coinValue;

    public AudioSource audioObject;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // Unity calls this function when coin touches any other object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the thing we touched is the player
        Player playerScript = collision.collider.GetComponent<Player>();

        // If the thing we touched has a playerscript, that means it is the player
        if (playerScript)
        {
            // We hit the player
            // Add to the score based on our value
            scoreObject.AddScore(coinValue);

            //PLay audio clip on collision
            audioObject.Play();

            // Destroy the gameObject that this script is attached to (the coin)
            Destroy(gameObject);
        }
    }
}
