using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartLabControl : MonoBehaviour
{

    public GameObject lab, tutorial;


    void TeleportToLab()
    {
        tutorial.SetActive(false);
        lab.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.collider.name);
        if (collision.collider.name == "Bakery")
        {
            TeleportToLab();
        }
    }
}
