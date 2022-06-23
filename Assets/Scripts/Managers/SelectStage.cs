using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{
    [SerializeField]
    private Button[] stageBtn;

    private void Start()
    {
        Stage();
    }

    private void Stage()
    {
        stageBtn[0].onClick.AddListener(() =>
        {
            StageData.Instance.LoadStage(0);
        });
        stageBtn[1].onClick.AddListener(() =>
        {
            StageData.Instance.LoadStage(1);
        });
        stageBtn[2].onClick.AddListener(() =>
        {
            StageData.Instance.LoadStage(2);
        });
        stageBtn[3].onClick.AddListener(() =>
        {
            StageData.Instance.LoadStage(3);
        });
        stageBtn[4].onClick.AddListener(() =>
        {
            StageData.Instance.LoadStage(4);
        });
        stageBtn[5].onClick.AddListener(() =>
        {
            StageData.Instance.LoadStage(5);
        });



    }
}
