using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{


    public Transform target;
    public Vector3 offset;
    public float smooth = 1;

 

    private void Update()
    {

        if(!missleMotion.isDead)
        transform.position = new Vector3(target.position.x, target.position.y,transform.position.z);
    }






}
