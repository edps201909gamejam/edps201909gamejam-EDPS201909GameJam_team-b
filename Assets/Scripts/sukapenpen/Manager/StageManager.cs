using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : SingletonMonoBehaviour<StageManager>
{
    [SerializeField]
    private int availableDoors;
    
    private GameStatus gameStatus;
        
    private void Awake()
    {
        gameStatus = new GameReset();
    }

    private void Update()
    {
        gameStatus = gameStatus.Run(Time.deltaTime, availableDoors);
    }

    public void Reset()
    {
        gameStatus = new GameReset();
    }
}
