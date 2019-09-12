using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartCount : GameStatus
{
    private float initCount = 4.0f;
    
    public override void Reset()
    {
        this.elapsedTime = initCount;
    }
    
    public override GameStatus Run(float _time)
    {
        this.elapsedTime -= _time;
        if (this.elapsedTime < 0.0f)
        {
            return new GamePlaying();
        }
        return this;
    }
}
