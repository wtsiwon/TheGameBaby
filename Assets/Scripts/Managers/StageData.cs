using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageData : SingletonDDOL<StageData>
{
    [SerializeField]
    private StageScene[] stagedata;

    [SerializeField]
    private Transform[] slots;
    [SerializeField]
    private Transform words;
    [SerializeField]
    private Transform coWords;

    [SerializeField]
    private Image ground;

    private void Start()
    {
        LoadStage(GameManager.Instance.Stage,GameManager.Instance.Step);
    }

    /// <summary>
    ///스테이지에 맞는 사진으로 바꿔주는 함수
    /// </summary>
    /// <param name="stagenum">Stage</param>
    /// <param name="step">단계</param>
    public void LoadStage(int stageNum, int step)
    {
        if (stageNum == 0 && step > 2 || stageNum > 0 && step > 4)
        {
            SceneManager.LoadScene("SelectStage");
        }
        
        ground.sprite = stagedata[stageNum].ground;
        for (int i = 0; i < 3; i++)
        {
            Instantiate(stagedata[stageNum].steps[step].slot[i],slots[i].transform);
        }
        Instantiate(stagedata[stageNum].steps[step].coword,coWords.transform);
        stagedata[stageNum].steps[step].coword.SetActive(false);

        Instantiate(stagedata[stageNum].steps[step].word,words.transform);
    }
}
