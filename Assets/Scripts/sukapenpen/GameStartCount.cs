using System;
using UnityEngine;
using UnityEngine.UI;

public class GameStartCount : GameStatus
{    
    private Text startCount;
    private float initCount = 4.0f;

    public GameStartCount()
    {
        startCount = GameObject.Find("StartCount").GetComponent<Text>();
        startCount.gameObject.SetActive(true);
        this.elapsedTime = initCount;
    }
    
    public override GameStatus Run(float _time)
    {
        this.elapsedTime -= _time;
        if (this.elapsedTime < 0.0f)
        {
            startCount.gameObject.SetActive(false);
            return new GamePlaying();
        }

        if (this.elapsedTime < 1.0f)
        {
            startCount.text = "GO!";
        }
        else
        {
            startCount.text = Math.Floor(this.elapsedTime).ToString();
        }
        return this;
    }
}
