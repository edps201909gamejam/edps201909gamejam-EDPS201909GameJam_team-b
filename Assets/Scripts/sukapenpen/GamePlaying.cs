using System;
using UnityEngine;
using UnityEngine.UI;


public class GamePlaying : GameStatus
{
    private Text gameTime;

    public GamePlaying()
    {
        gameTime = GameObject.Find("GameTime").GetComponent<Text>();
        gameTime.text = "00:00:00";
        this.elapsedTime = 0.0f;
    }
    
    public override GameStatus Run(float _time)
    {
        this.elapsedTime += _time;
        gameTime.text = GameTime();
        return this;
    }

    private String GameTime()
    {
        var minutes = ((int)this.elapsedTime / 60).ToString("00");
        var seconds = Math.Floor(this.elapsedTime).ToString("00");
        var underSeconds = Math.Floor(this.elapsedTime % 1 * 100).ToString("00");
        var time = minutes + ":" + seconds + ":" + underSeconds;
        
        return time;
    }
}
