using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExStatus : GameStatus
{
    //private GameObject 
    public ExStatus()
    {
        UIManager.Instance.AppearMission();
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
