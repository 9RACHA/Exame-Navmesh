using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivo : MonoBehaviour {
    
    [Range(0,1)]
    public int mouseButtonIndex = 0;

    void Update() {
        if (Input.GetMouseButtonDown(mouseButtonIndex)) {
            RaycastHit hitData;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitData, 1000)) {
                transform.position = hitData.point;
            }
        }
    }
}

