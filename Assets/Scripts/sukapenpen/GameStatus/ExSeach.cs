using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExSeach : GameStatus
{
    public ExSeach()
    {
        UIManager.Instance.AppearSeachEx();
    }

    public override GameStatus Run(float _time, int _doors, GameObject _player)
    {
        return this;
    }
    
    public override GameStatus NextEx()
    {
        UIManager.Instance.DisAppEx();
        return new GameStartCount();
    }
}
