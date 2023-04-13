using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class CartScript : MonoBehaviour {
    public GameObject ChargerPointsParent;
    
    public GameObject ChargerStandin;
    public GameObject Charger;

    public int ChargerAmount = 3;
    
    public void Start() {
        int numChildren = ChargerPointsParent.transform.childCount;

        for (int i = 0; i < numChildren; i++){
            Transform childTransform = ChargerPointsParent.transform.GetChild(i);

            GameObject prefab = null;
            if(i < ChargerAmount) prefab = Charger;
            else prefab = ChargerStandin;
            
            Instantiate(prefab, childTransform);
        }
    }
}
