using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGerator : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    public float platformWidth;
    public float distanceBtweenMin;
    public float distanceBtweenMax;
    public ObjectPooler[] theObjectPools;
    public Transform maxHeightPoint;
    public float maxHeightChange;


    private float distanceBtween;
    private int platformSelector;
    private float[] platformWidths;
    private float minHeight;
    private float maxHeight;
    private float heightChange;
    //public GameObject[] thePlatforms;


    // Start is called before the first frame update
    void Start()
    {
        platformWidths = new float[theObjectPools.Length];

        for (int i = 0; i < theObjectPools.Length; i++)
        {
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x; 
        }

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBtween = Random.Range(distanceBtweenMin, distanceBtweenMax);

            platformSelector = theObjectPools.Length;

            heightChange = transform.position.y + Random.Range(maxHeightChange, - maxHeightChange);

           
            if(heightChange > maxHeight)
            {
                heightChange = maxHeight;
            }
            else if (heightChange < minHeight)
            {
                heightChange = minHeight;
            }
            
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]/2) + distanceBtween, heightChange);


            GameObject newPlataform = theObjectPools[platformSelector].GetPooledObject();

            newPlataform.transform.position = transform.position;
            newPlataform.transform.rotation = transform.rotation;
            newPlataform.SetActive(true);

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBtween, transform.position.y);
        }
    }
}
