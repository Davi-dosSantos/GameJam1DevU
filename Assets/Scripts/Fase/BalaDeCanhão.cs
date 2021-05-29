using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDeCanhão : MonoBehaviour
{
    public float speed;
    Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = transform.right * speed;
    }

    
}
