using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{
    [SerializeField]
    private Button[] stageBtn;
    [SerializeField]
    private Button tutorial;

    private void Start()
    {
        Stage();
    }
    /// <summary>
    /// 스테이지 버튼들이 모여 있는 함수
    /// </summary>
    private void Stage()
    {
        tutorial.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Tutorial");
        });
        stageBtn[0].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            StageData.Instance.LoadStage(0);
        });
        stageBtn[1].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            StageData.Instance.LoadStage(1);
        });
        stageBtn[2].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            StageData.Instance.LoadStage(2);
        });
        stageBtn[3].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            StageData.Instance.LoadStage(3);
        });
        stageBtn[4].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            StageData.Instance.LoadStage(4);
        });
        stageBtn[5].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            StageData.Instance.LoadStage(5);
        });
    }
}