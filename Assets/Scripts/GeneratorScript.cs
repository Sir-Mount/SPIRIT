using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GeneratorScript : MonoBehaviour
{

    public Transform attachmentPoint;
    public Material generatorColor;

    public GameObject model;
    
    void Start() {
        var matArray = model.GetComponent<MeshRenderer>().materials;
        matArray[4] = generatorColor;
        model.GetComponent<MeshRenderer>().materials = matArray;
    }

    void Update() {
        
    }
}
