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
        if(GameManager.Instance.Stage > 0)
        {
            stageLock[1].gameObject.SetActive(false);
        }
        if (GameManager.Instance.Stage > 1)
        {
            stageLock[2].gameObject.SetActive(false);
        }
        if (GameManager.Instance.Stage > 2)
        {
            stageLock[3].gameObject.SetActive(false);
        }
        if (GameManager.Instance.Stage > 3)
        {
            stageLock[4].gameObject.SetActive(false);
        }
        //if (GameManager.Instance.Stage > 4)
        //{
        //    stageLock[5].gameObject.SetActive(false);
        //}

    }
    /// <summary>
    /// �������� ��ư���� �� �ִ� �Լ�
    /// </summary>
    private void Stage()
    {
        //for (int i = 0; i < 5; i++)
        //{
        //    stageBtn[i].onClick.AddListener(() =>
        //    {
        //        SceneManager.LoadScene("Stage");
        //        GameManager.Instance.Stage = i;
        //    });
        //}
        #region ��ư
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
        //stageBtn[5].onClick.AddListener(() =>
        //{
        //    SceneManager.LoadScene("Stage");
        //    GameManager.Instance.Stage = 5;
        //});
        //stageBtn[6].onClick.AddListener(() =>
        //{
        //    SceneManager.LoadScene("Stage");
        //    GameManager.Instance.Stage = 6;
        //});
        #endregion
    }
}