using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public float speed;

    
    public float lifeTime;

	
	void Start () {

        
        if (speed <= 0)
        {
            
            speed = 7.0f;

            
            Debug.Log("speed was not set. Defaulting to " + speed);
        }

        
        if (lifeTime <= 0)
        {
            
            lifeTime = 1.0f;

            
            Debug.Log("lifeTime was not set. Defaulting to " + lifeTime);
        }

        
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        
        
        Destroy(gameObject,lifeTime);

    }

    
    void OnCollisionEnter2D(Collision2D c)
    {
        
        if (c.gameObject.tag != "Player")
        {
            
            Destroy(gameObject);
        }

       
    }
}
