using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectManager : SingletonMonoBehaviour<SceneSelectManager>
{
    //頭の悪い実装
    
    private void Awake()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
    }

    public void ChangeStageSelect()
    {
        SceneManager.LoadScene("StageSelectScene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("TitleScene");
    }

    public void ChangeStage1Scene()
    {
        SceneManager.LoadScene("Stage1Scene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("StageSelectScene");
    }
    
    public void ChangeStage2Scene()
    {
        SceneManager.LoadScene("Stage2Scene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("StageSelectScene");
    }
    
    public void ChangeStage3Scene()
    {
        SceneManager.LoadScene("Stage3Scene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("StageSelectScene");
    }

    public void GameRestart()
    {
        StageManager.Instance.Reset();
    }

    public void NextEx()
    {
        StageManager.Instance.NextEx();
    }

    public void ChangeTitleScene()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
    }
}
