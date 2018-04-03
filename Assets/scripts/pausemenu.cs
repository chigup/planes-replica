using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour {

    private bool isPaused = false;
    public GameObject pauseUI;
    // Update is called once per frame

   
    void Update () {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }

	}



    public void resume()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseUI.SetActive(false);
    }
    public void pause()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseUI.SetActive(true);
    }





}
