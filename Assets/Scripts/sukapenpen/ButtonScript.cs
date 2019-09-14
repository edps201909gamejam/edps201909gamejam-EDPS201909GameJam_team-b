using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void LoadStageSelect()
    {
        SceneSelectManager.Instance.ChangeStageSelect();
    }

    public void LoadStage1()
    {
        SceneSelectManager.Instance.ChangeStage1Scene();
    }
    
    public void LoadStage2()
    {
        SceneSelectManager.Instance.ChangeStage2Scene();
    }
    
    public void LoadStage3()
    {
        SceneSelectManager.Instance.ChangeStage3Scene();
    }

    public void Restart()
    {
        SceneSelectManager.Instance.GameRestart();
    }

    public void ExState()
    {
        SceneSelectManager.Instance.NextEx();
    }

    public void LoadTitle()
    {
        SceneSelectManager.Instance.ChangeTitleScene();
    }

}
