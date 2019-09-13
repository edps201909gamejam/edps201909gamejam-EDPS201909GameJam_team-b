using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecomplete : MonoBehaviour
{
    public float speed = 0.01f;
    public float turn = 5;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed;
           
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, turn, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -1*turn, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed;
        }


    }
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Item"))
        {

            // 何らかの処理
            count = count + 1;
        }
    }
   

}
