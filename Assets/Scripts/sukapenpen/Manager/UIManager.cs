using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : SingletonMonoBehaviour<UIManager>
{
    private Text startCount;
    
    private Text gameTime;
    private Text tresures;
    private Text doors;

    private void Awake()
    {
        startCount = GameObject.Find("StartCount").GetComponent<Text>();
        startCount.gameObject.SetActive(true);
        
        tresures = GameObject.Find("TresureCount").GetComponent<Text>();
        doors = GameObject.Find("DoorCount").GetComponent<Text>();
        gameTime = GameObject.Find("GameTime").GetComponent<Text>();
    }

    public void Reset(int _availableDoors)
    {
        startCount.gameObject.SetActive(true);
        tresures.text = "×0";
        doors.text = "×" + _availableDoors.ToString();
        gameTime.text = "00:00:00";
    }

    public void WriteStartCount(float _startTime)
    {
        if (_startTime < 0.0f)
        {
            startCount.gameObject.SetActive(false);
        }

        if (_startTime < 1.0f)
        {
            startCount.text = "GO!";
        }
        else
        {
            startCount.text = Math.Floor(_startTime).ToString();
        }
    }

    public void WriteTresureCount(int _count)
    {
        tresures.text = _count.ToString();
    }
    
    public void WriteDoorCount(int _count)
    {
        doors.text = _count.ToString();
    }

    public void WriteGameTime(string _gameTime)
    {
        gameTime.text = _gameTime;
    }
}
