using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playAgainScreenScore : MonoBehaviour {


    public Text scoreText;

	// Use this for initialization
	void Start () {

        scoreText.text = "Score " + player.score;
        player.score = 0;

	}
	

}
