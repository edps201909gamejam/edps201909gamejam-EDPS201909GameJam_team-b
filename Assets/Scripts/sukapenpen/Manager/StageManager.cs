using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageManager : SingletonMonoBehaviour<StageManager>
{
    [SerializeField]
    private int availableDoors;

    [SerializeField]
    private int mustItems;
    
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
        gameStatus = gameStatus.NextEx();
    }

    public void ClearJudge(int _itemCount)
    {
        if (_itemCount > mustItems)
        {
            gameStatus = new ClearStatus(GameTime(gameStatus.elapsedTime));
        }
    }
    
    private string GameTime(float _elapsedTime)
    {
        var minutes = ((int)_elapsedTime / 60).ToString("00");
        var seconds = Math.Floor(_elapsedTime).ToString("00");
        var underSeconds = Math.Floor(_elapsedTime % 1 * 100).ToString("00");
        var time = minutes + ":" + seconds + ":" + underSeconds;
        
        return time;
    }
    
}
