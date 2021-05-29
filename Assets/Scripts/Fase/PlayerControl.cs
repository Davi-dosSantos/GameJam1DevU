using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {

    public static PlayerControl playerControl;
    public float moveSpeed;
    public float jumpForce;
    private float speedBase;
    public Transform groundCheck;

    public AudioSource jumpSound;
    public AudioSource deathSound;
    public AudioSource chestSound;


    private Rigidbody2D rb;
    private bool grounded = true;
    private float maxSpeed = 150;
    private bool estaVivo = true;

    private Animator animator;

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        speedBase = LevelManager.levelManager.speedBase;
    }

    // Update is called once per frame
    public void Update()
    {
        
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        animator.SetBool("OnGround", grounded);

        if (grounded)
        {
            animator.SetBool("Jump", false);
        }
    }

    public void FixedUpdate()
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
            
            if (grounded) { 
            
                if (Input.GetKey("space")|| Input.GetKey("up"))
                {
                    jumpSound.Play();
                    animator.SetBool("Jump", true);
                    rb.AddForce(new Vector2(0, jumpForce));
                    grounded = false;
                }
                
            }
            if (!grounded)
            {
                if (Input.GetKey("down") || Input.GetKey(KeyCode.LeftAlt))
                {
                    rb.AddForce(new Vector2(0, -jumpForce));
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
            deathSound.Play();
            estaVivo = false;
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            GetComponent<BoxCollider2D>().enabled = false;
            Invoke("GameOver", 2f);

            
        }
    }

    public void GameOver()
    {
        LevelManager.levelManager.GameOver();
    }
    public void GameWin()
    {
        LevelManager.levelManager.GameWin();
    }
    public void GameContinue()
    {
        LevelManager.levelManager.GameContinue();
    }
}


