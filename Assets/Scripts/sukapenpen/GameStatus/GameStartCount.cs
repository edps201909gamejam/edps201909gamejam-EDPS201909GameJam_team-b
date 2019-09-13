using System;
using UnityEngine;
using UnityEngine.UI;

public class GameStartCount : GameStatus
{
    private float initCount = 4.0f;

    public GameStartCount()
    {
        this.elapsedTime = initCount;
    }
    
    public override GameStatus Run(float _time, int _doors = 0)
    {
        this.elapsedTime -= _time;
        UIManager.Instance.WriteStartCount(this.elapsedTime);
        if (this.elapsedTime < 0.0f)
        {
            return new GamePlaying();
        }

        return this;
    }
}
