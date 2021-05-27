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


    private float distanceBtween;
    private int platformSelector;
    private float[] platformWidths;

    //public GameObject[] thePlatforms;


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
                
            if (LevelManager.levelManager.keysAtual < 5)
            {
                platformSelector = Random.Range(0, theObjectPools.Length - 1);
            }else 
            {
                platformSelector = (theObjectPools.Length-1);
            }
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 3) + distanceBtween, transform.position.y);

                GameObject newPlataform = theObjectPools[platformSelector].GetPooledObject();

                newPlataform.transform.position = transform.position;
                newPlataform.transform.rotation = transform.rotation;
                newPlataform.SetActive(true);

                transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBtween, transform.position.y);

            }
        }
        
    }

