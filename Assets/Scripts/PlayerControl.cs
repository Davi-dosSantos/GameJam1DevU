using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

<<<<<<< HEAD
    public static PlayerControl playerControl;
    public float MaxSpeedMultply = 0.5F;
    private float speedBase = 10;
    public float moveSpeed = 7;
    public float maxSpeed = 100;
=======
    public float multiplicSpeedKeysNum = 0.2F;
    public float maxSpeed = 100;
    public float speed = 5;
>>>>>>> ea7295e643c75980d70e33f06c5a2a214236e994
    public float jumpForce = 500;
    public Transform groundCheck;
    private float keysSpeedAdd = (LevelManager.levelManager.keysAtual + 1) ;

    private bool grounded = true;

    private Rigidbody2D rb;
    private bool estaVivo = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
        speed = speed * keysSpeedAdd * multiplicSpeedKeysNum;
>>>>>>> ea7295e643c75980d70e33f06c5a2a214236e994
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
    }

    private void FixedUpdate()
    {
        if (estaVivo)
<<<<<<< HEAD
        { 
            moveSpeed = speedBase * (LevelManager.levelManager.keysAtual + 1) * MaxSpeedMultply;
            
            
            rb.AddForce(Vector2.right * moveSpeed);
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
=======
        {
            rb.AddForce(Vector2.right * speed * keysSpeedAdd);

>>>>>>> ea7295e643c75980d70e33f06c5a2a214236e994
            if (rb.velocity.x > maxSpeed)
            {
                rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x)* maxSpeed, rb.velocity.y);
            }
            if (grounded)
            {
                if (Input.GetKey("space"))
                {
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


