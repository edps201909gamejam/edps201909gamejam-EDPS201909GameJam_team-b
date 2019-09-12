using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameStatus gameStatus;
    
    private void Awake()
    {
        gameStatus = new GameStartCount();
        gameStatus.Reset();
    }

    private void Update()
    {
        gameStatus = gameStatus.Run(Time.deltaTime);
        Debug.Log(gameStatus.elapsedTime);
    }
}
