using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStatus : GameStatus
{
    public string clearTime { get; private set; }
    
    public ClearStatus(string _clearTime)
    {
        this.clearTime = _clearTime;
    }
    
    public override GameStatus Run(float _time, int _doors, GameObject _player)
    {
        return this;
    }
    
    public override GameStatus NextEx()
    {
        return this;
    }
}
