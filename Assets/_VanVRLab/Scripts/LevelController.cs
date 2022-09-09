using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{


    public GameObject[] cases;
    bool inputY;

    public void SelectCase(int selection)
    {
        DisableAllCases();
        if (selection == -1) return;
        cases[selection].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            inputY = !inputY;
            DisableAllCases();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DisableAllCases();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DisableAllCases();
            cases[0].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DisableAllCases();
            cases[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DisableAllCases();
            cases[2].SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            DisableAllCases();
            cases[3].SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            DisableAllCases();
            cases[4].SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            DisableAllCases();
            cases[5].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            DisableAllCases();
            cases[6].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            DisableAllCases();
            cases[7].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            DisableAllCases();
            cases[8].SetActive(true);
        }
    }


    private void DisableAllCases()
    {
        for(int i = 0; i < cases.Length; i++) cases[i].SetActive(false);
    }


}
