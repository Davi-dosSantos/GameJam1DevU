using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGerator : MonoBehaviour
{

    public GameObject thePlatform;

    public static PlataformGerator plataformGerator;
    public Transform generationPoint;
    public float platformWidth;
    public float distanceBtweenMin;
    public float distanceBtweenMax;
    public ObjectPooler[] theObjectPools;
    public int NumKeysWin;

    private float distanceBtween;
    private int platformSelector;
    private float[] platformWidths;

    private KeysGenerator theKeysGenerator;
    private EnemyGenerator theEnemyGenerator;

    //public GameObject[] thePlatforms;


    // Start is called before the first frame update
    void Start()
    {
        platformWidths = new float[theObjectPools.Length];

        for (int i = 0; i < theObjectPools.Length; i++)
        {
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }

        theKeysGenerator = FindObjectOfType<KeysGenerator>();
        theEnemyGenerator = FindObjectOfType<EnemyGenerator>();

    }

    // Update is called once per frame
    void Update()
    {
            if (transform.position.x < generationPoint.position.x)
            {
            distanceBtween = Random.Range(distanceBtweenMin, distanceBtweenMax);
                
            if (LevelManager.levelManager.keysAtual < NumKeysWin)
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
            if (Random.Range(0, 3) == 1)
            {
                theKeysGenerator.SpawnKeys(new Vector3(transform.position.x, transform.position.y + Random.Range(1, 5)));
            }
            if (Random.Range(0, 6) == 1)
            {
                theEnemyGenerator.SpawnEnemy(new Vector3(transform.position.x, transform.position.y + 1F));
            }
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBtween, transform.position.y);

            }
        }

    public void SetMaxKeys(int KeysWin = 5)
    {

        NumKeysWin = KeysWin;
    }
    

}

