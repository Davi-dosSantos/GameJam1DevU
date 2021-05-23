using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float multiplicSpeedKeysNum = 0.2F;
    public float maxSpeed = 100;
    public float speed = 5;
    public float jumpForce = 500;
    public Transform groundCheck;
    private float keysSpeedAdd = (LevelManager.levelManager.keysAtual + 1) ;

    private bool grounded = true;
    private bool enemies = false;

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
        speed = speed * keysSpeedAdd * multiplicSpeedKeysNum;
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
    }

    private void FixedUpdate()
    {
        if (estaVivo)
        {
            rb.AddForce(Vector2.right * speed * keysSpeedAdd);

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
        }
    }
}


