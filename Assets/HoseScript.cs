using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoseScript : MonoBehaviour {
    public GameObject startPoint;
    public GameObject endPoint;

    private ArrayList _hosePoints;

    public void SetStartPoint(Transform loc) {
        startPoint.transform.position = loc.position;
    }
    
    public void SetEndPoint(Transform loc) {
        endPoint.transform.position = loc.position;
    }
}
