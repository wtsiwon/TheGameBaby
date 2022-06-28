using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageData : SingletonDDOL<StageData>
{
    [SerializeField]
    private StageScene[] stagedata;

    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private GameObject[] slots;
    [SerializeField]
    private GameObject words;
    [SerializeField]
    private GameObject coWords;

    [SerializeField]
    private Image ground;

    

    /// <summary>
    ///스테이지에 맞는 사진으로 바꿔주는 함수
    /// </summary>
    /// <param name="stagenum">Stage</param>
    /// <param name="step">단계</param>
    public void LoadStage(int stageNum, int step)
    {
        ground.sprite = stagedata[stageNum].ground;
        for (int i = 0; i < 3; i++)
        {
            var obj = Instantiate(stagedata[stageNum].steps[step].slot[i]);
            obj.transform.parent = slots[i].transform;
        }
        coWords.transform.SetParent(Instantiate(stagedata[stageNum].steps[step].coword).transform);
        
        words = stagedata[stageNum].steps[step].word;
    }
}
