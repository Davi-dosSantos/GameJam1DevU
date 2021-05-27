using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public ObjectPooler EnemyPool;
    public void SpawnEnemy(Vector3 startPosition)
    {
        GameObject enemy = EnemyPool.GetPooledObject();
        enemy.transform.position = startPosition;
        enemy.SetActive(true);
    }
}
