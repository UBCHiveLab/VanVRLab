using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowEffect : MonoBehaviour
{

    public Transform A, B;
    public float speed = 1.0f;
    TrailRenderer tRender;

    private void Awake()
    {
        transform.position = A.position;

        tRender = GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, B.position, Time.deltaTime * speed);

        if(Vector3.Distance(transform.position, B.position) <= 0.05f)
        {
            transform.position = A.position;
            tRender.Clear();
        }

    }
}
