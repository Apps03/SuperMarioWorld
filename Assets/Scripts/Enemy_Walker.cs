using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_Walker : MonoBehaviour {

   
    Rigidbody2D rb;

    
    public float speed;

    
    public bool isFacingRight;

   
    void Start () {
      
        rb = GetComponent<Rigidbody2D>();

       
        if (!rb)
        {
            
            Debug.LogWarning("No Rigidbody2D found.");
        }

        
        if (speed <= 0)
        {
            
            speed = 5.0f;

            
            Debug.LogWarning("Default speed to " + speed);
        }
    }
	
	
	void Update () {

       
        if (!isFacingRight)
            
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        else
            
            rb.velocity = new Vector2(speed, rb.velocity.y);

    }

   
    private void OnTriggerEnter2D(Collider2D c)
    {
        
        if (c.gameObject.tag == "Enemy_Barrier")
            
            flip();
    }

    
    private void OnCollisionEnter2D(Collision2D c)
    {
       
        if (c.gameObject.tag == "Enemy" || c.gameObject.tag == "Player")
            
            flip();
    }

   
    void flip()
    {
        
        isFacingRight = !isFacingRight;

        
        Vector3 scaleFactor = transform.localScale;

        
        scaleFactor.x *= -1;    // scaleFactor.x = -scaleFactor.x;

        
        transform.localScale = scaleFactor;
    }
}
