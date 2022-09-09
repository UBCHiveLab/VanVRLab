using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Annotation : MonoBehaviour
{
    public TextMeshProUGUI annotationText;
    public string annotationName = "Heart annotation";



    private void Awake()
    {
        annotationText = GameObject.Find("AnnotationTextmesh").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AnnotationPointer")
        {
            annotationText.text = annotationName;
        }


    }

}
