using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartTeleportBack : MonoBehaviour
{

    public float maxDistance = 1.5f;
    Vector3 originalpos;

    void Start()
    {
        originalpos = transform.position;
    }


    void Update()
    {
        if(Vector3.Distance(transform.position, originalpos) >= maxDistance)
        {
            transform.position = originalpos;
        }
    }
}
