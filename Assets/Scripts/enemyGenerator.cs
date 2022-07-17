using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour
{
    public objectPooler enemyPool;

    public void spawnEnemies(Vector3 startPosition)
    {
        GameObject enemy1 = enemyPool.GetPooledObject();
        enemy1.transform.position = startPosition;
        enemy1.SetActive(true);

        
    } 
}
