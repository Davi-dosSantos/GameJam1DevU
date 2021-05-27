using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysGenerator : MonoBehaviour
{

    public ObjectPooler KeyPool;
    public void SpawnKeys(Vector3 startPosition)
    {
        GameObject key = KeyPool.GetPooledObject();
        key.transform.position = startPosition;
        key.SetActive(true);
    }
}
