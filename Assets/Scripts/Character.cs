using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Transform groundCheck;
    public LayerMask isGroundLayer;
    public Animator animator;
    public Rigidbody2D rigidbody;
    public GameObject projectilePrefab;
    public Transform spawpoint;
    private float lives;

    public float speed = 1.0f;
    public int jumpForce = 2;
    public float groundCheckRadius = 0.2f;
    public float projectileSpeed;


    private bool isGrounded;
    private bool isFacingRight = true;

    public class Projectile : MonoBehaviour
    {
        public float speed;
        public float lifeTime;

    }
    
    void Start()
    {
        if (lifeTime)
        {
            lifeTime > 1.0f;        
        }
        if(jumpForce <=0)
        {
            jumpForce = 2;
        }
        if(speed <= 0)
        {
            speed = 1;
        }
        if(groundCheckRadius <= 0)
        {
            groundCheckRadius = 0.2f;
        }
        if(!rigidbody)
        {
            GetComponent<Rigidbody2D>();
        }
        if(!animator)
        {
            GetComponent<Animator>();
        }

    }

    
    void Update()

    {
        float moveValue = Input.GetAxisRaw("Horizontal");
        Vector2 xMovement = new Vector2(moveValue * speed, rigidbody.velocity.y);
        
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        rigidbody.velocity = xMovement;
        animator.SetFloat("Speed", Mathf.Abs(moveValue));

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, isGroundLayer);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
                Debug.Log("Jump");
                rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);            
        }
    }
    
}

if (Input.getbuttondown("Fire"))

if(moveValue < 0 && isFacingRight) || (moveValue > 0 && !isFacingRight)
    {
    flip();
    }


void flip()
{
    isFacingRight = !isfacingRight;

    scaleValue = transform.localScale;

    scaleValue.x = -scaleValue.x;

    transform.localscale = scaleValue;




}

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision gameObject.layer == Ground)
        {

    }


}



public void decrement lives;
{
    lives = -;
    if ( lives < 0)

}