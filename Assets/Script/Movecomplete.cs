﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Movecomplete : MonoBehaviour
{
    public float speed = 0.01f;
    public float turn = 5;
    public int count;

    [SerializeField]
    public int scoreCount { get; private set; }

    public int DoorCount;

    // Start is called before the first frame update
    void Start()
    {
        //count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /* 
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
        */

        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");

        transform.position += dy * transform.forward * speed;
        transform.Rotate(0, dx * turn, 0);

    }
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Item"))
        {

            // 何らかの処理
            count = count + 1;
            UIManager.Instance.WriteTresureCount(count);
            StageManager.Instance.ClearJudge(count);
        }
    }

    public void Reset(int _availableDoors)
    {
        scoreCount = 0;
        DoorCount = _availableDoors;
        UIManager.Instance.WriteDoorCount(DoorCount);
    }

    public void DeDoor()
    {
        DoorCount -= 1;
        UIManager.Instance.WriteDoorCount(DoorCount);
    }
    
    //Playerの初期化、リザルトまでデータを持っていく
    
    

}
