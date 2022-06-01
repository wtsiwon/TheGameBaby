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
        for (int i = 0; i < stageBtn.Length; i++)
        {
            stageBtn[i].onClick.AddListener(() =>
            {
                SceneManager.LoadScene(i);
            });
        }
    }
}
