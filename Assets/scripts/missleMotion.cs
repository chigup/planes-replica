using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class missleMotion : MonoBehaviour
{

    private Transform target;

    public float speed = 5f;
    public float rotateSpeed = 200f;

    private Rigidbody2D rb;
    public GameObject particle;
    public GameObject missileParticle;
    public static  bool isDead = false;
   // public GameObject explodeClip;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
       // explodeClip.SetActive(false);
    }


    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * speed;

       
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Instantiate(missileParticle, transform.position, transform.rotation);
       // Destroy(effect);
        // Put a particle effect here
        Destroy(gameObject);

        if (collider.tag == "Player")
        {
            Dead();


        }
        
    }


    void Dead()
    {
        isDead = true;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Instantiate(particle, player.transform);
       // explodeClip.SetActive(true);
        Destroy(player);
      
 
        Debug.Log("dead");
    
      
        Application.LoadLevel(2);
      
        
    }




}