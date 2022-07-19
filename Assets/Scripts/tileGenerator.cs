using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileGenerator : MonoBehaviour
{
    //public GameObject tile;
    public Transform generationPoint;
    public float distanceBetween;

    private float tileHeight;

    //public GameObject[] tiles;
    private int tileSelector;


    public objectPooler[] pools;

    private enemyGenerator enemyGenerator;

    public float randomEnemyThreshold;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pools.Length; i++)
        {
            tileHeight = pools[i].pooledObject.GetComponent<BoxCollider2D>().size.y;

        }

        enemyGenerator = FindObjectOfType<enemyGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < generationPoint.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + tileHeight + distanceBetween, transform.position.z);

            tileSelector = Random.Range(0, pools.Length);

            //Instantiate(/*tile*/pools[tileSelector] , transform.position, transform.rotation);
            GameObject newTile = pools[tileSelector].GetPooledObject();

            newTile.transform.position = transform.position;
            newTile.transform.rotation = transform.rotation;
            newTile.SetActive(true);

            /*if (Random.Range(0f, 100f) < randomEnemyThreshold)
            {
                enemyGenerator.spawnEnemies(new Vector3(transform.position.x, transform.position.y, transform.position.z));

            }*/
        }
    }
}
