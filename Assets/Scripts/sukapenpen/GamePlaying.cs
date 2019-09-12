using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaying : GameStatus
{
    public override void Reset()
    {
        this.elapsedTime = 0.0f;
    }
    
    public override GameStatus Run(float _time)
    {
        this.elapsedTime += _time;
        return this;
    }
}
