using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExMission : GameStatus
{
    public ExMission()
    {
        UIManager.Instance.AppearMission();
    }

    public override GameStatus Run(float _time, int _doors, GameObject _player)
    {
        return this;
    }

    public override GameStatus NextEx()
    {
        return new ExMap();
    }
}
