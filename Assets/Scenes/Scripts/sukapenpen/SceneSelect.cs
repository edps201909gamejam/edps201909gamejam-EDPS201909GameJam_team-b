using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : SingletonMonoBehaviour<SceneSelect>
{
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
}
