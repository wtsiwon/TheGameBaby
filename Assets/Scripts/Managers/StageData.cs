using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageData : SingletonDDOL<StageData>
{
    [SerializeField]
    private StageScene stagedata;
    [SerializeField]
    private Image[] slots;
    [SerializeField]
    private Image words;
    [SerializeField]
    private Image coWords;
    [SerializeField]
    private Image ground;
    
    /// <summary>
    ///스테이지에 맞는 사진으로 바꿔주는 함수
    /// </summary>
    /// <param name="stagenum">Stage</param>
    public void LoadStage(int stageNum)
    {
        slots[0].sprite = stagedata.stages[stageNum - 1].steps[0].slot1;
    }
}
