using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : SingletonMonoBehaviour<UIManager>
{
    private GameObject[] explanation;

    private GameObject ExButton;
    private Text ExButtonText;
    
    private Text startCount;
    
    private Text gameTime;
    private Text tresures;
    private Text doors;

    private Text clearTime;

    private void Awake()
    {
        explanation = new GameObject[3];
        SetEx();
        ExButton = GameObject.Find("ExButton");
        ExButtonText = GameObject.Find("ExButtonText").GetComponent<Text>();
        startCount = GameObject.Find("StartCount").GetComponent<Text>();
        startCount.gameObject.SetActive(true);
        
        tresures = GameObject.Find("TresureCount").GetComponent<Text>();
        doors = GameObject.Find("DoorCount").GetComponent<Text>();
        gameTime = GameObject.Find("GameTime").GetComponent<Text>();
    }

    private void SetEx()
    {
        explanation[0] = GameObject.Find("Mission");
        explanation[1] = GameObject.Find("MapExplanation");
        explanation[2] = GameObject.Find("SeachExplanation");
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

    public void AppearMission()
    {
        explanation[0].SetActive(true);
        explanation[1].SetActive(false);
        explanation[2].SetActive(false);
        ExButtonText.GetComponent<Text>().text = "次へ";
        ExButton.SetActive(true);
    }
    
    public void AppearMapEx()
    {
        explanation[0].SetActive(false);
        explanation[1].SetActive(true);
        explanation[2].SetActive(false);
    }
    
    public void AppearSeachEx()
    {
        explanation[0].SetActive(false);
        explanation[1].SetActive(false);
        explanation[2].SetActive(true);
        ExButtonText.GetComponent<Text>().text = "ゲームスタート！";
    }

    public void DisAppEx()
    {
        for (int i = 0; i < explanation.Length; i++)
        {
            explanation[i].SetActive(false);
        }
        ExButton.SetActive(false);
    }
}
