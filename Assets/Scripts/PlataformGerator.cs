using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGerator : MonoBehaviour
{

    public GameObject thePlataform;
    public Transform generationPoint;
    public float distanceBtween;

    public float plataformWidth;

    private float distanceBtweenMin = 6;
    private float distanceBtweenMax = 10;

    public ObjectPooler theObjectPool;

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
            //Instantiate(thePlataform, transform.position, transform.rotation);
            GameObject newPlataform = theObjectPool.GetPooledObject();

            newPlataform.transform.position = transform.position;
            newPlataform.transform.rotation = transform.rotation;
            newPlataform.SetActive(true);
                }
    }
}
