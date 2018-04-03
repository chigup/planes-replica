using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] missileTurrent;
    public GameObject missile;
    public int turrentNumber;
    public float time;
    public float timeToSpawn = 5;

    private void Update()
    {
        time += Time.deltaTime;
        if (!missleMotion.isDead)
            spawn();
    }

    void spawn()
    {
        if (time >= timeToSpawn)
        {
            time = 0;
            turrentNumber = Random.Range(0, missileTurrent.Length);

            Transform missilePostion = missileTurrent[turrentNumber].transform;
           

            Debug.Log(missilePostion);


          GameObject child =   Instantiate(missile, missilePostion);
          
            child.transform.parent = null;
            
            
          
        }
    
       
     
    }






}
