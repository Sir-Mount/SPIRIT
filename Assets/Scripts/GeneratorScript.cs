using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class GeneratorScript : MonoBehaviour
{

    public Transform attachmentPoint;
    public Material generatorColor;
    public GameObject model;

    public float envEffectiveness;
    public float outputAmount;
    
    void Start() {
        var matArray = model.GetComponent<MeshRenderer>().materials;
        matArray[4] = generatorColor;
        model.GetComponent<MeshRenderer>().materials = matArray;
    }

    void Update() {
        calculateEffectiveness();
        updateOutput();
    }

    private void updateOutput() {
        outputAmount = 1f;
    }

    private void calculateEffectiveness() {
        // todo: implement
        envEffectiveness = 1f;
    }

    [ContextMenu("Attach Hose")]
    private void AttachHose() {
        print("Hose is attached!");
    }
}
