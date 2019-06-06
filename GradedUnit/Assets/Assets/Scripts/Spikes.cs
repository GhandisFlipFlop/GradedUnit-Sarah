using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

    //unity calls this function when damaging elements touch player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collided with has a player script
        Player playerScript = collision.collider.GetComponent<Player>();

        //only do something if the thing we ran into has a player script
        if (playerScript != null)
        {
            //we did hit the player
            //kill the player
            playerScript.Kill();
        }
    }

}
