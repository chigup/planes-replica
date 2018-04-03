using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainmenuScore : MonoBehaviour {



    public Text scoreText;


    // Use this for initialization
    void start()
    {

        Debug.Log("Im here");
        scoreText.text = "High Score " + player.highScore;
   




    }



}
