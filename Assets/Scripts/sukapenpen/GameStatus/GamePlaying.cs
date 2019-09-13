using System;
using UnityEngine;
using UnityEngine.UI;


public class GamePlaying : GameStatus
{

    public GamePlaying()
    {
        this.elapsedTime = 0.0f;
    }
    
    public override GameStatus Run(float _time, int _doors, GameObject _player)
    {
        this.elapsedTime += _time;
        UIManager.Instance.WriteGameTime(GameTime());
        return this;
    }

    private string GameTime()
    {
        var minutes = ((int)this.elapsedTime / 60).ToString("00");
        var seconds = Math.Floor(this.elapsedTime).ToString("00");
        var underSeconds = Math.Floor(this.elapsedTime % 1 * 100).ToString("00");
        var time = minutes + ":" + seconds + ":" + underSeconds;
        
        return time;
    }
    
    
    
    public override GameStatus NextEx()
    {
        return this;
    }
    
    
}
