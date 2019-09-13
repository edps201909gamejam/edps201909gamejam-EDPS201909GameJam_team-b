using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReset : GameStatus
{
    public override GameStatus Run(float _time, int _doors, GameObject _player)
    {
        UIManager.Instance.Reset(_doors);
        MapLoader.Instance.Reset();
        GameObject.Find("Player").GetComponent<Movecomplete>().Reset(_doors);
        return new GameStartCount();
    }
    
    public override GameStatus NextEx()
    {
        return this;
    }
}
