using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyScroll : MonoBehaviour {


    private BoxCollider2D skyCollider;
    private float skyColliderLengthX;
      private float skyColliderLengthY;
    // Use this for initialization
    void Start () {
        skyCollider = GetComponent<BoxCollider2D>();
        skyColliderLengthX = skyCollider.size.x;
        skyColliderLengthY = skyCollider.size.y;

	}
	
	// Update is called once per frame
	void Update () {
		
      //  if(transform.position.x<)






	}
}
