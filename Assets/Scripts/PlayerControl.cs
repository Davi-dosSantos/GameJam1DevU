using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public static PlayerControl playerControl;
    public float moveSpeed;
    public float jumpForce = 500;
    public float speedBase = 3;
    public Transform groundCheck;
   
    private Rigidbody2D rb;
    private bool grounded = true;
    private float maxSpeed = 50;
    private bool estaVivo = true;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        animator.SetBool("OnGround", grounded);

        if (grounded)
        {
            animator.SetBool("Jump", false);
        }
    }

    private void FixedUpdate()
    {
        if (estaVivo)
        {
            animator.SetFloat("Speed", rb.velocity.x);

            //velocidade definida na base + pra cada 
            moveSpeed = (speedBase +0.5F*(LevelManager.levelManager.keysAtual+1));
            rb.AddForce(Vector2.right * moveSpeed);
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            if (rb.velocity.x > maxSpeed)
            {
                rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x)* maxSpeed, rb.velocity.y);
            }
            if (grounded)
            {
                if (Input.GetKey("space"))
                {
                    animator.SetBool("Jump", true);
                    rb.AddForce(new Vector2(0, jumpForce));
                    grounded = false;
                }
            }
           
        }else
        {
            Morreu();
        }
        
    }
    public void Morreu()
    {
        if (estaVivo)
        {
            estaVivo = false;
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<CapsuleCollider2D>().enabled = false;
            Invoke("GameOver", 2f);
        }
    }

    public void GameOver()
    {
        LevelManager.levelManager.GameOver();
    }
}


