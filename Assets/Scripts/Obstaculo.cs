using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        this.transform.Translate(Vector3.left * 0.05f);
    }
}
