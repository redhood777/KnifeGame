using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileDestroyer : MonoBehaviour
{
    public GameObject tileDestroyerPoint;

    // Start is called before the first frame update
    void Start()
    {
        tileDestroyerPoint = GameObject.Find("TileDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < tileDestroyerPoint.transform.position.y)
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}
