using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float followSpeed = 2f;
    public float yOffset;
    public Transform target;

   

    
    void Update()
    {
        Vector3 newPos = new Vector3(0, target.position.y + yOffset, -10);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed);
    }
}
