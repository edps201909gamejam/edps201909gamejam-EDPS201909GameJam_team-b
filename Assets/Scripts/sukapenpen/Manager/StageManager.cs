using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : SingletonMonoBehaviour<StageManager>
{
    [SerializeField]
    private int availableDoors;
    
    private GameStatus gameStatus;

    private GameObject player;
        
    private void Awake()
    {
        gameStatus = new ExMission();
        player = GameObject.Find("Player");
        
    }

    private void Update()
    {
        gameStatus = gameStatus.Run(Time.deltaTime, availableDoors, player);
    }

    public void Reset()
    {
        gameStatus = new GameReset();
    }

    public void NextEx()
    {
        Debug.Log("3");
        gameStatus = gameStatus.NextEx();
    }
    
}
