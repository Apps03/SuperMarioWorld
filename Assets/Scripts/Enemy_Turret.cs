using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Turret : MonoBehaviour {

    
    public Transform projectileSpawnPoint;
    public Projectile projectilePrefab;
    public float projectileForce;

    
    public float projectileFireRate;
    float timeSinceLastFire = 0.0f;

    
    public int health;

    
    void Start () {
        
        if (!projectileSpawnPoint)
        {
            
            Debug.LogError("No projectileSpawnPoint found on GameObject");
        }

        
        if (!projectilePrefab)
        {
        
            Debug.LogError("No projectilePrefab found on GameObject");
        }

        
        {
           
            projectileForce = 7.0f;

           
            Debug.Log("projectileForce was not set. Defaulting to " + projectileForce);
        }

        
        if (projectileFireRate == 0)
        {
            
            projectileFireRate = 2.0f;

            
            Debug.Log("projectileFireRate was not set. Defaulting to " + projectileFireRate);
        }

        
        if (health == 0)
        {
       
            health = 5;

            
            Debug.Log("health was not set. Defaulting to " + health);
        }
    }
	
	
	void Update () {
        
        if (Time.time > timeSinceLastFire + projectileFireRate)
        {
            
            fire();

            
            timeSinceLastFire = Time.time;
        }
    }

    
    void fire()
    {
        
        Projectile temp =
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);

        
        temp.speed = projectileForce;
    }

    
    private void OnCollisionEnter2D(Collision2D c)
    {
        
        if(c.gameObject.tag == "Projectile")
        {
            
            health--;
            
            
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
