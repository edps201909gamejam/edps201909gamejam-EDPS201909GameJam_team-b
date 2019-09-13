using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSelector : MonoBehaviour
{
    bool isSelecting = false;
    Collider selecting;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider hit) {
        if (hit.CompareTag("Wall") && !isSelecting) {
            if (selecting) {
                selecting.gameObject.GetComponent<Renderer>().material.color = Color.white;
            }
            isSelecting = true;
            hit.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            selecting = hit;
        }
    }
    void OnTriggerExit(Collider hit) {
        if (hit == selecting && hit.CompareTag("Wall")) {
            isSelecting = false;
            selecting = null;
            hit.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
