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
                switch (i)
                {
                    case 0:
                        SceneManager.LoadScene("Stage 0");
                        break;
                    case 1:
                        SceneManager.LoadScene("Stage 1");
                        break;
                    case 2:
                        SceneManager.LoadScene("Stage 2");
                        break;
                    case 3:
                        SceneManager.LoadScene("Stage 3");
                        break;
                    case 4:
                        SceneManager.LoadScene("Stage 4");
                        break;
                    case 5:
                        SceneManager.LoadScene("Stage 5");
                        break;
                    case 6:
                        SceneManager.LoadScene("Stage 6");
                        break;
                }
            });
        }
    }
}
