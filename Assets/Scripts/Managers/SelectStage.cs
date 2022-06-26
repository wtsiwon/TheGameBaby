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
    private Image[] stageLock;

    private void Start()
    {
        Stage();
    }
    /// <summary>
    /// 스테이지 버튼들이 모여 있는 함수
    /// </summary>
    private void Stage()
    {
        stageBtn[0].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            GameManager.Instance.Stage = 0;
        });
        stageBtn[1].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            GameManager.Instance.Stage = 1;
        });
        stageBtn[2].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            GameManager.Instance.Stage = 2;
        });
        stageBtn[3].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            GameManager.Instance.Stage = 3;
        });
        stageBtn[4].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            GameManager.Instance.Stage = 4;
        });
        stageBtn[5].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            GameManager.Instance.Stage = 5;
        });
        stageBtn[6].onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage");
            GameManager.Instance.Stage = 6;
        });
    }
    private void Active()
    {
        if (GameManager.Instance.Stage >= 4)
        {

        }
        else if(GameManager.Instance.Stage >= 3)
        {

        }
    }
}