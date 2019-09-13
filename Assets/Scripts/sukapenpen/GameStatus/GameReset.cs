using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReset : GameStatus
{
    public override GameStatus Run(float _time, int _doors)
    {
        UIManager.Instance.Reset(_doors);
        MapLoader.Instance.Reset();
        GameObject.Find("Player").GetComponent<Movecomplete>().Reset(_doors);
        return new GameStartCount();
    }
}
