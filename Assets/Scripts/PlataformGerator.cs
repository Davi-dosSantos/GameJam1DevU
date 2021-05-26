using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGerator : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    private float distanceBtween;

    public float platformWidth;

    public float distanceBtweenMin;
    public float distanceBtweenMax;

    //public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;
        
    public ObjectPooler[] theObjectPools;

    // Start is called before the first frame update
    void Start()
    {
        platformWidths = new float[theObjectPools.Length];

        for (int i = 0; i < theObjectPools.Length; i++)
        {
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x; 
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBtween = Random.Range(distanceBtweenMin, distanceBtweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length);
            
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]/2) + distanceBtween, transform.position.y);
           
            
            GameObject newPlataform = theObjectPools[platformSelector].GetPooledObject();

            newPlataform.transform.position = transform.position;
            newPlataform.transform.rotation = transform.rotation;
            newPlataform.SetActive(true);

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBtween, transform.position.y);

        }
    }
}
