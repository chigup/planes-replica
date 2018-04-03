using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAgain : MonoBehaviour
{


  public  void againPlay()

    {
      
        Application.LoadLevel(1);

    }


    public void back()
    {

        Application.LoadLevel(0);


    }



}