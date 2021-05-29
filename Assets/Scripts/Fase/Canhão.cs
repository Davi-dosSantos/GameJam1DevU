using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhão : MonoBehaviour

{
    public Transform firepoint;
    public GameObject bullet;
    float timebetween;
    public float starttimebetween;
    public AudioSource bulletSound;
    public GameObject PlayerObject;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.Find("Player");
        timebetween = starttimebetween;
    }

    // Update is called once per frame
    void Update()
    {
        if (timebetween <= 0)
        {
            if(PlayerObject.transform.position.x < transform.position.x) { 
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            timebetween = starttimebetween;
            bulletSound.Play();
          }
        }
        else
        {
            timebetween -= Time.deltaTime;
        }
    }
}

