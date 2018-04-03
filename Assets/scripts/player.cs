using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    
    Quaternion rotation;
    public float speed = 1f;
    public float smooth = 1f;
    public static  int score = 0;
    public float scoreTime = 1;
    public Text scoreText;
    public Text highScoreText;
    public AudioSource planeSound;
    public static int highScore;
    private Touch touch;
    private float timeFlow;
  


    private void Start()
    {
        planeSound = GetComponent<AudioSource>();
        planeSound.Play();
        highScoreText.text = "High Score " + PlayerPrefs.GetInt("highScore", 0).ToString();

    }


    // Update is called once per frame
    void Update () {

        timeFlow += Time.deltaTime;

      

        if ( Input.GetMouseButton(0)  ) {
          

            Vector2 moveDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            Vector2 Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) ;
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            rotation = Quaternion.AngleAxis(angle, new Vector3(0f, 0f, 1f));
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smooth);
            transform.position = Vector2.MoveTowards(transform.position,Direction, speed * Time.deltaTime);
            //   transform.Translate(moveDirection.normalized *speed);
            // transform.Rotate(moveDirection.normalized * rotationSpeed);


        }

        if (timeFlow>=scoreTime)
        {
            timeFlow = 0;
            score+=1;
            scoreText.text = "Score " + score;

            if(score> PlayerPrefs.GetInt("highScore",0))
            {
                PlayerPrefs.SetInt("highScore", score);
                highScoreText.text = "High Score " + score.ToString();
                highScore = score;
            }




        }
       






    }
}
