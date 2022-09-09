
using UnityEngine;
using UnityEngine.UI;

public class MapImageSelector : MonoBehaviour
{
    public GameObject pilot1, pilot2, pilot3, pilot4;
    public int selectorIndex;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            DisableAllMap();

            switch (selectorIndex)
            {
                case 1:
                    pilot1.SetActive(true);
                    break;
                case 2:
                    pilot2.SetActive(true);
                    break;
                case 3:
                    pilot3.SetActive(true);
                    break;
                case 4:
                    pilot4.SetActive(true);
                    break;

                case 5:
                    //just disable all
                    break;

            }
        }
    }



    private void DisableAllMap()
    {
        pilot1.SetActive(false);
        pilot2.SetActive(false);
        pilot3.SetActive(false);
        pilot4.SetActive(false);
    }
}
