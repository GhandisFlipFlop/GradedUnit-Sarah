using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// allows us to use scene management
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public string sceneToLoad;
    //public string DefeatScreen;
    public ScoreManager scoreObject;
    public int scoreNeeded = 0;
    public Text scoreText;

    private AudioSource needmorepoints;

    // Use this for initialization
    void Start()
    {
        needmorepoints = GameObject.Find("NotEnoughPoints").GetComponent<AudioSource>();
    }

    //unity calls this function when something collides with player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collided with has a player script
        Player playerScript = collision.collider.GetComponent<Player>();
        //only do something if the thing we ran into has a player script
          if (playerScript != null && scoreObject.GetScore() >= scoreNeeded)
        {
            ////we DID hit the player
            scoreObject.SaveScore();

            //GO TO NEXT LEVEL
            SceneManager.LoadScene(sceneToLoad);
        }
        else if (playerScript != null && scoreObject.GetScore() < scoreNeeded)
        {
            //SceneManager.LoadScene(DefeatScreen);//
            scoreText.color = Color.red;
            needmorepoints.Play();
            

        }
    }

}
