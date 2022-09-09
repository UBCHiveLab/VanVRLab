using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facecam : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform.position);
        transform.Rotate(0, 180f, 0);
    }
}
