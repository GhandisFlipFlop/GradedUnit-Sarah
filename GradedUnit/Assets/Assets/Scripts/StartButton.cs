using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public void StartGame ()
    {

        //Reset Life Counter//
          PlayerPrefs.DeleteKey("lives");


        //Reset the Score Counter//
        PlayerPrefs.DeleteKey("score");


        //Load the first Level//
        SceneManager.LoadScene("Level 1");


    }
}
