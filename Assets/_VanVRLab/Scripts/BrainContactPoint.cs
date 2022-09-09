using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainContactPoint : MonoBehaviour
{

    public int caseIndex = 0; //0 to 8 (for cases 1 to 9)
    public FlowEffect particleEffect;
    LevelController _levelController;


    private void Awake()
    {
        _levelController = GameObject.Find("Level").GetComponent<LevelController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "OVRHandPrefab")
        {
            print("touched by hand");
            _levelController.SelectCase(caseIndex);
            GetComponent<MeshRenderer>().enabled = true;
            if (particleEffect != null) particleEffect.gameObject.SetActive(false);
        }

        
    }



    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "OVRHandPrefab")
        {
            GetComponent<MeshRenderer>().enabled = false;
            if (particleEffect != null)  particleEffect.gameObject.SetActive(true);
        }
    }
}
