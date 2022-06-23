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
    public void LoadStage(int stagenum)
    {
        slots[0].sprite = stagedata.stages[stagenum].slot1;
        slots[1].sprite = stagedata.stages[stagenum].slot2;
        slots[2].sprite = stagedata.stages[stagenum].slot3;

        words.sprite = stagedata.stages[stagenum].word;
        coWords.sprite = stagedata.stages[stagenum].coword;
        ground.sprite = stagedata.stages[stagenum].ground;
    }
}
