using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGerator : MonoBehaviour
{
    public int minRangeY = -8;
    public int maxRangeY = 8;

    public GameObject thePlataform;
    public Transform generationPoint;
    public float distanceBtween = 25;

    private float plataformWidth;

    private float distanceBtweenMin;
    private float distanceBtweenMax;


    // Start is called before the first frame update
    void Start()
    {
        plataformWidth = thePlataform.GetComponent<BoxCollider2D>().size.x; 
    }

    // Update is called once per frame
    void Update()
    {
        distanceBtween = Random.Range(distanceBtweenMin, distanceBtweenMax);

        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector2(transform.position.x + plataformWidth + distanceBtween, transform.position.y);
            Instantiate(thePlataform, transform.position, transform.rotation);
                }
    }
}
