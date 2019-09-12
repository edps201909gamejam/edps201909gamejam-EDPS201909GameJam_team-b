using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void LoadStageSelect()
    {
        SceneSelect.Instance.ChangeStageSelect();
    }

    public void LoadStage1()
    {
        SceneSelect.Instance.ChangeStage1Scene();
    }

}
