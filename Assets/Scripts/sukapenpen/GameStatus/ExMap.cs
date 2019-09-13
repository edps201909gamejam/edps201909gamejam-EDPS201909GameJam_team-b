using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExMap : GameStatus
{
    public ExMap()
    {
        UIManager.Instance.AppearMapEx();
    }

    public override GameStatus Run(float _time, int _doors, GameObject _player)
    {
        return this;
    }
    
    public override GameStatus NextEx()
    {
        return new ExSeach();
    }
}
