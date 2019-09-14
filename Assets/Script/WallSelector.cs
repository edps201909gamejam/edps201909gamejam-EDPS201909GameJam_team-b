using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSelector : MonoBehaviour
{
    bool isSelecting = false;
    Collider selecting;

    public Material doorMaterial;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider hit) {
        if (hit.CompareTag("Wall") && !isSelecting && hit.transform.parent.CompareTag("Untagged")) {
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

    private void Update() {
        string opposite = "";
        Transform parent = selecting.transform.parent;
        if (Input.GetKey(KeyCode.Space) && parent.CompareTag("Untagged")) {
            if (selecting.name == "N") {
                opposite = "S";
                parent.tag = "TateBlock";
            }
            else if(selecting.name == "S") {
                opposite = "N";
                parent.tag = "TateBlock";
            }
            else if (selecting.name == "E") {
                opposite = "W";
                parent.tag = "YokoBlock";
            }
            else if(selecting.name == "W") {
                opposite = "E";
                parent.tag = "YokoBlock";
            }
            selecting.gameObject.tag = "DoorWall";
            selecting.gameObject.GetComponent<Renderer>().sharedMaterial = doorMaterial;
            Debug.Log(selecting.transform.root);
            parent.transform.Find(opposite).gameObject.tag = "DoorWall";
            parent.transform.Find(opposite).gameObject.GetComponent<Renderer>().sharedMaterial = doorMaterial;
            isSelecting = false;
            selecting = null;
        }
    }
}
