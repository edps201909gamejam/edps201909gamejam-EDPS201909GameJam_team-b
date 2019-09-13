using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

    string opposite = "";

    void OnTriggerEnter(Collider hit) {
        if (hit.CompareTag("DoorWall")) {
            hit.gameObject.SetActive(false);
            if (hit.name == "N") {
                opposite = "S";
            }
            else if (hit.name == "S") {
                opposite = "N";
            }
            else if (hit.name == "E") {
                opposite = "W";
            }
            else if (hit.name == "W") {
                opposite = "E";
            }
            hit.transform.parent.transform.Find(opposite).gameObject.SetActive(false);
        }
    }
}
